﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34011
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class Resources
    
    Private Shared resourceMan As Global.System.Resources.ResourceManager
    
    Private Shared resourceCulture As Global.System.Globalization.CultureInfo
    
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Sub New()
        MyBase.New
    End Sub
    
    '''<summary>
    '''  Returns the cached ResourceManager instance used by this class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property
    
    '''<summary>
    '''  Overrides the current thread's CurrentUICulture property for all
    '''  resource lookups using this strongly typed resource class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set
            resourceCulture = value
        End Set
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to VsTemplate Designer.
    '''</summary>
    Friend Shared ReadOnly Property ErrorMessageBoxTitle() As String
        Get
            Return ResourceManager.GetString("ErrorMessageBoxTitle", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to Description.
    '''</summary>
    Friend Shared ReadOnly Property FieldNameDescription() As String
        Get
            Return ResourceManager.GetString("FieldNameDescription", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to ID.
    '''</summary>
    Friend Shared ReadOnly Property FieldNameId() As String
        Get
            Return ResourceManager.GetString("FieldNameId", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to The vstemplate file you are attempting to load is missing TemplateData.
    '''</summary>
    Friend Shared ReadOnly Property InvalidVsTemplateData() As String
        Get
            Return ResourceManager.GetString("InvalidVsTemplateData", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to Reformat.
    '''</summary>
    Friend Shared ReadOnly Property ReformatBuffer() As String
        Get
            Return ResourceManager.GetString("ReformatBuffer", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to Synchronize XML file with view.
    '''</summary>
    Friend Shared ReadOnly Property SynchronizeBuffer() As String
        Get
            Return ResourceManager.GetString("SynchronizeBuffer", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to {0} must be {1} characters or less..
    '''</summary>
    Friend Shared ReadOnly Property ValidationFieldMaxLength() As String
        Get
            Return ResourceManager.GetString("ValidationFieldMaxLength", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to {0} is a required value..
    '''</summary>
    Friend Shared ReadOnly Property ValidationRequiredField() As String
        Get
            Return ResourceManager.GetString("ValidationRequiredField", resourceCulture)
        End Get
    End Property
End Class
