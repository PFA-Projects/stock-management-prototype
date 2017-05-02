namespace GestionMagasin.GestionEmplacement
{
    partial class FormGeEmplacement
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
            this.tabEmplacement = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridEmplacement1 = new GestionMagasin.GestionEmplacement.GridEmplacement();
            this.button1 = new System.Windows.Forms.Button();
            this.tabEmplacement.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmplacement
            // 
            this.tabEmplacement.Controls.Add(this.tabPage1);
            this.tabEmplacement.Location = new System.Drawing.Point(13, 13);
            this.tabEmplacement.Name = "tabEmplacement";
            this.tabEmplacement.SelectedIndex = 0;
            this.tabEmplacement.Size = new System.Drawing.Size(581, 397);
            this.tabEmplacement.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridEmplacement1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emplacement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridEmplacement1
            // 
            this.gridEmplacement1.Location = new System.Drawing.Point(-18, 21);
            this.gridEmplacement1.Name = "gridEmplacement1";
            this.gridEmplacement1.Size = new System.Drawing.Size(623, 344);
            this.gridEmplacement1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter emplacement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGeEmplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabEmplacement);
            this.Name = "FormGeEmplacement";
            this.Text = "FormGeEmplacement";
            this.Load += new System.EventHandler(this.FormGeEmplacement_Load);
            this.tabEmplacement.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmplacement;
        private System.Windows.Forms.TabPage tabPage1;
        private GridEmplacement gridEmplacement1;
        private System.Windows.Forms.Button button1;
    }
}