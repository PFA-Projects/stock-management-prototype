namespace GestionMagasin.GestionEntrerSortie
{
    partial class FormMatChoix
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numeroInvontaireLabel;
            this.numeroInvontaireTextBox = new System.Windows.Forms.TextBox();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matrielDataGridView = new System.Windows.Forms.DataGridView();
            this.matrielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entrerSortieMatrielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sortie = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numeroInvontaireLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrielDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrerSortieMatrielBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroInvontaireLabel
            // 
            numeroInvontaireLabel.AutoSize = true;
            numeroInvontaireLabel.Location = new System.Drawing.Point(137, 26);
            numeroInvontaireLabel.Name = "numeroInvontaireLabel";
            numeroInvontaireLabel.Size = new System.Drawing.Size(97, 13);
            numeroInvontaireLabel.TabIndex = 1;
            numeroInvontaireLabel.Text = "Numero Invontaire:";
            // 
            // numeroInvontaireTextBox
            // 
            this.numeroInvontaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "NumeroInvontaire", true));
            this.numeroInvontaireTextBox.Location = new System.Drawing.Point(240, 23);
            this.numeroInvontaireTextBox.Name = "numeroInvontaireTextBox";
            this.numeroInvontaireTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroInvontaireTextBox.TabIndex = 2;
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.Location = new System.Drawing.Point(372, 23);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(75, 23);
            this.button_Rechercher.TabIndex = 3;
            this.button_Rechercher.Text = "Rechercher";
            this.button_Rechercher.UseVisualStyleBackColor = true;
            this.button_Rechercher.Click += new System.EventHandler(this.button_Rechercher_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.matrielDataGridView);
            this.panel1.Location = new System.Drawing.Point(13, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 325);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // matrielDataGridView
            // 
            this.matrielDataGridView.AllowUserToAddRows = false;
            this.matrielDataGridView.AutoGenerateColumns = false;
            this.matrielDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrielDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Sortie,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.matrielDataGridView.DataSource = this.matrielBindingSource;
            this.matrielDataGridView.Location = new System.Drawing.Point(3, 3);
            this.matrielDataGridView.Name = "matrielDataGridView";
            this.matrielDataGridView.Size = new System.Drawing.Size(785, 322);
            this.matrielDataGridView.TabIndex = 0;
            this.matrielDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrielDataGridView_CellContentClick_2);
            // 
            // matrielBindingSource
            // 
            this.matrielBindingSource.DataSource = typeof(GestionMagasin.Classe.Matriel);
            // 
            // entrerSortieMatrielBindingSource
            // 
            this.entrerSortieMatrielBindingSource.DataSource = typeof(GestionMagasin.Classe.EntrerSortieMatriel);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NumeroInvontaire";
            this.dataGridViewTextBoxColumn1.HeaderText = "NumeroInvontaire";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Sortie
            // 
            this.Sortie.HeaderText = "Sortie";
            this.Sortie.Name = "Sortie";
            this.Sortie.Text = "Sortie ";
            this.Sortie.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Designation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Numero_Serie";
            this.dataGridViewTextBoxColumn4.HeaderText = "Numero_Serie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateMiseService";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateMiseService";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Observation";
            this.dataGridViewTextBoxColumn6.HeaderText = "Observation";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "acquisition";
            this.dataGridViewTextBoxColumn7.HeaderText = "acquisition";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "valeurAcquisition";
            this.dataGridViewTextBoxColumn8.HeaderText = "valeurAcquisition";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsValeurAcquisitionExist";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsValeurAcquisitionExist";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EtatPhysique";
            this.dataGridViewTextBoxColumn9.HeaderText = "EtatPhysique";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsExistStok";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IsExistStok";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Dimension";
            this.dataGridViewTextBoxColumn10.HeaderText = "Dimension";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Numero_INN";
            this.dataGridViewTextBoxColumn11.HeaderText = "Numero_INN";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "categorie";
            this.dataGridViewTextBoxColumn12.HeaderText = "categorie";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // FormMatChoix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Rechercher);
            this.Controls.Add(numeroInvontaireLabel);
            this.Controls.Add(this.numeroInvontaireTextBox);
            this.Name = "FormMatChoix";
            this.Text = "FormMatChoix";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrielDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrerSortieMatrielBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource matrielBindingSource;
        private System.Windows.Forms.TextBox numeroInvontaireTextBox;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView matrielDataGridView;
        private System.Windows.Forms.BindingSource entrerSortieMatrielBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Sortie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}