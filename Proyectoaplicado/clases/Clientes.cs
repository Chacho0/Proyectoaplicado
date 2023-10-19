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
	internal class Clientes
	{
		public void informacion(GunaDataGridView tabla)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				tabla.DataSource = null;
				SqlDataAdapter adapter = new SqlDataAdapter("select ClienteID as Codigo, Nombre, Telefono, Dirreccion, Email from Clientes;", objetConexion.Establecerconexion());
				DataTable dt = new DataTable();

				adapter.Fill(dt);
				tabla.DataSource = dt;
				objetConexion.cerrarconexion();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logro agregar los datos" + ex.ToString());

			}
			objetConexion.cerrarconexion();
		}
		public void RegistrarCliente(string nombre, string telefono, string direccion, string email)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "INSERT INTO Clientes (Nombre, Telefono, Dirreccion, Email) " +
							   "VALUES (@Nombre, @Telefono, @Direccion, @Email);";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nombre", nombre);
					command.Parameters.AddWithValue("@Telefono", telefono);
					command.Parameters.AddWithValue("@Direccion", direccion);
					command.Parameters.AddWithValue("@Email", email);

					command.ExecuteNonQuery();
					MessageBox.Show("Cliente registrado exitosamente.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró registrar el cliente. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}
		public void ModificarCliente(string clienteID, string nuevoNombre, string nuevoTelefono, string nuevaDireccion, string nuevoEmail)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "UPDATE Clientes " +
							   "SET Nombre = @NuevoNombre, " +
							   "Telefono = @NuevoTelefono, " +
							   "Dirreccion = @NuevaDireccion, " +
							   "Email = @NuevoEmail " +
							   "WHERE ClienteID = @ClienteID;";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
					command.Parameters.AddWithValue("@NuevoTelefono", nuevoTelefono);
					command.Parameters.AddWithValue("@NuevaDireccion", nuevaDireccion);
					command.Parameters.AddWithValue("@NuevoEmail", nuevoEmail);
					command.Parameters.AddWithValue("@ClienteID", clienteID);

					int rowsAffected = command.ExecuteNonQuery();
					if (rowsAffected > 0)
						MessageBox.Show("Cliente modificado exitosamente.");
					else
						MessageBox.Show("No se encontró un cliente con el ID proporcionado.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró modificar el cliente. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}
		public void EliminarCliente(string clienteID)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID;";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@ClienteID", clienteID);

					int rowsAffected = command.ExecuteNonQuery();
					if (rowsAffected > 0)
						MessageBox.Show("Cliente eliminado exitosamente.");
					else
						MessageBox.Show("No se encontró un cliente con el ID proporcionado.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró eliminar el cliente. Error: " + ex.ToString());
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
				string query = "SELECT  ClienteID as Codigo, Nombre, Telefono, Dirreccion, Email FROM Clientes WHERE Nombre LIKE @Nombre;";
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
		public void selecionargree(GunaDataGridView Tabla, GunaTextBox paramid, GunaTextBox Nombre, GunaTextBox Telefono,
		   GunaTextBox Direccion, GunaTextBox Email)

		{
			try
			{
				paramid.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
				Nombre.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
				Telefono.Text = Tabla.CurrentRow.Cells[2].Value.ToString();
				Direccion.Text = Tabla.CurrentRow.Cells[3].Value.ToString();
				Email.Text = Tabla.CurrentRow.Cells[4].Value.ToString();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logro seleccionar" + ex.ToString());
			}
		}

	}
}
