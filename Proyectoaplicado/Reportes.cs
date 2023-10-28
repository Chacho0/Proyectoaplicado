using Guna.UI.WinForms;
using Microsoft.Reporting.WinForms;
using Proyecto_1;
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
    public partial class Frmreporte : Form
    {
        public Frmreporte()
        {
            InitializeComponent();
			
		}

        private void Form1_Load(object sender, EventArgs e)
        {


			
			
		}

		private void Devolver_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
            
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			
		}
		private void MostrarFormularioEnPanel(Form formulario)
		{
			formulario.TopLevel = false;
			formulario.FormBorderStyle = FormBorderStyle.None;
			formulario.Dock = DockStyle.Fill;

			Devolver.Controls.Clear();
			Devolver.Controls.Add(formulario);

			formulario.Show();

			formulario.Show();
		}
		private void btncliente_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmReportecliente());
		}

		private void lbcliente_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dgvreportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnproductos_Click(object sender, EventArgs e)
		{

			MostrarFormularioEnPanel(new FrmReporteproductos());
		}

		private void txtpedidos_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnpedidos_Click(object sender, EventArgs e)
		{
			MostrarFormularioEnPanel(new FrmReportepedidos());
		}

		private void btnventas_Click(object sender, EventArgs e)
		{

			MostrarFormularioEnPanel(new FrmReporteventas());
		}
		

		private void btnimprimir_Click(object sender, EventArgs e)
		{
			
		

		}

		private void btnCerrar_Click_1(object sender, EventArgs e)
		{
			
		}

		private void btncerrar_Click_2(object sender, EventArgs e)
		{

		}

		private void btncerrar_Click_3(object sender, EventArgs e)
		{
			

		}

		private void btnimprimirproducto_Click(object sender, EventArgs e)
		{
			
		}

		private void btnimprimirpedido_Click(object sender, EventArgs e)
		{
			
		}

		private void btninventas_Click(object sender, EventArgs e)
		{
			
		}
	}
}
 