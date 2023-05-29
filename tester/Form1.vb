Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TesterDataSet.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.TesterDataSet.login)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "Data Source=Z4P5-064; Initial Catalog = Tester; Trusted_Connection = True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        Dim query As String = "SELECT * FROM login WHERE username = @username AND password = @password"
        Dim command As New SqlCommand(query, connection)

        command.Parameters.AddWithValue("@username", TextBox1.Text)
        command.Parameters.AddWithValue("@password", TextBox2.Text)

        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                Dim username As String = reader("username").ToString
                Dim password As String = reader("password").ToString


            End While
            MsgBox("WElcome")
        Else
            MsgBox("Not WElcome")

        End If

    End Sub
End Class
