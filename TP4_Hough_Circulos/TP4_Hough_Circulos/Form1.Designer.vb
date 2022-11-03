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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblCentro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGTransformada = New System.Windows.Forms.DataGridView()
        Me.DGImagen = New System.Windows.Forms.DataGridView()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGTransformada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCentro
        '
        Me.lblCentro.AutoSize = True
        Me.lblCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentro.Location = New System.Drawing.Point(447, 527)
        Me.lblCentro.Name = "lblCentro"
        Me.lblCentro.Size = New System.Drawing.Size(0, 16)
        Me.lblCentro.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 527)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Y="
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(117, 527)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(20, 13)
        Me.label.TabIndex = 21
        Me.label.Text = "X="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(458, -19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(404, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Los puntos que forman rectas son las intersecciones de las curvas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-30, -19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 21)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Seleccione puntos que formen una recta del 1er cuadrante"
        '
        'DGTransformada
        '
        Me.DGTransformada.AllowUserToAddRows = False
        Me.DGTransformada.AllowUserToDeleteRows = False
        Me.DGTransformada.AllowUserToResizeColumns = False
        Me.DGTransformada.AllowUserToResizeRows = False
        Me.DGTransformada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTransformada.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGTransformada.Location = New System.Drawing.Point(474, 44)
        Me.DGTransformada.Name = "DGTransformada"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGTransformada.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGTransformada.Size = New System.Drawing.Size(325, 439)
        Me.DGTransformada.TabIndex = 18
        '
        'DGImagen
        '
        Me.DGImagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGImagen.Location = New System.Drawing.Point(12, 44)
        Me.DGImagen.Name = "DGImagen"
        Me.DGImagen.Size = New System.Drawing.Size(456, 439)
        Me.DGImagen.TabIndex = 17
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(240, 527)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(13, 13)
        Me.lblY.TabIndex = 26
        Me.lblY.Text = "0"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(143, 527)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(13, 13)
        Me.lblX.TabIndex = 25
        Me.lblX.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Dibuje con puntos un circulo de Radio 3 aproximadamente"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 612)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblCentro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGTransformada)
        Me.Controls.Add(Me.DGImagen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGTransformada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCentro As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGTransformada As System.Windows.Forms.DataGridView
    Friend WithEvents DGImagen As System.Windows.Forms.DataGridView
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
