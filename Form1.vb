Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class Form1
    Private Sub APPLICATION_WORKERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.APPLICATION_WORKERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KP_2024_ProzherinMDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KP_2024_ProzherinMDataSet.WORKERS". При необходимости она может быть перемещена или удалена.
        Me.WORKERSTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.WORKERS)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KP_2024_ProzherinMDataSet.TYPE_OF_WORK". При необходимости она может быть перемещена или удалена.
        Me.TYPE_OF_WORKTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.TYPE_OF_WORK)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KP_2024_ProzherinMDataSet.STATUS". При необходимости она может быть перемещена или удалена.
        Me.STATUSTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.STATUS)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KP_2024_ProzherinMDataSet.SERVICE_REQUEST". При необходимости она может быть перемещена или удалена.
        Me.SERVICE_REQUESTTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.SERVICE_REQUEST)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KP_2024_ProzherinMDataSet.POSTS". При необходимости она может быть перемещена или удалена.
        Me.POSTSTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.POSTS)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KP_2024_ProzherinMDataSet.PERFORMANCE_ASSESSMENT". При необходимости она может быть перемещена или удалена.
        Me.PERFORMANCE_ASSESSMENTTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.PERFORMANCE_ASSESSMENT)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KP_2024_ProzherinMDataSet.CONTROLLER". При необходимости она может быть перемещена или удалена.
        Me.CONTROLLERTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.CONTROLLER)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KP_2024_ProzherinMDataSet.CLIENT". При необходимости она может быть перемещена или удалена.
        Me.CLIENTTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.CLIENT)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KP_2024_ProzherinMDataSet.CATEGORY_OF_WORKS". При необходимости она может быть перемещена или удалена.
        Me.CATEGORY_OF_WORKSTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.CATEGORY_OF_WORKS)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KP_2024_ProzherinMDataSet.APPLICATION_WORKER". При необходимости она может быть перемещена или удалена.
        Me.APPLICATION_WORKERTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.APPLICATION_WORKER)
        FillClientZayavkaLV()

    End Sub
    Public Sub FillClientZayavkaLV()
        Me.CLIENTTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.CLIENT)
        Me.STATUSTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.STATUS)
        Me.SERVICE_REQUESTTableAdapter.Fill(Me.KP_2024_ProzherinMDataSet.SERVICE_REQUEST)
        ClientZayavkaLV.Items.Clear()
        ClientZayavkaLV.Columns.Clear() ' Очистка существующих колонок

        ' Добавление новых колонок
        ClientZayavkaLV.Columns.Add("ID Заявки", 100)
        ClientZayavkaLV.Columns.Add("ФИО Клиента", 150)
        ClientZayavkaLV.Columns.Add("Телефон", 120)
        ClientZayavkaLV.Columns.Add("Email", 100)
        ClientZayavkaLV.Columns.Add("Адрес работы", 150)
        ClientZayavkaLV.Columns.Add("Дата обращения", 120)
        ClientZayavkaLV.Columns.Add("Описание проблемы", 200)
        ClientZayavkaLV.Columns.Add("Статус", 100)
        Dim items(8) As String
        Dim TempRow As DataRow

        For Each Row As DataRow In Me.KP_2024_ProzherinMDataSet.SERVICE_REQUEST.Rows
            TempRow = Row.GetParentRow("CLIENTSERVICE_REQUEST")
            items(2) = TempRow("FIO")
            items(3) = TempRow("Phone_Number")
            items(4) = TempRow("E_mail")
            items(5) = TempRow("Work_address")
            items(6) = Row("Date_appearance")
            items(7) = Row("Problem_description")
            TempRow = Row.GetParentRow("STATUSSERVICE_REQUEST")
            items(8) = TempRow("Status_name")

            ' Создание нового элемента ListView и добавление его в ListView
            Dim it As New ListViewItem()
            it.Text = Row("ID_Application")
            it.SubItems.AddRange(items)
            ClientZayavkaLV.Items.Add(it)
        Next Row
    End Sub

End Class
