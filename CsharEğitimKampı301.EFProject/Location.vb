'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Location
    Public Property LocationId As Integer
    Public Property City As String
    Public Property Country As String
    Public Property Capacity As Nullable(Of Byte)
    Public Property Price As Nullable(Of Decimal)
    Public Property DayNight As String
    Public Property GuideId As Nullable(Of Integer)

    Public Overridable Property Guide As Guide

End Class
