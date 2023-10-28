namespace Proyectoaplicado
{
	partial class FrmReportecliente
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lavanderiaDataSet = new Proyectoaplicado.LavanderiaDataSet();
			this.btnimprimir = new Guna.UI.WinForms.GunaButton();
			this.lbcliente = new System.Windows.Forms.Label();
			this.txtbuscador = new Guna.UI.WinForms.GunaTextBox();
			this.btnbuscar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.reportViewerclientes = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dvgclientes = new Guna.UI.WinForms.GunaDataGridView();
			this.btncerrar = new System.Windows.Forms.PictureBox();
			this.clientesTableAdapter = new Proyectoaplicado.LavanderiaDataSetTableAdapters.ClientesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lavanderiaDataSet)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvgclientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
			this.SuspendLayout();
			// 
			// clientesBindingSource
			// 
			this.clientesBindingSource.DataMember = "Clientes";
			this.clientesBindingSource.DataSource = this.lavanderiaDataSet;
			// 
			// lavanderiaDataSet
			// 
			this.lavanderiaDataSet.DataSetName = "LavanderiaDataSet";
			this.lavanderiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnimprimir
			// 
			this.btnimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnimprimir.AnimationHoverSpeed = 0.07F;
			this.btnimprimir.AnimationSpeed = 0.03F;
			this.btnimprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnimprimir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnimprimir.BorderColor = System.Drawing.Color.Black;
			this.btnimprimir.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnimprimir.FocusedColor = System.Drawing.Color.Empty;
			this.btnimprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnimprimir.ForeColor = System.Drawing.Color.White;
			this.btnimprimir.Image = null;
			this.btnimprimir.ImageSize = new System.Drawing.Size(20, 20);
			this.btnimprimir.Location = new System.Drawing.Point(268, 95);
			this.btnimprimir.Name = "btnimprimir";
			this.btnimprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnimprimir.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnimprimir.OnHoverForeColor = System.Drawing.Color.White;
			this.btnimprimir.OnHoverImage = null;
			this.btnimprimir.OnPressedColor = System.Drawing.Color.Black;
			this.btnimprimir.Radius = 10;
			this.btnimprimir.Size = new System.Drawing.Size(86, 30);
			this.btnimprimir.TabIndex = 46;
			this.btnimprimir.Text = "Imprimir";
			this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
			// 
			// lbcliente
			// 
			this.lbcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbcliente.AutoSize = true;
			this.lbcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbcliente.Location = new System.Drawing.Point(41, 73);
			this.lbcliente.Name = "lbcliente";
			this.lbcliente.Size = new System.Drawing.Size(105, 16);
			this.lbcliente.TabIndex = 48;
			this.lbcliente.Text = "Buscar cliente";
			this.lbcliente.Click += new System.EventHandler(this.lbcliente_Click);
			// 
			// txtbuscador
			// 
			this.txtbuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtbuscador.BackColor = System.Drawing.Color.Transparent;
			this.txtbuscador.BaseColor = System.Drawing.Color.White;
			this.txtbuscador.BorderColor = System.Drawing.Color.Silver;
			this.txtbuscador.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtbuscador.FocusedBaseColor = System.Drawing.Color.White;
			this.txtbuscador.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtbuscador.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtbuscador.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtbuscador.Location = new System.Drawing.Point(12, 95);
			this.txtbuscador.Name = "txtbuscador";
			this.txtbuscador.PasswordChar = '\0';
			this.txtbuscador.Radius = 5;
			this.txtbuscador.SelectedText = "";
			this.txtbuscador.Size = new System.Drawing.Size(160, 30);
			this.txtbuscador.TabIndex = 49;
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
			this.btnbuscar.Location = new System.Drawing.Point(178, 95);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuscar.OnHoverImage = null;
			this.btnbuscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuscar.Radius = 10;
			this.btnbuscar.Size = new System.Drawing.Size(84, 30);
			this.btnbuscar.TabIndex = 50;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.reportViewerclientes);
			this.panel1.Controls.Add(this.dvgclientes);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 131);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 319);
			this.panel1.TabIndex = 51;
			// 
			// reportViewerclientes
			// 
			this.reportViewerclientes.Dock = System.Windows.Forms.DockStyle.Bottom;
			reportDataSource7.Name = "clientes";
			reportDataSource7.Value = this.clientesBindingSource;
			reportDataSource8.Name = "DataSet1";
			reportDataSource8.Value = this.clientesBindingSource;
			this.reportViewerclientes.LocalReport.DataSources.Add(reportDataSource7);
			this.reportViewerclientes.LocalReport.DataSources.Add(reportDataSource8);
			this.reportViewerclientes.LocalReport.ReportEmbeddedResource = "Proyectoaplicado.facturaventas.rdlc";
			this.reportViewerclientes.Location = new System.Drawing.Point(0, 4);
			this.reportViewerclientes.Name = "reportViewerclientes";
			this.reportViewerclientes.ServerReport.BearerToken = null;
			this.reportViewerclientes.Size = new System.Drawing.Size(800, 315);
			this.reportViewerclientes.TabIndex = 52;
			this.reportViewerclientes.Visible = false;
			// 
			// dvgclientes
			// 
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.dvgclientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dvgclientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvgclientes.BackgroundColor = System.Drawing.Color.White;
			this.dvgclientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dvgclientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvgclientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dvgclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dvgclientes.ColumnHeadersHeight = 20;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dvgclientes.DefaultCellStyle = dataGridViewCellStyle12;
			this.dvgclientes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dvgclientes.EnableHeadersVisualStyles = false;
			this.dvgclientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgclientes.Location = new System.Drawing.Point(0, 0);
			this.dvgclientes.Name = "dvgclientes";
			this.dvgclientes.RowHeadersVisible = false;
			this.dvgclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dvgclientes.Size = new System.Drawing.Size(800, 319);
			this.dvgclientes.TabIndex = 0;
			this.dvgclientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dvgclientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dvgclientes.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dvgclientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dvgclientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dvgclientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dvgclientes.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dvgclientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgclientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dvgclientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dvgclientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvgclientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dvgclientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dvgclientes.ThemeStyle.HeaderStyle.Height = 20;
			this.dvgclientes.ThemeStyle.ReadOnly = false;
			this.dvgclientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dvgclientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvgclientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvgclientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dvgclientes.ThemeStyle.RowsStyle.Height = 22;
			this.dvgclientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgclientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// btncerrar
			// 
			this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btncerrar.Image = global::Proyectoaplicado.Properties.Resources.emblemunreadable_93487;
			this.btncerrar.Location = new System.Drawing.Point(777, 110);
			this.btncerrar.Name = "btncerrar";
			this.btncerrar.Size = new System.Drawing.Size(19, 20);
			this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btncerrar.TabIndex = 71;
			this.btncerrar.TabStop = false;
			this.btncerrar.Visible = false;
			this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
			// 
			// clientesTableAdapter
			// 
			this.clientesTableAdapter.ClearBeforeFill = true;
			// 
			// FrmReportecliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btncerrar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtbuscador);
			this.Controls.Add(this.lbcliente);
			this.Controls.Add(this.btnimprimir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmReportecliente";
			this.Load += new System.EventHandler(this.FrmReportecliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lavanderiaDataSet)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dvgclientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI.WinForms.GunaButton btnimprimir;
		private System.Windows.Forms.Label lbcliente;
		private Guna.UI.WinForms.GunaTextBox txtbuscador;
		private Guna.UI.WinForms.GunaAdvenceButton btnbuscar;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewerclientes;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI.WinForms.GunaDataGridView dvgclientes;
		private System.Windows.Forms.PictureBox btncerrar;
		private LavanderiaDataSet lavanderiaDataSet;
		private System.Windows.Forms.BindingSource clientesBindingSource;
		private LavanderiaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
	}
}