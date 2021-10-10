<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FGaji
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnamakaryawan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.golongan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gajipokok = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Radiobutton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tunjanganjabatan = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.JumlahAnak = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TunjanganKeluarga = New System.Windows.Forms.Label()
        Me.TunjanganAnak = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TotalGaji = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYROLL PT. DIVAISIINDO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Karywawan"
        '
        'txtnamakaryawan
        '
        Me.txtnamakaryawan.Location = New System.Drawing.Point(183, 71)
        Me.txtnamakaryawan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnamakaryawan.Name = "txtnamakaryawan"
        Me.txtnamakaryawan.Size = New System.Drawing.Size(205, 25)
        Me.txtnamakaryawan.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Golongan"
        '
        'golongan
        '
        Me.golongan.FormattingEnabled = True
        Me.golongan.Items.AddRange(New Object() {"IA", "IIA", "IB", "IIB", "IIIA"})
        Me.golongan.Location = New System.Drawing.Point(183, 114)
        Me.golongan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.golongan.Name = "golongan"
        Me.golongan.Size = New System.Drawing.Size(205, 26)
        Me.golongan.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Gaji Pokok"
        '
        'gajipokok
        '
        Me.gajipokok.AutoSize = True
        Me.gajipokok.Location = New System.Drawing.Point(183, 161)
        Me.gajipokok.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gajipokok.Name = "gajipokok"
        Me.gajipokok.Size = New System.Drawing.Size(55, 18)
        Me.gajipokok.TabIndex = 6
        Me.gajipokok.Text = "lblgapok"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.Radiobutton1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 215)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(351, 138)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jabatan"
        '
        'Radiobutton1
        '
        Me.Radiobutton1.AutoSize = True
        Me.Radiobutton1.Location = New System.Drawing.Point(29, 43)
        Me.Radiobutton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Radiobutton1.Name = "Radiobutton1"
        Me.Radiobutton1.Size = New System.Drawing.Size(77, 22)
        Me.Radiobutton1.TabIndex = 0
        Me.Radiobutton1.TabStop = True
        Me.Radiobutton1.Text = "Direktur"
        Me.Radiobutton1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(195, 43)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(99, 22)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Administrasi"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(29, 87)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(83, 22)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Keuangan"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(195, 87)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(92, 22)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Operasional"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 399)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tunjangan Jabatan"
        '
        'tunjanganjabatan
        '
        Me.tunjanganjabatan.AutoSize = True
        Me.tunjanganjabatan.Location = New System.Drawing.Point(184, 399)
        Me.tunjanganjabatan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tunjanganjabatan.Name = "tunjanganjabatan"
        Me.tunjanganjabatan.Size = New System.Drawing.Size(79, 18)
        Me.tunjanganjabatan.TabIndex = 9
        Me.tunjanganjabatan.Text = "lbltunjangan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 449)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Status"
        '
        'Status
        '
        Me.Status.FormattingEnabled = True
        Me.Status.Items.AddRange(New Object() {"Kawin", "Belum Kawin"})
        Me.Status.Location = New System.Drawing.Point(183, 438)
        Me.Status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(205, 26)
        Me.Status.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 493)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Jumlah Anak"
        '
        'JumlahAnak
        '
        Me.JumlahAnak.Location = New System.Drawing.Point(183, 489)
        Me.JumlahAnak.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JumlahAnak.Name = "JumlahAnak"
        Me.JumlahAnak.Size = New System.Drawing.Size(205, 25)
        Me.JumlahAnak.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 530)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Tunjangan Keluarga"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 570)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Tunjangan Anak"
        '
        'TunjanganKeluarga
        '
        Me.TunjanganKeluarga.AutoSize = True
        Me.TunjanganKeluarga.Location = New System.Drawing.Point(179, 530)
        Me.TunjanganKeluarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TunjanganKeluarga.Name = "TunjanganKeluarga"
        Me.TunjanganKeluarga.Size = New System.Drawing.Size(64, 18)
        Me.TunjanganKeluarga.TabIndex = 16
        Me.TunjanganKeluarga.Text = "lbltunjkel"
        '
        'TunjanganAnak
        '
        Me.TunjanganAnak.AutoSize = True
        Me.TunjanganAnak.Location = New System.Drawing.Point(179, 570)
        Me.TunjanganAnak.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TunjanganAnak.Name = "TunjanganAnak"
        Me.TunjanganAnak.Size = New System.Drawing.Size(73, 18)
        Me.TunjanganAnak.TabIndex = 17
        Me.TunjanganAnak.Text = "lbltunjanak"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TotalGaji)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 623)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(347, 83)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'TotalGaji
        '
        Me.TotalGaji.AutoSize = True
        Me.TotalGaji.Location = New System.Drawing.Point(21, 35)
        Me.TotalGaji.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalGaji.Name = "TotalGaji"
        Me.TotalGaji.Size = New System.Drawing.Size(65, 18)
        Me.TotalGaji.TabIndex = 0
        Me.TotalGaji.Text = "Total Gaji"
        '
        'FGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 738)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TunjanganAnak)
        Me.Controls.Add(Me.TunjanganKeluarga)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.JumlahAnak)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tunjanganjabatan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gajipokok)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.golongan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnamakaryawan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FGaji"
        Me.Text = "Form IF"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnamakaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents golongan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gajipokok As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Radiobutton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tunjanganjabatan As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents JumlahAnak As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TunjanganKeluarga As System.Windows.Forms.Label
    Friend WithEvents TunjanganAnak As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalGaji As System.Windows.Forms.Label

End Class
