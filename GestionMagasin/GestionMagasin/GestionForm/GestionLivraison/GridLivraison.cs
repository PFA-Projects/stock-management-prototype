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

namespace GestionMagasin.GestionLivraison
{
    public partial class GridLivraison : UserControl
    {
        public GridLivraison()
        {
            InitializeComponent();
        }
        public event EventHandler EditerStagiaireEvent;
        public Livraison Current
        {
            get
            {
                return (Livraison)livraisonBindingSource.Current;
            }
        }
        public void Actualiser()
        {
            livraisonBindingSource.Clear();

            livraisonBindingSource.DataSource = new ServiceLivraison().ListStagiaires();

        }
        private void livraisonDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void livraisonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Supprimer
            if (e.ColumnIndex == livraisonDataGridView.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show(
                    "Voullez-vous vraimment supprimer ce stagiaire",
                    "Confirmation de supprision", MessageBoxButtons.YesNo))
                {
                    Livraison a = (Livraison)livraisonBindingSource.Current;
                    new ServiceLivraison().Supprimer(a.id);
                    this.Actualiser();
                }

            }
            // Editer
            if (e.ColumnIndex == livraisonDataGridView.Columns["Modifier"].Index && e.RowIndex >= 0)
            {

                EditerStagiaireEvent(sender, e);
            }
        }

    }
}
