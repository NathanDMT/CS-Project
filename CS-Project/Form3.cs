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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string connection = "Server=localhost ; Database=menageleccsharp ; User=root;";

            string query = "SELECT idCommande, idProduit, quantite FROM lignecommande";
            SqlDataReader read = new SqlDataReader(query, connection);
            DataTable dataTable = new DataTable();
            while (reader.Read())
            {
                ReadSingleRow((IDataRecord)reader);
            }

            dataGridView1.DataSource = dataTable;

            Console.WriteLine("Nombre de lignes récupérées : " + dataTable.Rows.Count);

            dataGridView1.Columns["idCommande"].HeaderText = "ID Commande";
            dataGridView1.Columns["idProduit"].HeaderText = "ID Produit";
            dataGridView1.Columns["quantite"].HeaderText = "Quantité";


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
    }
}
