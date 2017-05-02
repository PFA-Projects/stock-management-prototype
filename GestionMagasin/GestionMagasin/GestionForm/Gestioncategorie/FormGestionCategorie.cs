using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.Gestioncategorie
{
    public partial class FormGestionCategorie : Form
    {
        public FormGestionCategorie()
        {
            InitializeComponent();
        }
        private void GridMatriel_EditerMatrielEvent(object sender, EventArgs e)
        {

            Classe.Categorie_Matriel mat =gridCategorie1.Current;
     
            string tabEditerName = "TabEditer-" + mat.Designation;

            if (tabCategorie.TabPages.IndexOfKey(tabEditerName) == -1)
            {
                // Création de Tab
                TabPage tabEditerStagiaire = new TabPage();
                tabEditerStagiaire.Text = mat.Designation + " ";
                tabEditerStagiaire.Name = tabEditerName;
                tabCategorie.TabPages.Add(tabEditerStagiaire);
                tabCategorie.SelectedTab = tabEditerStagiaire;

                // Insertion du formulaire 
             FormCategorie matForm = new  FormCategorie();
                matForm.Name = "CategorieForm";
                matForm.CMatriel = mat;
             //   MatrielForm.Afficher();
                matForm.Afficher();
                this.tabCategorie.TabPages[tabEditerName].Controls.Add(matForm);
                matForm.EnregistrerClick += StagiaireForm_EditerClick;
                matForm.AnnulerClick += StagiaireForm_AnnulerEditerClick;
            }
        }

        private void StagiaireForm_EditerClick(object sender, EventArgs e)
        {
           FormCategorie formMatriel = (FormCategorie)sender;
            Classe.Categorie_Matriel mat = formMatriel.CMatriel;
            string tabEditerName = "TabEditer-" + mat.Designation;
            TabPage tabEditer = this.tabCategorie.TabPages[tabEditerName];

            //  if (new StagiairesService().Update(stagiaire))
            {
                MessageBox.Show("Le  :" + mat.ToString() + " a été bien enregistrer");
            }
            //   else
            {
                MessageBox.Show("Le :" + mat.ToString() + " n'est pas enregistrer car il n'y a pas des modifications");
            }


            // Suppression de la page Editer
            this.tabCategorie.TabPages.Remove(tabEditer);
         this.gridCategorie1.Actualiser();
           
        }
        private void StagiaireForm_AnnulerEditerClick(object sender, EventArgs e)
        {
           FormCategorie formMat = (FormCategorie)sender;
            Classe.Categorie_Matriel Mater = formMat.CMatriel;
            string tabEditerName = "TabEditer-" + Mater.Designation;

            TabPage tabEditer = this.tabCategorie.TabPages[tabEditerName];
            tabCategorie.TabPages.Remove(tabEditer);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Insertion du formulaire Si la page TabAjouter n'existe pas
            if (tabCategorie.TabPages.IndexOfKey("TabAjouter") == -1)
            {
                // Création de Tab
                TabPage tabAjouterMatriel = new TabPage();
                tabAjouterMatriel.Text = "Ajouter un matriel";
                tabAjouterMatriel.Name = "TabAjouter";
                tabAjouterMatriel.Height = 3000;
                tabCategorie.TabPages.Add(tabAjouterMatriel);
                tabCategorie.Height = 3000;
                tabCategorie.SelectedTab = tabAjouterMatriel;

                // Insertion du formulaire 
               FormCategorie MatrielForm = new FormCategorie();
                MatrielForm.Name = "MatrielForm";
           
                MatrielForm.Height = 2000;
                this.tabCategorie.TabPages["TabAjouter"].Controls.Add(MatrielForm);
                MatrielForm.EnregistrerClick += MatrielForm_EnregistrerClick;
                MatrielForm.AnnulerClick += MatrielForm_AnnulerAjouterClick;
            }
        }

        private void MatrielForm_EnregistrerClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabCategorie.TabPages["TabAjouter"];
            FormCategorie form = (FormCategorie)tabAjouter.Controls
                 .Find("MatrielForm", false).First();

             if (new ServiceCategorie().Ajouter(form.CMatriel))
            {
                MessageBox.Show("Le  :" + form.CMatriel.ToString() + " a été bien enregistrer");
            }
               else
            {
                MessageBox.Show("Le   :" + form.CMatriel.ToString() + " n'est pas enregistrer");
            }

            this.tabCategorie.TabPages.Remove(tabAjouter);
            this.gridCategorie1.Actualiser();
        }
        /// <summary>
        /// Annuler l'insertion d'un stagiaire
        /// </summary>
        private void MatrielForm_AnnulerAjouterClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabCategorie.TabPages["TabAjouter"];
            tabCategorie. TabPages.Remove(tabAjouter);
        }

        private void FormGestionCategorie_Load(object sender, EventArgs e)
        {
            gridCategorie1.Actualiser();
            gridCategorie1.EditerStagiaireEvent+=GridMatriel_EditerMatrielEvent;
        }


    }
}
