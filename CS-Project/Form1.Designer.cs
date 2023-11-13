namespace CS_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.connexionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 301);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(519, 190);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(222, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usernameText
            // 
            this.usernameText.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.usernameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.ForeColor = System.Drawing.SystemColors.Window;
            this.usernameText.Location = new System.Drawing.Point(519, 164);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(100, 13);
            this.usernameText.TabIndex = 2;
            this.usernameText.TabStop = false;
            this.usernameText.Text = "Utilisateur";
            this.usernameText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.passwordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.ForeColor = System.Drawing.SystemColors.Window;
            this.passwordText.Location = new System.Drawing.Point(519, 238);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 13);
            this.passwordText.TabIndex = 3;
            this.passwordText.TabStop = false;
            this.passwordText.Text = "Mot de passe";
            this.passwordText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(519, 264);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(222, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // connexionButton
            // 
            this.connexionButton.Location = new System.Drawing.Point(519, 339);
            this.connexionButton.Name = "connexionButton";
            this.connexionButton.Size = new System.Drawing.Size(222, 23);
            this.connexionButton.TabIndex = 6;
            this.connexionButton.Text = "Se connecter";
            this.connexionButton.UseVisualStyleBackColor = true;
            this.connexionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connexionButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Menageelec - Accès à l\'application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button connexionButton;
    }
}

