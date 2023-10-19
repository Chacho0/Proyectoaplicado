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
	public partial class FrmProveedores : Form
	{
		public FrmProveedores()
		{
			InitializeComponent();
			Proveedores proveedores = new Proveedores();
			proveedores.informacion(dvgproveedores);
		}

		private void FrmProveedores_Load(object sender, EventArgs e)
		{

		}

		private void gunaTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			Proveedores proveedores = new Proveedores();
			proveedores.RegistrarProveedor(txtproveedor.Text,txttelefono.Text,txtdireccion.Text,txtcategoria.Text,txtemail.Text);
			proveedores.informacion(dvgproveedores);
		}

		private void btnmodificar_Click(object sender, EventArgs e)
		{
			Proveedores proveedores = new Proveedores();
			proveedores.ModificarProveedor(Txtid.Text,txtproveedor.Text, txttelefono.Text, txtdireccion.Text, txtcategoria.Text, txtemail.Text);
			proveedores.informacion(dvgproveedores);
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Proveedores proveedores = new Proveedores();
			proveedores.EliminarProveedor(Txtid.Text);
			proveedores.informacion(dvgproveedores);
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			Proveedores proveedores = new Proveedores();
			proveedores.BuscarProveedor(txtbuscar.Text,dvgproveedores);
		}

		private void dvgproveedores_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			Proveedores proveedores = new Proveedores();
			proveedores.SeleccionarProveedor(dvgproveedores,Txtid,txtproveedor, txttelefono, txtdireccion, txtcategoria, txtemail);
			
		}

		private void Devolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
