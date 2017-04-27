namespace GestionMagasin.GestionSociete
{
    partial class SocieteGrid
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
            this.societeDataGridView = new System.Windows.Forms.DataGridView();
            this.Modifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.societeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.societeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.societeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // societeDataGridView
            // 
            this.societeDataGridView.AllowUserToAddRows = false;
            this.societeDataGridView.AutoGenerateColumns = false;
            this.societeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.societeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modifier,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Supprimer});
            this.societeDataGridView.DataSource = this.societeBindingSource1;
            this.societeDataGridView.Location = new System.Drawing.Point(16, 12);
            this.societeDataGridView.Name = "societeDataGridView";
            this.societeDataGridView.Size = new System.Drawing.Size(446, 221);
            this.societeDataGridView.TabIndex = 0;
            this.societeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.societeDataGridView_CellContentClick);
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Image = global::GestionMagasin.Properties.Resources.edit;
            this.Modifier.Name = "Modifier";
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Image = global::GestionMagasin.Properties.Resources.delete;
            this.Supprimer.Name = "Supprimer";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NomSociete";
            this.dataGridViewTextBoxColumn4.HeaderText = "NomSociete";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // societeBindingSource1
            // 
            this.societeBindingSource1.DataSource = typeof(GestionMagasin.Classe.Societe);
            // 
            // SocieteGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.societeDataGridView);
            this.Name = "SocieteGrid";
            this.Size = new System.Drawing.Size(483, 260);
            this.Load += new System.EventHandler(this.SocieteGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.societeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.societeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    //    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource societeBindingSource1;
        private System.Windows.Forms.DataGridView societeDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn Supprimer;
    }
}
