using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectoaplicado.clases
{
	internal class Inventario
	{
		public void Informacion(GunaDataGridView tabla)
		{
			Conexion objetConexion = new Conexion();
			try
			{
				tabla.DataSource = null;
				SqlDataAdapter adapter = new SqlDataAdapter("select Descripcion as Producto,Cantidad, Precio from Productos;", objetConexion.Establecerconexion());
				DataTable dt = new DataTable();

				adapter.Fill(dt);
				tabla.DataSource = dt;
				objetConexion.cerrarconexion();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logro agregar los datos" + ex.ToString());
			}

		}
	}
}
