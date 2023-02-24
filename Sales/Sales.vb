Public Class Sales
    'Project Sales
    'Application for Package Sales
    'Programmed by Brian Nicewander
    'Date last modified 2/26/19

    'Declare inputs
    Dim intPackage1 As Integer    'Package A
    Dim intPackage2 As Integer    'Package B
    Dim intPackage3 As Integer    'Package C

    'Variables for output
    Dim dblPackageA As Double
    Dim dblPackageB As Double
    Dim dblPackageC As Double
    Dim dblGrandTotal As Double

    'Constant for Discounts
    Const decDiscountA As Decimal = CDec(0.8)         '10-19 packages 20% discount
    Const decDiscountB As Decimal = CDec(0.7)         '20-49 packages 30% discount
    Const decDiscountC As Decimal = CDec(0.6)         '50-99 Packages 40% discount
    Const decDiscountD As Decimal = CDec(0.5)         '100 or more packages 50% discount

    'Constant for package cost
    Const intPackageA As Integer = 99           'Price for package A
    Const intPackageB As Integer = 199          'Price for package B
    Const intPackageC As Integer = 299          'Price for Package C

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Shows the date and time in a label
        lblDateAndTime.Text = Now.ToString("D") & " " & Now.ToString("T")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calculate the total of packages and the discount offered and displays total of each package and grand total in a label.

        'Get the number of Package A 
        If Integer.TryParse(txtPackage1.Text, intPackage1) Then
            'Validate a number of 0 or higher in Package A
            If intPackage1 >= 0 Then

                'Calculating the price of Pacakge A with no discount
                dblPackageA = intPackage1 * intPackageA

                'Discount for Package A
                Select Case intPackage1
                    Case 10 To 19
                        dblPackageA = (intPackage1 * intPackageA) * decDiscountA
                    Case 20 To 49
                        dblPackageA = (intPackage1 * intPackageA) * decDiscountB
                    Case 50 To 99
                        dblPackageA = (intPackage1 * intPackageA) * decDiscountC
                    Case Is >= 100
                        dblPackageA = (intPackage1 * intPackageA) * decDiscountD
                End Select

            Else
                'Error: If a Integer of 0 or higher is not entered
                MessageBox.Show("Please enter a Integer of 0 or higher in Package A!")
                txtPackage1.Focus()
                Exit Sub
            End If

        Else
            'Error: If the text box is left empty or if they put text in that is not a Integer
            MessageBox.Show("Please enter a valid Integer in Package A!")
            txtPackage1.Focus()
            Exit Sub
        End If

        'Get the number of Package B
        If Integer.TryParse(txtPackage2.Text, intPackage2) Then
            'Validate a number of 0 or higher in Package B
            If intPackage2 >= 0 Then

                'Calculating the price of Pacakge B with no discount
                dblPackageB = intPackage2 * intPackageB

                'Discount for Package B
                Select Case intPackage2
                    Case 10 To 19
                        dblPackageB = (intPackage2 * intPackageB) * decDiscountA
                    Case 20 To 49
                        dblPackageB = (intPackage2 * intPackageB) * decDiscountB
                    Case 50 To 99
                        dblPackageB = (intPackage2 * intPackageB) * decDiscountC
                    Case Is >= 100
                        dblPackageB = (intPackage2 * intPackageB) * decDiscountD
                End Select

            Else
                'Error: If a Integer of 0 or higher is not entered
                MessageBox.Show("Please enter a Integer of 0 or higher in Package B!")
                txtPackage2.Focus()
                Exit Sub
            End If

        Else
            'Error: If the text box is left empty or if they put text in that is not a Integer
            MessageBox.Show("Please enter a valid Integer in Package B!")
            txtPackage2.Focus()
            Exit Sub
        End If

        'Get the number of Package C
        If Integer.TryParse(txtPackage3.Text, intPackage3) Then
            'Validate a number of 0 or higher in Package C
            If intPackage3 >= 0 Then

                'Calculating the price of Pacakge C with no discount
                dblPackageC = intPackage3 * intPackageC

                'Discount for Package C
                Select Case intPackage3
                    Case 10 To 19
                        dblPackageC = (intPackage3 * intPackageC) * decDiscountA
                    Case 20 To 49
                        dblPackageC = (intPackage3 * intPackageC) * decDiscountB
                    Case 50 To 99
                        dblPackageC = (intPackage3 * intPackageC) * decDiscountC
                    Case Is >= 100
                        dblPackageC = (intPackage3 * intPackageC) * decDiscountD
                End Select

            Else
                'Error: If a Integer of 0 or higher is not entered
                MessageBox.Show("Please enter a Integer of 0 or higher in Package C!")
                txtPackage3.Focus()
                Exit Sub
            End If

        Else
            'Error: If the text box is left empty or if they put text in that is not a Integer
            MessageBox.Show("Please enter a valid Integer in Package C!")
            txtPackage3.Focus()
            Exit Sub
        End If


        'Calculate Grand total
        dblGrandTotal = dblPackageC + dblPackageB + dblPackageA

        'Display fees
        lbloutput.Text = "Package A:" + dblPackageA.ToString("C") & vbCrLf & "Package B: " + dblPackageB.ToString("C") & vbCrLf & "Package C:" + dblPackageC.ToString("C") & vbCrLf & vbCrLf & "Grand Total: " + dblGrandTotal.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the text box for number of packages
        txtPackage1.Clear()
        txtPackage2.Clear()
        txtPackage3.Clear()

        'Clear the fee lable
        lbloutput.Text = String.Empty

        'Resets the time and date
        lblDateAndTime.Text = Now.ToString("D") & " " & Now.ToString("T")

        'Give pacakge A fucus
        txtPackage1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form.
        Me.Close()
    End Sub
End Class
