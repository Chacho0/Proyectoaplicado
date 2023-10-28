using Microsoft.Reporting.WinForms;
using Proyectoaplicado.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectoaplicado
{
	public partial class FrmReportepedidos : Form
	{
		public FrmReportepedidos()
		{
			InitializeComponent();
		}

		private void Reportepedidos_Load(object sender, EventArgs e)
		{

            this.reportViewerpedidos.RefreshReport();
        }

		private void btnimprimirpedido_Click(object sender, EventArgs e)
		{
			MostrarReporte();
			dvgpedidos.Visible = false;
			reportViewerpedidos.Visible = true;
			btncerrar.Visible = true;


		}
		private void MostrarReporte()
		{
			//Crea un DataTable para almacenar tus datos de productos
			DataTable dt = new DataTable("Pedidos");

			// Llena el DataTable con los datos de tu DataGridView dgvProductos
			foreach (DataGridViewColumn col in dvgpedidos.Columns)
			{
				dt.Columns.Add(col.Name);
			}

			foreach (DataGridViewRow row in dvgpedidos.Rows)
			{
				DataRow dRow = dt.NewRow();
				foreach (DataGridViewCell cell in row.Cells)
				{
					dRow[cell.ColumnIndex] = cell.Value;
				}
				dt.Rows.Add(dRow);
			}

			// Define una fuente de datos con tu DataTable
			ReportDataSource rds = new ReportDataSource("Pedidos", dt);

			// Asigna la fuente de datos al control ReportViewer
			reportViewerpedidos.LocalReport.DataSources.Clear();
			reportViewerpedidos.LocalReport.DataSources.Add(rds);

			// Refresca el informe
			reportViewerpedidos.RefreshReport();
		}

		private void btnbupedido_Click(object sender, EventArgs e)
		{
			Reportepedido reportepedido = new Reportepedido();
			reportepedido.BuscarCliente(txtpedidos.Text,dateFecha.Value,dvgpedidos);
			
			dvgpedidos.Visible=true;
			reportViewerpedidos.Visible = false;
			btncerrar.Visible = false;
		}

		private void btncerrar_Click(object sender, EventArgs e)
		{
			reportViewerpedidos.Visible = false;
			btncerrar.Visible = false;
			dvgpedidos.Visible = true;
		}
	}
}
