namespace GestionMagasin.GestionEmplacement
{
    partial class FormEmplacement
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
            System.Windows.Forms.Label serviceLabel;
            System.Windows.Forms.Label designationLabel;
            this.emplacementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.br_enregistrer = new System.Windows.Forms.Button();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            serviceLabel = new System.Windows.Forms.Label();
            designationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Location = new System.Drawing.Point(46, 91);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new System.Drawing.Size(44, 13);
            serviceLabel.TabIndex = 63;
            serviceLabel.Text = "service:";
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new System.Drawing.Point(46, 47);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(66, 13);
            designationLabel.TabIndex = 61;
            designationLabel.Text = "Designation:";
            // 
            // emplacementBindingSource
            // 
            this.emplacementBindingSource.DataSource = typeof(GestionMagasin.Classe.Emplacement);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_annuler);
            this.groupBox1.Controls.Add(this.br_enregistrer);
            this.groupBox1.Controls.Add(serviceLabel);
            this.groupBox1.Controls.Add(this.serviceComboBox);
            this.groupBox1.Controls.Add(designationLabel);
            this.groupBox1.Controls.Add(this.designationTextBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emplacement";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(189, 142);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 66;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // br_enregistrer
            // 
            this.br_enregistrer.Location = new System.Drawing.Point(68, 142);
            this.br_enregistrer.Name = "br_enregistrer";
            this.br_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.br_enregistrer.TabIndex = 65;
            this.br_enregistrer.Text = "Enregistrer";
            this.br_enregistrer.UseVisualStyleBackColor = true;
            this.br_enregistrer.Click += new System.EventHandler(this.br_enregistrer_Click);
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emplacementBindingSource, "service", true));
            this.serviceComboBox.DataSource = this.serviceBindingSource;
            this.serviceComboBox.DisplayMember = "id";
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(142, 88);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(100, 21);
            this.serviceComboBox.TabIndex = 64;
            this.serviceComboBox.ValueMember = "Observation";
            // 
            // designationTextBox
            // 
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emplacementBindingSource, "Designation", true));
            this.designationTextBox.Location = new System.Drawing.Point(142, 44);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(100, 20);
            this.designationTextBox.TabIndex = 62;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(GestionMagasin.Classe.Service);
            // 
            // FormEmplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEmplacement";
            this.Size = new System.Drawing.Size(318, 216);
            this.Load += new System.EventHandler(this.FormEmplacement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource emplacementBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button br_enregistrer;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.BindingSource serviceBindingSource;
    }
}
