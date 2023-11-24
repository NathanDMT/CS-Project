using CS_Project.Entity;
using CS_Project.Manager;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace CS_Project
{
    public partial class GestionCommandes : Form
    {
        public GestionCommandes()
        {
            InitializeComponent();

            this.FormClosing += GestionCommandes_Load_FormClosing;
        }

        private void GestionCommandes_Load_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();

            form2.Show();

            this.Hide();
        }

        private void GestionCommandes_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxTout_CheckedChanged(object sender, EventArgs e)
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
        private void groupBoxClientInformations_Enter(object sender, EventArgs e)
        {
            
        }

        private void labelCivilitee_Click(object sender, EventArgs e)
        {
            
        }

        private void labelColisage_Click(object sender, EventArgs e)
        {
            
        }

        private void labelNombreElements1_Click(object sender, EventArgs e)
        {
            
        }

        private void labelNombreElements_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelCivilitee.Text = dataGridViewCommandes.Rows.ToString();
        }

        private void labelGestionDesCommandes_Click(object sender, EventArgs e)
        {
            
        }

        private void labelInformationCommande_Click(object sender, EventArgs e)
        {
            
        }

        private void labelAdresseMail_Click(object sender, EventArgs e)
        {
            
        }
    }
}
