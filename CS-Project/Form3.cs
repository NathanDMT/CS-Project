using CS_Project.Entity;
using CS_Project.Manager;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

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

                dataGridViewCommandes.ColumnCount = 3;
                dataGridViewCommandes.ColumnHeadersVisible = true;

                dataGridViewCommandes.Columns[0].Name = "idCommande";
                dataGridViewCommandes.Columns[1].Name = "date";
                dataGridViewCommandes.Columns[2].Name = "client";

                Collection<Commande> commandes = CommandeManager.ReadAllCommandes();

                foreach (Commande commande in commandes)
                {
                    dataGridViewCommandes.Rows.Add(commande.idCommande, commande.date, commande.idClient);
                }

                labelNombreElements1.Text = dataGridViewCommandes.Rows.Count.ToString();
            }

            else
            {
                dataGridViewCommandes.Rows.Clear();
                labelNombreElements1.Text = "0".ToString();
            }

        }

        private void checkBoxAP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAP.Checked)
            {
                checkBoxTout.Checked = false;
                checkBoxAE.Checked = false;

                dataGridViewCommandes.ColumnCount = 3;
                dataGridViewCommandes.ColumnHeadersVisible = true;

                dataGridViewCommandes.Columns[0].Name = "idCommande";
                dataGridViewCommandes.Columns[1].Name = "date";
                dataGridViewCommandes.Columns[2].Name = "client";

                Collection<Commande> commandes = CommandeManager.ReadPayableCommandes();

                foreach (Commande commande in commandes)
                {
                    dataGridViewCommandes.Rows.Add(commande.idCommande, commande.date, commande.idClient);
                }

                labelNombreElements1.Text = dataGridViewCommandes.Rows.Count.ToString();
            }

            else
            {
                dataGridViewCommandes.Rows.Clear();
                labelNombreElements1.Text = "0".ToString();
            }
        }

        private void checkBoxAE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAE.Checked)
            {
                checkBoxTout.Checked = false;
                checkBoxAP.Checked = false;

                dataGridViewCommandes.ColumnCount = 3;
                dataGridViewCommandes.ColumnHeadersVisible = true;

                dataGridViewCommandes.Columns[0].Name = "idCommande";
                dataGridViewCommandes.Columns[1].Name = "date";
                dataGridViewCommandes.Columns[2].Name = "client";

                Collection<Commande> commandes = CommandeManager.ReadToShipCommandes();

                foreach (Commande commande in commandes)
                {
                    dataGridViewCommandes.Rows.Add(commande.idCommande, commande.date, commande.idClient);
                }

                labelNombreElements1.Text = dataGridViewCommandes.Rows.Count.ToString();
            }

            else
            {
                dataGridViewCommandes.Rows.Clear();
                labelNombreElements1.Text = "0".ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelCivilitee_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
