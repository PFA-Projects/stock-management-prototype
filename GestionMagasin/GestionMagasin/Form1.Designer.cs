namespace GestionMagasin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matrielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emplacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livraisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.societeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrerEtSortieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrielToolStripMenuItem,
            this.emplacementToolStripMenuItem,
            this.categorieToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.livraisonToolStripMenuItem,
            this.societeToolStripMenuItem,
            this.entrerEtSortieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matrielToolStripMenuItem
            // 
            this.matrielToolStripMenuItem.Name = "matrielToolStripMenuItem";
            this.matrielToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.matrielToolStripMenuItem.Text = "Matriel";
            this.matrielToolStripMenuItem.Click += new System.EventHandler(this.matrielToolStripMenuItem_Click);
            // 
            // emplacementToolStripMenuItem
            // 
            this.emplacementToolStripMenuItem.Name = "emplacementToolStripMenuItem";
            this.emplacementToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.emplacementToolStripMenuItem.Text = "emplacement";
            this.emplacementToolStripMenuItem.Click += new System.EventHandler(this.emplacementToolStripMenuItem_Click);
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.categorieToolStripMenuItem.Text = "categorie";
            this.categorieToolStripMenuItem.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.serviceToolStripMenuItem.Text = "service";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
            // 
            // livraisonToolStripMenuItem
            // 
            this.livraisonToolStripMenuItem.Name = "livraisonToolStripMenuItem";
            this.livraisonToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.livraisonToolStripMenuItem.Text = "livraison";
            this.livraisonToolStripMenuItem.Click += new System.EventHandler(this.livraisonToolStripMenuItem_Click);
            // 
            // societeToolStripMenuItem
            // 
            this.societeToolStripMenuItem.Name = "societeToolStripMenuItem";
            this.societeToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.societeToolStripMenuItem.Text = "Societe";
            this.societeToolStripMenuItem.Click += new System.EventHandler(this.societeToolStripMenuItem_Click);
            // 
            // entrerEtSortieToolStripMenuItem
            // 
            this.entrerEtSortieToolStripMenuItem.Name = "entrerEtSortieToolStripMenuItem";
            this.entrerEtSortieToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.entrerEtSortieToolStripMenuItem.Text = "Entrer Et sortie";
            this.entrerEtSortieToolStripMenuItem.Click += new System.EventHandler(this.entrerEtSortieToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matrielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emplacementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livraisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem societeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrerEtSortieToolStripMenuItem;
    }
}

