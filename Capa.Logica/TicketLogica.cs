using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class TicketLogica
    {
        public void Insertar(Ticket Ticket)
        {
            if (string.IsNullOrEmpty(Ticket.NombrePelicula))
            {
                throw new ApplicationException("El Nombre es requerido");
            }

            TicketDatos datos = new TicketDatos();

            if (datos.SeleccionarTicketPorId(Ticket.IdTicket) == null)
            {
                datos.Insertar(Ticket);
            }
            else
            {
                datos.Actualizar(Ticket);
            }
        }

        public Ticket SeleccionarPorID(int IdTicket)
        {
            TicketDatos datos = new TicketDatos();
            return datos.SeleccionarTicketPorId(IdTicket);
        }

        public List<Ticket> SeleccionarTodos()
        {
            TicketDatos datos = new TicketDatos();
            return datos.SeleccionarTodos();
        }

        public void Eliminar(int IdTicket)
        {
            TicketDatos datos = new TicketDatos();
            datos.Eliminar(IdTicket);
        }
    }
}
