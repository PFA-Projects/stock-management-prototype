using GestionMagasin.Classe;
using GestionMagasin.GestionMatriel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.GestionEntrerSortie
{
    public partial class FormSortie : Form
    {
        public FormSortie()
        {
            InitializeComponent();
        }
        public void afficher(string  l)
    {
        numeroInvontaireTextBox.Text =""+ l;
    }

        private void buttonSortie_Click(object sender, EventArgs e)
        {
            Classe.EntrerSortieMatriel ES = new Classe.EntrerSortieMatriel();

            ES.DateSortie = dateSortieDateTimePicker.Value;
            ES.Observation = observationTextBox.Text;
            ES.RaisonSortie = raisonSortieTextBox.Text;
            ES.emplacement = (Emplacement)emplacementBindingSource.Current;
            ES.matriel = new ServiceMatriel().RechercheParId(numeroInvontaireTextBox.Text);
            new ServiceEntrerSortie().Ajouter(ES);
        }

        private void raisonSortieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSortie_Load(object sender, EventArgs e)
        {
            emplacementBindingSource.DataSource = new GestionEmplacement.ServiceEmplacement().ListStagiaires();


        }

       
    }
}
