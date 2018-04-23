Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils

Namespace DxSample
	Partial Public Class Form1
		Inherits Form
		Private Const LayoutFile As String = "layout.xml"

		Public Sub New()
			InitializeComponent()
			pivotGrid1.DataSource = CreateTable(10)
			pivotGrid1.RetrieveFields()
			For i As Integer = 0 To pivotGrid1.Fields.Count - 1
				pivotGrid1.Fields(i).Name = "field" & i.ToString()
			Next i
		End Sub
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
		End Function

		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			If File.Exists(LayoutFile) Then
				File.Delete(LayoutFile)
			End If
			Using stream As New FileStream(LayoutFile, FileMode.OpenOrCreate, FileAccess.Write)
				pivotGrid1.SaveLayoutToStream(stream)
			End Using
		End Sub

		Private Sub btnRestore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestore.Click
			Using stream As New FileStream(LayoutFile, FileMode.Open, FileAccess.Read)
				pivotGrid1.RestoreLayoutFromStream(stream)
			End Using
		End Sub

		Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAllowUpdate.Click
			For Each field As PivotGridField In pivotGrid1.Fields
				field.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			Next field
		End Sub
	End Class
End Namespace