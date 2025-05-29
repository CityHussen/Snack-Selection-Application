'Program Name; Free Snack
'Developer; City Hussen
'Date; 06/25/2022
'Purpose; This application displays four different types of healthy snacks.
'The user can choose the one they desire.

Public Class formfreeSnack

    Private Sub btnbeanburitto_Click(sender As Object, e As EventArgs) Handles btnbeanburitto.Click
        'This code is executed when the user Click the Beanburrito button.it displays
        'the picture od bean burrito,hides all other picture and enables the select button

        PicbeanBurrito.Visible = True
        PicFalafel.Visible = False
        PicGreekYoghurt.Visible = False
        PicSpringrolls.Visible = False
        btnSelectbutton.Enabled = True
    End Sub
    Private Sub btnSelectbutton_Click(sender As Object, e As EventArgs) Handles btnSelectbutton.Click
        'This code is executed when the user clicks the select button.It disables all
        'other buttons.Hides the description label and display the confirmation label.
        'enables the Exit window button

        btnbeanburitto.Enabled = False
        btnFalafel.Enabled = False
        btnGreekYoghurt.Enabled = False
        btnSpringRolls.Enabled = False
        btnSelectbutton.Enabled = False
        lbldescription.Visible = False
        lblConfirmation.Visible = True
        BtnExitWindow.Enabled = True

    End Sub

    Private Sub btnFalafel_Click(sender As Object, e As EventArgs) Handles btnFalafel.Click
        'This code is executed when the user clicks the Falafel Button .It displays the
        'Falafel Picture.hides all other pictures while enabling the select button

        PicFalafel.Visible = True
        PicbeanBurrito.Visible = False
        PicGreekYoghurt.Visible = False
        PicSpringrolls.Visible = False
        btnSelectbutton.Enabled = True

    End Sub
    Private Sub btnGreekYoghurt_Click(sender As Object, e As EventArgs) Handles btnGreekYoghurt.Click
        'This code is executed when the user clicks the Greek Yoghurt Button .It displays the
        'Falafel Picture.hides all other pictures while enabling the select button

        PicFalafel.Visible = False
        PicbeanBurrito.Visible = False
        PicGreekYoghurt.Visible = True
        PicSpringrolls.Visible = False
        btnSelectbutton.Enabled = True
    End Sub
    Private Sub btnSpringRolls_Click(sender As Object, e As EventArgs) Handles btnSpringRolls.Click
        'This code is executed when the user clicks the Spring Rolls Button .It displays the
        'Falafel Picture.hides all other pictures while enabling the select button

        PicFalafel.Visible = False
        PicbeanBurrito.Visible = False
        PicGreekYoghurt.Visible = False
        PicSpringrolls.Visible = True
        btnSelectbutton.Enabled = True
    End Sub

    Private Sub BtnExitWindow_Click(sender As Object, e As EventArgs) Handles BtnExitWindow.Click
        'This code is executed when the user clicks the Exit window button .
        'It closes the window and terminates the program execution.
        Close()
    End Sub

End Class
