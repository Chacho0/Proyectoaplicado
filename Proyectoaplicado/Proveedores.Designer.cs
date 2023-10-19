namespace Proyectoaplicado
{
	partial class FrmProveedores
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtproveedor = new Guna.UI.WinForms.GunaTextBox();
			this.txttelefono = new Guna.UI.WinForms.GunaTextBox();
			this.txtdireccion = new Guna.UI.WinForms.GunaTextBox();
			this.txtcategoria = new Guna.UI.WinForms.GunaTextBox();
			this.txtbuscar = new Guna.UI.WinForms.GunaTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtemail = new Guna.UI.WinForms.GunaTextBox();
			this.Txtid = new Guna.UI.WinForms.GunaTextBox();
			this.dvgproveedores = new Guna.UI.WinForms.GunaDataGridView();
			this.Devolver = new System.Windows.Forms.PictureBox();
			this.btnEliminar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnmodificar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnbuscar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnRegistrar = new Guna.UI.WinForms.GunaAdvenceButton();
			((System.ComponentModel.ISupportInitialize)(this.dvgproveedores)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(55, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 26;
			this.label3.Text = "Dirección";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 26;
			this.label1.Text = "Proveedor";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(55, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 26;
			this.label2.Text = "Télefono";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(324, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 16);
			this.label4.TabIndex = 26;
			this.label4.Text = "Categoria";
			// 
			// txtproveedor
			// 
			this.txtproveedor.BackColor = System.Drawing.Color.Transparent;
			this.txtproveedor.BaseColor = System.Drawing.Color.White;
			this.txtproveedor.BorderColor = System.Drawing.Color.Silver;
			this.txtproveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtproveedor.FocusedBaseColor = System.Drawing.Color.White;
			this.txtproveedor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtproveedor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtproveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtproveedor.Location = new System.Drawing.Point(130, 29);
			this.txtproveedor.Name = "txtproveedor";
			this.txtproveedor.PasswordChar = '\0';
			this.txtproveedor.Radius = 5;
			this.txtproveedor.SelectedText = "";
			this.txtproveedor.Size = new System.Drawing.Size(160, 30);
			this.txtproveedor.TabIndex = 27;
			this.txtproveedor.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
			// 
			// txttelefono
			// 
			this.txttelefono.BackColor = System.Drawing.Color.Transparent;
			this.txttelefono.BaseColor = System.Drawing.Color.White;
			this.txttelefono.BorderColor = System.Drawing.Color.Silver;
			this.txttelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttelefono.FocusedBaseColor = System.Drawing.Color.White;
			this.txttelefono.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txttelefono.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txttelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttelefono.Location = new System.Drawing.Point(130, 104);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.PasswordChar = '\0';
			this.txttelefono.Radius = 5;
			this.txttelefono.SelectedText = "";
			this.txttelefono.Size = new System.Drawing.Size(160, 30);
			this.txttelefono.TabIndex = 27;
			// 
			// txtdireccion
			// 
			this.txtdireccion.BackColor = System.Drawing.Color.Transparent;
			this.txtdireccion.BaseColor = System.Drawing.Color.White;
			this.txtdireccion.BorderColor = System.Drawing.Color.Silver;
			this.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtdireccion.FocusedBaseColor = System.Drawing.Color.White;
			this.txtdireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtdireccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtdireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtdireccion.Location = new System.Drawing.Point(130, 174);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.PasswordChar = '\0';
			this.txtdireccion.Radius = 5;
			this.txtdireccion.SelectedText = "";
			this.txtdireccion.Size = new System.Drawing.Size(160, 30);
			this.txtdireccion.TabIndex = 27;
			// 
			// txtcategoria
			// 
			this.txtcategoria.BackColor = System.Drawing.Color.Transparent;
			this.txtcategoria.BaseColor = System.Drawing.Color.White;
			this.txtcategoria.BorderColor = System.Drawing.Color.Silver;
			this.txtcategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtcategoria.FocusedBaseColor = System.Drawing.Color.White;
			this.txtcategoria.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtcategoria.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtcategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtcategoria.Location = new System.Drawing.Point(414, 32);
			this.txtcategoria.Name = "txtcategoria";
			this.txtcategoria.PasswordChar = '\0';
			this.txtcategoria.Radius = 5;
			this.txtcategoria.SelectedText = "";
			this.txtcategoria.Size = new System.Drawing.Size(160, 30);
			this.txtcategoria.TabIndex = 27;
			// 
			// txtbuscar
			// 
			this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtbuscar.BackColor = System.Drawing.Color.Transparent;
			this.txtbuscar.BaseColor = System.Drawing.Color.White;
			this.txtbuscar.BorderColor = System.Drawing.Color.Silver;
			this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtbuscar.FocusedBaseColor = System.Drawing.Color.White;
			this.txtbuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtbuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtbuscar.Location = new System.Drawing.Point(12, 321);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.PasswordChar = '\0';
			this.txtbuscar.Radius = 5;
			this.txtbuscar.SelectedText = "";
			this.txtbuscar.Size = new System.Drawing.Size(146, 30);
			this.txtbuscar.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(18, 302);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 16);
			this.label6.TabIndex = 29;
			this.label6.Text = "Buscar Proveedor";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(347, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "Email";
			// 
			// txtemail
			// 
			this.txtemail.BackColor = System.Drawing.Color.Transparent;
			this.txtemail.BaseColor = System.Drawing.Color.White;
			this.txtemail.BorderColor = System.Drawing.Color.Silver;
			this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtemail.FocusedBaseColor = System.Drawing.Color.White;
			this.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtemail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtemail.Location = new System.Drawing.Point(414, 90);
			this.txtemail.Name = "txtemail";
			this.txtemail.PasswordChar = '\0';
			this.txtemail.Radius = 5;
			this.txtemail.SelectedText = "";
			this.txtemail.Size = new System.Drawing.Size(160, 30);
			this.txtemail.TabIndex = 27;
			// 
			// Txtid
			// 
			this.Txtid.BackColor = System.Drawing.Color.Transparent;
			this.Txtid.BaseColor = System.Drawing.Color.White;
			this.Txtid.BorderColor = System.Drawing.Color.Silver;
			this.Txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Txtid.FocusedBaseColor = System.Drawing.Color.White;
			this.Txtid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Txtid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.Txtid.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Txtid.Location = new System.Drawing.Point(130, 29);
			this.Txtid.Name = "Txtid";
			this.Txtid.PasswordChar = '\0';
			this.Txtid.Radius = 5;
			this.Txtid.SelectedText = "";
			this.Txtid.Size = new System.Drawing.Size(160, 30);
			this.Txtid.TabIndex = 35;
			this.Txtid.Visible = false;
			// 
			// dvgproveedores
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dvgproveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dvgproveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvgproveedores.BackgroundColor = System.Drawing.Color.White;
			this.dvgproveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dvgproveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvgproveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dvgproveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dvgproveedores.ColumnHeadersHeight = 20;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dvgproveedores.DefaultCellStyle = dataGridViewCellStyle6;
			this.dvgproveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dvgproveedores.EnableHeadersVisualStyles = false;
			this.dvgproveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgproveedores.Location = new System.Drawing.Point(0, 353);
			this.dvgproveedores.Name = "dvgproveedores";
			this.dvgproveedores.RowHeadersVisible = false;
			this.dvgproveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dvgproveedores.Size = new System.Drawing.Size(774, 154);
			this.dvgproveedores.TabIndex = 36;
			this.dvgproveedores.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dvgproveedores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dvgproveedores.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dvgproveedores.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dvgproveedores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dvgproveedores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dvgproveedores.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dvgproveedores.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgproveedores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dvgproveedores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dvgproveedores.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvgproveedores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dvgproveedores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dvgproveedores.ThemeStyle.HeaderStyle.Height = 20;
			this.dvgproveedores.ThemeStyle.ReadOnly = false;
			this.dvgproveedores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dvgproveedores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvgproveedores.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvgproveedores.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dvgproveedores.ThemeStyle.RowsStyle.Height = 22;
			this.dvgproveedores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgproveedores.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// Devolver
			// 
			this.Devolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Devolver.Image = global::Proyectoaplicado.Properties.Resources.atras;
			this.Devolver.Location = new System.Drawing.Point(739, 2);
			this.Devolver.Name = "Devolver";
			this.Devolver.Size = new System.Drawing.Size(32, 30);
			this.Devolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Devolver.TabIndex = 37;
			this.Devolver.TabStop = false;
			this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEliminar.AnimationHoverSpeed = 0.07F;
			this.btnEliminar.AnimationSpeed = 0.03F;
			this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnEliminar.BorderColor = System.Drawing.Color.Black;
			this.btnEliminar.CheckedBaseColor = System.Drawing.Color.Gray;
			this.btnEliminar.CheckedBorderColor = System.Drawing.Color.Black;
			this.btnEliminar.CheckedForeColor = System.Drawing.Color.White;
			this.btnEliminar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.CheckedImage")));
			this.btnEliminar.CheckedLineColor = System.Drawing.Color.DimGray;
			this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnEliminar.ForeColor = System.Drawing.Color.White;
			this.btnEliminar.Image = global::Proyectoaplicado.Properties.Resources.icons8_eliminar_26;
			this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
			this.btnEliminar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnEliminar.Location = new System.Drawing.Point(453, 321);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnEliminar.OnHoverImage = null;
			this.btnEliminar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
			this.btnEliminar.Radius = 10;
			this.btnEliminar.Size = new System.Drawing.Size(89, 30);
			this.btnEliminar.TabIndex = 33;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnmodificar
			// 
			this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnmodificar.AnimationHoverSpeed = 0.07F;
			this.btnmodificar.AnimationSpeed = 0.03F;
			this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
			this.btnmodificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnmodificar.BorderColor = System.Drawing.Color.Black;
			this.btnmodificar.CheckedBaseColor = System.Drawing.Color.Gray;
			this.btnmodificar.CheckedBorderColor = System.Drawing.Color.Black;
			this.btnmodificar.CheckedForeColor = System.Drawing.Color.White;
			this.btnmodificar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnmodificar.CheckedImage")));
			this.btnmodificar.CheckedLineColor = System.Drawing.Color.DimGray;
			this.btnmodificar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnmodificar.FocusedColor = System.Drawing.Color.Empty;
			this.btnmodificar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnmodificar.ForeColor = System.Drawing.Color.White;
			this.btnmodificar.Image = global::Proyectoaplicado.Properties.Resources.icons8_editar_propiedad_30;
			this.btnmodificar.ImageSize = new System.Drawing.Size(20, 20);
			this.btnmodificar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnmodificar.Location = new System.Drawing.Point(352, 321);
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnmodificar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnmodificar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnmodificar.OnHoverImage = null;
			this.btnmodificar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnmodificar.OnPressedColor = System.Drawing.Color.Black;
			this.btnmodificar.Radius = 10;
			this.btnmodificar.Size = new System.Drawing.Size(96, 30);
			this.btnmodificar.TabIndex = 34;
			this.btnmodificar.Text = "Modificar";
			this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
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
			this.btnbuscar.Location = new System.Drawing.Point(164, 321);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 10;
			this.btnbuscar.Size = new System.Drawing.Size(84, 30);
			this.btnbuscar.TabIndex = 32;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRegistrar.AnimationHoverSpeed = 0.07F;
			this.btnRegistrar.AnimationSpeed = 0.03F;
			this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnRegistrar.BorderColor = System.Drawing.Color.Black;
			this.btnRegistrar.CheckedBaseColor = System.Drawing.Color.Gray;
			this.btnRegistrar.CheckedBorderColor = System.Drawing.Color.Black;
			this.btnRegistrar.CheckedForeColor = System.Drawing.Color.White;
			this.btnRegistrar.CheckedImage = null;
			this.btnRegistrar.CheckedLineColor = System.Drawing.Color.DimGray;
			this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnRegistrar.FocusedColor = System.Drawing.Color.Empty;
			this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnRegistrar.ForeColor = System.Drawing.Color.White;
			this.btnRegistrar.Image = global::Proyectoaplicado.Properties.Resources.icons8_registro_32;
			this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
			this.btnRegistrar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnRegistrar.Location = new System.Drawing.Point(252, 321);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnRegistrar.OnHoverImage = null;
			this.btnRegistrar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
			this.btnRegistrar.Radius = 10;
			this.btnRegistrar.Size = new System.Drawing.Size(95, 30);
			this.btnRegistrar.TabIndex = 30;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// FrmProveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 507);
			this.Controls.Add(this.Devolver);
			this.Controls.Add(this.dvgproveedores);
			this.Controls.Add(this.Txtid);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnmodificar);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtcategoria);
			this.Controls.Add(this.txtemail);
			this.Controls.Add(this.txtdireccion);
			this.Controls.Add(this.txttelefono);
			this.Controls.Add(this.txtproveedor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmProveedores";
			this.Text = "Proveedores";
			this.Load += new System.EventHandler(this.FrmProveedores_Load);
			((System.ComponentModel.ISupportInitialize)(this.dvgproveedores)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Guna.UI.WinForms.GunaTextBox txtcategoria;
		private Guna.UI.WinForms.GunaTextBox txtdireccion;
		private Guna.UI.WinForms.GunaTextBox txttelefono;
		private Guna.UI.WinForms.GunaTextBox txtproveedor;
		private Guna.UI.WinForms.GunaAdvenceButton btnEliminar;
		private Guna.UI.WinForms.GunaAdvenceButton btnmodificar;
		private Guna.UI.WinForms.GunaAdvenceButton btnbuscar;
		private Guna.UI.WinForms.GunaTextBox txtbuscar;
		private Guna.UI.WinForms.GunaAdvenceButton btnRegistrar;
		private System.Windows.Forms.Label label6;
		private Guna.UI.WinForms.GunaTextBox txtemail;
		private System.Windows.Forms.Label label7;
		private Guna.UI.WinForms.GunaTextBox Txtid;
		private Guna.UI.WinForms.GunaDataGridView dvgproveedores;
		private System.Windows.Forms.PictureBox Devolver;
	}
}