Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Microsoft.CognitiveServices.Speech
Imports Microsoft.CognitiveServices.Speech.Audio
Imports Microsoft.CognitiveServices.Speech.PronunciationAssessment


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Async Sub RecognitionWithMicrophone()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Dim config = SpeechConfig.FromSubscription("8c2a080e80a4489bbc8fc4fcbfa10e29", "eastus")
        Dim recognizer = New SpeechRecognizer(config)

        Using (recognizer)
            Dim result = Await recognizer.RecognizeOnceAsync.ConfigureAwait(False)

            'TextBox2.Text = result.Text

            If result.Reason = ResultReason.RecognizedSpeech Then
                TextBox1.Text = ""
                'Dim threadParameters = New System.Threading.ThreadStart(AddressOf WriteTextSafe("This is safe."))
                TextBox1.Text = result.Text
            End If

        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call RecognitionWithMicrophone()
    End Sub

    Private Sub WriteTextSafe()

    End Sub

End Class


