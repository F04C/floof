Imports System.Drawing

Public Class Form1
    ' Define a setting to store the last position
    Private Property LastFormPosition As Point
        Get
            If My.Settings.LastFormPosition.IsEmpty Then
                ' Default position if it has not been set yet
                Return New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2,
                                 (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2)
            Else
                Return My.Settings.LastFormPosition
            End If
        End Get
        Set(value As Point)
            My.Settings.LastFormPosition = value
            My.Settings.Save()
        End Set
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the last position when the form is loaded
        Me.Location = LastFormPosition
        Me.TopMost = True
        UpdateTime() ' Call the method to update the time

        ' Show the NotifyIcon immediately
        NotifyIcon1.Visible = True

        ' Enable the Timer to update the time every second
        Timer1.Enabled = True
    End Sub

    Private Sub UpdateTime()
        Dim currentDateTime As DateTime = DateTime.Now
        Dim adjustedTime As DateTime = currentDateTime.AddHours(-7)

        ' Use "hh" for 12-hour clock format, "tt" for AM/PM designator
        LabelAdjustedTime.Text = adjustedTime.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateTime()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Save the current form position when the form is closing
        LastFormPosition = Me.Location
    End Sub

    ' Handle the NotifyIcon click event to show the form
    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class
