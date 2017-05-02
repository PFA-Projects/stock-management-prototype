namespace GestionMagasin.GestionSociete
{
    partial class FormSociete
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
            System.Windows.Forms.Label nomSocieteLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.br_enregistrer = new System.Windows.Forms.Button();
            this.nomSocieteTextBox = new System.Windows.Forms.TextBox();
            this.societeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomSocieteLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.societeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomSocieteLabel
            // 
            nomSocieteLabel.AutoSize = true;
            nomSocieteLabel.Location = new System.Drawing.Point(37, 72);
            nomSocieteLabel.Name = "nomSocieteLabel";
            nomSocieteLabel.Size = new System.Drawing.Size(71, 13);
            nomSocieteLabel.TabIndex = 2;
            nomSocieteLabel.Text = "Nom Societe:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_annuler);
            this.groupBox1.Controls.Add(this.br_enregistrer);
            this.groupBox1.Controls.Add(nomSocieteLabel);
            this.groupBox1.Controls.Add(this.nomSocieteTextBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Societe";
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(176, 128);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 60;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // br_enregistrer
            // 
            this.br_enregistrer.Location = new System.Drawing.Point(55, 128);
            this.br_enregistrer.Name = "br_enregistrer";
            this.br_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.br_enregistrer.TabIndex = 59;
            this.br_enregistrer.Text = "Enregistrer";
            this.br_enregistrer.UseVisualStyleBackColor = true;
            this.br_enregistrer.Click += new System.EventHandler(this.br_enregistrer_Click);
            // 
            // nomSocieteTextBox
            // 
            this.nomSocieteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.societeBindingSource, "NomSociete", true));
            this.nomSocieteTextBox.Location = new System.Drawing.Point(114, 69);
            this.nomSocieteTextBox.Name = "nomSocieteTextBox";
            this.nomSocieteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomSocieteTextBox.TabIndex = 3;
            // 
            // societeBindingSource
            // 
            this.societeBindingSource.DataSource = typeof(GestionMagasin.Classe.Societe);
            // 
            // FormSociete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSociete";
            this.Size = new System.Drawing.Size(514, 309);
            this.Load += new System.EventHandler(this.FormSociete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.societeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource societeBindingSource;
        private System.Windows.Forms.TextBox nomSocieteTextBox;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button br_enregistrer;
    }
}
