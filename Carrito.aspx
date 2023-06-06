<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForms_TP3_Equipo27.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        .table {
            color: white;
        }

        .text-align-right {
            text-align: right;
        }
    </style>

 <div class="container">
    <div class="row">
        <div class="col">
            <table class="table">
                <tr>
                    <td>Nombre:</td>
                    <td>Marca:</td>
                    <td>Precio:</td>
                    <td>Acción:</td>
                </tr>

                <% foreach (var articulo in listaCarrito) { %>
                <tr>
                    <td><%= articulo.Nombre %></td>
                    <td><%= articulo.Marca %></td>
                    <td>$<%= articulo.Precio %></td>
                    <td><a href="Calcs.aspx?idQuitar=<%= articulo.ID.ToString() %>" class="btn btn-danger">Eliminar</a></td>
                </tr>
                <% } %>

                <tr>
                    <td colspan="4">
                        <div class="text-end">
                            Total a pagar: $<asp:Label ID="lblTotal" runat="server" />
                        </div>
                    </td>
                </tr>

                <tr>
                    <td colspan="4">
                        <div class="text-end">
                            Cantidad de artículos: <asp:Label ID="lblCantidad" runat="server" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</div>


    <div>
        <td><a href="Default.aspx" class="btn btn-secondary btn active" role="button" style="margin-left: 3rem; margin-top: 3rem">Continuar comprando</a></td>
    </div>
    <br />

</asp:Content>
