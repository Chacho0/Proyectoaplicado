using Guna.UI.WinForms;
using Proyecto_1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectoaplicado.clases
{
	internal class Conexion
	{
		SqlConnection conex = new SqlConnection();
		string CadenaConnection = "Data Source=DESKTOP-TP2GOM2\\SQLEXPRESS;Initial Catalog=Lavanderia;Integrated Security=True";
		public SqlConnection Establecerconexion()
		{

			try
			{
				conex.ConnectionString = CadenaConnection;
				conex.Open();


			}
			catch (Exception ex)
			{
				MessageBox.Show("No Se a podido conectado" + ex.ToString());
			}
			return conex;
		}
		public void cerrarconexion()
		{
			conex.Close();
		}
		
	}
}
