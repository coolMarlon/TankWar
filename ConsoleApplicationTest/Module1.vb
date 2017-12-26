Imports System.IO
Imports System.Threading

Module Module1

    Sub Main()
        Dim al As ArrayList = New ArrayList()
        Dim i As Integer
        Console.WriteLine("Adding some numbers:")
        al.Add(45)
        al.Add(78)
        al.Add(33)
        al.Add(56)
        al.Add(12)
        al.Add(23)
        al.Add(9)
        Console.WriteLine("Capacity: {0} ", al.Capacity)
        Console.WriteLine("Count: {0}", al.Count)
        Console.Write("Content: ")
        For Each i In al
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        Console.Write("Sorted Content: ")
        al.Sort()
        For Each i In al
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        Console.ReadKey()
    End Sub
End Module

