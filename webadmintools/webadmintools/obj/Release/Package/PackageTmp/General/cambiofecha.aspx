<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="cambiofecha.aspx.vb" Inherits="webadmintools.CambioFecha" MasterPageFile ="~/principal.Master"  %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cambio de Fecha</h1>
    <asp:UpdatePanel runat ="server" >
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
                        <td>
                             <dx:ASPxCheckBox ID="mostrarpornombreASPxCheckBox1" runat="server" Text="MOSTRAR POR NOMBRE" Theme="Moderno" AutoPostBack="True" CheckState="Unchecked">
                            </dx:ASPxCheckBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             <dx:ASPxCheckBox ID="MODOASPxCheckBox1" runat="server" Text="MODO ADMINISTRADOR" Theme="Moderno" AutoPostBack="True" CheckState="Unchecked">
                            </dx:ASPxCheckBox>
                        </td>
                    </tr>
                     <tr>
                        <td>
                             <dx:ASPxCheckBox ID="todasempresasASPxCheckBox1" runat="server" Text="TODAS LAS EMPRESAS" Theme="Moderno" AutoPostBack="True" CheckState="Unchecked">
                            </dx:ASPxCheckBox>
                        </td>
                    </tr>

                    <tr>

                    <td style ="text-align :left ;">
                        <br />
                        EMPRESA
                     </td>
                    </tr>
        <tr><td>
            <dx:ASPxComboBox ID="dealerASPxComboBox1" runat="server" ValueType="System.String" Width ="100%" Height ="35px" Theme="Moderno" AutoPostBack="True"></dx:ASPxComboBox>
            </td>
        </tr>
                    <tr>
                        <td style ="text-align :left ;">USUARIO</td>

                    </tr>
                   <tr>
                       <td> <dx:ASPxComboBox ID="usuariosASPxComboBox1" runat="server" ValueType="System.String" Width ="100%" Height ="35px" Theme="Moderno" AutoPostBack="True"></dx:ASPxComboBox></td>
                   </tr>
                   
                    <tr>
                        <td style ="text-align :left ;">FECHA</td>

                    </tr>
                   <tr>
                       <td><dx:ASPxDateEdit ID="fechaASPxDateEdit1" runat="server" Width ="100%" Theme="Moderno" Height ="35px"></dx:ASPxDateEdit></td>
                   </tr>
                    <tr>
                        <td>
                            <br />
                            <dx:ASPxButton ID="cambiarASPxButton1" runat="server" Text="CAMBIAR" Width ="100%" Theme="Moderno" Height ="35px" ></dx:ASPxButton>
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
