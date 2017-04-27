namespace GestionMagasin.Gestioncategorie
{
    partial class FormGestionCategorie
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabCategorie = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.gridCategorie1 = new GestionMagasin.Gestioncategorie.GridCategorie();
            this.tabPage1.SuspendLayout();
            this.tabCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridCategorie1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categorie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabCategorie
            // 
            this.tabCategorie.Controls.Add(this.tabPage1);
            this.tabCategorie.Location = new System.Drawing.Point(12, 34);
            this.tabCategorie.Name = "tabCategorie";
            this.tabCategorie.SelectedIndex = 0;
            this.tabCategorie.Size = new System.Drawing.Size(575, 289);
            this.tabCategorie.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter Categorie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridCategorie1
            // 
            this.gridCategorie1.Location = new System.Drawing.Point(0, 6);
            this.gridCategorie1.Name = "gridCategorie1";
            this.gridCategorie1.Size = new System.Drawing.Size(597, 302);
            this.gridCategorie1.TabIndex = 0;
            // 
            // FormGestionCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabCategorie);
            this.Name = "FormGestionCategorie";
            this.Text = "FormGestionCategorie";
            this.Load += new System.EventHandler(this.FormGestionCategorie_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabCategorie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabCategorie;
        private GridCategorie gridCategorie1;
        private System.Windows.Forms.Button button1;
    }
}