using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMagasin.Gestioncategorie;

namespace GestionMagasin.GestionMatriel
{
    public partial class FormMatriel : UserControl
    {
        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;

        public FormMatriel()
        {
            InitializeComponent();
        }

        public Classe.Matriel Matriel { set; get; }
        public void Afficher()
        {


         acquisitionTextBox.Text=  ""+ Matriel.acquisition ;
            dateMiseServiceDateTimePicker.Value = Matriel.DateMiseService;
            designationTextBox.Text= Matriel.Designation ;
          dimensionTextBox.Text=""+  Matriel.Dimension ;
 etatPhysiqueTextBox.Text=            Matriel.EtatPhysique ;
          
            if (Matriel.IsExistStok == true) 
            {
                isExistStokRadioButton.Checked = true;
            }
            else
            {
               radioButton1.Checked = true;
            }
           
            if (Matriel.IsValeurAcquisitionExist==true)
            {
                radioButton3.Checked = true;
              
            }
            else
            {
                radioButton2.Checked = true;

            }
           modelTextBox.Text= Matriel.Model ;
           numero_INNTextBox.Text = Matriel.Numero_INN;
           numero_SerieTextBox.Text = Matriel.Numero_Serie;
           numeroInvontaireTextBox.Text = Matriel.NumeroInvontaire;
            observationTextBox.Text    =  Matriel.NumeroInvontaire;
     valeurAcquisitionTextBox.Text      =   Matriel.valeurAcquisition;






            if (categorieComboBox.SelectedItem != null)
                Matriel.categorie = (Classe.Categorie_Matriel)categorieComboBox.SelectedItem;

        }

        private void br_enregistrer_Click(object sender, EventArgs e)
        {

            if (this.Matriel == null) Matriel  = new Classe.Matriel(); 
            Matriel.acquisition = float.Parse(acquisitionTextBox.Text);
            Matriel.DateMiseService = dateMiseServiceDateTimePicker.Value;
            Matriel.Designation = designationTextBox.Text;
            Matriel.Dimension = int.Parse(dimensionTextBox.Text);
            Matriel.EtatPhysique = etatPhysiqueTextBox.Text;
          if(isExistStokRadioButton.Checked)
            {
                Matriel.IsExistStok = true;
            }else
            {
                Matriel.IsExistStok = false;
            }
            if (radioButton3.Checked)
            {
                Matriel.IsValeurAcquisitionExist = true;
            }
            else
            {
                Matriel.IsValeurAcquisitionExist = false;
            }
            Matriel.Model = modelTextBox.Text;
            Matriel.Numero_INN = numero_INNTextBox.Text;
            Matriel.Numero_Serie = numero_SerieTextBox.Text;
            Matriel.NumeroInvontaire = numeroInvontaireTextBox.Text;
            Matriel.Observation = observationTextBox.Text;
            Matriel.valeurAcquisition = valeurAcquisitionTextBox.Text;
           
        
          


        
            if (categorieComboBox.SelectedItem != null)
                Matriel.categorie= (Classe.Categorie_Matriel)categorieComboBox.SelectedItem;
          //  new ServiceMatriel().Ajouter(Matriel);
            EnregistrerClick(this, e);

        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            AnnulerClick(this, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormMatriel_Load(object sender, EventArgs e)
        {
            categorieMatrielBindingSource.DataSource = new ServiceCategorie().ListStagiaires();
        }
    }
}
