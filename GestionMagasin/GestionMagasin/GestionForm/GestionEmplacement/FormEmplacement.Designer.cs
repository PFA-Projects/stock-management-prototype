namespace GestionMagasin.GestionForm.GestionEmplacement
{
    partial class FormEmplacement
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
            System.Windows.Forms.Label designationLabel;
            System.Windows.Forms.Label serviceLabel;
            this.emplacementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.br_enregistrer = new System.Windows.Forms.Button();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            designationLabel = new System.Windows.Forms.Label();
            serviceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emplacementBindingSource
            // 
            this.emplacementBindingSource.DataSource = typeof(GestionMagasin.Classe.Emplacement);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(serviceLabel);
            this.groupBox1.Controls.Add(this.serviceComboBox);
            this.groupBox1.Controls.Add(this.bt_annuler);
            this.groupBox1.Controls.Add(this.br_enregistrer);
            this.groupBox1.Controls.Add(designationLabel);
            this.groupBox1.Controls.Add(this.designationTextBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emplacement";
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new System.Drawing.Point(45, 41);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(66, 13);
            designationLabel.TabIndex = 6;
            designationLabel.Text = "Designation:";
            // 
            // designationTextBox
            // 
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emplacementBindingSource, "Designation", true));
            this.designationTextBox.Location = new System.Drawing.Point(117, 36);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(121, 20);
            this.designationTextBox.TabIndex = 7;
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(174, 121);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 70;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // br_enregistrer
            // 
            this.br_enregistrer.Location = new System.Drawing.Point(53, 121);
            this.br_enregistrer.Name = "br_enregistrer";
            this.br_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.br_enregistrer.TabIndex = 69;
            this.br_enregistrer.Text = "Enregistrer";
            this.br_enregistrer.UseVisualStyleBackColor = true;
            this.br_enregistrer.Click += new System.EventHandler(this.br_enregistrer_Click);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(GestionMagasin.Classe.Service);
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.DataSource = this.serviceBindingSource;
            this.serviceComboBox.DisplayMember = "Observation";
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(117, 78);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(121, 21);
            this.serviceComboBox.TabIndex = 70;
            this.serviceComboBox.ValueMember = "id";
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Location = new System.Drawing.Point(45, 86);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new System.Drawing.Size(44, 13);
            serviceLabel.TabIndex = 70;
            serviceLabel.Text = "service:";
            // 
            // FormEmplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEmplacement";
            this.Size = new System.Drawing.Size(415, 211);
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
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.BindingSource serviceBindingSource;
    }
}
