namespace Proyecto_1
{
	partial class FrmInventario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.Txtbuscar = new Guna.UI.WinForms.GunaTextBox();
			this.Btnbuscar = new Guna.UI.WinForms.GunaAdvenceButton();
			this.dvinventario = new Guna.UI.WinForms.GunaDataGridView();
			this.Devolver = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dvinventario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).BeginInit();
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// Txtbuscar
			// 
			this.Txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Txtbuscar.BackColor = System.Drawing.Color.Transparent;
			this.Txtbuscar.BaseColor = System.Drawing.Color.White;
			this.Txtbuscar.BorderColor = System.Drawing.Color.Silver;
			this.Txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Txtbuscar.FocusedBaseColor = System.Drawing.Color.White;
			this.Txtbuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Txtbuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.Txtbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Txtbuscar.Location = new System.Drawing.Point(21, 79);
			this.Txtbuscar.Name = "Txtbuscar";
			this.Txtbuscar.PasswordChar = '\0';
			this.Txtbuscar.Radius = 5;
			this.Txtbuscar.SelectedText = "";
			this.Txtbuscar.Size = new System.Drawing.Size(178, 30);
			this.Txtbuscar.TabIndex = 14;
			// 
			// Btnbuscar
			// 
			this.Btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Btnbuscar.AnimationHoverSpeed = 0.07F;
			this.Btnbuscar.AnimationSpeed = 0.03F;
			this.Btnbuscar.BackColor = System.Drawing.Color.Transparent;
			this.Btnbuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.Btnbuscar.BorderColor = System.Drawing.Color.Black;
			this.Btnbuscar.CheckedBaseColor = System.Drawing.Color.Gray;
			this.Btnbuscar.CheckedBorderColor = System.Drawing.Color.Black;
			this.Btnbuscar.CheckedForeColor = System.Drawing.Color.White;
			this.Btnbuscar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Btnbuscar.CheckedImage")));
			this.Btnbuscar.CheckedLineColor = System.Drawing.Color.DimGray;
			this.Btnbuscar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.Btnbuscar.FocusedColor = System.Drawing.Color.Empty;
			this.Btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Btnbuscar.ForeColor = System.Drawing.Color.White;
			this.Btnbuscar.Image = global::Proyectoaplicado.Properties.Resources.icons8_buscar_50;
			this.Btnbuscar.ImageSize = new System.Drawing.Size(20, 20);
			this.Btnbuscar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.Btnbuscar.Location = new System.Drawing.Point(229, 76);
			this.Btnbuscar.Name = "Btnbuscar";
			this.Btnbuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.Btnbuscar.OnHoverBorderColor = System.Drawing.Color.Black;
			this.Btnbuscar.OnHoverForeColor = System.Drawing.Color.White;
			this.Btnbuscar.OnHoverImage = null;
			this.Btnbuscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.Btnbuscar.OnPressedColor = System.Drawing.Color.Black;
			this.Btnbuscar.Radius = 10;
			this.Btnbuscar.Size = new System.Drawing.Size(98, 34);
			this.Btnbuscar.TabIndex = 15;
			this.Btnbuscar.Text = "Buscar";
			this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
			// 
			// dvinventario
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dvinventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dvinventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvinventario.BackgroundColor = System.Drawing.Color.White;
			this.dvinventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dvinventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvinventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dvinventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dvinventario.ColumnHeadersHeight = 20;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dvinventario.DefaultCellStyle = dataGridViewCellStyle3;
			this.dvinventario.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dvinventario.EnableHeadersVisualStyles = false;
			this.dvinventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvinventario.Location = new System.Drawing.Point(0, 119);
			this.dvinventario.Name = "dvinventario";
			this.dvinventario.RowHeadersVisible = false;
			this.dvinventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dvinventario.Size = new System.Drawing.Size(800, 366);
			this.dvinventario.TabIndex = 16;
			this.dvinventario.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dvinventario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dvinventario.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dvinventario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dvinventario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dvinventario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dvinventario.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dvinventario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvinventario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dvinventario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dvinventario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvinventario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dvinventario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dvinventario.ThemeStyle.HeaderStyle.Height = 20;
			this.dvinventario.ThemeStyle.ReadOnly = false;
			this.dvinventario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dvinventario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dvinventario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dvinventario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dvinventario.ThemeStyle.RowsStyle.Height = 22;
			this.dvinventario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dvinventario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// Devolver
			// 
			this.Devolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Devolver.Image = global::Proyectoaplicado.Properties.Resources.atras;
			this.Devolver.Location = new System.Drawing.Point(764, 4);
			this.Devolver.Name = "Devolver";
			this.Devolver.Size = new System.Drawing.Size(32, 28);
			this.Devolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Devolver.TabIndex = 38;
			this.Devolver.TabStop = false;
			this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
			// 
			// FrmInventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 485);
			this.Controls.Add(this.Devolver);
			this.Controls.Add(this.dvinventario);
			this.Controls.Add(this.Btnbuscar);
			this.Controls.Add(this.Txtbuscar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmInventario";
			this.Text = "Inventario";
			this.Load += new System.EventHandler(this.FrmInventario_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmInventario_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.dvinventario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Devolver)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaAdvenceButton Btnbuscar;
		private Guna.UI.WinForms.GunaTextBox Txtbuscar;
		private Guna.UI.WinForms.GunaDataGridView dvinventario;
		private System.Windows.Forms.PictureBox Devolver;
	}
}