Imports System.Data.SqlClient

Public Class AdRules

    Private Sub viewdata()
        Dset = New DataSet
        query = "SELECT ShortName,Name FROM Department"
        Dadapter = New SqlDataAdapter(query, conn)
        Dadapter.Fill(Dset)
        DataGridView1.DataSource = Dset.Tables(0)

        Dset = New DataSet
        query = "SELECT * FROM LimitBookBank"
        Dadapter = New SqlDataAdapter(query, conn)
        Dadapter.Fill(Dset)
        DataGridView2.DataSource = Dset.Tables(0)

        Using Com As New SqlCommand("Select * From LibraryRules where Category ='" + "STSC" + "'", conn)
            Using RDR = Com.ExecuteReader()
                If RDR.HasRows Then
                    Do While RDR.Read
                        Label8.Text = RDR.Item("NoofBook").ToString()
                        Label11.Text = RDR.Item("NoofDays").ToString()
                        Label14.Text = RDR.Item("LateFees").ToString()
                    Loop
                Else
                End If
            End Using
        End Using
        Using Com As New SqlCommand("Select * From LibraryRules where Category ='" + "GENOBC" + "'", conn)
            Using RDR = Com.ExecuteReader()
                If RDR.HasRows Then
                    Do While RDR.Read
                        Label7.Text = RDR.Item("NoofBook").ToString()
                        Label10.Text = RDR.Item("NoofDays").ToString()
                        Label13.Text = RDR.Item("LateFees").ToString()
                    Loop
                Else
                End If
            End Using
        End Using
        Using Com As New SqlCommand("Select * From LibraryRules where Category ='" + "NA" + "'", conn)
            Using RDR = Com.ExecuteReader()
                If RDR.HasRows Then
                    Do While RDR.Read
                        Label9.Text = RDR.Item("NoofBook").ToString()
                        Label12.Text = RDR.Item("NoofDays").ToString()
                        Label15.Text = RDR.Item("LateFees").ToString()
                    Loop
                Else
                End If
            End Using
        End Using
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
        HomeAdmin.GroupBox1.Visible = True
        HomeAdmin.records()
    End Sub

    Private Sub AdRules_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        viewdata()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Student" Then
            ComboBox2.Enabled = True
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("STSC")
            ComboBox2.Items.Add("GENOBC")
        ElseIf ComboBox1.SelectedItem = "Staff" Then
            ComboBox2.Enabled = False
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("NA")
            ComboBox2.SelectedItem = "NA"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            cmd = New SqlCommand
            cmd.Connection = conn
            query = "delete from LibraryRules where RulesFor='" & ComboBox1.SelectedItem.ToString() & "' and Category='" & ComboBox2.SelectedItem.ToString() & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand
            cmd.Connection = conn
            query = Nothing
            query = "insert into LibraryRules values('" + ComboBox1.SelectedItem + "','" + ComboBox2.SelectedItem + "','" + ComboBox3.SelectedItem + "','" + ComboBox4.SelectedItem + "','" + TextBox1.Text + "')"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            viewdata()
            MsgBox("Record Save successfully")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            cmd = New SqlCommand
            cmd.Connection = conn
            query = Nothing
            query = "insert into Department values('" + TextBox2.Text + "','" + TextBox3.Text + "')"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            viewdata()
            MsgBox("Record Save successfully")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            cmd = New SqlCommand
            cmd.Connection = conn
            query = Nothing
            query = "insert into LimitBookBank values('" + DateTimePicker1.Text + "','" + DateTimePicker2.Text + "','" + TextBox4.Text + "')"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            viewdata()
            MsgBox("Record Save successfully")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then          'ONLY NUMERIC ALLOWED
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then          'ONLY NUMERIC ALLOWED
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'delete dept'
        Try
            Dim addAnother = MessageBox.Show("Department name will be deleted." & vbCrLf & "Want to Delete?" & vbCrLf & " If you press YES record will updated", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, False)
            If addAnother = MsgBoxResult.Yes Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = "delete from Department where Name='" & TextBox2.Text & "'"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                Button8.Visible = False
                viewdata()
            End If

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim I As Integer
        I = DataGridView1.CurrentRow.Index
        TextBox2.Text = DataGridView1.Item(0, I).Value
        TextBox3.Text = DataGridView1.Item(1, I).Value
        Button8.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox2.Clear()
        TextBox3.Clear()
        Button8.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        TextBox1.Clear()
    End Sub
End Class