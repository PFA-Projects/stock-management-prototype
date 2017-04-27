using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.GestionService
{
    public partial class FormGestionService : Form
    {
        public FormGestionService()
        {
            InitializeComponent();
        }

        private void GridMatriel_EditerMatrielEvent(object sender, EventArgs e)
        {
            Classe.Service mat = gridService1.Current; ;
            string tabEditerName = "TabEditer-" + mat.Observation;


            if (tabService.TabPages.IndexOfKey(tabEditerName) == -1)
            {
                // Création de Tab
                TabPage tabEditerStagiaire = new TabPage();
                tabEditerStagiaire.Text = mat.Observation + " ";
                tabEditerStagiaire.Name = tabEditerName;
                tabService.TabPages.Add(tabEditerStagiaire);
                tabService.SelectedTab = tabEditerStagiaire;

                // Insertion du formulaire 
              FormService matForm = new  FormService();
                matForm.Name = "MatrielForm";
                matForm.Service = mat;
                matForm.Afficher();
                this.tabService.TabPages[tabEditerName].Controls.Add(matForm);
       //         matForm.EnregistrerClick += StagiaireForm_EditerClick;
         //       matForm.AnnulerClick += StagiaireForm_AnnulerEditerClick;
            }
        }

        private void StagiaireForm_EditerClick(object sender, EventArgs e)
        {
          FormService formMatriel = (FormService)sender;
            Classe.Service mat = formMatriel.Service;
            string tabEditerName = "TabEditer-" + mat.Observation;
            TabPage tabEditer = this.tabService.TabPages[tabEditerName];

            //  if (new StagiairesService().Update(stagiaire))
            {
                MessageBox.Show("Le Matriel :" + mat.ToString() + " a été bien enregistrer");
            }
            //   else
            {
                MessageBox.Show("Le Matriel :" + mat.ToString() + " n'est pas enregistrer car il n'y a pas des modifications");
            }


            // Suppression de la page Editer
            this.tabService.TabPages.Remove(tabEditer);
          //  this.materielGrid1.Actualiser();
        }
        private void StagiaireForm_AnnulerEditerClick(object sender, EventArgs e)
        {
           FormService formMat = (FormService)sender;
            Classe.Service Mater = formMat.Service;
            string tabEditerName = "TabEditer-" + Mater.Observation;
            TabPage tabEditer = this.tabService.TabPages[tabEditerName];
            tabService.TabPages.Remove(tabEditer);
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            // Insertion du formulaire Si la page TabAjouter n'existe pas
            if (tabService.TabPages.IndexOfKey("TabAjouter") == -1)
            {
                // Création de Tab
                TabPage tabAjouterMatriel = new TabPage();
                tabAjouterMatriel.Text = "Ajouter un matriel";
                tabAjouterMatriel.Name = "TabAjouter";
                tabAjouterMatriel.Height = 3000;
                tabService.TabPages.Add(tabAjouterMatriel);
                tabService.Height = 3000;
                tabService.SelectedTab = tabAjouterMatriel;

                // Insertion du formulaire 
              FormService MatrielForm = new FormService();
                MatrielForm.Name = "MatrielForm";
                MatrielForm.Height = 2000;
                this.tabService.TabPages["TabAjouter"].Controls.Add(MatrielForm);
                MatrielForm.EnregistrerClick += MatrielForm_EnregistrerClick;
                MatrielForm.AnnulerClick += MatrielForm_AnnulerAjouterClick;
            }

        }
        private void MatrielForm_EnregistrerClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabService.TabPages["TabAjouter"];
           FormService form = (FormService)tabAjouter.Controls
                 .Find("MatrielForm", false).First();

               if (new ServiceServices().Ajouter(form.Service))
            {
                MessageBox.Show("Le Matriel :" + form.Service.ToString() + " a été bien enregistrer");
            }
               else
            {
                MessageBox.Show("Le Matriel  :" + form.Service.ToString() + " n'est pas enregistrer");
            }

            this.tabService.TabPages.Remove(tabAjouter);
          ///  this.materielGrid1.Actualiser();
            gridService1.Actualiser();
        }
        /// <summary>
        /// Annuler l'insertion d'un stagiaire
        /// </summary>
        private void MatrielForm_AnnulerAjouterClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabService.TabPages["TabAjouter"];
            tabService.TabPages.Remove(tabAjouter);
        }

        private void FormGestionService_Load(object sender, EventArgs e)
        {
            gridService1.Actualiser();
            gridService1.EditerStagiaireEvent+=GridMatriel_EditerMatrielEvent;
                 
        }


    }
}
