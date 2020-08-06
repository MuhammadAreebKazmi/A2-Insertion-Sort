Module Module1

    Sub Main()
        'Insertion Sort
        Const NumberOfItems As Integer = 6
        Dim List(6) As Integer
        Dim Pointer, ItemToBeInserted, CurrentItem As Integer
        List(1) = 53
        List(2) = 21
        List(3) = 60
        List(4) = 18
        List(5) = 42
        List(6) = 19

        For Pointer = 1 To NumberOfItems
            ItemToBeInserted = List(Pointer)
            CurrentItem = Pointer - 1 'pointer to last item in sorted part of list
            While (List(CurrentItem) > ItemToBeInserted) And (CurrentItem > 0)
                List(CurrentItem + 1) = List(CurrentItem) 'move current item down
                CurrentItem = CurrentItem - 1 'look at the item above
            End While
            List(CurrentItem + 1) = ItemToBeInserted 'insert item
        Next

        For Pointer = 1 To 6
            Console.WriteLine("Index is: " & Pointer & " value is: " & List(Pointer))
        Next
        Console.ReadKey()
    End Sub

End Module
