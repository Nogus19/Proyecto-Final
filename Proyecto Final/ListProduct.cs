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
	public partial class ListProduct : Form
	{
		public ListProduct()
		{
			InitializeComponent();
		}


		private void ListProduct_Load(object sender, EventArgs e)
		{
			datostablas mostrarpro = new datostablas();
			dataGridView1.DataSource = mostrarpro.mostrarlistaproductos();
		}
	}
}
