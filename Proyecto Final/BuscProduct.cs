using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final
{
	public partial class BuscProduct : Form
	{
		public BuscProduct()
		{
			InitializeComponent();
		}

		private void btn_verinfo_Click(object sender, EventArgs e)
		{
			int id = 0;
			try
			{
				id = Convert.ToInt32(txt_id.Text);
				datostablas buscando = new datostablas();
				Productos buscandopro = new Productos();
				List<Productos> buscandoconid = new List<Productos>();
				buscandoconid = buscando.buscarproductos(id);
				txt_idsuc.Text = buscandoconid[0].idsucursal.ToString();
				txt_idcat.Text = buscandoconid[0].idcategoria.ToString();
				txt_nomprod.Text = buscandoconid[0].nombre;
				txt_precomp.Text = buscandoconid[0].preciocompra.ToString();
				txt_prevent.Text = buscandoconid[0].precioventa.ToString();
				txt_cant.Text = buscandoconid[0].cantidad.ToString();
			}
			catch
			{
				string mensaje = "Ha ingresado un dato incorrecto en el ID. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_id.Clear();
					txt_idsuc.Clear();
					txt_idcat.Clear();
					txt_nomprod.Clear();
					txt_precomp.Clear();
					txt_prevent.Clear();
					txt_cant.Clear();
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
			txt_id.Clear();
			txt_idsuc.Clear();
			txt_idcat.Clear();
			txt_nomprod.Clear();
			txt_precomp.Clear();
			txt_prevent.Clear();
			txt_cant.Clear();
		}
	}
}
