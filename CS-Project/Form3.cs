using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS_Project
{
    public partial class Form3 : Form 
    { 
        public Form3()
        {
            InitializeComponent();

            this.FormClosing += Form3_FormClosing;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTout.Checked)
            {
                checkBoxAP.Checked = false;
                checkBoxAE.Checked = false;
            }
        }

        private void checkBoxAP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAP.Checked)
            {
                checkBoxTout.Checked = false;
                checkBoxAE.Checked = false;
            }
        }

        private void checkBoxAE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAE.Checked)
            {
                checkBoxTout.Checked = false;
                checkBoxAP.Checked = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = "Server=localhost ; Database=menageleccsharp ; User=root;";
            string query = "SELECT idProduit, idCommande, quantite FROM lignecommande";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idCommande = reader.GetInt32(reader.GetOrdinal("idCommande"));
                    int idProduit = reader.GetInt32(reader.GetOrdinal("idProduit"));
                    int quantite = reader.GetInt32(reader.GetOrdinal("quantite"));

                    // Do something with the retrieved values
                    Console.WriteLine($"idCommande: {idCommande}, idProduit: {idProduit}, quantite: {quantite}");
                }

                DataTable dataTable = new DataTable();
                dataTable.Load(reader); // This will load the SqlDataReader data into the DataTable

                reader.Close();

                connection.Close();

                // Now you can use the dataTable for further processing or display
                // Example: Printing data from the DataTable
                
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine($"idCommande: {row["idCommande"]}, idProduit: {row["idProduit"]}, quantite: {row["quantite"]}");
                }
            }
        }
        private static void ReadOrderData(string connectionString)
        {
            string queryString = "SELECT idProduit, idCommande, quantite FROM lignecommande";

            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    //var client = new Client()
                    //{

                    //}
                    //return client;
                }

                // Call Close when done reading.
                reader.Close();
            }
        }

        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            Console.WriteLine(String.Format("{0}, {1}", dataRecord[0], dataRecord[1]));
        }
    }
}
