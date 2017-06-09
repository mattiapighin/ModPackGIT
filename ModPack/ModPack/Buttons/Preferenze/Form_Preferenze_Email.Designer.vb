<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Preferenze_Email
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Mail_Password = New System.Windows.Forms.TextBox()
        Me.Txt_Mail_Username = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_Mail_ServerSMTP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Mail_PortaSMTP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_Dest4 = New System.Windows.Forms.TextBox()
        Me.Txt_Dest3 = New System.Windows.Forms.TextBox()
        Me.Txt_Dest2 = New System.Windows.Forms.TextBox()
        Me.Txt_Dest1 = New System.Windows.Forms.TextBox()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.Bt_TestMail = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtPDFPrinter = New System.Windows.Forms.TextBox()
        Me.Bt_StampantePDF = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Txt_DefaultPathCO = New System.Windows.Forms.TextBox()
        Me.Bt_DefaultPathCO = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_Mail_Password)
        Me.GroupBox1.Controls.Add(Me.Txt_Mail_Username)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credenziali"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Txt_Mail_Password
        '
        Me.Txt_Mail_Password.Location = New System.Drawing.Point(65, 45)
        Me.Txt_Mail_Password.Name = "Txt_Mail_Password"
        Me.Txt_Mail_Password.Size = New System.Drawing.Size(243, 20)
        Me.Txt_Mail_Password.TabIndex = 1
        '
        'Txt_Mail_Username
        '
        Me.Txt_Mail_Username.Location = New System.Drawing.Point(65, 19)
        Me.Txt_Mail_Username.Name = "Txt_Mail_Username"
        Me.Txt_Mail_Username.Size = New System.Drawing.Size(243, 20)
        Me.Txt_Mail_Username.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_Mail_ServerSMTP)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txt_Mail_PortaSMTP)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 49)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Smtp"
        '
        'Txt_Mail_ServerSMTP
        '
        Me.Txt_Mail_ServerSMTP.Location = New System.Drawing.Point(65, 19)
        Me.Txt_Mail_ServerSMTP.Name = "Txt_Mail_ServerSMTP"
        Me.Txt_Mail_ServerSMTP.Size = New System.Drawing.Size(151, 20)
        Me.Txt_Mail_ServerSMTP.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Server"
        '
        'Txt_Mail_PortaSMTP
        '
        Me.Txt_Mail_PortaSMTP.Location = New System.Drawing.Point(260, 19)
        Me.Txt_Mail_PortaSMTP.Name = "Txt_Mail_PortaSMTP"
        Me.Txt_Mail_PortaSMTP.Size = New System.Drawing.Size(48, 20)
        Me.Txt_Mail_PortaSMTP.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Porta"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_Dest4)
        Me.GroupBox3.Controls.Add(Me.Txt_Dest3)
        Me.GroupBox3.Controls.Add(Me.Txt_Dest2)
        Me.GroupBox3.Controls.Add(Me.Txt_Dest1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(314, 130)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Destinatari"
        '
        'Txt_Dest4
        '
        Me.Txt_Dest4.Location = New System.Drawing.Point(11, 97)
        Me.Txt_Dest4.Name = "Txt_Dest4"
        Me.Txt_Dest4.Size = New System.Drawing.Size(297, 20)
        Me.Txt_Dest4.TabIndex = 3
        '
        'Txt_Dest3
        '
        Me.Txt_Dest3.Location = New System.Drawing.Point(11, 71)
        Me.Txt_Dest3.Name = "Txt_Dest3"
        Me.Txt_Dest3.Size = New System.Drawing.Size(297, 20)
        Me.Txt_Dest3.TabIndex = 2
        '
        'Txt_Dest2
        '
        Me.Txt_Dest2.Location = New System.Drawing.Point(11, 45)
        Me.Txt_Dest2.Name = "Txt_Dest2"
        Me.Txt_Dest2.Size = New System.Drawing.Size(297, 20)
        Me.Txt_Dest2.TabIndex = 1
        '
        'Txt_Dest1
        '
        Me.Txt_Dest1.Location = New System.Drawing.Point(11, 19)
        Me.Txt_Dest1.Name = "Txt_Dest1"
        Me.Txt_Dest1.Size = New System.Drawing.Size(297, 20)
        Me.Txt_Dest1.TabIndex = 0
        '
        'Bt_Salva
        '
        Me.Bt_Salva.Location = New System.Drawing.Point(251, 402)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Salva.TabIndex = 3
        Me.Bt_Salva.Text = "Salva"
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'Bt_TestMail
        '
        Me.Bt_TestMail.Location = New System.Drawing.Point(12, 402)
        Me.Bt_TestMail.Name = "Bt_TestMail"
        Me.Bt_TestMail.Size = New System.Drawing.Size(75, 23)
        Me.Bt_TestMail.TabIndex = 4
        Me.Bt_TestMail.Text = "Test"
        Me.Bt_TestMail.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtPDFPrinter)
        Me.GroupBox4.Controls.Add(Me.Bt_StampantePDF)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 282)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(314, 52)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stampante PDF"
        '
        'TxtPDFPrinter
        '
        Me.TxtPDFPrinter.Location = New System.Drawing.Point(92, 19)
        Me.TxtPDFPrinter.Name = "TxtPDFPrinter"
        Me.TxtPDFPrinter.Size = New System.Drawing.Size(216, 20)
        Me.TxtPDFPrinter.TabIndex = 1
        '
        'Bt_StampantePDF
        '
        Me.Bt_StampantePDF.Location = New System.Drawing.Point(11, 19)
        Me.Bt_StampantePDF.Name = "Bt_StampantePDF"
        Me.Bt_StampantePDF.Size = New System.Drawing.Size(75, 21)
        Me.Bt_StampantePDF.TabIndex = 0
        Me.Bt_StampantePDF.Text = "Scegli"
        Me.Bt_StampantePDF.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Txt_DefaultPathCO)
        Me.GroupBox5.Controls.Add(Me.Bt_DefaultPathCO)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 340)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(314, 56)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Default Path Conferme d'ordine"
        '
        'Txt_DefaultPathCO
        '
        Me.Txt_DefaultPathCO.Location = New System.Drawing.Point(42, 22)
        Me.Txt_DefaultPathCO.Name = "Txt_DefaultPathCO"
        Me.Txt_DefaultPathCO.Size = New System.Drawing.Size(266, 20)
        Me.Txt_DefaultPathCO.TabIndex = 1
        '
        'Bt_DefaultPathCO
        '
        Me.Bt_DefaultPathCO.Location = New System.Drawing.Point(11, 19)
        Me.Bt_DefaultPathCO.Name = "Bt_DefaultPathCO"
        Me.Bt_DefaultPathCO.Size = New System.Drawing.Size(25, 23)
        Me.Bt_DefaultPathCO.TabIndex = 0
        Me.Bt_DefaultPathCO.Text = "..."
        Me.Bt_DefaultPathCO.UseVisualStyleBackColor = True
        '
        'Form_Preferenze_Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 435)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Bt_TestMail)
        Me.Controls.Add(Me.Bt_Salva)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Preferenze_Email"
        Me.Text = "Opzioni Email"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Mail_Password As TextBox
    Friend WithEvents Txt_Mail_Username As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Txt_Mail_ServerSMTP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Mail_PortaSMTP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Bt_Salva As Button
    Friend WithEvents Txt_Dest4 As TextBox
    Friend WithEvents Txt_Dest3 As TextBox
    Friend WithEvents Txt_Dest2 As TextBox
    Friend WithEvents Txt_Dest1 As TextBox
    Friend WithEvents Bt_TestMail As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtPDFPrinter As TextBox
    Friend WithEvents Bt_StampantePDF As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Txt_DefaultPathCO As TextBox
    Friend WithEvents Bt_DefaultPathCO As Button
End Class
