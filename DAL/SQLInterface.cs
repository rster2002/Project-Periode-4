using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;

namespace DAL {
    public abstract class SQLInterface<T> {
        private string config = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        private string queryString;

        private Dictionary<string, object> sqlParams = new Dictionary<string, object>();

        protected Dictionary<string, object> Param(string key, object value) {
            sqlParams.Add(key, value.ToString());
            return sqlParams;
        }

        protected string Line(string queryLine) {
            queryString += " " + queryLine;
            return queryString;
        }

        protected string Query(string queryString) {
            this.queryString = queryString;
            return this.queryString;
        }

        protected void Clear() {
            queryString = null;
            sqlParams = new Dictionary<string, object>();
        }

        private void EvaluateParameters(SqlCommand command) {
            foreach (KeyValuePair<string, object> parameter in sqlParams) {
                command.Parameters.AddWithValue("@" + parameter.Key, parameter.Value);
            }

            sqlParams = new Dictionary<string, object>();
        }

        protected void ExecuteCommand() => ExecuteCommand(queryString);
        protected void ExecuteCommand(string query) {
            using (SqlConnection sqlConnection = new SqlConnection(config)) {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);

                EvaluateParameters(command);

                command.ExecuteNonQuery();

                Clear();
            }
        }

        protected List<Record> ExecuteSelect() => ExecuteSelect(queryString);
        protected List<Record> ExecuteSelect(string query) {
            using (SqlConnection sqlConnection = new SqlConnection(config)) {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);

                List<Record> records = new List<Record>();

                EvaluateParameters(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) {
                    Record record = new Record();
                    record.fieldCount = reader.FieldCount;

                    for (int i = 0; i < reader.FieldCount; i++) {
                        record[reader.GetName(i)] = reader.GetValue(i);
                    }

                    records.Add(record);
                }

                Clear();

                return records;
            }
        }

        protected List<Record> ExecuteUnprocessed() => ExecuteUnprocessed(queryString);
        protected List<Record> ExecuteUnprocessed(string query) {
            List<Record> returnValue = new List<Record>();

            if (queryString.Contains("SELECT") && queryString.Contains("FROM")) {
                returnValue = ExecuteSelect(query);
            } else {
                ExecuteCommand(query);
            }

            return returnValue;
        }


        protected List<T> Execute() => Execute(queryString, ProcessRecord);
        protected List<T> Execute(string query) => Execute(query, ProcessRecord);
        protected List<T> Execute(Func<Record, T> processFunction) => Execute(queryString, processFunction);
        protected List<T> Execute(string query, Func<Record, T> processFunction) {
            return ProcessRecords(ExecuteUnprocessed(query), processFunction);
        }

        protected List<T> Execute(Func<List<Record>, List<T>> recordsProcessor) => Execute(queryString, recordsProcessor);
        protected List<T> Execute(string query, Func<List<Record>, List<T>> recordsProcessor) {
            return recordsProcessor(ExecuteUnprocessed(query));
        }

        protected virtual List<T> ProcessRecords (List<Record> records, Func<Record, T> processFunction) {
            return records
                .Select(processFunction)
                .ToList();
        }

        protected abstract T ProcessRecord(Record record);
        public abstract List<T> GetAll();
        public abstract T GetById(int id);
    }

    public class Record:Dictionary<string, object> {
        public int fieldCount;
    }
}
