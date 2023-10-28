namespace Proyectoaplicado
{
	partial class FrmReportepedidos
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
			this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetPedidos = new Proyectoaplicado.DataSetPedidos();
			this.btnimprimirpedido = new Guna.UI.WinForms.GunaButton();
			this.txtpedidos = new Guna.UI.WinForms.GunaTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnbupedido = new Guna.UI.WinForms.GunaButton();
			this.dateFecha = new Guna.UI.WinForms.GunaDateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.reportViewerpedidos = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dvgpedidos = new Guna.UI.WinForms.GunaDataGridView();
			this.btncerrar = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetPedidos)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvgpedidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
			this.SuspendLayout();
			// 
			// pedidosBindingSource
			// 
			this.pedidosBindingSource.DataMember = "Pedidos";
			this.pedidosBindingSource.DataSource = this.dataSetPedidos;
			// 
			// dataSetPedidos
			// 
			this.dataSetPedidos.DataSetName = "DataSetPedidos";
			this.dataSetPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnimprimirpedido
			// 
			this.btnimprimirpedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnimprimirpedido.AnimationHoverSpeed = 0.07F;
			this.btnimprimirpedido.AnimationSpeed = 0.03F;
			this.btnimprimirpedido.BackColor = System.Drawing.Color.Transparent;
			this.btnimprimirpedido.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnimprimirpedido.BorderColor = System.Drawing.Color.Black;
			this.btnimprimirpedido.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnimprimirpedido.FocusedColor = System.Drawing.Color.Empty;
			this.btnimprimirpedido.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnimprimirpedido.ForeColor = System.Drawing.Color.White;
			this.btnimprimirpedido.Image = null;
			this.btnimprimirpedido.ImageSize = new System.Drawing.Size(20, 20);
			this.btnimprimirpedido.Location = new System.Drawing.Point(458, 116);
			this.btnimprimirpedido.Name = "btnimprimirpedido";
			this.btnimprimirpedido.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnimprimirpedido.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnimprimirpedido.OnHoverForeColor = System.Drawing.Color.White;
			this.btnimprimirpedido.OnHoverImage = null;
			this.btnimprimirpedido.OnPressedColor = System.Drawing.Color.Black;
			this.btnimprimirpedido.Radius = 10;
			this.btnimprimirpedido.Size = new System.Drawing.Size(86, 30);
			this.btnimprimirpedido.TabIndex = 72;
			this.btnimprimirpedido.Text = "Imprimir";
			this.btnimprimirpedido.Click += new System.EventHandler(this.btnimprimirpedido_Click);
			// 
			// txtpedidos
			// 
			this.txtpedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtpedidos.BackColor = System.Drawing.Color.Transparent;
			this.txtpedidos.BaseColor = System.Drawing.Color.White;
			this.txtpedidos.BorderColor = System.Drawing.Color.Silver;
			this.txtpedidos.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtpedidos.FocusedBaseColor = System.Drawing.Color.White;
			this.txtpedidos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.txtpedidos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.txtpedidos.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtpedidos.Location = new System.Drawing.Point(12, 117);
			this.txtpedidos.Name = "txtpedidos";
			this.txtpedidos.PasswordChar = '\0';
			this.txtpedidos.Radius = 5;
			this.txtpedidos.SelectedText = "";
			this.txtpedidos.Size = new System.Drawing.Size(160, 30);
			this.txtpedidos.TabIndex = 70;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 16);
			this.label1.TabIndex = 69;
			this.label1.Text = "Buscar Pedidos";
			// 
			// btnbupedido
			// 
			this.btnbupedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnbupedido.AnimationHoverSpeed = 0.07F;
			this.btnbupedido.AnimationSpeed = 0.03F;
			this.btnbupedido.BackColor = System.Drawing.Color.Transparent;
			this.btnbupedido.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnbupedido.BorderColor = System.Drawing.Color.Black;
			this.btnbupedido.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnbupedido.FocusedColor = System.Drawing.Color.Empty;
			this.btnbupedido.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnbupedido.ForeColor = System.Drawing.Color.White;
			this.btnbupedido.Image = global::Proyectoaplicado.Properties.Resources.icons8_buscar_50;
			this.btnbupedido.ImageSize = new System.Drawing.Size(20, 20);
			this.btnbupedido.Location = new System.Drawing.Point(356, 116);
			this.btnbupedido.Name = "btnbupedido";
			this.btnbupedido.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.btnbupedido.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnbupedido.OnHoverForeColor = System.Drawing.Color.White;
			this.btnbupedido.OnHoverImage = null;
			this.btnbupedido.OnPressedColor = System.Drawing.Color.Black;
			this.btnbupedido.Radius = 10;
			this.btnbupedido.Size = new System.Drawing.Size(87, 30);
			this.btnbupedido.TabIndex = 71;
			this.btnbupedido.Text = "Buscar";
			this.btnbupedido.Click += new System.EventHandler(this.btnbupedido_Click);
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
			this.dateFecha.Location = new System.Drawing.Point(191, 116);
			this.dateFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dateFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dateFecha.Name = "dateFecha";
			this.dateFecha.OnHoverBaseColor = System.Drawing.Color.White;
			this.dateFecha.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dateFecha.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dateFecha.OnPressedColor = System.Drawing.Color.Black;
			this.dateFecha.Radius = 5;
			this.dateFecha.Size = new System.Drawing.Size(153, 30);
			this.dateFecha.TabIndex = 73;
			this.dateFecha.Text = "25/10/2023";
			this.dateFecha.Value = new System.DateTime(2023, 10, 25, 14, 11, 47, 190);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(232, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 16);
			this.label2.TabIndex = 69;
			this.label2.Text = "Fecha";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.reportViewerpedidos);
			this.panel1.Controls.Add(this.dvgpedidos);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 152);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 298);
			this.panel1.TabIndex = 74;
			// 
			// reportViewerpedidos
			// 
			this.reportViewerpedidos.Dock = System.Windows.Forms.DockStyle.Bottom;
			reportDataSource1.Name = "Pedidos";
			reportDataSource1.Value = this.pedidosBindingSource;
			this.reportViewerpedidos.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewerpedidos.LocalReport.ReportEmbeddedResource = "Proyectoaplicado.pedido.rdlc";
			this.reportViewerpedidos.Location = new System.Drawing.Point(0, 3);
			this.reportViewerpedidos.Name = "reportViewerpedidos";
			this.reportViewerpedidos.ServerReport.BearerToken = null;
			this.reportViewerpedidos.Size = new System.Drawing.Size(800, 295);
			this.reportViewerpedidos.TabIndex = 75;
			this.reportViewerpedidos.Visible = false;
			// 
			// dvgpedidos
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dvgpedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dvgpedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvgpedidos.BackgroundColor = System.Drawing.Color.White;
			this.dvgpedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dvgpedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvgpedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dvgpedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dvgpedidos.ColumnHeadersHeight = 20;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dvgpedidos.DefaultCellStyle = dataGridViewCellStyle3;
			this.dvgpedidos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dvgpedidos.EnableHeadersVisualStyles = false;
			this.dvgpedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgpedidos.Location = new System.Drawing.Point(0, 0);
			this.dvgpedidos.Name = "dvgpedidos";
			this.dvgpedidos.RowHeadersVisible = false;
			this.dvgpedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dvgpedidos.Size = new System.Drawing.Size(800, 298);
			this.dvgpedidos.TabIndex = 0;
			this.dvgpedidos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dvgpedidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dvgpedidos.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dvgpedidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dvgpedidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dvgpedidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dvgpedidos.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dvgpedidos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgpedidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dvgpedidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dvgpedidos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvgpedidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dvgpedidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dvgpedidos.ThemeStyle.HeaderStyle.Height = 20;
			this.dvgpedidos.ThemeStyle.ReadOnly = false;
			this.dvgpedidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dvgpedidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvgpedidos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvgpedidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dvgpedidos.ThemeStyle.RowsStyle.Height = 22;
			this.dvgpedidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvgpedidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// btncerrar
			// 
			this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btncerrar.Image = global::Proyectoaplicado.Properties.Resources.emblemunreadable_93487;
			this.btncerrar.Location = new System.Drawing.Point(778, 130);
			this.btncerrar.Name = "btncerrar";
			this.btncerrar.Size = new System.Drawing.Size(19, 20);
			this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btncerrar.TabIndex = 75;
			this.btncerrar.TabStop = false;
			this.btncerrar.Visible = false;
			this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
			// 
			// FrmReportepedidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btncerrar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dateFecha);
			this.Controls.Add(this.btnimprimirpedido);
			this.Controls.Add(this.btnbupedido);
			this.Controls.Add(this.txtpedidos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmReportepedidos";
			this.Text = "Reportepedidos";
			this.Load += new System.EventHandler(this.Reportepedidos_Load);
			((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetPedidos)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dvgpedidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI.WinForms.GunaButton btnimprimirpedido;
		private Guna.UI.WinForms.GunaButton btnbupedido;
		private Guna.UI.WinForms.GunaTextBox txtpedidos;
		private System.Windows.Forms.Label label1;
		private Guna.UI.WinForms.GunaDateTimePicker dateFecha;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewerpedidos;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI.WinForms.GunaDataGridView dvgpedidos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox btncerrar;
		private System.Windows.Forms.BindingSource pedidosBindingSource;
		private DataSetPedidos dataSetPedidos;
	}
}