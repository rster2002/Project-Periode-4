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

        protected Dictionary<string, object> param(string key, object value) {
            sqlParams.Add(key, value.ToString());
            return sqlParams;
        }

        protected string line(string queryLine) {
            queryString += " " + queryLine;
            return queryString;
        }

        protected string query(string queryString) {
            this.queryString = queryString;
            return this.queryString;
        }

        protected void clear() {
            queryString = null;
            sqlParams = new Dictionary<string, object>();
        }

        private void evaluateParameters(SqlCommand command) {
            foreach (KeyValuePair<string, object> parameter in sqlParams) {
                command.Parameters.AddWithValue("@" + parameter.Key, parameter.Value);
            }

            sqlParams = new Dictionary<string, object>();
        }

        protected void executeCommand() => executeCommand(queryString);
        protected void executeCommand(string query) {
            using (SqlConnection sqlConnection = new SqlConnection(config)) {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);

                evaluateParameters(command);

                command.ExecuteNonQuery();

                clear();
            }
        }

        protected List<Record> executeSelect() => executeSelect(queryString);
        protected List<Record> executeSelect(string query) {
            using (SqlConnection sqlConnection = new SqlConnection(config)) {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);

                List<Record> records = new List<Record>();

                evaluateParameters(command);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) {
                    Record record = new Record();
                    record.fieldCount = reader.FieldCount;

                    for (int i = 0; i < reader.FieldCount; i++) {
                        record[reader.GetName(i)] = reader.GetValue(i);
                    }

                    records.Add(record);
                }

                clear();

                return records;
            }
        }

        protected List<Record> executeUnprocessed() => executeUnprocessed(queryString);
        protected List<Record> executeUnprocessed(string query) {
            List<Record> returnValue = new List<Record>();

            if (queryString.Contains("SELECT") && queryString.Contains("FROM")) {
                returnValue = executeSelect(query);
            } else {
                executeCommand(query);
            }

            return returnValue;
        }


        protected List<T> execute() => execute(queryString, processRecord);
        protected List<T> execute(string query) => execute(query, processRecord);
        protected List<T> execute(Func<Record, T> processFunction) => execute(queryString, processFunction);
        protected List<T> execute(string query, Func<Record, T> processFunction) {
            return processRecords(executeUnprocessed(query), processFunction);
        }

        protected List<T> execute(Func<List<Record>, List<T>> recordsProcessor) => execute(queryString, recordsProcessor);
        protected List<T> execute(string query, Func<List<Record>, List<T>> recordsProcessor) {
            return recordsProcessor(executeUnprocessed(query));
        }

        protected virtual List<T> processRecords(List<Record> records, Func<Record, T> processFunction) {
            return records
                .Select(processFunction)
                .ToList();
        }

        protected abstract T processRecord(Record record);
    }

    public class Record:Dictionary<string, object> {
        public int fieldCount;
    }
}
