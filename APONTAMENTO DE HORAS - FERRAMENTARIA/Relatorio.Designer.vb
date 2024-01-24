<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Relatorio))
        Me.txt_fer = New System.Windows.Forms.TextBox()
        Me.Lista_OS = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.MaskedTextBox()
        Me.btn_os = New System.Windows.Forms.Button()
        Me.txt_horas_totais = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_os = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_fun = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_op = New System.Windows.Forms.ComboBox()
        Me.cbo_maq = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_limpar = New System.Windows.Forms.Button()
        Me.txt_data_fim = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_fer
        '
        Me.txt_fer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_fer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fer.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fer.Location = New System.Drawing.Point(249, 133)
        Me.txt_fer.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_fer.Name = "txt_fer"
        Me.txt_fer.Size = New System.Drawing.Size(175, 31)
        Me.txt_fer.TabIndex = 2
        '
        'Lista_OS
        '
        Me.Lista_OS.AllowColumnReorder = True
        Me.Lista_OS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lista_OS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lista_OS.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista_OS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Lista_OS.FullRowSelect = True
        Me.Lista_OS.GridLines = True
        Me.Lista_OS.Location = New System.Drawing.Point(48, 226)
        Me.Lista_OS.MultiSelect = False
        Me.Lista_OS.Name = "Lista_OS"
        Me.Lista_OS.Size = New System.Drawing.Size(891, 344)
        Me.Lista_OS.TabIndex = 69
        Me.Lista_OS.UseCompatibleStateImageBehavior = False
        Me.Lista_OS.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 22)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Ferramenta"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(429, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 22)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Data Início"
        '
        'txt_data
        '
        Me.txt_data.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_data.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data.Location = New System.Drawing.Point(527, 133)
        Me.txt_data.Mask = "00/00/0000"
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(99, 31)
        Me.txt_data.TabIndex = 3
        Me.txt_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_data.ValidatingType = GetType(Date)
        '
        'btn_os
        '
        Me.btn_os.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_os.BackColor = System.Drawing.Color.Transparent
        Me.btn_os.BackgroundImage = Global.APONTAMENTO_DE_HORAS___FERRAMENTARIA.My.Resources.Resources.excel
        Me.btn_os.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_os.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btn_os.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_os.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btn_os.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_os.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_os.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_os.Location = New System.Drawing.Point(811, 586)
        Me.btn_os.Name = "btn_os"
        Me.btn_os.Size = New System.Drawing.Size(128, 39)
        Me.btn_os.TabIndex = 11
        Me.btn_os.UseVisualStyleBackColor = False
        '
        'txt_horas_totais
        '
        Me.txt_horas_totais.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_horas_totais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_horas_totais.Enabled = False
        Me.txt_horas_totais.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_horas_totais.Location = New System.Drawing.Point(832, 177)
        Me.txt_horas_totais.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_horas_totais.Name = "txt_horas_totais"
        Me.txt_horas_totais.Size = New System.Drawing.Size(107, 31)
        Me.txt_horas_totais.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(721, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 22)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Horas Totais"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 22)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "OS"
        '
        'txt_os
        '
        Me.txt_os.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_os.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_os.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_os.Location = New System.Drawing.Point(79, 133)
        Me.txt_os.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_os.Name = "txt_os"
        Me.txt_os.Size = New System.Drawing.Size(55, 31)
        Me.txt_os.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 22)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Funcionário"
        '
        'txt_fun
        '
        Me.txt_fun.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_fun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fun.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fun.Location = New System.Drawing.Point(151, 178)
        Me.txt_fun.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_fun.Name = "txt_fun"
        Me.txt_fun.Size = New System.Drawing.Size(143, 31)
        Me.txt_fun.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(306, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 22)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Operação"
        '
        'txt_op
        '
        Me.txt_op.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_op.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_op.FormattingEnabled = True
        Me.txt_op.Location = New System.Drawing.Point(398, 177)
        Me.txt_op.Name = "txt_op"
        Me.txt_op.Size = New System.Drawing.Size(89, 30)
        Me.txt_op.TabIndex = 6
        '
        'cbo_maq
        '
        Me.cbo_maq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_maq.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_maq.FormattingEnabled = True
        Me.cbo_maq.Location = New System.Drawing.Point(579, 177)
        Me.cbo_maq.Name = "cbo_maq"
        Me.cbo_maq.Size = New System.Drawing.Size(135, 30)
        Me.cbo_maq.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(496, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 22)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Máquina"
        '
        'txt_limpar
        '
        Me.txt_limpar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_limpar.BackColor = System.Drawing.Color.Transparent
        Me.txt_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txt_limpar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.txt_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.txt_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.txt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_limpar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_limpar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_limpar.Location = New System.Drawing.Point(832, 133)
        Me.txt_limpar.Name = "txt_limpar"
        Me.txt_limpar.Size = New System.Drawing.Size(107, 29)
        Me.txt_limpar.TabIndex = 10
        Me.txt_limpar.Text = "LIMPAR"
        Me.txt_limpar.UseVisualStyleBackColor = False
        '
        'txt_data_fim
        '
        Me.txt_data_fim.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_data_fim.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data_fim.Location = New System.Drawing.Point(717, 133)
        Me.txt_data_fim.Mask = "00/00/0000"
        Me.txt_data_fim.Name = "txt_data_fim"
        Me.txt_data_fim.Size = New System.Drawing.Size(99, 31)
        Me.txt_data_fim.TabIndex = 4
        Me.txt_data_fim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_data_fim.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(631, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 22)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Data Fim"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Montserrat Black", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label10.Location = New System.Drawing.Point(309, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 48)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "•"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Montserrat Black", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label11.Location = New System.Drawing.Point(660, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 48)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "•"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Montserrat", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(337, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(332, 48)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "APTIV - Relatório"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(989, 656)
        Me.Controls.Add(Me.txt_data_fim)
        Me.Controls.Add(Me.txt_limpar)
        Me.Controls.Add(Me.cbo_maq)
        Me.Controls.Add(Me.txt_op)
        Me.Controls.Add(Me.txt_fun)
        Me.Controls.Add(Me.txt_os)
        Me.Controls.Add(Me.txt_horas_totais)
        Me.Controls.Add(Me.btn_os)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.txt_fer)
        Me.Controls.Add(Me.Lista_OS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Relatorio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatorio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_fer As TextBox
    Friend WithEvents Lista_OS As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_data As MaskedTextBox
    Friend WithEvents btn_os As Button
    Friend WithEvents txt_horas_totais As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_os As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_fun As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_op As ComboBox
    Friend WithEvents cbo_maq As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_limpar As Button
    Friend WithEvents txt_data_fim As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
