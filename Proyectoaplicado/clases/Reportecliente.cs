using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectoaplicado.clases
{
	internal class Reportecliente
	{
		public void BuscarCliente(string filtro, GunaDataGridView Tabla)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "SELECT ClienteID as Codigo, Nombre, Telefono, Dirreccion, Email FROM Clientes " +
							   "WHERE Nombre LIKE @Nombre OR ClienteID = @ClienteID;";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nombre", "%" + filtro + "%");  // Búsqueda por nombre
																					 // Búsqueda por la primera vocal
					
					// Búsqueda por ClienteID
					if (int.TryParse(filtro, out int clienteID))
					{
						command.Parameters.AddWithValue("@ClienteID", clienteID);
					}
					else
					{
						// Si no se proporciona un ClienteID válido, establece el parámetro en un valor que no coincida con ninguno.
						command.Parameters.AddWithValue("@ClienteID", -1);
					}

					DataTable dt = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter(command);
					adapter.Fill(dt);

					Tabla.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo realizar la búsqueda. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		

	}
}
