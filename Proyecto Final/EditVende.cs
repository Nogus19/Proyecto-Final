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
	public partial class EditVende : Form
	{
		public EditVende()
		{
			InitializeComponent();
		}

		private void btn_busc_Click(object sender, EventArgs e)
		{
			int idven = 0;
			try
			{
				idven = Convert.ToInt32(txt_idven.Text);
				datostablas buscando = new datostablas();
				Vendedores buscandoven = new Vendedores();
				List<Vendedores> buscandoconid = new List<Vendedores>();
				buscandoconid = buscando.buscarvendedores(idven);
				txt_nom.Text = buscandoconid[0].nombre;
				txt_ape.Text = buscandoconid[0].apellido;
				txt_dui.Text = buscandoconid[0].DUI;
				txt_tel.Text = buscandoconid[0].telefono;
				txt_email.Text = buscandoconid[0].email;
				txt_dir.Text = buscandoconid[0].direccion;
			}
			catch
			{
				string mensaje = "Hay un error en el ID. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idven.Clear();
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

		private void btn_edit_Click(object sender, EventArgs e)
		{
			int idvendedor = 0;
			string nombre = null, apellido = null, dui = null, telefono = null, email = null, direccion = null;
			try
			{
				idvendedor = Convert.ToInt32(txt_idven.Text);
				nombre = txt_nom.Text;
				apellido = txt_ape.Text;
				dui = txt_dui.Text;
				telefono = txt_tel.Text;
				email = txt_email.Text;
				direccion = txt_dir.Text;
				datostablas editandovendedores = new datostablas();
				editandovendedores.editarvendedores(nombre, apellido, dui, telefono, email, direccion, idvendedor);
				MessageBox.Show("La informacion del vendedor seleccionado acaba de ser editada", "Éxito");
				txt_idven.Clear();
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
					txt_idven.Clear();
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
