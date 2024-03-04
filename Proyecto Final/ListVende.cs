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
	public partial class ListVende : Form
	{
		public ListVende()
		{
			InitializeComponent();
		}

		private void ListVende_Load(object sender, EventArgs e)
		{
			datostablas mostrarven = new datostablas();
			dataGridView1.DataSource = mostrarven.mostrarlistavendedores();
		}
	}
}
