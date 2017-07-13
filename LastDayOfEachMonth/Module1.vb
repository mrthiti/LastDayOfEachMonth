Module Module1

    Sub Main()
        Dim year = 2017
        Dim arrayLastDay = getLastDayOfAllMunth(year)

        Console.WriteLine("Last day of each month in year " & year)

        For i As Integer = 0 To arrayLastDay.Length - 1
            Console.WriteLine(arrayLastDay(i))
        Next

        Console.ReadKey()
    End Sub

    Function getLastDayOfAllMunth(ByVal year As Long) As String()
        Dim thisYear = New DateTime(year, 1, 1)
        Dim lastDayOfAllMonth(11) As String

        For i As Integer = 0 To lastDayOfAllMonth.Length - 1
            lastDayOfAllMonth(i) = thisYear.AddMonths(i + 1).AddDays(-1).ToString("dd/MM/yyyy")
        Next

        Return lastDayOfAllMonth
    End Function

End Module
