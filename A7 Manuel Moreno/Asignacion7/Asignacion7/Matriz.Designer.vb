<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriz
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvMatriz = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MatrizBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatrizBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMatriz
        '
        Me.dgvMatriz.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMatriz.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatriz.ColumnHeadersVisible = False
        Me.dgvMatriz.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvMatriz.Location = New System.Drawing.Point(12, 12)
        Me.dgvMatriz.Name = "dgvMatriz"
        Me.dgvMatriz.ReadOnly = True
        Me.dgvMatriz.Size = New System.Drawing.Size(383, 241)
        Me.dgvMatriz.TabIndex = 0
        Me.dgvMatriz.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(148, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "LLenar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MatrizBindingSource
        '
        Me.MatrizBindingSource.DataSource = GetType(Asignacion7.Matriz)
        '
        'Matriz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 357)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvMatriz)
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Matriz"
        Me.Text = "Matriz"
        CType(Me.dgvMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatrizBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvMatriz As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents MatrizBindingSource As BindingSource
End Class
