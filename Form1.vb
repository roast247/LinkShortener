Public Class Form1
    Private draggable As Boolean
    Private mouseY As Integer
    Private mouseX As Integer
    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Close()
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingPic_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingPic_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingPic_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseUp
        draggable = False
    End Sub
    Private Function ShrinkURL(ByVal strURL As String) As String

        Dim URL As String
        URL = "http://tinyurl.com/api-create.php?url=" +
           strURL.ToLower

        Dim objWebRequest As Net.HttpWebRequest
        Dim objWebResponse As Net.HttpWebResponse

        Dim srReader As IO.StreamReader

        Dim strHTML As String

        objWebRequest = CType(Net.WebRequest.Create(URL),
           Net.HttpWebRequest)
        objWebRequest.Method = "GET"

        objWebResponse = CType(objWebRequest.GetResponse(),
           Net.HttpWebResponse)
        srReader = New IO.StreamReader(objWebResponse _
           .GetResponseStream)

        strHTML = srReader.ReadToEnd

        srReader.Close()
        objWebResponse.Close()
        objWebRequest.Abort()

        Return (strHTML)

    End Function

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If txtURL.Text = "" Then
            MsgBox("Please add a URL")
        Else
            Threading.Thread.Sleep(1000)
            txtOutput.Text = ShrinkURL(txtURL.Text)
            txtURL.Text = ""
        End If

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(txtOutput.Text)
    End Sub
End Class