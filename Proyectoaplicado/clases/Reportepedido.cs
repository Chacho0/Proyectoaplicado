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
	internal class Reportepedido
	{
		public void BuscarCliente(string codigo, DateTime fecha, GunaDataGridView Tabla)
		{
			
			Conexion objetConexion = new Conexion();
			
			try
			{
				string query = "SELECT PedidosID as ID, CodigoID as Codigo, Tipoderopa as Ropa, Fechaentrega as Fecha, horaentrega as Hora, Fechaespera as Fecha_de_espera, horaespera as Hora_de_espera, Estadoropa as Estado, Precio FROM Pedidos WHERE CodigoID LIKE @Codigo AND CONVERT(date, Fechaentrega) = @Fecha;";
				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Codigo", "%" + codigo + "%");  // Buscar por código
					command.Parameters.AddWithValue("@Fecha", fecha.Date);  // Obtener la fecha seleccionada del GunaDateTimePicker en formato DateTime

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
