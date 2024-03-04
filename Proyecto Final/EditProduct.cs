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
	public partial class EditProduct : Form
	{
		public EditProduct()
		{
			InitializeComponent();
		}

		private void btn_busc_Click(object sender, EventArgs e)
		{
			try
			{
				int idproducto = 0;
				idproducto = Convert.ToInt32(txt_idpro.Text);
				datostablas buscando = new datostablas();
				Productos buscandopro = new Productos();
				List<Productos> buscandoconid = new List<Productos>();
				buscandoconid = buscando.buscarproductos(idproducto);
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
					txt_idpro.Clear();
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

		private void btn_editar_Click(object sender, EventArgs e)
		{
			int idproducto, idsucursal = 0, idcategoria = 0, cantidad = 0;
			string nombre = null;
			double preciocompra = 0, precioventa = 0;
			try
			{
				idproducto = Convert.ToInt32(txt_idpro.Text);
				idsucursal = Convert.ToInt32(txt_idsuc.Text);
				idcategoria = Convert.ToInt32(txt_idcat.Text);
				nombre = txt_nomprod.Text;
				preciocompra = Convert.ToDouble(txt_precomp.Text);
				precioventa = Convert.ToDouble(txt_prevent.Text);
				cantidad = Convert.ToInt32(txt_cant.Text);
				datostablas editandoproductos = new datostablas();
				editandoproductos.editarproductos(idsucursal, idcategoria, nombre, preciocompra, precioventa, cantidad, idproducto);
				MessageBox.Show("La informacion del producto seleccionado acaba de ser editada", "Éxito");
				txt_idpro.Clear();
				txt_idsuc.Clear();
				txt_idcat.Clear();
				txt_nomprod.Clear();
				txt_precomp.Clear();
				txt_prevent.Clear();
				txt_cant.Clear();
			}
			catch
			{
				string mensaje = "Hay un error. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idpro.Clear();
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
	}
}
