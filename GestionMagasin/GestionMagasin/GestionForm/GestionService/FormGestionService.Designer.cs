namespace GestionMagasin.GestionService
{
    partial class FormGestionService
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
            this.tabService = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridService1 = new GestionMagasin.GestionService.GridService();
            this.button1 = new System.Windows.Forms.Button();
            this.tabService.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.tabPage1);
            this.tabService.Location = new System.Drawing.Point(13, 1);
            this.tabService.Name = "tabService";
            this.tabService.SelectedIndex = 0;
            this.tabService.Size = new System.Drawing.Size(548, 296);
            this.tabService.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridService1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Service";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridService1
            // 
            this.gridService1.Location = new System.Drawing.Point(9, 6);
            this.gridService1.Name = "gridService1";
            this.gridService1.Size = new System.Drawing.Size(531, 261);
            this.gridService1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter service";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGestionService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabService);
            this.Name = "FormGestionService";
            this.Text = "FormGestionService";
            this.Load += new System.EventHandler(this.FormGestionService_Load);
            this.tabService.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabService;
        private System.Windows.Forms.TabPage tabPage1;
        private GridService gridService1;
        private System.Windows.Forms.Button button1;
    }
}