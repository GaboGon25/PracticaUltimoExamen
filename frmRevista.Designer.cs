namespace PracticaUltimoExamen
{
    partial class frmRevista
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
            groupBox1 = new GroupBox();
            cboPeriodicidad = new ComboBox();
            txtCostoRevista = new TextBox();
            txtTituloRevista = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvRevistas = new DataGridView();
            btnGuardar = new Button();
            btnNuevo = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevistas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboPeriodicidad);
            groupBox1.Controls.Add(txtCostoRevista);
            groupBox1.Controls.Add(txtTituloRevista);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(68, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(999, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DE REVISTA";
            // 
            // cboPeriodicidad
            // 
            cboPeriodicidad.FormattingEnabled = true;
            cboPeriodicidad.Items.AddRange(new object[] { "Mensual", "Semanal", "Quincenal" });
            cboPeriodicidad.Location = new Point(210, 203);
            cboPeriodicidad.Name = "cboPeriodicidad";
            cboPeriodicidad.Size = new Size(278, 40);
            cboPeriodicidad.TabIndex = 5;
            // 
            // txtCostoRevista
            // 
            txtCostoRevista.Location = new Point(615, 113);
            txtCostoRevista.Name = "txtCostoRevista";
            txtCostoRevista.Size = new Size(357, 39);
            txtCostoRevista.TabIndex = 4;
            // 
            // txtTituloRevista
            // 
            txtTituloRevista.Location = new Point(131, 65);
            txtTituloRevista.Name = "txtTituloRevista";
            txtTituloRevista.Size = new Size(357, 39);
            txtTituloRevista.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 211);
            label3.Name = "label3";
            label3.Size = new Size(169, 32);
            label3.TabIndex = 2;
            label3.Text = "PERIODICIDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(520, 120);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 1;
            label2.Text = "COSTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 72);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 0;
            label1.Text = "TITULO";
            // 
            // dgvRevistas
            // 
            dgvRevistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevistas.Location = new Point(68, 385);
            dgvRevistas.Name = "dgvRevistas";
            dgvRevistas.RowHeadersWidth = 82;
            dgvRevistas.RowTemplate.Height = 41;
            dgvRevistas.Size = new Size(1352, 273);
            dgvRevistas.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1127, 72);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(309, 105);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(1127, 232);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(309, 105);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "NUEVOS DATOS";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmRevista
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 809);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(dgvRevistas);
            Controls.Add(groupBox1);
            Name = "frmRevista";
            Text = "frmRevista";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevistas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvRevistas;
        private ComboBox cboPeriodicidad;
        private TextBox txtCostoRevista;
        private TextBox txtTituloRevista;
        private Button btnGuardar;
        private Button btnNuevo;
    }
}