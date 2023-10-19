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

namespace Proyecto_1
{
	public partial class FrmInventario : Form
	{
		public FrmInventario()
		{
			InitializeComponent();
			Inventario inventario = new Inventario();
			inventario.Informacion(dvinventario);

		}


		private void FrmInventario_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void FrmInventario_Load(object sender, EventArgs e)
		{

		}

		private void Btnbuscar_Click(object sender, EventArgs e)
		{

		}

		private void Devolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
