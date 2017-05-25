<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Turno.aspx.cs" Inherits="Servicio.Turno" %>

<asp:Content ID="Turno" ContentPlaceHolderID="mainContent" runat="server">


    <div class="tabContainer">
        
        <asp:Button ID="btnSig" runat="server" Text="Turno siguiente" CssClass="btn btn-success" OnClick="btnTurnoSiguiente_ServerClick"/>
        <asp:Button ID="btnSimular" runat="server" Text="Simular cambio de turno" CssClass="btn btn-info" OnClick="btnSimular_Click"/>

        <asp:GridView runat="server" ID="GridViewTurno" DataKeyNames="ID" AutoGenerateColumns="False" BackColor ="White" CssClass="table"
            OnRowDataBound="GridViewTurno_RowDataBound" >

            <emptydatatemplate>
                No hay nada que mostrar  
            </emptydatatemplate>           

            <Columns>

                <asp:BoundField DataField="ID" HeaderText="Identificación" ReadOnly="True" SortExpression="ID"></asp:BoundField>
                <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" ReadOnly="True"></asp:BoundField>
                <asp:BoundField DataField="RESIDENCIAL1.NOMBRE" HeaderText="Residencial" ReadOnly="True"></asp:BoundField>
                <asp:BoundField DataField="ESTADO" HeaderText="Estado" ReadOnly="True"></asp:BoundField>

                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">
                    <ItemTemplate>
                        <asp:Button ID="btnRempl" runat="server" Text="Remplazar" CssClass="btn btn-info" OnClick="btnRempl_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            
        </asp:GridView>

    </div>

    <div id="popupTurno" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">

                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Remplazo</h4>
                </div>

                <asp:TextBox ID="txtVigilanteRemplazar" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>

                <div class="modal-body">
                    <asp:GridView ID="GridViewRemplazos" runat="server" DataKeyNames="ID" AutoGenerateColumns="False" BackColor ="White" CssClass="table">

                        <emptydatatemplate>
                            No hay nada que mostrar  
                        </emptydatatemplate>           

                        <Columns>

                            <asp:BoundField DataField="ID" HeaderText="Identificación" ReadOnly="True" SortExpression="ID"></asp:BoundField>
                            <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" ReadOnly="True"></asp:BoundField>
                            <asp:BoundField DataField="TELEFONO" HeaderText="Telf." ReadOnly="True"></asp:BoundField>

                            <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">
                                <ItemTemplate>
                                    <asp:Button ID="btnElegir" runat="server" Text="Elegir" CssClass="btn btn-info" OnClick="btnElegir_Click"/>
                                </ItemTemplate>
                            </asp:TemplateField>

                        </Columns>
                    </asp:GridView>
                </div>

                <div class="modal-footer">
                    <asp:Button runat="server" Text="Cancelar" CssClass="btn btn-default"/>
                </div>

            </div>
        </div>
    </div>


</asp:Content>
