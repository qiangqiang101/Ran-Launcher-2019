Imports System.IO

Public Class frmPatchMaker

    Public PatchList As New List(Of PatchFile)

    Private Sub btnBrowsePD_Click(sender As Object, e As EventArgs) Handles btnBrowsePID.Click
        Try
            Dim fsd = New FolderSelectDialog()
            fsd.Title = "Select Patch Input Directory..."
            fsd.InitialDirectory = txtPatchInputDir.Text

            If fsd.ShowDialog(IntPtr.Zero) Then txtPatchInputDir.Text = fsd.FileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBrowsePOD_Click(sender As Object, e As EventArgs) Handles btnBrowsePOD.Click
        Try
            Dim fsd = New FolderSelectDialog()
            fsd.Title = "Select Patch Output Directory..."
            fsd.InitialDirectory = txtPatchOutputDir.Text

            If fsd.ShowDialog(IntPtr.Zero) Then txtPatchOutputDir.Text = fsd.FileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStartTask_Click(sender As Object, e As EventArgs) Handles btnStartTask.Click
        If String.IsNullOrWhiteSpace(txtPatchInputDir.Text) Then
            MsgBox("Please select Input Directory.", MsgBoxStyle.Critical, "Patch Maker")
        ElseIf String.IsNullOrWhiteSpace(txtPatchOutputDir.Text) Then
            MsgBox("Please select Output Directory.", MsgBoxStyle.Critical, "Patch Maker")
        Else
            lblStatus.Text = "Checking files..."


        End If
    End Sub

    Private Function ZipFilesInDirectory(dirPath As String) As List(Of PatchFile)
        For Each item As String In Directory.GetFiles(dirPath, "*.*", SearchOption.AllDirectories)
            Dim patchFile As New PatchFile()

        Next
    End Function
End Class
