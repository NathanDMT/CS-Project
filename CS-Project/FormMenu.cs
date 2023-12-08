﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Project
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void buttonCommandMenu_Click(object sender, EventArgs e)
        {
            FormGestionCommandes form3 = new FormGestionCommandes();

            form3.Show();

            this.Hide();
        }

        private void labelGestionDesCommandes_Click(object sender, EventArgs e)
        {

        }
    }
}