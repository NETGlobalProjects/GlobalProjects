<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/principal.Master" CodeBehind="recibirtraslado.aspx.vb" Inherits="webadmintools.recibirtraslado" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>RECIBIR TRASLADO</h2>
    <asp:UpdatePanel ID="UpdatePanel1" runat ="server"  UpdateMode="Always"  >
       <%-- <Triggers >
            <asp:AsyncPostBackTrigger ControlID ="ASPxButton1" />
        </Triggers>--%>
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

                    <td style ="text-align :left ; font-size : 14px; font :bold ;">
                        <br />
                        Empresa
                     </td>
                    </tr>
        <tr><td>
            <dx:ASPxComboBox ID="dealerASPxComboBox1" runat="server" ValueType="System.String" Width ="100%" Height ="35px" Theme="SoftOrange" AutoPostBack ="true"  ></dx:ASPxComboBox>
            </td>
        </tr>

                    <tr>

                    <td style ="text-align :left ; font-size : 14px; font :bold ;">
                       
                        Sucursal
                     </td>
                    </tr>
        <tr><td>
            <dx:ASPxComboBox ID="sucursalASPxComboBox1" runat="server" ValueType="System.String" Width ="100%" Height ="35px" Theme="SoftOrange" ></dx:ASPxComboBox>
            </td>
        </tr>


                   
                    <tr>
                        <td style ="text-align :left ; font-size : 14px; font :bold ;">Traslado No.</td>

                    </tr>
                   <tr>
                       <td> <dx:ASPxTextBox ID="trasladoASPxTextBox1" runat="server" Width="100%" Height ="35px" Theme ="SoftOrange" AutoPostBack="True"></dx:ASPxTextBox></td>
                   </tr>
                   
                    
                    
                    <tr>
                        <td>
                            <br />
                            <dx:ASPxButton ID="mostrarASPxButton1" runat="server" Text="MOSTRAR" Width ="100%" Theme="SoftOrange" Height ="35px" Visible ="false"  ></dx:ASPxButton>
                        </td>
                    </tr>
                   <%-- <tr>
                        <td>
                            <table style ="width :100%;">
                                <tr>
                                    <td style ="text-align :left ">
                                        Desde
                                    </td>
                                     <td style ="text-align :left ">
                                        Hasta
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <dx:ASPxSpinEdit ID="desdeASPxSpinEdit1" runat="server" Number="0" Theme ="SoftOrange" Width ="100%" Height ="35px" />
                                    </td>
                                    <td>
                                        <dx:ASPxSpinEdit ID="hastaASPxSpinEdit2" runat="server" Number="0" Theme ="SoftOrange" Width ="100%" Height ="35px" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>--%>
                    
                    <tr>
                        <td>
                            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width ="100%" AutoGenerateColumns="False">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="TrasladoNo" HeaderText="Despacho No">
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" DataFormatString="{0:d}" />
                                    <asp:BoundField DataField="Total" HeaderText="Total">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Saldo" HeaderText="Saldo" >
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="NoFacturas" HeaderText="No Facturas" >
                                    <ItemStyle Width="80px" HorizontalAlign="Center" />
                                    </asp:BoundField>
                                </Columns>
                                <FooterStyle BackColor="#CCCC99" />
                                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" Font-Size="Small" />
                                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                <RowStyle BackColor="#F7F7DE" Font-Size="Small" />
                                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                                <SortedAscendingHeaderStyle BackColor="#848384" />
                                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                                <SortedDescendingHeaderStyle BackColor="#575357" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td style ="text-align : right ;">
                           <table style ="width :100%">
                               <tr>
                                   <td style ="font-size :14px; font :bold ;">
                                       Hecho Por:
                                   </td>
                                   <td>
                                       <dx:ASPxLabel runat ="server" id="hechoporLabel" Text =""></dx:ASPxLabel>
                                   </td>
                                   <td style ="font-size :14px; font :bold ;">
                                       &nbsp;</td>
                                   <td>
                                       <dx:ASPxCheckBox ID="estatusASPxCheckBox1" runat="server" Theme ="SoftOrange" Text="CERRADO?" Width ="125px" AutoPostBack="True" ></dx:ASPxCheckBox>
                                   </td>
                                   <tr>
                                   <td style ="text-align :left ;" colspan ="4">
                                       <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Motivo de anulación" Width ="150px"></dx:ASPxLabel>
                                   </td>
                                       </tr><tr>
                                   <td style ="width :100%" colspan ="4">
                                       <dx:ASPxTextBox ID="motivoASPxTextBox1" runat="server" Width="100%" Height ="35px" Theme ="SoftOrange"></dx:ASPxTextBox>
                                   </td>
                                       </tr>
                               </tr>
                           </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                            <asp:Button ID="guardarButton1" runat="server" Text="ANULAR DESPACHO" CssClass="boton" Height ="40" OnClientClick="return confirm('¿CONFIRMA QUE DESEA EJECUTAR EL PROCESO?')" Width="100%"/>
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
