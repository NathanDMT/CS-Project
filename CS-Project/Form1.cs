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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost ; Database=menageleccsharp ; User=root;";

            try
            {
                using (MySqlConnection connexion = new MySqlConnection(connectionString))
                {
                    connexion.Open();

                    string query = $"SELECT * FROM user WHERE login = '{usernameTextBox.Text}' AND password = '{passwordTextBox.Text}'";

                    using (MySqlCommand command = new MySqlCommand(query, connexion))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Form2 form2 = new Form2();

                            form2.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Le mot de passe ou l'identifiant est incorrect!");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine($"Erreur MySQL : {ex.Message}");
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Une erreur s'est produite : {ex.Message}");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}