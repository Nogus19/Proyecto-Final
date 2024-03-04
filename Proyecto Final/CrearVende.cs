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
	public partial class CrearVende : Form
	{
		public CrearVende()
		{
			InitializeComponent();
		}

		private void btn_crear_Click(object sender, EventArgs e)
		{
			datostablas agregando = new datostablas();
			string nombre = null, apellido = null, dui = null, telefono = null, email = null, direccion = null;
			try
			{
				nombre = txt_nom.Text;
				apellido = txt_ape.Text;
				dui = txt_dui.Text;
				telefono = txt_tel.Text;
				email = txt_email.Text;
				direccion = txt_dir.Text;
				agregando.agregarvendedores(nombre, apellido, dui, telefono, email, direccion);
				MessageBox.Show("El vendedor fue añadido correctamente a los registros ", "Éxito");
				txt_nom.Clear();
				txt_ape.Clear();
				txt_dui.Clear();
				txt_tel.Clear();
				txt_email.Clear();
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
					txt_ape.Clear();
					txt_dui.Clear();
					txt_tel.Clear();
					txt_email.Clear();
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
