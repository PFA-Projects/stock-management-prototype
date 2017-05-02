using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.GestionLivraison
{
    public partial class FormLivraison : UserControl
    {
        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;
        public FormLivraison()
        {
            InitializeComponent();
        }

        public Classe.Livraison livraison { get; set; }
        public void Afficher()
        {
            dateDateTimePicker.Value = livraison.date;
            marcherTextBox.Text = livraison.Marcher;
            numeroBonLivraisonTextBox.Text = "" + livraison.NumeroBonLivraison;

        }

        private void br_enregistrer_Click(object sender, EventArgs e)
        {

            if (this.livraison == null) livraison = new Classe.Livraison();
            livraison.date = dateDateTimePicker.Value;
            livraison.Marcher = marcherTextBox.Text;
            livraison.NumeroBonLivraison = int.Parse(numeroBonLivraisonTextBox.Text);
           
            EnregistrerClick(this, e);

        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            AnnulerClick(this, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
