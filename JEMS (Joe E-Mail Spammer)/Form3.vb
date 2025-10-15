Public Class Form3
    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Windows Live Hotmail" Then
            TextBox1.Text = "@hotmail.it   |   @hotmail.com   |   @live.it   |   @live.com"
            TextBox2.Text = "smtp.live.com"
            TextBox3.Text = "587"
        End If
        If ComboBox1.SelectedItem = "Libero Mail" Then
            TextBox1.Text = "@libero.it"
            TextBox2.Text = "smtp.libero.it"
            TextBox3.Text = "465"
        End If
        If ComboBox1.SelectedItem = "Yahoo Mail" Then
            TextBox1.Text = "@yahoo.it   |   @yahoo.com   |   @ymail.com   |   @rocketmail.com"
            TextBox2.Text = "smtp.mail.yahoo.it"
            TextBox3.Text = "587"
        End If
        If ComboBox1.SelectedItem = "Google Mail" Then
            TextBox1.Text = "@gmail.com"
            TextBox2.Text = "smtp.gmail.com"
            TextBox3.Text = "465"
        End If
        If ComboBox1.SelectedItem = "Teletu Mail" Then
            TextBox1.Text = "@teletu.it"
            TextBox2.Text = "smtp.teletu.it"
            TextBox3.Text = "587"
        End If
        If ComboBox1.SelectedItem = "Email.it" Then
            TextBox1.Text = "@email.it"
            TextBox2.Text = "smtp.email.it"
            TextBox3.Text = "587"
        End If
    End Sub
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(220, 182)
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TextBox2.Text = TextBox5.Text
        TextBox3.Text = TextBox4.Text
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.Size = New Size(442, 182)
        Else
            Me.Size = New Size(220, 182)
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class