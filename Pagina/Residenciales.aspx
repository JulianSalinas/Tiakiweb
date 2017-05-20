<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Residenciales.aspx.cs" Inherits="Servicio.Residenciales" %>


<asp:Content ID="ContentResidenciales" ContentPlaceHolderID="mainContent" runat="server">

    <div class="tabContainer">
        
        <button id="btnReg" type="button" runat="server" class="btn btn-success" onserverclick="btnReg_ServerClick">Registrar</button>      

        <asp:GridView runat="server" ID="GridViewResidenciales" DataKeyNames="ID" AutoGenerateColumns="False" BackColor ="White" CssClass="table" >

            <emptydatatemplate>
                No hay residenciales que mostrar  
            </emptydatatemplate>           

            <Columns>

                <asp:BoundField DataField="ID" HeaderText="#Residencial" ReadOnly="True" SortExpression="ID"></asp:BoundField>
                <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" ReadOnly="True"></asp:BoundField>
                <asp:BoundField DataField="DIRECCION" HeaderText="Dirección" ReadOnly="True"></asp:BoundField>

                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">
                    <ItemTemplate>

                        <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" OnClick="btnDelete_Click"/>
                        <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEdit_Click"/>

                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            
        </asp:GridView>

    </div>

    <div id="popupResidencial" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">

                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Residencial</h4>
                </div>

                <div class="modal-body">
                    <asp:TextBox ID="txtIdResidencial" runat="server" placeholder="Número de cliente" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtNombreResidencial" runat="server" placeholder="Nombre" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtDireccionResidencial" runat="server" placeholder="Dirección" class="form-control"></asp:TextBox><br />
                </div>

                <div class="modal-footer">
                    <asp:Button runat="server" Text="Cancelar" CssClass="btn btn-default"/>
                    <asp:Button runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnResidencial_Click"/>
                </div>

            </div>
        </div>
    </div>

</asp:Content>
