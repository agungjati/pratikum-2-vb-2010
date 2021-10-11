Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        txtJumlah.Text = Val(txtQty.Text) * Val(txtHarga.Text)
    End Sub

    Private Sub txtHarga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHarga.TextChanged
        txtJumlah.Text = Val(txtQty.Text) * Val(txtHarga.Text)
    End Sub

    Private Sub txtDiskon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiskon.TextChanged
        Dim diskon As Double = Val(txtJumlah.Text) * Val(txtDiskon.Text) / 100
        txtTotal.Text = Val(txtJumlah.Text) - diskon
    End Sub
End Class
