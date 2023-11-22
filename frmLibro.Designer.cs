namespace PracticaUltimoExamen
{
    partial class frmLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            dtpFechaLibro = new DateTimePicker();
            txtCostoLibro = new TextBox();
            txtAutorLibro = new TextBox();
            txtTtituloLibro = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            tabPage2 = new TabPage();
            dgvLibros = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnBuscar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(16, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1773, 703);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLimpiar);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnGuardar);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1757, 587);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1091, 397);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(297, 129);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "NUEVOS DATOS";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFechaLibro);
            groupBox1.Controls.Add(txtCostoLibro);
            groupBox1.Controls.Add(txtAutorLibro);
            groupBox1.Controls.Add(txtTtituloLibro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(169, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1219, 291);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL LIBRO";
            // 
            // dtpFechaLibro
            // 
            dtpFechaLibro.Location = new Point(758, 74);
            dtpFechaLibro.Name = "dtpFechaLibro";
            dtpFechaLibro.Size = new Size(362, 39);
            dtpFechaLibro.TabIndex = 7;
            // 
            // txtCostoLibro
            // 
            txtCostoLibro.Location = new Point(572, 212);
            txtCostoLibro.Name = "txtCostoLibro";
            txtCostoLibro.Size = new Size(369, 39);
            txtCostoLibro.TabIndex = 6;
            // 
            // txtAutorLibro
            // 
            txtAutorLibro.Location = new Point(95, 216);
            txtAutorLibro.Name = "txtAutorLibro";
            txtAutorLibro.Size = new Size(369, 39);
            txtAutorLibro.TabIndex = 5;
            // 
            // txtTtituloLibro
            // 
            txtTtituloLibro.Location = new Point(102, 74);
            txtTtituloLibro.Name = "txtTtituloLibro";
            txtTtituloLibro.Size = new Size(369, 39);
            txtTtituloLibro.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 222);
            label4.Name = "label4";
            label4.Size = new Size(89, 32);
            label4.TabIndex = 3;
            label4.Text = "COSTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 74);
            label3.Name = "label3";
            label3.Size = new Size(275, 32);
            label3.TabIndex = 2;
            label3.Text = "FECHA DE PUBLICACION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 219);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 1;
            label2.Text = "AUTOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 74);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 0;
            label1.Text = "TITULO";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(169, 416);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(297, 129);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnBuscar);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dgvLibros);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1757, 649);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ver Tabla";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(368, 18);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 82;
            dgvLibros.RowTemplate.Height = 41;
            dgvLibros.Size = new Size(848, 334);
            dgvLibros.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 401);
            label5.Name = "label5";
            label5.Size = new Size(286, 32);
            label5.TabIndex = 1;
            label5.Text = "AUTOR CON MAS LIBROS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 496);
            label6.Name = "label6";
            label6.Size = new Size(129, 32);
            label6.TabIndex = 2;
            label6.Text = "CANTIDAD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(554, 401);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(554, 493);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 39);
            textBox2.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(914, 396);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(303, 133);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "VER";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmLibro
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1849, 737);
            Controls.Add(tabControl1);
            Name = "frmLibro";
            Text = "frmLibro";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private DateTimePicker dtpFechaLibro;
        private TextBox txtCostoLibro;
        private TextBox txtAutorLibro;
        private TextBox txtTtituloLibro;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLimpiar;
        private Button btnGuardar;
        private DataGridView dgvLibros;
        private Button btnBuscar;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
    }
}