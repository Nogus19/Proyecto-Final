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
	public partial class CrearSucur : Form
	{
		public CrearSucur()
		{
			InitializeComponent();
		}

		private void btn_agregar_Click(object sender, EventArgs e)
		{
			datostablas agregando = new datostablas();
			string nombre = null, direccion = null;
			try
			{
				nombre = txt_nom.Text;
				direccion = txt_dir.Text;
				agregando.agregarsucursal(nombre, direccion);
				MessageBox.Show("La sucursal fue añadida correctamente a los registros ", "Éxito");
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
