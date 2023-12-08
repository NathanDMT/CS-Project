using CS_Project.Entity;
using CS_Project.Manager;
using System;
using System.Collections.ObjectModel;
using System.Data;
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

                foreach (Commande commande in GetCommandeWithFilter())
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

                foreach (Commande commande in GetCommandeWithFilter())
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

                foreach (Commande commande in GetCommandeWithFilter())
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

            groupBoxClientInformations.Tag = client;


            // Partie affichage de la commande

            var commandeCellValue = int.TryParse(dataGridViewCommandes.Rows[row.Index].Cells[0].Value.ToString(), out var commandeCellValueOut);
            Commande commande = CommandeManager.Read(commandeCellValueOut);
            labelDateCommande1.Text = commande.date.ToString();

            groupBoxCommandeInformations.Text = "Commande n°" + commande.idCommande.ToString();

            groupBoxCommandeInformations.Tag = commande;


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
            var commande = (Commande)groupBoxCommandeInformations.Tag;
            commande.estPayee = 1;
            CommandeManager.Update(commande);

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
        }

        private void buttonValidExpedition_Click(object sender, EventArgs e)
        {
            var commande = (Commande)groupBoxCommandeInformations.Tag;
            commande.estExpediee = 1;
            CommandeManager.Update(commande);

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
        }
        private void checkBoxRechercheCommande_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRechercheCommande.Checked)
            {
                dataGridViewCommandes.Rows.Clear();
                checkBoxRechercheClient.Checked = false;
                foreach (Commande commande in GetCommandeWithFilter())
                {
                    dataGridViewCommandes.Rows.Add(commande.idCommande, commande.date, commande.idClient);
                }
            }
            else
            {
                dataGridViewCommandes.Rows.Clear();
                labelNombreElements1.Text = "0".ToString();
                foreach (Commande commande in GetCommandeWithFilter())
                {
                    dataGridViewCommandes.Rows.Add(commande.idCommande, commande.date, commande.idClient);
                }
            }
        }

        private void checkBoxRechercheClient_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRechercheClient.Checked)
            {
                dataGridViewCommandes.Rows.Clear();
                checkBoxRechercheCommande.Checked = false;
                foreach (Commande commande in GetCommandeWithFilter())
                {
                    dataGridViewCommandes.Rows.Add(commande.idCommande, commande.date, commande.idClient);
                }
                labelNombreElements1.Text = dataGridViewCommandes.Rows.Count.ToString();
            }
            else
            {
                dataGridViewCommandes.Rows.Clear();
                foreach (Commande commande in GetCommandeWithFilter())
                {
                    dataGridViewCommandes.Rows.Add(commande.idCommande, commande.date, commande.idClient);
                }
                labelNombreElements1.Text = dataGridViewCommandes.Rows.Count.ToString();
            }
        }

        private Collection<Commande> GetCommandeWithFilter()
        {
            CommandeManager.Base basicCommandeSQL = CommandeManager.Base.ALL;
            CommandeManager.Specific filterCommandeSQL = CommandeManager.Specific.NOTHING;
            var id = new int[1];
            
            if (checkBoxTout.Checked)
            {
                basicCommandeSQL = CommandeManager.Base.ALL;
            }

            if (checkBoxAP.Checked)
            {
                basicCommandeSQL = CommandeManager.Base.EST_PAYEE;
            }

            if (checkBoxAE.Checked)
            {
                basicCommandeSQL = CommandeManager.Base.EST_EXPEDIEE;
            }

            if (checkBoxRechercheClient.Checked)
            {
                int.TryParse(textBoxRechercheClient.Text, out id[0]);
                filterCommandeSQL = CommandeManager.Specific.CLIENT;
            }

            if (checkBoxRechercheCommande.Checked)
            {
                int.TryParse(textBoxRechercheCommande.Text, out id[0]);
                filterCommandeSQL = CommandeManager.Specific.COMMANDE;
            }

            return CommandeManager.ReadWithFilters(basicCommandeSQL, filterCommandeSQL, id);
        }
    }
}
