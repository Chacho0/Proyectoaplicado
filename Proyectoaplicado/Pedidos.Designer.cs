namespace Proyecto_1
{
    partial class fRmPedidos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRmPedidos));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtcodigocliente = new Guna.UI.WinForms.GunaTextBox();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
			this.btnmodificar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnregistrar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnEliminar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.cmbestadopedido = new Guna.UI.WinForms.GunaComboBox();
			this.cbmtiporopa = new Guna.UI.WinForms.GunaComboBox();
			this.datetimefechaespera = new Guna.UI.WinForms.GunaDateTimePicker();
			this.datetimefechaentrega = new Guna.UI.WinForms.GunaDateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txthoraespera = new Guna.UI.WinForms.GunaTextBox();
			this.txthorallegada = new Guna.UI.WinForms.GunaTextBox();
			this.Txtbuscar = new Guna.UI.WinForms.GunaTextBox();
			this.btnbuscar = new Guna.UI.WinForms.GunaButton();
			this.label8 = new System.Windows.Forms.Label();
			this.txtid = new Guna.UI.WinForms.GunaTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbprecio = new Guna.UI.WinForms.GunaComboBox();
			this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
			this.gunaCheckBox2 = new Guna.UI.WinForms.GunaCheckBox();
			this.Devolver = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo del cliente ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(297, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tipo de ropa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Fecha que se entrego";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(41, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Fecha de entrega";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(135, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Estado del pedido";
			// 
			// txtcodigocliente
			// 
			this.txtcodigocliente.BackColor = System.Drawing.Color.Transparent;
			this.txtcodigocliente.BaseColor = System.Drawing.Color.White;
			this.txtcodigocliente.BorderColor = System.Drawing.Color.Silver;
			this.txtcodigocliente.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtcodigocliente.FocusedBaseColor = System.Drawing.Color.White;
			this.txtcodigocliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtcodigocliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtcodigocliente.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtcodigocliente.Location = new System.Drawing.Point(178, 26);
			this.txtcodigocliente.Name = "txtcodigocliente";
			this.txtcodigocliente.PasswordChar = '\0';
			this.txtcodigocliente.Radius = 5;
			this.txtcodigocliente.SelectedText = "";
			this.txtcodigocliente.Size = new System.Drawing.Size(113, 30);
			this.txtcodigocliente.TabIndex = 10;
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
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
			this.gunaDataGridView1.Location = new System.Drawing.Point(0, 395);
			this.gunaDataGridView1.Name = "gunaDataGridView1";
			this.gunaDataGridView1.RowHeadersVisible = false;
			this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gunaDataGridView1.Size = new System.Drawing.Size(638, 196);
			this.gunaDataGridView1.TabIndex = 17;
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
			this.gunaDataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gunaDataGridView1_CellMouseDown);
			// 
			// btnmodificar
			// 
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
			this.btnmodificar.Location = new System.Drawing.Point(382, 297);
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnmodificar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnmodificar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnmodificar.OnHoverImage = null;
			this.btnmodificar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnmodificar.OnPressedColor = System.Drawing.Color.Black;
			this.btnmodificar.Radius = 10;
			this.btnmodificar.Size = new System.Drawing.Size(99, 30);
			this.btnmodificar.TabIndex = 9;
			this.btnmodificar.Text = "Modificar";
			this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
			// 
			// btnregistrar
			// 
			this.btnregistrar.AnimationHoverSpeed = 0.07F;
			this.btnregistrar.AnimationSpeed = 0.03F;
			this.btnregistrar.BackColor = System.Drawing.Color.Transparent;
			this.btnregistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnregistrar.BorderColor = System.Drawing.Color.Black;
			this.btnregistrar.CheckedBaseColor = System.Drawing.Color.Gray;
			this.btnregistrar.CheckedBorderColor = System.Drawing.Color.Black;
			this.btnregistrar.CheckedForeColor = System.Drawing.Color.White;
			this.btnregistrar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.CheckedImage")));
			this.btnregistrar.CheckedLineColor = System.Drawing.Color.DimGray;
			this.btnregistrar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnregistrar.FocusedColor = System.Drawing.Color.Empty;
			this.btnregistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnregistrar.ForeColor = System.Drawing.Color.White;
			this.btnregistrar.Image = global::Proyectoaplicado.Properties.Resources.icons8_registro_32;
			this.btnregistrar.ImageSize = new System.Drawing.Size(20, 20);
			this.btnregistrar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnregistrar.Location = new System.Drawing.Point(283, 297);
			this.btnregistrar.Name = "btnregistrar";
			this.btnregistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnregistrar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnregistrar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnregistrar.OnHoverImage = null;
			this.btnregistrar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnregistrar.OnPressedColor = System.Drawing.Color.Black;
			this.btnregistrar.Radius = 10;
			this.btnregistrar.Size = new System.Drawing.Size(93, 30);
			this.btnregistrar.TabIndex = 11;
			this.btnregistrar.Text = "Registrar";
			this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
			// 
			// btnEliminar
			// 
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
			this.btnEliminar.Location = new System.Drawing.Point(486, 297);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnEliminar.OnHoverImage = null;
			this.btnEliminar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
			this.btnEliminar.Radius = 10;
			this.btnEliminar.Size = new System.Drawing.Size(91, 30);
			this.btnEliminar.TabIndex = 22;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// cmbestadopedido
			// 
			this.cmbestadopedido.BackColor = System.Drawing.Color.Transparent;
			this.cmbestadopedido.BaseColor = System.Drawing.Color.White;
			this.cmbestadopedido.BorderColor = System.Drawing.Color.Silver;
			this.cmbestadopedido.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbestadopedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbestadopedido.FocusedColor = System.Drawing.Color.Empty;
			this.cmbestadopedido.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbestadopedido.ForeColor = System.Drawing.Color.Black;
			this.cmbestadopedido.FormattingEnabled = true;
			this.cmbestadopedido.Items.AddRange(new object[] {
            "Bueno",
            "Regular",
            "Malo"});
			this.cmbestadopedido.Location = new System.Drawing.Point(178, 190);
			this.cmbestadopedido.Name = "cmbestadopedido";
			this.cmbestadopedido.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.cmbestadopedido.OnHoverItemForeColor = System.Drawing.Color.White;
			this.cmbestadopedido.Radius = 5;
			this.cmbestadopedido.Size = new System.Drawing.Size(113, 26);
			this.cmbestadopedido.TabIndex = 23;
			// 
			// cbmtiporopa
			// 
			this.cbmtiporopa.BackColor = System.Drawing.Color.Transparent;
			this.cbmtiporopa.BaseColor = System.Drawing.Color.White;
			this.cbmtiporopa.BorderColor = System.Drawing.Color.Silver;
			this.cbmtiporopa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbmtiporopa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbmtiporopa.FocusedColor = System.Drawing.Color.Empty;
			this.cbmtiporopa.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbmtiporopa.ForeColor = System.Drawing.Color.Black;
			this.cbmtiporopa.FormattingEnabled = true;
			this.cbmtiporopa.Items.AddRange(new object[] {
            "Camisa",
            "Pantalon ",
            "Blusa",
            "Vestido",
            "Sabanas ",
            "Sueter",
            "Traje(Completo)",
            "Traje(Incompleto)"});
			this.cbmtiporopa.Location = new System.Drawing.Point(400, 30);
			this.cbmtiporopa.Name = "cbmtiporopa";
			this.cbmtiporopa.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.cbmtiporopa.OnHoverItemForeColor = System.Drawing.Color.White;
			this.cbmtiporopa.Radius = 5;
			this.cbmtiporopa.Size = new System.Drawing.Size(189, 26);
			this.cbmtiporopa.TabIndex = 23;
			// 
			// datetimefechaespera
			// 
			this.datetimefechaespera.BackColor = System.Drawing.Color.Transparent;
			this.datetimefechaespera.BaseColor = System.Drawing.Color.White;
			this.datetimefechaespera.BorderColor = System.Drawing.Color.Silver;
			this.datetimefechaespera.CustomFormat = null;
			this.datetimefechaespera.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.datetimefechaespera.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datetimefechaespera.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.datetimefechaespera.ForeColor = System.Drawing.Color.Black;
			this.datetimefechaespera.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datetimefechaespera.Location = new System.Drawing.Point(178, 135);
			this.datetimefechaespera.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.datetimefechaespera.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.datetimefechaespera.Name = "datetimefechaespera";
			this.datetimefechaespera.OnHoverBaseColor = System.Drawing.Color.White;
			this.datetimefechaespera.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datetimefechaespera.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datetimefechaespera.OnPressedColor = System.Drawing.Color.Black;
			this.datetimefechaespera.Radius = 5;
			this.datetimefechaespera.Size = new System.Drawing.Size(210, 30);
			this.datetimefechaespera.TabIndex = 24;
			this.datetimefechaespera.Text = "05/10/2023";
			this.datetimefechaespera.Value = new System.DateTime(2023, 10, 5, 22, 51, 48, 699);
			// 
			// datetimefechaentrega
			// 
			this.datetimefechaentrega.BackColor = System.Drawing.Color.Transparent;
			this.datetimefechaentrega.BaseColor = System.Drawing.Color.White;
			this.datetimefechaentrega.BorderColor = System.Drawing.Color.Silver;
			this.datetimefechaentrega.CustomFormat = null;
			this.datetimefechaentrega.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.datetimefechaentrega.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datetimefechaentrega.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.datetimefechaentrega.ForeColor = System.Drawing.Color.Black;
			this.datetimefechaentrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datetimefechaentrega.Location = new System.Drawing.Point(178, 79);
			this.datetimefechaentrega.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.datetimefechaentrega.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.datetimefechaentrega.Name = "datetimefechaentrega";
			this.datetimefechaentrega.OnHoverBaseColor = System.Drawing.Color.White;
			this.datetimefechaentrega.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datetimefechaentrega.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datetimefechaentrega.OnPressedColor = System.Drawing.Color.Black;
			this.datetimefechaentrega.Radius = 5;
			this.datetimefechaentrega.Size = new System.Drawing.Size(210, 30);
			this.datetimefechaentrega.TabIndex = 24;
			this.datetimefechaentrega.Text = "05/10/2023";
			this.datetimefechaentrega.Value = new System.DateTime(2023, 10, 5, 22, 11, 44, 640);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(394, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "Hora de llegada";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(394, 141);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 16);
			this.label7.TabIndex = 1;
			this.label7.Text = "Hora de Entrega";
			// 
			// txthoraespera
			// 
			this.txthoraespera.BackColor = System.Drawing.Color.Transparent;
			this.txthoraespera.BaseColor = System.Drawing.Color.White;
			this.txthoraespera.BorderColor = System.Drawing.Color.Silver;
			this.txthoraespera.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txthoraespera.FocusedBaseColor = System.Drawing.Color.White;
			this.txthoraespera.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txthoraespera.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txthoraespera.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txthoraespera.Location = new System.Drawing.Point(520, 132);
			this.txthoraespera.Name = "txthoraespera";
			this.txthoraespera.PasswordChar = '\0';
			this.txthoraespera.Radius = 5;
			this.txthoraespera.SelectedText = "";
			this.txthoraespera.Size = new System.Drawing.Size(69, 30);
			this.txthoraespera.TabIndex = 10;
			// 
			// txthorallegada
			// 
			this.txthorallegada.BackColor = System.Drawing.Color.Transparent;
			this.txthorallegada.BaseColor = System.Drawing.Color.White;
			this.txthorallegada.BorderColor = System.Drawing.Color.Silver;
			this.txthorallegada.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txthorallegada.FocusedBaseColor = System.Drawing.Color.White;
			this.txthorallegada.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txthorallegada.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txthorallegada.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txthorallegada.Location = new System.Drawing.Point(519, 80);
			this.txthorallegada.Name = "txthorallegada";
			this.txthorallegada.PasswordChar = '\0';
			this.txthorallegada.Radius = 5;
			this.txthorallegada.SelectedText = "";
			this.txthorallegada.Size = new System.Drawing.Size(70, 30);
			this.txthorallegada.TabIndex = 10;
			// 
			// Txtbuscar
			// 
			this.Txtbuscar.BackColor = System.Drawing.Color.Transparent;
			this.Txtbuscar.BaseColor = System.Drawing.Color.White;
			this.Txtbuscar.BorderColor = System.Drawing.Color.Silver;
			this.Txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Txtbuscar.FocusedBaseColor = System.Drawing.Color.White;
			this.Txtbuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Txtbuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.Txtbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Txtbuscar.Location = new System.Drawing.Point(15, 297);
			this.Txtbuscar.Name = "Txtbuscar";
			this.Txtbuscar.PasswordChar = '\0';
			this.Txtbuscar.Radius = 5;
			this.Txtbuscar.SelectedText = "";
			this.Txtbuscar.Size = new System.Drawing.Size(160, 30);
			this.Txtbuscar.TabIndex = 25;
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
			this.btnbuscar.Location = new System.Drawing.Point(190, 297);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 10;
			this.btnbuscar.Size = new System.Drawing.Size(87, 30);
			this.btnbuscar.TabIndex = 26;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(33, 278);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "Buscar Pedido";
			// 
			// txtid
			// 
			this.txtid.BackColor = System.Drawing.Color.Transparent;
			this.txtid.BaseColor = System.Drawing.Color.White;
			this.txtid.BorderColor = System.Drawing.Color.Silver;
			this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtid.FocusedBaseColor = System.Drawing.Color.White;
			this.txtid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtid.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtid.Location = new System.Drawing.Point(178, 26);
			this.txtid.Name = "txtid";
			this.txtid.PasswordChar = '\0';
			this.txtid.Radius = 5;
			this.txtid.SelectedText = "";
			this.txtid.Size = new System.Drawing.Size(113, 30);
			this.txtid.TabIndex = 27;
			this.txtid.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(337, 194);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 16);
			this.label9.TabIndex = 1;
			this.label9.Text = "precio";
			// 
			// cmbprecio
			// 
			this.cmbprecio.BackColor = System.Drawing.Color.Transparent;
			this.cmbprecio.BaseColor = System.Drawing.Color.White;
			this.cmbprecio.BorderColor = System.Drawing.Color.Silver;
			this.cmbprecio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbprecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbprecio.FocusedColor = System.Drawing.Color.Empty;
			this.cmbprecio.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbprecio.ForeColor = System.Drawing.Color.Black;
			this.cmbprecio.FormattingEnabled = true;
			this.cmbprecio.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200",
            "250",
            "300",
            "350",
            "400",
            "450",
            "500"});
			this.cmbprecio.Location = new System.Drawing.Point(397, 190);
			this.cmbprecio.Name = "cmbprecio";
			this.cmbprecio.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.cmbprecio.OnHoverItemForeColor = System.Drawing.Color.White;
			this.cmbprecio.Radius = 5;
			this.cmbprecio.Size = new System.Drawing.Size(192, 26);
			this.cmbprecio.TabIndex = 23;
			// 
			// gunaCheckBox1
			// 
			this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
			this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
			this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
			this.gunaCheckBox1.Location = new System.Drawing.Point(406, 236);
			this.gunaCheckBox1.Name = "gunaCheckBox1";
			this.gunaCheckBox1.Size = new System.Drawing.Size(67, 20);
			this.gunaCheckBox1.TabIndex = 29;
			this.gunaCheckBox1.Text = "Lavado";
			// 
			// gunaCheckBox2
			// 
			this.gunaCheckBox2.BaseColor = System.Drawing.Color.White;
			this.gunaCheckBox2.CheckedOffColor = System.Drawing.Color.Gray;
			this.gunaCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.gunaCheckBox2.FillColor = System.Drawing.Color.White;
			this.gunaCheckBox2.Location = new System.Drawing.Point(486, 236);
			this.gunaCheckBox2.Name = "gunaCheckBox2";
			this.gunaCheckBox2.Size = new System.Drawing.Size(83, 20);
			this.gunaCheckBox2.TabIndex = 29;
			this.gunaCheckBox2.Text = "Planchado";
			// 
			// Devolver
			// 
			this.Devolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Devolver.Image = global::Proyectoaplicado.Properties.Resources.atras;
			this.Devolver.Location = new System.Drawing.Point(604, 2);
			this.Devolver.Name = "Devolver";
			this.Devolver.Size = new System.Drawing.Size(32, 28);
			this.Devolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Devolver.TabIndex = 38;
			this.Devolver.TabStop = false;
			this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
			// 
			// fRmPedidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 591);
			this.Controls.Add(this.Devolver);
			this.Controls.Add(this.gunaCheckBox2);
			this.Controls.Add(this.gunaCheckBox1);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.Txtbuscar);
			this.Controls.Add(this.datetimefechaentrega);
			this.Controls.Add(this.datetimefechaespera);
			this.Controls.Add(this.cbmtiporopa);
			this.Controls.Add(this.cmbprecio);
			this.Controls.Add(this.cmbestadopedido);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.gunaDataGridView1);
			this.Controls.Add(this.btnmodificar);
			this.Controls.Add(this.btnregistrar);
			this.Controls.Add(this.txthorallegada);
			this.Controls.Add(this.txthoraespera);
			this.Controls.Add(this.txtcodigocliente);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fRmPedidos";
			this.Load += new System.EventHandler(this.fRmPedidos_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fRmPedidos_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
		private Guna.UI.WinForms.GunaTextBox txtcodigocliente;
		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaAdvenceButton btnregistrar;
		private Guna.UI.WinForms.GunaAdvenceButton btnmodificar;
		private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
		private Guna.UI.WinForms.GunaAdvenceButton btnEliminar;
		private Guna.UI.WinForms.GunaComboBox cbmtiporopa;
		private Guna.UI.WinForms.GunaComboBox cmbestadopedido;
		private Guna.UI.WinForms.GunaDateTimePicker datetimefechaentrega;
		private Guna.UI.WinForms.GunaDateTimePicker datetimefechaespera;
		private Guna.UI.WinForms.GunaTextBox txthorallegada;
		private Guna.UI.WinForms.GunaTextBox txthoraespera;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private Guna.UI.WinForms.GunaButton btnbuscar;
		private Guna.UI.WinForms.GunaTextBox Txtbuscar;
		private System.Windows.Forms.Label label8;
		private Guna.UI.WinForms.GunaTextBox txtid;
		private Guna.UI.WinForms.GunaComboBox cmbprecio;
		private System.Windows.Forms.Label label9;
		private Guna.UI.WinForms.GunaCheckBox gunaCheckBox2;
		private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
		private System.Windows.Forms.PictureBox Devolver;
	}
}