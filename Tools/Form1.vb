Public Class Form1

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        If txtKey.Text.Trim <> "" And txtOpenSsssubKey.Text.Trim <> "" Then

            Dim regKey As Microsoft.Win32.RegistryKey

            Select Case cmdMainRoot.SelectedIndex
                Case 0 'HKEY CURRENT USER
                    regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(txtOpenSubKey.Text.Trim, True)
                Case 1 'HKEY LOCAL MACHINE
                    regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(txtOpenSubKey.Text.Trim, True)
                Case 2 'HKEY CLASSIC ROOT
                    regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(txtOpenSubKey.Text.Trim, True)
            End Select

            regKey.DeleteValue(txtKey.Text.Trim, False)
            txtKey.Text = ""
            LOAD()
            regKey.Close()

            'My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(txtKey.Text.Trim)
        Else
            MsgBox("You must be fill all of fields")
        End If
    End Sub

    Private Sub cmdMainRoot_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmdMainRoot.SelectedIndexChanged

        LOAD()

    End Sub

    Private Sub LOAD()
        Try
            Dim regKey As Microsoft.Win32.RegistryKey
            lstKeys.Items.Clear()

            Select Case cmdMainRoot.SelectedIndex
                Case 0 'HKEY CURRENT USER
                    regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(txtOpenSubKey.Text.Trim, False)
                Case 1 'HKEY LOCAL MACHINE
                    regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(txtOpenSubKey.Text.Trim, False)
                Case 2 'HKEY CLASSIC ROOT
                    regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(txtOpenSubKey.Text.Trim, False)
            End Select

            Dim Names = regKey.GetValueNames
            For Each Item In Names
                lstKeys.Items.Add(String.Format("{0} = {1}", Item, regKey.GetValue(Item)))
            Next
            regKey.Close()
        Catch ex As Exception
            Select Case Err.Number
                Case 91
                    MsgBox("Address is invalid,Change OpenSubKey path")
            End Select
        End Try
    End Sub


    Private Sub lstKeys_Click(sender As System.Object, e As System.EventArgs) Handles lstKeys.Click
        Dim s() As String = lstKeys.Items(lstKeys.SelectedIndex).ToString.Split("=")
        txtKey.Text = s(0).Trim
    End Sub
End Class
