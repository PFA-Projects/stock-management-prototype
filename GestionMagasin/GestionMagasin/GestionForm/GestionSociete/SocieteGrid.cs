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

namespace GestionMagasin.GestionSociete
{
    public partial class SocieteGrid : UserControl
    {
        public SocieteGrid()
        {
            InitializeComponent();
        }

        //événements
        public event EventHandler EditerSocieteEvent;

        /// <summary>
        /// Obient le stagiaire séléctionner
        /// </summary>
        public Societe Current
        {
            get
            {
                return (Societe)societeBindingSource1.Current;
            }
        }
        public void Actualiser()
        {

            societeBindingSource1.DataSource = null;
            societeBindingSource1.DataSource = new ServiceSocietes().List();
            //      matrielBindingSource.DataSource = new StagiairesService().ListStagiaires();

        }
        
        private void societeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void societeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Supprimer
            if (e.ColumnIndex == societeDataGridView.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show(
                    "Voullez-vous vraimment supprimer ce societe",
                    "Confirmation de supprision", MessageBoxButtons.YesNo))
                {
                    Societe s = (Societe)societeBindingSource1.Current;
                    //      new StagiairesService().Supprimer(s.Id);
                    this.Actualiser();
                }

            }
            // Editer
            if (e.ColumnIndex == societeDataGridView.Columns["Modifier"].Index && e.RowIndex >= 0)
            {

                EditerSocieteEvent(sender, e);
            }
        }

        private void SocieteGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
