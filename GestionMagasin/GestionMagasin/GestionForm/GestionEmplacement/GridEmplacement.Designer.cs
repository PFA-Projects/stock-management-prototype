namespace GestionMagasin.GestionForm.GestionEmplacement
{
    partial class GridEmplacement
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
            this.emplacementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.emplacementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emplacementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emplacementDataGridView
            // 
            this.emplacementDataGridView.AutoGenerateColumns = false;
            this.emplacementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emplacementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modifier,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Supprimer});
            this.emplacementDataGridView.DataSource = this.emplacementBindingSource;
            this.emplacementDataGridView.Location = new System.Drawing.Point(12, 26);
            this.emplacementDataGridView.Name = "emplacementDataGridView";
            this.emplacementDataGridView.Size = new System.Drawing.Size(532, 239);
            this.emplacementDataGridView.TabIndex = 1;
            this.emplacementDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emplacementDataGridView_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GestionMagasin.Properties.Resources.edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::GestionMagasin.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Designation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "service";
            this.dataGridViewTextBoxColumn3.HeaderText = "service";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "";
            this.Supprimer.Image = global::GestionMagasin.Properties.Resources.delete;
            this.Supprimer.Name = "Supprimer";
            // 
            // emplacementBindingSource
            // 
            this.emplacementBindingSource.DataSource = typeof(GestionMagasin.Classe.Emplacement);
            // 
            // GridEmplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emplacementDataGridView);
            this.Name = "GridEmplacement";
            this.Size = new System.Drawing.Size(561, 320);
            this.Load += new System.EventHandler(this.GridEmplacement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emplacementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource emplacementBindingSource;
        private System.Windows.Forms.DataGridView emplacementDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn Supprimer;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}
