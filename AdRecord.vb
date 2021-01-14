Imports System.Data.SqlClient

Public Class AdRecord

    Private Sub AdRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.LibraryDataDataSet.Department)
        connection()
        hideall()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
        HomeAdmin.GroupBox1.Visible = True
        HomeAdmin.records()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.SelectedIndex = 0 Then
                Using Com As New SqlCommand("Select * From Student where StudentID ='" + TextBox1.Text + "'", conn)
                    Using RDR = Com.ExecuteReader()
                        If RDR.HasRows Then
                            Do While RDR.Read
                                Label3.Visible = True
                                Label4.Visible = True
                                Label5.Visible = True
                                Label6.Visible = True
                                Label7.Visible = True
                                Label8.Visible = True
                                Label9.Visible = True
                                Label10.Visible = True
                                Label11.Visible = True
                                Label12.Visible = True
                                Label13.Visible = True
                                Label14.Visible = True
                                Label15.Visible = True
                                Label16.Visible = True
                                Label17.Visible = True
                                Label18.Visible = True
                                Label19.Visible = True
                                Label20.Visible = True
                                Label21.Visible = True
                                Label23.Visible = True
                                Label24.Visible = True
                                Label25.Visible = True
                                Label26.Visible = True
                                Label28.Visible = True
                                Label30.Visible = True
                                Label3.Text = "StudentID"
                                Label4.Text = "F Name"
                                Label5.Text = "Father"
                                Label6.Text = "L Name"
                                Label7.Text = "Roll No"
                                Label8.Text = "Enroll No"
                                Label9.Text = "ID No"
                                Label10.Text = "Mobile No"
                                Label11.Text = "Alt Mobile"
                                Label12.Text = "Email"
                                Label13.Text = "House No"
                                Label14.Text = "Street"
                                Label15.Text = "City"
                                Label16.Text = "Post Office"
                                Label17.Text = "Tehsil"
                                Label18.Text = "PinCode"
                                Label19.Text = "State"
                                Label20.Text = "District"
                                Label21.Text = "Acad Year"
                                Label23.Text = "Gender"
                                Label24.Text = "Category"
                                Label25.Text = "Department"
                                Label26.Text = "Year"
                                Label28.Text = "ID Card"
                                Label30.Text = "Birth Date"
                                TextBox2.Visible = True
                                TextBox3.Visible = True
                                TextBox4.Visible = True
                                TextBox5.Visible = True
                                TextBox6.Visible = True
                                TextBox7.Visible = True
                                TextBox8.Visible = True
                                TextBox9.Visible = True
                                TextBox10.Visible = True
                                TextBox11.Visible = True
                                TextBox12.Visible = True
                                TextBox13.Visible = True
                                TextBox14.Visible = True
                                TextBox15.Visible = True
                                TextBox16.Visible = True
                                TextBox17.Visible = True
                                TextBox18.Visible = True
                                TextBox19.Visible = True
                                TextBox20.Visible = True
                                TextBox2.Text = RDR.Item("StudentID").ToString.TrimEnd(" ")
                                TextBox3.Text = RDR.Item("FirstName").ToString.TrimEnd(" ")
                                TextBox4.Text = RDR.Item("FatherName").ToString.TrimEnd(" ")
                                TextBox5.Text = RDR.Item("LastName").ToString.TrimEnd(" ")
                                TextBox6.Text = RDR.Item("RollNo").ToString
                                TextBox7.Text = RDR.Item("EnrollNo").ToString.TrimEnd(" ")
                                TextBox8.Text = RDR.Item("IDNo").ToString
                                TextBox9.Text = RDR.Item("MobileNo").ToString
                                TextBox10.Text = RDR.Item("AltMobile").ToString
                                TextBox11.Text = RDR.Item("Email").ToString.TrimEnd(" ")
                                TextBox12.Text = RDR.Item("HNo").ToString.TrimEnd(" ")
                                TextBox13.Text = RDR.Item("Street").ToString.TrimEnd(" ")
                                TextBox14.Text = RDR.Item("City").ToString.TrimEnd(" ")
                                TextBox15.Text = RDR.Item("PostOffice").ToString.TrimEnd(" ")
                                TextBox16.Text = RDR.Item("Tehsil").ToString.TrimEnd(" ")
                                TextBox17.Text = RDR.Item("PinCode").ToString
                                TextBox18.Text = RDR.Item("State").ToString.TrimEnd(" ")
                                TextBox19.Text = RDR.Item("District").ToString.TrimEnd(" ")
                                TextBox20.Text = RDR.Item("Acad_Year").ToString
                                ComboBox2.Visible = True
                                ComboBox3.Visible = True
                                ComboBox4.Visible = True
                                ComboBox5.Visible = True
                                ComboBox7.Visible = True
                                ComboBox2.Items.Clear()
                                ComboBox2.Items.Add("M")
                                ComboBox2.Items.Add("F")
                                ComboBox2.Items.Add("T")
                                ComboBox3.Items.Clear()
                                ComboBox3.Items.Add("Gen")
                                ComboBox3.Items.Add("OBC")
                                ComboBox3.Items.Add("ST")
                                ComboBox3.Items.Add("SC")
                                ' ComboBox4.Items.Clear()
                                ComboBox5.Items.Clear()
                                ComboBox5.Items.Add("1")
                                ComboBox5.Items.Add("2")
                                ComboBox5.Items.Add("3")
                                ComboBox7.Items.Clear()
                                ComboBox7.Items.Add("Adhar Card")
                                ComboBox7.Items.Add("Votar ID")
                                ComboBox7.Items.Add("PAN Card")
                                ComboBox7.Items.Add("DR Licence")
                                ComboBox7.Items.Add("Passport")
                                ComboBox7.Items.Add("Other ID")
                                ComboBox2.SelectedItem = RDR.Item("Gender")
                                ComboBox3.SelectedItem = RDR.Item("Category")
                                ComboBox4.SelectedItem = RDR.Item("Department")
                                ComboBox5.SelectedItem = RDR.Item("Year")
                                ComboBox7.SelectedItem = RDR.Item("IDCard")
                                DateTimePicker1.Visible = True
                                DateTimePicker1.Text = RDR.Item("BirthDate")
                                Button4.Visible = True
                                Button5.Visible = True
                                Button6.Visible = True
                            Loop
                        Else
                            MsgBox("No record Found")
                            hideall()
                        End If
                    End Using
                End Using
            ElseIf ComboBox1.SelectedIndex = 1 Then
                Using Com As New SqlCommand("Select * From Employee where EmployeeID ='" + TextBox1.Text + "'", conn)
                    Using RDR = Com.ExecuteReader()
                        If RDR.HasRows Then
                            Do While RDR.Read
                                Label3.Visible = True
                                Label4.Visible = True
                                Label5.Visible = True
                                Label6.Visible = True
                                Label7.Visible = True
                                Label8.Visible = True
                                Label9.Visible = True
                                Label10.Visible = True
                                Label11.Visible = True
                                Label12.Visible = True
                                Label13.Visible = True
                                Label14.Visible = True
                                Label15.Visible = True
                                Label16.Visible = True
                                Label17.Visible = True
                                Label18.Visible = True
                                Label19.Visible = True
                                Label20.Visible = True
                                Label21.Visible = True
                                Label22.Visible = True
                                Label23.Visible = True
                                Label25.Visible = True
                                Label28.Visible = True
                                Label30.Visible = True
                                Label31.Visible = True
                                Label32.Visible = True
                                Label33.Visible = True
                                Label34.Visible = True
                                Label3.Text = "F Name"
                                Label4.Text = "Father"
                                Label5.Text = "L Name"
                                Label6.Text = "ID No"
                                Label7.Text = "Mobile No"
                                Label8.Text = "AltMobile"
                                Label9.Text = "Email"
                                Label10.Text = "HNo(L)"
                                Label11.Text = "Landmark(L)"
                                Label12.Text = "City(L)"
                                Label13.Text = "P.O.(L)"
                                Label14.Text = "Tehsil(L)"
                                Label15.Text = "PinCode(L)"
                                Label16.Text = "State(L)"
                                Label17.Text = "District(L)"
                                Label18.Text = "HNo(P)"
                                Label19.Text = "Landmark(P)"
                                Label20.Text = "City(P)"
                                Label21.Text = "P.O.(P)"
                                Label22.Text = "Tehsil(P)"
                                Label23.Text = "Category"
                                Label32.Text = "PinCode(P)"
                                Label33.Text = "State(P)"
                                Label34.Text = "District(P)"
                                Label25.Text = "Department"
                                Label28.Text = "ID Card"
                                Label30.Text = "Birth Date"
                                Label31.Text = "Joining date"
                                TextBox2.Visible = True
                                TextBox3.Visible = True
                                TextBox4.Visible = True
                                TextBox5.Visible = True
                                TextBox6.Visible = True
                                TextBox7.Visible = True
                                TextBox8.Visible = True
                                TextBox9.Visible = True
                                TextBox10.Visible = True
                                TextBox11.Visible = True
                                TextBox12.Visible = True
                                TextBox13.Visible = True
                                TextBox14.Visible = True
                                TextBox15.Visible = True
                                TextBox16.Visible = True
                                TextBox17.Visible = True
                                TextBox18.Visible = True
                                TextBox19.Visible = True
                                TextBox20.Visible = True
                                TextBox21.Visible = True
                                TextBox22.Visible = True
                                TextBox23.Visible = True
                                TextBox24.Visible = True
                                TextBox2.Text = RDR.Item("FirstName").ToString.TrimEnd(" ")
                                TextBox3.Text = RDR.Item("Fathername").ToString.TrimEnd(" ")
                                TextBox4.Text = RDR.Item("LastName").ToString.TrimEnd(" ")
                                TextBox5.Text = RDR.Item("IDNo").ToString.TrimEnd(" ")
                                TextBox6.Text = RDR.Item("MobileNo").ToString
                                TextBox7.Text = RDR.Item("AltMobile").ToString
                                TextBox8.Text = RDR.Item("Email").ToString
                                TextBox9.Text = RDR.Item("L_HNo").ToString
                                TextBox10.Text = RDR.Item("L_Landmark").ToString
                                TextBox11.Text = RDR.Item("L_City").ToString.TrimEnd(" ")
                                TextBox12.Text = RDR.Item("L_PostOffice").ToString.TrimEnd(" ")
                                TextBox13.Text = RDR.Item("L_Tehsil").ToString.TrimEnd(" ")
                                TextBox14.Text = RDR.Item("L_Pincode").ToString
                                TextBox15.Text = RDR.Item("L_State").ToString.TrimEnd(" ")
                                TextBox16.Text = RDR.Item("L_District").ToString.TrimEnd(" ")
                                TextBox17.Text = RDR.Item("P_HNo").ToString
                                TextBox18.Text = RDR.Item("P_Landmark").ToString.TrimEnd(" ")
                                TextBox19.Text = RDR.Item("P_City").ToString.TrimEnd(" ")
                                TextBox20.Text = RDR.Item("P_PostOffice").ToString.TrimEnd(" ")
                                TextBox21.Text = RDR.Item("P_Tehsil").ToString.TrimEnd(" ")
                                TextBox22.Text = RDR.Item("P_Pincode").ToString.ToString
                                TextBox23.Text = RDR.Item("P_State").ToString.TrimEnd(" ")
                                TextBox24.Text = RDR.Item("P_District").ToString.TrimEnd(" ")
                                ComboBox2.Visible = True
                                ComboBox4.Visible = True
                                ComboBox7.Visible = True
                                ComboBox2.Items.Clear()
                                ComboBox2.Items.Add("Faculty")
                                ComboBox2.Items.Add("Staff")
                                ComboBox2.Items.Add("Other")
                                ' ComboBox4.Items.Clear()
                                ComboBox7.Items.Clear()
                                ComboBox7.Items.Add("Adhar Card")
                                ComboBox7.Items.Add("Votar ID")
                                ComboBox7.Items.Add("PAN Card")
                                ComboBox7.Items.Add("DR Licence")
                                ComboBox7.Items.Add("Passport")
                                ComboBox7.Items.Add("Other ID")
                                ComboBox2.SelectedItem = RDR.Item("Category")
                                ComboBox4.SelectedValue = RDR.Item("Department")
                                ComboBox7.SelectedItem = RDR.Item("IDCard")
                                DateTimePicker1.Visible = True
                                DateTimePicker2.Visible = True
                                DateTimePicker1.Text = RDR.Item("BirthDate")
                                DateTimePicker2.Text = RDR.Item("JoiningDate")
                                Button4.Visible = True
                                Button5.Visible = True
                                Button6.Visible = True
                            Loop
                        Else
                            MsgBox("No record Found")
                            hideall()
                        End If
                    End Using
                End Using
            ElseIf ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Then
                Using Com As New SqlCommand("Select * From " + ComboBox1.SelectedItem + " where BookID ='" + TextBox1.Text + "'", conn)
                    Using RDR = Com.ExecuteReader()
                        If RDR.HasRows Then
                            Do While RDR.Read
                                Label3.Visible = True
                                Label4.Visible = True
                                Label5.Visible = True
                                Label6.Visible = True
                                Label7.Visible = True
                                Label8.Visible = True
                                Label9.Visible = True
                                Label10.Visible = True
                                Label11.Visible = True
                                Label12.Visible = True
                                Label24.Visible = True
                                Label25.Visible = True
                                Label3.Text = "BookTitle"
                                Label4.Text = "Author1"
                                Label5.Text = "Author2"
                                Label6.Text = "Author3"
                                Label7.Text = "Author4"
                                Label8.Text = "Edition"
                                Label9.Text = "Price"
                                Label10.Text = "ISBN"
                                Label11.Text = "Location"
                                Label12.Text = "Publisher"
                                Label24.Text = "Digi Media"
                                Label25.Text = "Department"
                                TextBox2.Visible = True
                                TextBox3.Visible = True
                                TextBox4.Visible = True
                                TextBox5.Visible = True
                                TextBox6.Visible = True
                                TextBox7.Visible = True
                                TextBox8.Visible = True
                                TextBox9.Visible = True
                                TextBox10.Visible = True
                                TextBox11.Visible = True
                                TextBox2.Text = RDR.Item("BookTitle").ToString.TrimEnd(" ")
                                TextBox3.Text = RDR.Item("Author1").ToString.TrimEnd(" ")
                                TextBox4.Text = RDR.Item("Author2").ToString.TrimEnd(" ")
                                TextBox5.Text = RDR.Item("Author3").ToString.TrimEnd(" ")
                                TextBox6.Text = RDR.Item("Author4").ToString
                                TextBox7.Text = RDR.Item("Edition").ToString
                                TextBox8.Text = RDR.Item("Price").ToString
                                TextBox9.Text = RDR.Item("ISBN").ToString
                                TextBox10.Text = RDR.Item("Location").ToString
                                TextBox11.Text = RDR.Item("Publisher").ToString.TrimEnd(" ")
                                ComboBox4.Visible = True
                                ComboBox4.SelectedValue = RDR.Item("Department")
                                ComboBox3.Visible = True
                                ComboBox3.Items.Clear()
                                ComboBox3.Items.Add("NO")
                                ComboBox3.Items.Add("CD")
                                ComboBox3.Items.Add("DVD")
                                ComboBox3.Items.Add("FDD")
                                ComboBox3.Items.Add("Other")
                                ComboBox3.Items.Add("VCD")
                                ComboBox3.SelectedValue = RDR.Item("DigitalMedia")
                                Button4.Visible = True
                                Button5.Visible = True
                                Button6.Visible = True
                                Label2.Visible = True
                                RadioButton1.Visible = True
                                RadioButton2.Visible = True
                            Loop
                        Else
                            MsgBox("No record Found")
                            hideall()
                        End If
                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If ComboBox1.SelectedIndex = 0 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = "update Student set FirstName='" & TextBox3.Text & "', FatherName='" & TextBox4.Text & "', LastName='" & TextBox5.Text & "', RollNo='" & TextBox6.Text & "', EnrollNo='" & TextBox7.Text & "', Year='" & ComboBox5.SelectedItem.ToString() & "', Acad_Year='" & TextBox20.Text & "', IDCard='" & ComboBox7.SelectedItem.ToString() & "', IDNo='" & TextBox8.Text & "', MobileNo='" & TextBox9.Text & "', AltMobile='" & TextBox10.Text & "', Email='" & TextBox11.Text & "', HNo='" & TextBox12.Text & "', Street='" & TextBox13.Text & "', City='" & TextBox14.Text & "', PostOffice='" & TextBox15.Text & "', Tehsil='" & TextBox16.Text & "', State='" & TextBox18.Text & "', District='" & TextBox19.Text & "', Pincode='" & TextBox17.Text & "' where StudentID='" & TextBox1.Text & "'"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                MsgBox("Record Updated")
            ElseIf ComboBox1.SelectedIndex = 1 Then
                cmd = New SqlCommand
                cmd.Connection = conn
                query = "update Employee set FirstName='" & TextBox2.Text & "', FatherName='" & TextBox3.Text & "', LastName='" & TextBox4.Text & "', Department='" & ComboBox4.SelectedValue.ToString() & "', Category='" & ComboBox2.SelectedItem.ToString() & "', MobileNo='" & TextBox6.Text & "', AltMobile='" & TextBox7.Text & "', Email='" & TextBox8.Text & "', IDCard='" & ComboBox7.SelectedItem.ToString() & "', IDNo='" & TextBox5.Text & "', L_HNo='" & TextBox9.Text & "', L_Landmark='" & TextBox10.Text & "', L_City='" & TextBox11.Text & "', L_PostOffice='" & TextBox12.Text & "', L_Tehsil='" & TextBox13.Text & "', L_State='" & TextBox15.Text & "', L_District='" & TextBox16.Text & "', L_Pincode='" & TextBox14.Text & "', P_HNo='" & TextBox17.Text & "', P_Landmark='" & TextBox18.Text & "', P_City='" & TextBox19.Text & "', P_PostOffice='" & TextBox20.Text & "', P_Tehsil='" & TextBox21.Text & "', P_State='" & TextBox23.Text & "', P_District='" & TextBox24.Text & "', P_Pincode='" & TextBox22.Text & "' where EmployeeID='" & TextBox1.Text & "'"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                MsgBox("Record Updated")
            ElseIf ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Then
                ComboBox3.SelectedIndex = 0
                Dim phyavail As String = Nothing
                If RadioButton1.Checked = True Then
                    phyavail = "Yes"
                ElseIf RadioButton2.Checked = True Then
                    phyavail = "No"
                End If
                cmd = New SqlCommand
                cmd.Connection = conn
                query = "update " + ComboBox1.SelectedItem + " set BookTitle='" & TextBox2.Text & "', Author1='" & TextBox3.Text & "', Author2='" & TextBox4.Text & "', Author3='" & TextBox5.Text & "', Author4='" & TextBox6.Text & "', Edition='" & TextBox7.Text & "', Price='" & TextBox8.Text & "', DigitalMedia='" & ComboBox3.SelectedItem.ToString() & "', ISBN='" & TextBox9.Text & "', Department='" & ComboBox4.SelectedValue.ToString() & "', Publisher='" & TextBox11.Text & "', PhyAvailable='" & phyavail & "', Location='" & TextBox10.Text & "' where BookID='" & TextBox1.Text & "'"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                MsgBox("Record Updated")
            End If
        Catch ex As Exception
            MsgBox("Please recheck all details :" + vbCrLf + Err.Description)
        End Try

    End Sub
    Private Sub hideall()
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False

        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox15.Visible = False
        TextBox16.Visible = False
        TextBox17.Visible = False
        TextBox18.Visible = False
        TextBox19.Visible = False
        TextBox20.Visible = False
        TextBox21.Visible = False
        TextBox22.Visible = False
        TextBox23.Visible = False
        TextBox24.Visible = False

        ComboBox2.Visible = False
        ComboBox3.Visible = False
        ComboBox4.Visible = False
        ComboBox5.Visible = False
        ComboBox6.Visible = False
        ComboBox7.Visible = False
        ComboBox8.Visible = False

        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False

        TextBox1.Clear()
        Label2.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        hideall()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        hideall()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim addAnother = MessageBox.Show("For delete record you have to verify NO-DUES for member/book." & vbCrLf & " Do you want to switch on NO-DUES section ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, False)
        If addAnother = MsgBoxResult.Yes Then
            Dim frm As New AdNoDues
            frm.Show()
            frm.ComboBox1.SelectedIndex = ComboBox1.SelectedIndex
            frm.TextBox1.Text = TextBox1.Text
            frm.Label1.Text = "Press verify button..."
            frm.MdiParent = HomeAdmin
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        hideall()
    End Sub
End Class