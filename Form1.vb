Public Class Gregory_Chavez_Home_Utility_Auditing_Program
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Application.Restart()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectAppliance.SelectedIndexChanged

    End Sub

    Private Sub TextBoxInteger1_TextChanged(sender As Object, e As EventArgs) Handles txtCostPerKWH.TextChanged
        txtDailyCost.Text = CType(Val(txtCostPerKWH.Text) * Val(txtApplianceKWH.Text) * Val(txtHoursPerDay.Text), String)
    End Sub

    Private Sub TextBoxInteger1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCostPerKWH.Validating
        e.Cancel = Not IsTextInteger1(CType(sender, TextBox))
    End Sub

    Private Function IsTextInteger1(target As TextBox) As Boolean
        If target.TextLength = 0 Then Return True
        If Integer.TryParse(target.Text, Nothing) Then
            Return True
        Else
            MessageBox.Show("Text entered must be an integer.")
            target.SelectAll()
            Return False
        End If
    End Function

    Private Sub TextBoxValue1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCostPerKWH.Validating
        e.Cancel = Not TextBoxValue1(CType(sender, TextBox))
    End Sub

    Private Function TextBoxValue1(target As TextBox) As Boolean
        Dim value1 As Integer = 0

        If Integer.TryParse(target.Text, value1) Then
            If value1 > 0 Then
                Return True
            Else
                MessageBox.Show("No Negative Numbers")
                target.SelectAll()
                Return False
            End If
        End If
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtApplianceKWH.TextChanged
        txtDailyCost.Text = CType(Val(txtCostPerKWH.Text) * Val(txtApplianceKWH.Text) * Val(txtHoursPerDay.Text), String)
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApplianceKWH.Validating
        e.Cancel = Not IsTextInteger2(CType(sender, TextBox))
    End Sub

    Private Function IsTextInteger2(target As TextBox) As Boolean
        If target.TextLength = 0 Then Return True
        If Integer.TryParse(target.Text, Nothing) Then
            Return True
        Else
            MessageBox.Show("Text entered must be an integer.")
            target.SelectAll()
            Return False
        End If
    End Function

    Private Sub TextBoxValue2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApplianceKWH.Validating
        e.Cancel = Not TextBoxValue2(CType(sender, TextBox))
    End Sub

    Private Function TextBoxValue2(target As TextBox) As Boolean
        Dim value2 As Integer = 0

        If Integer.TryParse(target.Text, value2) Then
            If value2 > 0 Then
                Return True
            Else
                MessageBox.Show("No Negative Numbers")
                target.SelectAll()
                Return False
            End If
        End If
    End Function

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtHoursPerDay.TextChanged
        txtDailyCost.Text = CType(Val(txtCostPerKWH.Text) * Val(txtApplianceKWH.Text) * Val(txtHoursPerDay.Text), String)
    End Sub

    Private Sub TextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHoursPerDay.Validating
        e.Cancel = Not IsTextInteger3(CType(sender, TextBox))
    End Sub

    Private Function IsTextInteger3(target As TextBox) As Boolean
        If target.TextLength = 0 Then Return True
        If Integer.TryParse(target.Text, Nothing) Then
            Return True
        Else
            MessageBox.Show("Text entered must be an integer.")
            target.SelectAll()
            Return False
        End If
    End Function

    Private Sub TextBoxValue3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHoursPerDay.Validating
        e.Cancel = Not TextBoxValue3(CType(sender, TextBox))
    End Sub

    Private Function TextBoxValue3(target As TextBox) As Boolean
        Dim Value3 As Integer = 0
        If Integer.TryParse(target.Text, Value3) Then
            If Value3 > 0 Then
                Return True
            Else
                MessageBox.Show("No Negative Numbers")
                target.SelectAll()
                Return False
            End If
        End If
    End Function

    Private Sub TextBoxTimeFrame3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHoursPerDay.Validating
        e.Cancel = Not TextBoxTimeFrame3(CType(sender, TextBox))
    End Sub

    Private Function TextBoxTimeFrame3(target As TextBox) As Boolean
        Dim Value3 As Integer = 0
        If Integer.TryParse(target.Text, Value3) Then
            If Value3 > 1 Then
                If Value3 < 25 Then
                    'End If
                    Return True
                Else
                    MessageBox.Show("Enter an Integer between 1 and 24")
                    target.SelectAll()
                    Return False
                End If
            End If
        End If
    End Function

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)
        txtDailyCost.Text = CType(Val(txtCostPerKWH.Text) * Val(txtApplianceKWH.Text) * Val(txtHoursPerDay.Text), String)
    End Sub

    Private Sub txtDailyCost_TextChanged(sender As Object, e As EventArgs) Handles txtDailyCost.TextChanged
        txtDailyCost.Text = CType(Val(txtCostPerKWH.Text) * Val(txtApplianceKWH.Text) * Val(txtHoursPerDay.Text), String)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
