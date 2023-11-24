using System;

namespace CS_Project
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.labelUtilisateur = new System.Windows.Forms.Label();
            this.labelMotDePasse = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(519, 190);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(222, 20);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(519, 264);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(222, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(519, 339);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(222, 23);
            this.buttonConnexion.TabIndex = 6;
            this.buttonConnexion.Text = "Se connecter";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // labelUtilisateur
            // 
            this.labelUtilisateur.AutoSize = true;
            this.labelUtilisateur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUtilisateur.Location = new System.Drawing.Point(516, 164);
            this.labelUtilisateur.Name = "labelUtilisateur";
            this.labelUtilisateur.Size = new System.Drawing.Size(53, 13);
            this.labelUtilisateur.TabIndex = 7;
            this.labelUtilisateur.Text = "Utilisateur";
            this.labelUtilisateur.Click += new System.EventHandler(this.labelUtilisateur_Click);
            // 
            // labelMotDePasse
            // 
            this.labelMotDePasse.AutoSize = true;
            this.labelMotDePasse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMotDePasse.Location = new System.Drawing.Point(516, 237);
            this.labelMotDePasse.Name = "labelMotDePasse";
            this.labelMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.labelMotDePasse.TabIndex = 8;
            this.labelMotDePasse.Text = "Mot de passe";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CS_Project.Properties.Resources.logo_menagelec;
            this.pictureBoxLogo.Location = new System.Drawing.Point(94, 61);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(301, 301);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMotDePasse);
            this.Controls.Add(this.labelUtilisateur);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Login";
            this.Text = "Menageelec - Accès à l\'application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.Label labelMotDePasse;
    }
}

