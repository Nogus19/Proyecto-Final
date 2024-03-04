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
	public partial class ListCatego : Form
	{
		public ListCatego()
		{
			InitializeComponent();
		}


		private void ListCatego_Load(object sender, EventArgs e)
		{
			datostablas mostrarcat = new datostablas();
			dataGridView1.DataSource = mostrarcat.mostrarlistacategoria();
		}
	}
}
