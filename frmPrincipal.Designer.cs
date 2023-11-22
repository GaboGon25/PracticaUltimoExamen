namespace PracticaUltimoExamen
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            publicacionToolStripMenuItem = new ToolStripMenuItem();
            ingresarLibroToolStripMenuItem = new ToolStripMenuItem();
            ingresarRevistaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { publicacionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1923, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // publicacionToolStripMenuItem
            // 
            publicacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarLibroToolStripMenuItem, ingresarRevistaToolStripMenuItem });
            publicacionToolStripMenuItem.Name = "publicacionToolStripMenuItem";
            publicacionToolStripMenuItem.Size = new Size(155, 38);
            publicacionToolStripMenuItem.Text = "Publicacion";
            // 
            // ingresarLibroToolStripMenuItem
            // 
            ingresarLibroToolStripMenuItem.Name = "ingresarLibroToolStripMenuItem";
            ingresarLibroToolStripMenuItem.Size = new Size(359, 44);
            ingresarLibroToolStripMenuItem.Text = "Ingresar Libro";
            ingresarLibroToolStripMenuItem.Click += ingresarLibroToolStripMenuItem_Click;
            // 
            // ingresarRevistaToolStripMenuItem
            // 
            ingresarRevistaToolStripMenuItem.Name = "ingresarRevistaToolStripMenuItem";
            ingresarRevistaToolStripMenuItem.Size = new Size(359, 44);
            ingresarRevistaToolStripMenuItem.Text = "Ingresar Revista";
            ingresarRevistaToolStripMenuItem.Click += ingresarRevistaToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1923, 794);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem publicacionToolStripMenuItem;
        private ToolStripMenuItem ingresarLibroToolStripMenuItem;
        private ToolStripMenuItem ingresarRevistaToolStripMenuItem;
    }
}