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
	public partial class ListSucur : Form
	{
		public ListSucur()
		{
			InitializeComponent();
		}

		private void ListSucur_Load(object sender, EventArgs e)
		{
			datostablas mostrarsuc = new datostablas();
			dataGridView1.DataSource = mostrarsuc.mostrarlistasucursal();
		}
	}
}
