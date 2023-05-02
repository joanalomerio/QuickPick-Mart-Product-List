Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports Excel = Microsoft.Office.Interop.Excel
Module Module1

    Public conn As New MySqlConnection
    Public dataset As New DataSet
    Public cmd As New MySqlCommand
    Public reader As MySqlDataReader
    Public sql As String

    Public currentDate As DateTime = DateTime.Now
    Public strpassword = "joana"
    Public xlsPath As String = System.IO.Directory.GetCurrentDirectory & "\dataXls\TEMPLATE\"
    Public xlsFiles As String = System.IO.Directory.GetCurrentDirectory & "\dataXls\TEMPLATE\"

    Public Sub Connect()

        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        conn.Open()
        reader = cmd.ExecuteReader

    End Sub

    Public Sub ConnectToDB()
        conn.ConnectionString = "server=localhost; user id=root;port=3306;password=joana0741;database=product_sales_db"

        Try
            conn.Open()
            'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
            'myconn.Close()

        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password")
            End Select

        End Try

    End Sub
    Public Sub DisconnectToDB()
        conn.Close()
        conn.Dispose()
    End Sub
    Public Sub ImportToExcel(ByVal mydg As DataGridView, ByVal templatefilename As String)
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application With {
            .Visible = False
        }
        xlsWB = xlsApp.Workbooks.Open(xlsPath & templatefilename)

        xlsSheet = xlsWB.Worksheets(1)
        'xlsCell = xlsSheet.Range("A1")
        'xlsSheet.Cells(3, 1) = strfilter
        Dim x, y As Integer
        For x = 0 To mydg.RowCount - 1
            For y = 0 To mydg.ColumnCount - 1
                xlsSheet.Cells(x + 5, y + 1) = mydg.Rows(x).Cells(y).Value
            Next
        Next
        With xlsSheet.Range(ConvertToLetters(1) & 5, ConvertToLetters(mydg.ColumnCount) & x + 4)
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        End With

        'xlsSheet.Cells(1, 1) = "Mike"
        templatefilename = templatefilename.Replace(".xlsx", "")
        templatefilename = templatefilename.Replace(".xls", "")
        Dim myfilename As String = templatefilename & " " & currentDate.ToString("mm-dd-yy hh-mm-ss") & ".xlsx"
        MsgBox(myfilename)
        xlsSheet.Protect(strpassword)
        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False
        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()
        ReleaseObject(xlsApp)
        ReleaseObject(xlsWB)
        ReleaseObject(xlsSheet)
        System.Diagnostics.Process.Start("excel.exe", """" & xlsFiles & myfilename & """")
    End Sub

    Public Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Function ConvertToLetters(ByVal number As Integer) As String
        number -= 1
        Dim result As String = String.Empty

        If (26 > number) Then
            result = Chr(number + 65)
        Else
            Dim column As Integer

            Do
                column = number Mod 26
                number = (number \ 26) - 1
                result = Chr(column + 65) + result
            Loop Until (number < 0)
        End If

        Return result

    End Function

End Module