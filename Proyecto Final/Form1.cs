using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListProduct hijoproduct1 = new ListProduct();
			hijoproduct1.MdiParent = this;
			hijoproduct1.Show();
		}

		private void buscarPorIDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BuscProduct hijoproduct2 = new BuscProduct();
			hijoproduct2.MdiParent = this;
			hijoproduct2.Show();
		}

		private void crearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CrearProduct hijoproduct3 = new CrearProduct();
			hijoproduct3.MdiParent = this;
			hijoproduct3.Show();
		}

		private void editarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditProduct hijoproduct4 = new EditProduct();
			hijoproduct4.MdiParent = this;
			hijoproduct4.Show();

		}

		private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ElimProduct hijoproduct5 = new ElimProduct();
			hijoproduct5.MdiParent = this;
			hijoproduct5.Show();
		}

		private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ListCatego hijocatego1 = new ListCatego();
			hijocatego1.MdiParent = this;
			hijocatego1.Show();
		}

		private void buscarPorIDToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			BuscCatego hijocatego2 = new BuscCatego();
			hijocatego2.MdiParent = this;
			hijocatego2.Show();
		}

		private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			CrearCatego hijocatego3 = new CrearCatego();
			hijocatego3.MdiParent = this;
			hijocatego3.Show();
		}

		private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			EditCatego hijocatego4 = new EditCatego();
			hijocatego4.MdiParent = this;
			hijocatego4.Show();
		}

		private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ElimCatego hijocatego5 = new ElimCatego();
			hijocatego5.MdiParent = this;
			hijocatego5.Show();
		}

		private void listadoToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ListVende hijovende1 = new ListVende();
			hijovende1.MdiParent = this;
			hijovende1.Show();
		}

		private void buscarPorIDToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			BuscVende hijovende2 = new BuscVende();
			hijovende2.MdiParent = this;
			hijovende2.Show();
		}

		private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			CrearVende hijovende3 = new CrearVende();
			hijovende3.MdiParent = this;
			hijovende3.Show();
		}

		private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			EditVende hijovende4 = new EditVende();
			hijovende4.MdiParent = this;
			hijovende4.Show();
		}

		private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ElimVende hijovende5 = new ElimVende();
			hijovende5.MdiParent = this;
			hijovende5.Show();
		}

		private void listadoToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			ListSucur hijosucur1 = new ListSucur();
			hijosucur1.MdiParent = this;
			hijosucur1.Show();
		}

		private void buscarPorIDToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			BuscSucur hijosucur2 = new BuscSucur();
			hijosucur2.MdiParent = this;
			hijosucur2.Show();
		}

		private void crearToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			CrearSucur hijosucur3 = new CrearSucur();
			hijosucur3.MdiParent = this;
			hijosucur3.Show();
		}

		private void editarToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			EditSucur hijosucur4 = new EditSucur();
			hijosucur4.MdiParent = this;
			hijosucur4.Show();
		}

		private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			ElimSucur hijosucur5 = new ElimSucur();
			hijosucur5.MdiParent = this;
			hijosucur5.Show();
		}

		private void probarConexionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			datostablas conectar = new datostablas();
			if (conectar.conectado())
			{
				MessageBox.Show("Se logro establecer conexion con la base de datos", "Conectado");
			}
			else
			{
				MessageBox.Show("No se pudo establecer la conexion", "No conectado");
			}
		}

		private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Facturar hijofact1 = new Facturar();
			hijofact1.MdiParent = this;
			hijofact1.Show();
		}

		private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Verfacturas hijofact2 = new Verfacturas();
			hijofact2.MdiParent = this;
			hijofact2.Show();
		}
	}
}
