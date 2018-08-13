using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa.UI
{
    public partial class CompraCine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LLenarCombo();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void LLenarCombo()
        {
            TicketDatos TicketDatos = new TicketDatos();
            List<Ticket> Tickets = TicketDatos.SeleccionarTodos();
            ddlPeliculas.DataSource = Tickets;
            ddlPeliculas.DataTextField = "NombrePelicula";
            ddlPeliculas.DataValueField = "IdTicket";
            ddlPeliculas.DataBind();
        }
    }
}