namespace GestionMagasin.GestionLivraison
{
    partial class FormLivraison
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
            System.Windows.Forms.Label marcherLabel;
            System.Windows.Forms.Label numeroBonLivraisonLabel;
            System.Windows.Forms.Label dateLabel;
            this.livraisonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.br_enregistrer = new System.Windows.Forms.Button();
            this.marcherTextBox = new System.Windows.Forms.TextBox();
            this.numeroBonLivraisonTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            marcherLabel = new System.Windows.Forms.Label();
            numeroBonLivraisonLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // marcherLabel
            // 
            marcherLabel.AutoSize = true;
            marcherLabel.Location = new System.Drawing.Point(29, 44);
            marcherLabel.Name = "marcherLabel";
            marcherLabel.Size = new System.Drawing.Size(49, 13);
            marcherLabel.TabIndex = 63;
            marcherLabel.Text = "Marcher:";
            // 
            // numeroBonLivraisonLabel
            // 
            numeroBonLivraisonLabel.AutoSize = true;
            numeroBonLivraisonLabel.Location = new System.Drawing.Point(29, 70);
            numeroBonLivraisonLabel.Name = "numeroBonLivraisonLabel";
            numeroBonLivraisonLabel.Size = new System.Drawing.Size(114, 13);
            numeroBonLivraisonLabel.TabIndex = 65;
            numeroBonLivraisonLabel.Text = "Numero Bon Livraison:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(29, 89);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(31, 13);
            dateLabel.TabIndex = 61;
            dateLabel.Text = "date:";
            // 
            // livraisonBindingSource
            // 
            this.livraisonBindingSource.DataSource = typeof(GestionMagasin.Classe.Livraison);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_annuler);
            this.groupBox1.Controls.Add(this.br_enregistrer);
            this.groupBox1.Controls.Add(marcherLabel);
            this.groupBox1.Controls.Add(this.marcherTextBox);
            this.groupBox1.Controls.Add(numeroBonLivraisonLabel);
            this.groupBox1.Controls.Add(this.numeroBonLivraisonTextBox);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(this.dateDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livraison";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(225, 138);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 68;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            // 
            // br_enregistrer
            // 
            this.br_enregistrer.Location = new System.Drawing.Point(104, 138);
            this.br_enregistrer.Name = "br_enregistrer";
            this.br_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.br_enregistrer.TabIndex = 67;
            this.br_enregistrer.Text = "Enregistrer";
            this.br_enregistrer.UseVisualStyleBackColor = true;
            this.br_enregistrer.Click += new System.EventHandler(this.br_enregistrer_Click);
            // 
            // marcherTextBox
            // 
            this.marcherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livraisonBindingSource, "Marcher", true));
            this.marcherTextBox.Location = new System.Drawing.Point(149, 41);
            this.marcherTextBox.Name = "marcherTextBox";
            this.marcherTextBox.Size = new System.Drawing.Size(200, 20);
            this.marcherTextBox.TabIndex = 64;
            // 
            // numeroBonLivraisonTextBox
            // 
            this.numeroBonLivraisonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livraisonBindingSource, "NumeroBonLivraison", true));
            this.numeroBonLivraisonTextBox.Location = new System.Drawing.Point(149, 67);
            this.numeroBonLivraisonTextBox.Name = "numeroBonLivraisonTextBox";
            this.numeroBonLivraisonTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeroBonLivraisonTextBox.TabIndex = 66;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.livraisonBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(149, 85);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 62;
            // 
            // FormLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLivraison";
            this.Size = new System.Drawing.Size(382, 208);
            ((System.ComponentModel.ISupportInitialize)(this.livraisonBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource livraisonBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button br_enregistrer;
        private System.Windows.Forms.TextBox marcherTextBox;
        private System.Windows.Forms.TextBox numeroBonLivraisonTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
    }
}
