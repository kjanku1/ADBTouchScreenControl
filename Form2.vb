Public Class Form2

    Private Sub ABC_Click(sender As Object, e As EventArgs) Handles ABC.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Buttonat_Click(sender As Object, e As EventArgs) Handles Buttonat.Click
        Shell("""Tools\adb.exe"" shell input text '@'")
    End Sub

    Private Sub Buttonnet_Click(sender As Object, e As EventArgs) Handles Buttonnet.Click
        Shell("""Tools\adb.exe"" shell input text '#'")
    End Sub

    Private Sub buttondolar_Click(sender As Object, e As EventArgs) Handles buttondolar.Click
        Shell("""Tools\adb.exe"" shell input text '$'")
    End Sub

    Private Sub buttonpro_Click(sender As Object, e As EventArgs) Handles buttonpro.Click
        Shell("""Tools\adb.exe"" shell input text '%'")
    End Sub

    Private Sub buttonbackslash_Click(sender As Object, e As EventArgs) Handles buttonbackslash.Click
        Shell("""Tools\adb.exe"" shell input text '\'")
    End Sub

    Private Sub buttonminus_Click(sender As Object, e As EventArgs) Handles buttonminus.Click
        Shell("""Tools\adb.exe"" shell input text '-'")
    End Sub

    Private Sub buttonequal_Click(sender As Object, e As EventArgs) Handles buttonequal.Click
        Shell("""Tools\adb.exe"" shell input text '='")
    End Sub

    Private Sub buttonleftbra_Click(sender As Object, e As EventArgs) Handles buttonleftbra.Click
        Shell("""Tools\adb.exe"" shell input text '('")
    End Sub

    Private Sub buttonrightbra_Click(sender As Object, e As EventArgs) Handles buttonrightbra.Click
        Shell("""Tools\adb.exe"" shell input text ')'")
    End Sub

    Private Sub buttonstar_Click(sender As Object, e As EventArgs) Handles buttonstar.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_STAR")
    End Sub

    Private Sub buttoncudzy_Click(sender As Object, e As EventArgs) Handles buttoncudzy.Click
        Shell("""Tools\adb.exe"" shell input text '\""'")
    End Sub

    Private Sub buttonapos_Click(sender As Object, e As EventArgs) Handles buttonapos.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_APOSTROPHE")
    End Sub

    Private Sub buttoncolon_Click(sender As Object, e As EventArgs) Handles buttoncolon.Click
        Shell("""Tools\adb.exe"" shell input text ':'")
    End Sub

    Private Sub buttonsemi_Click(sender As Object, e As EventArgs) Handles buttonsemi.Click
        Shell("""Tools\adb.exe"" shell input text ';'")
    End Sub

    Private Sub buttonexcla_Click(sender As Object, e As EventArgs) Handles buttonexcla.Click
        Shell("""Tools\adb.exe"" shell input text '!'")
    End Sub

    Private Sub buttonwat_Click(sender As Object, e As EventArgs) Handles buttonwat.Click
        Shell("""Tools\adb.exe"" shell input text '?'")
    End Sub

    Private Sub buttonunder_Click(sender As Object, e As EventArgs) Handles buttonunder.Click
        Shell("""Tools\adb.exe"" shell input text '_'")
    End Sub

    Private Sub buttonslash_Click(sender As Object, e As EventArgs) Handles buttonslash.Click
        Shell("""Tools\adb.exe"" shell input text '/'")
    End Sub

    Private Sub buttonspace_Click(sender As Object, e As EventArgs) Handles buttonspace.Click
        Shell("""Tools\adb.exe"" shell input text ' '")
    End Sub

    Private Sub buttoncoma_Click(sender As Object, e As EventArgs) Handles buttoncoma.Click
        Shell("""Tools\adb.exe"" shell input text ','")
    End Sub

    Private Sub buttondot_Click(sender As Object, e As EventArgs) Handles buttondot.Click
        Shell("""Tools\adb.exe"" shell input text '.'")
    End Sub
End Class