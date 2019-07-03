using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.PivotGrid;
using HowToObtainUnderlyingData.NWindDataSetTableAdapters;
using static HowToObtainUnderlyingData.NWindDataSet;

namespace HowToObtainUnderlyingData
{
    [POCOViewModel]
    public class ViewModel {
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();
        public SalesPersonDataTable DataSource { get; } = new SalesPersonDataTable();

        protected ViewModel() {
            salesPersonDataAdapter.Fill(DataSource);
        }

        public void ShowDrillDownData(CellInfo cellInfo) {
            this.GetService<IDialogService>().ShowDialog(MessageButton.OK, "Drill Down Results", cellInfo);
        }
    }
}
