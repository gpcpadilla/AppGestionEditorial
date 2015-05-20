<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AppGestionEditorial.Web.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
     <h1>App Gestion Editorial</h1>
        <p class="lead">Crear cliente, guardar </p>
        <p>
            <a class="btn btn-lg btn-success" href="create.aspx" role="button">boton1</a>
            <a class="btn btn-lg btn-success" href="list.aspx" role="button">boton2</a>
        </p>
      </div> 
</asp:Content>
