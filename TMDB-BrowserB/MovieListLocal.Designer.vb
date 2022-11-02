<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieListLocal
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
        Me.btn_get_todo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_release_date = New System.Windows.Forms.Label()
        Me.lbl_overview = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_get_todo
        '
        Me.btn_get_todo.Location = New System.Drawing.Point(27, 12)
        Me.btn_get_todo.Name = "btn_get_todo"
        Me.btn_get_todo.Size = New System.Drawing.Size(75, 23)
        Me.btn_get_todo.TabIndex = 0
        Me.btn_get_todo.Text = "Get Movies"
        Me.btn_get_todo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Judul"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Release Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Overview"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(126, 62)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(32, 13)
        Me.lbl_title.TabIndex = 4
        Me.lbl_title.Text = "Judul"
        '
        'lbl_release_date
        '
        Me.lbl_release_date.AutoSize = True
        Me.lbl_release_date.Location = New System.Drawing.Point(126, 94)
        Me.lbl_release_date.Name = "lbl_release_date"
        Me.lbl_release_date.Size = New System.Drawing.Size(32, 13)
        Me.lbl_release_date.TabIndex = 5
        Me.lbl_release_date.Text = "Judul"
        '
        'lbl_overview
        '
        Me.lbl_overview.AutoSize = True
        Me.lbl_overview.Location = New System.Drawing.Point(126, 126)
        Me.lbl_overview.Name = "lbl_overview"
        Me.lbl_overview.Size = New System.Drawing.Size(32, 13)
        Me.lbl_overview.TabIndex = 6
        Me.lbl_overview.Text = "Judul"
        '
        'MovieListLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_overview)
        Me.Controls.Add(Me.lbl_release_date)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_get_todo)
        Me.Name = "MovieListLocal"
        Me.Text = "The Movie Database Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_get_todo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_release_date As Label
    Friend WithEvents lbl_overview As Label
End Class
