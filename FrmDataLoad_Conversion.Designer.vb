<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDataLoad_Conversion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDataLoad_Conversion))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.BtnUpload = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DGV1)
        Me.Panel3.Location = New System.Drawing.Point(12, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(481, 283)
        Me.Panel3.TabIndex = 10
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(3, 3)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(475, 277)
        Me.DGV1.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.White
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.Location = New System.Drawing.Point(364, 23)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(129, 37)
        Me.btnBackup.TabIndex = 19
        Me.btnBackup.Text = "       &Backup File"
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'BtnUpload
        '
        Me.BtnUpload.BackColor = System.Drawing.Color.White
        Me.BtnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpload.Image = CType(resources.GetObject("BtnUpload.Image"), System.Drawing.Image)
        Me.BtnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpload.Location = New System.Drawing.Point(12, 373)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(107, 37)
        Me.BtnUpload.TabIndex = 20
        Me.BtnUpload.Text = "       &Upload"
        Me.BtnUpload.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "d:/"
        '
        'saveFileDialog
        '
        Me.saveFileDialog.FileName = "saveFileDialog1"
        Me.saveFileDialog.InitialDirectory = "C:\ProgramData\MySQL\MySQL Server 8.0\Uploads"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        Me.OpenFileDialog2.InitialDirectory = "C:\ProgramData\MySQL\MySQL Server 8.0\Uploads"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(143, 373)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 20)
        Me.TextBox1.TabIndex = 21
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Snow
        Me.BtnBack.Location = New System.Drawing.Point(15, 416)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(104, 30)
        Me.BtnBack.TabIndex = 26
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'FrmDataLoad_Conversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 463)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnUpload)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FrmDataLoad_Conversion"
        Me.Text = "FrmDataLoad_Conversion"
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBackup As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnUpload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents saveFileDialog As SaveFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnBack As Button
End Class
