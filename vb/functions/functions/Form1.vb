Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim x = f.execute(" INSERT INTO Customers  ( CustomerName, Address, City, PostalCode, Country ) VALUES ( 'Hekkan Burger', 'Gateveien 15', 'Sandnes', '4306', 'Norway') ;")

        'MsgBox(x)


        'x = f.dataViewAddCollom(DataGridView1, "ik", "ben", "Ruben")
        'x = f.dataViewAddCollom(DataGridView1, "en", "ik", "ben")
        'x = f.dataViewAddCollom(DataGridView1, "nen", "faxing", "dwaazn")


        MsgBox(f.selectToDataGridView("SELECT * FROM customers", DataGridView1))

    End Sub
End Class
