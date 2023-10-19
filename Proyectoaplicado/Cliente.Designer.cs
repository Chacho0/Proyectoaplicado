namespace Proyecto_1
{
    partial class FrmCliente
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtdireccion = new Guna.UI.WinForms.GunaTextBox();
			this.txttelefono = new Guna.UI.WinForms.GunaTextBox();
			this.txtnombre = new Guna.UI.WinForms.GunaTextBox();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.TxtEmail = new Guna.UI.WinForms.GunaTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
			this.txtbuscar = new Guna.UI.WinForms.GunaTextBox();
			this.Txtid = new Guna.UI.WinForms.GunaTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnEliminar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnmodificar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnbuscar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnRegistrar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.Devolver = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(94, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre del cliente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(84, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Teléfono del cliente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(156, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Dirección";
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
			this.txtdireccion.Location = new System.Drawing.Point(234, 123);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.PasswordChar = '\0';
			this.txtdireccion.Radius = 5;
			this.txtdireccion.SelectedText = "";
			this.txtdireccion.Size = new System.Drawing.Size(160, 30);
			this.txtdireccion.TabIndex = 8;
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
			this.txttelefono.Location = new System.Drawing.Point(234, 70);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.PasswordChar = '\0';
			this.txttelefono.Radius = 5;
			this.txttelefono.SelectedText = "";
			this.txttelefono.Size = new System.Drawing.Size(160, 30);
			this.txttelefono.TabIndex = 9;
			// 
			// txtnombre
			// 
			this.txtnombre.BackColor = System.Drawing.Color.Transparent;
			this.txtnombre.BaseColor = System.Drawing.Color.White;
			this.txtnombre.BorderColor = System.Drawing.Color.Silver;
			this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtnombre.FocusedBaseColor = System.Drawing.Color.White;
			this.txtnombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtnombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtnombre.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtnombre.Location = new System.Drawing.Point(234, 12);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.PasswordChar = '\0';
			this.txtnombre.Radius = 5;
			this.txtnombre.SelectedText = "";
			this.txtnombre.Size = new System.Drawing.Size(160, 30);
			this.txtnombre.TabIndex = 10;
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// TxtEmail
			// 
			this.TxtEmail.BackColor = System.Drawing.Color.Transparent;
			this.TxtEmail.BaseColor = System.Drawing.Color.White;
			this.TxtEmail.BorderColor = System.Drawing.Color.Silver;
			this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TxtEmail.FocusedBaseColor = System.Drawing.Color.White;
			this.TxtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.TxtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.TxtEmail.Location = new System.Drawing.Point(234, 175);
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.PasswordChar = '\0';
			this.TxtEmail.Radius = 5;
			this.TxtEmail.SelectedText = "";
			this.TxtEmail.Size = new System.Drawing.Size(160, 30);
			this.TxtEmail.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(183, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Email";
			// 
			// gunaDataGridView1
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gunaDataGridView1.ColumnHeadersHeight = 20;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.gunaDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gunaDataGridView1.EnableHeadersVisualStyles = false;
			this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gunaDataGridView1.Location = new System.Drawing.Point(0, 250);
			this.gunaDataGridView1.Name = "gunaDataGridView1";
			this.gunaDataGridView1.RowHeadersVisible = false;
			this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gunaDataGridView1.Size = new System.Drawing.Size(601, 186);
			this.gunaDataGridView1.TabIndex = 18;
			this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 20;
			this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
			this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
			this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.gunaDataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gunaDataGridView1_CellMouseClick);
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
			this.txtbuscar.Location = new System.Drawing.Point(4, 214);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.PasswordChar = '\0';
			this.txtbuscar.Radius = 5;
			this.txtbuscar.SelectedText = "";
			this.txtbuscar.Size = new System.Drawing.Size(146, 30);
			this.txtbuscar.TabIndex = 19;
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
			this.Txtid.Location = new System.Drawing.Point(234, 12);
			this.Txtid.Name = "Txtid";
			this.Txtid.PasswordChar = '\0';
			this.Txtid.Radius = 5;
			this.Txtid.SelectedText = "";
			this.Txtid.Size = new System.Drawing.Size(160, 30);
			this.Txtid.TabIndex = 22;
			this.Txtid.Visible = false;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Buscar cliente";
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
			this.btnEliminar.Location = new System.Drawing.Point(441, 214);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnEliminar.OnHoverImage = null;
			this.btnEliminar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
			this.btnEliminar.Radius = 10;
			this.btnEliminar.Size = new System.Drawing.Size(89, 30);
			this.btnEliminar.TabIndex = 21;
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
			this.btnmodificar.Location = new System.Drawing.Point(340, 214);
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnmodificar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnmodificar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnmodificar.OnHoverImage = null;
			this.btnmodificar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnmodificar.OnPressedColor = System.Drawing.Color.Black;
			this.btnmodificar.Radius = 10;
			this.btnmodificar.Size = new System.Drawing.Size(96, 30);
			this.btnmodificar.TabIndex = 21;
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
			this.btnbuscar.Location = new System.Drawing.Point(152, 214);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 10;
			this.btnbuscar.Size = new System.Drawing.Size(84, 30);
			this.btnbuscar.TabIndex = 20;
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
			this.btnRegistrar.Location = new System.Drawing.Point(240, 214);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnRegistrar.OnHoverImage = null;
			this.btnRegistrar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
			this.btnRegistrar.Radius = 10;
			this.btnRegistrar.Size = new System.Drawing.Size(95, 30);
			this.btnRegistrar.TabIndex = 10;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// Devolver
			// 
			this.Devolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Devolver.Image = global::Proyectoaplicado.Properties.Resources.atras;
			this.Devolver.Location = new System.Drawing.Point(562, 6);
			this.Devolver.Name = "Devolver";
			this.Devolver.Size = new System.Drawing.Size(32, 28);
			this.Devolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Devolver.TabIndex = 38;
			this.Devolver.TabStop = false;
			this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
			// 
			// FrmCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 436);
			this.Controls.Add(this.Devolver);
			this.Controls.Add(this.Txtid);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnmodificar);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.gunaDataGridView1);
			this.Controls.Add(this.TxtEmail);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.txtdireccion);
			this.Controls.Add(this.txttelefono);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmCliente";
			this.Text = "Cliente";
			this.Load += new System.EventHandler(this.FrmCliente_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCliente_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private Guna.UI.WinForms.GunaTextBox txtdireccion;
		private Guna.UI.WinForms.GunaTextBox txttelefono;
		private Guna.UI.WinForms.GunaTextBox txtnombre;
		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaAdvenceButton btnRegistrar;
		private Guna.UI.WinForms.GunaTextBox TxtEmail;
		private System.Windows.Forms.Label label4;
		private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
		private Guna.UI.WinForms.GunaAdvenceButton btnbuscar;
		private Guna.UI.WinForms.GunaTextBox txtbuscar;
		private Guna.UI.WinForms.GunaAdvenceButton btnEliminar;
		private Guna.UI.WinForms.GunaAdvenceButton btnmodificar;
		private Guna.UI.WinForms.GunaTextBox Txtid;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox Devolver;
	}
}