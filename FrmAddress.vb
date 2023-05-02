Imports MySql.Data.MySqlClient
Public Class Address
    Private Sub Address_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost; user id=root;port=3306;password=joana0741;database=product_sales_db"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()

        cmd.Connection = conn

        With cmd
            .CommandText = "INSERT INTO address values (@add_num, @add_name);"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@add_num", add_numtxt.Text)
            .Parameters.AddWithValue("@add_name", add_nametxt.Text)

        End With
        cmd.ExecuteNonQuery()
        MsgBox("Data has been insert Successfully!")
        conn.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        conn.Open()

        cmd.Connection = conn

        With cmd

            .CommandText = "UPDATE address SET add_name = @add_name where add_num = @add_num"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@add_num", add_numtxt.Text)
            .Parameters.AddWithValue("@add_name", add_nametxt.Text)

        End With

        cmd.ExecuteNonQuery()

        MsgBox("Data has been Update Successfully!")

        conn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            conn.Open()
            sql = "Select * FROM address"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        conn.Open()
        cmd.Connection = conn

        With cmd

            .CommandText = "DELETE FROM address where add_num = @add_num"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@add_num", add_numtxt.Text)
            .Parameters.AddWithValue("@add_name", add_nametxt.Text)

        End With

        cmd.ExecuteNonQuery()
        MsgBox("Data Delete Successfully!")
        conn.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ImportToExcel(Me.customergrid, "samplereport.xlsx")
    End Sub
End Class