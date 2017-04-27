namespace GestionMagasin.GestionLivraison
{
    partial class FormGestionLivraison
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
            this.tabLivraison = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridLivraison1 = new GestionMagasin.GestionLivraison.GridLivraison();
            this.button1 = new System.Windows.Forms.Button();
            this.tabLivraison.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLivraison
            // 
            this.tabLivraison.Controls.Add(this.tabPage1);
            this.tabLivraison.Location = new System.Drawing.Point(27, 13);
            this.tabLivraison.Name = "tabLivraison";
            this.tabLivraison.SelectedIndex = 0;
            this.tabLivraison.Size = new System.Drawing.Size(664, 315);
            this.tabLivraison.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridLivraison1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Livraison";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridLivraison1
            // 
            this.gridLivraison1.Location = new System.Drawing.Point(6, 15);
            this.gridLivraison1.Name = "gridLivraison1";
            this.gridLivraison1.Size = new System.Drawing.Size(644, 249);
            this.gridLivraison1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter un livrason";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGestionLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabLivraison);
            this.Name = "FormGestionLivraison";
            this.Text = "FormGestionLivraison";
            this.Load += new System.EventHandler(this.FormGestionLivraison_Load);
            this.tabLivraison.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLivraison;
        private System.Windows.Forms.TabPage tabPage1;
        private GridLivraison gridLivraison1;
        private System.Windows.Forms.Button button1;
    }
}