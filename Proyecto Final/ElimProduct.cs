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
	public partial class ElimProduct : Form
	{
		public ElimProduct()
		{
			InitializeComponent();
		}

		private void btn_elim_Click(object sender, EventArgs e)
		{
			int idpro = 0;
			try
			{
				idpro = Convert.ToInt32(txt_idpro.Text);
				datostablas eliminandoproductos = new datostablas();
				eliminandoproductos.eliminarproductos(idpro);
				if (idpro != 0)
				{
					MessageBox.Show("El producto seleccionado fue eliminado correctamente de los registros ", "Éxito");
					txt_idpro.Clear();
				}
				else
				{
					MessageBox.Show("No existe el producto seleccionado", "Fallo");
					txt_idpro.Clear();
				}
			}
			catch
			{
				string mensaje = "Ha ingresado un dato incorrecto en el ID. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idpro.Clear();
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
