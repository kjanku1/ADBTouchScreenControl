Imports System.IO
Imports System.Threading
Imports System.Windows.Forms.DialogResult

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists("Tools") Then
            Directory.CreateDirectory("Tools")
        Else
            If Not File.Exists("Tools\adb.exe") Then
                File.WriteAllBytes("Tools\adb.exe", My.Resources.adb)
            End If
            If Not File.Exists("Tools\AdbWinApi.dll") Then
                File.WriteAllBytes("Tools\AdbWinApi.dll", My.Resources.AdbWinApi)
            End If
            If Not File.Exists("Tools\AdbWinUsbApi.dll") Then
                File.WriteAllBytes("Tools\AdbWinUsbApi.dll", My.Resources.AdbWinUsbApi)
            End If
            If Not File.Exists("Tools\droidAtScreen-1.1.jar") Then
                File.WriteAllBytes("Tools\droidAtScreen-1.1.jar", My.Resources.droidAtScreen_1_1)
            End If
            Shell("cmd.exe /c" & "start Tools\droidAtScreen-1.1.jar")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Select Case ComboBox1.Text
            Case "1440x2560"
                Shell("""Tools\adb.exe"" shell input swipe 562 1800 1440 1800")
            Case "1080x1920"
                Shell("""Tools\adb.exe"" shell input swipe 722 1390 1340 1390")
            Case "800x1280"
                Shell("""Tools\adb.exe"" shell input swipe 400 900 740 900")
            Case "768x1280"
                Shell("""Tools\adb.exe"" shell input swipe 300 900 720 900")
            Case "720x1280"
                Shell("""Tools\adb.exe"" shell input swipe 359 907 660 907")
            Case "720x1200"
                Shell("""Tools\adb.exe"" shell input swipe 360 850 660 850")
            Case "540x960"
                Shell("""Tools\adb.exe"" shell input swipe 270 680 509 676")
            Case "480x800"
                Shell("""Tools\adb.exe"" shell input swipe 240 570 560 570")
            Case "400x800"
                Shell("""Tools\adb.exe"" shell input swipe 200 570 560 570")
            Case "240x320"
                Shell("""Tools\adb.exe"" shell input swipe 120 230 213 230")
            Case Else
                MsgBox("Choose you're devices resolution")
        End Select
    End Sub
    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        Select Case ComboBox1.Text
            Case "1440x2560"
                Shell("""Tools\adb.exe"" shell input swipe 562 1800 1440 1800")
            Case "1080x1920"
                Shell("""Tools\adb.exe"" shell input swipe 722 1390 1340 1390")
            Case "800x1280"
                Shell("""Tools\adb.exe"" shell input swipe 400 900 740 900")
            Case "768x1280"
                Shell("""Tools\adb.exe"" shell input swipe 300 900 720 900")
            Case "720x1280"
                Shell("""Tools\adb.exe"" shell input swipe 359 907 660 907")
            Case "720x1200"
                Shell("""Tools\adb.exe"" shell input swipe 360 850 660 850")
            Case "540x960"
                Shell("""Tools\adb.exe"" shell input swipe 270 680 509 676")
            Case "480x800"
                Shell("""Tools\adb.exe"" shell input swipe 240 570 560 570")
            Case "400x800"
                Shell("""Tools\adb.exe"" shell input swipe 200 570 560 570")
            Case "240x320"
                Shell("""Tools\adb.exe"" shell input swipe 120 230 213 230")
            Case Else
                MsgBox("Choose you're devices resolution")
        End Select
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Shell("""Tools\adb.exe"" shell input text '" & TextBox1.Text & "'")
            TextBox1.Clear()
        End If
    End Sub
    'numerki
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" & Button1.Text)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Button2.Text)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Button3.Text)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Button4.Text)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Button5.Text)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Button6.Text)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Button7.Text)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Button8.Text)
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Button9.Text)
    End Sub
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Button0.Text)
    End Sub

    'literki
    Private Sub Buttonq_Click(sender As Object, e As EventArgs) Handles Buttonq.Click
        Shell("""Tools\adb.exe"" input keyevent KEYCODE_" + Buttonq.Text)
    End Sub
    Private Sub Buttonw_Click(sender As Object, e As EventArgs) Handles Buttonw.Click
        Shell("""Tools\adb.exe"" input keyevent KEYCODE_" + Buttonw.Text)
    End Sub
    Private Sub Buttone_Click(sender As Object, e As EventArgs) Handles Buttone.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttone.Text)
    End Sub
    Private Sub Buttonr_Click(sender As Object, e As EventArgs) Handles Buttonr.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonr.Text)
    End Sub
    Private Sub Buttont_Click(sender As Object, e As EventArgs) Handles Buttont.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttont.Text)
    End Sub
    Private Sub Buttony_Click(sender As Object, e As EventArgs) Handles Buttony.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttony.Text)
    End Sub
    Private Sub Buttonu_Click(sender As Object, e As EventArgs) Handles Buttonu.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonu.Text)
    End Sub
    Private Sub Buttoni_Click(sender As Object, e As EventArgs) Handles Buttoni.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttoni.Text)
    End Sub
    Private Sub Buttono_Click(sender As Object, e As EventArgs) Handles Buttono.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttono.Text)
    End Sub
    Private Sub Buttonp_Click(sender As Object, e As EventArgs) Handles Buttonp.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonp.Text)
    End Sub
    Private Sub Buttona_Click(sender As Object, e As EventArgs) Handles Buttona.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttona.Text)
    End Sub
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles Buttons.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttons.Text)
    End Sub
    Private Sub Buttond_Click(sender As Object, e As EventArgs) Handles Buttond.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttond.Text)
    End Sub
    Private Sub Buttonf_Click(sender As Object, e As EventArgs) Handles Buttonf.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonf.Text)
    End Sub
    Private Sub Buttong_Click(sender As Object, e As EventArgs) Handles Buttong.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttong.Text)
    End Sub
    Private Sub Buttonh_Click(sender As Object, e As EventArgs) Handles Buttonh.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonh.Text)
    End Sub
    Private Sub Buttonj_Click(sender As Object, e As EventArgs) Handles Buttonj.Click
        Shell("""Tools\adb.exe""b shell input keyevent KEYCODE_" + Buttonj.Text)
    End Sub
    Private Sub Buttonk_Click(sender As Object, e As EventArgs) Handles Buttonk.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonk.Text)
    End Sub
    Private Sub Buttonl_Click(sender As Object, e As EventArgs) Handles Buttonl.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonl.Text)
    End Sub
    Private Sub Buttonz_Click(sender As Object, e As EventArgs) Handles Buttonz.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonz.Text)
    End Sub
    Private Sub Buttonx_Click(sender As Object, e As EventArgs) Handles Buttonx.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonx.Text)
    End Sub
    Private Sub Buttonc_Click(sender As Object, e As EventArgs) Handles Buttonc.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonc.Text)
    End Sub
    Private Sub Buttonv_Click(sender As Object, e As EventArgs) Handles Buttonv.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonv.Text)
    End Sub
    Private Sub Buttonb_Click(sender As Object, e As EventArgs) Handles Buttonb.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonb.Text)
    End Sub
    Private Sub Buttonn_Click(sender As Object, e As EventArgs) Handles Buttonn.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonn.Text)
    End Sub
    Private Sub Buttonm_Click(sender As Object, e As EventArgs) Handles Buttonm.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_" + Buttonm.Text)
    End Sub
    'specials

    Private Sub Buttonback_Click(sender As Object, e As EventArgs) Handles Buttonback.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_DEL")
    End Sub

    Private Sub Buttonspace_Click(sender As Object, e As EventArgs) Handles Buttonspace.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_SPACE")
    End Sub

    Private Sub Buttonenter_Click(sender As Object, e As EventArgs) Handles Buttonenter.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_ENTER")
    End Sub

    Private Sub Buttoncomma_Click(sender As Object, e As EventArgs) Handles Buttoncomma.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_COMMA")
    End Sub

    Private Sub Buttondot_Click(sender As Object, e As EventArgs) Handles Buttondot.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_PERIOD")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_BACK")
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_HOME")
    End Sub

    Private Sub Apps_Click(sender As Object, e As EventArgs) Handles Apps.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_APP_SWITCH")
    End Sub

    Private Sub Up_Click(sender As Object, e As EventArgs) Handles Up.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_DPAD_UP")
    End Sub

    Private Sub Left_Click(sender As Object, e As EventArgs) Handles bLeft.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_DPAD_LEFT")
    End Sub

    Private Sub Down_Click(sender As Object, e As EventArgs) Handles Down.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_DPAD_DOWN")
    End Sub

    Private Sub Right_Click(sender As Object, e As EventArgs) Handles bRight.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_DPAD_RIGHT")
    End Sub

    Private Sub Center_Click(sender As Object, e As EventArgs) Handles Center.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_DPAD_CENTER")
    End Sub

    Private Sub bsym_Click(sender As Object, e As EventArgs) Handles bsym.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Powerbtn_Click(sender As Object, e As EventArgs) Handles Powerbtn.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_POWER")
    End Sub

    Private Sub adb_Click(sender As Object, e As EventArgs) Handles adb.Click
        Shell("cmd.exe /k cd Tools && color 02 && title adb path")
    End Sub

    Private Sub Buttoncaps_Click(sender As Object, e As EventArgs) Handles Buttoncaps.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_CAPS_LOCK")
    End Sub

    Private Sub Buttonslash_Click(sender As Object, e As EventArgs) Handles Buttonslash.Click
        Shell("""Tools\adb.exe"" shell input text '/'")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Shell("""Tools\adb.exe"" shell su -c " & """rm /data/system/*.key""")
        Shell("""Tools\adb.exe"" shell su -c " & """rm /data/system/*.db""")
        Shell("""Tools\adb.exe"" shell su -c " & """rm /data/system/*.db-shm""")
        Shell("""Tools\adb.exe"" shell su -c " & """rm /data/system/*.db-wal""")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Shell("""Tools\adb.exe"" reboot")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Shell("""Tools\adb.exe"" reboot recovery")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Shell("""Tools\adb.exe"" shell su -c " & """poweroff""")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Gestures.Show()
    End Sub

    Private Sub AndroidControlByToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AndroidControlByToolStripMenuItem.Click
        'ShellExecute ByVal 0&, "open", _
        '"http://forum.xda-developers.com/showthread.php?t=2786395", _
        'vbNullString, vbNullString, 
        System.Diagnostics.Process.Start("http://forum.xda-developers.com/showthread.php?t=2786395")
    End Sub

    Private Sub Version010ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Version010ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/kjanku1/WindowsApplication1/commits/master")
    End Sub
End Class
