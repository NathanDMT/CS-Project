namespace CS_Project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuButton = new System.Windows.Forms.Button();
            this.textBoxRechercheClient = new System.Windows.Forms.TextBox();
            this.textBoxRechercheCommande = new System.Windows.Forms.TextBox();
            this.buttonColisage = new System.Windows.Forms.Button();
            this.checkBoxTout = new System.Windows.Forms.CheckBox();
            this.checkBoxAP = new System.Windows.Forms.CheckBox();
            this.checkBoxAE = new System.Windows.Forms.CheckBox();
            this.dataGridViewCommandes = new System.Windows.Forms.DataGridView();
            this.labelNombreElements = new System.Windows.Forms.Label();
            this.labelNombreElements1 = new System.Windows.Forms.Label();
            this.labelClientRecherche = new System.Windows.Forms.Label();
            this.labelRechercheCommande = new System.Windows.Forms.Label();
            this.labelColisage = new System.Windows.Forms.Label();
            this.labelCivilitee = new System.Windows.Forms.Label();
            this.groupBoxClientInformations = new System.Windows.Forms.GroupBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelCodePostale = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelAdresseMail = new System.Windows.Forms.Label();
            this.labelAdresseMail1 = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelTelephone1 = new System.Windows.Forms.Label();
            this.labelListeCommandes = new System.Windows.Forms.Label();
            this.labelInformationCommande = new System.Windows.Forms.Label();
            this.labelRechercheSpecifique = new System.Windows.Forms.Label();
            this.labelGestionDesCommandes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommandes)).BeginInit();
            this.groupBoxClientInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(847, 526);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(85, 42);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Retour au menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // textBoxRechercheClient
            // 
            this.textBoxRechercheClient.Location = new System.Drawing.Point(741, 118);
            this.textBoxRechercheClient.Name = "textBoxRechercheClient";
            this.textBoxRechercheClient.Size = new System.Drawing.Size(191, 20);
            this.textBoxRechercheClient.TabIndex = 7;
            // 
            // textBoxRechercheCommande
            // 
            this.textBoxRechercheCommande.Location = new System.Drawing.Point(741, 186);
            this.textBoxRechercheCommande.Name = "textBoxRechercheCommande";
            this.textBoxRechercheCommande.Size = new System.Drawing.Size(191, 20);
            this.textBoxRechercheCommande.TabIndex = 8;
            // 
            // buttonColisage
            // 
            this.buttonColisage.Location = new System.Drawing.Point(741, 269);
            this.buttonColisage.Name = "buttonColisage";
            this.buttonColisage.Size = new System.Drawing.Size(191, 23);
            this.buttonColisage.TabIndex = 12;
            this.buttonColisage.Text = "Liste de colisage";
            this.buttonColisage.UseVisualStyleBackColor = true;
            // 
            // checkBoxTout
            // 
            this.checkBoxTout.AutoSize = true;
            this.checkBoxTout.Location = new System.Drawing.Point(23, 72);
            this.checkBoxTout.Name = "checkBoxTout";
            this.checkBoxTout.Size = new System.Drawing.Size(48, 17);
            this.checkBoxTout.TabIndex = 15;
            this.checkBoxTout.Text = "Tout";
            this.checkBoxTout.UseVisualStyleBackColor = true;
            this.checkBoxTout.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxAP
            // 
            this.checkBoxAP.AutoSize = true;
            this.checkBoxAP.Location = new System.Drawing.Point(77, 72);
            this.checkBoxAP.Name = "checkBoxAP";
            this.checkBoxAP.Size = new System.Drawing.Size(62, 17);
            this.checkBoxAP.TabIndex = 16;
            this.checkBoxAP.Text = "A payer";
            this.checkBoxAP.UseVisualStyleBackColor = true;
            this.checkBoxAP.CheckedChanged += new System.EventHandler(this.checkBoxAP_CheckedChanged);
            // 
            // checkBoxAE
            // 
            this.checkBoxAE.AutoSize = true;
            this.checkBoxAE.Location = new System.Drawing.Point(145, 72);
            this.checkBoxAE.Name = "checkBoxAE";
            this.checkBoxAE.Size = new System.Drawing.Size(76, 17);
            this.checkBoxAE.TabIndex = 17;
            this.checkBoxAE.Text = "A expédier";
            this.checkBoxAE.UseVisualStyleBackColor = true;
            this.checkBoxAE.CheckedChanged += new System.EventHandler(this.checkBoxAE_CheckedChanged);
            // 
            // dataGridViewCommandes
            // 
            this.dataGridViewCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCommandes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCommandes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommandes.ColumnHeadersVisible = false;
            this.dataGridViewCommandes.EnableHeadersVisualStyles = false;
            this.dataGridViewCommandes.Location = new System.Drawing.Point(23, 118);
            this.dataGridViewCommandes.Name = "dataGridViewCommandes";
            this.dataGridViewCommandes.RowHeadersVisible = false;
            this.dataGridViewCommandes.Size = new System.Drawing.Size(238, 450);
            this.dataGridViewCommandes.TabIndex = 18;
            this.dataGridViewCommandes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelNombreElements
            // 
            this.labelNombreElements.AutoSize = true;
            this.labelNombreElements.Location = new System.Drawing.Point(20, 95);
            this.labelNombreElements.Name = "labelNombreElements";
            this.labelNombreElements.Size = new System.Drawing.Size(103, 13);
            this.labelNombreElements.TabIndex = 20;
            this.labelNombreElements.Text = "Nombre d\'éléments :";
            this.labelNombreElements.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombreElements1
            // 
            this.labelNombreElements1.AutoSize = true;
            this.labelNombreElements1.Location = new System.Drawing.Point(129, 95);
            this.labelNombreElements1.Name = "labelNombreElements1";
            this.labelNombreElements1.Size = new System.Drawing.Size(13, 13);
            this.labelNombreElements1.TabIndex = 21;
            this.labelNombreElements1.Text = "0";
            this.labelNombreElements1.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelClientRecherche
            // 
            this.labelClientRecherche.AutoSize = true;
            this.labelClientRecherche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelClientRecherche.Location = new System.Drawing.Point(738, 102);
            this.labelClientRecherche.Name = "labelClientRecherche";
            this.labelClientRecherche.Size = new System.Drawing.Size(106, 13);
            this.labelClientRecherche.TabIndex = 23;
            this.labelClientRecherche.Text = "Rechercher un client";
            // 
            // labelRechercheCommande
            // 
            this.labelRechercheCommande.AutoSize = true;
            this.labelRechercheCommande.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRechercheCommande.Location = new System.Drawing.Point(738, 170);
            this.labelRechercheCommande.Name = "labelRechercheCommande";
            this.labelRechercheCommande.Size = new System.Drawing.Size(139, 13);
            this.labelRechercheCommande.TabIndex = 24;
            this.labelRechercheCommande.Text = "Rechercher une commande";
            // 
            // labelColisage
            // 
            this.labelColisage.AutoSize = true;
            this.labelColisage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColisage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelColisage.Location = new System.Drawing.Point(738, 242);
            this.labelColisage.Name = "labelColisage";
            this.labelColisage.Size = new System.Drawing.Size(91, 20);
            this.labelColisage.TabIndex = 25;
            this.labelColisage.Text = "Documents";
            this.labelColisage.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelCivilitee
            // 
            this.labelCivilitee.AutoSize = true;
            this.labelCivilitee.Location = new System.Drawing.Point(16, 19);
            this.labelCivilitee.Name = "labelCivilitee";
            this.labelCivilitee.Size = new System.Drawing.Size(35, 13);
            this.labelCivilitee.TabIndex = 0;
            this.labelCivilitee.Text = "label6";
            this.labelCivilitee.Click += new System.EventHandler(this.labelCivilitee_Click);
            // 
            // groupBoxClientInformations
            // 
            this.groupBoxClientInformations.Controls.Add(this.labelTelephone1);
            this.groupBoxClientInformations.Controls.Add(this.labelTelephone);
            this.groupBoxClientInformations.Controls.Add(this.labelAdresseMail1);
            this.groupBoxClientInformations.Controls.Add(this.labelAdresseMail);
            this.groupBoxClientInformations.Controls.Add(this.labelVille);
            this.groupBoxClientInformations.Controls.Add(this.labelCodePostale);
            this.groupBoxClientInformations.Controls.Add(this.labelAdresse);
            this.groupBoxClientInformations.Controls.Add(this.labelPrenom);
            this.groupBoxClientInformations.Controls.Add(this.labelNom);
            this.groupBoxClientInformations.Controls.Add(this.labelCivilitee);
            this.groupBoxClientInformations.Location = new System.Drawing.Point(370, 112);
            this.groupBoxClientInformations.Name = "groupBoxClientInformations";
            this.groupBoxClientInformations.Size = new System.Drawing.Size(257, 144);
            this.groupBoxClientInformations.TabIndex = 26;
            this.groupBoxClientInformations.TabStop = false;
            this.groupBoxClientInformations.Text = "groupBox1";
            this.groupBoxClientInformations.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(104, 19);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "label7";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(193, 19);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(35, 13);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "label8";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(16, 44);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(35, 13);
            this.labelAdresse.TabIndex = 3;
            this.labelAdresse.Text = "label9";
            // 
            // labelCodePostale
            // 
            this.labelCodePostale.AutoSize = true;
            this.labelCodePostale.Location = new System.Drawing.Point(15, 68);
            this.labelCodePostale.Name = "labelCodePostale";
            this.labelCodePostale.Size = new System.Drawing.Size(41, 13);
            this.labelCodePostale.TabIndex = 4;
            this.labelCodePostale.Text = "label10";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(98, 68);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(41, 13);
            this.labelVille.TabIndex = 5;
            this.labelVille.Text = "label11";
            // 
            // labelAdresseMail
            // 
            this.labelAdresseMail.AutoSize = true;
            this.labelAdresseMail.Location = new System.Drawing.Point(14, 95);
            this.labelAdresseMail.Name = "labelAdresseMail";
            this.labelAdresseMail.Size = new System.Drawing.Size(72, 13);
            this.labelAdresseMail.TabIndex = 6;
            this.labelAdresseMail.Text = "Adresse mail :";
            this.labelAdresseMail.Click += new System.EventHandler(this.label12_Click);
            // 
            // labelAdresseMail1
            // 
            this.labelAdresseMail1.AutoSize = true;
            this.labelAdresseMail1.Location = new System.Drawing.Point(98, 95);
            this.labelAdresseMail1.Name = "labelAdresseMail1";
            this.labelAdresseMail1.Size = new System.Drawing.Size(41, 13);
            this.labelAdresseMail1.TabIndex = 7;
            this.labelAdresseMail1.Text = "label13";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(14, 121);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(64, 13);
            this.labelTelephone.TabIndex = 8;
            this.labelTelephone.Text = "Téléphone :";
            // 
            // labelTelephone1
            // 
            this.labelTelephone1.AutoSize = true;
            this.labelTelephone1.Location = new System.Drawing.Point(98, 121);
            this.labelTelephone1.Name = "labelTelephone1";
            this.labelTelephone1.Size = new System.Drawing.Size(41, 13);
            this.labelTelephone1.TabIndex = 9;
            this.labelTelephone1.Text = "label15";
            // 
            // labelListeCommandes
            // 
            this.labelListeCommandes.AutoSize = true;
            this.labelListeCommandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeCommandes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelListeCommandes.Location = new System.Drawing.Point(18, 44);
            this.labelListeCommandes.Name = "labelListeCommandes";
            this.labelListeCommandes.Size = new System.Drawing.Size(172, 20);
            this.labelListeCommandes.TabIndex = 10;
            this.labelListeCommandes.Text = "Liste des commandes :";
            // 
            // labelInformationCommande
            // 
            this.labelInformationCommande.AutoSize = true;
            this.labelInformationCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformationCommande.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInformationCommande.Location = new System.Drawing.Point(340, 40);
            this.labelInformationCommande.Name = "labelInformationCommande";
            this.labelInformationCommande.Size = new System.Drawing.Size(313, 20);
            this.labelInformationCommande.TabIndex = 27;
            this.labelInformationCommande.Text = "Informations de la commande sélectionnée";
            this.labelInformationCommande.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelRechercheSpecifique
            // 
            this.labelRechercheSpecifique.AutoSize = true;
            this.labelRechercheSpecifique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRechercheSpecifique.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRechercheSpecifique.Location = new System.Drawing.Point(737, 40);
            this.labelRechercheSpecifique.Name = "labelRechercheSpecifique";
            this.labelRechercheSpecifique.Size = new System.Drawing.Size(163, 20);
            this.labelRechercheSpecifique.TabIndex = 28;
            this.labelRechercheSpecifique.Text = "Recherche spécifique";
            // 
            // labelGestionDesCommandes
            // 
            this.labelGestionDesCommandes.AutoSize = true;
            this.labelGestionDesCommandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionDesCommandes.Location = new System.Drawing.Point(366, 2);
            this.labelGestionDesCommandes.Name = "labelGestionDesCommandes";
            this.labelGestionDesCommandes.Size = new System.Drawing.Size(262, 24);
            this.labelGestionDesCommandes.TabIndex = 29;
            this.labelGestionDesCommandes.Text = "Gestionnaire des commandes";
            this.labelGestionDesCommandes.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(964, 576);
            this.Controls.Add(this.labelGestionDesCommandes);
            this.Controls.Add(this.labelRechercheSpecifique);
            this.Controls.Add(this.labelInformationCommande);
            this.Controls.Add(this.labelListeCommandes);
            this.Controls.Add(this.groupBoxClientInformations);
            this.Controls.Add(this.labelColisage);
            this.Controls.Add(this.labelRechercheCommande);
            this.Controls.Add(this.labelClientRecherche);
            this.Controls.Add(this.labelNombreElements1);
            this.Controls.Add(this.labelNombreElements);
            this.Controls.Add(this.dataGridViewCommandes);
            this.Controls.Add(this.checkBoxAE);
            this.Controls.Add(this.checkBoxAP);
            this.Controls.Add(this.checkBoxTout);
            this.Controls.Add(this.buttonColisage);
            this.Controls.Add(this.textBoxRechercheCommande);
            this.Controls.Add(this.textBoxRechercheClient);
            this.Controls.Add(this.menuButton);
            this.Name = "Form3";
            this.Text = "Menagelec - Gestion des commandes";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommandes)).EndInit();
            this.groupBoxClientInformations.ResumeLayout(false);
            this.groupBoxClientInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.TextBox textBoxRechercheClient;
        private System.Windows.Forms.TextBox textBoxRechercheCommande;
        private System.Windows.Forms.Button buttonColisage;
        private System.Windows.Forms.CheckBox checkBoxTout;
        private System.Windows.Forms.CheckBox checkBoxAP;
        private System.Windows.Forms.CheckBox checkBoxAE;
        private System.Windows.Forms.DataGridView dataGridViewCommandes;
        private System.Windows.Forms.Label labelNombreElements;
        private System.Windows.Forms.Label labelNombreElements1;
        private System.Windows.Forms.Label labelClientRecherche;
        private System.Windows.Forms.Label labelRechercheCommande;
        private System.Windows.Forms.Label labelColisage;
        private System.Windows.Forms.Label labelCivilitee;
        private System.Windows.Forms.GroupBox groupBoxClientInformations;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelTelephone1;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelAdresseMail1;
        private System.Windows.Forms.Label labelAdresseMail;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelCodePostale;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelListeCommandes;
        private System.Windows.Forms.Label labelInformationCommande;
        private System.Windows.Forms.Label labelRechercheSpecifique;
        private System.Windows.Forms.Label labelGestionDesCommandes;
    }
}