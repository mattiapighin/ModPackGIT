﻿Namespace LOG
    Module Module_Log

        Dim FileLog As String = My.Settings.FileLogPath

        Public Sub CheckSize()
            Try
                'Se il log non esiste o viene eliminato lo crea
                If Not My.Computer.FileSystem.FileExists(FileLog) Then
                    IO.File.Create(FileLog)
                Else

                    'Controlla la dimensione, se supera il mb ne crea una copia di backup e pulisce quello in uso
                    Dim infoReader As System.IO.FileInfo
                    infoReader = My.Computer.FileSystem.GetFileInfo(My.Settings.FileLogPath)

                    Debug.WriteLine("Log file size : " & infoReader.Length)
                    Debug.WriteLine("Log file size : " & infoReader.DirectoryName)

                    If infoReader.Length > My.Settings.MaxLengthLog Then

                        IO.File.Copy(FileLog, infoReader.DirectoryName & "\BackupLog.txt", True)

                    End If
                    LOG.Clean()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub Clean()
            Try
                IO.File.WriteAllText(FileLog, "")
                LOG.Write("Pulizia LOG effettuata")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub Show()
            Try
                Process.Start(FileLog)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub Write(ByVal Stringa As String)
            Try

                Select Case My.Settings.LogType
                    Case "normal"
                        Dim contenuto As String = IO.File.ReadAllText(FileLog)
                        IO.File.WriteAllText(FileLog, "")
                        IO.File.AppendAllText(FileLog, DateTime.Now & " [" & System.Environment.UserName & "] " & Stringa & vbCrLf & contenuto)
                    Case "light"
                        IO.File.AppendAllText(FileLog, DateTime.Now & " [" & System.Environment.UserName & "] " & Stringa & vbCrLf)
                    Case Else
                        'Niente log
                End Select

                Debug.WriteLine(Stringa)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Module
End Namespace
