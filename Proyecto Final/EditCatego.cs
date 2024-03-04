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
	public partial class EditCatego : Form
	{
		public EditCatego()
		{
			InitializeComponent();
		}

		private void btn_busc_Click(object sender, EventArgs e)
		{
			int idcat = 0;
			try
			{
				idcat = Convert.ToInt32(txt_idcat.Text);
				datostablas buscando = new datostablas();
				Categoria buscandocat = new Categoria();
				List<Categoria> buscandoconid = new List<Categoria>();
				buscandoconid = buscando.buscarcategoria(idcat);
				txt_busnomcat.Text = buscandoconid[0].nombre;
				txt_buscstocat.Text = buscandoconid[0].stock.ToString();
			}
			catch
			{
				string mensaje = "Ha ingresado un dato incorrecto en el ID. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idcat.Clear();
					txt_busnomcat.Clear();
					txt_buscstocat.Clear();
				}
				else
				{
					this.Close();
				}
			}
		}

		private void btn_editar_Click(object sender, EventArgs e)
		{
			int idcategoria = 0,stock = 0;
			string nombre = null;
			try
			{
				idcategoria = Convert.ToInt32(txt_idcat.Text);
				nombre = txt_busnomcat.Text;
				stock = Convert.ToInt32(txt_buscstocat.Text);
				datostablas editandocategoria = new datostablas();
				editandocategoria.editarcategoria(nombre, stock, idcategoria);
				MessageBox.Show("La informacion de la categoria seleccionada acaba de ser editada ", "Éxito");
				txt_idcat.Clear();
				txt_busnomcat.Clear();
				txt_buscstocat.Clear();
			}
			catch
			{
				string mensaje = "Hay un error. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idcat.Clear();
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
	}
}
