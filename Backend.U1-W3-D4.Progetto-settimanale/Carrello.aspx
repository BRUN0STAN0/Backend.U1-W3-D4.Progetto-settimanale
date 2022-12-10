<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Backend.U1_W3_D4.Progetto_settimanale.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridCarrello" CssClass="table table-light" AutoGenerateColumns="false" runat="server" ItemType="Backend.U1_W3_D4.Progetto_settimanale.Articolo.CarrelloUtente">
        <Columns>
            <asp:BoundField DataField="Nome" HeaderText="Nome della sedia" />
            <asp:BoundField DataField="Descrizione" HeaderText="Descrizione" />
            <asp:BoundField DataField="Categoria" HeaderText="Tipologia" />
            <asp:BoundField DataField="Prezzo" HeaderText="Da pagare" />
        </Columns>
    </asp:GridView>
</asp:Content>
