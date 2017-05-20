<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Vigilantes.aspx.cs" Inherits="Servicio.Vigilantes" %>

<asp:Content ID="ContentVigilantes" ContentPlaceHolderID="mainContent" runat="server">

    <div class="tabContainer">
        
        <button id="btnReg" type="button" runat="server" class="btn btn-success" onserverclick="btnReg_ServerClick">Registrar</button>      

        <asp:GridView runat="server" ID="GridViewVigilantes" DataKeyNames="ID" AutoGenerateColumns="False" BackColor ="White" CssClass="table" >

            <emptydatatemplate>
                No hay residenciales que mostrar  
            </emptydatatemplate>           

            <Columns>

                <asp:BoundField DataField="ID" HeaderText="Identificación" ReadOnly="True" SortExpression="ID"></asp:BoundField>
                <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" ReadOnly="True"></asp:BoundField>
                <asp:BoundField DataField="RESIDENCIAL1.NOMBRE" HeaderText="Residencial" ReadOnly="True"></asp:BoundField>
                <asp:BoundField DataField="GRUPO" HeaderText="Grupo" ReadOnly="True"></asp:BoundField>
                <asp:BoundField DataField="PRECIOHORA" HeaderText="Grupo" ReadOnly="True"></asp:BoundField>

                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">
                    <ItemTemplate>

                        <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" OnClick="btnDelete_Click"/>
                        <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEdit_Click"/>

                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            
        </asp:GridView>

    </div>

    <div id="popupVigilante" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">

                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Vigilante</h4>
                </div>

                <div class="modal-body">
                    <asp:TextBox ID="txtIdVigilante" runat="server" placeholder="Identificación" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtNombreVigilante" runat="server" placeholder="Nombre" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtTelefonoVigilante" runat="server" placeholder="Teléfono" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtCivil" runat="server" placeholder="Estado civil" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtEstado" runat="server" placeholder="Estado de actividad" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtGrupo" runat="server" placeholder="Grupo de horario" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtResidencial" runat="server" placeholder="Residencial de trabajo" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtPrecioHora" runat="server" placeholder="Precio por hora trabajada" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtExtraHora" runat="server" placeholder="Precio por hora extra trabajada" class="form-control"></asp:TextBox><br />
                </div>

                <div class="modal-footer">
                    <asp:Button runat="server" Text="Cancelar" CssClass="btn btn-default"/>
                    <asp:Button runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnVigilante_Click"/>
                </div>

            </div>
        </div>
    </div>

</asp:Content>
