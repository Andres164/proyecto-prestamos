namespace Prestamos.formularios
{
    partial class Prestamos
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
            this.btnPagarPrestamo = new System.Windows.Forms.Button();
            this.btnNuevoPrestamo = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnGenerarResumen = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagarPrestamo
            // 
            this.btnPagarPrestamo.Location = new System.Drawing.Point(665, 94);
            this.btnPagarPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagarPrestamo.Name = "btnPagarPrestamo";
            this.btnPagarPrestamo.Size = new System.Drawing.Size(124, 36);
            this.btnPagarPrestamo.TabIndex = 25;
            this.btnPagarPrestamo.Text = "Pagar Prestamo";
            this.btnPagarPrestamo.UseVisualStyleBackColor = true;
            // 
            // btnNuevoPrestamo
            // 
            this.btnNuevoPrestamo.Location = new System.Drawing.Point(665, 54);
            this.btnNuevoPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            this.btnNuevoPrestamo.Size = new System.Drawing.Size(124, 36);
            this.btnNuevoPrestamo.TabIndex = 24;
            this.btnNuevoPrestamo.Text = "Nuevo prestamo";
            this.btnNuevoPrestamo.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(665, 437);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(124, 36);
            this.btnRefrescar.TabIndex = 23;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(11, 54);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(650, 419);
            this.dgvPrestamos.TabIndex = 22;
            // 
            // btnGenerarResumen
            // 
            this.btnGenerarResumen.Location = new System.Drawing.Point(665, 397);
            this.btnGenerarResumen.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarResumen.Name = "btnGenerarResumen";
            this.btnGenerarResumen.Size = new System.Drawing.Size(124, 36);
            this.btnGenerarResumen.TabIndex = 27;
            this.btnGenerarResumen.Text = "Generar resumen";
            this.btnGenerarResumen.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 29);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGenerarResumen);
            this.Controls.Add(this.btnPagarPrestamo);
            this.Controls.Add(this.btnNuevoPrestamo);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dgvPrestamos);
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPagarPrestamo;
        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnGenerarResumen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}