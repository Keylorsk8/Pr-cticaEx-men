using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class CompraCineLogica
    {
        public void Insertar(CompraCine CompraCine)
        {
            if (string.IsNullOrEmpty(CompraCine.IdTicket.ToString()))
            {
                throw new ApplicationException("ElTicket es requerido");
            }

            CompraCineDatos datos = new CompraCineDatos();

            if (datos.SeleccionarCompraCinePorId(CompraCine.IdCompra) == null)
            {
                datos.Insertar(CompraCine);
            }
            else
            {
                datos.Actualizar(CompraCine);
            }
        }

        public CompraCine SeleccionarPorID(int IdCompraCine)
        {
            CompraCineDatos datos = new CompraCineDatos();
            return datos.SeleccionarCompraCinePorId(IdCompraCine);
        }

        public List<CompraCine> SeleccionarTodos()
        {
            CompraCineDatos datos = new CompraCineDatos();
            return datos.SeleccionarTodos();
        }

        public void Eliminar(int IdCompraCine)
        {
            CompraCineDatos datos = new CompraCineDatos();
            datos.Eliminar(IdCompraCine);
        }
    }
}
