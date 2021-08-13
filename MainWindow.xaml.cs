#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace DetailsViewStackedHeaderRowsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnDataGrid_DetailsViewLoading(object sender, DetailsViewLoadingAndUnloadingEventArgs e)
        {
            System.Windows.Interactivity.EventTrigger trigger = new System.Windows.Interactivity.EventTrigger();
            trigger.EventName = "CellTapped";

            InvokeCommandAction action = new InvokeCommandAction();
            action.Command = (this.DataContext as ViewModel).CellTappedCommand;

            trigger.Actions.Add(action);
            trigger.Attach(e.DetailsViewDataGrid);
        }
    }
}
