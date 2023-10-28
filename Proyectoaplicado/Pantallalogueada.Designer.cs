namespace Proyectoaplicado
{
	partial class FrmPantallalogueada
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
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// FrmPantallalogueada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(686, 384);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmPantallalogueada";
			this.Text = "Pantallalogueada";
			this.Load += new System.EventHandler(this.Pantallalogueada_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private System.Windows.Forms.Timer timer1;
	}
}