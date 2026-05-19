# How to bind SelectedItems property of WPF SfDatagrid to ViewModel property?
 
In [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid), `SelectedItems` is a collection property. So, whenever the `SelectedItems` collection is changed, the property bound with SelectedItems does not get notified for this change. However, you can achieve this by creating an attached property for SelectedItems.

The following is an attached property created for SfDataGrid and the property value is updated based on `SfDataGrid.SelectedItems.CollectionChanged` event.

**C#**
```
class SfDataGridHelper
{
    public static void SetSelectedItems(DependencyObject element, object value)
    {
        if (element is SfDataGrid)
            element.SetValue(SelectedItemsProperty, value);
        else
            throw new NotSupportedException("This property can be used only with SfDataGrid");
    }
    public static object GetSelectedItems(DependencyObject element)
    {
        return (object)element.GetValue(SelectedItemsProperty);
    }
    public static readonly DependencyProperty SelectedItemsProperty = DependencyProperty.RegisterAttached(
    "SelectedItems", typeof(ObservableCollection<Object>), typeof(SfDataGridHelper), new PropertyMetadata(new ObservableCollection<Object>(), OnSelectedItemsChanged));
    private static void OnSelectedItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
    {
        var sfDataGrid = d as SfDataGrid;
        if (sfDataGrid == null)
            return;
        //SfDataGridHelper.SelectedItems property updated based on SfDataGrid.SelectedItems Collectionchanged event.
        sfDataGrid.SelectedItems.CollectionChanged += (sender, e) =>
        {
            SfDataGridHelper.SetSelectedItems(sfDataGrid, sfDataGrid.SelectedItems);
        };
    }
}
```

SfDataGrid’s `SelectedItems` values are set to the attached property by using `SelectedItems.Collectionchanged` event. The following is the ViewModel property bound to the attached property that you created in the above code example.

**XAML**
```
<syncfusion:SfDataGrid x:Name="dataGrid"
                               Grid.Row="0"
                               AutoGenerateColumns="False"
                               AllowEditing="True"
                               local:SelectedItemsBehaviour.SelectedItems=
                               "{Binding SelectedItems, Mode=TwoWay,
                               UpdateSourceTrigger=PropertyChanged}"
                               AllowDeleting="True"
                               AllowResizingColumns="True"
                               AllowResizingHiddenColumns="True"
                               HideEmptyGridViewDefinition="True"
                               ItemsSource="{Binding GDCSource}"
                               NavigationMode="Cell"
                               SelectionMode="Extended"
                               ShowGroupDropArea="True"
                               ShowRowHeader="True">
```
Now, whenever the `SelectedItems` collection is changed the `ViewModel` property gets notified via the attached property.

Take a moment to peruse the [WPF SfDataGrid Documentation](https://help.syncfusion.com/wpf/datagrid/overview), where you can find about SfDataGrid with code examples.