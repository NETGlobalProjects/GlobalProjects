<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="webadmintools.login" MasterPageFile="~/principal.Master" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table id="login" style ="width :100%">
        <tr>
            <td >
                <center>
                <table style ="width :90%; text-align :left ;">
                    <tr>
                        <td style ="font-size :20px;">
                Usuario
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="100%" Theme="Metropolis" Height ="30px" ></dx:ASPxTextBox>
            </td>
                    </tr>

                        <tr>
                        <td style ="font-size :20px;">
                                Contraseña
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dx:ASPxTextBox ID="ASPxTextBox2" runat="server" Width="100%" Theme="Metropolis" Height ="30px" Password="True"></dx:ASPxTextBox>
                            </td>
                    </tr>
                    <tr>
                           <td style ="width :100%;">
                               <br />
                                <dx:ASPxButton ID="ASPxButton1" runat="server" Text="INGRESAR" Theme="SoftOrange" Width ="100%" Height ="35px"></dx:ASPxButton>
                           </td>
                    </tr>
                    <tr>
                           <td style ="width :100%; text-align :center ;">
                               <br />
                               <asp:Label runat ="server" ID="lbinfo" ForeColor ="Red" ></asp:Label>
                           </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
