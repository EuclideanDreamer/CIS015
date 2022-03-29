' Name:         Discount Project
' Purpose:     Display a discount based on the selection from a tect box
' Programmer:   <Bailey Nichols> on <3/17/2022>
Option Explicit On
Option Strict On
Option Infer Off
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblOrigPrice As Double = 0
        Dim dblDiscountRate As Double = 0
        'first select what discount
        If ListBox1.SelectedIndex = 0 Then '10
            dblDiscountRate = 0.9
        ElseIf ListBox1.SelectedIndex = 1 Then '15
            dblDiscountRate = 0.85
        ElseIf ListBox1.SelectedIndex = 2 Then '20
            dblDiscountRate = 0.8
        ElseIf ListBox1.SelectedIndex = 3 Then '25
            dblDiscountRate = 0.75
        ElseIf ListBox1.SelectedIndex = 4 Then '30
            dblDiscountRate = 0.7
        ElseIf ListBox1.SelectedIndex = 5 Then '35
            dblDiscountRate = 0.65
        ElseIf ListBox1.SelectedIndex = 1 Then '40
            dblDiscountRate = 0.6
        End If
        'get number 
        dblOrigPrice = Double.Parse(tbPrice.Text)
        'now multiply and display
        dblOrigPrice = dblDiscountRate * dblOrigPrice
        lblDisplayDiscountPrice.Text = dblOrigPrice.ToString("c")
    End Sub
End Class
