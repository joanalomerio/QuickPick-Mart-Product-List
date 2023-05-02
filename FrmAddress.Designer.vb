<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Address
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Address))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.add_numtxt = New System.Windows.Forms.TextBox()
        Me.add_num = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.add_nametxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.customergrid = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.add_num.SuspendLayout()
        CType(Me.customergrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(2, 2)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(86, 65)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 1
        Me.LogoPictureBox.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(94, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(271, 63)
        Me.Panel3.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Modify Address of Customer"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(12, 376)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 31)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Load"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "add_num"
        '
        'add_numtxt
        '
        Me.add_numtxt.Location = New System.Drawing.Point(107, 17)
        Me.add_numtxt.Name = "add_numtxt"
        Me.add_numtxt.Size = New System.Drawing.Size(226, 20)
        Me.add_numtxt.TabIndex = 21
        '
        'add_num
        '
        Me.add_num.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.add_num.Controls.Add(Me.Button2)
        Me.add_num.Controls.Add(Me.Button3)
        Me.add_num.Controls.Add(Me.add_numtxt)
        Me.add_num.Controls.Add(Me.add_nametxt)
        Me.add_num.Controls.Add(Me.Button1)
        Me.add_num.Controls.Add(Me.Label3)
        Me.add_num.Controls.Add(Me.Label2)
        Me.add_num.Location = New System.Drawing.Point(12, 76)
        Me.add_num.Name = "add_num"
        Me.add_num.Size = New System.Drawing.Size(349, 158)
        Me.add_num.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(125, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 33)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "    Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(243, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 33)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "    Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'add_nametxt
        '
        Me.add_nametxt.Location = New System.Drawing.Point(107, 52)
        Me.add_nametxt.Name = "add_nametxt"
        Me.add_nametxt.Size = New System.Drawing.Size(226, 20)
        Me.add_nametxt.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(13, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 33)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "      Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "add_name"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Snow
        Me.Button5.Location = New System.Drawing.Point(278, 377)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 30)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'customergrid
        '
        Me.customergrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.customergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customergrid.Location = New System.Drawing.Point(12, 240)
        Me.customergrid.Name = "customergrid"
        Me.customergrid.Size = New System.Drawing.Size(353, 130)
        Me.customergrid.TabIndex = 27
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(119, 377)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 31)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Print"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Address
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 419)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.customergrid)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.add_num)
        Me.Name = "Address"
        Me.Text = "Address"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.add_num.ResumeLayout(False)
        Me.add_num.PerformLayout()
        CType(Me.customergrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents add_numtxt As TextBox
    Friend WithEvents add_num As Panel
    Friend WithEvents add_nametxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents customergrid As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
End Class
