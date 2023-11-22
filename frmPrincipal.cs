using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaUltimoExamen
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ingresarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibro frmLibro = new frmLibro();
            frmLibro.ShowDialog();
        }

        private void ingresarRevistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRevista frmRevista = new frmRevista();
            frmRevista.ShowDialog();
        }
    }
}
