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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mediaBazarLogoLogin.BorderStyle = BorderStyle.None;

            // TODO: this is added for debugging now, remove later
            (new CreateAccount()).Show();
        }
    }
}