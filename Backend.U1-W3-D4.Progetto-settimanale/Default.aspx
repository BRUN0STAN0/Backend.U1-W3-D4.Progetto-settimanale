<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Backend.U1_W3_D4.Progetto_settimanale.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center text-white">
        <div class="row justify-content-center">
            <asp:Repeater ID="Repeater1" ItemType="Backend.U1_W3_D4.Progetto_settimanale.Articolo" runat="server">
                <ItemTemplate>
                    <div class="card mx-2 my-2 bg-dark text-white border border-white" style="width: 200px">
                        <img src="<%# Item.URLImage %>" class="card-img-top" class="img-fluid" alt="<%# Item.Nome %>">
                        <div class="card-body">
                            <h5 class="card-title"><%# Item.Nome %></h5>
                            <asp:Label ID="Label1" Visible="<%# Item.InOfferta %>" runat="server" Font-Bold="true" ForeColor="Green" Text="IN OFFERTA">
                            <p class="card-text"> <%# Item.Prezzo.ToString("c2") %> </p></asp:Label>
                            <asp:Label Visible="<%# !Item.InOfferta %>" runat="server"><p class="card-text"> <%# Item.Prezzo.ToString("c2") %> </p></asp:Label>
                            <a href="Dettagli.aspx?IDChair=<%# Item.ID %>" class="btn btn-sm btn-secondary">Dettagli</a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
