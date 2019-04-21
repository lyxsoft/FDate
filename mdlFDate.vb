﻿Imports System
Imports System.IO

Module mdlFDate

    Sub Main()
        If My.Application.CommandLineArgs.Count = 2 Then
            If IsDate(My.Application.CommandLineArgs(1)) Then
                Try
                    File.SetCreationTime(My.Application.CommandLineArgs(0), My.Application.CommandLineArgs(1))
                    File.SetLastWriteTime(My.Application.CommandLineArgs(0), My.Application.CommandLineArgs(1))
                    Console.WriteLine(My.Application.CommandLineArgs(0) & " set to " & Format(CDate(My.Application.CommandLineArgs(1)), "yyyy-MM-dd HH:mm"))
                Catch ex As FileNotFoundException
                    Console.WriteLine("File not found: " & My.Application.CommandLineArgs(0))
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
                Exit Sub
            End If
        End If
        Console.WriteLine("FDate - Command-line tool to change file date." & vbCrLf &
                          "Usage:" & vbCrLf &
                          "FDate [FileFullName] [YYYY-MM-dd HH:mm]")
    End Sub

End Module
