namespace Proyecto_1
{
    partial class FrmVentas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Dateventa = new Guna.UI.WinForms.GunaDateTimePicker();
			this.txtmontodevolver = new Guna.UI.WinForms.GunaTextBox();
			this.txtpedidos = new Guna.UI.WinForms.GunaTextBox();
			this.dgvpedidos = new Guna.UI.WinForms.GunaDataGridView();
			this.dgvventas = new Guna.UI.WinForms.GunaDataGridView();
			this.txttotal = new Guna.UI.WinForms.GunaTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtITB = new Guna.UI.WinForms.GunaTextBox();
			this.Txtmontopagado = new Guna.UI.WinForms.GunaTextBox();
			this.btnbuscar = new Guna.UI.WinForms.GunaButton();
			this.txtcalcular = new Guna.UI.WinForms.GunaAdvenceButton();
			this.txtpago = new Guna.UI.WinForms.GunaAdvenceButton();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
			this.Cantidadpercha = new System.Windows.Forms.NumericUpDown();
			this.Devolver = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvpedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvventas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Cantidadpercha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(473, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Cliente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Monto pagado";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Monto a devolver";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(304, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(131, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "Fecha de la venta";
			// 
			// Dateventa
			// 
			this.Dateventa.BackColor = System.Drawing.Color.Transparent;
			this.Dateventa.BaseColor = System.Drawing.Color.White;
			this.Dateventa.BorderColor = System.Drawing.Color.Silver;
			this.Dateventa.CustomFormat = null;
			this.Dateventa.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.Dateventa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Dateventa.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Dateventa.ForeColor = System.Drawing.Color.Black;
			this.Dateventa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.Dateventa.Location = new System.Drawing.Point(291, 31);
			this.Dateventa.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.Dateventa.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.Dateventa.Name = "Dateventa";
			this.Dateventa.OnHoverBaseColor = System.Drawing.Color.White;
			this.Dateventa.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Dateventa.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Dateventa.OnPressedColor = System.Drawing.Color.Black;
			this.Dateventa.Radius = 5;
			this.Dateventa.Size = new System.Drawing.Size(160, 30);
			this.Dateventa.TabIndex = 7;
			this.Dateventa.Text = "03/10/2023";
			this.Dateventa.Value = new System.DateTime(2023, 10, 3, 8, 43, 5, 298);
			this.Dateventa.ValueChanged += new System.EventHandler(this.gunaDateTimePicker1_ValueChanged);
			// 
			// txtmontodevolver
			// 
			this.txtmontodevolver.BackColor = System.Drawing.Color.Transparent;
			this.txtmontodevolver.BaseColor = System.Drawing.Color.White;
			this.txtmontodevolver.BorderColor = System.Drawing.Color.Silver;
			this.txtmontodevolver.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtmontodevolver.FocusedBaseColor = System.Drawing.Color.White;
			this.txtmontodevolver.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtmontodevolver.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtmontodevolver.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtmontodevolver.Location = new System.Drawing.Point(150, 74);
			this.txtmontodevolver.Name = "txtmontodevolver";
			this.txtmontodevolver.PasswordChar = '\0';
			this.txtmontodevolver.Radius = 5;
			this.txtmontodevolver.SelectedText = "";
			this.txtmontodevolver.Size = new System.Drawing.Size(94, 30);
			this.txtmontodevolver.TabIndex = 11;
			this.txtmontodevolver.TextChanged += new System.EventHandler(this.txtmontodevolver_TextChanged);
			// 
			// txtpedidos
			// 
			this.txtpedidos.BackColor = System.Drawing.Color.Transparent;
			this.txtpedidos.BaseColor = System.Drawing.Color.White;
			this.txtpedidos.BorderColor = System.Drawing.Color.Silver;
			this.txtpedidos.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtpedidos.FocusedBaseColor = System.Drawing.Color.White;
			this.txtpedidos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtpedidos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtpedidos.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtpedidos.Location = new System.Drawing.Point(547, 24);
			this.txtpedidos.Name = "txtpedidos";
			this.txtpedidos.PasswordChar = '\0';
			this.txtpedidos.Radius = 5;
			this.txtpedidos.SelectedText = "";
			this.txtpedidos.Size = new System.Drawing.Size(89, 30);
			this.txtpedidos.TabIndex = 14;
			// 
			// dgvpedidos
			// 
			this.dgvpedidos.AllowUserToAddRows = false;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
			this.dgvpedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dgvpedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvpedidos.BackgroundColor = System.Drawing.Color.White;
			this.dgvpedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvpedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvpedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvpedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dgvpedidos.ColumnHeadersHeight = 20;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvpedidos.DefaultCellStyle = dataGridViewCellStyle15;
			this.dgvpedidos.EnableHeadersVisualStyles = false;
			this.dgvpedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvpedidos.Location = new System.Drawing.Point(476, 60);
			this.dgvpedidos.Name = "dgvpedidos";
			this.dgvpedidos.RowHeadersVisible = false;
			this.dgvpedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvpedidos.Size = new System.Drawing.Size(300, 322);
			this.dgvpedidos.TabIndex = 16;
			this.dgvpedidos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dgvpedidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvpedidos.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvpedidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvpedidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvpedidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvpedidos.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvpedidos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvpedidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvpedidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvpedidos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dgvpedidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvpedidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvpedidos.ThemeStyle.HeaderStyle.Height = 20;
			this.dgvpedidos.ThemeStyle.ReadOnly = false;
			this.dgvpedidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvpedidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvpedidos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dgvpedidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvpedidos.ThemeStyle.RowsStyle.Height = 22;
			this.dgvpedidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvpedidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvpedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpedidos_CellClick);
			this.dgvpedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpedidos_CellContentClick);
			this.dgvpedidos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvpedidos_CellMouseClick);
			this.dgvpedidos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvpedidos_CellMouseDoubleClick);
			this.dgvpedidos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvpedidos_CellMouseDown);
			// 
			// dgvventas
			// 
			this.dgvventas.AllowUserToAddRows = false;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			this.dgvventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvventas.BackgroundColor = System.Drawing.Color.White;
			this.dgvventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dgvventas.ColumnHeadersHeight = 20;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvventas.DefaultCellStyle = dataGridViewCellStyle18;
			this.dgvventas.EnableHeadersVisualStyles = false;
			this.dgvventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvventas.Location = new System.Drawing.Point(12, 137);
			this.dgvventas.Name = "dgvventas";
			this.dgvventas.RowHeadersVisible = false;
			this.dgvventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvventas.Size = new System.Drawing.Size(455, 245);
			this.dgvventas.TabIndex = 16;
			this.dgvventas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dgvventas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvventas.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvventas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvventas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvventas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvventas.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvventas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvventas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvventas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvventas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dgvventas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvventas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvventas.ThemeStyle.HeaderStyle.Height = 20;
			this.dgvventas.ThemeStyle.ReadOnly = false;
			this.dgvventas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvventas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvventas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dgvventas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvventas.ThemeStyle.RowsStyle.Height = 22;
			this.dgvventas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvventas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvventas_CellClick);
			this.dgvventas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvventas_CellValueChanged);
			// 
			// txttotal
			// 
			this.txttotal.BackColor = System.Drawing.Color.Transparent;
			this.txttotal.BaseColor = System.Drawing.Color.White;
			this.txttotal.BorderColor = System.Drawing.Color.Silver;
			this.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txttotal.FocusedBaseColor = System.Drawing.Color.White;
			this.txttotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txttotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txttotal.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txttotal.Location = new System.Drawing.Point(59, 394);
			this.txttotal.Name = "txttotal";
			this.txttotal.PasswordChar = '\0';
			this.txttotal.Radius = 5;
			this.txttotal.SelectedText = "";
			this.txttotal.Size = new System.Drawing.Size(80, 30);
			this.txttotal.TabIndex = 18;
			this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 402);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Total";
			// 
			// txtITB
			// 
			this.txtITB.BaseColor = System.Drawing.Color.White;
			this.txtITB.BorderColor = System.Drawing.Color.Silver;
			this.txtITB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtITB.FocusedBaseColor = System.Drawing.Color.White;
			this.txtITB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtITB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtITB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtITB.Location = new System.Drawing.Point(150, 38);
			this.txtITB.Name = "txtITB";
			this.txtITB.PasswordChar = '\0';
			this.txtITB.SelectedText = "";
			this.txtITB.Size = new System.Drawing.Size(94, 30);
			this.txtITB.TabIndex = 19;
			this.txtITB.Text = "0.18";
			this.txtITB.Visible = false;
			// 
			// Txtmontopagado
			// 
			this.Txtmontopagado.BackColor = System.Drawing.Color.Transparent;
			this.Txtmontopagado.BaseColor = System.Drawing.Color.White;
			this.Txtmontopagado.BorderColor = System.Drawing.Color.Silver;
			this.Txtmontopagado.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Txtmontopagado.FocusedBaseColor = System.Drawing.Color.White;
			this.Txtmontopagado.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Txtmontopagado.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.Txtmontopagado.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Txtmontopagado.Location = new System.Drawing.Point(150, 38);
			this.Txtmontopagado.Name = "Txtmontopagado";
			this.Txtmontopagado.PasswordChar = '\0';
			this.Txtmontopagado.Radius = 5;
			this.Txtmontopagado.SelectedText = "";
			this.Txtmontopagado.Size = new System.Drawing.Size(94, 30);
			this.Txtmontopagado.TabIndex = 20;
			this.Txtmontopagado.TextChanged += new System.EventHandler(this.Txtmontopagado_TextChanged_1);
			// 
			// btnbuscar
			// 
			this.btnbuscar.AnimationHoverSpeed = 0.07F;
			this.btnbuscar.AnimationSpeed = 0.03F;
			this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
			this.btnbuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnbuscar.BorderColor = System.Drawing.Color.Black;
			this.btnbuscar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnbuscar.FocusedColor = System.Drawing.Color.Empty;
			this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnbuscar.ForeColor = System.Drawing.Color.White;
			this.btnbuscar.Image = global::Proyectoaplicado.Properties.Resources.icons8_buscar_50;
			this.btnbuscar.ImageSize = new System.Drawing.Size(20, 20);
			this.btnbuscar.Location = new System.Drawing.Point(649, 24);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 10;
			this.btnbuscar.Size = new System.Drawing.Size(87, 30);
			this.btnbuscar.TabIndex = 17;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.Click += new System.EventHandler(this.gunaButton3_Click);
			// 
			// txtcalcular
			// 
			this.txtcalcular.AnimationHoverSpeed = 0.07F;
			this.txtcalcular.AnimationSpeed = 0.03F;
			this.txtcalcular.BackColor = System.Drawing.Color.Transparent;
			this.txtcalcular.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtcalcular.BorderColor = System.Drawing.Color.Black;
			this.txtcalcular.CheckedBaseColor = System.Drawing.Color.Gray;
			this.txtcalcular.CheckedBorderColor = System.Drawing.Color.Black;
			this.txtcalcular.CheckedForeColor = System.Drawing.Color.White;
			this.txtcalcular.CheckedImage = ((System.Drawing.Image)(resources.GetObject("txtcalcular.CheckedImage")));
			this.txtcalcular.CheckedLineColor = System.Drawing.Color.DimGray;
			this.txtcalcular.DialogResult = System.Windows.Forms.DialogResult.None;
			this.txtcalcular.FocusedColor = System.Drawing.Color.Empty;
			this.txtcalcular.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtcalcular.ForeColor = System.Drawing.Color.White;
			this.txtcalcular.Image = global::Proyectoaplicado.Properties.Resources.icons8_calculadora_30;
			this.txtcalcular.ImageSize = new System.Drawing.Size(20, 20);
			this.txtcalcular.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.txtcalcular.Location = new System.Drawing.Point(250, 394);
			this.txtcalcular.Name = "txtcalcular";
			this.txtcalcular.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.txtcalcular.OnHoverBorderColor = System.Drawing.Color.Black;
			this.txtcalcular.OnHoverForeColor = System.Drawing.Color.White;
			this.txtcalcular.OnHoverImage = null;
			this.txtcalcular.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.txtcalcular.OnPressedColor = System.Drawing.Color.Black;
			this.txtcalcular.Radius = 10;
			this.txtcalcular.Size = new System.Drawing.Size(93, 30);
			this.txtcalcular.TabIndex = 15;
			this.txtcalcular.Text = "Calcular";
			this.txtcalcular.Click += new System.EventHandler(this.txtcalcular_Click);
			// 
			// txtpago
			// 
			this.txtpago.AnimationHoverSpeed = 0.07F;
			this.txtpago.AnimationSpeed = 0.03F;
			this.txtpago.BackColor = System.Drawing.Color.Transparent;
			this.txtpago.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtpago.BorderColor = System.Drawing.Color.Black;
			this.txtpago.CheckedBaseColor = System.Drawing.Color.Gray;
			this.txtpago.CheckedBorderColor = System.Drawing.Color.Black;
			this.txtpago.CheckedForeColor = System.Drawing.Color.White;
			this.txtpago.CheckedImage = ((System.Drawing.Image)(resources.GetObject("txtpago.CheckedImage")));
			this.txtpago.CheckedLineColor = System.Drawing.Color.DimGray;
			this.txtpago.DialogResult = System.Windows.Forms.DialogResult.None;
			this.txtpago.FocusedColor = System.Drawing.Color.Empty;
			this.txtpago.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtpago.ForeColor = System.Drawing.Color.White;
			this.txtpago.Image = global::Proyectoaplicado.Properties.Resources.icons8_reembolso_26;
			this.txtpago.ImageSize = new System.Drawing.Size(20, 20);
			this.txtpago.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.txtpago.Location = new System.Drawing.Point(157, 394);
			this.txtpago.Name = "txtpago";
			this.txtpago.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.txtpago.OnHoverBorderColor = System.Drawing.Color.Black;
			this.txtpago.OnHoverForeColor = System.Drawing.Color.White;
			this.txtpago.OnHoverImage = null;
			this.txtpago.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.txtpago.OnPressedColor = System.Drawing.Color.Black;
			this.txtpago.Radius = 10;
			this.txtpago.Size = new System.Drawing.Size(87, 30);
			this.txtpago.TabIndex = 15;
			this.txtpago.Text = "Pagar";
			this.txtpago.Click += new System.EventHandler(this.txtpago_Click);
			// 
			// reportViewer1
			// 
			this.reportViewer1.Location = new System.Drawing.Point(473, 60);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(300, 333);
			this.reportViewer1.TabIndex = 21;
			this.reportViewer1.Visible = false;
			// 
			// gunaCheckBox1
			// 
			this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
			this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
			this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
			this.gunaCheckBox1.Location = new System.Drawing.Point(291, 84);
			this.gunaCheckBox1.Name = "gunaCheckBox1";
			this.gunaCheckBox1.Size = new System.Drawing.Size(66, 20);
			this.gunaCheckBox1.TabIndex = 22;
			this.gunaCheckBox1.Text = "Percha";
			// 
			// Cantidadpercha
			// 
			this.Cantidadpercha.Location = new System.Drawing.Point(381, 84);
			this.Cantidadpercha.Name = "Cantidadpercha";
			this.Cantidadpercha.Size = new System.Drawing.Size(41, 20);
			this.Cantidadpercha.TabIndex = 23;
			// 
			// Devolver
			// 
			this.Devolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Devolver.Image = global::Proyectoaplicado.Properties.Resources.atras;
			this.Devolver.Location = new System.Drawing.Point(856, 2);
			this.Devolver.Name = "Devolver";
			this.Devolver.Size = new System.Drawing.Size(27, 26);
			this.Devolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Devolver.TabIndex = 39;
			this.Devolver.TabStop = false;
			this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
			// 
			// FrmVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 575);
			this.Controls.Add(this.Devolver);
			this.Controls.Add(this.Cantidadpercha);
			this.Controls.Add(this.gunaCheckBox1);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.Txtmontopagado);
			this.Controls.Add(this.txtITB);
			this.Controls.Add(this.txttotal);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.dgvventas);
			this.Controls.Add(this.dgvpedidos);
			this.Controls.Add(this.txtcalcular);
			this.Controls.Add(this.txtpago);
			this.Controls.Add(this.txtmontodevolver);
			this.Controls.Add(this.txtpedidos);
			this.Controls.Add(this.Dateventa);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmVentas";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.FrmVentas_Load);
			this.VisibleChanged += new System.EventHandler(this.FrmVentas_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.dgvpedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvventas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Cantidadpercha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
		private Guna.UI.WinForms.GunaDateTimePicker Dateventa;
		private Guna.UI.WinForms.GunaTextBox txtmontodevolver;
		private Guna.UI.WinForms.GunaTextBox txtpedidos;
		private Guna.UI.WinForms.GunaAdvenceButton txtpago;
		private Guna.UI.WinForms.GunaDataGridView dgvpedidos;
		private Guna.UI.WinForms.GunaButton btnbuscar;
		private Guna.UI.WinForms.GunaDataGridView dgvventas;
		private Guna.UI.WinForms.GunaTextBox txttotal;
		private System.Windows.Forms.Label label5;
		private Guna.UI.WinForms.GunaAdvenceButton txtcalcular;
		private Guna.UI.WinForms.GunaTextBox txtITB;
		private Guna.UI.WinForms.GunaTextBox Txtmontopagado;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
		private System.Windows.Forms.NumericUpDown Cantidadpercha;
		private System.Windows.Forms.PictureBox Devolver;
	}
}