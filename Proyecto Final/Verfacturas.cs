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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final
{
	public partial class Verfacturas : Form
	{

		public Verfacturas()
		{
			InitializeComponent();
		}

		private void btn_busc_Click(object sender, EventArgs e)
		{
			int id = 0;
			double subtotal = 0, iva = 0, total = 0;
			try
			{
				id = Convert.ToInt32(txt_idfact.Text);
				datostablas buscando = new datostablas();
				List<Detallefactura> buscandodetall = new List<Detallefactura>();
				buscandodetall = buscando.buscardetalles(id);
				Factura buscandofact = new Factura();
				buscandofact = buscando.buscarfactura(id);
				List<BuscarFactura> lista = new List<BuscarFactura>();
				for (int i = 0; i < buscandodetall.Count; i++)
				{
					BuscarFactura busca = new BuscarFactura();
					Vendedores buscar = new Vendedores();
					busca.IDfactura = buscandofact.idfactura;
					busca.IDdetalle = buscandodetall[i].iddetalle;

					busca.IDproducto = buscandodetall[i].idproducto;
					List<Productos> buscproductos = new List<Productos>();
					buscproductos = buscando.buscarprod(buscandodetall[i].idproducto);
					if (buscproductos.Count > 0)
					{
						busca.NombreProducto = buscproductos[0].nombre;
					}

					buscar.idvendedor = buscandofact.idvendedor;
					List<Vendedores> listven = new List<Vendedores>();
					listven = buscando.buscarvendedores(buscandofact.idvendedor);
					if (listven.Count > 0)
					{
						txt_vendedor.Text = listven[0].nombre;
					}

					busca.Cantidad = buscandodetall[i].cantidad;
					busca.Precio = buscandodetall[i].precio;
					subtotal = subtotal + (busca.Cantidad * busca.Precio);
					iva = subtotal * 0.13;
					txt_fecha.Text = buscandofact.fecha.ToString("dddd, dd 'de' MMMM 'de' yyyy");
					total = buscandofact.total;
					lista.Add(busca);
					lista.Sort((a, b) => a.IDdetalle.CompareTo(b.IDdetalle));
				}
				txt_subtot.Text = subtotal.ToString();
				txt_iva.Text = iva.ToString();
				txt_tot.Text = total.ToString();
				dataGridView1.DataSource = lista;
			}
			catch
			{
				string mensaje = "Ha ingresado un dato incorrecto en el ID. ¿Desea volver a introducir los datos?", titulo = "Error";
				MessageBoxButtons botones = MessageBoxButtons.YesNo;
				DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
				if (resultado == DialogResult.Yes)
				{
					txt_idfact.Clear();
					txt_fecha.Clear();
					txt_vendedor.Clear();
					txt_iva.Text = 0.ToString();
					txt_subtot.Text = 0.ToString();
					txt_tot.Text = 0.ToString(); ;
					dataGridView1.DataSource = null;
					dataGridView1.Rows.Clear();
				}
				else
				{
					this.Close();
				}
			}
		}

		private void btn_limpiar_Click(object sender, EventArgs e)
		{
			txt_idfact.Clear();
			txt_fecha.Clear();
			txt_vendedor.Clear();
			txt_iva.Text = 0.ToString();
			txt_subtot.Text = 0.ToString();
			txt_tot.Text = 0.ToString(); ;
			dataGridView1.DataSource = null;
			dataGridView1.Rows.Clear();
		}

		private void btn_salir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
