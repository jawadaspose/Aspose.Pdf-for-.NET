﻿Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeNUp
    Public Class MakeNUpUsingPageSizeAndStreams
        Public Shared Sub Run()
            ' ExStart:MakeNUpUsingPageSizeAndStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("input.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("MakeNUpUsingPageSizeAndStreams_out_.pdf"), FileMode.Create)
            ' Make NUp
            pdfEditor.MakeNUp(inputStream, outputStream, 2, 3, PageSize.A5)
            ' ExEnd:MakeNUpUsingPageSizeAndStreams
        End Sub
    End Class
End Namespace
