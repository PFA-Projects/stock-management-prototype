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

namespace GestionMagasin.GestionMatriel
{
    public partial class MaterielGrid : UserControl
    {
        public MaterielGrid()
        {
            InitializeComponent();
        }


        //événements
        public event EventHandler EditerStagiaireEvent;

        /// <summary>
        /// Obient le stagiaire séléctionner
        /// </summary>
        public  Matriel Current
        {
            get
            {
                return (Matriel)matrielBindingSource.Current;
            }
        }


        public void Actualiser()
        {
            matrielBindingSource.Clear();
        matrielBindingSource.DataSource = new ServiceMatriel().ListStagiaires();

        }
        private void MaterielGrid_Load(object sender, EventArgs e)
        {

        }


        private void dataGridViewStagiaires_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void matrielDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Supprimer
            if (e.ColumnIndex == matrielDataGridView.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show(
                    "Voullez-vous vraimment supprimer ce stagiaire",
                    "Confirmation de supprision", MessageBoxButtons.YesNo))
                {
                    Matriel s = (Matriel)matrielBindingSource.Current;
                    new ServiceMatriel().Supprimer(s.NumeroInvontaire);
                    //      new StagiairesService().Supprimer(s.Id);
                    this.Actualiser();
                }

            }
            // Editer
            if (e.ColumnIndex == matrielDataGridView.Columns["Modifier"].Index && e.RowIndex >= 0)
            {

                EditerStagiaireEvent(sender, e);

            }
        }

       
    }
}
