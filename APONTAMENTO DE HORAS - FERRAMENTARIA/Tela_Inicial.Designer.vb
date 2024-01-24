<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tela_Inicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tela_Inicial))
        Me.btn_os = New System.Windows.Forms.Button()
        Me.Lista_OS = New System.Windows.Forms.ListView()
        Me.btn_servico = New System.Windows.Forms.Button()
        Me.btn_relatorio = New System.Windows.Forms.Button()
        Me.btn_maq = New System.Windows.Forms.Button()
        Me.txt_fer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_os
        '
        Me.btn_os.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_os.BackColor = System.Drawing.Color.Transparent
        Me.btn_os.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btn_os.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_os.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_os.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_os.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_os.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_os.Location = New System.Drawing.Point(503, 142)
        Me.btn_os.Name = "btn_os"
        Me.btn_os.Size = New System.Drawing.Size(101, 32)
        Me.btn_os.TabIndex = 1
        Me.btn_os.Text = "NOVA OS"
        Me.btn_os.UseVisualStyleBackColor = False
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
        Me.Lista_OS.Location = New System.Drawing.Point(50, 185)
        Me.Lista_OS.MultiSelect = False
        Me.Lista_OS.Name = "Lista_OS"
        Me.Lista_OS.Size = New System.Drawing.Size(990, 393)
        Me.Lista_OS.TabIndex = 0
        Me.Lista_OS.UseCompatibleStateImageBehavior = False
        Me.Lista_OS.View = System.Windows.Forms.View.Details
        '
        'btn_servico
        '
        Me.btn_servico.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_servico.BackColor = System.Drawing.Color.Transparent
        Me.btn_servico.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btn_servico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_servico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_servico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_servico.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_servico.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_servico.Location = New System.Drawing.Point(604, 142)
        Me.btn_servico.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_servico.Name = "btn_servico"
        Me.btn_servico.Size = New System.Drawing.Size(177, 32)
        Me.btn_servico.TabIndex = 2
        Me.btn_servico.Text = "APONTAR SERVIÇO"
        Me.btn_servico.UseVisualStyleBackColor = False
        '
        'btn_relatorio
        '
        Me.btn_relatorio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_relatorio.BackColor = System.Drawing.Color.Transparent
        Me.btn_relatorio.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btn_relatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_relatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_relatorio.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_relatorio.Location = New System.Drawing.Point(781, 142)
        Me.btn_relatorio.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_relatorio.Name = "btn_relatorio"
        Me.btn_relatorio.Size = New System.Drawing.Size(129, 32)
        Me.btn_relatorio.TabIndex = 3
        Me.btn_relatorio.Text = "RELATÓRIOS"
        Me.btn_relatorio.UseVisualStyleBackColor = False
        '
        'btn_maq
        '
        Me.btn_maq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_maq.BackColor = System.Drawing.Color.Transparent
        Me.btn_maq.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btn_maq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_maq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btn_maq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maq.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_maq.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_maq.Location = New System.Drawing.Point(910, 142)
        Me.btn_maq.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_maq.Name = "btn_maq"
        Me.btn_maq.Size = New System.Drawing.Size(125, 32)
        Me.btn_maq.TabIndex = 4
        Me.btn_maq.Text = " MÁQUINAS"
        Me.btn_maq.UseVisualStyleBackColor = False
        '
        'txt_fer
        '
        Me.txt_fer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_fer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fer.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.txt_fer.Location = New System.Drawing.Point(130, 142)
        Me.txt_fer.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_fer.Name = "txt_fer"
        Me.txt_fer.Size = New System.Drawing.Size(225, 29)
        Me.txt_fer.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(320, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 48)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "APTIV - Ordem de Serviço"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Location = New System.Drawing.Point(501, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 10)
        Me.Panel1.TabIndex = 75
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Location = New System.Drawing.Point(503, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(543, 10)
        Me.Panel2.TabIndex = 76
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.Location = New System.Drawing.Point(495, 133)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 41)
        Me.Panel3.TabIndex = 76
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel4.Location = New System.Drawing.Point(1034, 137)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 41)
        Me.Panel4.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Montserrat Black", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(805, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 48)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "•"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Montserrat Black", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(292, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 48)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "•"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(46, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Pesquisar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tela_Inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1089, 622)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_servico)
        Me.Controls.Add(Me.btn_os)
        Me.Controls.Add(Me.txt_fer)
        Me.Controls.Add(Me.btn_relatorio)
        Me.Controls.Add(Me.Lista_OS)
        Me.Controls.Add(Me.btn_maq)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tela_Inicial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela_Inicial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_os As Button
    Friend WithEvents Lista_OS As ListView
    Friend WithEvents btn_servico As Button
    Friend WithEvents btn_relatorio As Button
    Friend WithEvents btn_maq As Button
    Friend WithEvents txt_fer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
