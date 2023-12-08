using System;
using MySql.Data.MySqlClient;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string login = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if ((login == "fournier" && password == "1234") || (login == "hurier" && password == "5678"))
            {
                FormMenu Menu = new FormMenu();
                Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Le mot de passe ou l'identifiant est incorrect!");
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelUtilisateur_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            
        }
    }
}