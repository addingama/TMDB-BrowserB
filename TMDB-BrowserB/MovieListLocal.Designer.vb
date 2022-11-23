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
        Me.dgv_movie_list = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_movie_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_get_todo
        '
        Me.btn_get_todo.Location = New System.Drawing.Point(32, 29)
        Me.btn_get_todo.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btn_get_todo.Name = "btn_get_todo"
        Me.btn_get_todo.Size = New System.Drawing.Size(462, 55)
        Me.btn_get_todo.TabIndex = 0
        Me.btn_get_todo.Text = "Get Movies From API"
        Me.btn_get_todo.UseVisualStyleBackColor = True
        '
        'dgv_movie_list
        '
        Me.dgv_movie_list.AllowUserToAddRows = False
        Me.dgv_movie_list.AllowUserToDeleteRows = False
        Me.dgv_movie_list.AllowUserToResizeRows = False
        Me.dgv_movie_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_movie_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_movie_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_movie_list.Location = New System.Drawing.Point(32, 131)
        Me.dgv_movie_list.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.dgv_movie_list.Name = "dgv_movie_list"
        Me.dgv_movie_list.RowHeadersWidth = 102
        Me.dgv_movie_list.RowTemplate.Height = 40
        Me.dgv_movie_list.Size = New System.Drawing.Size(2069, 907)
        Me.dgv_movie_list.TabIndex = 1
        '
        'MovieListLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2133, 1073)
        Me.Controls.Add(Me.dgv_movie_list)
        Me.Controls.Add(Me.btn_get_todo)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "MovieListLocal"
        Me.Text = "The Movie Database Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_movie_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_get_todo As Button
    Friend WithEvents dgv_movie_list As DataGridView
End Class
