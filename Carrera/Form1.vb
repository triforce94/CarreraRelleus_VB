
Public Class Form1
    Dim laps As New Stopwatch()
    Dim random As New Random
    Dim pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16 As Integer

#Region "Iniciar"
    Private Sub ButtonClick_Iniciar(sender As Object, e As EventArgs) Handles Button_iniciar.Click

        laps.Start()

        Dim list As New ArrayList
        Dim rand As New Random
        Dim index As Integer
        Dim item As Object

        For i As Integer = 1 To 4
            list.Add(i)
        Next i

        While list.Count > 0
            index = rand.Next(0, list.Count)

            item = list(index)

            list.RemoveAt(index)

            If item.ToString() = 1 Then
                BackgroundWorker1.RunWorkerAsync()
            End If

            If item.ToString() = 2 Then
                BackgroundWorker2.RunWorkerAsync()
            End If

            If item.ToString() = 3 Then
                BackgroundWorker3.RunWorkerAsync()
            End If

            If item.ToString() = 4 Then
                BackgroundWorker4.RunWorkerAsync()
            End If

        End While

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

        Button_iniciar.Enabled = False

    End Sub

#End Region

#Region "Descalificadors"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BackgroundWorker1.CancelAsync()
        Time1_1.Text = "DESCALIFICAT"
        BackgroundWorker5.CancelAsync()
        Time1_2.Text = "DESCALIFICAT"
        BackgroundWorker9.CancelAsync()
        Time1_3.Text = "DESCALIFICAT"
        BackgroundWorker13.CancelAsync()
        Time1_4.Text = "DESCALIFICAT"

        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackgroundWorker2.CancelAsync()
        Time2_1.Text = "DESCALIFICAT"
        BackgroundWorker6.CancelAsync()
        Time2_2.Text = "DESCALIFICAT"
        BackgroundWorker10.CancelAsync()
        Time2_3.Text = "DESCALIFICAT"
        BackgroundWorker14.CancelAsync()
        Time2_4.Text = "DESCALIFICAT"

        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BackgroundWorker3.CancelAsync()
        Time3_1.Text = "DESCALIFICAT"
        BackgroundWorker7.CancelAsync()
        Time3_2.Text = "DESCALIFICAT"
        BackgroundWorker11.CancelAsync()
        Time3_3.Text = "DESCALIFICAT"
        BackgroundWorker15.CancelAsync()
        Time3_4.Text = "DESCALIFICAT"

        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BackgroundWorker4.CancelAsync()
        Time4_1.Text = "DESCALIFICAT"
        BackgroundWorker8.CancelAsync()
        Time4_2.Text = "DESCALIFICAT"
        BackgroundWorker12.CancelAsync()
        Time4_3.Text = "DESCALIFICAT"
        BackgroundWorker16.CancelAsync()
        Time4_4.Text = "DESCALIFICAT"

        Button4.Enabled = False
    End Sub

#End Region

#Region "First Lap"

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker1.ReportProgress(i)

            If (BackgroundWorker1.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'Notificar el progreso de la tarea

        pos1 = e.ProgressPercentage

        PictureBox1_1.Location = New Point(100 + pos1, 86)

        If (pos1 = 100) Then

            BackgroundWorker5.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time1_1.Text = elapsedTime

        End If

        If Time2_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya1.Text = "GUANYADOR!"
            Button1.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker2.ReportProgress(i)

            If (BackgroundWorker2.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        'Notificar el progreso de la tarea

        pos2 = e.ProgressPercentage

        PictureBox2_1.Location = New Point(100 + pos2, 135)

        If (pos2 = 100) Then

            BackgroundWorker6.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time2_1.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya2.Text = "GUANYADOR!"
            Button2.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

    Private Sub BackgroundWorker3_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker3.ReportProgress(i)

            If (BackgroundWorker3.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker3_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker3.ProgressChanged
        'Notificar el progreso de la tarea

        pos3 = e.ProgressPercentage

        PictureBox3_1.Location = New Point(100 + pos3, 184)

        If (pos3 = 100) Then

            BackgroundWorker7.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time3_1.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time2_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya3.Text = "GUANYADOR!"
            Button3.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

    Private Sub BackgroundWorker4_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker4.ReportProgress(i)

            If (BackgroundWorker4.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker4_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker4.ProgressChanged
        'Notificar el progreso de la tarea

        pos4 = e.ProgressPercentage

        PictureBox4_1.Location = New Point(100 + pos4, 235)

        If (pos4 = 100) Then

            BackgroundWorker8.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time4_1.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time2_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" Then

            Guanya4.Text = "GUANYADOR!"
            Button4.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker4_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker4.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

#End Region

#Region "Second Lap"

    Private Sub BackgroundWorker5_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker5.DoWork

        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker5.ReportProgress(i)

            If (BackgroundWorker5.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker5_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker5.ProgressChanged
        'Notificar el progreso de la tarea

        pos5 = e.ProgressPercentage

        PictureBox1_2.Location = New Point(230 + pos5, 86)

        If (pos5 = 100) Then

            BackgroundWorker9.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time1_2.Text = elapsedTime

        End If

        If Time2_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya1.Text = "GUANYADOR!"
            Button1.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker5_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker5.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

    Private Sub BackgroundWorker6_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker6.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker6.ReportProgress(i)

            If (BackgroundWorker6.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker6_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker6.ProgressChanged
        'Notificar el progreso de la tarea

        pos6 = e.ProgressPercentage

        PictureBox2_2.Location = New Point(230 + pos6, 135)

        If (pos6 = 100) Then

            BackgroundWorker10.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time2_2.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya2.Text = "GUANYADOR!"
            Button2.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker6_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker5.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

    Private Sub BackgroundWorker7_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker7.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker7.ReportProgress(i)

            If (BackgroundWorker7.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker7_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker7.ProgressChanged
        'Notificar el progreso de la tarea

        pos7 = e.ProgressPercentage

        PictureBox3_2.Location = New Point(230 + pos7, 184)

        If (pos7 = 100) Then

            BackgroundWorker11.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time3_2.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time2_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya3.Text = "GUANYADOR!"
            Button3.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker7_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker7.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

    Private Sub BackgroundWorker8_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker8.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker8.ReportProgress(i)

            If (BackgroundWorker8.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker8_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker8.ProgressChanged
        'Notificar el progreso de la tarea

        pos8 = e.ProgressPercentage

        PictureBox4_2.Location = New Point(230 + pos8, 235)

        If (pos8 = 100) Then

            BackgroundWorker12.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time4_2.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time2_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" Then

            Guanya4.Text = "GUANYADOR!"
            Button4.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker8_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker8.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

#End Region

#Region "Third Lap"

    Private Sub BackgroundWorker9_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker9.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker9.ReportProgress(i)

            If (BackgroundWorker9.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker9_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker9.ProgressChanged
        'Notificar el progreso de la tarea

        pos9 = e.ProgressPercentage

        PictureBox1_3.Location = New Point(360 + pos9, 86)

        If (pos9 = 100) Then

            BackgroundWorker13.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time1_3.Text = elapsedTime

        End If

        If Time2_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya1.Text = "GUANYADOR!"
            Button1.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker9_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker9.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

    Private Sub BackgroundWorker10_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker10.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker10.ReportProgress(i)

            If (BackgroundWorker10.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker10_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker10.ProgressChanged
        'Notificar el progreso de la tarea

        pos10 = e.ProgressPercentage

        PictureBox2_3.Location = New Point(360 + pos10, 135)

        If (pos10 = 100) Then

            BackgroundWorker14.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time2_3.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya2.Text = "GUANYADOR!"
            Button2.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker10_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker10.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

    Private Sub BackgroundWorker11_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker11.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker11.ReportProgress(i)

            If (BackgroundWorker11.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker11_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker11.ProgressChanged
        'Notificar el progreso de la tarea

        pos11 = e.ProgressPercentage

        PictureBox3_3.Location = New Point(360 + pos11, 184)

        If (pos11 = 100) Then

            BackgroundWorker15.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time3_3.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time2_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya3.Text = "GUANYADOR!"
            Button3.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker11_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker11.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

    Private Sub BackgroundWorker12_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker12.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker12.ReportProgress(i)

            If (BackgroundWorker12.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackgroundWorker12_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker12.ProgressChanged
        'Notificar el progreso de la tarea

        pos12 = e.ProgressPercentage

        PictureBox4_3.Location = New Point(360 + pos12, 235)

        If (pos12 = 100) Then

            BackgroundWorker16.RunWorkerAsync()

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time4_3.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time2_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" Then

            Guanya4.Text = "GUANYADOR!"
            Button4.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker12_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker12.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

    End Sub

#End Region

#Region "Fourth Lap"

    Private Sub BackgroundWorker13_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker13.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker13.ReportProgress(i)

            If (BackgroundWorker13.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker13_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker13.ProgressChanged
        'Notificar el progreso de la tarea

        pos13 = e.ProgressPercentage

        PictureBox1_4.Location = New Point(490 + pos13, 86)

        If (pos13 = 100) Then

            Button1.Enabled = False

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time1_4.Text = elapsedTime

        End If

        If Time2_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya1.Text = "GUANYADOR!"
            Button1.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker13_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker13.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

        If Time1_4.Text = "DESCALIFICAT" Then

            Guanya1.Visible = False

        Else

            If (BackgroundWorker14.IsBusy Or Time2_4.Text = "DESCALIFICAT") And (BackgroundWorker15.IsBusy Or Time3_4.Text = "DESCALIFICAT") AndAlso (BackgroundWorker16.IsBusy Or Time4_4.Text = "DESCALIFICAT") Then

                Guanya1.Text = "GUANYADOR!"
                Button1.Enabled = False
                Button_reiniciar.Enabled = True

            End If

        End If

    End Sub

    Private Sub BackgroundWorker14_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker14.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker14.ReportProgress(i)

            If (BackgroundWorker14.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker14_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker14.ProgressChanged
        'Notificar el progreso de la tarea

        pos14 = e.ProgressPercentage

        PictureBox2_4.Location = New Point(490 + pos14, 135)

        If (pos14 = 100) Then

            Button2.Enabled = False

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time2_4.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya2.Text = "GUANYADOR!"
            Button2.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker14_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker14.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

        If Time2_4.Text = "DESCALIFICAT" Then

            Guanya2.Visible = False

        Else

            If (BackgroundWorker13.IsBusy Or Time1_4.Text = "DESCALIFICAT") And (BackgroundWorker15.IsBusy Or Time3_4.Text = "DESCALIFICAT") AndAlso (BackgroundWorker16.IsBusy Or Time4_4.Text = "DESCALIFICAT") Then

                Guanya2.Text = "GUANYADOR!"
                Button2.Enabled = False
                Button_reiniciar.Enabled = True

            End If

        End If

    End Sub

    Private Sub BackgroundWorker15_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker15.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker15.ReportProgress(i)

            If (BackgroundWorker15.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker15_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker15.ProgressChanged
        'Notificar el progreso de la tarea

        pos15 = e.ProgressPercentage

        PictureBox3_4.Location = New Point(490 + pos15, 184)

        If (pos15 = 100) Then

            Button3.Enabled = False

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time3_4.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time2_4.Text = "DESCALIFICAT" And Time4_4.Text = "DESCALIFICAT" Then

            Guanya3.Text = "GUANYADOR!"
            Button3.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker15_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker15.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

        If Time3_4.Text = "DESCALIFICAT" Then

            Guanya3.Visible = False

        Else

            If (BackgroundWorker13.IsBusy Or Time1_4.Text = "DESCALIFICAT") And (BackgroundWorker14.IsBusy Or Time2_4.Text = "DESCALIFICAT") AndAlso (BackgroundWorker16.IsBusy Or Time4_4.Text = "DESCALIFICAT") Then

                Guanya3.Text = "GUANYADOR!"
                Button3.Enabled = False
                Button_reiniciar.Enabled = True

            End If

        End If

    End Sub

    Private Sub BackgroundWorker16_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker16.DoWork
        For i As Integer = 1 To 100

            Dim rand As Integer = random.Next(0, 200) + 1

            System.Threading.Thread.Sleep(rand)

            BackgroundWorker16.ReportProgress(i)

            If (BackgroundWorker16.CancellationPending) Then

                Return

            End If
        Next

    End Sub

    Private Sub BackgroundWorker16_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker16.ProgressChanged
        'Notificar el progreso de la tarea

        pos16 = e.ProgressPercentage

        PictureBox4_4.Location = New Point(490 + pos16, 235)

        If (pos16 = 100) Then

            Button4.Enabled = False

            Dim ts As TimeSpan = laps.Elapsed

            Dim elapsedTime As String = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            Time4_4.Text = elapsedTime

        End If

        If Time1_4.Text = "DESCALIFICAT" And Time2_4.Text = "DESCALIFICAT" And Time3_4.Text = "DESCALIFICAT" Then

            Guanya4.Text = "GUANYADOR!"
            Button4.Enabled = False
            Button_reiniciar.Enabled = True

        End If

    End Sub

    Private Sub BackgroundWorker16_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker16.RunWorkerCompleted

        'Realizamos las operaciones que haya que realizar al terminar el progreso

        If Time4_4.Text = "DESCALIFICAT" Then

            Guanya4.Visible = False

        Else

            If (BackgroundWorker13.IsBusy Or Time1_4.Text = "DESCALIFICAT") And (BackgroundWorker14.IsBusy Or Time2_4.Text = "DESCALIFICAT") AndAlso (BackgroundWorker15.IsBusy Or Time3_4.Text = "DESCALIFICAT") Then

                Guanya4.Text = "GUANYADOR!"
                Button4.Enabled = False
                Button_reiniciar.Enabled = True

            End If

        End If

    End Sub

#End Region

#Region "Reiniciar"

    Private Sub ButtonClick_Reiniciar(sender As Object, e As EventArgs) Handles Button_reiniciar.Click

        Application.Restart()

    End Sub

#End Region

End Class
