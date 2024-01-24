Imports System.Data.SqlClient

Public Class Servico

    Private Sub Servico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        i = 0
        While i < 24
            cbo_horai1.Items.Add(i.ToString("00"))
            i = i + 1
        End While

        i = 0
        While i < 60
            cbo_horai2.Items.Add(i.ToString("00"))
            i = i + 1
        End While

        i = 0
        While i < 24
            cbo_horaf1.Items.Add(i.ToString("00"))
            i = i + 1
        End While

        i = 0
        While i < 60
            cbo_horaf2.Items.Add(i.ToString("00"))
            i = i + 1
        End While
        Preencher_maq()
        btn_iniciar.Enabled = False
        btn_parar.Enabled = False
        btn_fim.Enabled = False
        cb_manual.Enabled = False
        cbo_maq.Enabled = False
        txt_qtd.Enabled = False
        id_OP = 0
    End Sub

    Sub Preencher_maq()
        conectar()
        comandoSQL.CommandText = "SELECT * FROM TAB_OS_MAQUINA"
        objDataReader = comandoSQL.ExecuteReader
        While objDataReader.Read
            cbo_maq.Items.Add(objDataReader("MAQ_ABREVIACAO") & "-" & objDataReader("MAQ_NOME"))
        End While
        desconectar()
    End Sub

    Private Sub cb_manual_CheckedChanged(sender As Object, e As EventArgs) Handles cb_manual.CheckedChanged
        If cb_manual.Checked Then
            cbo_horai1.Enabled = True
            cbo_horai2.Enabled = True
            cbo_horaf1.Enabled = True
            cbo_horaf2.Enabled = True
            cbo_dataf.Enabled = True
            cbo_datai.Enabled = True
            btn_iniciar.Enabled = False
            btn_fim.Enabled = True
            txt_qtd.Enabled = True
        Else
            cbo_horai1.Enabled = False
            cbo_horai2.Enabled = False
            cbo_horaf1.Enabled = False
            cbo_horaf2.Enabled = False
            cbo_dataf.Enabled = False
            cbo_datai.Enabled = False
            btn_iniciar.Enabled = True
            btn_fim.Enabled = False
            txt_qtd.Enabled = False
        End If
    End Sub

    Sub Lista()
        conectar()
        comandoSQL.CommandText = "SELECT * FROM TAB_OS_OPERACAO WHERE OP_ID = '" & id_OP & "'"
        objDataReader = comandoSQL.ExecuteReader
        Lista_OP.Clear()
        Lista_OP.View = View.Details
        Lista_OP.Columns.Add("", 0, HorizontalAlignment.Left)
        Lista_OP.Columns.Add("ID", 40, HorizontalAlignment.Center)
        Lista_OP.Columns.Add("OPERAÇÃO", 70, HorizontalAlignment.Center)
        Lista_OP.Columns.Add("ENTREGA", 80, HorizontalAlignment.Center)
        Lista_OP.Columns.Add("HORAS PREV.", 100, HorizontalAlignment.Center)
        Lista_OP.Columns.Add("HORAS PREV. UNI.", 100, HorizontalAlignment.Center)
        If objDataReader.Read() Then
            Dim ls As New ListViewItem("", 0)
            ls.SubItems.Add(objDataReader("OP_ID").ToString())
            ls.SubItems.Add(objDataReader("OP_NOME_OP").ToString())
            ls.SubItems.Add(Convert.ToDateTime(objDataReader("OP_DATA_ENTREGA")).ToString("dd/MM/yyyy"))
            ls.SubItems.Add(objDataReader("OP_HORAS_PREV").ToString())
            ls.SubItems.Add(objDataReader("OP_HORAS_PREV_UNIT").ToString())
            Lista_OP.Items.Add(ls)
            cbo_maq.Text = objDataReader("OP_MAQUINA").ToString()
        End If
        objDataReader.Close()
        desconectar()
    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        If cbo_maq.Text = "" Then
            MessageBox.Show("Selecione a máquina.")
            Return
        End If
        If txt_caixa.Text = "0" Then
            MessageBox.Show("Selecione a caixa.")
            Return
        End If
        If btn_iniciar.Text = "RETOMAR" Then
            Dim dataf As Date = Date.Parse(cbo_dataf.Text & " " & cbo_horaf1.Text & " : " & cbo_horaf2.Text & " : 00")
            Try
                conectar()
                objDataReader.Close()
                comandoSQL.CommandText = "INSERT INTO TAB_OP_PARADAS (PARADA_ID_OP, PARADA_DATA_INICIO, PARADA_DATA_FIM, PARADA_MOTIVO) VALUES ('" & id_OP & "', '" & dataf & "', '" & DateTime.Now & "', 'RETOMADA')"
                comandoSQL.ExecuteReader()
                desconectar()

                conectar()
                objDataReader.Close()
                comandoSQL.CommandText = "UPDATE TAB_OS_OPERACAO SET OP_DATA_FIM = NULL WHERE OP_ID = '" & id_OP & "'"
                comandoSQL.ExecuteReader()
                desconectar()
                MessageBox.Show("Operação retomada.")
                btn_iniciar.Enabled = False
                btn_parar.Enabled = True
                btn_fim.Enabled = True
                txt_qtd.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        Else
            Try
                conectar()
                comandoSQL.CommandText = "UPDATE TAB_OS_OPERACAO SET OP_FUNCIONARIO = @User, OP_MAQUINA = @Maquina, OP_DATA_INICIO = @DataInicio WHERE OP_ID = @OpID"
                comandoSQL.Parameters.AddWithValue("@User", User)
                comandoSQL.Parameters.AddWithValue("@Maquina", cbo_maq.Text)
                comandoSQL.Parameters.AddWithValue("@DataInicio", DateTime.Now)
                comandoSQL.Parameters.AddWithValue("@OpID", id_OP)
                comandoSQL.ExecuteNonQuery()
                desconectar()
                btn_iniciar.Enabled = False
                btn_parar.Enabled = True
                txt_qtd.Enabled = True
                btn_fim.Enabled = True
                cb_manual.Enabled = False
                cbo_maq.Enabled = True
                MessageBox.Show("Operação iniciada.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
            Try
                conectar()
                comandoSQL.CommandText = "UPDATE TAB_OS_RELATORIO SET OS_CAIXA = @Caixa WHERE OS_ID = @OsID"
                comandoSQL.Parameters.AddWithValue("@Caixa", txt_caixa.Text)
                comandoSQL.Parameters.AddWithValue("@OsID", id_OS)
                comandoSQL.ExecuteNonQuery()
                desconectar()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_fim_Click(sender As Object, e As EventArgs) Handles btn_fim.Click
        If cbo_maq.Text = "" Then
            MessageBox.Show("Máquina não preenchida.")
            Return
        End If
        If txt_qtd.Text = "" Then
            MessageBox.Show("Quantidade não preenchida.")
            Return
        End If
        Dim result As DialogResult = MessageBox.Show("Tem certeza que deseja finalizar esta operação?", "Confirmar finalzação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If cb_manual.Checked Then
                If cbo_datai.Text = "" Or cbo_dataf.Text = "" Or cbo_horai1.Text = "" Or cbo_horaf1.Text = "" Or cbo_horai2.Text = "" Or cbo_horaf2.Text = "" Then
                    MessageBox.Show("Data não preenchida.")
                    Return
                End If
                If txt_qtd.Text = "0" Then
                    MessageBox.Show("Caixa não preenchida.")
                    Return
                End If

                Dim datai As Date = Date.Parse(cbo_datai.Text & " " & cbo_horai1.Text & " : " & cbo_horai2.Text & " : 00")
                Dim dataf As Date = Date.Parse(cbo_dataf.Text & " " & cbo_horaf1.Text & " : " & cbo_horaf2.Text & " : 00")
                Try
                    conectar()
                    comandoSQL.CommandText = "UPDATE TAB_OS_OPERACAO SET OP_FUNCIONARIO = @User, OP_MAQUINA = @Maquina, OP_QUANTIDADE_FINAL = @qtd, OP_DATA_INICIO = @DataInicio, OP_DATA_FIM = @DataFim WHERE OP_ID = @OpID"
                    comandoSQL.Parameters.AddWithValue("@User", User)
                    comandoSQL.Parameters.AddWithValue("@Maquina", cbo_maq.Text)
                    comandoSQL.Parameters.AddWithValue("@qtd", txt_qtd.Text)
                    comandoSQL.Parameters.AddWithValue("@DataInicio", datai)
                    comandoSQL.Parameters.AddWithValue("@DataFim", dataf)
                    comandoSQL.Parameters.AddWithValue("@OpID", id_OP)
                    comandoSQL.ExecuteNonQuery()
                    desconectar()
                    MessageBox.Show("Operação finalizada.")
                    btn_parar.Enabled = False
                    btn_fim.Enabled = False
                    txt_qtd.Enabled = False
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro: " & ex.Message)
                End Try
                Try
                    conectar()
                    comandoSQL.CommandText = "UPDATE TAB_OS_RELATORIO SET OS_CAIXA = @Caixa WHERE OS_ID = @OsID"
                    comandoSQL.Parameters.AddWithValue("@Caixa", txt_caixa.Text)
                    comandoSQL.Parameters.AddWithValue("@OsID", id_OS)
                    comandoSQL.ExecuteNonQuery()
                    desconectar()
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro: " & ex.Message)
                End Try
            Else
                Try
                    conectar()
                    comandoSQL.CommandText = "UPDATE TAB_OS_OPERACAO SET OP_FUNCIONARIO = @User, OP_MAQUINA = @Maquina, OP_QUANTIDADE_FINAL = @qtd, OP_DATA_FIM = @DataFim WHERE OP_ID = @OpID"
                    comandoSQL.Parameters.AddWithValue("@User", User)
                    comandoSQL.Parameters.AddWithValue("@Maquina", cbo_maq.Text)
                    comandoSQL.Parameters.AddWithValue("@qtd", txt_qtd.Text)
                    comandoSQL.Parameters.AddWithValue("@DataFim", DateTime.Now)
                    comandoSQL.Parameters.AddWithValue("@OpID", id_OP)
                    comandoSQL.ExecuteNonQuery()
                    desconectar()
                    MessageBox.Show("Operação finalizada.")
                    btn_parar.Enabled = False
                    btn_fim.Enabled = False
                    txt_qtd.Enabled = False
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro: " & ex.Message)
                End Try
            End If
            Close()
        End If
    End Sub

    Private Sub btn_parar_Click(sender As Object, e As EventArgs) Handles btn_parar.Click
        If btn_parar.Text = "PARAR" Then
            Parada.Show()
        Else
            Dim ultima_parada As Integer
            Try
                conectar()
                objDataReader.Close()
                comandoSQL.CommandText = "SELECT TOP 1 * FROM TAB_OP_PARADAS WHERE PARADA_ID_OP = '" & id_OP & "' ORDER BY PARADA_DATA_INICIO DESC;"
                objDataReader = comandoSQL.ExecuteReader
                If objDataReader.Read Then
                    ultima_parada = objDataReader("PARADA_ID")
                End If
                desconectar()

                conectar()
                objDataReader.Close()
                comandoSQL.CommandText = "UPDATE TAB_OP_PARADAS SET PARADA_DATA_FIM = '" & DateTime.Now & "' WHERE PARADA_ID = '" & ultima_parada & "'"
                comandoSQL.ExecuteReader()
                desconectar()
                btn_iniciar.Enabled = False
                btn_parar.Enabled = True
                btn_parar.Text = "PARAR"
                btn_fim.Enabled = True
                txt_qtd.Enabled = True
                MessageBox.Show("Operação retomada.")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub txt_op_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_op.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            id_OP = txt_op.Text
            conectar()
            comandoSQL.CommandText = "SELECT TOP 1 OP_ID, OP_ID_OS, OP_NOME_OP, OP_MAQUINA, OP_QUANTIDADE_FINAL, OS_DATA_FIM, OP_DATA_INICIO, OP_DATA_FIM, OP_DATA_FIM,PARADA_ID, PARADA_DATA_INICIO, PARADA_DATA_FIM, OS_CAIXA FROM TAB_OS_OPERACAO INNER JOIN TAB_OS_RELATORIO ON OP_ID_OS = OS_ID LEFT JOIN TAB_OP_PARADAS ON OP_ID = PARADA_ID_OP WHERE OP_ID = '" & id_OP & "' ORDER BY PARADA_ID DESC"
            objDataReader = comandoSQL.ExecuteReader
            If objDataReader.Read Then
                id_OS = objDataReader("OP_ID_OS")
                txt_qtd.Text = objDataReader("OP_QUANTIDADE_FINAL").ToString
                txt_caixa.Text = objDataReader("OS_CAIXA").ToString
                If objDataReader("OS_DATA_FIM") IsNot DBNull.Value OrElse objDataReader("OS_DATA_FIM") Is Nothing Then
                    Lista()
                    btn_iniciar.Enabled = False
                    btn_parar.Enabled = False
                    btn_fim.Enabled = False
                    txt_qtd.Enabled = False
                    cb_manual.Enabled = False
                    cbo_maq.Enabled = False
                    MessageBox.Show("OS já finalizada.")
                    Return
                Else
                    If Not objDataReader.IsDBNull(objDataReader.GetOrdinal("OP_DATA_INICIO")) And Not objDataReader.IsDBNull(objDataReader.GetOrdinal("OP_DATA_FIM")) Then
                        MessageBox.Show("Operação finalizada")
                        btn_iniciar.Enabled = True
                        btn_iniciar.Text = "RETOMAR"
                        btn_parar.Enabled = False
                        btn_fim.Enabled = False
                        txt_qtd.Enabled = False
                        cb_manual.Enabled = False
                        cbo_maq.Enabled = False
                    ElseIf Not objDataReader.IsDBNull(objDataReader.GetOrdinal("PARADA_DATA_INICIO")) And objDataReader.IsDBNull(objDataReader.GetOrdinal("PARADA_DATA_FIM")) Then
                        btn_iniciar.Enabled = False
                        btn_parar.Enabled = True
                        btn_parar.Text = "RETOMAR"
                        btn_fim.Enabled = False
                        txt_qtd.Enabled = False
                        cb_manual.Enabled = False
                        cbo_maq.Enabled = True
                    ElseIf Not objDataReader.IsDBNull(objDataReader.GetOrdinal("OP_DATA_INICIO")) And objDataReader.IsDBNull(objDataReader.GetOrdinal("OP_DATA_FIM")) Then
                        btn_iniciar.Enabled = False
                        btn_parar.Enabled = True
                        btn_fim.Enabled = True
                        txt_qtd.Enabled = True
                        cb_manual.Enabled = False
                        cbo_maq.Enabled = True
                    ElseIf objDataReader.IsDBNull(objDataReader.GetOrdinal("OP_DATA_INICIO")) And objDataReader.IsDBNull(objDataReader.GetOrdinal("OP_DATA_FIM")) Then
                        btn_iniciar.Enabled = True
                        btn_parar.Enabled = False
                        btn_fim.Enabled = False
                        txt_qtd.Enabled = False
                        cb_manual.Enabled = True
                        cbo_maq.Enabled = True
                    End If
                End If
                If Not objDataReader("OP_MAQUINA") Is DBNull.Value Then
                    cbo_maq.Text = objDataReader("OP_MAQUINA").ToString()
                End If

                If Not objDataReader("OP_DATA_INICIO") Is DBNull.Value Then
                    cbo_datai.Text = CType(objDataReader("OP_DATA_INICIO"), DateTime).ToString("dd/MM/yyyy")
                    cbo_horai1.Text = CType(objDataReader("OP_DATA_INICIO"), DateTime).ToString("HH")
                    cbo_horai2.Text = CType(objDataReader("OP_DATA_INICIO"), DateTime).ToString("mm")
                End If

                If Not objDataReader("OP_DATA_FIM") Is DBNull.Value Then
                    cbo_dataf.Text = CType(objDataReader("OP_DATA_FIM"), DateTime).ToString("dd/MM/yyyy")
                    cbo_horaf1.Text = CType(objDataReader("OP_DATA_FIM"), DateTime).ToString("HH")
                    cbo_horaf2.Text = CType(objDataReader("OP_DATA_FIM"), DateTime).ToString("mm")
                End If
                Lista()
            Else
                btn_iniciar.Enabled = False
                btn_parar.Enabled = False
                btn_fim.Enabled = False
                txt_qtd.Enabled = False
                Lista_OP.Clear()
                MessageBox.Show("Operação não encontrada")
            End If
            objDataReader.Close()
            desconectar()
        End If
    End Sub

    Private Sub txt_caixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_caixa.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class