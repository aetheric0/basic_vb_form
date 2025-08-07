

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFavorites.Items.Add("Pizza")
        cmbFavorites.Items.Add("Sushi")
        cmbFavorites.Items.Add("Burger")
        cmbFavorites.Items.Add("Chapati")
        cmbFavorites.Items.Add("Pilau")

        ' Splash Screen Styling
        Dim splashScreen As New Form()
        splashScreen.Text = "Welcome to Food Selection"
        splashScreen.BackColor = Color.LightYellow
        splashScreen.Size = New Size(300, 200)

        Dim lblSplash As New Label()
        lblSplash.Text = "Loading..."
        lblSplash.Font = New Font("Arial", 14, FontStyle.Bold)
        lblSplash.Location = New Point(50, 80)
        splashScreen.Controls.Add(lblSplash)

        splashScreen.Show()
        Threading.Thread.Sleep(2000)
        splashScreen.Close()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim userInput As Integer

        If Integer.TryParse(txtNumber.Text, userInput) Then
            If userInput >= 10 AndAlso userInput <= 20 Then
                MessageBox.Show("✅ Valid input: " & userInput)
            Else
                MessageBox.Show("❌ Invalid input. Please enter a number between 10 and 20.")
            End If
        Else
            MessageBox.Show("⚠️ Please enter a valid numeric value.")
        End If
    End Sub

    Private Sub btnSelect_Click_1(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim selection As String = cmbFavorites.SelectedItem

        Select Case selection
            Case "Pizza"
                MessageBox.Show("🍕 You love pizza, and so does Chrix!")
            Case "Sushi"
                MessageBox.Show("🍣 Health is wealth and Sushi is best!")
            Case "Burger"
                MessageBox.Show("🍔 Great Choice! Burger so tasty, Penkerei is also a fan!")
            Case "Chapati"
                MessageBox.Show("🥘 Chapatiii!!! - Kenyan rocks!")
            Case "Pilau"
                MessageBox.Show("🍛 Flavor-packed! Pilau, Our Liz shares a bond.")
            Case Else
                MessageBox.Show("🤔 Please select an item from the list.")
        End Select
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged

    End Sub
End Class