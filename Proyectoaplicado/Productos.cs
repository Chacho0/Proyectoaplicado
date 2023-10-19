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
	public partial class FrmProductos : Form
	{
		public FrmProductos()
		{
			InitializeComponent();
			Producto producto = new Producto();
			producto.informacion(dvgproducto);
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			Producto producto = new Producto();
			producto.AgregarProducto(txtproveedor.Text,txtnombre.Text,Txtcategoria.Text,txtcantidad.Text,txttotal.Text);
			producto.informacion(dvgproducto);
		}

		private void btnmodificar_Click(object sender, EventArgs e)
		{
			Producto producto = new Producto();
			producto.ModificarProducto(Txtid.Text,txtproveedor.Text, txtnombre.Text, Txtcategoria.Text, txtcantidad.Text, Txtprecio.Text,txttotal.Text);
			producto.informacion(dvgproducto);

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Producto producto = new Producto();
			producto.EliminarProducto(Txtid.Text);
			producto.informacion(dvgproducto);
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			Producto producto = new Producto();
			producto.BuscarProductoPorDescripcion(dvgproducto,txtbuscar.Text);
			
		}

		private void dvgproducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Producto producto = new Producto();
			producto.SeleccionarProducto(dvgproducto,Txtid,txtproveedor, txtnombre, Txtcategoria, txtcantidad, Txtprecio,txttotal);
			
		}

		private void Devolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
