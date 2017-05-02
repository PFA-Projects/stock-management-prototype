using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.Gestioncategorie
{
    public partial class FormCategorie : UserControl
    {

        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;
        public FormCategorie()
        {
            InitializeComponent();
        }

        public Classe.Categorie_Matriel CMatriel { set; get; }
        public void Afficher()
        {
            designationTextBox.Text = CMatriel.Designation;
          
        }
        private void br_enregistrer_Click(object sender, EventArgs e)
        {

            if (this.CMatriel == null) CMatriel = new Classe.Categorie_Matriel();
            CMatriel.Designation = designationTextBox.Text;
            EnregistrerClick(this, e);
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            AnnulerClick(this,e);
        }
    }
}
