using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMagasin.Classe;

namespace GestionMagasin.GestionForm.GestionEmplacement
{
    public partial class FormEmplacement : UserControl
    {
        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;
        public FormEmplacement()
        {
            InitializeComponent();
        }
        public Classe.Emplacement Empl { get; set; }
        public void Afficher()
        {
           
           
        }

        private void br_enregistrer_Click(object sender, EventArgs e)
        {
            if (this.Empl == null) Empl = new Classe.Emplacement();
            Empl.Designation = designationTextBox.Text;
            Empl.service = (Service)serviceBindingSource.Current;
            EnregistrerClick(this, e);
          
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            AnnulerClick(this, e);

        }
    }
}
