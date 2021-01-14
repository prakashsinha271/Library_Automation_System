Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class AdReport

    Private Sub loadcmb3()
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 1 Then
            ComboBox3.Enabled = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Physiacl Available")
            ComboBox3.Items.Add("Physiacl Un-available")
            ComboBox3.SelectedIndex = 0
        ElseIf ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Or ComboBox1.SelectedIndex = 4 Or ComboBox1.SelectedIndex = 5 Then
            ComboBox3.Enabled = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("Today")
            ComboBox3.Items.Add("7 Days")
            ComboBox3.Items.Add("15 Days")
            ComboBox3.Items.Add("30 Days")
            ComboBox3.Items.Add("Overall")
            ComboBox3.SelectedIndex = 0
        Else
            ComboBox3.SelectedIndex = 0
            ComboBox3.Enabled = False
        End If
    End Sub

    Private Sub AdReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        HideAll()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
        HomeAdmin.GroupBox1.Visible = True
        HomeAdmin.records()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        HideAll()
        loadcmb3()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 1 Then
            HideAll()
            ReportViewer1.Visible = True
            If ComboBox3.SelectedIndex = 0 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptBook"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptBook (BookID,BookTitle,Author,Edition,Price,Publisher,PhyAvailable) SELECT BookID,BookTitle,Author1,Edition,Price,Publisher,PhyAvailable FROM " + ComboBox1.SelectedItem + " Where PhyAvailable = '" + "Yes" + "'"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                Me.rptBookTableAdapter.Fill(Me.LibraryDataDataSet.rptBook)
                ReportViewer1.RefreshReport()
            ElseIf ComboBox3.SelectedIndex = 1 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptBook"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptBook (BookID,BookTitle,Author,Edition,Price,Publisher,PhyAvailable) SELECT BookID,BookTitle,Author1,Edition,Price,Publisher,PhyAvailable FROM " + ComboBox1.SelectedItem + " Where PhyAvailable =  '" + "No" + "'"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                Me.rptBookTableAdapter.Fill(Me.LibraryDataDataSet.rptBook)
                ReportViewer1.RefreshReport()
            End If
        ElseIf ComboBox1.SelectedIndex = 2 Then
            HideAll()
            ReportViewer3.Visible = True
            If ComboBox3.SelectedIndex = 0 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptIssue"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptIssue (IssueID,IssueFor,BookType,BookID,BookTitle,BookAuthor,MemberID,Name,Father,Department,IssueDate,DueDate,Status) SELECT IssueID,IssueTo,BookType,BookID,BookTitle,Author,MemberID,MemberName,FathersName,Department,IssueDate,DueDate,Status FROM IssueBook WHERE IssueDate = GETDATE()"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 1 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptIssue"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptIssue (IssueID,IssueFor,BookType,BookID,BookTitle,BookAuthor,MemberID,Name,Father,Department,IssueDate,DueDate,Status) SELECT IssueID,IssueTo,BookType,BookID,BookTitle,Author,MemberID,MemberName,FathersName,Department,IssueDate,DueDate,Status FROM IssueBook WHERE IssueDate >= DATEADD(day, -7 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 2 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptIssue"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptIssue (IssueID,IssueFor,BookType,BookID,BookTitle,BookAuthor,MemberID,Name,Father,Department,IssueDate,DueDate,Status) SELECT IssueID,IssueTo,BookType,BookID,BookTitle,Author,MemberID,MemberName,FathersName,Department,IssueDate,DueDate,Status FROM IssueBook WHERE IssueDate >= DATEADD(day, -15 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 3 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptIssue"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptIssue (IssueID,IssueFor,BookType,BookID,BookTitle,BookAuthor,MemberID,Name,Father,Department,IssueDate,DueDate,Status) SELECT IssueID,IssueTo,BookType,BookID,BookTitle,Author,MemberID,MemberName,FathersName,Department,IssueDate,DueDate,Status FROM IssueBook WHERE IssueDate >= DATEADD(day, -30 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 4 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptIssue"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptIssue (IssueID,IssueFor,BookType,BookID,BookTitle,BookAuthor,MemberID,Name,Father,Department,IssueDate,DueDate,Status) SELECT IssueID,IssueTo,BookType,BookID,BookTitle,Author,MemberID,MemberName,FathersName,Department,IssueDate,DueDate,Status FROM IssueBook" ' WHERE IssueDate >= DATEADD(day, -7 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            End If
            Me.rptIssueTableAdapter.Fill(Me.LibraryDataDataSet.rptIssue)
            ReportViewer3.RefreshReport()
        ElseIf ComboBox1.SelectedIndex = 3 Then
            HideAll()
            ReportViewer4.Visible = True
            If ComboBox3.SelectedIndex = 0 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptReturn"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptReturn (ReturnID,BookID,Title,MemberID,Name,Department,DueDate,Returningdate,LateDays,Fine,Remark) SELECT ReturnID,BookID,Title,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine,Remark FROM ReturnBook WHERE ReturningDate = GETDATE()"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 1 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptReturn"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptReturn (ReturnID,BookID,Title,MemberID,Name,Department,DueDate,Returningdate,LateDays,Fine,Remark) SELECT ReturnID,BookID,Title,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine,Remark FROM ReturnBook WHERE ReturningDate >= DATEADD(day, -7 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 2 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptReturn"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptReturn (ReturnID,BookID,Title,MemberID,Name,Department,DueDate,Returningdate,LateDays,Fine,Remark) SELECT ReturnID,BookID,Title,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine,Remark FROM ReturnBook WHERE ReturningDate >= DATEADD(day, -15 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 3 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptReturn"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptReturn (ReturnID,BookID,Title,MemberID,Name,Department,DueDate,Returningdate,LateDays,Fine,Remark) SELECT ReturnID,BookID,Title,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine,Remark FROM ReturnBook WHERE ReturningDate >= DATEADD(day, -30 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 4 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptReturn"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptReturn (ReturnID,BookID,Title,MemberID,Name,Department,DueDate,Returningdate,LateDays,Fine,Remark) SELECT ReturnID,BookID,Title,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine,Remark FROM ReturnBook" ' WHERE ReturningDate >= DATEADD(day, -7 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            End If
            Me.rptReturnTableAdapter.Fill(Me.LibraryDataDataSet.rptReturn)
            ReportViewer4.RefreshReport()
        ElseIf ComboBox1.SelectedIndex = 4 Then
            HideAll()
            ReportViewer5.Visible = True
            If ComboBox3.SelectedIndex = 0 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptFine"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptFine (ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine) SELECT ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine FROM FineTable where Status = '" + "Payed" + "' and ReturningDate = GETDATE()"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 1 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptFine"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptFine (ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine) SELECT ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine FROM FineTable where Status = '" + "Payed" + "' and ReturningDate >= DATEADD(day, -7 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 2 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptFine"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptFine (ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine) SELECT ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine FROM FineTable where Status = '" + "Payed" + "' and ReturningDate >= DATEADD(day, -15 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 3 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptFine"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptFine (ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine) SELECT ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine FROM FineTable where Status = '" + "Payed" + "' and ReturningDate >= DATEADD(day, -30 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 4 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptFine"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptFine (ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine) SELECT ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine FROM FineTable where Status = '" + "Payed" + "'" ' and ReturningDate >= DATEADD(day, -7 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            End If
            Me.rptFineTableAdapter.Fill(Me.LibraryDataDataSet.rptFine)
            ReportViewer5.RefreshReport()
        ElseIf ComboBox1.SelectedIndex = 5 Then
            HideAll()
            ReportViewer5.Visible = True
            If ComboBox3.SelectedIndex = 0 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptFine"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptFine (ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine) SELECT ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine FROM FineTable where Status = '" + "Skip" + "' and ReturningDate = GETDATE()"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 1 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptFine"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptFine (ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine) SELECT ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine FROM FineTable where Status = '" + "Skip" + "' and ReturningDate >= DATEADD(day, -7 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 2 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptFine"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptFine (ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine) SELECT ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine FROM FineTable where Status = '" + "Skip" + "' and ReturningDate >= DATEADD(day, -15 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 3 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptFine"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptFine (ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine) SELECT ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine FROM FineTable where Status = '" + "Skip" + "' and ReturningDate >= DATEADD(day, -30 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            ElseIf ComboBox3.SelectedIndex = 4 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "DELETE FROM rptFine"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand
                cmd.Connection = conn
                query = Nothing
                query = "INSERT INTO rptFine (ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine) SELECT ReturnID,MemberID,Name,Department,DueDate,ReturningDate,LateDays,Fine FROM FineTable where Status = '" + "Skip" + "'" ' and ReturningDate >= DATEADD(day, -7 , GETDATE())"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            End If
            Me.rptFineTableAdapter.Fill(Me.LibraryDataDataSet.rptFine)
            ReportViewer5.RefreshReport()
        ElseIf ComboBox1.SelectedIndex = 6 Then
            HideAll()
            ReportViewer2.Visible = True
            cmd = New SqlCommand
            cmd.Connection = conn
            query = Nothing
            query = "DELETE FROM rptMember"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand
            cmd.Connection = conn
            query = Nothing
            query = "INSERT INTO rptMember (MemeberID,Name,FatherName,Department,MobileNo,City,District,State) SELECT EmployeeID,FirstName,FatherName,Department,MobileNo,P_City,P_District,P_State FROM Employee"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            Me.rptMemberTableAdapter.Fill(Me.LibraryDataDataSet.rptMember)
            ReportViewer2.RefreshReport()
        ElseIf ComboBox1.SelectedIndex = 7 Then
            HideAll()
            ReportViewer2.Visible = True
            cmd = New SqlCommand
            cmd.Connection = conn
            query = Nothing
            query = "DELETE FROM rptMember"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand
            cmd.Connection = conn
            query = Nothing
            query = "INSERT INTO rptMember (MemeberID,Name,FatherName,Department,MobileNo,City,District,State) SELECT StudentID,FirstName,FatherName,Department,MobileNo,City,District,State FROM Student"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            Me.rptMemberTableAdapter.Fill(Me.LibraryDataDataSet.rptMember)
            ReportViewer2.RefreshReport()
        ElseIf ComboBox1.SelectedIndex = 8 Then
            HideAll()
            ReportViewer6.Visible = True
            Me.JournalsTableAdapter.Fill(Me.LibraryDataDataSet.Journals)
            ReportViewer6.RefreshReport()
        ElseIf ComboBox1.SelectedIndex = 9 Then
            HideAll()
            ReportViewer7.Visible = True
            Me.PurchaseOrderTableAdapter.Fill(Me.LibraryDataDataSet.PurchaseOrder)
            ReportViewer7.RefreshReport()
        End If
    End Sub
    Private Sub HideAll()
        ReportViewer1.Visible = False
        ReportViewer2.Visible = False
        ReportViewer3.Visible = False
        ReportViewer4.Visible = False
        ReportViewer5.Visible = False
        ReportViewer6.Visible = False
        ReportViewer7.Visible = False
    End Sub
End Class