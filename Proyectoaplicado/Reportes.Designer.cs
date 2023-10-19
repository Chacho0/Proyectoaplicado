namespace Proyectoaplicado
{
    partial class Frmreporte
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.Devolver = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Txtid = new Guna.UI.WinForms.GunaTextBox();
			this.txtproveedor = new Guna.UI.WinForms.GunaTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnbuscar = new Guna.UI.WinForms.GunaAdvenceButton();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.reportViewer1.Location = new System.Drawing.Point(0, 164);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(860, 286);
			this.reportViewer1.TabIndex = 0;
			// 
			// Devolver
			// 
			this.Devolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Devolver.Image = global::Proyectoaplicado.Properties.Resources.atras;
			this.Devolver.Location = new System.Drawing.Point(827, 1);
			this.Devolver.Name = "Devolver";
			this.Devolver.Size = new System.Drawing.Size(32, 28);
			this.Devolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Devolver.TabIndex = 38;
			this.Devolver.TabStop = false;
			this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(262, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 39;
			// 
			// Txtid
			// 
			this.Txtid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Txtid.BackColor = System.Drawing.Color.Transparent;
			this.Txtid.BaseColor = System.Drawing.Color.White;
			this.Txtid.BorderColor = System.Drawing.Color.Silver;
			this.Txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Txtid.FocusedBaseColor = System.Drawing.Color.White;
			this.Txtid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Txtid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.Txtid.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Txtid.Location = new System.Drawing.Point(77, 114);
			this.Txtid.Name = "Txtid";
			this.Txtid.PasswordChar = '\0';
			this.Txtid.Radius = 5;
			this.Txtid.SelectedText = "";
			this.Txtid.Size = new System.Drawing.Size(160, 30);
			this.Txtid.TabIndex = 42;
			this.Txtid.Visible = false;
			// 
			// txtproveedor
			// 
			this.txtproveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtproveedor.BackColor = System.Drawing.Color.Transparent;
			this.txtproveedor.BaseColor = System.Drawing.Color.White;
			this.txtproveedor.BorderColor = System.Drawing.Color.Silver;
			this.txtproveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtproveedor.FocusedBaseColor = System.Drawing.Color.White;
			this.txtproveedor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtproveedor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtproveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtproveedor.Location = new System.Drawing.Point(77, 114);
			this.txtproveedor.Name = "txtproveedor";
			this.txtproveedor.PasswordChar = '\0';
			this.txtproveedor.Radius = 5;
			this.txtproveedor.SelectedText = "";
			this.txtproveedor.Size = new System.Drawing.Size(160, 30);
			this.txtproveedor.TabIndex = 41;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 16);
			this.label2.TabIndex = 40;
			this.label2.Text = "Buscar";
			// 
			// btnbuscar
			// 
			this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnbuscar.AnimationHoverSpeed = 0.07F;
			this.btnbuscar.AnimationSpeed = 0.03F;
			this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
			this.btnbuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnbuscar.BorderColor = System.Drawing.Color.Black;
			this.btnbuscar.CheckedBaseColor = System.Drawing.Color.Gray;
			this.btnbuscar.CheckedBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.CheckedForeColor = System.Drawing.Color.White;
			this.btnbuscar.CheckedImage = null;
			this.btnbuscar.CheckedLineColor = System.Drawing.Color.DimGray;
			this.btnbuscar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnbuscar.FocusedColor = System.Drawing.Color.Empty;
			this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnbuscar.ForeColor = System.Drawing.Color.White;
			this.btnbuscar.Image = global::Proyectoaplicado.Properties.Resources.icons8_buscar_50;
			this.btnbuscar.ImageSize = new System.Drawing.Size(20, 20);
			this.btnbuscar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnbuscar.Location = new System.Drawing.Point(265, 114);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 10;
			this.btnbuscar.Size = new System.Drawing.Size(84, 30);
			this.btnbuscar.TabIndex = 43;
			this.btnbuscar.Text = "Buscar";
			// 
			// Frmreporte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(860, 450);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.Txtid);
			this.Controls.Add(this.txtproveedor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Devolver);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frmreporte";
			this.Text = "reportes";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.PictureBox Devolver;
		private System.Windows.Forms.Label label1;
		private Guna.UI.WinForms.GunaTextBox Txtid;
		private Guna.UI.WinForms.GunaTextBox txtproveedor;
		private System.Windows.Forms.Label label2;
		private Guna.UI.WinForms.GunaAdvenceButton btnbuscar;
	}
}

