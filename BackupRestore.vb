Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class BackupRestore


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ComboBox1.SelectedIndex = 0 Then
            'backup
            Try
                '  conn.Close()
                '   My.Computer.FileSystem.CopyFile("C:\Program Files\PRAKASH TECHNOLOGIES\Library Automation System\LibraryData.mdf", "E:\DB_BKP\Library Automation System\LibraryData.mdf", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                '   My.Computer.FileSystem.CopyFile("C:\Program Files\PRAKASH TECHNOLOGIES\Library Automation System\LibraryData_log.ldf", "E:\DB_BKP\Library Automation System\LibraryData_log.ldf", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                MsgBox("Will be soon" + vbCrLf + "Please go manualy to backup database")
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Critical)
            End Try
        ElseIf ComboBox1.SelectedIndex = 1 Then
            'restore
            Try
                'conn.Close()
                '  My.Computer.FileSystem.CopyFile("E:\DB_BKP\Library Automation System\LibraryData.mdf", "C:\Program Files\PRAKASH TECHNOLOGIES\Library Automation System\LibraryData.mdf", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                '   My.Computer.FileSystem.CopyFile("E:\DB_BKP\Library Automation System\LibraryData_log.ldf", "C:\Program Files\PRAKASH TECHNOLOGIES\Library Automation System\LibraryData_log.ldf", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                MsgBox("Will be soon" + vbCrLf + "Please go manualy to restore database")
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub BackupRestore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
End Class
