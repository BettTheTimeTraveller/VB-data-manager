Public Class Form1
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click

        'Trim() deletes trailing white space in the textbox
        If licenceTxt.Text.Trim() IsNot "" And IsNumeric(licenceTxt.Text.Trim()) And ownernameTxt.Text.Trim() IsNot "" And ownerphoneTxt.Text.Trim() IsNot "" Then

            'CHECK THE SIZE OF THE DATABASE

            'open the text file db.txt using file reader as below
            Dim reader As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("db.txt")
            Dim data As String

            'loop through all the lines in the file exit when all data has been read
            Dim i As Integer = 0
            Do
                'read line text and save it to data variable
                data = reader.ReadLine
                If Not String.IsNullOrWhiteSpace(data) Then
                    'increment i to keep track of number of lines in db.txt
                    i += 1
                End If
            Loop Until data Is Nothing
            reader.Close()

            'ADDING DATA
            'allow adding of data if the lines are less or equals to 100
            If i <= 100 Then
                'check if the licence is in db.txt by calling the sub method InDB written below
                If Not Me.InDb(licenceTxt.Text.Trim()) Then
                    'Open the data.txt file using stream reader
                    Dim file As IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter("db.txt", True)
                    'write data to file each  set of data one line separated by commas i.e licence number,owner name,owner phone number
                    file.WriteLine(licenceTxt.Text.Trim() + "," + ownernameTxt.Text.Trim() + "," + ownerphoneTxt.Text.Trim())
                    'close file
                    file.Close()

                    'call loadData sub written below to reload data to the listbox
                    Me.loadData()
                    MessageBox.Show("Successfully Added")
                Else
                    MsgBox("Not Added Already EXISTS IN DB")
                End If

            Else
                MessageBox.Show("Not Added Database full")
            End If

        Else
            MessageBox.Show("Not Added Fill all fields with correct data. Licence must be Numeric")
        End If
        'set all the inputs to be blank
        licenceTxt.Text = ""
        ownernameTxt.Text = ""
        ownerphoneTxt.Text = ""


    End Sub

    'LOAD DATA TO THE LISTBOX
    Public Sub loadData()
        'open the db.txt using stream reader
        Dim reader As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("db.txt")
        Dim data As String

        'create a lists to take in licence, owner names and owner phone numbers
        Dim vehicles As New List(Of String)
        Dim names As New List(Of String)
        Dim phone As New List(Of String)

        'loop through each line of thedb.txt
        Do
            'save each line to data
            data = reader.ReadLine
            'if the line is not empty
            If Not String.IsNullOrWhiteSpace(data) Then
                'split it into an array using the commas and save the first to licence list(vehicle) second to names and third to phone as shown below
                Dim s() As String = Split(data, ",")
                vehicles.Add(s(0))
                names.Add(s(1))
                phone.Add(s(2))
            End If
        Loop Until data Is Nothing

        reader.Close()

        'first clear the listbox
        listBox.Items.Clear()

        'loop through the items in one of the lists above and add them to the list box spacing them as shown below
        Dim i As Integer = 0
        For Each vehicle In vehicles
            listBox.Items.Add(vehicle + "   " + names.Item(i) + "   " + phone.Item(i))
            i += 1
        Next

    End Sub

    'SORT THE LICENSE NUMBERS
    Public Sub sortLicence()
        'read data in db.txt
        Dim reader As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("db.txt")
        Dim data As String
        Dim vehicles As New List(Of String)
        Dim names As New List(Of String)
        Dim phone As New List(Of String)

        'loop through the data split and add them to the lists above
        Do
            data = reader.ReadLine
            If Not String.IsNullOrWhiteSpace(data) Then
                Dim s() As String = Split(data, ",")
                vehicles.Add(s(0))
                names.Add(s(1))
                phone.Add(s(2))
            End If
        Loop Until data Is Nothing

        reader.Close()

        'create a new list of sorted integers
        Dim licNumbers As New List(Of Integer)

        'convert each license to an integer
        For Each vehicle In vehicles
            licNumbers.Add(Convert.ToInt32(vehicle.Trim()))
        Next

        'sort the license numbers and reverse them to order them start from the largest to the smallest.
        licNumbers.Sort()
        licNumbers.Reverse()

        'clear the listbox add create a loop to add the sorted licences to the listbox
        listBox.Items.Clear()
        For Each licNumber In licNumbers
            Dim x As String = licNumber.ToString()
            listBox.Items.Add(x + "   " + names(vehicles.IndexOf(x)) + "  " + phone(vehicles.IndexOf(x)))
        Next

    End Sub

    'RELOAD THE LISTBOX using loadData METHOD WHEN THE refresh BUTTON IS CLOCKED
    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        Me.loadData()
    End Sub

    'SORT LICENSES USING sortLicence METHOD WHEN sort button is clicked
    Private Sub sortedBtn_Click(sender As Object, e As EventArgs) Handles sortedBtn.Click
        Me.sortLicence()
    End Sub

    'WHEN THE FORM LOADS
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CREATE db.txt FILE IF IT DOESNT EXISTS
        If Not IO.File.Exists("db.txt") Then
            Dim file As IO.StreamWriter = IO.File.CreateText("db.txt")
            file.Close()
        End If
        'load data to the listBox
        Me.loadData()
    End Sub

    'If the selected item in the listbox changes. show in textboxes if one is selected
    Private Sub listBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox.SelectedIndexChanged
        If listBox.SelectedItems.Count() = 1 Then
            Dim texts() As String = Split(listBox.SelectedItem(), "  ")
            licenceTxt.Text = texts(0)
            ownernameTxt.Text = texts(1)
            ownerphoneTxt.Text = texts(2)
        ElseIf listBox.SelectedItems.Count() = 0 Then
            licenceTxt.Text = ""
            ownernameTxt.Text = ""
            ownerphoneTxt.Text = ""
        End If
    End Sub

    'SEARCH LICENCE NUMBER
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click

        'Check if the search textbox has some text
        If Not searchTxt.Text.Trim() = "" Then
            'Read the sb.txt file
            Dim reader As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("db.txt")
            Dim data As String
            Dim vehicles As New List(Of String)
            Dim names As New List(Of String)
            Dim phone As New List(Of String)


            Do
                data = reader.ReadLine
                If Not String.IsNullOrWhiteSpace(data) Then
                    Dim s() As String = Split(data, ",")
                    vehicles.Add(s(0))
                    names.Add(s(1))
                    phone.Add(s(2))
                End If
            Loop Until data Is Nothing

            reader.Close()

            'check if the the licence exists
            Dim i As Integer = 0
            Dim found As Boolean = False
            For Each vehicle In vehicles
                If vehicle = searchTxt.Text.Trim() Then
                    found = True
                    Exit For
                End If
                i += 1
            Next

            'if found liad it in the listbox as shown below
            listBox.Items.Clear()
            If found Then
                listBox.Items.Add(vehicles(i) + "   " + names(i) + "   " + phone(i))
            End If


        Else
            MsgBox("Enter licence number to search")
        End If

    End Sub

    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click

        Dim removed As New List(Of String)

        'check if there is an item selected in the listbox
        If Not listBox.SelectedItems.Count() = 0 Then
            'split it by space and get the first array i.e license number
            For Each line In listBox.SelectedItems
                Dim texts() As String = Split(line, "  ")
                removed.Add(texts(0))
            Next
            'use the removeItem Function/ Method  to remove selected item
            Me.removeItem(removed)
        Else
            MsgBox("ERROR!! Select Item to Remove")
        End If
    End Sub

    'delete Item from the file
    Public Sub removeItem(ByVal removed As List(Of String))
        'create empty lists to take updated data
        Dim uvehicles As New List(Of String)
        Dim unames As New List(Of String)
        Dim uphone As New List(Of String)

        'read data from db.txt and append its data to the lists below
        Dim reader As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("db.txt")
        Dim data As String
        Dim vehicles As New List(Of String)
        Dim names As New List(Of String)
        Dim phone As New List(Of String)


        Do
            data = reader.ReadLine
            If Not String.IsNullOrWhiteSpace(data) Then
                Dim s() As String = Split(data, ",")
                vehicles.Add(s(0))
                names.Add(s(1))
                phone.Add(s(2))
            End If
        Loop Until data Is Nothing

        reader.Close()

        'loop through the list of licenses and append to the updated if the target licence is not equals to the current data
        Dim i As Integer = 0
        For Each vehicle In vehicles
            Dim Add As Boolean = True
            For Each rmv In removed
                If rmv = vehicle Then
                    Add = False
                    i += 1
                    Exit For
                End If
                If Add Then
                    uvehicles.Add(vehicle)
                    unames.Add(names(i))
                    uphone.Add(phone(i))
                End If
                i += 1
            Next
        Next

        'clear all the data in the db.txt
        IO.File.WriteAllText("db.txt", "")

        'write the data in the updated lists to the db .txt as shown below
        Dim file As IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("db.txt", True)

        Dim count As Integer = 0
        For Each uvehicle In uvehicles
            file.WriteLine(uvehicle + "," + unames(count) + "," + uphone(count))
            count += 1
        Next
        file.Close()

        'reload the list box as soon as the db.txt is updated.
        Me.loadData()
        MsgBox("Removed Successfully")

    End Sub

    'CHECK IF IS IN DB
    Public Function InDb(ByVal license As String) As Boolean
        Dim Result As Boolean = False

        'read data in the db.txt
        Dim reader As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("db.txt")
        Dim data As String
        Dim vehicles As New List(Of String)
        Dim names As New List(Of String)
        Dim phone As New List(Of String)


        Do
            data = reader.ReadLine
            If Not String.IsNullOrWhiteSpace(data) Then
                Dim s() As String = Split(data, ",")
                vehicles.Add(s(0))
                names.Add(s(1))
                phone.Add(s(2))
            End If
        Loop Until data Is Nothing

        reader.Close()

        'loop through each license data in lists above if it already exists i.e equal to the passed parameter return true else return false
        For Each vehicle In vehicles
            If vehicle = license Then
                Result = True
                Exit For
            End If
        Next

        Return Result
    End Function

End Class
