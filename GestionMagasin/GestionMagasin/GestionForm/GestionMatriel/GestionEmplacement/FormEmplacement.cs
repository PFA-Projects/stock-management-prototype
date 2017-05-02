using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMagasin.GestionService;

namespace GestionMagasin.GestionEmplacement
{
    public partial class FormEmplacement : UserControl
    {
        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;
        public FormEmplacement()
        {
            InitializeComponent();
        }

        public Classe.Emplacement Emplacement { set; get; }
        public void Afficher()
        {
            designationTextBox.Text = Emplacement.Designation;

        }
        private void br_enregistrer_Click(object sender, EventArgs e)
        {

            if (this.Emplacement == null) Emplacement = new Classe.Emplacement();
            Emplacement.Designation = designationTextBox.Text;




            if (serviceComboBox.SelectedItem != null)
                Emplacement.service = (Classe.Service)serviceComboBox.SelectedItem;

            EnregistrerClick(this, e);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            AnnulerClick(this, e);
        }

        private void FormEmplacement_Load(object sender, EventArgs e)
        {
            serviceBindingSource.DataSource=new ServiceServices().List();
                
        }
    }
}
