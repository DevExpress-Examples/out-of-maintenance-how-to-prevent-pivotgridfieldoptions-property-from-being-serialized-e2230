Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.ViewInfo

Namespace DxSample

    Public Class MyPivotGrid
        Inherits PivotGridControl

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Function CreateData() As PivotGridViewInfoData
            Return New MyPivotGridViewInfoData(Me)
        End Function
    End Class

    Public Class MyPivotGridField
        Inherits PivotGridField

        Public Sub New(ByVal fieldName As String, ByVal area As PivotArea)
            MyBase.New(fieldName, area)
        End Sub

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal data As PivotGridData)
            MyBase.New(data)
        End Sub

        Protected Overrides Function OnAllowSerializationProperty(ByVal options As DevExpress.Utils.OptionsLayoutBase, ByVal propertyName As String, ByVal id As Integer) As Boolean
            If Equals(propertyName, "Options") Then Return False
            Return MyBase.OnAllowSerializationProperty(options, propertyName, id)
        End Function
    End Class

    Public Class MyPivotGridFieldCollection
        Inherits PivotGridFieldCollection

        Public Sub New(ByVal data As PivotGridData)
            MyBase.New(data)
        End Sub

        Protected Overrides Function CreateFieldCore(ByVal fieldName As String, ByVal area As PivotArea) As PivotGridField
            Return New MyPivotGridField(fieldName, area)
        End Function
    End Class

    Public Class MyPivotGridViewInfoData
        Inherits PivotGridViewInfoData

        Public Sub New(ByVal control As IViewInfoControl)
            MyBase.New(control)
        End Sub

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Protected Overrides Function CreateFieldCollection() As PivotGridFieldCollectionBase
            Return New MyPivotGridFieldCollection(Me)
        End Function
    End Class
End Namespace
