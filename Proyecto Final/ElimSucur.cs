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
	public partial class ElimSucur : Form
	{
		public ElimSucur()
		{
			InitializeComponent();
		}

		private void btn_elim_Click(object sender, EventArgs e)
		{
			int idsuc = 0;
			try
			{
				idsuc = Convert.ToInt32(txt_idsuc.Text);
				datostablas eliminandosucursal = new datostablas();
				eliminandosucursal.eliminarsucursal(idsuc);
				if (idsuc != 0)
				{
					MessageBox.Show("La sucursal seleccionada fue eliminada correctamente de los registros ", "Éxito");
					txt_idsuc.Clear();
				}
				else
				{
					MessageBox.Show("La sucursal seleccionada no existe ", "Fallo");
					txt_idsuc.Clear();
				}
			}
			catch
			{
				string mensaje = "Ha ingresado un dato incorrecto en el ID. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idsuc.Clear();
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
