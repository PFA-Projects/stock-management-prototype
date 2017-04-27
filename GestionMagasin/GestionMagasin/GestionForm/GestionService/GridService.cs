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

namespace GestionMagasin.GestionService
{
    public partial class GridService : UserControl
    {
        public GridService()
        {
            InitializeComponent();
        }


        //événements
        public event EventHandler EditerStagiaireEvent;

        /// <summary>
        /// Obient le stagiaire séléctionner
        /// </summary>
        public Service Current
        {
            get
            {
                return (Service)serviceBindingSource.Current;
            }
        }


        public void Actualiser()
        {
            serviceBindingSource.Clear();
            serviceBindingSource.DataSource = new ServiceServices().List();
        }
        private void MaterielGrid_Load(object sender, EventArgs e)
        {

        }


        private void societeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {            // Supprimer

            if (e.ColumnIndex == societeDataGridView.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show(
                    "Voullez-vous vraimment supprimer ce stagiaire",
                    "Confirmation de supprision", MessageBoxButtons.YesNo))
                {
                    Service a = (Service)serviceBindingSource.Current;
               //     Matriel s = (Matriel)matrielBindingSource.Current;
                    new ServiceServices().Supprimer(a.id);
                    this.Actualiser();
                }

            }
            // Editer
            if (e.ColumnIndex == societeDataGridView.Columns["Modifier"].Index && e.RowIndex >= 0)
            {

                EditerStagiaireEvent(sender, e);
            }
        }


        private void societeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void societeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Supprimer

            if (e.ColumnIndex == societeDataGridView.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show(
                    "Voullez-vous vraimment supprimer ce stagiaire",
                    "Confirmation de supprision", MessageBoxButtons.YesNo))
                {
                    Service a = (Service)serviceBindingSource.Current;
                    //     Matriel s = (Matriel)matrielBindingSource.Current;
                    new ServiceServices().Supprimer(a.id);
                    this.Actualiser();
                }

            }
            // Editer
            if (e.ColumnIndex == societeDataGridView.Columns["Modifier"].Index && e.RowIndex >= 0)
            {

                EditerStagiaireEvent(sender, e);
            }
        }
    }
}
