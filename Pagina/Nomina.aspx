<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Nomina.aspx.cs" Inherits="Servicio.Nomina" %>

<asp:Content ID="ContentNominaa" ContentPlaceHolderID="mainContent" runat="server">

    <div class="tabContainer">
        
        <button id="btnReset" type="button" runat="server" class="btn btn-success" onserverclick="btnReset_ServerClick">Reiniciar estadísticas</button>      

        

        <asp:GridView ID="GridViewNomina" runat="server" AutoGenerateColumns="False" BackColor="White" CssClass="table" DataKeyNames="ID" DataSourceID="SqlDataSourceNomina">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="Identificación" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" SortExpression="NOMBRE" />
                <asp:BoundField DataField="PRECIOHORA" HeaderText="P.Hora" SortExpression="PRECIOHORA" />
                <asp:BoundField DataField="EXTRAHORA" HeaderText="P.Extra" SortExpression="EXTRAHORA" />
                <asp:BoundField DataField="HORASTRABAJADAS" HeaderText="Horas.T" SortExpression="HORASTRABAJADAS" />
                <asp:BoundField DataField="EXTRASTRABAJADAS" HeaderText="Extras.T" SortExpression="EXTRASTRABAJADAS" />
                <asp:BoundField DataField="COBRO" HeaderText="Monto a cancelar" ReadOnly="True" SortExpression="COBRO" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceNomina" runat="server" ConnectionString="<%$ ConnectionStrings:tiakidatabaseConnectionString %>" SelectCommand="SELECT ID, NOMBRE, PRECIOHORA, EXTRAHORA, HORASTRABAJADAS, EXTRASTRABAJADAS, PRECIOHORA * HORASTRABAJADAS + EXTRAHORA * EXTRASTRABAJADAS AS COBRO FROM VIGILANTE"></asp:SqlDataSource>

    </div>

</asp:Content>
