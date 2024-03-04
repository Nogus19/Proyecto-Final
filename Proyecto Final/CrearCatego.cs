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
	public partial class CrearCatego : Form
	{
		public CrearCatego()
		{
			InitializeComponent();
		}

		private void btn_ingres_Click(object sender, EventArgs e)
		{
			datostablas agregando = new datostablas();
			int stock = 0;
			string nombre = null;
			try
			{
				nombre = txt_nomcat.Text;
				stock = Convert.ToInt32(txt_stocat.Text);
				agregando.agregarcategoria(nombre, stock);
				MessageBox.Show("La categoria fue añadida correctamente a los registros ", "Éxito");
				txt_nomcat.Clear();
				txt_stocat.Clear();
			}
			catch
			{
				string mensaje = "Hay un error. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_nomcat.Clear();
					txt_stocat.Clear();
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
