Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module validationMod

    Function presenceCheck(ByVal textbox As String) 'the value textbox is used which will be passed into by (name of textbox).Text when used for presence checking
        If textbox = "" Then 'if the text box is empty return false, meaning validation has failed.
            Return False
        Else

            Return True 'if text box has text, return true, meaning validation succeeded. o/
            End If
        End Function


End Module
