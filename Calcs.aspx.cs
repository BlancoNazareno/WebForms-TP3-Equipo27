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
    public partial class Calcs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Articulo> listaCarrito = (List<Articulo>)Session[Session.SessionID + "listaCarrito"];
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaAux;
            try
            {
                listaAux = negocio.listar();

                if (Request.QueryString["idQuitar"] != null)
                {
                    int idQuitar = Convert.ToInt32(Request.QueryString["idQuitar"]);
                    listaCarrito = (List<Articulo>)Session["listaCarrito"];
                    listaCarrito.Remove(listaCarrito.Find(i => i.ID == idQuitar));
                    Session["listaCarrito"] = listaCarrito;
                    Response.Redirect("Carrito.aspx");
                }

                listaCarrito = (List<Articulo>)Session["listaCarrito"];


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}