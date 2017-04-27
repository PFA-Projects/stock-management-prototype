using GestionMagasin.Classe;
using GestionMagasin.GestionMatriel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin.GestionEntrerSortie
{
    public partial class FormMatChoix : Form
    {
        public FormMatChoix()
        {
            InitializeComponent();
        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {
            List<Matriel> ls = new List<Matriel>();
            ls.Add(new ServiceMatriel().RechercheParId(numeroInvontaireTextBox.Text));
            if (ls.Count != 0)
            {
                panel1.Visible = true;
                matrielDataGridView.DataSource = null;
                matrielDataGridView.DataSource = ls;
            }
            else
            {
                MessageBox.Show("numero errone");
            }/*
            panel1.Visible = true;
            matrielBindingSource.Clear();
            List<Matriel> ls = new List<Matriel>();
            ls.Add(new ServiceMatriel().RechercheParId(numeroInvontaireTextBox.Text));
            matrielBindingSource.DataSource = ls;*/
        }

      //  Matriel lm = new Matriel();
        private void matrielDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void button_suiv_Click(object sender, EventArgs e)
        {
          /*  FormSortie a = new FormSortie();
            a.afficher(l);*/
        }

        
        private void matrielDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == matrielDataGridView.Columns["Sortie"].Index && e.RowIndex >= 0)
            {

                 string a = (string)matrielDataGridView.SelectedRows[0].Cells[0].Value;
                Matriel c = (Matriel)matrielBindingSource.Current;
                FormSortie ab = new FormSortie();
                ab.afficher(a);

                ab.ShowDialog();
            }

        }
    }
}
