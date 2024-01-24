Public Class Tela_Inicial
    Private Sub Tela_Inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lista()
    End Sub
    Private Sub btn_os_Click(sender As Object, e As EventArgs) Handles btn_os.Click
        id_OS = 0
        Ordem.Show()
        Ordem.btn_salvar.Text = "ENVIAR"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_servico.Click
        Servico.Show()
        tela = 2
        Login.Show()
    End Sub

    Private Sub btn_maq_Click(sender As Object, e As EventArgs) Handles btn_maq.Click
        Maquina.Show()
    End Sub

    Sub Lista()
        conectar()
        comandoSQL.CommandText = "WITH UltimaOperacao AS (SELECT *,ROW_NUMBER() OVER (PARTITION BY OP_ID_OS ORDER BY OP_DATA_INICIO DESC) AS Ordem FROM TAB_OS_OPERACAO) "
        comandoSQL.CommandText &= "SELECT R.*, UOP.* FROM TAB_OS_RELATORIO R LEFT JOIN UltimaOperacao UOP ON R.OS_ID = UOP.OP_ID_OS AND UOP.Ordem = 1 "
        comandoSQL.CommandText &= "WHERE ('" & txt_fer.Text & "' = '' OR R.OS_FERRAMENTA LIKE '%" & txt_fer.Text & "%' OR R.OS_POSICAO LIKE '%" & txt_fer.Text & "%') AND R.OS_SITUACAO = 'EM ANDAMENTO' ORDER BY OS_ID;"
        objDataReader = comandoSQL.ExecuteReader
        Lista_OS.Clear()
        Lista_OS.View = View.Details
        Lista_OS.Columns.Add("", 0, HorizontalAlignment.Left)
        Lista_OS.Columns.Add("OS", 50, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("FERRAMENTA", 151, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("POSIÇÃO", 151, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("INÍCIO", 100, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("RESPONSAVEL", 138, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("SITUAÇÃO", 153, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("OPERAÇÃO", 110, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("LOCAL", 132, HorizontalAlignment.Center)
        While objDataReader.Read()
            Dim ls As New ListViewItem("", 0)
            ls.SubItems.Add(objDataReader("OS_ID").ToString())
            ls.SubItems.Add(objDataReader("OS_FERRAMENTA").ToString())
            ls.SubItems.Add(objDataReader("OS_POSICAO").ToString())
            ls.SubItems.Add(Convert.ToDateTime(objDataReader("OS_DATA_INICIO")).ToString("dd/MM/yyyy"))
            ls.SubItems.Add(objDataReader("OS_REG_RESPONSAVEL").ToString())
            ls.SubItems.Add(objDataReader("OS_SITUACAO").ToString())

            If objDataReader("OP_NOME_OP") IsNot DBNull.Value Then
                ls.SubItems.Add(objDataReader("OP_NOME_OP").ToString())
            Else
                ls.SubItems.Add("SEM OP")
            End If

            If objDataReader("OP_MAQUINA") IsNot DBNull.Value Then
                ls.SubItems.Add(objDataReader("OP_MAQUINA").ToString())
            Else
                ls.SubItems.Add("SEM OP")
            End If

            Lista_OS.Items.Add(ls)
        End While
        objDataReader.Close()
        desconectar()
    End Sub

    Private Sub Lista_OS_DoubleClick(sender As Object, e As EventArgs) Handles Lista_OS.DoubleClick
        If Lista_OS.SelectedItems.Count > 0 Then
            id_OS = Convert.ToInt32(Lista_OS.SelectedItems(0).SubItems(1).Text)
            conectar()
            comandoSQL.CommandText = "SELECT TAB_OS_RELATORIO.*, FUN_NOME FROM TAB_OS_RELATORIO INNER JOIN FUNCIONARIO ON OS_REG_RESPONSAVEL = FUN_REGISTRO WHERE OS_ID = '" & id_OS & "'"
            objDataReader = comandoSQL.ExecuteReader
            If objDataReader.Read() Then
                Ordem.txt_OS.Text = objDataReader("OS_ID").ToString()
                Ordem.txt_fer.Text = objDataReader("OS_FERRAMENTA").ToString()
                Ordem.txt_pos.Text = objDataReader("OS_POSICAO").ToString()
                Ordem.txt_desc.Text = objDataReader("OS_DESCRICAO").ToString()
                Ordem.txt_tp.Text = objDataReader("OS_TIPO").ToString()
                Ordem.txt_dt_ent.Text = objDataReader("OS_DATA_ENTREGA").ToString()
                Ordem.txt_caixa.Text = objDataReader("OS_CAIXA").ToString()
                Ordem.txt_uni.Text = objDataReader("OS_UNIDADE").ToString()
                Ordem.txt_qtd.Text = objDataReader("OS_QUANTIDADE").ToString()
                Ordem.txt_conta.Text = objDataReader("OS_CONTA").ToString()
                Ordem.txt_sub_conta.Text = objDataReader("OS_SUB_CONTA").ToString()
                Ordem.txt_secao.Text = objDataReader("OS_SECAO").ToString()
                Ordem.txt_resp.Text = objDataReader("OS_REG_RESPONSAVEL").ToString() & " - " & objDataReader("FUN_NOME").ToString()
                Ordem.txt_projeto.Text = objDataReader("OS_PROJETO").ToString()
                Ordem.txt_situ.Text = objDataReader("OS_SITUACAO").ToString()
                Ordem.txt_dt_ini.Text = objDataReader("OS_DATA_INICIO").ToString()
                If objDataReader("OS_SITUACAO").ToString() = "ENVIADA" Then
                    Ordem.Lista_Request.Visible = True
                    Ordem.btn_salvar.Text = "INICIAR"
                Else
                    Ordem.Lista_Request.Visible = False
                End If
            Else
                Reset()
            End If
            objDataReader.Close()
            desconectar()
        End If
        id_OP = 0
        Ordem.Show()
    End Sub

    Private Sub btn_relatorio_Click(sender As Object, e As EventArgs) Handles btn_relatorio.Click
        Relatorio.Show()
    End Sub

    Private Sub txt_os_TextChanged(sender As Object, e As EventArgs) Handles txt_fer.TextChanged
        Lista()
    End Sub

    Private Sub btn_pesquisa_Click(sender As Object, e As EventArgs)
        Lista()
    End Sub
End Class