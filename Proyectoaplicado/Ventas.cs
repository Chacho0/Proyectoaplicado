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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Proyecto_1
{
	public partial class FrmVentas : Form
	{
		public FrmVentas()
		{
			InitializeComponent();
			
			Dateventa.Value = DateTime.Today;


		}

		private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void gunaButton3_Click(object sender, EventArgs e)
		{
			ventas l = new ventas();
			l.BuscarCliente(txtpedidos.Text, dgvpedidos);
		}

		private void dgvpedidos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{

		}

		private void dgvpedidos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{

		}

		private void dgvpedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvpedidos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{


		}

		private void dgvpedidos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ventas l = new ventas();
			l.PasarPedidosAGridDestino(dgvpedidos, dgvventas);
		}

		private void dgvventas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Verifica si hay al menos una fila seleccionada
			if (dgvventas.SelectedRows.Count > 0)
			{
				// Obtiene la fila seleccionada
				DataGridViewRow selectedRow = dgvventas.SelectedRows[0];

				// Verifica si la fila no está vacía antes de eliminarla
				if (IsRowEmpty(selectedRow))
				{
					MessageBox.Show("No puedes eliminar filas vacías.");
				}
				else
				{
					// Elimina la fila del DataGridView
					dgvventas.Rows.Remove(selectedRow);
				}
			}
			else
			{
				MessageBox.Show("Selecciona una fila para eliminar.");
			}
		}
		private bool IsRowEmpty(DataGridViewRow row)
		{
			foreach (DataGridViewCell cell in row.Cells)
			{
				if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
				{
					return false;
				}
			}
			return true;
		}
		private void FrmVentas_Load(object sender, EventArgs e)
		{

		}
		private void dgvventas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}
		private void txtcalcular_Click(object sender, EventArgs e)
		{
			decimal sumaTotal = 0;  // Variable para almacenar la suma
			decimal sumaITBIS = 0;  // Variable para almacenar la suma del ITBIS

			// Porcentaje de ITBIS (cámbialo al porcentaje que necesites)
			decimal porcentajeITBIS = 0.18m; // Por ejemplo, 18%

			// Itera a través de cada fila en el DataGridView
			foreach (DataGridViewRow fila in dgvventas.Rows)
			{
				// Verifica si el valor de la celda en la columna "Precio" es un decimal válido
				if (decimal.TryParse(fila.Cells["Precio"].Value?.ToString(), out decimal precio))
				{
					// Si es válido, agrégalo a la suma total
					sumaTotal += precio;

					// Calcula el ITBIS para este precio y agrégalo a la suma de ITBIS
					decimal itbisParaEstePrecio = precio * porcentajeITBIS;
					sumaITBIS += itbisParaEstePrecio;
				}
			}

			// Suma el ITBIS a la suma total
			sumaTotal += sumaITBIS;

			// Muestra la suma total y la suma de ITBIS en los TextBox
			txttotal.Text = sumaTotal.ToString();


		}

		private void FrmVentas_VisibleChanged(object sender, EventArgs e)
		{
			decimal sumaTotal = 0;  // Variable para almacenar la suma

			// Itera a través de cada fila en el DataGridView
			foreach (DataGridViewRow fila in dgvventas.Rows)
			{
				// Verifica si el valor de la celda en la columna "Precio" es un decimal válido
				if (decimal.TryParse(fila.Cells["Precio"].Value?.ToString(), out decimal precio))
				{
					// Si es válido, agrégalo a la suma total
					sumaTotal += precio;
				}
			}

			// Muestra la suma en el TextBox
			txttotal.Text = sumaTotal.ToString();
		}

		private decimal CalcularMontoTotal(int precioRopa, decimal itb)
		{
			// Implementa tu lógica para calcular el monto total (por ejemplo, sumar el ITB al precio)
			return precioRopa + itb;
		}
		public void RegistrarVenta()
		{
			string connectionString = "Data Source=DESKTOP-TP2GOM2\\SQLEXPRESS;Initial Catalog=Lavanderia;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				foreach (DataGridViewRow row in dgvventas.Rows)
				{
					if (!row.IsNewRow)
					{
						// Verificamos y obtenemos el ID del pedido
						int pedidoID = row.Cells["ID"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["ID"].Value) : 0;

						// Verificamos y obtenemos el ID del cliente
						int clienteID = row.Cells["Codigo"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["Codigo"].Value) : 0;

						// Verificamos y obtenemos otros datos
						string tipoRopa = row.Cells["Ropa"].Value != DBNull.Value ? row.Cells["Ropa"].Value.ToString() : string.Empty;
						int precioRopa = row.Cells["Precio"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["Precio"].Value) : 0;

						DateTime fechaVenta = Dateventa.Value;
						decimal montoEntregado = Convert.ToDecimal(Txtmontopagado.Text);
						decimal itb = Convert.ToDecimal(txtITB.Text);
						decimal montoTotal = CalcularMontoTotal(precioRopa, itb);

						// Calcular el monto a devolver
						decimal montoDevolver = montoEntregado - montoTotal;

						// Mostrar el monto a devolver en el TextBoxDevuelta
						txtmontodevolver.Text = montoDevolver.ToString();

						// Insertar la venta si el monto a devolver es mayor o igual a 0
						if (montoDevolver >= 0)
						{
							string query = "INSERT INTO Ventas (PedidoID, ClienteID, Tipoderopa, FechaVenta, MontoEntregado, MontoDevolver, ITB, Precioropa, MontoTotal) " +
										   "VALUES (@PedidoID, @ClienteID, @Tipoderopa, @FechaVenta, @MontoEntregado, @MontoDevolver, @ITB, @Precioropa, @MontoTotal)";

							using (SqlCommand command = new SqlCommand(query, connection))
							{
								command.Parameters.AddWithValue("@PedidoID", pedidoID);
								command.Parameters.AddWithValue("@ClienteID", clienteID);
								command.Parameters.AddWithValue("@Tipoderopa", tipoRopa);
								command.Parameters.AddWithValue("@FechaVenta", fechaVenta);
								command.Parameters.AddWithValue("@MontoEntregado", montoEntregado);
								command.Parameters.AddWithValue("@MontoDevolver", montoDevolver);
								command.Parameters.AddWithValue("@ITB", itb);
								command.Parameters.AddWithValue("@Precioropa", precioRopa);
								command.Parameters.AddWithValue("@MontoTotal", montoTotal);

								try
								{
									command.ExecuteNonQuery();

									// Llama a la función para eliminar el pedido desde la venta
									EliminarPedidoDesdeVenta();

									CargarPedidosDelCliente();
								}
								catch (Exception ex)
								{
									MessageBox.Show("Error al registrar la venta: " + ex.Message);
								}
							}
						}
						else
						{
							MessageBox.Show("El monto entregado es insuficiente.");
						}
					}
				}

				MessageBox.Show("Ventas registradas exitosamente.");
			}
		}

		private void EliminarPedidoDesdeVenta()
		{
			for (int i = 0; i < dgvventas.Rows.Count; i++)
			{
				DataGridViewRow row = dgvventas.Rows[i];
				int pedidoID = Convert.ToInt32(row.Cells["ID"].Value != DBNull.Value ? row.Cells["ID"].Value : 0);

				if (pedidoID != 0)
				{
					EliminarPedidoDeBaseDeDatos(pedidoID);
					dgvventas.Rows.Remove(row);
					i--;
				}
			}
		}

		private void EliminarPedidoDeBaseDeDatos(int pedidoID)
		{
			string connectionString = "Data Source=DESKTOP-TP2GOM2\\SQLEXPRESS;Initial Catalog=Lavanderia;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string eliminarPedidoQuery = "DELETE FROM Pedidos WHERE PedidosID = @PedidoID";
				using (SqlCommand command = new SqlCommand(eliminarPedidoQuery, connection))
				{
					command.Parameters.AddWithValue("@PedidoID", pedidoID);

					try
					{
						command.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error al eliminar el pedido de la base de datos: " + ex.Message);
					}
				}
			}
		}

		private void CargarPedidosDelCliente()
		{
			// Asumiendo que la columna "Codigo" contiene el ID del cliente
			if (dgvpedidos.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvpedidos.SelectedRows[0];

				// Verifica que al menos una celda tenga información
				bool hasInfo = false;
				foreach (DataGridViewCell cell in selectedRow.Cells)
				{
					if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
					{
						hasInfo = true;
						break;
					}
				}

				if (hasInfo)
				{
					// Obtén el ID del cliente desde la fila seleccionada
					int clienteID = Convert.ToInt32(selectedRow.Cells["Codigo"].Value);

					// Llama a una función para cargar los pedidos del cliente en dgvpedidos
					CargarPedidosClienteEnDataGridView(clienteID);
				}
				else
				{
					MessageBox.Show("La fila seleccionada no contiene información.");
				}
			}
			else
			{
				MessageBox.Show("Por favor, seleccione una fila para cargar los pedidos del cliente.");
			}
		}

		private void CargarPedidosClienteEnDataGridView(int clienteID)
		{

			string connectionString = "Data Source=DESKTOP-TP2GOM2\\SQLEXPRESS;Initial Catalog=Lavanderia;Integrated Security=True";
			string query = "SELECT  PedidosID as ID, CodigoID as Codigo, Tipoderopa as Ropa, Precio FROM Pedidos WHERE CodigoID = @ClienteID";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@ClienteID", clienteID);

					try
					{
						SqlDataAdapter adapter = new SqlDataAdapter(command);
						DataTable dt = new DataTable();
						adapter.Fill(dt);

						// Asigna los datos al DataGridView dgvpedidos
						dgvpedidos.DataSource = dt;
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error al cargar los pedidos del cliente: " + ex.Message);
					}
				}
			}
		}

		private void txtpago_Click(object sender, EventArgs e)
		{
			RegistrarVenta();
		}

		private void Txtmontopagado_TextChanged(object sender, EventArgs e)
		{

		}

		private void Txtmontopagado_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void txtmontodevolver_TextChanged(object sender, EventArgs e)
		{

		}

		private void txttotal_TextChanged(object sender, EventArgs e)
		{

		}

		private void Devolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		
		}
		private void Detalledeventa_MouseDown(object sender, MouseEventArgs e)
		{
			
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Detalledeventa.Visible = false;
			btnCerrar.Visible = false;
		}

		private void Txtfacturar_Click(object sender, EventArgs e)
		{
			btnCerrar.Visible = true;
			Detalledeventa.Visible = true;
		
			Detalledeventa.Items.Clear();

			// Construye el contenido de la factura línea por línea
			Detalledeventa.Items.Add("      Lavanderia Central");
			Detalledeventa.Items.Add("C/17  Centro de la Ciudad. Cotui");
			Detalledeventa.Items.Add("Tel. 809-000-0000");
			// Obtén la fecha desde el control GunaDateTimePicker
			string fechaVenta = "Fecha de la Venta\t" + Dateventa.Value.ToString("dd/MM/yyyy");
			Detalledeventa.Items.Add(fechaVenta);
			Detalledeventa.Items.Add("___________________________________");
			Detalledeventa.Items.Add("Factura Consumidor final");
			Detalledeventa.Items.Add("___________________________________");
			Detalledeventa.Items.Add("Descripcion\tITB\tPrecio");

			// Agrega los detalles de venta desde el DataGridView al ListBox
			foreach (DataGridViewRow row in dgvventas.Rows)
			{
				if (!row.IsNewRow)
				{
					string descripcion = row.Cells["Ropa"].Value.ToString();
					string itb = "18%"; // Puedes obtener el valor real del ITB desde tus datos
					string precio = row.Cells["Precio"].Value.ToString();

					// Formatea la línea para alinear correctamente los valores
					string linea = $"{descripcion}\t\t{itb}\t{precio}";

					Detalledeventa.Items.Add(linea);
				}
			}

			Detalledeventa.Items.Add("___________________________________");

			// Obtén el valor del monto entregado desde Txtmontopagado
			string montoEntregado = "Monto Entregado\t" + Txtmontopagado.Text;
			Detalledeventa.Items.Add(montoEntregado);

			// Obtén el valor del total a pagar desde txttotal
			string total = "Total\t\t" + txttotal.Text;
			Detalledeventa.Items.Add(total);



			// Calcula el monto a devolver
			decimal montoAPagar = decimal.Parse(txttotal.Text);
			decimal montoEntregadoValor = 0;

			if (decimal.TryParse(Txtmontopagado.Text, out montoEntregadoValor))
			{
				// El valor se convirtió correctamente
			}
			else
			{
				// La cadena no es convertible a decimal, por lo tanto, se establece a cero
				montoEntregadoValor = 0;
			}
			decimal montoDevolverValor = montoEntregadoValor - montoAPagar;
			string montoDevolver = "Monto a devolver\t" + montoDevolverValor.ToString();
			Detalledeventa.Items.Add(montoDevolver);
			Detalledeventa.Items.Add("________________________________________");
			Detalledeventa.Items.Add("Gracias por su pedir nuestros servicios\n");

		}
	}
}


