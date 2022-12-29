using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelectedItemsBindingDemo
{
    public class PersonModel : INotifyPropertyChanged
    {
        private ObservableCollection<object> _selectedItems; 
        public ObservableCollection<object> SelectedItems
        {
            get
            {
                return _selectedItems;
            }
            set
            {
                _selectedItems = value;
                RaisePropertyChanged("SelectedItems");
                UpdateSummary();
            }
        }
        private bool _Ischecked;
        public bool Ischecked
        {
            get
            {
                return _Ischecked;
            }
            set
            {
                _Ischecked = value; RaisePropertyChanged("Ischecked");
            }
        }
        private string _summary;
        public string Summary
        {
            get
            {
                return _summary;
            }
            private set
            {
                _summary = value;
                RaisePropertyChanged("Summary");
            }
        }
        private object selectedItem;
        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }
        public PersonModel()
        {
            this.GDCSource = Getsource();
            
        }

        private ObservableCollection<Person> _gdcsource;
        public ObservableCollection<Person> GDCSource
        {
            get { return _gdcsource; }
            set { _gdcsource = value; }
        }
        private ObservableCollection<Person> Getsource()
        {
            ObservableCollection<Person> items = new ObservableCollection<Person>();
            if (items != null)
            {
                items.Add(new Person() { FirstName = "Sean", LastName = "Jacobson", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Srithar", LastName = "Phyllis", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Marvin", LastName = "Allen", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items.Add(new Person() { FirstName = "Michael", LastName = "Allen", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Cecil", LastName = "Allison", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Oscar", LastName = "Alpuerto", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items.Add(new Person() { FirstName = "Sandra", LastName = "Altamirano", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Selena", LastName = "Alvarad", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Emilio", LastName = "Alvaro", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items.Add(new Person() { FirstName = "Maxwell", LastName = "Amland", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Ramona", LastName = "Antrim", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Sabria", LastName = "Appelbaum", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items.Add(new Person() { FirstName = "Hannah", LastName = "Arakawa", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Kyley", LastName = "Arbelaez", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Thomas", LastName = "Armstrong", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items.Add(new Person() { FirstName = "Chris", LastName = "Ashton", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Teresa", LastName = "Atkinson", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Robert", LastName = "Avalos", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
            }
            return items;
            
        }
        public void UpdateSummary()
        {
            if(SelectedItems.Count==1)
                Summary = string.Format("{0} item  selected.", _selectedItems.Count);
            else
                Summary = string.Format("{0} items are selected.", _selectedItems.Count);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
