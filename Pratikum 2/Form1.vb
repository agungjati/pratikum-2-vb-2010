Public Class FGaji

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TunjanganAnak.Click

    End Sub

    Private Sub golongan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles golongan.SelectedIndexChanged
        If golongan.Text = "IB" Then
            gajipokok.Text = 1500000
        Else
            If golongan.Text = "IIA" Then
                gajipokok.Text = 1200000
            Else
                If golongan.Text = "IIB" Then
                    gajipokok.Text = 1000000
                Else
                    gajipokok.Text = 800000
                End If
            End If
        End If
    End Sub

    Private Sub Radiobutton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radiobutton1.CheckedChanged
        tunjanganjabatan.Text = 1500000
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        tunjanganjabatan.Text = 1000000
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        tunjanganjabatan.Text = 750000
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        tunjanganjabatan.Text = 500000
    End Sub

    Private Sub Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Status.SelectedIndexChanged
        If Status.Text = "Kawin" Then
            TunjanganKeluarga.Text = 0.2 * Val(gajipokok.Text)
        Else
            TunjanganKeluarga.Text = 0
            TotalGaji.Text = Val(gajipokok.Text) + Val(TunjanganKeluarga.Text)
        End If
    End Sub

    Private Sub JumlahAnak_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JumlahAnak.TextChanged
        TunjanganAnak.Text = 0.1 * Val(gajipokok.Text) * Val(JumlahAnak.Text)
        TotalGaji.Text = Val(gajipokok.Text) + Val(tunjanganjabatan.Text) + Val(TunjanganKeluarga.Text) + Val(TunjanganAnak.Text)
    End Sub
End Class
