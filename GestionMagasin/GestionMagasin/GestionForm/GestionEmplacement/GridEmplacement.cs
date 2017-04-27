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

namespace GestionMagasin.GestionForm.GestionEmplacement
{
    public partial class GridEmplacement : UserControl
    {
        public GridEmplacement()
        {
            InitializeComponent();
        }

        public event EventHandler EditerStagiaireEvent;
        public Emplacement Current
        {
            get
            {
                return (Emplacement)emplacementBindingSource.Current;
            }
        }
        public void Actualiser()
        {
            emplacementBindingSource.Clear();

            emplacementBindingSource.DataSource = new ServiceEmplacement().ListStagiaires();

        }
        private void emplacementDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Supprimer
            if (e.ColumnIndex == emplacementDataGridView.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show(
                    "Voullez-vous vraimment supprimer ce Emplacement",
                    "Confirmation de supprision", MessageBoxButtons.YesNo))
                {
                    Emplacement a = (Emplacement)emplacementBindingSource.Current;
                    new ServiceEmplacement().Supprimer(a.id);
                    this.Actualiser();
                }

            }
            // Editer
            if (e.ColumnIndex == emplacementDataGridView.Columns["Modifier"].Index && e.RowIndex >= 0)
            {

                EditerStagiaireEvent(sender, e);
            }
        }

        private void GridEmplacement_Load(object sender, EventArgs e)
        {

        }
    }
}
