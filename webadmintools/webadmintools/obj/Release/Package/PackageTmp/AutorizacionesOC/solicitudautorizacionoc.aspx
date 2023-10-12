<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="solicitudautorizacionoc.aspx.vb" Inherits="webadmintools.solicitudautorizacionoc"  MasterPageFile="~/principal.Master"%>

<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate >

       
   <%-- <div>--%>

     <div class ="div" >
         <div style ="background-color :green; color :white ; padding :15PX; " runat="server" id="APROBADA" visible ="false" >APROBADA</div>
   <div style ="background-color :RED; color :white ; padding :15PX; " runat="server" id="RECHAZADA" visible ="false" >RECHAZADA</div>
        <h3>Solicitud de autorización de OC.</h3> 
       
        <dx:ASPxLabel runat ="server" ID="lbMensaje" Theme ="Moderno" ></dx:ASPxLabel>
        <table cellpadding="0" cellspacing="8" style ="color :#808080; width:100%;" >
            <tr><td style ="width :120px;">Orden No.</td><td style ="width :20px;">:</td><td>
                 <dx:ASPxTextBox ID="OrdenNoASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox>
                                                                   </td></tr>
            <tr><td>Proveedor</td><td>:</td><td >
                <dx:ASPxTextBox ID="proveedorASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = "" ></dx:ASPxTextBox>
            </td></tr>
            <tr><td>Fecha OC.</td><td>:</td><td> <dx:ASPxTextBox ID="fechaocASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox></td></tr>
            <tr><td>Fecha Entrega</td><td>:</td><td> <dx:ASPxTextBox ID="fechaentregaASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox></td></tr>
            <tr><td>Tipo OC.</td><td>:</td><td> <dx:ASPxTextBox ID="tipoASPxTextBox2" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox></td></tr>
             <tr><td>Solicitado por</td><td>:</td><td> <dx:ASPxTextBox ID="solicitadoporASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox></td></tr>
            <tr><td>Motivo</td><td>:</td><td> <dx:ASPxTextBox ID="motivoASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox></td></tr>
            <tr><td>Total Orden</td><td>:</td><td> <dx:ASPxTextBox ID="totalordenASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox></td></tr>
            <tr><td>Forma Pago</td><td>:</td><td> <dx:ASPxTextBox ID="formapagoASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox></td></tr>
             <tr><td>Días Crédito</td><td>:</td><td> <dx:ASPxTextBox ID="diascreditoASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox></td></tr>
            <tr><td>Solicita Aut.</td><td>:</td><td> <dx:ASPxTextBox ID="usuarioNDASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox></td></tr>
             <tr><td>Nombre Sol. Aut.</td><td>:</td><td> <dx:ASPxTextBox ID="nombresolicitaASPxTextBox1" runat="server" Width="100%" Theme="MetropolisBlue" Text = ""></dx:ASPxTextBox></td></tr>
        </table>
      </div>
     


          <div class ="div" >
        <h3>Detalle de la Orden</h3>
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" EnableTheming="True" Theme="DevEx" Width="100%">
            <Columns>
                <dx:GridViewDataTextColumn Caption="Código" FieldName="Codigo" Name="Codigo" VisibleIndex="1" Width="80px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Descripción" FieldName="Descripcion" Name="Descripcion" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Cantidad" FieldName="Cantidad" Name="Cantidad" VisibleIndex="0" Width="50px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataSpinEditColumn Caption="Unitario ($)" FieldName="Unitario" Name="Unitario" VisibleIndex="3" Width="60px">
                    <PropertiesSpinEdit DecimalPlaces="2" DisplayFormatString="c" NumberFormat="Currency" Width ="80px">
                    </PropertiesSpinEdit>
                </dx:GridViewDataSpinEditColumn>
                <dx:GridViewDataSpinEditColumn Caption="Importe ($)" FieldName="Importe" Name="Importe" VisibleIndex="5" Width="70px">
                    <PropertiesSpinEdit DisplayFormatString="c" NumberFormat="Currency">
                    </PropertiesSpinEdit>
                </dx:GridViewDataSpinEditColumn>
            </Columns>
        </dx:ASPxGridView>
      </div> 

          <div class ="div" >
        <h3>Revisión</h3>
      <table style ="width :100%;" cellpadding="0" cellspacing="8">
          <tr>
              <td style ="width :120px; padding-left :10px;">
                  <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Comentario Autorizador" Width ="150px"></dx:ASPxLabel>
              </td>
              </TR>
          <tr>
             
              <td style ="width :100%;">
                  <dx:ASPxTextBox ID="comentarioASPxTextBox1" runat="server" Width="100%" Theme="Moderno"></dx:ASPxTextBox>
              </td>
          </tr>
          <tr>
              <td colspan =" 3" style ="text-align :right ;">
                  <table >
                      <tr>
                          <td>
                              <%--<dx:ASPxRadioButton ID="aprobadaASPxRadioButton1" runat="server" Theme ="Moderno" Text ="Aprobada" Checked ="true" ></dx:ASPxRadioButton>--%>
                              <dx:ASPxCheckBox ID="aprobadaASPxRadioButton1" runat="server" Theme="Moderno" Text ="Aprobada" AutoPostBack="True">
                              </dx:ASPxCheckBox>
                          </td>
                          <td>
                               <%--<dx:ASPxRadioButton ID="rechazadaASPxRadioButton2" runat="server" Theme ="Moderno" Text ="Rechazada"></dx:ASPxRadioButton>--%>
                              <dx:ASPxCheckBox ID="rechazadaASPxRadioButton2" runat="server" Text ="Rechazada" AutoPostBack="True" Theme="Moderno" ></dx:ASPxCheckBox>
                           </td>
                          <td>
                              <asp:Button ID="enviarrespuestaButton1" runat="server" Text="Enviar respuesta" CssClass ="boton" Height ="40"  OnClientClick="return confirm('¿CONFIRMA QUE DESEA ENVIAR LA RESPUESTA?')" />
                          </td>
                      </tr>

                  </table>

              </td>
          </tr>
      </table>
              </div> 
    <br />
  
    

      <%--  </div>--%>
             </ContentTemplate>
    </asp:UpdatePanel>
   </asp:Content>
      

