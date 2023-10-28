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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnventas = new Guna.UI.WinForms.GunaButton();
			this.btnpedidos = new Guna.UI.WinForms.GunaButton();
			this.btnproductos = new Guna.UI.WinForms.GunaButton();
			this.btncliente = new Guna.UI.WinForms.GunaButton();
			this.Devolver = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnventas);
			this.panel1.Controls.Add(this.btnpedidos);
			this.panel1.Controls.Add(this.btnproductos);
			this.panel1.Controls.Add(this.btncliente);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(159, 450);
			this.panel1.TabIndex = 44;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnventas
			// 
			this.btnventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnventas.AnimationHoverSpeed = 0.07F;
			this.btnventas.AnimationSpeed = 0.03F;
			this.btnventas.BackColor = System.Drawing.Color.Transparent;
			this.btnventas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnventas.BorderColor = System.Drawing.Color.Black;
			this.btnventas.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnventas.FocusedColor = System.Drawing.Color.Empty;
			this.btnventas.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnventas.ForeColor = System.Drawing.Color.White;
			this.btnventas.Image = null;
			this.btnventas.ImageSize = new System.Drawing.Size(20, 20);
			this.btnventas.Location = new System.Drawing.Point(3, 307);
			this.btnventas.Name = "btnventas";
			this.btnventas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnventas.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnventas.OnHoverForeColor = System.Drawing.Color.White;
			this.btnventas.OnHoverImage = null;
			this.btnventas.OnPressedColor = System.Drawing.Color.Black;
			this.btnventas.Radius = 10;
			this.btnventas.Size = new System.Drawing.Size(139, 42);
			this.btnventas.TabIndex = 45;
			this.btnventas.Text = "Ventas";
			this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
			// 
			// btnpedidos
			// 
			this.btnpedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnpedidos.AnimationHoverSpeed = 0.07F;
			this.btnpedidos.AnimationSpeed = 0.03F;
			this.btnpedidos.BackColor = System.Drawing.Color.Transparent;
			this.btnpedidos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnpedidos.BorderColor = System.Drawing.Color.Black;
			this.btnpedidos.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnpedidos.FocusedColor = System.Drawing.Color.Empty;
			this.btnpedidos.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnpedidos.ForeColor = System.Drawing.Color.White;
			this.btnpedidos.Image = null;
			this.btnpedidos.ImageSize = new System.Drawing.Size(20, 20);
			this.btnpedidos.Location = new System.Drawing.Point(3, 254);
			this.btnpedidos.Name = "btnpedidos";
			this.btnpedidos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnpedidos.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnpedidos.OnHoverForeColor = System.Drawing.Color.White;
			this.btnpedidos.OnHoverImage = null;
			this.btnpedidos.OnPressedColor = System.Drawing.Color.Black;
			this.btnpedidos.Radius = 10;
			this.btnpedidos.Size = new System.Drawing.Size(139, 42);
			this.btnpedidos.TabIndex = 45;
			this.btnpedidos.Text = "Pedidos";
			this.btnpedidos.Click += new System.EventHandler(this.btnpedidos_Click);
			// 
			// btnproductos
			// 
			this.btnproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnproductos.AnimationHoverSpeed = 0.07F;
			this.btnproductos.AnimationSpeed = 0.03F;
			this.btnproductos.BackColor = System.Drawing.Color.Transparent;
			this.btnproductos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnproductos.BorderColor = System.Drawing.Color.Black;
			this.btnproductos.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnproductos.FocusedColor = System.Drawing.Color.Empty;
			this.btnproductos.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnproductos.ForeColor = System.Drawing.Color.White;
			this.btnproductos.Image = null;
			this.btnproductos.ImageSize = new System.Drawing.Size(20, 20);
			this.btnproductos.Location = new System.Drawing.Point(3, 201);
			this.btnproductos.Name = "btnproductos";
			this.btnproductos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnproductos.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnproductos.OnHoverForeColor = System.Drawing.Color.White;
			this.btnproductos.OnHoverImage = null;
			this.btnproductos.OnPressedColor = System.Drawing.Color.Black;
			this.btnproductos.Radius = 10;
			this.btnproductos.Size = new System.Drawing.Size(139, 42);
			this.btnproductos.TabIndex = 45;
			this.btnproductos.Text = "Productos";
			this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
			// 
			// btncliente
			// 
			this.btncliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btncliente.AnimationHoverSpeed = 0.07F;
			this.btncliente.AnimationSpeed = 0.03F;
			this.btncliente.BackColor = System.Drawing.Color.Transparent;
			this.btncliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btncliente.BorderColor = System.Drawing.Color.Black;
			this.btncliente.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btncliente.FocusedColor = System.Drawing.Color.Empty;
			this.btncliente.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btncliente.ForeColor = System.Drawing.Color.White;
			this.btncliente.Image = null;
			this.btncliente.ImageSize = new System.Drawing.Size(20, 20);
			this.btncliente.Location = new System.Drawing.Point(3, 149);
			this.btncliente.Name = "btncliente";
			this.btncliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btncliente.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btncliente.OnHoverForeColor = System.Drawing.Color.White;
			this.btncliente.OnHoverImage = null;
			this.btncliente.OnPressedColor = System.Drawing.Color.Black;
			this.btncliente.Radius = 10;
			this.btncliente.Size = new System.Drawing.Size(139, 42);
			this.btncliente.TabIndex = 45;
			this.btncliente.Text = "Clientes";
			this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
			// 
			// Devolver
			// 
			this.Devolver.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Devolver.Location = new System.Drawing.Point(159, 0);
			this.Devolver.Name = "Devolver";
			this.Devolver.Size = new System.Drawing.Size(713, 450);
			this.Devolver.TabIndex = 45;
			// 
			// Frmreporte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 450);
			this.Controls.Add(this.Devolver);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frmreporte";
			this.Text = "reportes";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.Panel panel1;
		private Guna.UI.WinForms.GunaButton btnproductos;
		private Guna.UI.WinForms.GunaButton btncliente;
		private Guna.UI.WinForms.GunaButton btnpedidos;
		private Guna.UI.WinForms.GunaButton btnventas;
		private System.Windows.Forms.Panel Devolver;
	}
}

