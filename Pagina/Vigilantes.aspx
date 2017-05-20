<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Vigilantes.aspx.cs" Inherits="Servicio.Vigilantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    <div class="tabContainer">

        <asp:Button ID="btnAddVigilante" runat="server" Text="Agregar nuevo vigilante" CssClass="btn btn-success" />

        <%--DATAGRID DONDE SE ENCUENTRA LA TABLA DEL RESIDENCIAL--%>
        <asp:GridView 
            ID="GridViewVigilantes" 
            runat="server" 
            AutoGenerateColumns="False" 
            RowStyle-BackColor="Red"
            RowStyle-BorderColor="Red"
            GridLines="None"
            CssClass="table" 
            DataSourceID="LinqDataSourceVigilantes" 
            OnRowDataBound="GridViewVigilantes_RowDataBound"
            >
            
            <emptydatatemplate>
                No hay residenciales que mostrar  
            </emptydatatemplate>           

            <Columns>

                <%--CAMPOS NO EDITABLES--%>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID">
                </asp:BoundField>

                <%--CAMPOS SI EDITABLES--%>
                <asp:TemplateField  HeaderText="Nombre">
                    <ItemTemplate>
                        <asp:Label id="labNombreVigilante" runat="server"><%# Eval("NOMBRE")%></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNombreVigilante" runat="server" Text='<%# Bind("NOMBRE")%>' CssClass="form-control" ></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField  HeaderText="Telefóno">
                    <ItemTemplate>
                        <asp:Label id="labTelefonoVigilante" runat="server"><%# Eval("TELEFONO")%></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtTelefonosnVigilante" runat="server" Text='<%# Bind("TELEFONO")%>' CssClass="form-control" ></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField  HeaderText="E.Civil">
                    <ItemTemplate>
                        <asp:Label id="labCivilVigilante" runat="server"><%# Eval("CIVIL")%></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCivilVigilante" runat="server" Text='<%# Bind("CIVIL")%>' CssClass="form-control" ></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField  HeaderText="Estado">
                    <ItemTemplate>
                        <asp:Label id="labEstadoVigilante" runat="server"><%# Eval("ESTADO")%></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEstadoVigilante" runat="server" Text='<%# Bind("ESTADO")%>' CssClass="form-control" ></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField  HeaderText="Grupo">
                    <ItemTemplate>
                        <asp:Label id="labGrupoVigilante" runat="server"><%# Eval("GRUPO")%></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtGrupoVigilante" runat="server" Text='<%# Bind("GRUPO")%>' CssClass="form-control" ></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField  HeaderText="Residencial">
                    <ItemTemplate>
                        <asp:Label id="labResidencial" runat="server"><%# Eval("RESIDENCIAL")%></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtResidencialVigilante" runat="server" Text='<%# Bind("RESIDENCIAL")%>' CssClass="form-control" ></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <%--BOTONES DE ACCION DENTRO DE LA TABLA--%>

                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">

                    <%--BOTONES DE AGREGAR Y DE QUITAR--%>
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" />
                        <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" />
                    </ItemTemplate>

                    <%--BOTON DE AGREGAR Y CANCELAR--%>
                    <edititemtemplate>       
                        <asp:Button ID="btnUpdate" runat="server" Text="Grabar" CssClass="btn btn-success" CommandName="Update" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="btn btn-default" CommandName="Cancel" />
                    </edititemtemplate>

                </asp:TemplateField>

            </Columns>
       
            <RowStyle BackColor="White" BorderColor="White"></RowStyle>
       
        </asp:GridView>

        <asp:LinqDataSource 
            ID="LinqDataSourceVigilantes" 
            runat="server" 
            ContextTypeName="Servicio.LinqDataContext" 
            EntityTypeName="" 
            Select="new (ID, NOMBRE, TELEFONO, CIVIL, ESTADO, GRUPO, RESIDENCIAL)" 
            TableName="VIGILANTE">
        </asp:LinqDataSource>


    </div>


    

</asp:Content>
