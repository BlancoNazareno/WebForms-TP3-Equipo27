using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_TP3_Equipo27
{
    public partial class Detalle : System.Web.UI.Page
    {
        public Articulo articuloDetalle { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaAux;

            if (Request.QueryString["idArticulo"] != null)
                try
                {
                    listaAux = negocio.listar();
                    int idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
                    articuloDetalle = listaAux.Find(i => i.ID == idAux);
                }
                catch (Exception ex)
                {
                    Session.Add("errorEncontrado", ex.ToString());
                    Response.Redirect("Error.aspx");
                }
            else Response.Redirect("Default.aspx");
        }
    }
}