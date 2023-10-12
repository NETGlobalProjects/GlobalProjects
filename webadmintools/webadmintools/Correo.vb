Imports System.Net.Mail
Public Class Correo
    Public vParaCorreo As String
    Public vParaNombre As String
    Public vDeCorreo As String = "portal@globalalimentos.com.sv"
    Public vDeNombre As String = "Portal Web [no-reply]"
    Public vAsunto As String
    Public vCuerpo As String
    Public vCC As New DropDownList

    Public Property ParaCorreo() As String
        Get
            Return vParaCorreo
        End Get
        Set(value As String)
            vParaCorreo = value
        End Set
    End Property
    Public Property ParaNombre() As String
        Get
            Return vParaNombre
        End Get
        Set(value As String)
            vParaNombre = value
        End Set
    End Property
    Public Property DeCorreo() As String
        Get
            Return vDeCorreo
        End Get
        Set(value As String)
            vDeCorreo = value
        End Set
    End Property
    Public Property DeNombre() As String
        Get
            Return vDeNombre
        End Get
        Set(value As String)
            vDeNombre = value
        End Set
    End Property
    Public Property Asunto() As String
        Get
            Return vAsunto
        End Get
        Set(value As String)
            vAsunto = value
        End Set
    End Property
    Public Property Cuerpo() As String
        Get
            Return vCuerpo
        End Get
        Set(value As String)
            vCuerpo = value
        End Set
    End Property
    Public Property CC As DropDownList
        Get
            Return vCC
        End Get
        Set(value As DropDownList)
            vCC = value
        End Set
    End Property
    Public Function enviarcorreo() As String
        Dim msj As String
        'Try

        Dim fromAddress As New MailAddress(vDeCorreo, vDeNombre)
        Dim toAddress As New MailAddress(Me.vParaCorreo, vParaNombre)
        Dim message As New MailMessage(fromAddress, toAddress)

        Dim mailSender As SmtpClient = New SmtpClient("192.168.0.228")
        With mailSender
            '.Credentials = New Net.NetworkCredential("GestorPrecios", "GesPre15", "gumarsaldc")
            .UseDefaultCredentials = False
            .EnableSsl = False
        End With

        message.Bcc.Add(fromAddress)

        If vCC.Items.Count > 0 Then
            For i As Integer = 0 To vCC.Items.Count - 1
                message.CC.Add(vCC.Items(i).ToString)
            Next
        End If
        message.Subject = vAsunto
        message.IsBodyHtml = True
        message.Body = vCuerpo
        mailSender.Send(message)
        msj = "Exito"
        'If Not attachmentString = "" Then
        '    Dim msgAttach As New Attachment(attachmentString)
        '    message.Attachments.Add(msgAttach)
        'End If
        'Catch ex As Exception
        '    msj = ex.Message
        'End Try
        Return msj
    End Function

End Class
