namespace GestionMagasin.GestionLivraison
{
    partial class GridLivraison
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.livraisonDataGridView = new System.Windows.Forms.DataGridView();
            this.Modifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.livraisonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.livraisonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // livraisonDataGridView
            // 
            this.livraisonDataGridView.AllowUserToAddRows = false;
            this.livraisonDataGridView.AutoGenerateColumns = false;
            this.livraisonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livraisonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modifier,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Supprimer});
            this.livraisonDataGridView.DataSource = this.livraisonBindingSource;
            this.livraisonDataGridView.Location = new System.Drawing.Point(3, 0);
            this.livraisonDataGridView.Name = "livraisonDataGridView";
            this.livraisonDataGridView.Size = new System.Drawing.Size(658, 286);
            this.livraisonDataGridView.TabIndex = 1;
            this.livraisonDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.livraisonDataGridView_CellContentClick);
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "";
            this.Modifier.Image = global::GestionMagasin.Properties.Resources.edit;
            this.Modifier.Name = "Modifier";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn2.HeaderText = "date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marcher";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marcher";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumeroBonLivraison";
            this.dataGridViewTextBoxColumn4.HeaderText = "NumeroBonLivraison";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "";
            this.Supprimer.Image = global::GestionMagasin.Properties.Resources.delete;
            this.Supprimer.Name = "Supprimer";
            // 
            // livraisonBindingSource
            // 
            this.livraisonBindingSource.DataSource = typeof(GestionMagasin.Classe.Livraison);
            // 
            // GridLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.livraisonDataGridView);
            this.Name = "GridLivraison";
            this.Size = new System.Drawing.Size(652, 293);
            ((System.ComponentModel.ISupportInitialize)(this.livraisonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource livraisonBindingSource;
        private System.Windows.Forms.DataGridView livraisonDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn Supprimer;
    }
}
