namespace CS_Project
{
    partial class Form2
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
            this.cmdMenu = new System.Windows.Forms.Button();
            this.cmdMenuText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdMenu
            // 
            this.cmdMenu.BackgroundImage = global::CS_Project.Properties.Resources.commande_impayee;
            this.cmdMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdMenu.Location = new System.Drawing.Point(31, 28);
            this.cmdMenu.Name = "cmdMenu";
            this.cmdMenu.Size = new System.Drawing.Size(71, 66);
            this.cmdMenu.TabIndex = 0;
            this.cmdMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdMenu.UseVisualStyleBackColor = true;
            this.cmdMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdMenuText
            // 
            this.cmdMenuText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.cmdMenuText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmdMenuText.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmdMenuText.Location = new System.Drawing.Point(108, 52);
            this.cmdMenuText.Name = "cmdMenuText";
            this.cmdMenuText.Size = new System.Drawing.Size(134, 13);
            this.cmdMenuText.TabIndex = 1;
            this.cmdMenuText.Text = "Gestion des commandes";
            this.cmdMenuText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(290, 136);
            this.Controls.Add(this.cmdMenuText);
            this.Controls.Add(this.cmdMenu);
            this.Name = "Form2";
            this.Text = "Menagelec - Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdMenu;
        private System.Windows.Forms.TextBox cmdMenuText;
    }
}