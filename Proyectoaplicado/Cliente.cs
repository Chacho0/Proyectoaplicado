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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
			Clientes l = new Clientes();
			l.informacion(gunaDataGridView1);
        }

		private void FrmCliente_Load(object sender, EventArgs e)
		{

		}
		
		private void FrmCliente_MouseDown(object sender, MouseEventArgs e)
		{
			
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			string nombre = txtnombre.Text;
			string telefono = txttelefono.Text;
			string direccion = txtdireccion.Text;
			string email = TxtEmail.Text;

			if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(telefono) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(email))
			{
				
				Clientes l = new Clientes();
				l.RegistrarCliente(nombre, telefono, direccion, email);
				l.informacion(gunaDataGridView1);
				nombre = "";
				telefono = "";
				direccion = "";
				email = "";
			}
			else
			{
				MessageBox.Show("No dejes ningun Campo vacio");
			}


		}

		private void gunaDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Clientes l = new Clientes();
			l.selecionargree(gunaDataGridView1,Txtid, txtnombre, txttelefono, txtdireccion, TxtEmail);
			l.informacion(gunaDataGridView1);
		}

		private void btnmodificar_Click(object sender, EventArgs e)
		{
			string id = Txtid.Text;
			string nombre = txtnombre.Text;
			string telefono = txttelefono.Text;
			string direccion = txtdireccion.Text;
			string email = TxtEmail.Text;

			if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(telefono) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(email))
			{
				
				Clientes l = new Clientes();
				l.ModificarCliente(id, nombre, telefono, direccion, email);

				
				l.informacion(gunaDataGridView1);
				id = "";
				nombre = "";
				telefono = "";
				direccion = "";
				email = "";
			}
			else
			{
				MessageBox.Show("No se permiten campos vacios para modificar");
			}



		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Clientes l = new Clientes();
			l.EliminarCliente(Txtid.Text);
			l.informacion(gunaDataGridView1);
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			if ((!string.IsNullOrEmpty(txtbuscar.Text)))
			{
				Clientes l = new Clientes();
				l.BuscarCliente(txtbuscar.Text, gunaDataGridView1);
				txtbuscar.Text = "";
			}
			else
			{
				MessageBox.Show("Escribe en el campus de busqueda");
			}
		}

		private void Devolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
