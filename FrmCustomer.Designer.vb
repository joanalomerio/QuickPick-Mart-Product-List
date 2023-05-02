<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cusnumtxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cusnametxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cus_agetxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cus_add_idtxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.customergrid = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.customergrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "cus_num"
        '
        'cusnumtxt
        '
        Me.cusnumtxt.Location = New System.Drawing.Point(68, 86)
        Me.cusnumtxt.Name = "cusnumtxt"
        Me.cusnumtxt.Size = New System.Drawing.Size(226, 20)
        Me.cusnumtxt.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 52)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Customer Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "name"
        '
        'cusnametxt
        '
        Me.cusnametxt.Location = New System.Drawing.Point(68, 126)
        Me.cusnametxt.Name = "cusnametxt"
        Me.cusnametxt.Size = New System.Drawing.Size(226, 20)
        Me.cusnametxt.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Age"
        '
        'cus_agetxt
        '
        Me.cus_agetxt.Location = New System.Drawing.Point(68, 163)
        Me.cus_agetxt.Name = "cus_agetxt"
        Me.cus_agetxt.Size = New System.Drawing.Size(226, 20)
        Me.cus_agetxt.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "add_id"
        '
        'cus_add_idtxt
        '
        Me.cus_add_idtxt.Location = New System.Drawing.Point(68, 202)
        Me.cus_add_idtxt.Name = "cus_add_idtxt"
        Me.cus_add_idtxt.Size = New System.Drawing.Size(226, 20)
        Me.cus_add_idtxt.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 33)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "      Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(108, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 33)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "    Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(204, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 33)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "    Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Snow
        Me.Button5.Location = New System.Drawing.Point(6, 146)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 30)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(203, 146)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 31)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Load"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(12, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(297, 170)
        Me.Panel3.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Location = New System.Drawing.Point(12, 246)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(297, 187)
        Me.Panel4.TabIndex = 13
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "C:\ProgramData\MySQL\MySQL Server 8.0\Uploads"
        '
        'customergrid
        '
        Me.customergrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.customergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customergrid.Location = New System.Drawing.Point(5, 3)
        Me.customergrid.Name = "customergrid"
        Me.customergrid.Size = New System.Drawing.Size(468, 308)
        Me.customergrid.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.customergrid)
        Me.Panel2.Location = New System.Drawing.Point(315, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(476, 362)
        Me.Panel2.TabIndex = 7
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Snow
        Me.Button6.Location = New System.Drawing.Point(373, 317)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 30)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Print"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 435)
        Me.Controls.Add(Me.cus_add_idtxt)
        Me.Controls.Add(Me.cus_agetxt)
        Me.Controls.Add(Me.cusnametxt)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cusnumtxt)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "customer"
        Me.Text = "customer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.customergrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cusnumtxt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cusnametxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cus_agetxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cus_add_idtxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents customergrid As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button6 As Button
End Class
