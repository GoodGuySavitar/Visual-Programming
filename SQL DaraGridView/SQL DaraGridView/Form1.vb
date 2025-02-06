Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=root;database=BookDB")

    Private Sub DisplayData()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM Books", conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvBooks.DataSource = table
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO Books (BookTitle, Author) VALUES (@BookTitle, @Author)"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@BookTitle", txtAuthor.Text)
        cmd.Parameters.AddWithValue("@Author", txtBookTitle.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Book Added Successfully!")
        DisplayData()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE Books SET BookTitle=@BookTitle, Author=@Author WHERE BookID=@BookID"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@BookID", txtBookID.Text)
        cmd.Parameters.AddWithValue("@BookTitle", txtAuthor.Text)
        cmd.Parameters.AddWithValue("@Author", txtBookTitle.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Book Updated Successfully!")
        DisplayData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query As String = "DELETE FROM Books WHERE BookID=@BookID"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@BookID", txtBookID.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Book Deleted Successfully!")
        DisplayData()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DisplayData()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBookID.Clear()
        txtAuthor.Clear()
        txtBookTitle.Clear()
    End Sub

End Class
