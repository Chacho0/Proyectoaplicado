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
	public partial class FrmReporteproductos : Form
	{
		public FrmReporteproductos()
		{
			InitializeComponent();
		}

		private void Reporteproductos_Load(object sender, EventArgs e)
		{

            this.reportViewerproductos.RefreshReport();
           
        }
		private void MostrarReporte()
		{
			//Crea un DataTable para almacenar tus datos de productos
			DataTable dt = new DataTable("Productos");

			// Llena el DataTable con los datos de tu DataGridView dgvProductos
			foreach (DataGridViewColumn col in dvgproductos.Columns)
			{
				dt.Columns.Add(col.Name);
			}

			foreach (DataGridViewRow row in dvgproductos.Rows)
			{
				DataRow dRow = dt.NewRow();
				foreach (DataGridViewCell cell in row.Cells)
				{
					dRow[cell.ColumnIndex] = cell.Value;
				}
				dt.Rows.Add(dRow);
			}

			// Define una fuente de datos con tu DataTable
			ReportDataSource rds = new ReportDataSource("Productos", dt);

			// Asigna la fuente de datos al control ReportViewer
			reportViewerproductos.LocalReport.DataSources.Clear();
			reportViewerproductos.LocalReport.DataSources.Add(rds);

			// Refresca el informe
			reportViewerproductos.RefreshReport();
		}

		private void btnbusproducto_Click(object sender, EventArgs e)
		{
			Producto producto = new Producto();
			producto.informacion(dvgproductos);
		}

		private void btnimprimirproducto_Click(object sender, EventArgs e)
		{
			reportViewerproductos.Visible = true;
			btncerrar.Visible = true;
			MostrarReporte();
		}

		private void btncerrar_Click(object sender, EventArgs e)
		{
			reportViewerproductos.Visible = false;
			btncerrar.Visible = false;
		}

		private void dvgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
