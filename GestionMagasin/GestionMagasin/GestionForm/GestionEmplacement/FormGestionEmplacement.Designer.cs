namespace GestionMagasin.GestionForm.GestionEmplacement
{
    partial class FormGestionEmplacement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridEmplacement1 = new GestionMagasin.GestionEmplacement.GridEmplacement();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridEmplacement1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emplacement ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridEmplacement1
            // 
            this.gridEmplacement1.Location = new System.Drawing.Point(-13, -22);
            this.gridEmplacement1.Name = "gridEmplacement1";
            this.gridEmplacement1.Size = new System.Drawing.Size(595, 296);
            this.gridEmplacement1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter un emplacement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGestionEmplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormGestionEmplacement";
            this.Text = "FormGestionEmplacement";
            this.Load += new System.EventHandler(this.FormGestionEmplacement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private GestionMagasin.GestionEmplacement.GridEmplacement gridEmplacement1;
        private System.Windows.Forms.Button button1;
    }
}