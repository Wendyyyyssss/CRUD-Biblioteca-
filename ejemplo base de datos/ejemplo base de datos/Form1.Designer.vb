<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.tbapellidos = New System.Windows.Forms.TextBox()
        Me.tbpais = New System.Windows.Forms.TextBox()
        Me.dtpnac = New System.Windows.Forms.DateTimePicker()
        Me.dtpmuerte = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btteliminar = New System.Windows.Forms.Button()
        Me.bttguardar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 233)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(616, 222)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "País:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha de Nacimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(300, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 28)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha de Muerte:"
        '
        'tbnombre
        '
        Me.tbnombre.Location = New System.Drawing.Point(106, 103)
        Me.tbnombre.Multiline = True
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(148, 20)
        Me.tbnombre.TabIndex = 7
        '
        'tbapellidos
        '
        Me.tbapellidos.Location = New System.Drawing.Point(106, 141)
        Me.tbapellidos.Multiline = True
        Me.tbapellidos.Name = "tbapellidos"
        Me.tbapellidos.Size = New System.Drawing.Size(148, 20)
        Me.tbapellidos.TabIndex = 8
        '
        'tbpais
        '
        Me.tbpais.Location = New System.Drawing.Point(106, 177)
        Me.tbpais.Multiline = True
        Me.tbpais.Name = "tbpais"
        Me.tbpais.Size = New System.Drawing.Size(148, 20)
        Me.tbpais.TabIndex = 9
        '
        'dtpnac
        '
        Me.dtpnac.Location = New System.Drawing.Point(418, 103)
        Me.dtpnac.Name = "dtpnac"
        Me.dtpnac.Size = New System.Drawing.Size(200, 20)
        Me.dtpnac.TabIndex = 10
        '
        'dtpmuerte
        '
        Me.dtpmuerte.Location = New System.Drawing.Point(418, 138)
        Me.dtpmuerte.Name = "dtpmuerte"
        Me.dtpmuerte.Size = New System.Drawing.Size(200, 20)
        Me.dtpmuerte.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(270, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 47)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Autores"
        '
        'btteliminar
        '
        Me.btteliminar.BackgroundImage = CType(resources.GetObject("btteliminar.BackgroundImage"), System.Drawing.Image)
        Me.btteliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btteliminar.Location = New System.Drawing.Point(462, 174)
        Me.btteliminar.Name = "btteliminar"
        Me.btteliminar.Size = New System.Drawing.Size(116, 47)
        Me.btteliminar.TabIndex = 13
        Me.btteliminar.UseVisualStyleBackColor = True
        '
        'bttguardar
        '
        Me.bttguardar.BackgroundImage = CType(resources.GetObject("bttguardar.BackgroundImage"), System.Drawing.Image)
        Me.bttguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bttguardar.Location = New System.Drawing.Point(331, 174)
        Me.bttguardar.Name = "bttguardar"
        Me.bttguardar.Size = New System.Drawing.Size(116, 47)
        Me.bttguardar.TabIndex = 14
        Me.bttguardar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(680, 467)
        Me.Controls.Add(Me.bttguardar)
        Me.Controls.Add(Me.btteliminar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpmuerte)
        Me.Controls.Add(Me.dtpnac)
        Me.Controls.Add(Me.tbpais)
        Me.Controls.Add(Me.tbapellidos)
        Me.Controls.Add(Me.tbnombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbnombre As TextBox
    Friend WithEvents tbapellidos As TextBox
    Friend WithEvents tbpais As TextBox
    Friend WithEvents dtpnac As DateTimePicker
    Friend WithEvents dtpmuerte As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents btteliminar As Button
    Friend WithEvents bttguardar As Button
End Class
