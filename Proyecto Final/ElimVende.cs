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
	public partial class ElimVende : Form
	{
		public ElimVende()
		{
			InitializeComponent();
		}

		private void btn_elim_Click(object sender, EventArgs e)
		{
			int idven = 0;
			try
			{
				idven = Convert.ToInt32(txt_idven.Text);
				datostablas eliminandovendedores = new datostablas();
				eliminandovendedores.eliminarvendedores(idven);
				if (idven != 0)
				{
					MessageBox.Show("El vendedor seleccionado fue eliminado correctamente de los registros ", "Éxito");
					txt_idven.Clear();
				}
				else
				{
					MessageBox.Show("El vendedor seleccionado no existe ", "Fallo");
					txt_idven.Clear();
				}
			}
			catch
			{
				string mensaje = "Ha ingresado un dato incorrecto en el ID. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idven.Clear();
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
