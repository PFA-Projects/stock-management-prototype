using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.GestionForm.GestionEmplacement
{
    public partial class FormGestionEmplacement : Form
    {
        public FormGestionEmplacement()
        {
            InitializeComponent();
        }
        private void FormGestionEmplacement_Load(object sender, EventArgs e)
        {
            gridEmplacement1.Actualiser();

            gridEmplacement1.EditerStagiaireEvent += GridMatriel_EditerMatrielEvent;
          //  gridEmplacement1.EditerStagiaireEvent += GridMatriel_EditerMatrielEvent;
        }

        private void GridMatriel_EditerMatrielEvent(object sender, EventArgs e)
        {

            Classe.Emplacement mat = gridEmplacement1.Current;
            string tabEditerName = "TabEditer-" + mat.Designation;

            if (tabControl1.TabPages.IndexOfKey(tabEditerName) == -1)
            {
                // Création de Tab
                TabPage tabEditerStagiaire = new TabPage();
                tabEditerStagiaire.Text = mat.Designation + " ";
                tabEditerStagiaire.Name = tabEditerName;
                tabControl1.TabPages.Add(tabEditerStagiaire);
                tabControl1.SelectedTab = tabEditerStagiaire;

                // Insertion du formulaire 
                FormEmplacement matForm = new FormEmplacement();

                matForm.Name = "EmplacementForm";
                matForm.Empl = mat;
                matForm.Afficher();
                this.tabControl1.TabPages[tabEditerName].Controls.Add(matForm);
                matForm.EnregistrerClick += StagiaireForm_EditerClick;
                matForm.AnnulerClick += StagiaireForm_AnnulerEditerClick;
            }
        }


        private void StagiaireForm_EditerClick(object sender, EventArgs e)
        {
            FormEmplacement formMatriel = (FormEmplacement)sender;
       //     FormLivraison formMatriel = (FormLivraison)sender;
            Classe.Emplacement mat = formMatriel.Empl;
            string tabEditerName = "TabEditer-" + mat.Designation;
            TabPage tabEditer = this.tabControl1.TabPages[tabEditerName];

              if (new ServiceEmplacement().Update(mat))
            {
                MessageBox.Show("L'emplacement :" + mat.ToString() + " a été bien enregistrer");
            }
            //   else
            {
                MessageBox.Show("L'emplacement :" + mat.ToString() + " n'est pas enregistrer car il n'y a pas des modifications");
            }


            // Suppression de la page Editer
            this.tabControl1.TabPages.Remove(tabEditer);
            this.gridEmplacement1.Actualiser();

        }
        private void StagiaireForm_AnnulerEditerClick(object sender, EventArgs e)
        {
            FormEmplacement formMat = (FormEmplacement)sender;
         //   FormLivraison formMat = (FormLivraison)sender;
            Classe.Emplacement Mater = formMat.Empl;
            string tabEditerName = "TabEditer-" + Mater.Designation;
            TabPage tabEditer = this.tabControl1.TabPages[tabEditerName];
            tabControl1.TabPages.Remove(tabEditer);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Insertion du formulaire Si la page TabAjouter n'existe pas
            if (tabControl1.TabPages.IndexOfKey("TabAjouter") == -1)
            {
                // Création de Tab
                TabPage tabAjouterMatriel = new TabPage();
                tabAjouterMatriel.Text = "Ajouter Emplacement";
                tabAjouterMatriel.Name = "TabAjouter";
                tabAjouterMatriel.Height = 3000;
                tabControl1.TabPages.Add(tabAjouterMatriel);
                tabControl1.Height = 3000;
                tabControl1.SelectedTab = tabAjouterMatriel;

                // Insertion du formulaire 
                FormEmplacement MatrielForm = new FormEmplacement();
               // FormLivraison MatrielForm = new FormLivraison();
                MatrielForm.Name = "EmplacementForm";
                MatrielForm.Afficher();
                MatrielForm.Height = 2000;
                this.tabControl1.TabPages["TabAjouter"].Controls.Add(MatrielForm);
                MatrielForm.EnregistrerClick += MatrielForm_EnregistrerClick;
                MatrielForm.AnnulerClick += MatrielForm_AnnulerAjouterClick;
            }
        }
        private void MatrielForm_EnregistrerClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabControl1.TabPages["TabAjouter"];
            FormEmplacement form = (FormEmplacement)tabAjouter.Controls
                     .Find("EmplacementForm", false).First();

            if (new ServiceEmplacement().Ajouter(form.Empl))
            {
                MessageBox.Show("Le Matriel :" + form.Empl.ToString() + " a été bien enregistrer");
            }
            else
            {
                MessageBox.Show("Le Matriel  :" + form.Empl.ToString() + " n'est pas enregistrer");
            }

            this.tabControl1.TabPages.Remove(tabAjouter);
            this.gridEmplacement1.Actualiser();
        }
        /// <summary>
        /// Annuler l'insertion d'un stagiaire
        /// </summary>
        private void MatrielForm_AnnulerAjouterClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabControl1.TabPages["TabAjouter"];
            tabControl1.TabPages.Remove(tabAjouter);
        }

       


       
    }
}
