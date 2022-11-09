namespace Prestamos.formularios
{
    partial class Sucursales
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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dgvSucursales = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(665, 394);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(124, 36);
            this.btnRefrescar.TabIndex = 19;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // dgvSucursales
            // 
            this.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursales.Location = new System.Drawing.Point(11, 11);
            this.dgvSucursales.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSucursales.Name = "dgvSucursales";
            this.dgvSucursales.RowHeadersWidth = 51;
            this.dgvSucursales.RowTemplate.Height = 24;
            this.dgvSucursales.Size = new System.Drawing.Size(650, 419);
            this.dgvSucursales.TabIndex = 16;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(665, 11);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 36);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Location = new System.Drawing.Point(665, 51);
            this.btnDeshacer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(124, 36);
            this.btnDeshacer.TabIndex = 21;
            this.btnDeshacer.Text = "Deshacer cambios";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dgvSucursales);
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.Sucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView dgvSucursales;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDeshacer;
    }
}