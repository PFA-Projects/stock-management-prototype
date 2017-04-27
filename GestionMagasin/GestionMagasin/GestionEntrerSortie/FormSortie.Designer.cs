namespace GestionMagasin.GestionEntrerSortie
{
    partial class FormSortie
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
            System.Windows.Forms.Label dateSortieLabel;
            System.Windows.Forms.Label observationLabel;
            System.Windows.Forms.Label raisonSortieLabel;
            System.Windows.Forms.Label emplacementLabel;
            this.dateSortieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.entrerSortieMatrielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.observationTextBox = new System.Windows.Forms.TextBox();
            this.raisonSortieTextBox = new System.Windows.Forms.TextBox();
            this.buttonSortie = new System.Windows.Forms.Button();
            this.numeroInvontaireTextBox = new System.Windows.Forms.TextBox();
            this.emplacementComboBox = new System.Windows.Forms.ComboBox();
            this.emplacementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateSortieLabel = new System.Windows.Forms.Label();
            observationLabel = new System.Windows.Forms.Label();
            raisonSortieLabel = new System.Windows.Forms.Label();
            emplacementLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entrerSortieMatrielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateSortieLabel
            // 
            dateSortieLabel.AutoSize = true;
            dateSortieLabel.Location = new System.Drawing.Point(27, 50);
            dateSortieLabel.Name = "dateSortieLabel";
            dateSortieLabel.Size = new System.Drawing.Size(63, 13);
            dateSortieLabel.TabIndex = 3;
            dateSortieLabel.Text = "Date Sortie:";
            // 
            // observationLabel
            // 
            observationLabel.AutoSize = true;
            observationLabel.Location = new System.Drawing.Point(27, 75);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new System.Drawing.Size(67, 13);
            observationLabel.TabIndex = 7;
            observationLabel.Text = "Observation:";
            // 
            // raisonSortieLabel
            // 
            raisonSortieLabel.AutoSize = true;
            raisonSortieLabel.Location = new System.Drawing.Point(27, 101);
            raisonSortieLabel.Name = "raisonSortieLabel";
            raisonSortieLabel.Size = new System.Drawing.Size(73, 13);
            raisonSortieLabel.TabIndex = 9;
            raisonSortieLabel.Text = "Raison Sortie:";
            // 
            // dateSortieDateTimePicker
            // 
            this.dateSortieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.entrerSortieMatrielBindingSource, "DateSortie", true));
            this.dateSortieDateTimePicker.Location = new System.Drawing.Point(129, 43);
            this.dateSortieDateTimePicker.Name = "dateSortieDateTimePicker";
            this.dateSortieDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateSortieDateTimePicker.TabIndex = 4;
            // 
            // entrerSortieMatrielBindingSource
            // 
            this.entrerSortieMatrielBindingSource.DataSource = typeof(GestionMagasin.Classe.EntrerSortieMatriel);
            // 
            // observationTextBox
            // 
            this.observationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entrerSortieMatrielBindingSource, "Observation", true));
            this.observationTextBox.Location = new System.Drawing.Point(129, 69);
            this.observationTextBox.Name = "observationTextBox";
            this.observationTextBox.Size = new System.Drawing.Size(200, 20);
            this.observationTextBox.TabIndex = 8;
            // 
            // raisonSortieTextBox
            // 
            this.raisonSortieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entrerSortieMatrielBindingSource, "RaisonSortie", true));
            this.raisonSortieTextBox.Location = new System.Drawing.Point(129, 95);
            this.raisonSortieTextBox.Name = "raisonSortieTextBox";
            this.raisonSortieTextBox.Size = new System.Drawing.Size(200, 20);
            this.raisonSortieTextBox.TabIndex = 10;
            this.raisonSortieTextBox.TextChanged += new System.EventHandler(this.raisonSortieTextBox_TextChanged);
            // 
            // buttonSortie
            // 
            this.buttonSortie.Location = new System.Drawing.Point(129, 205);
            this.buttonSortie.Name = "buttonSortie";
            this.buttonSortie.Size = new System.Drawing.Size(75, 23);
            this.buttonSortie.TabIndex = 42;
            this.buttonSortie.Text = "Sortie";
            this.buttonSortie.UseVisualStyleBackColor = true;
            this.buttonSortie.Click += new System.EventHandler(this.buttonSortie_Click);
            // 
            // numeroInvontaireTextBox
            // 
            this.numeroInvontaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entrerSortieMatrielBindingSource, "matriel.NumeroInvontaire", true));
            this.numeroInvontaireTextBox.Location = new System.Drawing.Point(104, 12);
            this.numeroInvontaireTextBox.Name = "numeroInvontaireTextBox";
            this.numeroInvontaireTextBox.Size = new System.Drawing.Size(141, 20);
            this.numeroInvontaireTextBox.TabIndex = 43;
            this.numeroInvontaireTextBox.Visible = false;
            // 
            // emplacementLabel
            // 
            emplacementLabel.AutoSize = true;
            emplacementLabel.Location = new System.Drawing.Point(27, 144);
            emplacementLabel.Name = "emplacementLabel";
            emplacementLabel.Size = new System.Drawing.Size(73, 13);
            emplacementLabel.TabIndex = 43;
            emplacementLabel.Text = "emplacement:";
            // 
            // emplacementComboBox
            // 
            this.emplacementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entrerSortieMatrielBindingSource, "emplacement", true));
            this.emplacementComboBox.DataSource = this.emplacementBindingSource;
            this.emplacementComboBox.DisplayMember = "Designation";
            this.emplacementComboBox.FormattingEnabled = true;
            this.emplacementComboBox.Location = new System.Drawing.Point(129, 141);
            this.emplacementComboBox.Name = "emplacementComboBox";
            this.emplacementComboBox.Size = new System.Drawing.Size(121, 21);
            this.emplacementComboBox.TabIndex = 44;
            this.emplacementComboBox.ValueMember = "id";
            // 
            // emplacementBindingSource
            // 
            this.emplacementBindingSource.DataSource = typeof(GestionMagasin.Classe.Emplacement);
            // 
            // FormSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 286);
            this.Controls.Add(emplacementLabel);
            this.Controls.Add(this.emplacementComboBox);
            this.Controls.Add(this.numeroInvontaireTextBox);
            this.Controls.Add(this.buttonSortie);
            this.Controls.Add(dateSortieLabel);
            this.Controls.Add(this.dateSortieDateTimePicker);
            this.Controls.Add(observationLabel);
            this.Controls.Add(this.observationTextBox);
            this.Controls.Add(raisonSortieLabel);
            this.Controls.Add(this.raisonSortieTextBox);
            this.Name = "FormSortie";
            this.Text = "FormSortie";
            this.Load += new System.EventHandler(this.FormSortie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entrerSortieMatrielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource entrerSortieMatrielBindingSource;
        private System.Windows.Forms.DateTimePicker dateSortieDateTimePicker;
        private System.Windows.Forms.TextBox observationTextBox;
        private System.Windows.Forms.TextBox raisonSortieTextBox;
        private System.Windows.Forms.Button buttonSortie;
        private System.Windows.Forms.TextBox numeroInvontaireTextBox;
        private System.Windows.Forms.ComboBox emplacementComboBox;
        private System.Windows.Forms.BindingSource emplacementBindingSource;
    }
}