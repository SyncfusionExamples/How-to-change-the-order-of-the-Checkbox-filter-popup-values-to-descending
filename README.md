# How to change the order of the Checkbox filter popup values to descending

By default, In SfDataGrid, filter popup values are displayed in ascending order. To change the sort order of the checkbox filter popup values to descending, you can utilize the FilterItemsPopulated event.

In this event, you can sort the items based on your requirements by setting a custom sort comparer.

For example, if you want to sort the filter popup values for a Date column, you can write a custom sort comparer based on the sorting of that Date column.

Additionally, you can apply this customization for a specific column by checking the condition using the column's MappingName property and applying the custom sort comparer accordingly

Refer to the code snippet below:

 
 ```C#
 private void SfDataGrid_FilterItemsPopulated(object sender, Syncfusion.UI.Xaml.DataGrid.GridFilterItemsPopulatedEventArgs e)
 {
     if(e.Column.MappingName == "Date")
     {
         (e.ItemsSource as List<FilterElement>).Sort(new FilterElementComparer());
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
```
**Image Reference:**

 ![FilterPopUpImage.png](https://support.syncfusion.com/kb/agent/attachment/article/15757/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjIxMTkzIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.z9NLrhzphtULwe82ts4jQg2oasYFyxrRmAG7eJCEAeo)

Take a moment to peruse the [WinUI - DataGrid Filtering UG Documentation](https://help.syncfusion.com/winui/datagrid/filtering), to learn more about Custom Column support with examples.