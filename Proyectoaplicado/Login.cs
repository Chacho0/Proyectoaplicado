using Guna.UI.WinForms;
using Proyectoaplicado.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

		private void gunaTextBox2_TextChanged(object sender, EventArgs e)
		{

		}
		public void Cuentas(GunaTextBox paramNombre, GunaTextBox ParamClave)
		{
			string CadenaConnection = "Data Source=DESKTOP-TP2GOM2\\SQLEXPRESS;Initial Catalog=Lavanderia;Integrated Security=True";
			SqlConnection conex = new SqlConnection(CadenaConnection);
			try
			{
				conex.Open();
				SqlCommand cmd = new SqlCommand("select Correo,Clave from usuario where Correo='" + paramNombre.Text + "' and Clave ='" + ParamClave.Text + "'", conex);

				SqlDataReader sql = cmd.ExecuteReader();
				if (sql.Read())
				
				{
					this.Hide();

					FrmMenu llama = new FrmMenu();
					llama.Show();
					

				}
				else
				{
					MessageBox.Show("Usuario invalido");
				}
			}
			catch (Exception ex)
			{


				MessageBox.Show("Usuario invalido" + ex.ToString());



			}
		}

 		private void btnacceder_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(Txtusuario.Text) && !string.IsNullOrEmpty(TxtClave.Text))
			{
				Cuentas(Txtusuario, TxtClave);
				
			}
			else
			{
				MessageBox.Show("No se permiten credenciales vacios");
			}
		}
		
		private void Frmlogin_Load(object sender, EventArgs e)
		{
		}
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void Frmlogin_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);

		}
	}
}
