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
	public partial class BuscCatego : Form
	{
		public BuscCatego()
		{
			InitializeComponent();
		}

		private void btn_verinfo_Click(object sender, EventArgs e)
		{
			int idcat = 0;
			try
			{
				idcat = Convert.ToInt32(txt_buscat.Text);
				datostablas buscando = new datostablas();
				Categoria buscandocat = new Categoria();
				List<Categoria> buscandoconid = new List<Categoria>();
				buscandoconid = buscando.buscarcategoria(idcat);
				txt_busnomcat.Text = buscandoconid[0].nombre;
				txt_buscstocat.Text = buscandoconid[0].stock.ToString();
			}
			catch
			{
				string mensaje = "Hay un error. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_buscat.Clear();
					txt_busnomcat.Clear();
					txt_buscstocat.Clear();
				}
				else
				{
					this.Close();
				}
			}
		}

		private void btn_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_limpiar_Click(object sender, EventArgs e)
		{
			txt_buscat.Clear();
			txt_busnomcat.Clear();
			txt_buscstocat.Clear();
		}
	}
}
