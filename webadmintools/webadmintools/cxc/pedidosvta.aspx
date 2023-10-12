<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pedidosvta.aspx.vb" Inherits="webadmintools.pedidosvta" MasterPageFile="~/principal.Master" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>APROBACIÓN DE PEDIDOS</h1>
    <asp:UpdatePanel ID="UpdatePanel1" runat ="server" >
        <ContentTemplate >

    
    <table style ="width :100%">
        
        <tr>
            <td style ="text-align :left;">
                <center>
                <table style ="width :95%">
                    <tr>
                       <td style ="text-align :left ;">
                            <dx:ASPxButton ID="regresarASPxButton1" runat="server" Text="REGRESAR" Width ="10%" Theme="SoftOrange" Height ="40px" CssClass ="botonincialmenu ">
                                <Image IconID="navigation_backward_16x16">
                                </Image>
                            </dx:ASPxButton>
                           
                       </td>
                   </tr>
                    <tr>

                    <td style ="text-align :left ;">
                        <br />
                        Empresa
                     </td>
                    </tr>
        <tr><td>
            <dx:ASPxComboBox ID="dealerASPxComboBox1" runat="server" ValueType="System.String" Width ="100%" Height ="35px" Theme="SoftOrange" AutoPostBack="True"></dx:ASPxComboBox>
            </td>
        </tr>
                    <tr>
                        <td style ="text-align :left ;">Pedido No</td>

                    </tr>
                   <tr>
                      <td><dx:ASPxTextBox ID="pedidonoASPxTextBox1" runat="server" Theme ="SoftOrange"  Width="100%"  Height ="35px"  AutoPostBack ="true"></dx:ASPxTextBox></td>
                   </tr>
                   <tr>
                       <td>Resultados: <dx:ASPxLabel ID="resultadosASPxLabel1" runat="server" Text="0"></dx:ASPxLabel></td>
                   </tr>
                    <tr>
                        <td>
                            <asp:DataList ID="DataList1" runat="server" Width ="100%" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                                <AlternatingItemStyle BackColor="White" />
                                <FooterStyle BackColor="#CCCC99" />
                                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                <ItemStyle BackColor="#F7F7DE" />
                                <ItemTemplate>
                                    <div class ="div">

                                    
                                    <table style ="text-align :left; font-size :smaller;" >
                                       
                                        <tr>
                                            <td>
                                                Sucursal:
                                            </td>
                                            <td colspan ="4">
                                                <dx:ASPxLabel ID="tdaCodigoASPxLabel1" runat="server" Text='<%# Eval("tda") %>'></dx:ASPxLabel>
                                                <dx:ASPxLabel ID="tdaNombreASPxLabel1" runat="server" Text='<%# Eval("Sucursal") %>'></dx:ASPxLabel>
                                            </td>
                                            <td rowspan ="4" style ="width :60px; vertical-align :central ;">
                                                <dx:ASPxCheckBox ID="aprobarASPxCheckBox1" runat="server" Theme ="Metropolis" Height="30px" CheckState="Unchecked" Text ="Aprobar?"  Checked="False"></dx:ASPxCheckBox>
                                            </td>
                                        </tr>
                                  
                                        <tr>
                                            <td style ="font: bold; width :90px;">
                                                Pedido No:
                                            </td>
                                            <td>
                                                 <dx:ASPxLabel ID="pedidonoASPxLabel2" runat="server" Text='<%# Eval("PedidoNo") %>'></dx:ASPxLabel>
                                            </td>
                                            <td style ="font: bold; width :90px; padding-left :10px;">
                                                Tipo Pedido:
                                            </td>
                                            <td>
                                                 <dx:ASPxLabel ID="tipopedidoASPxLabel1" runat="server" Text='<%# Eval("TipoPedido") %>'></dx:ASPxLabel>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td style ="font: bold">
                                                Cliente:
                                            </td>
                                            <td colspan ="4">
                                                 <dx:ASPxLabel ID="clienteASPxLabel1" runat="server" Text='<%# Eval("Cliente") %>'></dx:ASPxLabel>
                                            </td>
                                            
                                        </tr>
                                        <tr>
                                            <td style ="font: bold">
                                                Fecha:
                                            </td>
                                            <td >
                                                 <dx:ASPxLabel ID="fechaASPxLabel1" runat="server" Text='<%# Eval("Fecha")%>'></dx:ASPxLabel>
                                            </td>
                                            <td style ="font: bold; padding-left :10px;">
                                                Total : $
                                            </td>
                                            <td>
                                                 <dx:ASPxLabel ID="totalASPxLabel1" runat="server" Text='<%# Eval("Total") %>'></dx:ASPxLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                             <td style ="font: bold">
                                                Estatus Actual:
                                            </td>
                                             <td >
                                                 <dx:ASPxLabel ID="estatusactualASPxLabel1" runat="server" Text='<%# Eval("Estatus") %>'></dx:ASPxLabel>
                                            </td>
                                        </tr>
                                         
                                    </table>
                                        </div>
                                    <br />
                                </ItemTemplate>
                                <SelectedItemStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                            </asp:DataList>
                        </td>
                    </tr>
                   <tr>
                        <td>
                            <br />
                            <dx:ASPxButton ID="cambiarASPxButton1" runat="server" Text="APLICAR CAMBIOS" Width ="100%" Theme="SoftOrange" Height ="35px" >
                                <ClientSideEvents Click="function(s, e) {
	e.processOnServer = confirm('Desea aplicar los cambios?');
}" />
                            </dx:ASPxButton>
                        </td>
                    </tr>
        <tr>
            <td>
                <br />
                <dx:ASPxLabel ID="lbnotificaciones" runat="server" Text="" ></dx:ASPxLabel>
            </td>
        </tr>
                </table>
            </td>
 </tr>
            
    </table>
                </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
