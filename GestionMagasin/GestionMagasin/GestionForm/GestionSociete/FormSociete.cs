using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.GestionSociete
{
    public partial class FormSociete : UserControl
    {
        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;
        public FormSociete()
        {
            InitializeComponent();
        }
        public Classe.Societe Societe{ set; get; }
        public void Afficher()
        {
            nomSocieteTextBox.Text = Societe.NomSociete;

        }

        private void br_enregistrer_Click(object sender, EventArgs e)
        {
            if (this.Societe == null) Societe = new Classe.Societe();
            Societe.NomSociete = nomSocieteTextBox.Text;
            EnregistrerClick(this, e);
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            AnnulerClick(this, e);
        }

        private void FormSociete_Load(object sender, EventArgs e)
        {

        }
    }
}
