using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.GestionSociete
{
    public partial class FormGestionSociete : Form
    {
        public FormGestionSociete()
        {
            InitializeComponent();
        }
        private void FormGestionSociete_Load(object sender, EventArgs e)
        {
            this.societeGrid1.Actualiser();



            // événement Supprimer et Editer sur la liste des stagiaires
            societeGrid1.EditerSocieteEvent +=  GridMatriel_EditerMatrielEvent;
        }
        private void GridMatriel_EditerMatrielEvent(object sender, EventArgs e)
        {

            Classe.Societe mat = societeGrid1.Current;

            string tabEditerName = "TabEditer-" + mat.NomSociete;

            if (tabControl1.TabPages.IndexOfKey(tabEditerName) == -1)
            {
                // Création de Tab
                TabPage tabEditerStagiaire = new TabPage();
                tabEditerStagiaire.Text = mat.NomSociete + " ";
                tabEditerStagiaire.Name = tabEditerName;
                tabControl1.TabPages.Add(tabEditerStagiaire);
                tabControl1.SelectedTab = tabEditerStagiaire;

                // Insertion du formulaire 
                FormSociete matForm = new FormSociete();
             //   FormCategorie matForm = new FormCategorie();
                matForm.Name = "SocieteForm";
                matForm.Societe = mat;
             
                matForm.Afficher();
                this.tabControl1.TabPages[tabEditerName].Controls.Add(matForm);
                matForm.EnregistrerClick += StagiaireForm_EditerClick;
                matForm.AnnulerClick += StagiaireForm_AnnulerEditerClick;
            }
        }

        private void StagiaireForm_EditerClick(object sender, EventArgs e)
        {
          FormSociete formMatriel = (FormSociete)sender;
            Classe.Societe mat = formMatriel.Societe;
            string tabEditerName = "TabEditer-" + mat.NomSociete;
            TabPage tabEditer = this.tabControl1.TabPages[tabEditerName];
         
          //  new ServiceSocietes
              if (new ServiceSocietes().Update(mat))
            {
                MessageBox.Show("Le  :" + mat.ToString() + " a été bien enregistrer");
            }
             else
            {
                MessageBox.Show("Le :" + mat.ToString() + " n'est pas enregistrer car il n'y a pas des modifications");
            }


            // Suppression de la page Editer
            this.tabControl1.TabPages.Remove(tabEditer);
           
            this. societeGrid1.Actualiser();

        }
        private void StagiaireForm_AnnulerEditerClick(object sender, EventArgs e)
        {
            FormSociete formMat = (FormSociete)sender;
            Classe.Societe Mater = formMat.Societe;
            string tabEditerName = "TabEditer-" + Mater.NomSociete;

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
                tabAjouterMatriel.Text = "Ajouter un matriel";
                tabAjouterMatriel.Name = "TabAjouter";
                tabAjouterMatriel.Height = 3000;
                tabControl1.TabPages.Add(tabAjouterMatriel);
                tabControl1.Height = 3000;
                tabControl1.SelectedTab = tabAjouterMatriel;

                // Insertion du formulaire 
                FormSociete MatrielForm = new FormSociete();
                MatrielForm.Name = "MatrielForm";

                MatrielForm.Height = 2000;
                this.tabControl1.TabPages["TabAjouter"].Controls.Add(MatrielForm);
                MatrielForm.EnregistrerClick += MatrielForm_EnregistrerClick;
                MatrielForm.AnnulerClick += MatrielForm_AnnulerAjouterClick;
            }
        }


        private void MatrielForm_EnregistrerClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabControl1.TabPages["TabAjouter"];
           FormSociete form = (FormSociete)tabAjouter.Controls
                 .Find("MatrielForm", false).First();

            if (new ServiceSocietes ().Ajouter(form.Societe))
            {
                MessageBox.Show("Le  :" + form.Societe.ToString() + " a été bien enregistrer");
            }
            else
            {
                MessageBox.Show("Le   :" + form.Societe.ToString() + " n'est pas enregistrer");
            }

            this.tabControl1.TabPages.Remove(tabAjouter);


            this.societeGrid1.Actualiser();
        }
        /// <summary>
        /// Annuler l'insertion d'un stagiaire
        /// </summary>
        private void MatrielForm_AnnulerAjouterClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabControl1.TabPages["TabAjouter"];
            tabControl1.TabPages.Remove(tabAjouter);
        }

        private void FormGestionCategorie_Load(object sender, EventArgs e)
        {
            societeGrid1.Actualiser();
            societeGrid1.EditerSocieteEvent += GridMatriel_EditerMatrielEvent;
        }

    }
}
           