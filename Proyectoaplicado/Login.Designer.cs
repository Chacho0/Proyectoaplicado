namespace Proyecto_1
{
    partial class Frmlogin
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtClave = new Guna.UI.WinForms.GunaTextBox();
			this.Txtusuario = new Guna.UI.WinForms.GunaTextBox();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.PictureBox();
			this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
			this.btnacceder = new Guna.UI.WinForms.GunaAdvenceButton();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 245);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Contraseña";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(55, 191);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Usuario";
			// 
			// TxtClave
			// 
			this.TxtClave.BackColor = System.Drawing.Color.Transparent;
			this.TxtClave.BaseColor = System.Drawing.Color.White;
			this.TxtClave.BorderColor = System.Drawing.Color.Silver;
			this.TxtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TxtClave.FocusedBaseColor = System.Drawing.Color.White;
			this.TxtClave.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.TxtClave.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.TxtClave.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.TxtClave.Location = new System.Drawing.Point(147, 235);
			this.TxtClave.Name = "TxtClave";
			this.TxtClave.PasswordChar = '*';
			this.TxtClave.Radius = 8;
			this.TxtClave.SelectedText = "";
			this.TxtClave.Size = new System.Drawing.Size(160, 30);
			this.TxtClave.TabIndex = 12;
			this.TxtClave.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
			// 
			// Txtusuario
			// 
			this.Txtusuario.BackColor = System.Drawing.Color.Transparent;
			this.Txtusuario.BaseColor = System.Drawing.Color.White;
			this.Txtusuario.BorderColor = System.Drawing.Color.Silver;
			this.Txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Txtusuario.FocusedBaseColor = System.Drawing.Color.White;
			this.Txtusuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Txtusuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.Txtusuario.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Txtusuario.Location = new System.Drawing.Point(147, 181);
			this.Txtusuario.Name = "Txtusuario";
			this.Txtusuario.PasswordChar = '\0';
			this.Txtusuario.Radius = 8;
			this.Txtusuario.SelectedText = "";
			this.Txtusuario.Size = new System.Drawing.Size(160, 30);
			this.Txtusuario.TabIndex = 13;
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel2.Controls.Add(this.btnCerrar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(440, 34);
			this.panel2.TabIndex = 17;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.Location = new System.Drawing.Point(406, 3);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(29, 29);
			this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrar.TabIndex = 1;
			this.btnCerrar.TabStop = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// gunaCirclePictureBox1
			// 
			this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
			this.gunaCirclePictureBox1.Image = global::Proyectoaplicado.Properties.Resources.icons8_usuario_80;
			this.gunaCirclePictureBox1.Location = new System.Drawing.Point(168, 52);
			this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
			this.gunaCirclePictureBox1.Size = new System.Drawing.Size(120, 120);
			this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.gunaCirclePictureBox1.TabIndex = 18;
			this.gunaCirclePictureBox1.TabStop = false;
			this.gunaCirclePictureBox1.UseTransfarantBackground = false;
			// 
			// btnacceder
			// 
			this.btnacceder.AnimationHoverSpeed = 0.07F;
			this.btnacceder.AnimationSpeed = 0.03F;
			this.btnacceder.BackColor = System.Drawing.Color.Transparent;
			this.btnacceder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnacceder.BorderColor = System.Drawing.Color.Black;
			this.btnacceder.CheckedBaseColor = System.Drawing.Color.Gray;
			this.btnacceder.CheckedBorderColor = System.Drawing.Color.Black;
			this.btnacceder.CheckedForeColor = System.Drawing.Color.White;
			this.btnacceder.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnacceder.CheckedImage")));
			this.btnacceder.CheckedLineColor = System.Drawing.Color.DimGray;
			this.btnacceder.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnacceder.FocusedColor = System.Drawing.Color.Empty;
			this.btnacceder.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnacceder.ForeColor = System.Drawing.Color.White;
			this.btnacceder.Image = global::Proyectoaplicado.Properties.Resources.icons8_entrar_48;
			this.btnacceder.ImageSize = new System.Drawing.Size(20, 20);
			this.btnacceder.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnacceder.Location = new System.Drawing.Point(174, 284);
			this.btnacceder.Name = "btnacceder";
			this.btnacceder.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnacceder.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnacceder.OnHoverForeColor = System.Drawing.Color.White;
			this.btnacceder.OnHoverImage = null;
			this.btnacceder.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnacceder.OnPressedColor = System.Drawing.Color.Black;
			this.btnacceder.Radius = 10;
			this.btnacceder.Size = new System.Drawing.Size(98, 34);
			this.btnacceder.TabIndex = 16;
			this.btnacceder.Text = "Acceder";
			this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
			// 
			// Frmlogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 353);
			this.Controls.Add(this.gunaCirclePictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnacceder);
			this.Controls.Add(this.TxtClave);
			this.Controls.Add(this.Txtusuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frmlogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Frmlogin_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frmlogin_MouseDown);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private Guna.UI.WinForms.GunaTextBox TxtClave;
		private Guna.UI.WinForms.GunaTextBox Txtusuario;
		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaAdvenceButton btnacceder;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox btnCerrar;
		private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
	}
}