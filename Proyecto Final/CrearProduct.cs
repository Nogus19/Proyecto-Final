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
	public partial class CrearProduct : Form
	{
		public CrearProduct()
		{
			InitializeComponent();
		}

		private void btn_ingres_Click(object sender, EventArgs e)
		{
			datostablas agregando = new datostablas();
			int idsucursal = 0, idcategoria = 0, cantidad = 0;
			string nombre = null;
			double preciocompra = 0, precioventa = 0;
			try
			{
				idsucursal = Convert.ToInt32(txt_idsuc.Text);
				idcategoria = Convert.ToInt32(txt_idcat.Text);
				nombre = txt_nomprod.Text;
				preciocompra = Convert.ToDouble(txt_precomp.Text);
				precioventa = Convert.ToDouble(txt_prevent.Text);
				cantidad = Convert.ToInt32(txt_cant.Text);
				agregando.agregarproductos(idsucursal, idcategoria, nombre, preciocompra, precioventa, cantidad);
				MessageBox.Show("El producto se ha añadido correctamente a los registros ", "Éxito");
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
