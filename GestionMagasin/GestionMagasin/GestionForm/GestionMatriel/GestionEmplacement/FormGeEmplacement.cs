using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.GestionEmplacement
{
    public partial class FormGeEmplacement : Form
    {
        public FormGeEmplacement()
        {
            InitializeComponent();
        }

        private void GridMatriel_EditerMatrielEvent(object sender, EventArgs e)
        {
            Classe.Emplacement mat = gridEmplacement1.Current;
            string tabEditerName = "TabEditer-" + mat.Designation;

            if (
            tabEmplacement.TabPages.IndexOfKey(tabEditerName) == -1)
            {
                // Création de Tab
                TabPage tabEditerStagiaire = new TabPage();
                tabEditerStagiaire.Text = mat.Designation + " ";
                tabEditerStagiaire.Name = tabEditerName;

                tabEmplacement.TabPages.Add(tabEditerStagiaire);
                tabEmplacement.SelectedTab = tabEditerStagiaire;

                // Insertion du formulaire 
               FormEmplacement matForm = new FormEmplacement();
                matForm.Name = "MatrielForm";
                matForm.Emplacement = mat;
                matForm.Afficher();
                this.tabEmplacement.TabPages[tabEditerName].Controls.Add(matForm);
                matForm.EnregistrerClick += StagiaireForm_EditerClick;
                matForm.AnnulerClick += StagiaireForm_AnnulerEditerClick;
            }
        }

        private void StagiaireForm_EditerClick(object sender, EventArgs e)
        {
            FormEmplacement formMatriel = (FormEmplacement)sender;
            Classe.Emplacement mat = formMatriel.Emplacement;
            string tabEditerName = "TabEditer-" + mat.Designation;
            TabPage tabEditer = this.tabEmplacement.TabPages[tabEditerName];

            //  if (new StagiairesService().Update(stagiaire))
            {
                MessageBox.Show(" :" + mat.ToString() + " a été bien enregistrer");
            }
            //   else
            {
                MessageBox.Show(" :" + mat.ToString() + " n'est pas enregistrer car il n'y a pas des modifications");
            }


            // Suppression de la page Editer
            this.tabEmplacement.TabPages.Remove(tabEditer);
           // this.materielGrid1.Actualiser();
        }
        private void StagiaireForm_AnnulerEditerClick(object sender, EventArgs e)
        {
            FormEmplacement formMat = (FormEmplacement)sender;
            Classe.Emplacement Mater = formMat.Emplacement;
            string tabEditerName = "TabEditer-" + Mater.Designation;
            TabPage tabEditer = this.tabEmplacement.TabPages[tabEditerName];
            tabEmplacement.TabPages.Remove(tabEditer);
        }

   /*     private void button_Ajouter_Click(object sender, EventArgs e)
        {
            // Insertion du formulaire Si la page TabAjouter n'existe pas
            if (tabEmplacement.TabPages.IndexOfKey("TabAjouter") == -1)
            {
                // Création de Tab
                TabPage tabAjouterMatriel = new TabPage();
                tabAjouterMatriel.Text = "Ajouter un matriel";
                tabAjouterMatriel.Name = "TabAjouter";
                tabAjouterMatriel.Height = 3000;
                tabEmplacement.TabPages.Add(tabAjouterMatriel);
                tabEmplacement.Height = 3000;
                tabEmplacement.SelectedTab = tabAjouterMatriel;

                // Insertion du formulaire 
                FormMatriel MatrielForm = new FormMatriel();
                MatrielForm.Name = "MatrielForm";
                MatrielForm.Height = 2000;
                this.tabEmplacement.TabPages["TabAjouter"].Controls.Add(MatrielForm);
                MatrielForm.EnregistrerClick += MatrielForm_EnregistrerClick;
                MatrielForm.AnnulerClick += MatrielForm_AnnulerAjouterClick;
            }
        }*/
        private void MatrielForm_EnregistrerClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabEmplacement.TabPages["TabAjouter"];
            FormEmplacement form = (FormEmplacement)tabAjouter.Controls
                 .Find("MatrielForm", false).First();

          if (new ServiceEmplacement().Ajouter(form.Emplacement))
            {
                MessageBox.Show("Le Matriel :" + form.Emplacement.ToString() + " a été bien enregistrer");
            }
            else
            {
                MessageBox.Show("Le Matriel  :" + form.Emplacement.ToString() + " n'est pas enregistrer");
            }

            this.tabEmplacement.TabPages.Remove(tabAjouter);
        this.gridEmplacement1.Actualiser();
        }
        /// <summary>
        /// Annuler l'insertion d'un stagiaire
        /// </summary>
        private void MatrielForm_AnnulerAjouterClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabEmplacement.TabPages["TabAjouter"];
            tabEmplacement.TabPages.Remove(tabAjouter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insertion du formulaire Si la page TabAjouter n'existe pas
            if (tabEmplacement.TabPages.IndexOfKey("TabAjouter") == -1)
            {
                // Création de Tab
                TabPage tabAjouterMatriel = new TabPage();
                tabAjouterMatriel.Text = "Ajouter un matriel";
                tabAjouterMatriel.Name = "TabAjouter";
                tabAjouterMatriel.Height = 3000;
                tabEmplacement.TabPages.Add(tabAjouterMatriel);
                tabEmplacement.Height = 3000;
                tabEmplacement.SelectedTab = tabAjouterMatriel;

                // Insertion du formulaire 
               FormEmplacement MatrielForm = new  FormEmplacement();
                MatrielForm.Name = "MatrielForm";
              
                MatrielForm.Height = 2000;
                this.tabEmplacement.TabPages["TabAjouter"].Controls.Add(MatrielForm);
                MatrielForm.EnregistrerClick += MatrielForm_EnregistrerClick;
                MatrielForm.AnnulerClick += MatrielForm_AnnulerAjouterClick;
            }
        }

        private void FormGeEmplacement_Load(object sender, EventArgs e)
        {
            gridEmplacement1.Actualiser();
            gridEmplacement1.EditerStagiaireEvent += GridMatriel_EditerMatrielEvent;
        }



    }
}
