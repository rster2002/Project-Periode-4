﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI.DesktopViews {
    public partial class LoginView: UserControl {
        private DesktopView mainView = DesktopView.GetInstance();

        public LoginView() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            mainView.LoadView(new TestView());
        }
    }
}
