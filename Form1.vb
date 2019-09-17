Public Class Form1

    Public Sub New()

        InitializeComponent()

        ComboBox1.Items.Add("kush.png")
        ComboBox1.Items.Add("hindu-kush.JPG")
        ComboBox1.Items.Add("gorilla-glue.JPG")
        ComboBox1.Items.Add("weed-nugget.png")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim bg = Image.FromFile(Environment.CurrentDirectory & "\" & ComboBox1.SelectedItem.ToString)

        Dim bmp As New Bitmap(bg, New Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height))

        Me.BackgroundImage = bmp

    End Sub
End Class
