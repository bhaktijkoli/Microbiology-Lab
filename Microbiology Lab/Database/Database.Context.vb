﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class DatabaseEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=DatabaseEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property BloodTests() As DbSet(Of BloodTest)
    Public Overridable Property GramNegatives() As DbSet(Of GramNegative)
    Public Overridable Property GramPositives() As DbSet(Of GramPositive)
    Public Overridable Property Pathogens() As DbSet(Of Pathogen)
    Public Overridable Property Samples() As DbSet(Of Sample)
    Public Overridable Property TestResults() As DbSet(Of TestResult)
    Public Overridable Property Tests() As DbSet(Of Test)
    Public Overridable Property Users() As DbSet(Of User)

End Class
