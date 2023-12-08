namespace CS_Project
{
    partial class FormProduitInfo
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
            this.labelNomProduit = new System.Windows.Forms.Label();
            this.labelDescriptionProduit = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelPrix1 = new System.Windows.Forms.Label();
            this.pictureBoxProduit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomProduit
            // 
            this.labelNomProduit.AutoSize = true;
            this.labelNomProduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNomProduit.Location = new System.Drawing.Point(57, 74);
            this.labelNomProduit.Name = "labelNomProduit";
            this.labelNomProduit.Size = new System.Drawing.Size(35, 13);
            this.labelNomProduit.TabIndex = 0;
            this.labelNomProduit.Text = "label1";
            // 
            // labelDescriptionProduit
            // 
            this.labelDescriptionProduit.AutoSize = true;
            this.labelDescriptionProduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDescriptionProduit.Location = new System.Drawing.Point(356, 90);
            this.labelDescriptionProduit.Name = "labelDescriptionProduit";
            this.labelDescriptionProduit.Size = new System.Drawing.Size(35, 13);
            this.labelDescriptionProduit.TabIndex = 1;
            this.labelDescriptionProduit.Text = "label2";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrix.Location = new System.Drawing.Point(57, 324);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(33, 13);
            this.labelPrix.TabIndex = 2;
            this.labelPrix.Text = "Prix : ";
            // 
            // labelPrix1
            // 
            this.labelPrix1.AutoSize = true;
            this.labelPrix1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrix1.Location = new System.Drawing.Point(96, 324);
            this.labelPrix1.Name = "labelPrix1";
            this.labelPrix1.Size = new System.Drawing.Size(35, 13);
            this.labelPrix1.TabIndex = 3;
            this.labelPrix1.Text = "label3";
            // 
            // pictureBoxProduit
            // 
            this.pictureBoxProduit.Location = new System.Drawing.Point(60, 90);
            this.pictureBoxProduit.Name = "pictureBoxProduit";
            this.pictureBoxProduit.Size = new System.Drawing.Size(290, 231);
            this.pictureBoxProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduit.TabIndex = 4;
            this.pictureBoxProduit.TabStop = false;
            // 
            // FormProduitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxProduit);
            this.Controls.Add(this.labelPrix1);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.labelDescriptionProduit);
            this.Controls.Add(this.labelNomProduit);
            this.Name = "FormProduitInfo";
            this.Text = "FormProduitInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomProduit;
        private System.Windows.Forms.Label labelDescriptionProduit;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelPrix1;
        private System.Windows.Forms.PictureBox pictureBoxProduit;
    }
}