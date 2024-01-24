Public Class Login

    Private Sub txtcodin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Verifica = 0
            conectar()
            comandoSQL.CommandText = "SELECT FUN_REGISTRO, FUN_NOME FROM FUNCIONARIO WHERE FUN_STATUS = 'ATIVO' AND (FUN_CODIN = '" & txtcodin.Text & "' or FUN_REGISTRO = '" & txtcodin.Text & "') AND FUN_CODIN >  '1'"
            objDataReader = comandoSQL.ExecuteReader
            If objDataReader.Read Then
                User = objDataReader("FUN_REGISTRO")
                UserName = objDataReader("FUN_NOME")
                If objDataReader("FUN_REGISTRO") <> 0 Then
                    Verifica = 1
                End If
            End If
            desconectar()
            Close()
            If tela = 2 Then
                If Verifica = 1 Then
                    Servico.Enabled = True
                    MessageBox.Show("Bem-Vindo(a) " & UserName & " ")
                Else
                    Servico.Enabled = False
                    Servico.Close()
                    MessageBox.Show("Funcionário não encontrado!")
                End If
            End If

            If tela = 1 Then
                If User = 343 Or User = 48 Or User = 2461 Or User = 3216 Or User = 901430 Then
                    Try
                        conectar()
                        comandoSQL.CommandText = "UPDATE TAB_OS_RELATORIO SET OS_DATA_FIM = '" & DateTime.Now & "', OS_SITUACAO = 'FINALIZADA' WHERE OS_ID = '" & Ordem.COD_FORM & "'"
                        comandoSQL.ExecuteNonQuery()
                        desconectar()
                        MessageBox.Show("Finalização bem-sucedida.")
                        Ordem.Close()
                        Tela_Inicial.Lista()
                    Catch ex As Exception
                        MessageBox.Show("Ocorreu um erro: " & ex.Message)
                    End Try
                Else
                    MessageBox.Show("Funcionário sem permissão.")
                End If
            ElseIf tela = 3 Then
                Ordem.situacao = "EM ANDAMENTO"
                If User = 343 Or User = 48 Or User = 2461 Or User = 3216 Or User = 901430 Then
                    Try
                        conectar()
                        comandoSQL.CommandText = "UPDATE TAB_OS_RELATORIO SET OS_FERRAMENTA = '" & Ordem.txt_fer.Text & "', OS_POSICAO = '" & Ordem.txt_pos.Text & "', OS_DESCRICAO = '" & Ordem.txt_desc.Text & "', OS_PROJETO = '" & Ordem.txt_projeto.Text & "', "
                        comandoSQL.CommandText &= "OS_DATA_ENTREGA = '" & Ordem.txt_dt_ent.Text & "', OS_CAIXA = '" & Ordem.txt_caixa.Text & "', OS_UNIDADE = '" & Ordem.txt_uni.Text & "', OS_TIPO = '" & Ordem.txt_tp.Text & "', OS_QUANTIDADE = '" & Ordem.txt_qtd.Text & "', OS_QUANTIDADE_FINAL = '" & Ordem.txt_qtd_fim.Text & "', "
                        comandoSQL.CommandText &= "OS_CONTA = '" & Ordem.txt_conta.Text & "',OS_SUB_CONTA = '" & Ordem.txt_sub_conta.Text & "',OS_SECAO = '" & Ordem.txt_secao.Text & "',OS_REG_RESPONSAVEL= '" & Ordem.REGISTRO & "', OS_SITUACAO = '" & Ordem.situacao & "', OS_DATA_INICIO = '" & DateTime.Now & "' WHERE OS_ID = '" & Ordem.COD_FORM & "'"
                        comandoSQL.ExecuteNonQuery()
                        desconectar()
                        Ordem.Lista_Request.Visible = False
                        Ordem.txt_situ.Text = Ordem.situacao
                        Ordem.btn_salvar.Text = "SALVAR"
                        Tela_Inicial.Lista()
                        MessageBox.Show("Ordem iniciada.")
                    Catch ex As Exception
                        MessageBox.Show("Ocorreu um erro: " & ex.Message)
                    End Try
                Else
                    MessageBox.Show("Funcionário sem permissão.")
                End If
            End If
        End If
    End Sub
End Class
