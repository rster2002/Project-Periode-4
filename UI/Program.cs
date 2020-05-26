﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try {
                DesktopView desktopView = DesktopView.GetInstance();
                desktopView.LoadView(new LoginView());

                Application.Run(desktopView);
            } catch(Exception error) {
                ErrorView errorView = new ErrorView(error.Message);
                errorView.ShowDialog();
            }
        }
    }
}
