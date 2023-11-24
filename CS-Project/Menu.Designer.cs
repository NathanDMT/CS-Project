using System;

namespace CS_Project
{
    partial class Menu
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
            this.buttonCommandMenu = new System.Windows.Forms.Button();
            this.labelGestionDesCommandes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCommandMenu
            // 
            this.buttonCommandMenu.BackgroundImage = global::CS_Project.Properties.Resources.commande_impayee;
            this.buttonCommandMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCommandMenu.Location = new System.Drawing.Point(31, 28);
            this.buttonCommandMenu.Name = "buttonCommandMenu";
            this.buttonCommandMenu.Size = new System.Drawing.Size(71, 66);
            this.buttonCommandMenu.TabIndex = 0;
            this.buttonCommandMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCommandMenu.UseVisualStyleBackColor = true;
            this.buttonCommandMenu.Click += new System.EventHandler(this.buttonCommandMenu_Click);
            // 
            // labelGestionDesCommandes
            // 
            this.labelGestionDesCommandes.AutoSize = true;
            this.labelGestionDesCommandes.Location = new System.Drawing.Point(125, 55);
            this.labelGestionDesCommandes.Name = "labelGestionDesCommandes";
            this.labelGestionDesCommandes.Size = new System.Drawing.Size(123, 13);
            this.labelGestionDesCommandes.TabIndex = 2;
            this.labelGestionDesCommandes.Text = "Gestion des commandes";
            this.labelGestionDesCommandes.Click += new System.EventHandler(this.labelGestionDesCommandes_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(290, 136);
            this.Controls.Add(this.labelGestionDesCommandes);
            this.Controls.Add(this.buttonCommandMenu);
            this.Name = "Form2";
            this.Text = "Menagelec - Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button buttonCommandMenu;
        protected internal System.Windows.Forms.Label labelGestionDesCommandes;
    }
}