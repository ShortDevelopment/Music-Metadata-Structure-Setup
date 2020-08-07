Imports System.IO
Imports Microsoft.WindowsAPICodePack.Shell
Imports Microsoft.WindowsAPICodePack.Shell.PropertySystem

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        With My.Computer.FileSystem

            For Each InterpretDir In .GetDirectories(TextBox1.Text)
                For Each AlbumDir In .GetDirectories(InterpretDir)
                    For Each FilePath In .GetFiles(AlbumDir).Where(Function(x) Path.GetExtension(x) = ".mp3")
                        Dim file = ShellObject.FromParsingName(FilePath)
                        Dim properties = file.Properties.GetPropertyWriter()
                        properties.WriteProperty(SystemProperties.System.Music.AlbumTitle, Path.GetFileName(AlbumDir))
                        properties.WriteProperty(SystemProperties.System.Music.Artist, Path.GetFileName(InterpretDir))
                        properties.WriteProperty(SystemProperties.System.Title, Path.GetFileNameWithoutExtension(FilePath))
                        properties.Close()
                    Next
                Next
            Next

        End With

    End Sub
End Class
