Imports System.IO
Public Class FrmDataLoad_Conversion
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        TextBox1.Text = OpenFileDialog1.FileName
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True


        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            TextBox1.Text = filePath
            Dim dt As New DataTable()
            Using sr As New StreamReader(filePath)
                Dim headers = sr.ReadLine().Split(","c)
                For Each header In headers
                    dt.Columns.Add(header)
                Next
                While Not sr.EndOfStream
                    Dim rows = sr.ReadLine().Split(","c)
                    dt.Rows.Add(rows)
                End While
            End Using
            ' Bind the DataTable to a DataGridView control '
            DGV1.DataSource = dt
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBackup.Click

        Dim OpenFileDialog2 As New OpenFileDialog()
        OpenFileDialog2.Filter = "Batch Files (*.bat)|*.bat|All Files (*.*)|*.*"
        OpenFileDialog2.FilterIndex = 1
        OpenFileDialog2.RestoreDirectory = True

        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*"
            saveFileDialog1.FilterIndex = 1
            saveFileDialog1.RestoreDirectory = True

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim process As New Process()
                process.StartInfo.FileName = OpenFileDialog2.FileName
                process.StartInfo.Arguments = saveFileDialog1.FileName
                process.StartInfo.CreateNoWindow = True
                process.Start()
                process.WaitForExit()

                If process.ExitCode = 0 Then
                    MessageBox.Show("Backup created successfully.")
                Else
                    MessageBox.Show("Error creating backup.")
                End If
            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Hide()
        Main.Show()
    End Sub
End Class