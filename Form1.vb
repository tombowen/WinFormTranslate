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

    Public Async Sub OneShotRecognitionWithMicrophone()
        'System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Dim config = SpeechConfig.FromSubscription("8c2a080e80a4489bbc8fc4fcbfa10e29", "eastus")
        Dim recognizer = New SpeechRecognizer(config)

        Using (recognizer)
            Dim result = Await recognizer.RecognizeOnceAsync.ConfigureAwait(False)

            If result.Reason = ResultReason.RecognizedSpeech Then
                SetText(result.Text)
            End If
        End Using

    End Sub

    Public Async Sub ContinuousRecognitionWithMicrophone()

        Dim config = SpeechConfig.FromSubscription("8c2a080e80a4489bbc8fc4fcbfa10e29", "eastus")
        Dim recognizer = New SpeechRecognizer(config)

        Using (recognizer)
            'Dim result = Await recognizer.StartContinuousRecognitionAsync.ConfigureAwait(False)

            Dim result = Await recognizer.StartContinuousRecognitionAsync.ConfigureAwait(True)

            If result.Reason = ResultReason.RecognizedSpeech Then
                SetText2(result.Text)
            End If
        End Using

    End Sub

    Private Sub BtnOneShot_Click(sender As Object, e As EventArgs) Handles btnOneShot.Click
        Call OneShotRecognitionWithMicrophone()
    End Sub


    Private Sub SetText(ByVal [text] As String)

        If Me.InvokeRequired Then
            Me.Invoke(Sub()
                          TextBox1.Text = text
                      End Sub)
        Else
            TextBox1.Text = text
        End If

    End Sub

    Private Sub SetText2(ByVal [text] As String)

        If Me.InvokeRequired Then
            Me.Invoke(Sub()
                          TextBox2.Text += text
                      End Sub)
        Else
            TextBox2.Text += text
        End If

    End Sub

    Private Sub BtnContinuous_Click(sender As Object, e As EventArgs) Handles btnContinuous.Click

        ContinuousRecognitionWithMicrophone()

    End Sub


End Class


