Imports System.Data.SqlClient

Public Class AdNoDues

    Dim issue As Boolean = False
    Dim avail As Boolean = True

    Private Sub AdNoDues_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        hideall()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
        HomeAdmin.GroupBox1.Visible = True
        HomeAdmin.records()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Text = "Enter " + ComboBox1.SelectedItem + " ID Number : "
        hideall()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = Nothing Then

            Else
                If ComboBox1.SelectedItem = "Student" Then
                    Dset = New DataSet
                    query = "SELECT * FROM Student where StudentID = '" + TextBox1.Text + "'"
                    Dadapter = New SqlDataAdapter(query, conn)
                    Dadapter.Fill(Dset)
                    DataGridView1.DataSource = Dset.Tables(0)
                ElseIf ComboBox1.SelectedItem = "Employee" Then
                    Dset = New DataSet
                    query = "SELECT * FROM Employee where EmployeeID = '" + TextBox1.Text + "'"
                    Dadapter = New SqlDataAdapter(query, conn)
                    Dadapter.Fill(Dset)
                    DataGridView1.DataSource = Dset.Tables(0)
                ElseIf ComboBox1.SelectedItem = "BookGeneral" Or ComboBox1.SelectedItem = "BookBank" Then
                    Dset = New DataSet
                    query = "SELECT * FROM " + ComboBox1.SelectedItem + " where BookID = " + TextBox1.Text + ""
                    Dadapter = New SqlDataAdapter(query, conn)
                    Dadapter.Fill(Dset)
                    DataGridView1.DataSource = Dset.Tables(0)
                End If
                DataGridView1.Visible = True
                Try
                    If ComboBox1.SelectedItem = "Student" Or ComboBox1.SelectedItem = "Employee" Then
                        Using Com As New SqlCommand("Select * From IssueBook where MemberID ='" + TextBox1.Text + "' and Status = '" + "Issued" + "'", conn)
                            Using RDR = Com.ExecuteReader()
                                If RDR.HasRows Then
                                    Do While RDR.Read
                                        issue = True
                                    Loop
                                Else
                                    issue = False
                                End If
                            End Using
                        End Using
                    ElseIf ComboBox1.SelectedItem = "BookGeneral" Or ComboBox1.SelectedItem = "BookBank" Then
                        Using Com As New SqlCommand("Select * From " + ComboBox1.SelectedItem + " where BookID ='" + TextBox1.Text + "' and PhyAvailable = '" + "No" + "'", conn)
                            Using RDR = Com.ExecuteReader()
                                If RDR.HasRows Then
                                    Do While RDR.Read
                                        avail = False
                                    Loop
                                Else
                                    avail = True
                                End If
                            End Using
                        End Using
                    End If

                Catch ex As Exception
                    MsgBox(Err.Description)
                End Try
                If ComboBox1.SelectedItem = "Student" Or ComboBox1.SelectedItem = "Employee" Then
                    If issue = True Then
                        Button2.Visible = True
                        Button2.Enabled = False
                        Label1.Text = "Member have library book, ask to subbmit first or memeber isn't register."
                        Label1.Visible = True
                    ElseIf issue = False Then
                        Button2.Visible = True
                        Button2.Enabled = True
                        Label1.Text = "All records are cleare, No DUES can be granted."
                        Label1.Visible = True
                    End If
                ElseIf ComboBox1.SelectedItem = "BookGeneral" Or ComboBox1.SelectedItem = "BookBank" Then
                    If avail = True Then
                        Button2.Visible = True
                        Button2.Enabled = False
                        Label1.Text = "This book is physicaly available or not in records of library."
                        Label1.Visible = True
                    ElseIf avail = False Then
                        Button2.Visible = True
                        Button2.Enabled = True
                        Label1.Text = "All records are cleare, No DUES can be granted."
                        Label1.Visible = True
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text = Nothing Then
                Button2.Enabled = False
            Else
                Dim addAnother = MessageBox.Show("All records will be deleted after NO-DUES." & vbCrLf & " Do you want to grant NO-DUES clearance ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, False)
                If addAnother = MsgBoxResult.Yes Then
                    If ComboBox1.SelectedItem = "Student" Then
                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM Student where StudentID = '" + TextBox1.Text + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM StudentTempID where StudentID = '" + TextBox1.Text.Substring(TextBox1.Text.Length - 3) + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM FineSlip where MemberID = '" + TextBox1.Text + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM IssueBook where MemberID = '" + TextBox1.Text + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM ReturnBook where MemberID = '" + TextBox1.Text + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        MsgBox("NO-DUES is granted and all records are deleted.")
                        hideall()
                        ComboBox1.SelectedIndex = 0
                        Dim issue As Boolean = False
                        Dim avail As Boolean = True

                    ElseIf ComboBox1.SelectedItem = "Employee" Then
                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM Employee where EmployeeID = '" + TextBox1.Text + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM EmployeeTempID where EmployeeID = '" + TextBox1.Text.Substring(TextBox1.Text.Length - 3) + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM FineSlip where MemberID = '" + TextBox1.Text + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM IssueBook where MemberID = '" + TextBox1.Text + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM ReturnBook where MemberID = '" + TextBox1.Text + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        MsgBox("NO-DUES is granted and all records are deleted.")
                        hideall()
                        ComboBox1.SelectedIndex = 0
                        Dim issue As Boolean = False
                        Dim avail As Boolean = True

                    ElseIf ComboBox1.SelectedItem = "BookGeneral" Or ComboBox1.SelectedItem = "BookBank" Then
                        Dim DelID As String = Nothing
                        Dim DelTitle As String = Nothing
                        Dim DelAuthor As String = Nothing
                        Dim DelEdition As String = Nothing
                        Dim DelPrice As String = Nothing
                        Dim DelPublisher As String = Nothing
                        Dim DelRemark As String = Nothing

                        Using Com As New SqlCommand("Select * From " + ComboBox1.SelectedItem + " where BookID ='" + TextBox1.Text + "' and PhyAvailable = '" + "No" + "'", conn)
                            Using RDR = Com.ExecuteReader()
                                If RDR.HasRows Then
                                    Do While RDR.Read
                                        DelID = RDR.Item("BookID").ToString()
                                        DelTitle = RDR.Item("BookTitle").ToString().TrimEnd(" ")
                                        DelAuthor = RDR.Item("Author1").ToString().TrimEnd(" ")
                                        DelEdition = RDR.Item("Edition").ToString()
                                        DelPrice = RDR.Item("Price").ToString()
                                        DelPublisher = RDR.Item("Publisher").ToString().TrimEnd(" ")
                                        DelRemark = InputBox("Provide remark/reason for delete book.....").ToString()
                                    Loop
                                End If
                            End Using
                        End Using

                        MsgBox(DelID.ToString + DelTitle.ToString + DelAuthor.ToString)

                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "insert into DeletedBook values('" + DelID + "','" + DelTitle + "','" + DelAuthor + "','" + DelEdition + "','" + DelPrice + "','" + DelPublisher + "','" + DelRemark + "')"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()


                        cmd = New SqlCommand
                        cmd.Connection = conn
                        query = Nothing
                        query = "DELETE FROM " + ComboBox1.SelectedItem + " where BookID = '" + TextBox1.Text + "'"
                        cmd.CommandText = query
                        cmd.ExecuteNonQuery()

                        MsgBox("Write of is done and all records are deleted.")
                        hideall()
                        ComboBox1.SelectedIndex = 0
                        Dim issue As Boolean = False
                        Dim avail As Boolean = True

                    End If
                Else
                    MsgBox("process unsuccesfull.")
                    hideall()
                    ComboBox1.SelectedIndex = 0
                    Dim issue As Boolean = False
                    Dim avail As Boolean = True
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub hideall()
        DataGridView1.Visible = False
        Label1.Visible = False
        Button2.Visible = False
        TextBox1.Clear()
        Button2.Enabled = False
    End Sub
End Class