using Proyectoaplicado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

		private void MostrarFormularioEnPanel(Form formulario)
		{
			formulario.TopLevel = false;
			formulario.FormBorderStyle = FormBorderStyle.None;
			formulario.Dock = DockStyle.Fill;

			principal.Controls.Clear();
		     principal.Controls.Add(formulario);

			formulario.Show();

			formulario.Show();
		}
		private void gunaAdvenceButton4_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmInventario());
		}

		private void btnCliente_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmCliente());
		}

		private void Btnpedidos_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new fRmPedidos());
		}

		private void Btnventas_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmVentas());
		}

		private void btnreportes_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new Frmreporte());
		}
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void principal_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void principal_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<FrmMenu>().Any())
			{
				FrmMenu form2 = Application.OpenForms.OfType<FrmMenu>().FirstOrDefault();
				form2.Close();
			}

			// Verificar si Formulario3 está abierto antes de intentar cerrarlo
			if (Application.OpenForms.OfType<FrmMenu>().Any())
			{
				FrmMenu form3 = Application.OpenForms.OfType<FrmMenu>().FirstOrDefault();
				form3.Close();
			}
			Frmlogin llamar = new Frmlogin();
			llamar.Show();
		}

		private void principal_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void btnPRoductos_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmProductos());
		}

		private void btnproveedores_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmProveedores());
		}
	}
}
