using Proyectoaplicado.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class fRmPedidos : Form
    {
        public fRmPedidos()
        {
            InitializeComponent();
			Pedido l = new Pedido();
			l.Pedidosinformacion(gunaDataGridView1);
        }
		
		private void fRmPedidos_MouseDown(object sender, MouseEventArgs e)
		{
			
		}

		private void fRmPedidos_Load(object sender, EventArgs e)
		{

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Pedido l = new Pedido();
			l.EliminarPedido(txtid.Text);
		}

		private void btnregistrar_Click(object sender, EventArgs e)
		{
			Pedido l = new Pedido();
			l.RegistrarPedido(txtcodigocliente.Text,cbmtiporopa.Text,datetimefechaentrega,txthorallegada.Text,datetimefechaespera,txthoraespera.Text,cmbestadopedido.Text,cmbprecio.Text);
			l.Pedidosinformacion(gunaDataGridView1);
		}

		private void btnmodificar_Click(object sender, EventArgs e)
		{
			Pedido l = new Pedido();
			l.ModificarPedido(txtid.Text,txtcodigocliente.Text, cbmtiporopa.Text, datetimefechaentrega, txthorallegada.Text, datetimefechaespera, txthoraespera.Text, cmbestadopedido.Text,cmbprecio.Text);
			l.Pedidosinformacion(gunaDataGridView1);
		}

		private void gunaDataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			Pedido l = new Pedido();
			l.selecionargree(gunaDataGridView1,txtid, txtcodigocliente, cbmtiporopa, datetimefechaentrega, txthorallegada, datetimefechaespera, txthoraespera, cmbestadopedido,cmbprecio);
			l.Pedidosinformacion(gunaDataGridView1);
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			Pedido l = new Pedido();
			l.BuscarCliente(Txtbuscar.Text,gunaDataGridView1);
		}

		private void Devolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
