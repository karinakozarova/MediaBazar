﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            mediaBazarLogoLogin.BorderStyle = BorderStyle.None;

            // TODO: this is added for debugging now, remove later
            (new AdministratorShiftsOverview()).Show();

            (new SearchForEmployee()).Show();
            (new RemoveManager()).Show();
            (new StockEdit()).Show();
            (new StockView()).Show();

        }

        private void loginBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
