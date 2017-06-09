<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Opzioni
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
        Me.Bt_Browse = New System.Windows.Forms.Button()
        Me.TxtFolder = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nu_Timer = New System.Windows.Forms.NumericUpDown()
        Me.BT_Ok = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Nu_Timer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bt_Browse
        '
        Me.Bt_Browse.Location = New System.Drawing.Point(6, 19)
        Me.Bt_Browse.Name = "Bt_Browse"
        Me.Bt_Browse.Size = New System.Drawing.Size(43, 20)
        Me.Bt_Browse.TabIndex = 0
        Me.Bt_Browse.Text = "..."
        Me.Bt_Browse.UseVisualStyleBackColor = True
        '
        'TxtFolder
        '
        Me.TxtFolder.Location = New System.Drawing.Point(55, 19)
        Me.TxtFolder.Name = "TxtFolder"
        Me.TxtFolder.Size = New System.Drawing.Size(356, 20)
        Me.TxtFolder.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bt_Browse)
        Me.GroupBox1.Controls.Add(Me.TxtFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 51)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Folder"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Timer aggiornamento:"
        '
        'Nu_Timer
        '
        Me.Nu_Timer.Location = New System.Drawing.Point(130, 83)
        Me.Nu_Timer.Name = "Nu_Timer"
        Me.Nu_Timer.Size = New System.Drawing.Size(97, 20)
        Me.Nu_Timer.TabIndex = 4
        '
        'BT_Ok
        '
        Me.BT_Ok.Location = New System.Drawing.Point(358, 80)
        Me.BT_Ok.Name = "BT_Ok"
        Me.BT_Ok.Size = New System.Drawing.Size(75, 23)
        Me.BT_Ok.TabIndex = 5
        Me.BT_Ok.Text = "OK"
        Me.BT_Ok.UseVisualStyleBackColor = True
        '
        'Form_Opzioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 123)
        Me.Controls.Add(Me.BT_Ok)
        Me.Controls.Add(Me.Nu_Timer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Opzioni"
        Me.Text = "Opzioni"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Nu_Timer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bt_Browse As Button
    Friend WithEvents TxtFolder As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Nu_Timer As NumericUpDown
    Friend WithEvents BT_Ok As Button
End Class
