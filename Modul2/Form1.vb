
Public Class Form1
    Dim w As New Integer 'membuat variabel w dengan tipe integer
    Dim h As New Integer 'membuat variabel h dengan tipe integer
    Dim x As Integer 'membuat variabel x dengan tipe integer
    Dim y As Integer 'membuat variabel y dengan tipe integer
    Dim a, r, g, b As Integer 'membuat variabel a,r,g,b dengan tipe integer
    Dim kecerahan As Integer
    Dim validasi As Integer


    Private Sub buka_Click(sender As Object, e As EventArgs) Handles B_buka.Click 'jika tombol buka di klik maka akan menjalankan script
        Dim ofd As New OpenFileDialog 'mendeklarasikan OpenFileDialog baru menjadi variabel ofd
        ofd.Title = "Pilih Gambar" 'mengatur judul openfiledialog menjadi "Pilih Gambar"
        ofd.Filter = "image files|*.bmp;*.jpg" 'mengatur filter dari openfiledialog sehingga hanya bisa membuka file gambar
        ofd.RestoreDirectory = True 'mengatur jika kita membuka suatu file di salah satu direktori, maka saat openfiledialog dijalankan akan berada di direktori sebelumnya
        If ofd.ShowDialog() = DialogResult.OK Then 'membuat premis jika openfiledialog saat membuka file bernilai benar sesuai filter maka
            tampilan1.Image = New Bitmap(ofd.FileName) 'pada tampilan1 akan memuat sebuah gambar sesuai dengan file yang di pilih openfiledialog
            tampilan1.SizeMode = PictureBoxSizeMode.Zoom 'mengatur besaran gambar akan sesuai dengan picbox yang telah di buat
            validasi = 1
        End If
    End Sub

    Private Sub B_grayscale_Click(sender As Object, e As EventArgs) Handles B_grayscale.Click
        If IsNothing(tampilan1.Image) Then 'membuat premis jika picbo tampilan2 tidak memuat gambar maka
            MessageBox.Show("Buka Gambar Terlebih Dahulu!", "Gagal Melakukan Grayscale", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'mengeluarkan pesan dan memberi tombol OK serta memunculkan ikon warning
        Else 'atau
            If validasi = 1 Then
                tampilan2.Image = tampilan1.Image.Clone
            End If
            w = tampilan2.ClientSize.Width 'mendeklarasikan bahwa w adalah lebar dari ukuran gambar yang berada di picbox tampilan1
            h = tampilan2.ClientSize.Height 'mendeklarasikan bahwa h adalah tinggi dari ukuran gambar yang berada di picbox tampilan1
            Dim hasilbagi As Integer
            Dim gambarhitamputih As New Bitmap(w, h) 'mendeklarasikan variabel gambarfilter sebagai tempat menyimpan nilai w dan h
            tampilan2.DrawToBitmap(gambarhitamputih, tampilan2.ClientRectangle) 'untuk menyalin border bitmap dari tampilan1 ke variable gambarfilter

            For Me.y = 0 To h - 1 'perulangan jika y = 0 menuju variabel h yang tingginya - 1 (karena koordinat 0 juga di hitung sehingga -1)
                For Me.x = 0 To w - 1 'perulangan jika x = 0 menuju variabel w yang lebarnya - 1 (karena koordinat 0 juga di hitung sehingga -1
                    hasilbagi = (CInt(gambarhitamputih.GetPixel(x, y).R) +
                           gambarhitamputih.GetPixel(x, y).G +
                           gambarhitamputih.GetPixel(x, y).B) \ 3
                    gambarhitamputih.SetPixel(x, y, Color.FromArgb(hasilbagi, hasilbagi, hasilbagi))
                Next x 'perulangan dilanjutkan sampai ke x
            Next y 'perulangan dilanjutkan sampai ke y
            tampilan2.Image = gambarhitamputih 'mendeklarasikan bahwa picbox tampilan3 memuat image dari variabel gambarfilter
            validasi = 0
        End If
    End Sub

    Private Sub B_biner_Click(sender As Object, e As EventArgs) Handles B_biner.Click
        If IsNothing(tampilan2.Image) Then 'membuat premis jika picbo tampilan2 tidak memuat gambar maka
            MessageBox.Show("Lakukan Grayscale!", "Gagal Melakukan Biner", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'mengeluarkan pesan dan memberi tombol OK serta memunculkan ikon warning
        Else 'atau
            w = tampilan2.ClientSize.Width 'mendeklarasikan bahwa w adalah lebar dari ukuran gambar yang berada di picbox tampilan1
            h = tampilan2.ClientSize.Height 'mendeklarasikan bahwa h adalah tinggi dari ukuran gambar yang berada di picbox tampilan1
            Dim gambarbiner As New Bitmap(w, h) 'mendeklarasikan variabel gambarfilter sebagai tempat menyimpan nilai w dan h
            tampilan2.DrawToBitmap(gambarbiner, tampilan2.ClientRectangle) 'untuk menyalin border bitmap dari tampilan1 ke variable gambarfilter

            For Me.y = 0 To h - 1 'perulangan jika y = 0 menuju variabel h yang tingginya - 1 (karena koordinat 0 juga di hitung sehingga -1)
                For Me.x = 0 To w - 1 'perulangan jika x = 0 menuju variabel w yang lebarnya - 1 (karena koordinat 0 juga di hitung sehingga -1
                    Dim warna As Integer = gambarbiner.GetPixel(x, y).R

                    If warna >= 128 Then warna = 255
                    If warna <= 127 Then warna = 0

                    gambarbiner.SetPixel(x, y, Color.FromArgb(warna, warna, warna))
                Next x 'perulangan dilanjutkan sampai ke x
            Next y 'perulangan dilanjutkan sampai ke y
            tampilan3.Image = gambarbiner 'mendeklarasikan bahwa picbox tampilan3 memuat image dari variabel gambarfilter
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nilaikecerahan_ValueChanged(sender As Object, e As EventArgs) Handles nilaikecerahan.ValueChanged
        nilaikecerahan.Maximum = 255
        nilaikecerahan.Minimum = -255
        If IsNothing(tampilan1.Image) Then 'membuat premis jika picbox tampilan2 tidak memuat gambar maka
            MessageBox.Show("Buka Gambar Terlebih Dahulu!", "Gagal Menegatifkan", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'mengeluarkan pesan dan memberi tombol OK serta memunculkan ikon warning
        Else 'atau
            If validasi = 1 Then
                tampilan2.Image = tampilan1.Image.Clone
            End If
            w = tampilan2.ClientSize.Width 'mendeklarasikan bahwa w adalah lebar dari ukuran gambar yang berada di picbox tampilan1
            h = tampilan2.ClientSize.Height 'mendeklarasikan bahwa h adalah tinggi dari ukuran gambar yang berada di picbox tampilan1
            Dim gambarcerah As New Bitmap(w, h) 'mendeklarasikan variabel gambarcerah sebagai tempat menyimpan nilai w dan h
            tampilan2.DrawToBitmap(gambarcerah, tampilan2.ClientRectangle)
            tampilan2.Image = gambarcerah
            TB_kecerahan.Value = nilaikecerahan.Value

            For Me.y = 0 To h - 1 'perulangan jika y = 0 menuju variabel h yang tingginya - 1 (karena koordinat 0 juga di hitung sehingga -1)
                For Me.x = 0 To w - 1 'perulangan jika x = 0 menuju variabel w yang lebarnya - 1 (karena koordinat 0 juga di hitung sehingga -1
                    Dim merah As Integer = gambarcerah.GetPixel(x, y).R
                    Dim hijau As Integer = gambarcerah.GetPixel(x, y).G
                    Dim biru As Integer = gambarcerah.GetPixel(x, y).B

                    merah = merah + TB_kecerahan.Value
                    hijau = hijau + TB_kecerahan.Value
                    biru = biru + TB_kecerahan.Value

                    If merah > 255 Then merah = 255
                    If hijau > 255 Then hijau = 255
                    If biru > 255 Then biru = 255

                    If merah < 0 Then merah = 0
                    If hijau < 0 Then hijau = 0
                    If biru < 0 Then biru = 0

                    gambarcerah.SetPixel(x, y, Color.FromArgb(merah, hijau, biru))
                Next x 'perulangan dilanjutkan sampai ke x
            Next y 'perulangan dilanjutkan sampai ke y
            validasi = 0
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TB_kecerahan.Scroll
        TB_kecerahan.Maximum = 255
        TB_kecerahan.Minimum = -255
        If IsNothing(tampilan1.Image) Then 'membuat premis jika picbox tampilan2 tidak memuat gambar maka
            MessageBox.Show("Buka Gambar Terlebih Dahulu", "Gagal Mencerahkan", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'mengeluarkan pesan dan memberi tombol OK serta memunculkan ikon warning
        Else 'atau
            If validasi = 1 Then
                tampilan2.Image = tampilan1.Image.Clone
            End If
            nilaikecerahan.Value = TB_kecerahan.Value
            w = tampilan2.ClientSize.Width 'mendeklarasikan bahwa w adalah lebar dari ukuran gambar yang berada di picbox tampilan1
            h = tampilan2.ClientSize.Height 'mendeklarasikan bahwa h adalah tinggi dari ukuran gambar yang berada di picbox tampilan1
            Dim gambarcerah As New Bitmap(w, h) 'mendeklarasikan variabel gambarcerah sebagai tempat menyimpan nilai w dan h
            tampilan2.DrawToBitmap(gambarcerah, tampilan2.ClientRectangle)
            tampilan2.Image = gambarcerah

            For Me.y = 0 To h - 1 'perulangan jika y = 0 menuju variabel h yang tingginya - 1 (karena koordinat 0 juga di hitung sehingga -1)
                For Me.x = 0 To w - 1 'perulangan jika x = 0 menuju variabel w yang lebarnya - 1 (karena koordinat 0 juga di hitung sehingga -1
                    Dim merah As Integer = gambarcerah.GetPixel(x, y).R
                    Dim hijau As Integer = gambarcerah.GetPixel(x, y).G
                    Dim biru As Integer = gambarcerah.GetPixel(x, y).B

                    merah = merah + TB_kecerahan.Value
                    hijau = hijau + TB_kecerahan.Value
                    biru = biru + TB_kecerahan.Value

                    If merah > 255 Then merah = 255
                    If hijau > 255 Then hijau = 255
                    If biru > 255 Then biru = 255

                    If merah < 0 Then merah = 0
                    If hijau < 0 Then hijau = 0
                    If biru < 0 Then biru = 0

                    gambarcerah.SetPixel(x, y, Color.FromArgb(merah, hijau, biru))
                Next x 'perulangan dilanjutkan sampai ke x
            Next y 'perulangan dilanjutkan sampai ke y
            validasi = 0
        End If
    End Sub

    Private Sub T_keluar_Click(sender As Object, e As EventArgs) Handles T_Keluar.Click
        Dim result = MessageBox.Show("Yakin Anda ingin keluar ?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Close() 'untuk keluar dari form
        End If
    End Sub

    Private Sub T_ulang_Click(sender As Object, e As EventArgs) Handles T_Ulang.Click
        Controls.Clear() 'untuk menghapus semua control yang ada
        nilaikecerahan.Value = 0
        validasi = 0
        InitializeComponent() 'untuk memuat kembali componen-componen yang ada pada form
    End Sub

End Class