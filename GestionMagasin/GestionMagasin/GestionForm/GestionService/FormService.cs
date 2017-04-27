using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.GestionService
{
    public partial class FormService : UserControl
    {
        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;
        public FormService()
        {
            InitializeComponent();
        }

        public Classe.Service Service { set; get; }
        public void Afficher()
        {
          //  designationTextBox.Text = CMatriel.Designation;
            observationTextBox.Text = Service.Observation;
        }
       

     
        private void FormService_Load(object sender, EventArgs e)
        {

        }

        private void br_enregistrer_Click(object sender, EventArgs e)
        {
            if (this.Service == null) Service = new Classe.Service();
            Service.Observation = observationTextBox.Text;





            EnregistrerClick(this, e);
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            AnnulerClick(this, e);
        }

       
    }
}
