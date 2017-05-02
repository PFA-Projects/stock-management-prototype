namespace GestionMagasin.Gestioncategorie
{
    partial class GridCategorie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categorie_MatrielDataGridView = new System.Windows.Forms.DataGridView();
            this.categorie_MatrielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Modifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categorie_MatrielDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorie_MatrielBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categorie_MatrielDataGridView
            // 
            this.categorie_MatrielDataGridView.AllowUserToAddRows = false;
            this.categorie_MatrielDataGridView.AllowUserToDeleteRows = false;
            this.categorie_MatrielDataGridView.AutoGenerateColumns = false;
            this.categorie_MatrielDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorie_MatrielDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modifier,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Supprimer});
            this.categorie_MatrielDataGridView.DataSource = this.categorie_MatrielBindingSource;
            this.categorie_MatrielDataGridView.Location = new System.Drawing.Point(0, 3);
            this.categorie_MatrielDataGridView.Name = "categorie_MatrielDataGridView";
            this.categorie_MatrielDataGridView.ReadOnly = true;
            this.categorie_MatrielDataGridView.Size = new System.Drawing.Size(444, 243);
            this.categorie_MatrielDataGridView.TabIndex = 0;
            this.categorie_MatrielDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categorie_MatrielDataGridView_CellContentClick);
            // 
            // categorie_MatrielBindingSource
            // 
            this.categorie_MatrielBindingSource.DataSource = typeof(GestionMagasin.Classe.Categorie_Matriel);
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "";
            this.Modifier.Image = global::GestionMagasin.Properties.Resources.edit;
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "System.Drawing.Bitmap";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Designation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "";
            this.Supprimer.Image = global::GestionMagasin.Properties.Resources.delete;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            // 
            // GridCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categorie_MatrielDataGridView);
            this.Name = "GridCategorie";
            this.Size = new System.Drawing.Size(465, 271);
            this.Load += new System.EventHandler(this.GridCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorie_MatrielDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorie_MatrielBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource categorie_MatrielBindingSource;
        private System.Windows.Forms.DataGridView categorie_MatrielDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Supprimer;
    }
}
