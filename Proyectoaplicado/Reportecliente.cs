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
	public partial class FrmReportecliente : Form
	{
		public FrmReportecliente()
		{
			InitializeComponent();
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			Reportecliente reportecliente = new Reportecliente();
			reportecliente.BuscarCliente(txtbuscador.Text, dvgclientes);
			reportViewerclientes.Visible = false;
			btncerrar.Visible = false;
			dvgclientes.Visible = true;


		}

		private void btnimprimir_Click(object sender, EventArgs e)
		{
			dvgclientes.Visible = false;
			reportViewerclientes.Visible = true;
			btncerrar.Visible = true;
		}

		private void FrmReportecliente_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'lavanderiaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
			this.clientesTableAdapter.Fill(this.lavanderiaDataSet.Clientes);

			this.reportViewerclientes.RefreshReport();
		}

		private void btncerrar_Click(object sender, EventArgs e)
		{
			reportViewerclientes.Visible = false;
			btncerrar.Visible = false;
		}

		private void lbcliente_Click(object sender, EventArgs e)
		{

		}
	}
}
