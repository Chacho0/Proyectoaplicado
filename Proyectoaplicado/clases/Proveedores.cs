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
	internal class Proveedores
	{
		public void informacion(GunaDataGridView tabla)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				tabla.DataSource = null;
				SqlDataAdapter adapter = new SqlDataAdapter("select * from proveedor;", objetConexion.Establecerconexion());
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
		public void RegistrarProveedor(string nombre, string telefono, string direccion, string categoria, string email)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "INSERT INTO Proveedor (Nombreprovedor, Telefono, Direccion, Categoria, Email) " +
							   "VALUES (@Nombre, @Telefono, @Direccion, @Categoria, @Email);";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nombre", nombre);
					command.Parameters.AddWithValue("@Telefono", telefono);
					command.Parameters.AddWithValue("@Direccion", direccion);
					command.Parameters.AddWithValue("@Categoria", categoria);
					command.Parameters.AddWithValue("@Email", email);

					command.ExecuteNonQuery();
					MessageBox.Show("Proveedor registrado exitosamente.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró registrar el proveedor. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		public void ModificarProveedor(string proveedorID, string nuevoNombre, string nuevoTelefono, string nuevaDireccion, string nuevaCategoria, string nuevoEmail)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "UPDATE Proveedor " +
							   "SET Nombreprovedor = @NuevoNombre, " +
							   "Telefono = @NuevoTelefono, " +
							   "Direccion = @NuevaDireccion, " +
							   "Categoria = @NuevaCategoria, " +
							   "Email = @NuevoEmail " +
							   "WHERE ID = @ProveedorID;";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
					command.Parameters.AddWithValue("@NuevoTelefono", nuevoTelefono);
					command.Parameters.AddWithValue("@NuevaDireccion", nuevaDireccion);
					command.Parameters.AddWithValue("@NuevaCategoria", nuevaCategoria);
					command.Parameters.AddWithValue("@NuevoEmail", nuevoEmail);
					command.Parameters.AddWithValue("@ProveedorID", proveedorID);

					int rowsAffected = command.ExecuteNonQuery();
					if (rowsAffected > 0)
						MessageBox.Show("Proveedor modificado exitosamente.");
					else
						MessageBox.Show("No se encontró un proveedor con el ID proporcionado.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró modificar el proveedor. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}

		public void EliminarProveedor(string proveedorID)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "DELETE FROM Proveedor WHERE ID = @ProveedorID;";

				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@ProveedorID", proveedorID);

					int rowsAffected = command.ExecuteNonQuery();
					if (rowsAffected > 0)
						MessageBox.Show("Proveedor eliminado exitosamente.");
					else
						MessageBox.Show("No se encontró un proveedor con el ID proporcionado.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logró eliminar el proveedor. Error: " + ex.ToString());
			}
			finally
			{
				objetConexion.cerrarconexion();
			}
		}
		public void BuscarProveedor(string nombre, GunaDataGridView Tabla)
		{
			Conexion objetConexion = new Conexion();

			try
			{
				string query = "SELECT ID, Nombreproveedor, Telefono, Direccion, Categoria, Email FROM Proveedor WHERE Nombreproveedor LIKE @Nombre;";
				using (SqlConnection connection = objetConexion.Establecerconexion())
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

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
		public void SeleccionarProveedor(GunaDataGridView Tabla, GunaTextBox id, GunaTextBox nombre, GunaTextBox telefono,
	GunaTextBox direccion, GunaTextBox categoria, GunaTextBox email)
		{
				id.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
				nombre.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
				telefono.Text = Tabla.CurrentRow.Cells[2].Value.ToString();
				direccion.Text = Tabla.CurrentRow.Cells[3].Value.ToString();
				categoria.Text = Tabla.CurrentRow.Cells[4].Value.ToString();
				email.Text = Tabla.CurrentRow.Cells[5].Value.ToString();
			
		}


	}
}
