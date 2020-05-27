﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI {
    public partial class MobileView: Form {
        private static MobileView instance;

        private MobileView() {
            InitializeComponent();
        }

        public static MobileView GetInstance() {
            if (instance == null) instance = new MobileView();
            return instance;
        }

        public void LoadView(UserControl userControl) {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(userControl);
        }
    }
}
