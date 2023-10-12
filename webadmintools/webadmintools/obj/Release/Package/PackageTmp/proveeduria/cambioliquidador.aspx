<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="cambioliquidador.aspx.vb" Inherits="webadmintools.cambioliquidador" MasterPageFile ="~/principal.Master" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>CAMBIAR DE LIQUIDADOR</h2>
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
                        <td style ="text-align :left ; font-size : 14px; font :bold ;">Usuario</td>

                    </tr>
                   <tr>
                       <td> <dx:ASPxComboBox ID="usuariosASPxComboBox1" runat="server" ValueType="System.String" Width ="100%" Height ="35px" Theme="SoftOrange" AutoPostBack="True"></dx:ASPxComboBox></td>
                   </tr>
                   <tr>
                       <td>
                           <table style ="width :100%">
                               <tr>
                                   <td style ="width :25%; text-align :left ;  font-size : 14px; font :bold ;">
                                       Liq. Actual:
                                   </td>
                                    <td  style ="width :25%; text-align :left ;  font-size : 14px; font :bold ;">
                                       Cambiar a:
                                   </td>
                                   </tr>
                               <tr>
                                   <td style ="width :25%;">
                                       <dx:ASPxTextBox ID="liquidadoractualASPxTextBox1" runat="server" Width="100%" Height ="35px" Theme ="SoftOrange"></dx:ASPxTextBox>
                                   </td>
                                  
                                   <td  style ="width :25%;">
                                       <dx:ASPxComboBox ID="liquidadoresASPxComboBox1" runat="server" ValueType="System.String" Width ="100%" Height ="35px" Theme="SoftOrange" AutoPostBack="True"></dx:ASPxComboBox>
                                   </td>


                               </tr>
                               <tr>
                                   <td>
                                       <dx:ASPxLabel ID="nombreliqactualASPxLabel1" runat="server" Text=""></dx:ASPxLabel>
                                   </td>
                                   <td>
                                       <dx:ASPxLabel ID="nombrenuevoliqASPxLabel1" runat="server" Text=""></dx:ASPxLabel>
                                   </td>
                               </tr>
                           </table>
                       </td>
                   </tr>
                    
                    
                   
                   
                    
                   
                   
                    <tr>
                        <td>
                            <br />
                            <dx:ASPxButton ID="guardarASPxButton1" runat="server" Text="GUARDAR CAMBIOS" Width ="100%" Theme="SoftOrange" Height ="35px" Visible="True" ></dx:ASPxButton>
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