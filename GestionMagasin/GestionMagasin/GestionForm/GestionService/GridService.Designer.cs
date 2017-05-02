namespace GestionMagasin.GestionService
{
    partial class GridService
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.societeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // societeDataGridView
            // 
            this.societeDataGridView.AllowUserToAddRows = false;
            this.societeDataGridView.AutoGenerateColumns = false;
            this.societeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.societeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modifier,
            this.idDataGridViewTextBoxColumn,
            this.observationDataGridViewTextBoxColumn,
            this.Supprimer});
            this.societeDataGridView.DataSource = this.serviceBindingSource;
            this.societeDataGridView.Location = new System.Drawing.Point(3, 3);
            this.societeDataGridView.Name = "societeDataGridView";
            this.societeDataGridView.Size = new System.Drawing.Size(509, 239);
            this.societeDataGridView.TabIndex = 1;
            this.societeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.societeDataGridView_CellContentClick);
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Image = global::GestionMagasin.Properties.Resources.edit;
            this.Modifier.Name = "Modifier";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // observationDataGridViewTextBoxColumn
            // 
            this.observationDataGridViewTextBoxColumn.DataPropertyName = "Observation";
            this.observationDataGridViewTextBoxColumn.HeaderText = "Observation";
            this.observationDataGridViewTextBoxColumn.Name = "observationDataGridViewTextBoxColumn";
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Image = global::GestionMagasin.Properties.Resources.delete;
            this.Supprimer.Name = "Supprimer";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(GestionMagasin.Classe.Service);
            // 
            // GridService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.societeDataGridView);
            this.Name = "GridService";
            this.Size = new System.Drawing.Size(525, 245);
            ((System.ComponentModel.ISupportInitialize)(this.societeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView societeDataGridView;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Supprimer;
    }
}
