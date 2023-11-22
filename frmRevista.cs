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
    public partial class frmRevista : Form
    {
        public List<Revistas> revistas = new List<Revistas>();
        public frmRevista()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtCostoRevista.Clear();
            txtTituloRevista.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            revistas.Add(new Revistas
            {
                Titulo = txtTituloRevista.Text,
                Costo = Int32.Parse(txtCostoRevista.Text),
                Periodicidad = cboPeriodicidad.Text,


            });
            dgvRevistas.DataSource = null;
            dgvRevistas.DataSource = revistas;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
