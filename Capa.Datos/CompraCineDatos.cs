using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class CompraCineDatos
    {
        public void Insertar(CompraCine CompraCine)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();

                string sql = "SP_compraCine_Insert";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@fecha", CompraCine.Fecha);
                comando.Parameters.AddWithValue("@idTicket", CompraCine.Ticket.IdTicket);
                comando.Parameters.AddWithValue("@cantidadNinos", CompraCine.CantNiños);
                comando.Parameters.AddWithValue("@cantidadRegular", CompraCine.CantRegula);
                comando.Parameters.AddWithValue("@descuento", CompraCine.Descuento);
                comando.Parameters.AddWithValue("@cargoServicio", CompraCine.CargoServicio);
                comando.Parameters.AddWithValue("@total", CompraCine.Total);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

        }

        public void Actualizar(CompraCine CompraCine)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();

                string sql = "SP_compraCine_Update";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@idCompra", CompraCine.IdCompra);
                comando.Parameters.AddWithValue("@fecha", CompraCine.Fecha);
                comando.Parameters.AddWithValue("@idTicket", CompraCine.Ticket.IdTicket);
                comando.Parameters.AddWithValue("@cantidadNinos", CompraCine.CantNiños);
                comando.Parameters.AddWithValue("@cantidadRegular", CompraCine.CantRegula);
                comando.Parameters.AddWithValue("@descuento", CompraCine.Descuento);
                comando.Parameters.AddWithValue("@cargoServicio", CompraCine.CargoServicio);
                comando.Parameters.AddWithValue("@total", CompraCine.Total);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

        }

        public CompraCine SeleccionarCompraCinePorId(int IdCompraCine)
        {
            CompraCine CompraCine = null;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();

                string sql = "SP_compraCine_SelectRow";
                TicketDatos TicketDatos = new TicketDatos();
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idCompraCine", IdCompraCine);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    CompraCine = new CompraCine()
                    {
                        IdCompra = Convert.ToInt32(reader["idCompra"]),
                        Fecha = Convert.ToDateTime(reader["fecha"].ToString()),
                        Ticket = TicketDatos.SeleccionarTicketPorId(Convert.ToInt32(reader["idTicket"])),
                        CantNiños = Convert.ToInt32(reader["cantidadNinos"]),
                        CantRegula = Convert.ToInt32(reader["cantidadRegular"]),
                        Descuento = Convert.ToDouble(reader["descuento"]),
                        CargoServicio = Convert.ToDouble(reader["cargoServcio"]),
                        Total = Convert.ToDouble(reader["total"])
                    };
                }
                return CompraCine;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                conexion.Close();
            }
        }

        public List<CompraCine> SeleccionarTodos()
        {
            List<CompraCine> CompraCines = new List<CompraCine>();
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();

                string sql = "SP_compraCine_SelectAll";

                SqlCommand comando = new SqlCommand(sql, conexion);
                TicketDatos TicketDatos = new TicketDatos();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    CompraCine CompraCine = new CompraCine()
                    {
                        IdCompra = Convert.ToInt32(reader["idCompra"]),
                        Fecha = Convert.ToDateTime(reader["fecha"].ToString()),
                        Ticket = TicketDatos.SeleccionarTicketPorId(Convert.ToInt32(reader["idTicket"])),
                        CantNiños = Convert.ToInt32(reader["cantidadNinos"]),
                        CantRegula = Convert.ToInt32(reader["cantidadRegular"]),
                        Descuento = Convert.ToDouble(reader["descuento"]),
                        CargoServicio = Convert.ToDouble(reader["cargoServcio"]),
                        Total = Convert.ToDouble(reader["total"])
                    };
                    CompraCines.Add(CompraCine);
                }
                return CompraCines;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                conexion.Close();
            }
        }

        public void Eliminar(int IdCompraCine)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();

                string sql = "SP_compraCine_DeleteRow";

                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idCompra", IdCompraCine);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                conexion.Close();
            }
        }
    }
}
