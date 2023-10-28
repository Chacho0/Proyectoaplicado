namespace Proyectoaplicado
{
	partial class FrmReporteventas
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.btncerrar = new System.Windows.Forms.PictureBox();
			this.btninventas = new Guna.UI.WinForms.GunaButton();
			this.txtventas = new Guna.UI.WinForms.GunaTextBox();
			this.btnbuventas = new Guna.UI.WinForms.GunaButton();
			this.label2 = new System.Windows.Forms.Label();
			this.dateFecha = new Guna.UI.WinForms.GunaDateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.reportViewerventas = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dvgventas = new Guna.UI.WinForms.GunaDataGridView();
			this.txtcliente = new Guna.UI.WinForms.GunaTextBox();
			this.lbcliente = new System.Windows.Forms.Label();
			this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetventas = new Proyectoaplicado.DataSetventas();
			((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvgventas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetventas)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// btncerrar
			// 
			this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btncerrar.Image = global::Proyectoaplicado.Properties.Resources.emblemunreadable_93487;
			this.btncerrar.Location = new System.Drawing.Point(760, 144);
			this.btncerrar.Name = "btncerrar";
			this.btncerrar.Size = new System.Drawing.Size(19, 20);
			this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btncerrar.TabIndex = 75;
			this.btncerrar.TabStop = false;
			this.btncerrar.Visible = false;
			this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
			// 
			// btninventas
			// 
			this.btninventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btninventas.AnimationHoverSpeed = 0.07F;
			this.btninventas.AnimationSpeed = 0.03F;
			this.btninventas.BackColor = System.Drawing.Color.Transparent;
			this.btninventas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btninventas.BorderColor = System.Drawing.Color.Black;
			this.btninventas.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btninventas.FocusedColor = System.Drawing.Color.Empty;
			this.btninventas.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btninventas.ForeColor = System.Drawing.Color.White;
			this.btninventas.Image = null;
			this.btninventas.ImageSize = new System.Drawing.Size(20, 20);
			this.btninventas.Location = new System.Drawing.Point(586, 128);
			this.btninventas.Name = "btninventas";
			this.btninventas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btninventas.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btninventas.OnHoverForeColor = System.Drawing.Color.White;
			this.btninventas.OnHoverImage = null;
			this.btninventas.OnPressedColor = System.Drawing.Color.Black;
			this.btninventas.Radius = 10;
			this.btninventas.Size = new System.Drawing.Size(80, 30);
			this.btninventas.TabIndex = 74;
			this.btninventas.Text = "Imprimir";
			this.btninventas.Click += new System.EventHandler(this.btninventas_Click);
			// 
			// txtventas
			// 
			this.txtventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtventas.BackColor = System.Drawing.Color.Transparent;
			this.txtventas.BaseColor = System.Drawing.Color.White;
			this.txtventas.BorderColor = System.Drawing.Color.Silver;
			this.txtventas.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtventas.FocusedBaseColor = System.Drawing.Color.White;
			this.txtventas.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtventas.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtventas.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtventas.Location = new System.Drawing.Point(0, 128);
			this.txtventas.Name = "txtventas";
			this.txtventas.PasswordChar = '\0';
			this.txtventas.Radius = 5;
			this.txtventas.SelectedText = "";
			this.txtventas.Size = new System.Drawing.Size(160, 30);
			this.txtventas.TabIndex = 73;
			this.txtventas.WordWrap = false;
			// 
			// btnbuventas
			// 
			this.btnbuventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnbuventas.AnimationHoverSpeed = 0.07F;
			this.btnbuventas.AnimationSpeed = 0.03F;
			this.btnbuventas.BackColor = System.Drawing.Color.Transparent;
			this.btnbuventas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnbuventas.BorderColor = System.Drawing.Color.Black;
			this.btnbuventas.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnbuventas.FocusedColor = System.Drawing.Color.Empty;
			this.btnbuventas.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnbuventas.ForeColor = System.Drawing.Color.White;
			this.btnbuventas.Image = global::Proyectoaplicado.Properties.Resources.icons8_buscar_50;
			this.btnbuventas.ImageSize = new System.Drawing.Size(20, 20);
			this.btnbuventas.Location = new System.Drawing.Point(493, 128);
			this.btnbuventas.Name = "btnbuventas";
			this.btnbuventas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnbuventas.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbuventas.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbuventas.OnHoverImage = null;
			this.btnbuventas.OnPressedColor = System.Drawing.Color.Black;
			this.btnbuventas.Radius = 10;
			this.btnbuventas.Size = new System.Drawing.Size(87, 30);
			this.btnbuventas.TabIndex = 72;
			this.btnbuventas.Text = "Buscar";
			this.btnbuventas.Click += new System.EventHandler(this.btnbuventas_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(46, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 16);
			this.label2.TabIndex = 71;
			this.label2.Text = "Ventas";
			// 
			// dateFecha
			// 
			this.dateFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dateFecha.BackColor = System.Drawing.Color.Transparent;
			this.dateFecha.BaseColor = System.Drawing.Color.White;
			this.dateFecha.BorderColor = System.Drawing.Color.Silver;
			this.dateFecha.CustomFormat = null;
			this.dateFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dateFecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dateFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dateFecha.ForeColor = System.Drawing.Color.Black;
			this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateFecha.Location = new System.Drawing.Point(332, 128);
			this.dateFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dateFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dateFecha.Name = "dateFecha";
			this.dateFecha.OnHoverBaseColor = System.Drawing.Color.White;
			this.dateFecha.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dateFecha.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dateFecha.OnPressedColor = System.Drawing.Color.Black;
			this.dateFecha.Radius = 5;
			this.dateFecha.Size = new System.Drawing.Size(153, 30);
			this.dateFecha.TabIndex = 77;
			this.dateFecha.Text = "25/10/2023";
			this.dateFecha.Value = new System.DateTime(2023, 10, 25, 14, 11, 47, 190);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(376, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 16);
			this.label1.TabIndex = 76;
			this.label1.Text = "Fecha";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.reportViewerventas);
			this.panel1.Controls.Add(this.dvgventas);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 170);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 280);
			this.panel1.TabIndex = 78;
			// 
			// reportViewerventas
			// 
			this.reportViewerventas.Dock = System.Windows.Forms.DockStyle.Bottom;
			reportDataSource1.Name = "Ventas";
			reportDataSource1.Value = this.ventasBindingSource;
			this.reportViewerventas.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewerventas.LocalReport.ReportEmbeddedResource = "Proyectoaplicado.venta.rdlc";
			this.reportViewerventas.Location = new System.Drawing.Point(0, 3);
			this.reportViewerventas.Name = "reportViewerventas";
			this.reportViewerventas.ServerReport.BearerToken = null;
			this.reportViewerventas.Size = new System.Drawing.Size(800, 277);
			this.reportViewerventas.TabIndex = 1;
			this.reportViewerventas.Visible = false;
			this.reportViewerventas.Load += new System.EventHandler(this.reportViewerventas_Load);
			// 
			// dvgventas
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dvgventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dvgventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvgventas.BackgroundColor = System.Drawing.Color.White;
			this.dvgventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dvgventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvgventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dvgventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dvgventas.ColumnHeadersHeight = 20;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dvgventas.DefaultCellStyle = dataGridViewCellStyle3;
			this.dvgventas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dvgventas.EnableHeadersVisualStyles = false;
			this.dvgventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgventas.Location = new System.Drawing.Point(0, 0);
			this.dvgventas.Name = "dvgventas";
			this.dvgventas.RowHeadersVisible = false;
			this.dvgventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dvgventas.Size = new System.Drawing.Size(800, 280);
			this.dvgventas.TabIndex = 0;
			this.dvgventas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dvgventas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dvgventas.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dvgventas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dvgventas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dvgventas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dvgventas.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dvgventas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgventas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dvgventas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dvgventas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvgventas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dvgventas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dvgventas.ThemeStyle.HeaderStyle.Height = 20;
			this.dvgventas.ThemeStyle.ReadOnly = false;
			this.dvgventas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dvgventas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvgventas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvgventas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dvgventas.ThemeStyle.RowsStyle.Height = 22;
			this.dvgventas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgventas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// txtcliente
			// 
			this.txtcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtcliente.BackColor = System.Drawing.Color.Transparent;
			this.txtcliente.BaseColor = System.Drawing.Color.White;
			this.txtcliente.BorderColor = System.Drawing.Color.Silver;
			this.txtcliente.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtcliente.FocusedBaseColor = System.Drawing.Color.White;
			this.txtcliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtcliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtcliente.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtcliente.Location = new System.Drawing.Point(166, 128);
			this.txtcliente.Name = "txtcliente";
			this.txtcliente.PasswordChar = '\0';
			this.txtcliente.Radius = 5;
			this.txtcliente.SelectedText = "";
			this.txtcliente.Size = new System.Drawing.Size(160, 30);
			this.txtcliente.TabIndex = 80;
			// 
			// lbcliente
			// 
			this.lbcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbcliente.AutoSize = true;
			this.lbcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbcliente.Location = new System.Drawing.Point(210, 107);
			this.lbcliente.Name = "lbcliente";
			this.lbcliente.Size = new System.Drawing.Size(55, 16);
			this.lbcliente.TabIndex = 79;
			this.lbcliente.Text = "Cliente";
			// 
			// ventasBindingSource
			// 
			this.ventasBindingSource.DataMember = "Ventas";
			this.ventasBindingSource.DataSource = this.dataSetventas;
			// 
			// dataSetventas
			// 
			this.dataSetventas.DataSetName = "DataSetventas";
			this.dataSetventas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// FrmReporteventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtcliente);
			this.Controls.Add(this.lbcliente);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dateFecha);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btncerrar);
			this.Controls.Add(this.btninventas);
			this.Controls.Add(this.txtventas);
			this.Controls.Add(this.btnbuventas);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmReporteventas";
			this.Text = "Reporteventas";
			this.Load += new System.EventHandler(this.Reporteventas_Load);
			((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dvgventas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetventas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private System.Windows.Forms.PictureBox btncerrar;
		private Guna.UI.WinForms.GunaButton btninventas;
		private Guna.UI.WinForms.GunaTextBox txtventas;
		private Guna.UI.WinForms.GunaButton btnbuventas;
		private System.Windows.Forms.Label label2;
		private Guna.UI.WinForms.GunaDateTimePicker dateFecha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI.WinForms.GunaDataGridView dvgventas;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewerventas;
		private Guna.UI.WinForms.GunaTextBox txtcliente;
		private System.Windows.Forms.Label lbcliente;
		private System.Windows.Forms.BindingSource ventasBindingSource;
		private DataSetventas dataSetventas;
	}
}