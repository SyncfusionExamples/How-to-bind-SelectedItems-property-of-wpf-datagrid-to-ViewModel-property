using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace SelectedItemsBindingDemo
{
    class AttachedProperty
    {
        private static void OnEnableSelectedItemBinding(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            var sfDataGrid = d as SfDataGrid;
            if (sfDataGrid != null)
            {
                sfDataGrid.SelectedItems.CollectionChanged += (sender, e) =>
                {
                    AttachedProperty.SetSelectedItems(sfDataGrid, sfDataGrid.SelectedItems);
                };
            }
        }

        public static void SetSelectedItems(DependencyObject element, object value)
        {
            if (element is SfDataGrid)
            {
                element.SetValue(SelectedItemsProperty, value);
            }

        }

        public static object GetSelectedItems(DependencyObject element)
        {
            return (object)element.GetValue(SelectedItemsProperty);
        }

        public static readonly DependencyProperty SelectedItemsProperty = DependencyProperty.RegisterAttached(
        "SelectedItems", typeof(ObservableCollection<Object>), typeof(AttachedProperty), new PropertyMetadata(new ObservableCollection<Object>(), OnEnableSelectedItemBinding));
    }
}
