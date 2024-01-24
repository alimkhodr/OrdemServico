<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Estoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estoque))
        Me.Lista_estoque = New System.Windows.Forms.ListView()
        Me.btn_os = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_os = New System.Windows.Forms.TextBox()
        Me.txt_limpar = New System.Windows.Forms.Button()
        Me.txt_data_fim = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lista_estoque
        '
        Me.Lista_estoque.AllowColumnReorder = True
        Me.Lista_estoque.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lista_estoque.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista_estoque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Lista_estoque.FullRowSelect = True
        Me.Lista_estoque.GridLines = True
        Me.Lista_estoque.Location = New System.Drawing.Point(48, 259)
        Me.Lista_estoque.MultiSelect = False
        Me.Lista_estoque.Name = "Lista_estoque"
        Me.Lista_estoque.Size = New System.Drawing.Size(891, 353)
        Me.Lista_estoque.TabIndex = 69
        Me.Lista_estoque.UseCompatibleStateImageBehavior = False
        Me.Lista_estoque.View = System.Windows.Forms.View.Details
        '
        'btn_os
        '
        Me.btn_os.BackColor = System.Drawing.Color.Transparent
        Me.btn_os.BackgroundImage = Global.APONTAMENTO_DE_HORAS___FERRAMENTARIA.My.Resources.Resources.excel
        Me.btn_os.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_os.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_os.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_os.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btn_os.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_os.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_os.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_os.Location = New System.Drawing.Point(832, 133)
        Me.btn_os.Name = "btn_os"
        Me.btn_os.Size = New System.Drawing.Size(107, 29)
        Me.btn_os.TabIndex = 77
        Me.btn_os.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 22)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "OS"
        '
        'txt_os
        '
        Me.txt_os.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_os.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.txt_os.Location = New System.Drawing.Point(79, 133)
        Me.txt_os.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_os.Name = "txt_os"
        Me.txt_os.Size = New System.Drawing.Size(55, 29)
        Me.txt_os.TabIndex = 80
        '
        'txt_limpar
        '
        Me.txt_limpar.BackColor = System.Drawing.Color.Transparent
        Me.txt_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txt_limpar.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.txt_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.txt_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.txt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_limpar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_limpar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_limpar.Location = New System.Drawing.Point(832, 173)
        Me.txt_limpar.Name = "txt_limpar"
        Me.txt_limpar.Size = New System.Drawing.Size(107, 29)
        Me.txt_limpar.TabIndex = 89
        Me.txt_limpar.Text = "LIMPAR"
        Me.txt_limpar.UseVisualStyleBackColor = False
        '
        'txt_data_fim
        '
        Me.txt_data_fim.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.txt_data_fim.Location = New System.Drawing.Point(716, 133)
        Me.txt_data_fim.Mask = "00/00/0000"
        Me.txt_data_fim.Name = "txt_data_fim"
        Me.txt_data_fim.Size = New System.Drawing.Size(99, 29)
        Me.txt_data_fim.TabIndex = 91
        Me.txt_data_fim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_data_fim.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(629, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 22)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Data Fim"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(832, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 29)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "ENVIAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Font = New System.Drawing.Font("Montserrat Black", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label24.Location = New System.Drawing.Point(323, 43)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 48)
        Me.Label24.TabIndex = 105
        Me.Label24.Text = "•"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Font = New System.Drawing.Font("Montserrat Black", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label25.Location = New System.Drawing.Point(654, 43)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 48)
        Me.Label25.TabIndex = 104
        Me.Label25.Text = "•"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Font = New System.Drawing.Font("Montserrat", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.Location = New System.Drawing.Point(351, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(314, 48)
        Me.Label26.TabIndex = 103
        Me.Label26.Text = "APTIV - Estoque"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(989, 656)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_data_fim)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_limpar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_os)
        Me.Controls.Add(Me.btn_os)
        Me.Controls.Add(Me.Lista_estoque)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Estoque"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatorio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lista_estoque As ListView
    Friend WithEvents btn_os As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_os As TextBox
    Friend WithEvents txt_limpar As Button
    Friend WithEvents txt_data_fim As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
End Class
