namespace Proyectoaplicado
{
	partial class FrmReporteproductos
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.reportViewerproductos = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dvgproductos = new Guna.UI.WinForms.GunaDataGridView();
			this.btnbusproducto = new Guna.UI.WinForms.GunaButton();
			this.txtbuscarproductos = new Guna.UI.WinForms.GunaTextBox();
			this.lbproducto = new System.Windows.Forms.Label();
			this.btnimprimirproducto = new Guna.UI.WinForms.GunaButton();
			this.btncerrar = new System.Windows.Forms.PictureBox();
			this.dataSetProductos = new Proyectoaplicado.DataSetProductos();
			this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.reportViewerproductos);
			this.panel1.Controls.Add(this.dvgproductos);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 137);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 313);
			this.panel1.TabIndex = 0;
			// 
			// reportViewerproductos
			// 
			this.reportViewerproductos.Dock = System.Windows.Forms.DockStyle.Bottom;
			reportDataSource2.Name = "Productos";
			reportDataSource2.Value = this.productosBindingSource;
			this.reportViewerproductos.LocalReport.DataSources.Add(reportDataSource2);
			this.reportViewerproductos.LocalReport.ReportEmbeddedResource = "Proyectoaplicado.Producto.rdlc";
			this.reportViewerproductos.Location = new System.Drawing.Point(0, 0);
			this.reportViewerproductos.Name = "reportViewerproductos";
			this.reportViewerproductos.ServerReport.BearerToken = null;
			this.reportViewerproductos.Size = new System.Drawing.Size(800, 313);
			this.reportViewerproductos.TabIndex = 1;
			this.reportViewerproductos.Visible = false;
			// 
			// dvgproductos
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dvgproductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dvgproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvgproductos.BackgroundColor = System.Drawing.Color.White;
			this.dvgproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dvgproductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvgproductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dvgproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dvgproductos.ColumnHeadersHeight = 20;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dvgproductos.DefaultCellStyle = dataGridViewCellStyle6;
			this.dvgproductos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dvgproductos.EnableHeadersVisualStyles = false;
			this.dvgproductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgproductos.Location = new System.Drawing.Point(0, 0);
			this.dvgproductos.Name = "dvgproductos";
			this.dvgproductos.RowHeadersVisible = false;
			this.dvgproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dvgproductos.Size = new System.Drawing.Size(800, 313);
			this.dvgproductos.TabIndex = 0;
			this.dvgproductos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dvgproductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dvgproductos.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dvgproductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dvgproductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dvgproductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dvgproductos.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dvgproductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgproductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dvgproductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dvgproductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvgproductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dvgproductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dvgproductos.ThemeStyle.HeaderStyle.Height = 20;
			this.dvgproductos.ThemeStyle.ReadOnly = false;
			this.dvgproductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dvgproductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvgproductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvgproductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dvgproductos.ThemeStyle.RowsStyle.Height = 22;
			this.dvgproductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgproductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dvgproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgproductos_CellContentClick);
			// 
			// btnbusproducto
			// 
			this.btnbusproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnbusproducto.AnimationHoverSpeed = 0.07F;
			this.btnbusproducto.AnimationSpeed = 0.03F;
			this.btnbusproducto.BackColor = System.Drawing.Color.Transparent;
			this.btnbusproducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnbusproducto.BorderColor = System.Drawing.Color.Black;
			this.btnbusproducto.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnbusproducto.FocusedColor = System.Drawing.Color.Empty;
			this.btnbusproducto.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnbusproducto.ForeColor = System.Drawing.Color.White;
			this.btnbusproducto.Image = global::Proyectoaplicado.Properties.Resources.icons8_buscar_50;
			this.btnbusproducto.ImageSize = new System.Drawing.Size(20, 20);
			this.btnbusproducto.Location = new System.Drawing.Point(182, 101);
			this.btnbusproducto.Name = "btnbusproducto";
			this.btnbusproducto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnbusproducto.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbusproducto.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbusproducto.OnHoverImage = null;
			this.btnbusproducto.OnPressedColor = System.Drawing.Color.Black;
			this.btnbusproducto.Radius = 10;
			this.btnbusproducto.Size = new System.Drawing.Size(87, 30);
			this.btnbusproducto.TabIndex = 65;
			this.btnbusproducto.Text = "Buscar";
			this.btnbusproducto.Click += new System.EventHandler(this.btnbusproducto_Click);
			// 
			// txtbuscarproductos
			// 
			this.txtbuscarproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtbuscarproductos.BackColor = System.Drawing.Color.Transparent;
			this.txtbuscarproductos.BaseColor = System.Drawing.Color.White;
			this.txtbuscarproductos.BorderColor = System.Drawing.Color.Silver;
			this.txtbuscarproductos.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtbuscarproductos.FocusedBaseColor = System.Drawing.Color.White;
			this.txtbuscarproductos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtbuscarproductos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtbuscarproductos.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtbuscarproductos.Location = new System.Drawing.Point(12, 101);
			this.txtbuscarproductos.Name = "txtbuscarproductos";
			this.txtbuscarproductos.PasswordChar = '\0';
			this.txtbuscarproductos.Radius = 5;
			this.txtbuscarproductos.SelectedText = "";
			this.txtbuscarproductos.Size = new System.Drawing.Size(160, 30);
			this.txtbuscarproductos.TabIndex = 64;
			// 
			// lbproducto
			// 
			this.lbproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbproducto.AutoSize = true;
			this.lbproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbproducto.Location = new System.Drawing.Point(31, 82);
			this.lbproducto.Name = "lbproducto";
			this.lbproducto.Size = new System.Drawing.Size(121, 16);
			this.lbproducto.TabIndex = 63;
			this.lbproducto.Text = "Buscar Producto";
			// 
			// btnimprimirproducto
			// 
			this.btnimprimirproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnimprimirproducto.AnimationHoverSpeed = 0.07F;
			this.btnimprimirproducto.AnimationSpeed = 0.03F;
			this.btnimprimirproducto.BackColor = System.Drawing.Color.Transparent;
			this.btnimprimirproducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnimprimirproducto.BorderColor = System.Drawing.Color.Black;
			this.btnimprimirproducto.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnimprimirproducto.FocusedColor = System.Drawing.Color.Empty;
			this.btnimprimirproducto.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnimprimirproducto.ForeColor = System.Drawing.Color.White;
			this.btnimprimirproducto.Image = null;
			this.btnimprimirproducto.ImageSize = new System.Drawing.Size(20, 20);
			this.btnimprimirproducto.Location = new System.Drawing.Point(275, 101);
			this.btnimprimirproducto.Name = "btnimprimirproducto";
			this.btnimprimirproducto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnimprimirproducto.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnimprimirproducto.OnHoverForeColor = System.Drawing.Color.White;
			this.btnimprimirproducto.OnHoverImage = null;
			this.btnimprimirproducto.OnPressedColor = System.Drawing.Color.Black;
			this.btnimprimirproducto.Radius = 10;
			this.btnimprimirproducto.Size = new System.Drawing.Size(86, 30);
			this.btnimprimirproducto.TabIndex = 68;
			this.btnimprimirproducto.Text = "Imprimir";
			this.btnimprimirproducto.Click += new System.EventHandler(this.btnimprimirproducto_Click);
			// 
			// btncerrar
			// 
			this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btncerrar.Image = global::Proyectoaplicado.Properties.Resources.emblemunreadable_93487;
			this.btncerrar.Location = new System.Drawing.Point(780, 117);
			this.btncerrar.Name = "btncerrar";
			this.btncerrar.Size = new System.Drawing.Size(19, 20);
			this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btncerrar.TabIndex = 72;
			this.btncerrar.TabStop = false;
			this.btncerrar.Visible = false;
			this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
			// 
			// dataSetProductos
			// 
			this.dataSetProductos.DataSetName = "DataSetProductos";
			this.dataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productosBindingSource
			// 
			this.productosBindingSource.DataMember = "Productos";
			this.productosBindingSource.DataSource = this.dataSetProductos;
			// 
			// FrmReporteproductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btncerrar);
			this.Controls.Add(this.btnimprimirproducto);
			this.Controls.Add(this.btnbusproducto);
			this.Controls.Add(this.txtbuscarproductos);
			this.Controls.Add(this.lbproducto);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmReporteproductos";
			this.Text = "Reporteproductos";
			this.Load += new System.EventHandler(this.Reporteproductos_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI.WinForms.GunaDataGridView dvgproductos;
		private Guna.UI.WinForms.GunaButton btnbusproducto;
		private Guna.UI.WinForms.GunaTextBox txtbuscarproductos;
		private System.Windows.Forms.Label lbproducto;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewerproductos;
		private Guna.UI.WinForms.GunaButton btnimprimirproducto;
		private System.Windows.Forms.PictureBox btncerrar;
		private System.Windows.Forms.BindingSource productosBindingSource;
		private DataSetProductos dataSetProductos;
	}
}