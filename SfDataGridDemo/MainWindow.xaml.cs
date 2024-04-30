using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Grids;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WINUI_DataGridDemos.ViewModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WINUI_DataGridDemos
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.sfDataGrid.FilterItemsPopulated += SfDataGrid_FilterItemsPopulated;
        }

        private void SfDataGrid_FilterItemsPopulated(object sender, Syncfusion.UI.Xaml.DataGrid.GridFilterItemsPopulatedEventArgs e)
        {
            if(e.Column.MappingName == "Date")
            {
                (e.ItemsSource as List<FilterElement>).Sort(new FilterElementComparer());
            }
        }    
    }

    public class FilterElementComparer : IComparer<FilterElement>
    {
        public int Compare(FilterElement x, FilterElement y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If both are null, they're equal.
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y is greater.
                    return 1; // Changed to 1 for descending order.
                }
            }
            else
            {
                // If x is not null... 
                if (y == null)
                {
                    // ...and y is null, x is greater. 
                    return -1; // Changed to -1 for descending order.
                }
                else
                {
                    // Compare in descending order.
                    return DateTime.Compare((DateTime)y.ActualValue,(DateTime)x.ActualValue); // Reversed x and y here.
                }
            }
        }

    }




}
