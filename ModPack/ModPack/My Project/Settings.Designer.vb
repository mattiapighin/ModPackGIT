﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.42000
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funzionalità di salvataggio automatico My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Z:\Modpack\Log.txt")>  _
        Public Property FileLogPath() As String
            Get
                Return CType(Me("FileLogPath"),String)
            End Get
            Set
                Me("FileLogPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1048576")>  _
        Public Property MaxLengthLog() As Long
            Get
                Return CType(Me("MaxLengthLog"),Long)
            End Get
            Set
                Me("MaxLengthLog") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("normal")>  _
        Public Property LogType() As String
            Get
                Return CType(Me("LogType"),String)
            End Get
            Set
                Me("LogType") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Z:\ModPack\ModPackDB.mdf;Inte"& _ 
            "grated Security=True;Connect Timeout=30")>  _
        Public ReadOnly Property ModPackDBConnectionString() As String
            Get
                Return CType(Me("ModPackDBConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property FormatoStampa() As Global.System.Drawing.Printing.PageSettings
            Get
                Return CType(Me("FormatoStampa"),Global.System.Drawing.Printing.PageSettings)
            End Get
            Set
                Me("FormatoStampa") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("110")>  _
        Public Property Etichette_DimensioneX() As Integer
            Get
                Return CType(Me("Etichette_DimensioneX"),Integer)
            End Get
            Set
                Me("Etichette_DimensioneX") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("69")>  _
        Public Property Etichette_DimensioneY() As Integer
            Get
                Return CType(Me("Etichette_DimensioneY"),Integer)
            End Get
            Set
                Me("Etichette_DimensioneY") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property Etichette_MargineTop() As Integer
            Get
                Return CType(Me("Etichette_MargineTop"),Integer)
            End Get
            Set
                Me("Etichette_MargineTop") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property Etichette_MargineBottom() As Integer
            Get
                Return CType(Me("Etichette_MargineBottom"),Integer)
            End Get
            Set
                Me("Etichette_MargineBottom") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property Etichette_MargineLeft() As Integer
            Get
                Return CType(Me("Etichette_MargineLeft"),Integer)
            End Get
            Set
                Me("Etichette_MargineLeft") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property Etichette_MargineRight() As Integer
            Get
                Return CType(Me("Etichette_MargineRight"),Integer)
            End Get
            Set
                Me("Etichette_MargineRight") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("\\10.0.0.5\TSC TTP-246M Pro")>  _
        Public Property Etichette_Stampante() As String
            Get
                Return CType(Me("Etichette_Stampante"),String)
            End Get
            Set
                Me("Etichette_Stampante") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CK_ConfermaEvaso() As Boolean
            Get
                Return CType(Me("CK_ConfermaEvaso"),Boolean)
            End Get
            Set
                Me("CK_ConfermaEvaso") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property OrdiniAperti_ColoraScaduti() As Boolean
            Get
                Return CType(Me("OrdiniAperti_ColoraScaduti"),Boolean)
            End Get
            Set
                Me("OrdiniAperti_ColoraScaduti") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property OrdiniAperti_ColoraEvasi() As Boolean
            Get
                Return CType(Me("OrdiniAperti_ColoraEvasi"),Boolean)
            End Get
            Set
                Me("OrdiniAperti_ColoraEvasi") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CheckInserimentoImballo() As Boolean
            Get
                Return CType(Me("CheckInserimentoImballo"),Boolean)
            End Get
            Set
                Me("CheckInserimentoImballo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property StampaBarcodeDistinte() As Boolean
            Get
                Return CType(Me("StampaBarcodeDistinte"),Boolean)
            End Get
            Set
                Me("StampaBarcodeDistinte") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property StampaBarcodeSoloCodice() As String
            Get
                Return CType(Me("StampaBarcodeSoloCodice"),String)
            End Get
            Set
                Me("StampaBarcodeSoloCodice") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("12")>  _
        Public Property DimensioneFontDistinta() As Integer
            Get
                Return CType(Me("DimensioneFontDistinta"),Integer)
            End Get
            Set
                Me("DimensioneFontDistinta") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("15")>  _
        Public Property NumeroRigheDistinta() As String
            Get
                Return CType(Me("NumeroRigheDistinta"),String)
            End Get
            Set
                Me("NumeroRigheDistinta") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property PrintBiancoNero() As Boolean
            Get
                Return CType(Me("PrintBiancoNero"),Boolean)
            End Get
            Set
                Me("PrintBiancoNero") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("200")>  _
        Public Property LimiteTavole8() As Integer
            Get
                Return CType(Me("LimiteTavole8"),Integer)
            End Get
            Set
                Me("LimiteTavole8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Z:\ModPack\ModPackConfig.xml")>  _
        Public Property XMLpath() As String
            Get
                Return CType(Me("XMLpath"),String)
            End Get
            Set
                Me("XMLpath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property NuoviPath() As String
            Get
                Return CType(Me("NuoviPath"),String)
            End Get
            Set
                Me("NuoviPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("NO_REPLY@bicciatoserafino.com")>  _
        Public Property MAIL_username() As String
            Get
                Return CType(Me("MAIL_username"),String)
            End Get
            Set
                Me("MAIL_username") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("estate-2016")>  _
        Public Property MAIL_password() As String
            Get
                Return CType(Me("MAIL_password"),String)
            End Get
            Set
                Me("MAIL_password") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("smtp.bicciatoserafino.com")>  _
        Public Property MAIL_server() As String
            Get
                Return CType(Me("MAIL_server"),String)
            End Get
            Set
                Me("MAIL_server") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("25")>  _
        Public Property MAIL_port() As String
            Get
                Return CType(Me("MAIL_port"),String)
            End Get
            Set
                Me("MAIL_port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MAIL_Destinatario1() As String
            Get
                Return CType(Me("MAIL_Destinatario1"),String)
            End Get
            Set
                Me("MAIL_Destinatario1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MAIL_Destinatario2() As String
            Get
                Return CType(Me("MAIL_Destinatario2"),String)
            End Get
            Set
                Me("MAIL_Destinatario2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MAIL_Destinatario3() As String
            Get
                Return CType(Me("MAIL_Destinatario3"),String)
            End Get
            Set
                Me("MAIL_Destinatario3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MAIL_Destinatario4() As String
            Get
                Return CType(Me("MAIL_Destinatario4"),String)
            End Get
            Set
                Me("MAIL_Destinatario4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MAIL_PDFPrinter() As String
            Get
                Return CType(Me("MAIL_PDFPrinter"),String)
            End Get
            Set
                Me("MAIL_PDFPrinter") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MAIL_DefaultPathCO() As String
            Get
                Return CType(Me("MAIL_DefaultPathCO"),String)
            End Get
            Set
                Me("MAIL_DefaultPathCO") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
        Public Property GiorniMantenimentoBackup() As Integer
            Get
                Return CType(Me("GiorniMantenimentoBackup"),Integer)
            End Get
            Set
                Me("GiorniMantenimentoBackup") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Z:\ModPack\")>  _
        Public Property Root() As String
            Get
                Return CType(Me("Root"),String)
            End Get
            Set
                Me("Root") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Program Files (x86)\Microsoft Office\Office12\Excel.exe")>  _
        Public Property ExcelPath() As String
            Get
                Return CType(Me("ExcelPath"),String)
            End Get
            Set
                Me("ExcelPath") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.ModPack.My.MySettings
            Get
                Return Global.ModPack.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
