﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.B_grayscale = New System.Windows.Forms.Button()
        Me.B_buka = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tampilan1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tampilan2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tampilan3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_Ulang = New System.Windows.Forms.PictureBox()
        Me.T_Keluar = New System.Windows.Forms.PictureBox()
        Me.B_biner = New System.Windows.Forms.Button()
        Me.GB_brightness = New System.Windows.Forms.GroupBox()
        Me.TB_kecerahan = New System.Windows.Forms.TrackBar()
        Me.temp = New System.Windows.Forms.PictureBox()
        Me.nilaikecerahan = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tampilan1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tampilan2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tampilan3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_Ulang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_Keluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_brightness.SuspendLayout()
        CType(Me.TB_kecerahan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.temp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_grayscale
        '
        Me.B_grayscale.BackColor = System.Drawing.Color.ForestGreen
        Me.B_grayscale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.B_grayscale.FlatAppearance.BorderSize = 2
        Me.B_grayscale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_grayscale.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_grayscale.ForeColor = System.Drawing.Color.White
        Me.B_grayscale.Location = New System.Drawing.Point(283, 354)
        Me.B_grayscale.Name = "B_grayscale"
        Me.B_grayscale.Size = New System.Drawing.Size(265, 31)
        Me.B_grayscale.TabIndex = 19
        Me.B_grayscale.Text = "Grayscale"
        Me.B_grayscale.UseVisualStyleBackColor = False
        '
        'B_buka
        '
        Me.B_buka.BackColor = System.Drawing.Color.ForestGreen
        Me.B_buka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.B_buka.FlatAppearance.BorderSize = 2
        Me.B_buka.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_buka.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_buka.ForeColor = System.Drawing.Color.White
        Me.B_buka.Location = New System.Drawing.Point(12, 354)
        Me.B_buka.Name = "B_buka"
        Me.B_buka.Size = New System.Drawing.Size(265, 31)
        Me.B_buka.TabIndex = 0
        Me.B_buka.Text = "Pilih Gambar..."
        Me.B_buka.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tampilan1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 276)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gambar 1"
        '
        'tampilan1
        '
        Me.tampilan1.Location = New System.Drawing.Point(6, 19)
        Me.tampilan1.Name = "tampilan1"
        Me.tampilan1.Size = New System.Drawing.Size(250, 250)
        Me.tampilan1.TabIndex = 17
        Me.tampilan1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tampilan2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(283, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 276)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gambar 2"
        '
        'tampilan2
        '
        Me.tampilan2.Location = New System.Drawing.Point(9, 19)
        Me.tampilan2.Name = "tampilan2"
        Me.tampilan2.Size = New System.Drawing.Size(250, 250)
        Me.tampilan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tampilan2.TabIndex = 18
        Me.tampilan2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.tampilan3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(554, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 276)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gambar 3"
        '
        'tampilan3
        '
        Me.tampilan3.Location = New System.Drawing.Point(6, 19)
        Me.tampilan3.Name = "tampilan3"
        Me.tampilan3.Size = New System.Drawing.Size(250, 250)
        Me.tampilan3.TabIndex = 19
        Me.tampilan3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(186, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "KELOMPOK I [ MODUL II ]"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'T_Ulang
        '
        Me.T_Ulang.BackColor = System.Drawing.Color.Transparent
        Me.T_Ulang.Image = Global.copas_rgb_cmy.My.Resources.Resources.refresh
        Me.T_Ulang.InitialImage = CType(resources.GetObject("T_Ulang.InitialImage"), System.Drawing.Image)
        Me.T_Ulang.Location = New System.Drawing.Point(742, 9)
        Me.T_Ulang.Name = "T_Ulang"
        Me.T_Ulang.Size = New System.Drawing.Size(34, 37)
        Me.T_Ulang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.T_Ulang.TabIndex = 31
        Me.T_Ulang.TabStop = False
        '
        'T_Keluar
        '
        Me.T_Keluar.BackColor = System.Drawing.Color.Transparent
        Me.T_Keluar.Image = Global.copas_rgb_cmy.My.Resources.Resources._error
        Me.T_Keluar.InitialImage = CType(resources.GetObject("T_Keluar.InitialImage"), System.Drawing.Image)
        Me.T_Keluar.Location = New System.Drawing.Point(782, 9)
        Me.T_Keluar.Name = "T_Keluar"
        Me.T_Keluar.Size = New System.Drawing.Size(34, 37)
        Me.T_Keluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.T_Keluar.TabIndex = 30
        Me.T_Keluar.TabStop = False
        '
        'B_biner
        '
        Me.B_biner.BackColor = System.Drawing.Color.ForestGreen
        Me.B_biner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.B_biner.FlatAppearance.BorderSize = 2
        Me.B_biner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_biner.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_biner.ForeColor = System.Drawing.Color.White
        Me.B_biner.Location = New System.Drawing.Point(554, 354)
        Me.B_biner.Name = "B_biner"
        Me.B_biner.Size = New System.Drawing.Size(265, 31)
        Me.B_biner.TabIndex = 32
        Me.B_biner.Text = "Biner"
        Me.B_biner.UseVisualStyleBackColor = False
        '
        'GB_brightness
        '
        Me.GB_brightness.Controls.Add(Me.nilaikecerahan)
        Me.GB_brightness.Controls.Add(Me.TB_kecerahan)
        Me.GB_brightness.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_brightness.Location = New System.Drawing.Point(12, 391)
        Me.GB_brightness.Name = "GB_brightness"
        Me.GB_brightness.Size = New System.Drawing.Size(807, 100)
        Me.GB_brightness.TabIndex = 34
        Me.GB_brightness.TabStop = False
        Me.GB_brightness.Text = "Brightness"
        '
        'TB_kecerahan
        '
        Me.TB_kecerahan.Location = New System.Drawing.Point(6, 53)
        Me.TB_kecerahan.Maximum = 255
        Me.TB_kecerahan.Minimum = -255
        Me.TB_kecerahan.Name = "TB_kecerahan"
        Me.TB_kecerahan.Size = New System.Drawing.Size(795, 45)
        Me.TB_kecerahan.TabIndex = 33
        '
        'temp
        '
        Me.temp.Location = New System.Drawing.Point(-70, -204)
        Me.temp.Name = "temp"
        Me.temp.Size = New System.Drawing.Size(250, 250)
        Me.temp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.temp.TabIndex = 35
        Me.temp.TabStop = False
        Me.temp.Visible = False
        '
        'nilaikecerahan
        '
        Me.nilaikecerahan.AutoSize = True
        Me.nilaikecerahan.ForeColor = System.Drawing.Color.Black
        Me.nilaikecerahan.Location = New System.Drawing.Point(551, 22)
        Me.nilaikecerahan.Name = "nilaikecerahan"
        Me.nilaikecerahan.Size = New System.Drawing.Size(224, 19)
        Me.nilaikecerahan.TabIndex = 34
        Me.nilaikecerahan.Text = "Penambahan Brightness = 0"
        Me.nilaikecerahan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(830, 508)
        Me.Controls.Add(Me.temp)
        Me.Controls.Add(Me.GB_brightness)
        Me.Controls.Add(Me.B_biner)
        Me.Controls.Add(Me.T_Ulang)
        Me.Controls.Add(Me.T_Keluar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.B_grayscale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_buka)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APLIKASI PENGOLAHAN GAMBAR"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.tampilan1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.tampilan2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.tampilan3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_Ulang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_Keluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_brightness.ResumeLayout(False)
        Me.GB_brightness.PerformLayout()
        CType(Me.TB_kecerahan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.temp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_grayscale As System.Windows.Forms.Button
    Friend WithEvents B_buka As System.Windows.Forms.Button
    Friend WithEvents tampilan1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tampilan2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tampilan3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T_Keluar As PictureBox
    Friend WithEvents T_Ulang As PictureBox
    Friend WithEvents B_biner As Button
    Friend WithEvents GB_brightness As GroupBox
    Friend WithEvents TB_kecerahan As TrackBar
    Friend WithEvents temp As PictureBox
    Friend WithEvents nilaikecerahan As Label
End Class
