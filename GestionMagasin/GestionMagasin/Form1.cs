using GestionMagasin.GestionEntrerSortie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMagasin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void matrielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMatriel.FormGestionMateriel form = new GestionMatriel.FormGestionMateriel();
            form.ShowDialog();
        }

        private void emplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEmplacement.FormGeEmplacement a = new GestionEmplacement.FormGeEmplacement();
            a.ShowDialog();
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestioncategorie.FormGestionCategorie a = new Gestioncategorie.FormGestionCategorie();
            a.ShowDialog();

        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionService.FormGestionService a = new GestionService.FormGestionService();
            a.ShowDialog();
        }

        private void livraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionLivraison.FormGestionLivraison a = new GestionLivraison.FormGestionLivraison();
            a.ShowDialog();
        }

        private void societeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionSociete.FormGestionSociete a = new GestionSociete.FormGestionSociete();
            a.ShowDialog();
        }

        private void entrerEtSortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMatChoix ab = new FormMatChoix();
            ab.ShowDialog();
        }
    }
}
