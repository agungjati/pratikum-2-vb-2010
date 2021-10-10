Public Class FormCase

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkodebarang.SelectedIndexChanged
        Select Case cmbkodebarang.Text
            Case "01"
                txtnamabarang.Text = "Laptop"
                txtharga.Text = 2500000
            Case "02"
                txtnamabarang.Text = "Tablet"
                txtharga.Text = 1000000
            Case "03"
                txtnamabarang.Text = "Komputer"
                txtharga.Text = 3500000
            Case "04"
                txtnamabarang.Text = "HP"
                txtharga.Text = 200000
            Case "05"
                txtnamabarang.Text = "Speaker"
                txtharga.Text = 450000
        End Select
    End Sub


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjumlah.TextChanged
        txttotal.Text = Val(txtharga.Text) * Val(txtjumlah.Text)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbkodebarang.Items.Add("01")
        cmbkodebarang.Items.Add("02")
        cmbkodebarang.Items.Add("03")
        cmbkodebarang.Items.Add("04")
        cmbkodebarang.Items.Add("05")
    End Sub
End Class
