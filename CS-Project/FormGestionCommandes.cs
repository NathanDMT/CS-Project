using CS_Project.Entity;
using CS_Project.Manager;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace CS_Project
{
    public partial class FormGestionCommandes : Form
    {
        public FormGestionCommandes()
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
            FormMenu form2 = new FormMenu();

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

        private void dataGridViewCommandes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCell cell = dataGridViewCommandes.CurrentCell;
            DataGridViewRow row = dataGridViewCommandes.CurrentRow;
   
            // Partie affichage du client

            var clientCellValue = int.TryParse(dataGridViewCommandes.Rows[row.Index].Cells[2].Value.ToString(), out var clientCellValueOut);
            Client client = ClientManager.Read(clientCellValueOut);
            labelCivilitee.Text = client.civilite;
            labelNom.Text = client.nom;
            labelPrenom.Text = client.prenom;
            labelAdresse.Text = client.adresse;
            labelCodePostale.Text = client.cp.ToString();
            labelVille.Text = client.ville;
            labelAdresseMail1.Text = client.mail;
            labelTelephone1.Text = client.tel;

            groupBoxClientInformations.Text = "Client n°" + client.idClient.ToString();


            // Partie affichage de la commande

            var commandeCellValue = int.TryParse(dataGridViewCommandes.Rows[row.Index].Cells[0].Value.ToString(), out var commandeCellValueOut);
            Commande commande = CommandeManager.Read(commandeCellValueOut);
            labelDateCommande1.Text = commande.date.ToString();

            groupBoxCommandeInformations.Text = "Commande n°" + commande.idCommande.ToString();


            // Partie affichage les bouttons de modification des paramètres "estPayee" et "estExpediee"

            if (commande.estPayee == 0)
            {
                pictureBoxPaiementValid.Hide();
                pictureBoxPaiementInvalid.Show();
                buttonValidPaiement.Show();
            } 


            if (commande.estPayee == 1)
            {
                pictureBoxPaiementValid.Show();
                pictureBoxPaiementInvalid.Hide();
                buttonValidExpedition.Show();
                buttonValidPaiement.Hide();
            }


            if (commande.estExpediee == 0)
            {
                pictureBoxExpeditionValid.Hide();
                pictureBoxExpeditionInvalid.Show();
            }


            if (commande.estPayee == 1 && commande.estExpediee == 0)
            {
                buttonValidPaiement.Hide();
                buttonValidExpedition.Show();
            }


            if (commande.estExpediee == 1)
            {
                pictureBoxExpeditionValid.Show();
                pictureBoxExpeditionInvalid.Hide();
                buttonValidExpedition.Hide();
            }

            // Partie affichage du GridView des commandes du même client
            dataGridViewCommandeByOne.Rows.Clear();

            dataGridViewCommandeByOne.ColumnCount = 2;
            dataGridViewCommandeByOne.ColumnHeadersVisible = true;

            dataGridViewCommandeByOne.Columns[0].Name = "Produit commandé";
            dataGridViewCommandeByOne.Columns[1].Name = "Quantité";

            Collection<LigneCommande> ligneCommandes = LigneCommandeManager.ReadAllCommandeByOne(commandeCellValueOut);

            foreach (LigneCommande ligneCommande in ligneCommandes)
            {
                dataGridViewCommandeByOne.Rows.Add(ligneCommande.idProduit, ligneCommande.quantite);
            }
        }

        private void pictureBoxPaiementValid_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxPaiementInvalid_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxExpeditionValid_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxExpeditionInvalid_Click(object sender, EventArgs e)
        {

        }

        private void buttonValidPaiement_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridViewCommandes.CurrentCell;
            DataGridViewRow row = dataGridViewCommandes.CurrentRow;

            var commandeCellValue = int.TryParse(dataGridViewCommandes.Rows[row.Index].Cells[0].Value.ToString(), out int commandeCellValueOut);
            Commande commande = CommandeManager.UpdatePaiementState(commandeCellValueOut);

            Console.WriteLine(commandeCellValue);
            Console.WriteLine(commande);
        }

        private void buttonValidExpedition_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCommandeByOne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
