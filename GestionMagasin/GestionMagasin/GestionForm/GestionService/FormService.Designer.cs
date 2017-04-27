namespace GestionMagasin.GestionService
{
    partial class FormService
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
            System.Windows.Forms.Label observationLabel;
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.br_enregistrer = new System.Windows.Forms.Button();
            this.observationTextBox = new System.Windows.Forms.TextBox();
            observationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // observationLabel
            // 
            observationLabel.AutoSize = true;
            observationLabel.Location = new System.Drawing.Point(45, 54);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new System.Drawing.Size(67, 13);
            observationLabel.TabIndex = 63;
            observationLabel.Text = "Observation:";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(GestionMagasin.Classe.Service);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_annuler);
            this.groupBox1.Controls.Add(this.br_enregistrer);
            this.groupBox1.Controls.Add(observationLabel);
            this.groupBox1.Controls.Add(this.observationTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 174);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service";
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(160, 100);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 66;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // br_enregistrer
            // 
            this.br_enregistrer.Location = new System.Drawing.Point(39, 100);
            this.br_enregistrer.Name = "br_enregistrer";
            this.br_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.br_enregistrer.TabIndex = 65;
            this.br_enregistrer.Text = "Enregistrer";
            this.br_enregistrer.UseVisualStyleBackColor = true;
            this.br_enregistrer.Click += new System.EventHandler(this.br_enregistrer_Click);
            // 
            // observationTextBox
            // 
            this.observationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Observation", true));
            this.observationTextBox.Location = new System.Drawing.Point(118, 51);
            this.observationTextBox.Name = "observationTextBox";
            this.observationTextBox.Size = new System.Drawing.Size(100, 20);
            this.observationTextBox.TabIndex = 64;
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FormService";
            this.Size = new System.Drawing.Size(281, 180);
            this.Load += new System.EventHandler(this.FormService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button br_enregistrer;
        private System.Windows.Forms.TextBox observationTextBox;
    }
}
