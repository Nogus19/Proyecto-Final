using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
	internal class datostablas
	{
		string cadenaconexion = "Database=proyectojp_grupo3; Datasource=proyectojp.site; User ID=proyectojp_usuario3; Password=bNFihuJ-7O@k;";

		public bool conectado()
		{
			try
			{
				MySqlConnection conexion = new MySqlConnection(cadenaconexion);
				conexion.Open();
			}
			catch
			{
				return false;
			}
			return true;
		}

		#region productostablas

		public List<Productos> mostrarlistaproductos()
		{
			List<Productos> listaproductos = new List<Productos>();
			string consulta = "select * from Productos";
			using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conexion);
				try
				{
					conexion.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					while (lector.Read())
					{
						Productos listapro = new Productos();
						listapro.idproducto = lector.GetInt32(0);
						listapro.idsucursal = lector.GetInt32(1);
						listapro.idcategoria = lector.GetInt32(2);
						listapro.nombre = lector[3].ToString();
						listapro.preciocompra = lector.GetDouble(4);
						listapro.precioventa = lector.GetDouble(5);
						listapro.cantidad = lector.GetInt32(6);
						listaproductos.Add(listapro);
					}
					lector.Close();
					conexion.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return listaproductos;
		}

		public List<Productos> buscarproductos(int id)
		{
			string consulta = "select * from Productos" + " where idproducto=@id";
			List<Productos> buscapro = new List<Productos>();
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@id", id);
				try
				{
					conectar.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					lector.Read();
					Productos listapro = new Productos();
					listapro.idproducto = lector.GetInt32(0);
					listapro.idsucursal = lector.GetInt32(1);
					listapro.idcategoria = lector.GetInt32(2);
					listapro.nombre = lector[3].ToString();
					listapro.preciocompra = lector.GetDouble(4);
					listapro.precioventa = lector.GetDouble(5);
					listapro.cantidad = lector.GetInt32(6);
					lector.Close();
					conectar.Close();
					buscapro.Add(listapro);
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return buscapro;
		}

		public void agregarproductos(int idsucursal, int idcategoria, string nombre, double preciocompra, double precioventa, int cantidad)
		{
			string consulta = "insert into Productos (idsucursal, idcategoria, nombre, preciocompra, precioventa, cantidad) values" + "(@idsuc, @idcat, @nom, @preccomp, @precven, @cant)";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@idsuc", idsucursal);
				comando.Parameters.AddWithValue("@idcat", idcategoria);
				comando.Parameters.AddWithValue("@nom", nombre);
				comando.Parameters.AddWithValue("@preccomp", preciocompra);
				comando.Parameters.AddWithValue("@precven", precioventa);
				comando.Parameters.AddWithValue("@cant", cantidad);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public void editarproductos(int idsucursal, int idcategoria, string nombre, double preciocompra, double precioventa, int cantidad, int idproducto)
		{
			string consulta = "update Productos set idsucursal=@idsuc, idcategoria=@idcat, nombre=@nom, preciocompra=@preccomp, precioventa=@precven, cantidad=@cant" + " where idproducto=@idpro";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@idsuc", idsucursal);
				comando.Parameters.AddWithValue("@idcat", idcategoria);
				comando.Parameters.AddWithValue("@nom", nombre);
				comando.Parameters.AddWithValue("@preccomp", preciocompra);
				comando.Parameters.AddWithValue("@precven", precioventa);
				comando.Parameters.AddWithValue("@cant", cantidad);
				comando.Parameters.AddWithValue("@idpro", idproducto);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public void eliminarproductos(int idproducto)
		{
			string consulta = "delete from Productos" + " where idproducto=@id";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@id", idproducto);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public List<Productos> buscarprod(int id)
		{
			string consulta = "select * from Productos" + " where idproducto=@id";
			List<Productos> buscapro = new List<Productos>();
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@id", id);
				try
				{
					conectar.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					while (lector.Read())
					{
						Productos listapro = new Productos();
						listapro.idproducto = lector.GetInt32(0);
						listapro.idsucursal = lector.GetInt32(1);
						listapro.idcategoria = lector.GetInt32(2);
						listapro.nombre = lector[3].ToString();
						listapro.preciocompra = lector.GetDouble(4);
						listapro.precioventa = lector.GetDouble(5);
						listapro.cantidad = lector.GetInt32(6);
						buscapro.Add(listapro);
					}
					lector.Close();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return buscapro;
		}  

		#endregion

		#region categoriatablas

		public List<Categoria> mostrarlistacategoria()
		{
			List<Categoria> listacategoria = new List<Categoria>();
			string consulta = "select * from Categoria";
			using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conexion);
				try
				{
					conexion.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					while (lector.Read())
					{
						Categoria listacat = new Categoria();
						listacat.idcategoria = lector.GetInt32(0);
						listacat.nombre = lector[1].ToString();
						listacat.stock = lector.GetInt32(2);
						listacategoria.Add(listacat);
					}
					lector.Close();
					conexion.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return listacategoria;
		}

		public List<Categoria> buscarcategoria(int idcat)
		{
			string consulta = "select * from Categoria" + " where idcategoria=@idcat";
			List<Categoria> buscacat = new List<Categoria>();
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@idcat", idcat);
				try
				{
					conectar.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					lector.Read();
					Categoria listacat = new Categoria();
					listacat.idcategoria = lector.GetInt32(0);
					listacat.nombre = lector[1].ToString();
					listacat.stock = lector.GetInt32(2);
					lector.Close();
					conectar.Close();
					buscacat.Add(listacat);
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return buscacat;
		}

		public void agregarcategoria(string nombre, int stock)
		{
			string consulta = "insert into Categoria (nombre, stock) values" + "(@nom, @stock)";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@nom", nombre);
				comando.Parameters.AddWithValue("@stock", stock);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public void editarcategoria(string nombre, int stock, int idcategoria)
		{
			string consulta = "update Categoria set nombre=@nom, stock=@stock" + " where idcategoria=@idcat";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@nom", nombre);
				comando.Parameters.AddWithValue("@stock", stock);
				comando.Parameters.AddWithValue("@idcat", idcategoria);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public void eliminarcategoria(int idcategoria)
		{
			string consulta = "delete from Categoria" + " where idcategoria=@id";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@id", idcategoria);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		#endregion

		#region vendedortablas
		public List<Vendedores> mostrarlistavendedores()
		{
			List<Vendedores> listavendedores = new List<Vendedores>();
			string consulta = "select * from Vendedores";
			using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conexion);
				try
				{
					conexion.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					while (lector.Read())
					{
						Vendedores listaven = new Vendedores();
						listaven.idvendedor = lector.GetInt32(0);
						listaven.nombre = lector[1].ToString();
						listaven.apellido = lector[2].ToString();
						listaven.DUI = lector[3].ToString();
						listaven.telefono = lector[4].ToString();
						listaven.email = lector[5].ToString();
						listaven.direccion = lector[6].ToString();
						listavendedores.Add(listaven);
					}
					lector.Close();
					conexion.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return listavendedores;
		}

		public List<Vendedores> buscarvendedores(int idven)
		{
			string consulta = "select * from Vendedores" + " where idvendedor=@id";
			List<Vendedores> buscaven = new List<Vendedores>();
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@id", idven);
				try
				{
					conectar.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					lector.Read();
					Vendedores listaven = new Vendedores();
					listaven.idvendedor = lector.GetInt32(0);
					listaven.nombre = lector[1].ToString();
					listaven.apellido = lector[2].ToString();
					listaven.DUI = lector[3].ToString();
					listaven.telefono = lector[4].ToString();
					listaven.email = lector[5].ToString();
					listaven.direccion = lector[6].ToString();
					lector.Close();
					conectar.Close();
					buscaven.Add(listaven);
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return buscaven;
		}

		public void agregarvendedores(string nombre, string apellido, string dui, string telefono, string email, string direccion)
		{
			string consulta = "insert into Vendedores (nombre, apellido, DUI, telefono, email, direccion) values" + "(@nom, @ape, @dui, @tel, @ema, @dir)";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@nom", nombre);
				comando.Parameters.AddWithValue("@ape", apellido);
				comando.Parameters.AddWithValue("@dui", dui);
				comando.Parameters.AddWithValue("@tel", telefono);
				comando.Parameters.AddWithValue("@ema", email);
				comando.Parameters.AddWithValue("@dir", direccion);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public void editarvendedores(string nombre, string apellido, string dui, string telefono, string email, string direccion, int idvendedor)
		{
			string consulta = "update Vendedores set nombre=@nom, apellido=@ape, DUI=@dui, telefono=@tel, email=@email, direccion=@dir" + " where idvendedor=@idven";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@nom", nombre);
				comando.Parameters.AddWithValue("@ape", apellido);
				comando.Parameters.AddWithValue("@dui", dui);
				comando.Parameters.AddWithValue("@tel", telefono);
				comando.Parameters.AddWithValue("@email", email);
				comando.Parameters.AddWithValue("@dir", direccion);
				comando.Parameters.AddWithValue("@idven", idvendedor);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public void eliminarvendedores(int idvendedor)
		{
			string consulta = "delete from Vendedores" + " where idvendedor=@id";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@id", idvendedor);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public List<Vendedores> buscarvend(int idven)
		{
			string consulta = "select * from Vendedores" + " where idvendedor=@id";
			List<Vendedores> buscaven = new List<Vendedores>();
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@id", idven);
				try
				{
					conectar.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					while (lector.Read())
					{
						Vendedores listaven = new Vendedores();
						listaven.idvendedor = lector.GetInt32(0);
						listaven.nombre = lector[1].ToString();
						listaven.apellido = lector[2].ToString();
						listaven.DUI = lector[3].ToString();
						listaven.telefono = lector[4].ToString();
						listaven.email = lector[5].ToString();
						listaven.direccion = lector[6].ToString();
						buscaven.Add(listaven);
					}
					lector.Close();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return buscaven;
		} //version modificada

		#endregion

		#region sucursaltablas

		public List<Sucursal> mostrarlistasucursal()
		{
			List<Sucursal> listasucursal = new List<Sucursal>();
			string consulta = "select * from Sucursal";
			using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conexion);
				try
				{
					conexion.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					while (lector.Read())
					{
						Sucursal listasuc = new Sucursal();
						listasuc.idsucursal = lector.GetInt32(0);
						listasuc.nombre = lector[1].ToString();
						listasuc.direccion = lector[2].ToString();
						listasucursal.Add(listasuc);
					}
					lector.Close();
					conexion.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return listasucursal;
		}

		public List<Sucursal> buscarsucursal(int idsuc)
		{
			string consulta = "select * from Sucursal" + " where idsucursal=@idsuc";
			List<Sucursal> buscasuc = new List<Sucursal>();
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@idsuc", idsuc);
				try
				{
					conectar.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					lector.Read();
					Sucursal listasuc = new Sucursal();
					listasuc.idsucursal = lector.GetInt32(0);
					listasuc.nombre = lector[1].ToString();
					listasuc.direccion = lector[2].ToString();
					lector.Close();
					conectar.Close();
					buscasuc.Add(listasuc);
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return buscasuc;
		}

		public void agregarsucursal(string nombre, string direccion)
		{
			string consulta = "insert into Sucursal (nombre, direccion) values" + "(@nom, @dir)";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@nom", nombre);
				comando.Parameters.AddWithValue("@dir", direccion);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public void editarsucursal(string nombre, string direccion, int idsucursal)
		{
			string consulta = "update Sucursal set nombre=@nom, direccion=@dir" + " where idsucursal=@idsuc";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@nom", nombre);
				comando.Parameters.AddWithValue("@dir", direccion);
				comando.Parameters.AddWithValue("@idsuc", idsucursal);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public void eliminarsucursal(int idsucursal)
		{
			string consulta = "delete from Sucursal" + " where idsucursal=@id";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@id", idsucursal);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		#endregion

		#region factura y detallefactura

		public List<Productos> listaprod()
		{
			List<Productos> listaproductos = new List<Productos>();
			string consulta = "select * from Productos";
			using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conexion);
				try
				{
					conexion.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					while (lector.Read())
					{
						Productos listapro = new Productos();
						listapro.idproducto = lector.GetInt32(0);
						listapro.nombre = lector[3].ToString();
						listapro.preciocompra = lector.GetDouble(4);
						listapro.precioventa = lector.GetDouble(5);
						listapro.cantidad = lector.GetInt32(6);
						listaproductos.Add(listapro);
					}
					lector.Close();
					conexion.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return listaproductos;
		}

		public List<Vendedores> listaven()
		{
			List<Vendedores> listavend = new List<Vendedores>();
			string consulta = "select * from Vendedores";
			using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conexion);
				try
				{
					conexion.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					while (lector.Read())
					{
						Vendedores listaven = new Vendedores();
						listaven.idvendedor = lector.GetInt32(0);
						listaven.nombre = lector[1].ToString();
						listaven.apellido = lector[2].ToString();
						listaven.DUI = lector[3].ToString();
						listaven.telefono = lector[4].ToString();
						listaven.email = lector[5].ToString();
						listaven.direccion = lector[6].ToString();
						listavend.Add(listaven);
					}
					lector.Close();
					conexion.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return listavend;
		}

		public void agregardetallefactura(int idfactura, int idproducto, int cantidad, double precio)
		{
			string consulta = "insert into Detallefactura (idfactura, idproducto, cantidad, precio) values" + "(@idfact, @idpro, @cant, @pre)";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@idfact", idfactura);
				comando.Parameters.AddWithValue("@idpro", idproducto);
				comando.Parameters.AddWithValue("@cant", cantidad);
				comando.Parameters.AddWithValue("@pre", precio);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public void agregarfactura(int idvendedor, double total, DateTime fecha)
		{
			string consulta = "insert into Factura (idvendedor, total, fecha) values" + "(@idven, @tot, @fech)";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@idven", idvendedor);
				comando.Parameters.AddWithValue("@tot", total);
				comando.Parameters.AddWithValue("@fech", fecha);
				try
				{
					conectar.Open();
					comando.ExecuteNonQuery();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public List<Productos> buscpro(string nom)
		{
			string consulta = "select * from Productos" + " where nombre=@nom";
			List<Productos> buscapro = new List<Productos>();
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@nom", nom);
				try
				{
					conectar.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					lector.Read();
					Productos listapro = new Productos();
					listapro.idproducto = lector.GetInt32(0);
					listapro.idsucursal = lector.GetInt32(1);
					listapro.idcategoria = lector.GetInt32(2);
					listapro.nombre = lector[3].ToString();
					listapro.preciocompra = lector.GetDouble(4);
					listapro.precioventa = lector.GetDouble(5);
					listapro.cantidad = lector.GetInt32(6);
					lector.Close();
					conectar.Close();
					buscapro.Add(listapro);
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return buscapro;
		}

		public List<Factura> buscid(int idvendedor, double total, DateTime fecha)
		{
			string consulta = "select * from Factura" + " where idvendedor=@idven AND total=@tot AND fecha=@fecha";
			List<Factura> buscidfac = new List<Factura>();
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@idven", idvendedor);
				comando.Parameters.AddWithValue("@tot", total);
				comando.Parameters.AddWithValue("@fecha", fecha);
				try
				{
					conectar.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					lector.Read();
					Factura listafactura = new Factura();
					listafactura.idfactura = lector.GetInt32(0);
					listafactura.idvendedor = lector.GetInt32(1);
					listafactura.total = lector.GetDouble(2);
					listafactura.fecha = lector.GetDateTime(3);
					lector.Close();
					conectar.Close();
					buscidfac.Add(listafactura);
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return buscidfac;
		}

		public Factura buscarfactura(int idfactura)
		{
			string consulta = "select * from Factura" + " where idfactura=@idfact";
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@idfact", idfactura);
				try
				{
					conectar.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					lector.Read();
					Factura listafactura = new Factura();
					listafactura.idfactura = lector.GetInt32(0);
					listafactura.idvendedor = lector.GetInt32(1);
					listafactura.total = lector.GetDouble(2);
					listafactura.fecha = lector.GetDateTime(3);
					lector.Close();
					conectar.Close();
					return listafactura;
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
		}

		public List<Detallefactura> buscardetalles(int idfactura)
		{
			string consulta = "select * from Detallefactura" + " where idfactura=@idfact";
			List<Detallefactura> buscafact = new List<Detallefactura>();
			using (MySqlConnection conectar = new MySqlConnection(cadenaconexion))
			{
				MySqlCommand comando = new MySqlCommand(consulta, conectar);
				comando.Parameters.AddWithValue("@idfact", idfactura);
				try
				{
					conectar.Open();
					MySqlDataReader lector = comando.ExecuteReader();
					while (lector.Read())
					{
						Detallefactura listadfactura = new Detallefactura();
						listadfactura.iddetalle = lector.GetInt32(0);
						listadfactura.idfactura = lector.GetInt32(1);
						listadfactura.idproducto = lector.GetInt32(2);
						listadfactura.cantidad = lector.GetInt32(3);
						listadfactura.precio = lector.GetDouble(4);
						buscafact.Add(listadfactura);
					}
					lector.Close();
					conectar.Close();
				}
				catch (Exception ex)
				{
					throw new Exception("Hay un error" + ex.Message);
				}
			}
			return buscafact;
		}

		#endregion
	}

	public class Productos
	{
		public int idproducto { get; set; }     
		public int idsucursal { get; set; }
		public int idcategoria { get; set; }
		public string nombre { get; set; }
		public double preciocompra { get; set; }
		public double precioventa { get; set; }
		public int cantidad { get; set; }
	}

	public class Sucursal
	{
		public int idsucursal { get; set; }  
		public string nombre { get; set; }
		public string direccion { get; set; }
	}

	public class Vendedores
	{
		public int idvendedor { get; set; }	 
		public string nombre { get; set; }
		public string apellido { get; set; }
		public string DUI { get; set; }
		public string telefono { get; set; }
		public string email { get; set; }
		public string direccion { get; set; }
	}

	public class Categoria
	{
		public int idcategoria { get; set; }    
		public string nombre { get; set; }
		public int stock { get; set; }
	}
	
	public class Detallefactura
	{
		public int iddetalle { get; set; }  
		public int idfactura { get; set; }
		public int idproducto { get; set; }
		public int cantidad { get; set; }
		public double precio { get; set; }
	}

    public class Factura
    {
        public int idfactura { get; set; }  
		public int idvendedor { get; set; }
		public double total { get; set; }
		public DateTime fecha { get; set; }
    }

	public class BuscarFactura
	{
		public int IDfactura { get; set; }
		public int IDdetalle { get; set; }
		public int IDproducto { get; set; }
		public string NombreProducto { get; set; }
		public int Cantidad { get; set; }
		public double Precio { get; set; }
	}
}

