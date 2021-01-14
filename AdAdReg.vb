Imports System.Data.SqlClient

Public Class AdAdReg
    Shared random As New Random()
    Private Sub viewdata()
        Dset = New DataSet
        query = "SELECT * FROM LoginCredential"
        Dadapter = New SqlDataAdapter(query, conn)
        Dadapter.Fill(Dset)
        DataGridView1.DataSource = Dset.Tables(0)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
        HomeAdmin.GroupBox1.Visible = True
        HomeAdmin.records()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        If ComboBox1.SelectedItem = "Administrator" Then
            Dim i As Integer
            For i = 0 To 5
                Dim num As String = Convert.ToString(random.Next(100000, 999999))
                Label8.Text = "AD" + num
            Next
        ElseIf ComboBox1.SelectedItem = "Librarian" Then
            Dim i As Integer
            For i = 0 To 5
                Dim num As String = Convert.ToString(random.Next(100000, 999999))
                Label8.Text = "LI" + num
            Next
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label8.Text = "Click Me!!"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox2.Text <> TextBox3.Text Or TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Or TextBox6.Text = Nothing Then
                MsgBox("Password isn't match!!" + vbCrLf + "or some fields are missing", MessageBoxIcon.Error)
            Else
                Dim flag As Boolean = False
                Using Com As New SqlCommand("Select * From LoginCredential where EmailID ='" + TextBox6.Text + "'", conn)
                    Using RDR = Com.ExecuteReader()
                        If RDR.HasRows Then
                            Do While RDR.Read
                                flag = True
                            Loop
                        Else
                            flag = False
                        End If
                    End Using
                End Using
                If flag = True Then
                    MsgBox("Email address is already in use, please try another mail address.", MsgBoxStyle.Information)
                    TextBox6.Focus()
                    flag = False
                Else
                    cmd = New SqlCommand
                    cmd.Connection = conn
                    query = Nothing
                    query = "insert into LoginCredential values('" + Label8.Text.ToString + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + ComboBox1.SelectedItem.ToString + "','" + ComboBox2.SelectedItem.ToString + "','" + TextBox1.Text + "')"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    flag = False
                    viewdata()
                    MsgBox("Registratin successful" + vbCrLf + "Please keep safe your login credential", MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub AdAdReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        Label8.Text = "Click Me!!"
        Button4.Visible = False
        Button5.Visible = False
        ComboBox1.Enabled = True
        viewdata()
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then          'ONLY NUMERIC ALLOWED
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then          'ONLY NUMERIC ALLOWED
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then          'ONLY NUMERIC ALLOWED
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim I As Integer
        I = DataGridView1.CurrentRow.Index
        Label8.Text = DataGridView1.Item(0, I).Value
        TextBox2.Text = DataGridView1.Item(1, I).Value
        TextBox4.Text = DataGridView1.Item(2, I).Value
        TextBox5.Text = DataGridView1.Item(3, I).Value
        ComboBox1.SelectedIndex = -1
        ComboBox1.Enabled = False
        TextBox6.Text = DataGridView1.Item(4, I).Value
        ComboBox1.SelectedText = DataGridView1.Item(5, I).Value
        ComboBox2.Text = DataGridView1.Item(6, I).Value
        TextBox1.Text = DataGridView1.Item(7, I).Value
        Button4.Visible = True
        Button5.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            cmd = New SqlCommand
            cmd.Connection = conn
            query = "update LoginCredential set Password='" & TextBox2.Text & "', Name='" & TextBox4.Text & "', MobileNo='" & TextBox5.Text & "', EmailID='" & TextBox6.Text & "', Question='" + ComboBox2.SelectedItem.ToString + "', Answer='" + TextBox1.Text + "' where LoginID='" & Label8.Text & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            Label8.Text = "Click Me!!"
            Button4.Visible = False
            Button5.Visible = False
            ComboBox1.Enabled = True
            viewdata()
            ComboBox1.SelectedIndex = 0
            ComboBox2.SelectedIndex = 0
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim addAnother = MessageBox.Show("Record will deleted." & vbCrLf & "Want to Delete?" & vbCrLf & " If you press YES record will updated", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, False)
        If addAnother = MsgBoxResult.Yes Then
            cmd = New SqlCommand
            cmd.Connection = conn
            query = "delete from LoginCredential where LoginID='" & Label8.Text & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

            Label8.Text = "Click Me!!"
            Button4.Visible = False
            Button5.Visible = False
            ComboBox1.Enabled = True
            viewdata()
            ComboBox1.SelectedIndex = 0
            ComboBox2.SelectedIndex = 0
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            

        ElseIf addAnother = MsgBoxResult.No Then
            MsgBox("No any change!!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label8.Text = "Click Me!!"
        Button4.Visible = False
        Button5.Visible = False
        ComboBox1.Enabled = True
        viewdata()
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

End Class