# How to add Event Triggers for DetailsViewDataGrid in WPF DataGrid (SfDataGrid)?

# About the sample

This example illustrates how to add Event Triggers for DetailsViewDataGrid in WPF DataGrid (SfDataGrid).

In [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid), EventTriggers added for the DetailsView DataGrid which is defined within the SfDataGrid.DetailsViewDefinition in XAML will not work, as it is not the same UI element which is displayed as the child DataGrid. However, it is possible to add EventTrigger for the DetailsView DataGrid in code behind by using [DetailsViewLoading](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_DetailsViewLoading) event. 

```C#

private void OnDataGrid_DetailsViewLoading(object sender, DetailsViewLoadingAndUnloadingEventArgs e)
{
    System.Windows.Interactivity.EventTrigger trigger = new System.Windows.Interactivity.EventTrigger();
    trigger.EventName = "CellTapped";

    InvokeCommandAction action = new InvokeCommandAction();
    action.Command = (this.DataContext as ViewModel).CellTappedCommand;

    trigger.Actions.Add(action);
    trigger.Attach(e.DetailsViewDataGrid);
}

```
KB article: [How to add Event Triggers for DetailsViewDataGrid in WPF DataGrid (SfDataGrid)?](https://www.syncfusion.com/kb/12816/how-to-add-event-triggers-for-detailsviewdatagrid-in-wpf-datagrid-sfdatagrid)

## Requirements to run the demo

Visual Studio 2015 and above versions.

