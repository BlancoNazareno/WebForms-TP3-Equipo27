<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebForms_TP3_Equipo27.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="align-content: center; width: 22rem" class="card border-light mb-3"">
        <img style="max-width: 300px; max-height: 300px; object-fit: contain" src="<% = articuloDetalle.ImagenUrl %>" class="card-img-top" alt="Imagen no disponible">
        <div class="card-body">
            <h2 style="color: black; font-style: italic" class="display-4"><%=articuloDetalle.Nombre %></h2>
            <p style="color: black; font-style: italic" class="lead">Precio: $<% = articuloDetalle.Precio %></p>
            <p style="color: black; font-style: italic" class="lead">Marca: <% = articuloDetalle.Marca %></p>
            <p style="color: black; font-style: italic" class="lead">Categoría: <% = articuloDetalle.Categoria %></p>
            <p><a href="Carrito.aspx?idArticulo=<%=articuloDetalle.ID%>" class="btn btn-primary btn-lg active" role="button" aria-pressed="true">Añadir al carrito</a></p>
            <p><a href="Default.aspx" class="btn btn-secondary btn-lg active" role="button">Volver al catálogo</a></p>
        </div>
    </div>
</asp:Content>
