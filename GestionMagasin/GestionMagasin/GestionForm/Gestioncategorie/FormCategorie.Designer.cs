namespace GestionMagasin.Gestioncategorie
{
    partial class FormCategorie
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.br_enregistrer = new System.Windows.Forms.Button();
            this.categorie_MatrielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            designationLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorie_MatrielBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_annuler);
            this.groupBox1.Controls.Add(this.br_enregistrer);
            this.groupBox1.Controls.Add(designationLabel);
            this.groupBox1.Controls.Add(this.designationTextBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorie";
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new System.Drawing.Point(58, 65);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(66, 13);
            designationLabel.TabIndex = 0;
            designationLabel.Text = "Designation:";
            // 
            // designationTextBox
            // 
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categorie_MatrielBindingSource, "Designation", true));
            this.designationTextBox.Location = new System.Drawing.Point(130, 62);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(100, 20);
            this.designationTextBox.TabIndex = 1;
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(187, 138);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 60;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // br_enregistrer
            // 
            this.br_enregistrer.Location = new System.Drawing.Point(66, 138);
            this.br_enregistrer.Name = "br_enregistrer";
            this.br_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.br_enregistrer.TabIndex = 59;
            this.br_enregistrer.Text = "Enregistrer";
            this.br_enregistrer.UseVisualStyleBackColor = true;
            this.br_enregistrer.Click += new System.EventHandler(this.br_enregistrer_Click);
            // 
            // categorie_MatrielBindingSource
            // 
            this.categorie_MatrielBindingSource.DataSource = typeof(GestionMagasin.Classe.Categorie_Matriel);
            // 
            // FormCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCategorie";
            this.Size = new System.Drawing.Size(345, 226);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorie_MatrielBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.BindingSource categorie_MatrielBindingSource;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button br_enregistrer;
    }
}
