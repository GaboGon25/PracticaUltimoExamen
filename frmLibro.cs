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
    public partial class frmLibro : Form
    {
        public List<Libros> libros = new List<Libros>();
        public frmLibro()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtAutorLibro.Clear();
            txtCostoLibro.Clear();
            txtTtituloLibro.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            libros.Add(new Libros
            {
                Titulo = txtTtituloLibro.Text,
                Autor = txtAutorLibro.Text,
                FechaPublicacion = DateTime.Parse(dtpFechaLibro.Text),
                Costo = Int32.Parse(txtCostoLibro.Text),

            });
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libros;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            libros.Add(new Libros
            {
                Titulo = txtTtituloLibro.Text,
                Autor = txtAutorLibro.Text,
                FechaPublicacion = DateTime.Parse(dtpFechaLibro.Text),
                Costo = Int32.Parse(txtCostoLibro.Text),

            });
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libros;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var AutorConMasLibros = libros.OfType<Libros>()
                .GroupBy(libro => libro.Autor)
                .OrderByDescending(grupo => grupo.Count())
                .FirstOrDefault()?.Key;

            if(AutorConMasLibros != null)
            {
                var CantidadLibrosAutorConMasLibros = libros.OfType<Libros>()
                    .Count(libro => libro.Autor == AutorConMasLibros);

                textBox1.Text = AutorConMasLibros;
                textBox2.Text = Convert.ToString(CantidadLibrosAutorConMasLibros);
            }
        }
    }
}
