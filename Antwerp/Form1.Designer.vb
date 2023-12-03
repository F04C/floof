<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.LabelAdjustedTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2DragControl3 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Floof: "
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'LabelAdjustedTime
        '
        Me.LabelAdjustedTime.AutoSize = True
        Me.LabelAdjustedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdjustedTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LabelAdjustedTime.Location = New System.Drawing.Point(87, 9)
        Me.LabelAdjustedTime.Name = "LabelAdjustedTime"
        Me.LabelAdjustedTime.Size = New System.Drawing.Size(131, 29)
        Me.LabelAdjustedTime.TabIndex = 1
        Me.LabelAdjustedTime.Text = "HH:MM:SS"
        '
        'Timer1
        '
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 2
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.TargetControl = Me.Label1
        '
        'Guna2DragControl3
        '
        Me.Guna2DragControl3.TargetControl = Me.LabelAdjustedTime
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(250, 50)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelAdjustedTime)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Floof ☁️"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents LabelAdjustedTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2DragControl3 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
