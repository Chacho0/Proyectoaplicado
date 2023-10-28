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
	public partial class FrmReporteventas : Form
	{
		public FrmReporteventas()
		{
			InitializeComponent();
		}

		private void Reporteventas_Load(object sender, EventArgs e)
		{

            this.reportViewerventas.RefreshReport();
        }

		private void reportViewerventas_Load(object sender, EventArgs e)
		{

		}

		private void btnbuventas_Click(object sender, EventArgs e)
		{
			ventas ventas = new ventas();
			ventas.informacion(dvgventas);
			reportViewerventas.Visible=false;
		}
		private void MostrarReporte()
		{
			//Crea un DataTable para almacenar tus datos de productos
			DataTable dt = new DataTable("Ventas");

			// Llena el DataTable con los datos de tu DataGridView dgvProductos
			foreach (DataGridViewColumn col in dvgventas.Columns)
			{
				dt.Columns.Add(col.Name);
			}

			foreach (DataGridViewRow row in dvgventas.Rows)
			{
				DataRow dRow = dt.NewRow();
				foreach (DataGridViewCell cell in row.Cells)
				{
					dRow[cell.ColumnIndex] = cell.Value;
				}
				dt.Rows.Add(dRow);
			}

			// Define una fuente de datos con tu DataTable
			ReportDataSource rds = new ReportDataSource("Ventas", dt);

			// Asigna la fuente de datos al control ReportViewer
			reportViewerventas.LocalReport.DataSources.Clear();
			reportViewerventas.LocalReport.DataSources.Add(rds);

			// Refresca el informe
			reportViewerventas.RefreshReport();
		}
		private void btninventas_Click(object sender, EventArgs e)
		{
			MostrarReporte();
			dvgventas.Visible = false;
			reportViewerventas.Visible = true;
		}

		private void btncerrar_Click(object sender, EventArgs e)
		{
			dvgventas.Visible = true;
			reportViewerventas.Visible = false;
			btncerrar.Visible = false;

		}
	}
}
