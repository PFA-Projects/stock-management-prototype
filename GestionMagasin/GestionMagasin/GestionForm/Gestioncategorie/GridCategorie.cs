using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionMagasin.Classe;

namespace GestionMagasin.Gestioncategorie
{
    public partial class GridCategorie : UserControl
    {
        public GridCategorie()
        {
            InitializeComponent();
        }
        public event EventHandler EditerStagiaireEvent;

        public Categorie_Matriel Current
        {
            get
            {
                return (Categorie_Matriel)categorie_MatrielBindingSource.Current;
            }
        }
        public void Actualiser()
        {
            categorie_MatrielBindingSource.Clear();
            categorie_MatrielBindingSource.DataSource = new ServiceCategorie().ListStagiaires();

        }

        private void GridCategorie_Load(object sender, EventArgs e)
        {
          
/*
            DataGridViewImageColumn imageColun = new DataGridViewImageColumn();
            imageColun.Name = "Supprimer";
            imageColun.HeaderText = "Supprimer";
            Image ii = Image.FromFile(@"C:\Users\Hanae\Desktop\GestionMagasin\GestionMagasin\Resources\delete.png");
            imageColun.Image = ii;
            categorie_MatrielDataGridView.Columns.Add(imageColun);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Modifier";
            imageColumn.HeaderText = "Modifier";
            Image i = Image.FromFile(@"C:\Users\Hanae\Desktop\GestionMagasin\GestionMagasin\Resources\edit.png");
            imageColumn.Image = i;
            categorie_MatrielDataGridView.Columns.Add(imageColumn);*/
        }
      

        private void categorie_MatrielDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // Supprimer
            if (e.ColumnIndex == categorie_MatrielDataGridView.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show(
                    "Voullez-vous vraimment supprimer ce stagiaire",
                    "Confirmation de supprision", MessageBoxButtons.YesNo))
                {
                    Categorie_Matriel s = (Categorie_Matriel)categorie_MatrielBindingSource.Current;
                    //      new StagiairesService().Supprimer(s.Id);
                    this.Actualiser();
                }

            }
            // Editer
            if (e.ColumnIndex == categorie_MatrielDataGridView.Columns["Modifier"].Index && e.RowIndex >= 0)
            {

                EditerStagiaireEvent(sender, e);
            }

        }
    }
}
