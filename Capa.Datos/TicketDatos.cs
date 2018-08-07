using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class TicketDatos
    {
        public void Insertar(Ticket Ticket)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();

                string sql = "SP_ticket_Insert";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@nombrePelicula", Ticket.NombrePelicula);
                comando.Parameters.AddWithValue("@detalle", Ticket.Detalle);
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

        public void Actualizar(Ticket Ticket)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();

                string sql = "SP_ticket_Update";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@idTicket", Ticket.IdTicket);
                comando.Parameters.AddWithValue("@nombrePelicula", Ticket.NombrePelicula);
                comando.Parameters.AddWithValue("@detalle", Ticket.Detalle);
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

        public Ticket SeleccionarTicketPorId(int IdTicket)
        {
            Ticket Ticket = null;
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();

                string sql = "SP_ticket_SelectRow";

                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idTicket", IdTicket);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Ticket = new Ticket()
                    {
                        IdTicket = Convert.ToInt32(reader["idTicket"]),
                        NombrePelicula = reader["nombrePelicula"].ToString(),
                        Detalle = reader["detalle"].ToString()
                    };
                }
                return Ticket;
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

        public List<Ticket> SeleccionarTodos()
        {
            List<Ticket> Tickets = new List<Ticket>();
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();

                string sql = "SP_ticket_SelectAll";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Ticket Ticket = new Ticket()
                    {
                        IdTicket = Convert.ToInt32(reader["idTicket"]),
                        NombrePelicula = reader["nombrePelicula"].ToString(),
                        Detalle = reader["detalle"].ToString()
                    };
                    Tickets.Add(Ticket);
                }
                return Tickets;
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

        public void Eliminar(int IdTicket)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();

                string sql = "SP_ticket_DeleteRow";

                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idTicket", IdTicket);
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
