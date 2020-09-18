﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

    
        private void manageHint(TextBox textbox, int eventType,string defaultText)
        {
            string text = textbox.Text;

            if (eventType == 0)
            {
                if (text == "")
                {
                    textbox.Text = defaultText;
                }
            }
            else
            {
                if (text == defaultText)
                {
                    textbox.Clear();
                }
            }

        }



        private void loginIDField_MouseEnter(object sender, EventArgs e)
        {
            manageHint(loginIDField, 1, "Login ID");
        }

        private void loginIDField_MouseLeave(object sender, EventArgs e)
        {
            manageHint(loginIDField, 0, "Login ID");
        }

        private void loginPasswordField_MouseEnter(object sender, EventArgs e)
        {
            manageHint(loginPasswordField,1, "Password");
        }

        private void loginPasswordField_MouseLeave(object sender, EventArgs e)
        {
            manageHint(loginPasswordField, 0, "Password");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
