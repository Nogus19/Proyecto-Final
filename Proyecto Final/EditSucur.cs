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
	public partial class EditSucur : Form
	{
		public EditSucur()
		{
			InitializeComponent();
		}

		private void btn_busc_Click(object sender, EventArgs e)
		{
			int idsuc = 0;
			try
			{
				idsuc = Convert.ToInt32(txt_idsuc.Text);
				datostablas buscando = new datostablas();
				Sucursal buscandosuc = new Sucursal();
				List<Sucursal> buscandoconid = new List<Sucursal>();
				buscandoconid = buscando.buscarsucursal(idsuc);
				txt_nom.Text = buscandoconid[0].nombre;
				txt_dir.Text = buscandoconid[0].direccion;
			}
			catch
			{
				string mensaje = "Ha ingresado un dato incorrecto en el ID. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idsuc.Clear();
					txt_nom.Clear();
					txt_dir.Clear();
				}
				else
				{
					this.Close();
				}
			}
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			int idsucursal = 0;
			string nombre = null, direccion = null;
			try
			{
				idsucursal = Convert.ToInt32(txt_idsuc.Text);
				nombre = txt_nom.Text;
				direccion = txt_dir.Text;
				datostablas editandocategoria = new datostablas();
				editandocategoria.editarsucursal(nombre, direccion, idsucursal);
				MessageBox.Show("La informacion de la sucursal seleccionada ha sido editada", "Éxito");
				txt_idsuc.Clear();
				txt_nom.Clear();
				txt_dir.Clear();
			}
			catch
			{
				string mensaje = "Hay un error. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idsuc.Clear();
					txt_nom.Clear();
					txt_dir.Clear();
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
