Public Class Form1
    Dim Counter As Integer = 0
    Public TotalNetProfitDecimal, AverageNetProfitDecimal As Decimal
    Public TotalQuantityInteger As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetButton.Enabled = False
    End Sub

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click

        If RetailPriceTextBox.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Please Make Sure all the Enabled Boxes are filled correctly")
        Else
            Try
                Dim RetailPriceDecimal, WholesaleCostDecimal, GrossProfitDecimal, StorageChargesDecimal, NetProfitDecimal As Decimal
                Dim QuantityInteger As Integer
                Counter += 1
                Const SPercentageSingle As Single = 0.05
                RetailPriceDecimal = Decimal.Parse(RetailPriceTextBox.Text) 'Globalization.NumberStyles.Currency
                WholesaleCostDecimal = Decimal.Parse(TextBox4.Text)
                QuantityInteger = Integer.Parse(TextBox5.Text)
                GrossProfitDecimal = Decimal.Parse(QuantityInteger) * (RetailPriceDecimal - WholesaleCostDecimal)
                StorageChargesDecimal = SPercentageSingle * GrossProfitDecimal
                NetProfitDecimal = GrossProfitDecimal - StorageChargesDecimal
                RetailPriceTextBox.Text = RetailPriceDecimal.ToString("C2")
                TextBox4.Text = WholesaleCostDecimal.ToString("N2")
                TextBox5.Text = QuantityInteger.ToString("N0")
                TextBox6.Text = GrossProfitDecimal.ToString("N2")
                TextBox7.Text = StorageChargesDecimal.ToString("N2")
                TextBox8.Text = NetProfitDecimal.ToString("N2")

                AverageNetProfitDecimal += (NetProfitDecimal) / 2
                TotalNetProfitDecimal += NetProfitDecimal
                TotalQuantityInteger += QuantityInteger

                If (Counter > 0) Then
                    ResetButton.Enabled = True
                    ComputeButton.Enabled = False
                    Counter = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Error in Retail Price, Wholesale Cost, or Quantity", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Counter = 0
            End Try
        End If


    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        RetailPriceTextBox.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComputeButton.Enabled = True
        ResetButton.Enabled = False
        PartIdentifierTextBox.Focus()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ResetButton.KeyUp, ResetButton.KeyDown
        If e.KeyCode = Keys.Escape Then ResetButton.PerformClick()
    End Sub
    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComputeButton.KeyUp, ComputeButton.KeyDown
        If e.KeyCode = Keys.Enter Then ComputeButton.PerformClick()
    End Sub
    Private Sub ComputeButton_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ResetButton.KeyPress
        If Keys.Enter Then ComputeButton.PerformClick()
    End Sub
    Private Sub ResetButton_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ResetButton.KeyPress
        If Keys.Escape Then ResetButton.PerformClick()
    End Sub

    Private Sub TotalNetProfitButton_Click(sender As Object, e As EventArgs) Handles TotalNetProfitButton.Click
        MessageBox.Show("Average Net Profit: $" & AverageNetProfitDecimal & vbNewLine &
                        "Total Quantity of Parts: " & TotalQuantityInteger & vbNewLine _
                        & "Average Net Profit: $" & TotalNetProfitDecimal & vbNewLine, "Total Net Profit")
    End Sub
End Class
