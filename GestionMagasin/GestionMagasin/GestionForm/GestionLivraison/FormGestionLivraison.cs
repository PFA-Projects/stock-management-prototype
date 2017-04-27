using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.GestionLivraison
{
    public partial class FormGestionLivraison : Form
    {
        public FormGestionLivraison()
        {
            InitializeComponent();
        }

        private void FormGestionLivraison_Load(object sender, EventArgs e)
        {
            gridLivraison1.Actualiser();
            gridLivraison1.EditerStagiaireEvent += GridMatriel_EditerMatrielEvent;
        }


       private void GridMatriel_EditerMatrielEvent(object sender, EventArgs e)
        {

            Classe.Livraison mat = gridLivraison1.Current;
            string tabEditerName = "TabEditer-" + mat.Marcher;
      
            if (tabLivraison.TabPages.IndexOfKey(tabEditerName) == -1)
            {
                // Création de Tab
                TabPage tabEditerStagiaire = new TabPage();
                tabEditerStagiaire.Text = mat.Marcher + " ";
                tabEditerStagiaire.Name = tabEditerName;
                tabLivraison.TabPages.Add(tabEditerStagiaire);
                tabLivraison.SelectedTab = tabEditerStagiaire;

                // Insertion du formulaire 
               FormLivraison matForm = new  FormLivraison();
                matForm.Name = "MatrielForm";
                matForm.livraison = mat;
                matForm.Afficher();
                this.tabLivraison.TabPages[tabEditerName].Controls.Add(matForm);
                matForm.EnregistrerClick += StagiaireForm_EditerClick;
                matForm.AnnulerClick += StagiaireForm_AnnulerEditerClick;
            }
        }

        private void StagiaireForm_EditerClick(object sender, EventArgs e)
        {
            FormLivraison formMatriel = (FormLivraison)sender;
            Classe.Livraison mat = formMatriel.livraison;
            string tabEditerName = "TabEditer-" + mat.Marcher;
            TabPage tabEditer = this.tabLivraison.TabPages[tabEditerName];

            //  if (new StagiairesService().Update(stagiaire))
            {
                MessageBox.Show("Le Matriel :" + mat.ToString() + " a été bien enregistrer");
            }
            //   else
            {
                MessageBox.Show("Le Matriel :" + mat.ToString() + " n'est pas enregistrer car il n'y a pas des modifications");
            }


            // Suppression de la page Editer
            this.tabLivraison.TabPages.Remove(tabEditer);
            this.gridLivraison1.Actualiser();
        
        }
        private void StagiaireForm_AnnulerEditerClick(object sender, EventArgs e)
        {
       FormLivraison   formMat = (FormLivraison)sender;
            Classe.Livraison Mater = formMat.livraison;
            string tabEditerName = "TabEditer-" + Mater.Marcher;
            TabPage tabEditer = this.tabLivraison.TabPages[tabEditerName];
            tabLivraison.TabPages.Remove(tabEditer);
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            // Insertion du formulaire Si la page TabAjouter n'existe pas
            if (tabLivraison.TabPages.IndexOfKey("TabAjouter") == -1)
            {
                // Création de Tab
                TabPage tabAjouterMatriel = new TabPage();
                tabAjouterMatriel.Text = "Ajouter un matriel";
                tabAjouterMatriel.Name = "TabAjouter";
                tabAjouterMatriel.Height = 3000;
                tabLivraison.TabPages.Add(tabAjouterMatriel);
                tabLivraison.Height = 3000;
                tabLivraison.SelectedTab = tabAjouterMatriel;

                // Insertion du formulaire 
              FormLivraison MatrielForm = new  FormLivraison();
                MatrielForm.Name = "MatrielForm";
                MatrielForm.Height = 2000;
                this.tabLivraison.TabPages["TabAjouter"].Controls.Add(MatrielForm);
                MatrielForm.EnregistrerClick += MatrielForm_EnregistrerClick;
                MatrielForm.AnnulerClick += MatrielForm_AnnulerAjouterClick;
            }
        }
        private void MatrielForm_EnregistrerClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabLivraison.TabPages["TabAjouter"];
            FormLivraison form = (FormLivraison)tabAjouter.Controls
                 .Find("MatrielForm", false).First();

             if (new  ServiceLivraison().Ajouter(form.livraison))
            {
                MessageBox.Show("Le Matriel :" + form.livraison.ToString() + " a été bien enregistrer");
            }
             else
            {
                MessageBox.Show("Le Matriel  :" + form.livraison.ToString() + " n'est pas enregistrer");
            }

            this.tabLivraison.TabPages.Remove(tabAjouter);
            this.gridLivraison1.Actualiser();
        }
        /// <summary>
        /// Annuler l'insertion d'un stagiaire
        /// </summary>
        private void MatrielForm_AnnulerAjouterClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabLivraison.TabPages["TabAjouter"];
            tabLivraison.TabPages.Remove(tabAjouter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insertion du formulaire Si la page TabAjouter n'existe pas
            if (tabLivraison.TabPages.IndexOfKey("TabAjouter") == -1)
            {
                // Création de Tab
                TabPage tabAjouterMatriel = new TabPage();
                tabAjouterMatriel.Text = "Ajouter un matriel";
                tabAjouterMatriel.Name = "TabAjouter";
                tabAjouterMatriel.Height = 3000;
                tabLivraison.TabPages.Add(tabAjouterMatriel);
                tabLivraison.Height = 3000;
                tabLivraison.SelectedTab = tabAjouterMatriel;

                // Insertion du formulaire 
                FormLivraison MatrielForm = new FormLivraison();
                MatrielForm.Name = "MatrielForm";
                MatrielForm.Afficher();
                MatrielForm.Height = 2000;
                this.tabLivraison.TabPages["TabAjouter"].Controls.Add(MatrielForm);
                MatrielForm.EnregistrerClick += MatrielForm_EnregistrerClick;
                MatrielForm.AnnulerClick += MatrielForm_AnnulerAjouterClick;
            }
        }

        

    }
}
