

Imports System.IO

Public Class Ordem
    Public COD_FORM As Integer
    Public REGISTRO As String
    Public situacao As String

    Private Sub Ordem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Preencher_cbo()

        If id_OS = 0 Then
            conectar()
            comandoSQL.CommandText = " SELECT TOP 1 OS_ID FROM TAB_OS_RELATORIO ORDER BY OS_ID DESC"
            objDataReader = comandoSQL.ExecuteReader
            If objDataReader.Read Then
                COD_FORM = objDataReader(0) + 1
            Else
                COD_FORM = 1
            End If
            objDataReader.Close()
            desconectar()
            txt_OS.Text = COD_FORM
        Else
            COD_FORM = txt_OS.Text
        End If
        Lista_Req()
        Lista()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If txt_fer.Text = "" Or txt_pos.Text = "" Or txt_projeto.Text = "" Or txt_secao.Text = "" Or txt_resp.Text = "" Or txt_secao.Text = "" Or txt_uni.Text = "" Or txt_tp.Text = "" Or txt_qtd.Text = "" Or txt_conta.Text = "" Or txt_sub_conta.Text = "" Then
            MessageBox.Show("Preencha os campos obrigatórios")
            Return
        End If
        REGISTRO = txt_resp.Text.ToString().Substring(0, txt_resp.Text.ToString().IndexOf(" - "))
        situacao = "ENVIADA"

        If btn_salvar.Text = "ENVIAR" Then
            Try
                conectar()
                objDataReader.Close()
                comandoSQL.CommandText = "INSERT INTO TAB_OS_RELATORIO (OS_ID, OS_FERRAMENTA, OS_POSICAO, OS_DESCRICAO, OS_PROJETO, OS_DATA_ENTREGA, OS_CAIXA, OS_UNIDADE,OS_TIPO,OS_QUANTIDADE,OS_QUANTIDADE_FINAL, "
                comandoSQL.CommandText &= "OS_CONTA, OS_SUB_CONTA,OS_SECAO, OS_REG_RESPONSAVEL, OS_SITUACAO, OP_DATA_ENVIADA) VALUES ('" & COD_FORM & "', '" & txt_fer.Text & "', '" & txt_pos.Text & "', '" & txt_desc.Text & "', '" & txt_projeto.Text & "', '" & txt_dt_ent.Text & "', "
                comandoSQL.CommandText &= "'" & txt_caixa.Text & "', '" & txt_uni.Text & "', '" & txt_tp.Text & "', '" & txt_qtd.Text & "','" & txt_qtd_fim.Text & "', '" & txt_conta.Text & "', '" & txt_sub_conta.Text & "', "
                comandoSQL.CommandText &= "'" & txt_secao.Text & "', '" & REGISTRO & "', '" & situacao & "', '" & DateTime.Now & "')"
                comandoSQL.ExecuteReader()
                desconectar()
                btn_salvar.Text = "INICIAR"
                txt_situ.Text = situacao
                MessageBox.Show("Ordem enviada.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        Else
            Try
                If btn_salvar.Text = "INICIAR" Then
                    Login.Show()
                    tela = 3
                ElseIf btn_salvar.Text = "SALVAR" Then
                    situacao = "EM ANDAMENTO"
                    txt_situ.Text = situacao
                    conectar()
                    comandoSQL.CommandText = "UPDATE TAB_OS_RELATORIO SET OS_FERRAMENTA = '" & txt_fer.Text & "', OS_POSICAO = '" & txt_pos.Text & "', OS_DESCRICAO = '" & txt_desc.Text & "', OS_PROJETO = '" & txt_projeto.Text & "', "
                    comandoSQL.CommandText &= "OS_DATA_ENTREGA = '" & txt_dt_ent.Text & "',OS_CAIXA = '" & txt_caixa.Text & "',OS_UNIDADE = '" & txt_uni.Text & "',OS_TIPO = '" & txt_tp.Text & "',OS_QUANTIDADE = '" & txt_qtd.Text & "', OS_QUANTIDADE_FINAL = '" & txt_qtd_fim.Text & "', "
                    comandoSQL.CommandText &= "OS_CONTA = '" & txt_conta.Text & "',OS_SUB_CONTA = '" & txt_sub_conta.Text & "',OS_SECAO = '" & txt_secao.Text & "',OS_REG_RESPONSAVEL= '" & REGISTRO & "', OS_SITUACAO = '" & situacao & "' WHERE OS_ID = '" & COD_FORM & "'"
                    comandoSQL.ExecuteNonQuery()
                    desconectar()
                    MessageBox.Show("Alteração bem-sucedida.")
                End If
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End If
        Lista_Req()
        Tela_Inicial.Lista()
    End Sub

    Sub Preencher_cbo()
        conectar()
        comandoSQL.CommandText = "SELECT FUN_REGISTRO, FUN_NOME FROM FUNCIONARIO WHERE FUN_STATUS = 'ATIVO'"
        objDataReader = comandoSQL.ExecuteReader
        While objDataReader.Read
            txt_resp.Items.Add(objDataReader("FUN_REGISTRO") & " - " & objDataReader("FUN_NOME"))
        End While
        desconectar()

        txt_uni.Items.Add("PC")
        txt_uni.Items.Add("CJ")

        txt_tp.Items.Add("RETRABALHO")
        txt_tp.Items.Add("PEÇA NOVA")

        txt_op.Items.Add("MP")
        txt_op.Items.Add("TO")
        txt_op.Items.Add("FR1")
        txt_op.Items.Add("TTA")
        txt_op.Items.Add("TT")
        txt_op.Items.Add("RPL")
        txt_op.Items.Add("RP1")
        txt_op.Items.Add("RCI")
        txt_op.Items.Add("CAM")
        txt_op.Items.Add("CAD")
        txt_op.Items.Add("CUD")
        txt_op.Items.Add("EE")
        txt_op.Items.Add("EEF")
        txt_op.Items.Add("MO")

        txt_conta.Items.Add("7000")
        txt_conta.Items.Add("8390")

        txt_sub_conta.Items.Add("02500")
        txt_sub_conta.Items.Add("02510")
        txt_sub_conta.Items.Add("03102")
        txt_sub_conta.Items.Add("03112")
        txt_sub_conta.Items.Add("03202")
        txt_sub_conta.Items.Add("03702")
        txt_sub_conta.Items.Add("05402")
        txt_sub_conta.Items.Add("05502")
        txt_sub_conta.Items.Add("10115")
        txt_sub_conta.Items.Add("01115")
    End Sub

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
        If txt_op.Text = "" Then
            MessageBox.Show("Preencha a operação")
            Return
        End If
        Try
            conectar()
            objDataReader.Close()
            comandoSQL.CommandText = "INSERT INTO TAB_OS_OPERACAO (OP_NOME_OP, OP_DESCRICAO_OP, OP_ID_OS, OP_DATA_ENTREGA, OP_HORAS_PREV, OP_HORAS_PREV_UNIT, OP_QUANTIDADE) "
            comandoSQL.CommandText &= "VALUES ('" & txt_op.Text & "', '" & txt_op_desc.Text & "', '" & COD_FORM & "', '" & txt_op_dt.Text & "', '" & txt_op_hr.Text & "', '" & txt_op_hr_uni.Text & "', '" & txt_op_qtd.Text & "')"
            comandoSQL.ExecuteReader()
            desconectar()
            Lista()
            MessageBox.Show("Inserção bem-sucedida.")
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_deletar_Click(sender As Object, e As EventArgs) Handles btn_deletar.Click
        If id_OP = 0 Then
            MessageBox.Show("Selecione uma operação")
            Return
        End If
        Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja excluir esta operação?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                conectar()
                objDataReader.Close()
                comandoSQL.CommandText = "DELETE TAB_OS_OPERACAO WHERE OP_ID = '" & id_OP & "'"
                comandoSQL.ExecuteReader()
                desconectar()
                id_OP = 0
                Lista()
                MessageBox.Show("Deletado com sucesso.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        Else
            id_OP = 0
        End If
    End Sub

    Sub Lista()
        conectar()
        comandoSQL.CommandText = "SELECT OP_ID, OP_NOME_OP, OP_DESCRICAO_OP, OP_DATA_ENTREGA, OP_HORAS_PREV, OP_HORAS_PREV_UNIT, OP_QUANTIDADE FROM TAB_OS_OPERACAO WHERE OP_ID_OS = '" & COD_FORM & "' AND OP_DATA_FIM IS NULL"
        objDataReader = comandoSQL.ExecuteReader
        Lista_OP.Clear()
        Lista_OP.View = View.Details
        Lista_OP.Columns.Add("", 0, HorizontalAlignment.Left)
        Lista_OP.Columns.Add("ID", 70, HorizontalAlignment.Center)
        Lista_OP.Columns.Add("OPERAÇÃO", 150, HorizontalAlignment.Center)
        Lista_OP.Columns.Add("DESCRIÇÃO", 215, HorizontalAlignment.Center)
        Lista_OP.Columns.Add("ENTREGA", 250, HorizontalAlignment.Center)
        Lista_OP.Columns.Add("HORAS PREV.", 150, HorizontalAlignment.Center)
        Lista_OP.Columns.Add("HORAS PREV. UNI.", 170, HorizontalAlignment.Center)
        Lista_OP.Columns.Add("QUANTIDADE", 170, HorizontalAlignment.Center)
        While objDataReader.Read()
            Dim ls As New ListViewItem("", 0)
            ls.SubItems.Add(objDataReader("OP_ID").ToString())
            ls.SubItems.Add(objDataReader("OP_NOME_OP").ToString())
            ls.SubItems.Add(objDataReader("OP_DESCRICAO_OP").ToString())
            ls.SubItems.Add(Convert.ToDateTime(objDataReader("OP_DATA_ENTREGA")).ToString("dd/MM/yyyy"))
            ls.SubItems.Add(objDataReader("OP_HORAS_PREV").ToString())
            ls.SubItems.Add(objDataReader("OP_HORAS_PREV_UNIT").ToString())
            ls.SubItems.Add(objDataReader("OP_QUANTIDADE").ToString())
            Lista_OP.Items.Add(ls)
        End While
        objDataReader.Close()
        desconectar()
    End Sub

    Sub Lista_Req()
        conectar()
        comandoSQL.CommandText = "SELECT * FROM TAB_OS_RELATORIO WHERE OS_SITUACAO = 'ENVIADA'"
        objDataReader = comandoSQL.ExecuteReader
        Lista_Request.Clear()
        Lista_Request.View = View.Details
        Lista_Request.Columns.Add("", 0, HorizontalAlignment.Left)
        Lista_Request.Columns.Add("OS", 60, HorizontalAlignment.Center)
        Lista_Request.Columns.Add("FERRAMENTA", 180, HorizontalAlignment.Center)
        Lista_Request.Columns.Add("POSIÇÃO", 180, HorizontalAlignment.Center)
        Lista_Request.Columns.Add("DATA_ENVIO", 142, HorizontalAlignment.Center)
        Lista_Request.Columns.Add("RESPONSAVEL", 150, HorizontalAlignment.Center)
        Lista_Request.Columns.Add("SITUAÇÃO", 150, HorizontalAlignment.Center)
        While objDataReader.Read()
            Dim ls As New ListViewItem("", 0)
            ls.SubItems.Add(objDataReader("OS_ID").ToString())
            ls.SubItems.Add(objDataReader("OS_FERRAMENTA").ToString())
            ls.SubItems.Add(objDataReader("OS_POSICAO").ToString())
            ls.SubItems.Add(Convert.ToDateTime(objDataReader("OP_DATA_ENVIADA")).ToString("dd/MM/yyyy"))
            ls.SubItems.Add(objDataReader("OS_REG_RESPONSAVEL").ToString())
            ls.SubItems.Add(objDataReader("OS_SITUACAO").ToString())
            Lista_Request.Items.Add(ls)
        End While
        objDataReader.Close()
        desconectar()
    End Sub

    Private Sub Lista_OP_Click(sender As Object, e As EventArgs) Handles Lista_OP.Click
        If Lista_OP.SelectedItems.Count > 0 Then
            id_OP = Convert.ToInt32(Lista_OP.SelectedItems(0).SubItems(1).Text)
        End If
    End Sub


    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja finalizar esta OS?", "Confirmar finalzação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            conectar()
            comandoSQL.CommandText = "SELECT COUNT(*) AS OP_EM_ANDAMENTO FROM TAB_OS_RELATORIO INNER JOIN TAB_OS_OPERACAO ON OS_ID = OP_ID_OS WHERE OS_ID = '" & COD_FORM & "' AND OP_DATA_FIM IS NULL"
            objDataReader = comandoSQL.ExecuteReader
            If objDataReader.Read() Then
                If objDataReader("OP_EM_ANDAMENTO") = 0 Then
                    Login.Show()
                    tela = 1
                Else
                    MessageBox.Show("Existe operações em andamento.")
                End If
            End If
        End If
    End Sub

    Private Sub txt_op_hr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_op_hr.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso ch <> "." AndAlso Not Char.IsControl(ch) Then
            e.Handled = True
        End If
        If ch = "." AndAlso txt_op_hr.Text.IndexOf(".") <> -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_caixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_caixa.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_qtd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtd.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_secao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_secao.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso ch <> "." AndAlso Not Char.IsControl(ch) Then
            e.Handled = True
        End If
        If ch = "." AndAlso txt_secao.Text.IndexOf(".") <> -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_op_hr_uni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_op_hr_uni.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso ch <> "." AndAlso Not Char.IsControl(ch) Then
            e.Handled = True
        End If
        If ch = "." AndAlso txt_op_hr_uni.Text.IndexOf(".") <> -1 Then
            e.Handled = True
        End If
    End Sub
    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Desenho.Show()
    End Sub

    Public Function ObterDados() As DataTable
        Dim dt = New DataTable()
        dt.Columns.Add("barcode", GetType(Byte()))
        dt.Columns.Add("desc")
        dt.Columns.Add("dt_entrega")
        dt.Columns.Add("op")
        dt.Columns.Add("hr_prev")

        For Each item As ListViewItem In Lista_OP.Items
            Dim barcodeImage As Image = GenerateBarcodeImage(item.SubItems(1).Text)
            dt.Rows.Add(ImageToByteArray(barcodeImage), "Descrição: " & item.SubItems(3).Text, "Data Entrega: " & item.SubItems(4).Text, item.SubItems(2).Text, "Horas Prev.: " & item.SubItems(5).Text)
        Next
        Return dt
    End Function

    Public Function GenerateBarcodeImage(ByVal code As String) As Image
        Using bc As New BarcodeLib.Barcode()
            bc.IncludeLabel = True
            bc.LabelFont = New Font("Arial", 35.0F)
            Return bc.Encode(BarcodeLib.TYPE.CODE128, code)
        End Using
    End Function

    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        Return ms.ToArray()
    End Function

    Private Sub txt_op_hr_TextChanged(sender As Object, e As EventArgs) Handles txt_op_hr.TextChanged
        If Not String.IsNullOrEmpty(txt_op_hr.Text) AndAlso Not String.IsNullOrEmpty(txt_qtd.Text) AndAlso IsNumeric(txt_op_hr.Text) AndAlso IsNumeric(txt_qtd.Text) Then
            Dim opHr As Double = Convert.ToDouble(txt_op_hr.Text)
            Dim qtd As Double = Convert.ToDouble(txt_op_qtd.Text)
            txt_op_hr_uni.Text = (opHr / qtd).ToString()
        Else
            MessageBox.Show("Insira somente numeros.")
            txt_op_hr_uni.Text = 0
        End If
    End Sub

    Private Sub txt_resp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_resp.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_tp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tp.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_op_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_op.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_op_qtd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_op_qtd.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Lista_Request_DoubleClick(sender As Object, e As EventArgs) Handles Lista_Request.DoubleClick
        If Lista_Request.SelectedItems.Count > 0 Then
            id_OS = Convert.ToInt32(Lista_Request.SelectedItems(0).SubItems(1).Text)
            conectar()
            comandoSQL.CommandText = "SELECT TAB_OS_RELATORIO.*, FUN_NOME FROM TAB_OS_RELATORIO INNER JOIN FUNCIONARIO ON OS_REG_RESPONSAVEL = FUN_REGISTRO WHERE OS_ID = '" & id_OS & "'"
            objDataReader = comandoSQL.ExecuteReader
            If objDataReader.Read() Then
                txt_OS.Text = objDataReader("OS_ID").ToString()
                txt_fer.Text = objDataReader("OS_FERRAMENTA").ToString()
                txt_pos.Text = objDataReader("OS_POSICAO").ToString()
                txt_desc.Text = objDataReader("OS_DESCRICAO").ToString()
                txt_tp.Text = objDataReader("OS_TIPO").ToString()
                txt_dt_ent.Text = objDataReader("OS_DATA_ENTREGA").ToString()
                txt_caixa.Text = objDataReader("OS_CAIXA").ToString()
                txt_uni.Text = objDataReader("OS_UNIDADE").ToString()
                txt_qtd.Text = objDataReader("OS_QUANTIDADE").ToString()
                txt_qtd_fim.Text = objDataReader("OS_QUANTIDADE_FINAL").ToString()
                txt_conta.Text = objDataReader("OS_CONTA").ToString()
                txt_sub_conta.Text = objDataReader("OS_SUB_CONTA").ToString()
                txt_secao.Text = objDataReader("OS_SECAO").ToString()
                txt_resp.Text = objDataReader("OS_REG_RESPONSAVEL").ToString() & " - " & objDataReader("FUN_NOME").ToString()
                txt_projeto.Text = objDataReader("OS_PROJETO").ToString()
                txt_situ.Text = objDataReader("OS_SITUACAO").ToString()
                txt_dt_ini.Text = objDataReader("OS_DATA_INICIO").ToString()
                If objDataReader("OS_SITUACAO").ToString() = "ENVIADA" Then
                    Lista_Request.Visible = True
                    btn_salvar.Text = "INICIAR"
                Else
                    Lista_Request.Visible = False
                End If
            Else
                Reset()
            End If
            objDataReader.Close()
            desconectar()
        End If
        COD_FORM = txt_OS.Text
        id_OP = 0
    End Sub

    Private Sub txt_conta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_conta.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso ch <> "." AndAlso Not Char.IsControl(ch) Then
            e.Handled = True
        End If
        If ch = "." AndAlso txt_conta.Text.IndexOf(".") <> -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_sub_conta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sub_conta.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso ch <> "." AndAlso Not Char.IsControl(ch) Then
            e.Handled = True
        End If
        If ch = "." AndAlso txt_sub_conta.Text.IndexOf(".") <> -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_qtd_fim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtd_fim.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class