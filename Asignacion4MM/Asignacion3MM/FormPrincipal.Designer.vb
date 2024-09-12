<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.btnAgregarU = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1AU = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAgregarU
        '
        Me.btnAgregarU.Image = CType(resources.GetObject("btnAgregarU.Image"), System.Drawing.Image)
        Me.btnAgregarU.Location = New System.Drawing.Point(54, 68)
        Me.btnAgregarU.Name = "btnAgregarU"
        Me.btnAgregarU.Size = New System.Drawing.Size(105, 103)
        Me.btnAgregarU.TabIndex = 0
        Me.btnAgregarU.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(318, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 103)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1AU
        '
        Me.Label1AU.AutoSize = True
        Me.Label1AU.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1AU.Location = New System.Drawing.Point(12, 29)
        Me.Label1AU.Name = "Label1AU"
        Me.Label1AU.Size = New System.Drawing.Size(182, 27)
        Me.Label1AU.TabIndex = 2
        Me.Label1AU.Text = "Agregar Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Realizar Transacción"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 198)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1AU)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAgregarU)
        Me.Name = "FormPrincipal"
        Me.Text = "FormPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregarU As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1AU As Label
    Friend WithEvents Label2 As Label
End Class
