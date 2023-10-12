<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="general.aspx.vb" Inherits="webadmintools.general" MasterPageFile="~/principal.Master"  %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Menú General</h1>
    <table style ="width :100%">
        <tr>
            <td>
                <center>
               <table style ="width :95%; text-align :left ;" cellspacing="0" cellpadding="0">
                   <tr>
                       <td>
                            <dx:ASPxButton ID="regresarASPxButton1" runat="server" Text="REGRESAR" Width ="10%" Theme="SoftOrange" Height ="40px" CssClass ="botonincialmenu ">
                                <Image IconID="navigation_backward_16x16">
                                </Image>
                            </dx:ASPxButton>
                       </td>
                   </tr>
                   <tr>
                       <td style ="border-top-left-radius:10px; border-top-right-radius : 10px;">
                           <br />
                           <dx:ASPxButton ID="cambiofechaASPxButton1" runat="server" Text="CAMBIO DE FECHA" Width ="100%" Theme="SoftOrange" Height ="40px" CssClass ="botonincialmenu "></dx:ASPxButton>
                       </td>
                   </tr>
                  
                   <tr>
                       <td>
                           <dx:ASPxButton ID="ASPxButton3" runat="server" Text="CERRAR SESIÓN" Width ="100%" Theme="SoftOrange" Height ="40px" CssClass ="botonfinalmenu "></dx:ASPxButton>
                       </td>
                   </tr>
                   <tr>
                       <td>
                           <asp:Label runat ="server" ID="lbnotificacion" ></asp:Label>
                       </td>
                   </tr>
               </table> 
            </td>
        </tr>
      </table>
</asp:Content>