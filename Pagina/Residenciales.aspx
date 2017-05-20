<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Residenciales.aspx.cs" Inherits="Servicio.Residenciales" %>


<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    <div class="tabContainer">
        
        <button type="button" runat="server" class="btn btn-success" data-toggle="modal" data-target="#popupResidencial">Registrar</button>      

        <asp:GridView 
            ID="GridViewResidenciales" 
            DataKeyNames="ID" 
            AutoGenerateColumns="False"
            BackColor ="White" 
            CssClass="table"
            runat="server"  >

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
                        <button id="btnEdit" type="button" runat="server" class="btn btn-info" onserverclick="btnEdit_Click">Editar</button>    
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
                    <h4 class="modal-title">Registrar residencial</h4>
                </div>
                <div class="modal-body">
                    <asp:TextBox ID="txtAddIdResidencial" runat="server" placeholder="Número de cliente" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtAddNombreResidencial" runat="server" placeholder="Nombre" class="form-control"></asp:TextBox><br />
                    <asp:TextBox ID="txtAddDireccionResidencial" runat="server" placeholder="Dirección" class="form-control"></asp:TextBox><br />
                </div>
                <div class="modal-footer">
                    <asp:Button ID="Button1" runat="server" Text="Cancelar" CssClass="btn btn-default"/>
                    <asp:Button ID="Button2" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnAddResidencial_Click"/>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
