Imports System.Text.RegularExpressions
Public Class Form4
    Dim path As String
    Public Sub cmdinvia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinvia.Click
        ToolStripStatusLabel2.Text = ""
        Try
            Dim Msg As New System.Net.Mail.MailMessage(txtmitt.Text, txtdest.Text, txtogg.Text, txtcorpo.Text)
            Dim Smtp As New System.Net.Mail.SmtpClient(txtsmtp.Text)
            If path <> "percorso" Then
                ToolStripStatusLabel2.Text = "Sto allegando"
                Msg.Attachments.Add(New Net.Mail.Attachment(path))
            End If
            Smtp.Send(Msg)
            ToolStripStatusLabel2.Text = "Mail inviata con successo"
            ProgressBar2.Value = 100
        Catch ex As Exception
            ToolStripStatusLabel2.Text = "X  Errore! Qualcosa è andato storto.  X"
            ProgressBar2.Value = 0
            txtmitt.BackColor = Color.Red
            txtdest.BackColor = Color.Red
        End Try
    End Sub
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        path = OpenFileDialog1.FileName
        Label6.Text = OpenFileDialog1.SafeFileName
        ProgressBar1.Value = 100
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        path = "percorso"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        path = "percorso"
        Label6.Text = "Percorso allegato..."
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FoundMatch As Boolean
        Try
            FoundMatch = Regex.IsMatch(txtmitt.Text, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)
        Catch ex As ArgumentException 'Syntax error in the regular expression
        End Try
        If Not FoundMatch Then
            txtmitt.BackColor = Color.Red
            txtmitt.Focus()
        Else
            txtmitt.BackColor = Color.Lime
            cmdinvia.Enabled = True
            ProgressBar2.Value = 15
        End If
    End Sub
    Private Sub txtmitt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmitt.TextChanged
        Dim FoundMatch As Boolean
        Try
            FoundMatch = Regex.IsMatch(txtmitt.Text, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)
        Catch ex As ArgumentException 'Syntax error in the regular expression
        End Try
        If Not FoundMatch Then
            txtmitt.BackColor = Color.Red
            txtmitt.Focus()
        Else
            txtmitt.BackColor = Color.Lime
            cmdinvia.Enabled = True
            ProgressBar2.Value = 15
        End If
    End Sub
End Class