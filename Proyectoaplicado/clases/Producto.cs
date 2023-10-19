using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Proyectoaplicado.clases
{
	internal class Producto
	{
		Conexion objetConexion = new Conexion();
		public void informacion(GunaDataGridView Tabla)
		{
			try
			{
				Tabla.DataSource = null;
				SqlDataAdapter adapter = new SqlDataAdapter("select * from Productos;", objetConexion.Establecerconexion());
				DataTable dt = new DataTable();

				adapter.Fill(dt);
				Tabla.DataSource = dt;
				objetConexion.cerrarconexion();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se logro agregar los datos" + ex.ToString());

			}
			objetConexion.cerrarconexion();
		}
		public void AgregarProducto(string nombreProveedor, string descripcion, string categoria, string cantidad, string precio)
		{
			// Convertir cantidad y precio a tipos numéricos
			int cantidadInt = Convert.ToInt32(cantidad);
			decimal precioDecimal = Convert.ToDecimal(precio);

			// Calcular el total a pagar
			decimal totalPagar = cantidadInt * precioDecimal;

			string query = "INSERT INTO Productos (Nombreproveedor, Descripcion, Categoria, Cantidad, Precio, totalapagar) " +
						   "VALUES (@Nombreproveedor, @Descripcion, @Categoria, @Cantidad, @Precio, @totalapagar)";

			using (SqlConnection connection = objetConexion.Establecerconexion())
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nombreproveedor", nombreProveedor);
					command.Parameters.AddWithValue("@Descripcion", descripcion);
					command.Parameters.AddWithValue("@Categoria", categoria);
					command.Parameters.AddWithValue("@Cantidad", cantidadInt);
					command.Parameters.AddWithValue("@Precio", precioDecimal);
					command.Parameters.AddWithValue("@totalapagar", totalPagar);

					try
					{
						objetConexion.cerrarconexion();
						connection.Open();
						command.ExecuteNonQuery();
						MessageBox.Show("Producto registrado exitosamente.");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error al registrar el producto: " + ex.Message);
					}
					objetConexion.cerrarconexion();
				}
			}
		}

		public void ModificarProducto(string productoID, string nombreProveedor, string descripcion, string categoria, string cantidad, string precio, string totalapagar)
		{
			string query = "UPDATE Productos " +
						   "SET Nombreproveedor = @Nombreproveedor, " +
						   "Descripcion = @Descripcion, " +
						   "Categoria = @Categoria, " +
						   "Cantidad = @Cantidad, " +
						   "Precio = @Precio, " +
						   "totalapagar = @totalapagar " +
						   "WHERE ProductoID = @ProductoID";

			using (SqlConnection connection = objetConexion.Establecerconexion())
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nombreproveedor", nombreProveedor);
					command.Parameters.AddWithValue("@Descripcion", descripcion);
					command.Parameters.AddWithValue("@Categoria", categoria);
					command.Parameters.AddWithValue("@Cantidad", cantidad);
					command.Parameters.AddWithValue("@Precio", precio);
					command.Parameters.AddWithValue("@totalapagar", totalapagar);
					command.Parameters.AddWithValue("@ProductoID", productoID);

					try
					{
						objetConexion.cerrarconexion();
						connection.Open();
						command.ExecuteNonQuery();
						MessageBox.Show("Producto modificado exitosamente.");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error al modificar el producto: " + ex.Message);
					}
					objetConexion.cerrarconexion();
				}
			}
		}

		public void EliminarProducto(string productoID)
		{
			string query = "DELETE FROM Productos WHERE ProductoID = @ProductoID";

			using (SqlConnection connection = objetConexion.Establecerconexion())
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@ProductoID", productoID);

					try
					{
						objetConexion.cerrarconexion();
						connection.Open();
						command.ExecuteNonQuery();
						MessageBox.Show("Producto eliminado exitosamente.");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error al eliminar el producto: " + ex.Message);
					}
					objetConexion.cerrarconexion();
				}
			}
		}

		public void SeleccionarProducto(GunaDataGridView tabla, GunaTextBox paramID, 
			GunaTextBox nombreProveedor, GunaTextBox descripcion, GunaTextBox categoria,
			GunaTextBox cantidad, GunaTextBox precio, GunaTextBox totalPagar)
		{
			
				paramID.Text = tabla.CurrentRow.Cells[0].Value.ToString();
				nombreProveedor.Text = tabla.CurrentRow.Cells[1].Value.ToString();
				descripcion.Text = tabla.CurrentRow.Cells[2].Value.ToString();
				categoria.Text = tabla.CurrentRow.Cells[3].Value.ToString();
				cantidad.Text = tabla.CurrentRow.Cells[4].Value.ToString();
				precio.Text = tabla.CurrentRow.Cells[5].Value.ToString();
				totalPagar.Text = tabla.CurrentRow.Cells[6].Value.ToString();
				
			
		}

		public void BuscarProductoPorDescripcion(GunaDataGridView tabla, string descripcion)
		{
			try
			{
				Conexion objetConexion = new Conexion();
				tabla.DataSource = null;

				string query = "SELECT * FROM Productos WHERE Descripcion LIKE @Descripcion";
				using (SqlConnection connection = objetConexion.Establecerconexion())
				{
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Descripcion", "%" + descripcion + "%");

						SqlDataAdapter adapter = new SqlDataAdapter(command);
						DataTable dt = new DataTable();

						adapter.Fill(dt);
						tabla.DataSource = dt;
					}
				}

				objetConexion.cerrarconexion();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al buscar productos por descripción: " + ex.ToString());
			}
		}


	}
}
