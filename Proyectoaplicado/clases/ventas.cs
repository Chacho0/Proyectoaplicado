using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_1;

namespace Proyectoaplicado.clases
{
	internal class ventas
	{
		public void informacion(GunaDataGridView Tablaregistroempleado)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				Tablaregistroempleado.DataSource = null;
				SqlDataAdapter adapter = new SqlDataAdapter("select ClienteID as Codigo, PedidoID as Pedido, tipoderopa as Ropa , FechaVenta as Fecha, MontoEntregado as Monto,MontoDevolver as Devuelta, ITB,MontoTotal from Ventas;", objetConexion.Establecerconexion());
				DataTable dt = new DataTable();

				adapter.Fill(dt);
				Tablaregistroempleado.DataSource = dt;
				objetConexion.cerrarconexion();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logro agregar los datos" + ex.ToString());

			}
			objetConexion.cerrarconexion();
		}
		public void BuscarCliente(string nombre, GunaDataGridView Tabla)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "SELECT  PedidosID as ID, CodigoID as Codigo, Tipoderopa as Ropa, Precio FROM Pedidos WHERE CodigoID LIKE @Nombre;";
				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");  // Buscar por nombre (puede adaptarse para otros criterios)

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

		public void PasarPedidosAGridDestino(GunaDataGridView gridOrigen, GunaDataGridView gridDestino)
		{
			// Verifica si hay filas seleccionadas en el DataGridView de origen
			if (gridOrigen.SelectedRows.Count > 0)
			{
				DataTable nuevaTabla = new DataTable(); // Crea una nueva tabla en memoria

				// Agrega las columnas necesarias a la nueva tabla
				foreach (DataGridViewColumn col in gridOrigen.Columns)
				{
					nuevaTabla.Columns.Add(col.Name);
				}

				// Agrega las filas seleccionadas del DataGridView origen
				foreach (DataGridViewRow fila in gridOrigen.SelectedRows)
				{
					DataRow newRow = nuevaTabla.NewRow();
					for (int i = 0; i < fila.Cells.Count; i++)
					{
						newRow[i] = fila.Cells[i].Value;
					}
					nuevaTabla.Rows.Add(newRow);
				}

				// Agrega las filas existentes en el DataGridView destino
				foreach (DataGridViewRow fila in gridDestino.Rows)
				{
					DataRow newRow = nuevaTabla.NewRow();
					for (int i = 0; i < fila.Cells.Count; i++)
					{
						newRow[i] = fila.Cells[i].Value;
					}
					nuevaTabla.Rows.Add(newRow);
				}

				// Enlaza la nueva tabla al DataGridView de destino
				gridDestino.DataSource = nuevaTabla;
			}
			else
			{
				MessageBox.Show("Selecciona al menos una fila primero.");
			}
		}


	}
}
