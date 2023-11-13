using System;
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
    public partial class Form2 : Form
    {
        public Form2()
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


        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();

            this.Hide();
        }
    }
}
