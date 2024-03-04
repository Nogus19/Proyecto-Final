using System;
using System.Collections;
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
	public partial class Facturar : Form
	{
		datostablas obj = new datostablas();
		List<Factura> listfactura = new List<Factura>();
		List<Detallefactura> listdetall = new List<Detallefactura>();
		List<Productos> listapro = new List<Productos>();
		List<Vendedores> listven = new List<Vendedores>();

		public Facturar()
		{
			InitializeComponent();
		}

		private void Facturas_Load(object sender, EventArgs e)
		{
			listapro = obj.listaprod();
			listven = obj.listaven();

			combopro.DataSource = listapro;
			combopro.DisplayMember = "nombre";
			comboven.DataSource = listven;
			comboven.DisplayMember = "nombre";
		}

		private void combopro_SelectedIndexChanged(object sender, EventArgs e)
		{
			txt_prec.Text = listapro[combopro.SelectedIndex].precioventa.ToString();
		}

		private void btn_agregar_Click(object sender, EventArgs e)
		{
			int cantidad = 0;
			double precio = 0, subtotal = 0, iva = 0, total = 0;
			try
			{
				cantidad = Convert.ToInt32(txt_cant.Text);
				precio = Convert.ToDouble(txt_prec.Text);

				DataGridViewRow fila = (DataGridViewRow)dataGridView1.Rows[0].Clone();
				fila.Cells[0].Value = combopro.Text;
				fila.Cells[1].Value = precio;
				fila.Cells[2].Value = cantidad;
				fila.Cells[3].Value = precio * cantidad;
				dataGridView1.Rows.Add(fila);

				subtotal = Convert.ToDouble(txt_subtot.Text);
				iva = Convert.ToDouble(txt_iva.Text);
				total = Convert.ToDouble(txt_tot.Text);

				subtotal = subtotal + (precio * cantidad);
				iva = subtotal * 0.13;
				total = subtotal + iva;

				txt_subtot.Text = subtotal.ToString();
				txt_iva.Text = iva.ToString();
				txt_tot.Text = total.ToString();
			}
			catch
			{
				string mensaje = "Ha ingresado un dato incorrecto en la cantidad. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_cant.Clear();
					txt_iva.Text = 0.ToString();
					txt_subtot.Text = 0.ToString();
					txt_tot.Text = 0.ToString();
					dataGridView1.Rows.Clear();
				}
				else
				{
					this.Close();
				}
			}
		}

		private void btn_guardar_Click(object sender, EventArgs e)
		{
			int cantidad = 0, idvendedor = 0, idfactura = 0, idproducto = 0;
			double precio = 0, total = 0;
			string producto = null;
			DateTime fecha;

			List<Factura> id = new List<Factura>();
			total = Convert.ToDouble(txt_tot.Text);
			fecha = dateTimePicker_fecha.Value.Date;

			idvendedor = listven[comboven.SelectedIndex].idvendedor;
			if (Convert.ToDouble(txt_tot.Text) != 0 && fecha != null)
			{
				obj.agregarfactura(idvendedor, total, fecha);
			}
			else
			{
				MessageBox.Show("Lo sentimos, si no añade nada no puede facturar", "Fallo");
			}

			for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
			{
				DataGridViewRow row = dataGridView1.Rows[i];
				if (row.Cells["Producto"].Value != null)
				{
					producto = row.Cells["Producto"].Value.ToString();
				}

				id = obj.buscid(idvendedor, total, fecha);
				idfactura = id[0].idfactura;
				List<Productos> idp = new List<Productos>();
				idp = obj.buscpro(producto);
				idproducto = idp[0].idproducto;

				cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
				precio = Convert.ToDouble(row.Cells["Precio"].Value);
				if (txt_cant != null && txt_prec != null)
				{
					obj.agregardetallefactura(idfactura, idproducto, cantidad, precio);
				}
			}
			MessageBox.Show("La factura y sus detalles fueron añadidos correctamente a los registros ", "Éxito");
		}

		private void btn_limp_Click(object sender, EventArgs e)
		{
			txt_cant.Clear();
			txt_iva.Text = 0.ToString();
			txt_subtot.Text = 0.ToString();
			txt_tot.Text = 0.ToString();
			dataGridView1.Rows.Clear();
		}

		private void btn_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
