﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace Turnera_TPC_Equipo27
{
    public partial class Turnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "No es posible acceder sin estar logueado");
                Response.Redirect("Default.aspx");
            }

            if ((Session["usuario"] != null) &&
                (((Paciente)Session["usuario"]).TipoUsuario == TipoUsuario.SUBADMIN ||
                ((Paciente)Session["usuario"]).TipoUsuario == TipoUsuario.ADMIN))
            {
                //ya está logueado como ADMIN o SUBADMIN, por lo que redirige a su área correspondiente
                Response.Redirect("HomeAdmin.aspx");
            }



            if (!IsPostBack)
            {
                EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
                List<Especialidad> listaEspecialidades = especialidadNegocio.listar();
                ddlEspecialidades.DataSource = listaEspecialidades;
                ddlEspecialidades.DataTextField = "Nombre";
                ddlEspecialidades.DataValueField = "Id";
                ddlEspecialidades.DataBind();

                MedicoNegocio negocio = new MedicoNegocio();
                List<Medico> listaMedicos = negocio.listar();
                dgvMedicos.DataSource = listaMedicos;
                dgvMedicos.DataBind();

            }
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener la lista de médicos correspondientes a la especialidad seleccionada
            MedicoNegocio negocio = new MedicoNegocio();
            List<Medico> listaMedicos = negocio.listarMedicosPorEspecialidad(int.Parse(ddlEspecialidades.SelectedValue));
            dgvMedicos.DataSource = listaMedicos;
            dgvMedicos.DataBind();
        }

        protected void ddlEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






    }
}