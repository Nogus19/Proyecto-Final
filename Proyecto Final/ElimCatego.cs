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
	public partial class ElimCatego : Form
	{
		public ElimCatego()
		{
			InitializeComponent();
		}

		private void btn_elim_Click(object sender, EventArgs e)
		{
			int idcat = 0;
			try
			{
				idcat = Convert.ToInt32(txt_idcat.Text);
				datostablas eliminandocategorias = new datostablas();
				eliminandocategorias.eliminarcategoria(idcat);
				if (idcat != 0)
				{
					MessageBox.Show("La categoria seleccionada ha sido eliminada correctamente de los registros ", "Éxito");
					txt_idcat.Clear();
				}
				else
				{
					MessageBox.Show("La categoria seleccionada no existe ", "Fallo");
					txt_idcat.Clear();
				}
			}
			catch
			{
				string mensaje = "Hay un error en el ID. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idcat.Clear();
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
