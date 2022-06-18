Imports ProcessHacker
Imports ProcessHacker.Common
Imports ProcessHacker.Native
Imports ProcessHacker.Native.Objects
Imports ProcessHacker.Native.Security
Imports ProcessHacker.Native.Symbols

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private WithEvents _threadP As ThreadProvider = Nothing

    Private Sub buttonWalk_Click(sender As Object, e As EventArgs) Handles buttonWalk.Click
        Dim processEx As Process = System.Diagnostics.Process.GetProcessById(TextBox1.Text)
        listViewCallStack.Items.Clear()

        _threadP = New ThreadProvider(processEx.Id)
        _threadP.LoadKernelSymbols()
        _threadP.Run()
    End Sub

    Private Sub _threadP_BeforeUpdate() Handles _threadP.BeforeUpdate
        listViewCallStack.Items.Clear()
    End Sub

    Private Sub _threadP_ResolveSybol(sender As Object, e As ThreadProvider.ResolveSybolData) Handles _threadP.ResolveSybol

        Me.BeginInvoke(Sub()
                           Debug.WriteLine("TID: " & e.TID & "  StartAdress: " & e.ResolveInfo.Symbol)
                           Dim ItemN As New ListViewItem
                           ItemN.Text = e.TID
                           ItemN.SubItems.Add(e.ResolveInfo.Symbol)
                           listViewCallStack.Items.Add(ItemN)
                       End Sub)

    End Sub

    Private Sub _threadP_Error(ex As Exception) Handles _threadP.[Error]
        MsgBox(ex.Message)
    End Sub

End Class
