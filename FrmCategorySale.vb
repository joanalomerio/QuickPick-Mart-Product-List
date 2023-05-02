Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            sql = "Select * FROM category_sale"
            cmd = New MySqlCommand(sql, conn)
            SDA.SelectCommand = cmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            customergrid.DataSource = bSource
            SDA.Update(dbdata)


            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Hide()
        Main.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ImportToExcel(Me.customergrid, "samplereport.xlsx")
    End Sub
End Class