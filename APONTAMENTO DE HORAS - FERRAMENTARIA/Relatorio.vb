Imports Microsoft.Office.Interop
Imports Microsoft.ReportingServices.Rendering.ExcelRenderer

Public Class Relatorio

    Private Sub Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consulta()
        txt_op.Items.Add("MP")
        txt_op.Items.Add("TO")
        txt_op.Items.Add("FR1")
        Preencher_maq()
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
    Sub Consulta()
        Dim deferenca_horas As Decimal = 0
        Dim horastotais As Decimal = 0
        conectar()
        comandoSQL.CommandText &= "SELECT OS_ID, OS_FERRAMENTA, OS_POSICAO, OS_SECAO, OS_PROJETO, OS_CONTA, OS_SUB_CONTA, OS_REG_RESPONSAVEL, OS_TIPO, OS_DATA_INICIO, OS_QUANTIDADE, OS_QUANTIDADE_FINAL, OP_ID, OP_NOME_OP, OP_FUNCIONARIO, OP_DATA_INICIO, OP_DATA_FIM, OP_MAQUINA, OP_QUANTIDADE, OP_QUANTIDADE_FINAL, "
        comandoSQL.CommandText &= "DATEDIFF(MINUTE, OP_DATA_INICIO, COALESCE(OP_DATA_FIM, GETDATE())) / 60.0 As HORAS_GERADAS, "
        comandoSQL.CommandText &= "COALESCE(SUM(DATEDIFF(MINUTE, PARADA.PARADA_DATA_INICIO, COALESCE(PARADA.PARADA_DATA_FIM, GETDATE()))), 0) / 60.0 As HORAS_PARADA "
        comandoSQL.CommandText &= "FROM TAB_OS_RELATORIO INNER JOIN TAB_OS_OPERACAO On OS_ID = OP_ID_OS LEFT JOIN TAB_OP_PARADAS PARADA On OP_ID = PARADA.PARADA_ID_OP "
        comandoSQL.CommandText &= "WHERE ('" & txt_fer.Text & "' = '' OR OS_FERRAMENTA LIKE '%" & txt_fer.Text & "%' OR OS_POSICAO LIKE '%" & txt_fer.Text & "%') AND ('" & txt_os.Text & "' = '' OR OS_ID = '" & txt_os.Text & "') AND ('" & txt_fun.Text & "' = '' OR OP_FUNCIONARIO = '" & txt_fun.Text & "') "
        comandoSQL.CommandText &= "AND ('" & txt_data.Text & "' = '  /  /' OR CONVERT(DATE, OP_DATA_INICIO, 103) >= CONVERT(DATE, '" & txt_data.Text & "', 103)) AND ('" & txt_data_fim.Text & "' = '  /  /' OR CONVERT(DATE, OP_DATA_FIM, 103) <= CONVERT(DATE, '" & txt_data_fim.Text & "', 103))"
        comandoSQL.CommandText &= "AND ('" & txt_op.Text & "' = '' OR OP_NOME_OP = '" & txt_op.Text & "')  AND ('" & cbo_maq.Text & "' = '' OR OP_MAQUINA = '" & cbo_maq.Text & "') "
        comandoSQL.CommandText &= "GROUP BY OS_ID, OS_FERRAMENTA, OS_SECAO, OS_PROJETO, OS_CONTA, OS_SUB_CONTA, OS_REG_RESPONSAVEL, OS_TIPO, OS_DATA_INICIO, OS_QUANTIDADE, OS_QUANTIDADE_FINAL, OP_ID, OP_NOME_OP, OP_FUNCIONARIO, OP_DATA_INICIO, OP_DATA_FIM, OP_MAQUINA, OP_QUANTIDADE, OP_QUANTIDADE_FINAL, OS_POSICAO;"
        objDataReader = comandoSQL.ExecuteReader
        Lista_OS.Clear()
        Lista_OS.View = View.Details
        Lista_OS.Columns.Add("ID ORDEM", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("FERRAMENTA", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("POSIÇÃO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("PROJETO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("SEÇÃO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("CONTA", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("SUB_CONTA", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("REG_RESPONSAVEL", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("TIPO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("DATA INICIO/ORDEM", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("QUANTIDADE/ORDEM", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("QUANTIDADE FINAL/ORDEM", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("ID OPERAÇÃO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("NOME OPERAÇÃO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("FUNCIONÁRIO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("DATA INICIO/OPERAÇÃO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("MAQUINA", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("QUANTIDADE/OPERAÇÃO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("QUANTIDADE FINAL/OPERAÇÃO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("DATA FIM/OPERAÇÃO", 60, HorizontalAlignment.Center)
        Lista_OS.Columns.Add("HORAS TOTAIS", 60, HorizontalAlignment.Center)
        While objDataReader.Read()
            Dim horas_geradas As Decimal = If(objDataReader("HORAS_GERADAS") IsNot DBNull.Value, Convert.ToDecimal(objDataReader("HORAS_GERADAS")), 0)
            Dim horas_parada As Decimal = If(objDataReader("HORAS_PARADA") IsNot DBNull.Value, Convert.ToDecimal(objDataReader("HORAS_PARADA")), 0)
            deferenca_horas = Math.Round(horas_geradas - horas_parada, 2)
            horastotais = Math.Round(horastotais + deferenca_horas, 2)
            Dim ls As New ListViewItem(objDataReader("OS_ID").ToString())
            ls.SubItems.Add(objDataReader("OS_FERRAMENTA").ToString())
            ls.SubItems.Add(objDataReader("OS_POSICAO").ToString())
            ls.SubItems.Add(objDataReader("OS_PROJETO").ToString())
            ls.SubItems.Add(objDataReader("OS_SECAO").ToString())
            ls.SubItems.Add(objDataReader("OS_CONTA").ToString())
            ls.SubItems.Add(objDataReader("OS_SUB_CONTA").ToString())
            ls.SubItems.Add(objDataReader("OS_REG_RESPONSAVEL").ToString())
            ls.SubItems.Add(objDataReader("OS_TIPO").ToString())
            ls.SubItems.Add(objDataReader("OS_DATA_INICIO").ToString())
            ls.SubItems.Add(objDataReader("OS_QUANTIDADE").ToString())
            ls.SubItems.Add(objDataReader("OS_QUANTIDADE_FINAL").ToString())
            ls.SubItems.Add(objDataReader("OP_ID").ToString())
            ls.SubItems.Add(objDataReader("OP_NOME_OP").ToString())
            ls.SubItems.Add(objDataReader("OP_FUNCIONARIO").ToString())
            ls.SubItems.Add(objDataReader("OP_DATA_INICIO").ToString())
            ls.SubItems.Add(objDataReader("OP_MAQUINA").ToString())
            ls.SubItems.Add(objDataReader("OP_QUANTIDADE").ToString())
            ls.SubItems.Add(objDataReader("OP_QUANTIDADE_FINAL").ToString())
            ls.SubItems.Add(objDataReader("OP_DATA_FIM").ToString())
            ls.SubItems.Add(deferenca_horas)
            Lista_OS.Items.Add(ls)
            txt_horas_totais.Text = horastotais
        End While
        objDataReader.Close()
        desconectar()
    End Sub



    Private Sub txt_data_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_data.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            Consulta()
        End If
    End Sub

    Private Sub txt_os_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_os.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_op_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_op.SelectedIndexChanged
        Consulta()
    End Sub

    Private Sub txt_op_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_op.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Consulta()
        End If
    End Sub

    Private Sub cbo_maq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_maq.SelectedIndexChanged
        Consulta()
    End Sub

    Private Sub cbo_maq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_maq.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Consulta()
        End If
    End Sub

    Private Sub btn_os_Click(sender As Object, e As EventArgs) Handles btn_os.Click
        ExportToExcel()
    End Sub

    Private Sub ExportToExcel()
        If Lista_OS.Items.Count = 0 Then
            MessageBox.Show("Sem dados para exportar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim excelApp As New Excel.Application()
            excelApp.Visible = True
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
            Dim worksheet As Excel.Worksheet = workbook.ActiveSheet
            Dim headerIndex As Integer = 1
            For Each column As ColumnHeader In Lista_OS.Columns
                worksheet.Cells(1, headerIndex) = column.Text
                worksheet.Cells(1, headerIndex).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                headerIndex += 1
            Next
            Dim rowIndex As Integer = 2
            For Each item As ListViewItem In Lista_OS.Items
                Dim columnIndex As Integer = 1
                For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                    worksheet.Cells(rowIndex, columnIndex) = subItem.Text
                    worksheet.Cells(rowIndex, columnIndex).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    columnIndex += 1
                Next
                rowIndex += 1
            Next
            worksheet.UsedRange.Columns.AutoFit()
            Dim filePath As String = "Ordem de Serviço " & DateTime.Now.ToString("dd-MM-yyyy HH-mm") & ".xlsx"
            workbook.SaveAs(filePath)
            MessageBox.Show("Documento gerado na pasta Documentos", "Document", MessageBoxButtons.OK, MessageBoxIcon.Information)
            workbook.Close()
            excelApp.Quit()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub txt_limpar_Click(sender As Object, e As EventArgs) Handles txt_limpar.Click
        txt_op.Text = ""
        txt_fun.Text = ""
        txt_fer.Text = ""
        txt_data.Text = ""
        txt_os.Text = ""
        cbo_maq.Text = ""
        Consulta()
    End Sub

    Private Sub txt_fer_TextChanged(sender As Object, e As EventArgs) Handles txt_fer.TextChanged
        Consulta()
    End Sub

    Private Sub txt_fun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fun.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            Consulta()
        End If
    End Sub

    Private Sub txt_os_TextChanged(sender As Object, e As EventArgs) Handles txt_os.TextChanged
        Consulta()
    End Sub

    Private Sub txt_data_fim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_data_fim.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            Consulta()
        End If
    End Sub
End Class