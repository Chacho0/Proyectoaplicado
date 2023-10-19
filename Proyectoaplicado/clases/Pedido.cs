using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace Proyectoaplicado.clases
{
	internal class Pedido
	{
		public void Pedidosinformacion(GunaDataGridView Tablaregistroempleado)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				Tablaregistroempleado.DataSource = null;
				SqlDataAdapter adapter = new SqlDataAdapter("select PedidosID as ID, CodigoID as Codigo, Tipoderopa as Ropa, Fechaentrega as Fecha, horaentrega as Hora, Fechaespera as Fecha_de_espera, horaespera as Hora_de_espera, Estadoropa as Estado, Precio from Pedidos;", objetConexion.Establecerconexion());
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


		public void RegistrarPedido(string codigoID, string tipoRopa, GunaDateTimePicker fechaEntregaPicker, string horaEntrega, GunaDateTimePicker fechaEsperaPicker, string horaEspera, string estadoRopa,string precio)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				// Verifica si el códigoID pertenece a algún cliente
				if (!ClienteExistente(int.Parse(codigoID)))
				{
					MessageBox.Show("El CodigoID ingresado no corresponde a ningún cliente. Codigo invalido.");
					return;
				}

				// Obtén los valores de DateTimePicker
				DateTime fechaEntrega = fechaEntregaPicker.Value;
				DateTime fechaEspera = fechaEsperaPicker.Value;

				// Query para insertar un nuevo pedido
				string query = $@"INSERT INTO Pedidos (CodigoID, Tipoderopa, Fechaentrega, horaentrega, Fechaespera, horaespera, Estadoropa,precio)
                          VALUES ('{codigoID}', '{tipoRopa}', '{fechaEntrega.ToString("yyyy-MM-dd")}', '{horaEntrega}', '{fechaEspera.ToString("yyyy-MM-dd")}', '{horaEspera}', '{estadoRopa}', '{precio}');";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.ExecuteNonQuery();
				}

				MessageBox.Show("Pedido registrado exitosamente.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo registrar el pedido. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		
		private bool ClienteExistente(int codigoID)
		{
			
			Conexion objetConexion = new Conexion();

			try
			{
				using (SqlConnection connection = objetConexion.Establecerconexion())
				{
					
					string query = $"SELECT COUNT(*) FROM Clientes WHERE ClienteID = {codigoID};";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						int count = (int)command.ExecuteScalar();
						return count > 0;  // Si count > 0, el cliente existe; de lo contrario, no existe
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al verificar la existencia del cliente. Error: " + ex.ToString());
				return false;  
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}


		public void ModificarPedido(string pedidoID, string codigoID, string tipoRopa, GunaDateTimePicker fechaEntregaPicker, string horaEntrega, GunaDateTimePicker fechaEsperaPicker, string horaEspera, string estadoRopa,string precio)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				// Verifica si el códigoID pertenece a algún cliente
				if (!ClienteExistente(int.Parse(codigoID)))
				{
					MessageBox.Show("El CodigoID ingresado no corresponde a ningún cliente. Código inválido.");
					return;
				}

				// Obtén los valores de DateTimePicker
				DateTime fechaEntrega = fechaEntregaPicker.Value;
				DateTime fechaEspera = fechaEsperaPicker.Value;

				// Query para modificar un pedido existente
				string query = $@"UPDATE Pedidos
                          SET CodigoID = '{codigoID}',
                              Tipoderopa = '{tipoRopa}',
                              Fechaentrega = '{fechaEntrega.ToString("yyyy-MM-dd")}',
                              horaentrega = '{horaEntrega}',
                              Fechaespera = '{fechaEspera.ToString("yyyy-MM-dd")}',
                              horaespera = '{horaEspera}',
                              Estadoropa = '{estadoRopa}',
						      Precio = '{precio}',
                          WHERE PedidosID = {pedidoID};";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.ExecuteNonQuery();
				}

				MessageBox.Show("Pedido modificado exitosamente.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo modificar el pedido. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		public void EliminarPedido(string clienteID)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "DELETE FROM Pedidos WHERE PedidosID = @ClienteID;";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@ClienteID", clienteID);

					int rowsAffected = command.ExecuteNonQuery();
					if (rowsAffected > 0)
						MessageBox.Show("Pedido eliminado exitosamente.");
					else
						MessageBox.Show("No se encontró El pedido con el ID proporcionado.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró eliminar el Pedido. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		public void BuscarCliente(string nombre, GunaDataGridView Tabla)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "SELECT  PedidosID as ID, CodigoID as Codigo, Tipoderopa as Ropa, Fechaentrega as Fecha, horaentrega as Hora, Fechaespera as Fecha_de_espera, horaespera as Hora_de_espera, Estadoropa as Estado, Precio FROM Pedidos WHERE CodigoID LIKE @Nombre;";
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
		public void selecionargree(GunaDataGridView Tabla, GunaTextBox pedidoID, GunaTextBox codigoID,
	GunaComboBox tipoRopa, GunaDateTimePicker fechaEntregaPicker, GunaTextBox horaEntrega, GunaDateTimePicker fechaEsperaPicker,
	GunaTextBox horaEspera, GunaComboBox estadoRopa, GunaComboBox precio)
		{
			try
			{
				pedidoID.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
				codigoID.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
				tipoRopa.Text = Tabla.CurrentRow.Cells[2].Value.ToString();

				// Convierte las fechas de string a DateTime y asígnales a los DateTimePicker
				if (DateTime.TryParse(Tabla.CurrentRow.Cells[3].Value.ToString(), out DateTime fechaEntrega))
					fechaEntregaPicker.Value = fechaEntrega;

				horaEntrega.Text = Tabla.CurrentRow.Cells[4].Value.ToString();

				if (DateTime.TryParse(Tabla.CurrentRow.Cells[5].Value.ToString(), out DateTime fechaEspera))
					fechaEsperaPicker.Value = fechaEspera;

				horaEspera.Text = Tabla.CurrentRow.Cells[6].Value.ToString();
				estadoRopa.Text = Tabla.CurrentRow.Cells[7].Value.ToString();
				precio.Text = Tabla.CurrentRow.Cells[8].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró seleccionar: " + ex.ToString());
			}
		}





	}
}
