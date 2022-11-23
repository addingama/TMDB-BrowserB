<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieDetail
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
        Me.lbl_overview = New System.Windows.Forms.Label()
        Me.pb_poster = New System.Windows.Forms.PictureBox()
        CType(Me.pb_poster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_overview
        '
        Me.lbl_overview.Location = New System.Drawing.Point(444, 25)
        Me.lbl_overview.Name = "lbl_overview"
        Me.lbl_overview.Size = New System.Drawing.Size(868, 536)
        Me.lbl_overview.TabIndex = 1
        Me.lbl_overview.Text = "Label2"
        '
        'pb_poster
        '
        Me.pb_poster.Location = New System.Drawing.Point(12, 12)
        Me.pb_poster.Name = "pb_poster"
        Me.pb_poster.Size = New System.Drawing.Size(415, 549)
        Me.pb_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_poster.TabIndex = 2
        Me.pb_poster.TabStop = False
        '
        'MovieDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 582)
        Me.Controls.Add(Me.pb_poster)
        Me.Controls.Add(Me.lbl_overview)
        Me.Name = "MovieDetail"
        Me.Text = "MovieDetail"
        CType(Me.pb_poster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_overview As Label
    Friend WithEvents pb_poster As PictureBox
End Class
