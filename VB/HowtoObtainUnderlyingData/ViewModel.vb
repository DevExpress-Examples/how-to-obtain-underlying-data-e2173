Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Xpf.PivotGrid
Imports HowToObtainUnderlyingData.NWindDataSetTableAdapters
Imports HowToObtainUnderlyingData.NWindDataSet

Namespace HowToObtainUnderlyingData
	<POCOViewModel>
	Public Class ViewModel
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()
		Public ReadOnly Property DataSource() As New SalesPersonDataTable()

		Protected Sub New()
			salesPersonDataAdapter.Fill(DataSource)
		End Sub

		Public Sub ShowDrillDownData(ByVal cellInfo As CellInfo)
			Me.GetService(Of IDialogService)().ShowDialog(MessageButton.OK, "Drill Down Results", cellInfo)
		End Sub
	End Class
End Namespace
