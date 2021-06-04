Module FormHelper
    Sub clearForms(ParamArray textbox() As TextBox)
        For i As Integer = 0 To UBound(textbox, 1)
            textbox(i).Clear()
        Next
    End Sub

    Sub enableForms(ParamArray textbox() As TextBox)
        For i As Integer = 0 To UBound(textbox, 1)
            textbox(i).Enabled = True
        Next
    End Sub

    Sub disableForms(ParamArray textbox() As TextBox)
        For i As Integer = 0 To UBound(textbox, 1)
            textbox(i).Enabled = False
        Next
    End Sub
    Sub enableButton(ParamArray button() As Button)
        For i As Integer = 0 To UBound(button, 1)
            button(i).Enabled = True
        Next
    End Sub

    Sub disableButton(ParamArray button() As Button)
        For i As Integer = 0 To UBound(button, 1)
            button(i).Enabled = False
        Next
    End Sub

End Module
