<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="menu.aspx.vb" Inherits="webadmintools.menu" MasterPageFile="~/principal.Master" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
     <table style ="width :100%">
        <tr>
            <td>
                <center>
               <table style ="width :95%; text-align :left ;" cellspacing="0" cellpadding="0">
                   <tr>
                       <td style ="border-top-left-radius:10px; border-top-right-radius : 10px;">
                           <dx:ASPxButton ID="generalASPxButton1" runat="server" Text="GENERAL" Width ="100%" Theme="SoftOrange" Height ="40px" CssClass ="botonincialmenu "></dx:ASPxButton>
                       </td>
                   </tr>
                   <tr>
                       <td >
                           <dx:ASPxButton ID="logisticaASPxButton1" runat="server" Text="LOGISTICA" Width ="100%" Theme="SoftOrange" Height ="40px" ></dx:ASPxButton>
                       </td>
                   </tr>
                    <tr>
                       <td >
                           <dx:ASPxButton ID="cuentasporcobrarASPxButton1" runat="server" Text="CREDITOS Y COBROS" Width ="100%" Theme="SoftOrange" Height ="40px" ></dx:ASPxButton>
                       </td>
                   </tr>
                   <tr>
                       <td>
                           <dx:ASPxButton ID="facturacionASPxButton2" runat="server" Text="FACTURACIÓN" Width ="100%" Theme="SoftOrange" Height ="40px"></dx:ASPxButton>
                       </td>
                   </tr>
                   <tr>
                       <td>
                           <dx:ASPxButton ID="proveeduriaASPxButton1" runat="server" Text="PROVEEDURIA" Width ="100%" Theme="SoftOrange" Height ="40px"></dx:ASPxButton>
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
