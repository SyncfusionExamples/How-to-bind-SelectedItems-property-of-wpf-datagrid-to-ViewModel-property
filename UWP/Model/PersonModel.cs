using Syncfusion.UI.Xaml.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class PersonModel : INotifyPropertyChanged
    {
        private ObservableCollection<object> selectedItems;
        public ObservableCollection<object> SelectedItems
        {
            get
            {
                return selectedItems;
            }
            set
            {
                selectedItems = value;
                RaisePropertyChanged("SelectedItems");
                UpdateSummary();
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
        public PersonModel()
        {
            RefreshCommand = new DelegateCommand(Refresh);
            this.GDCSource = Getsource();

        }

        private void Refresh(object obj)
        {
            this.GDCSource = Getsource1();
        }
        public DelegateCommand RefreshCommand { get; set; }

        private ObservableCollection<Person> _gdcsource;
        public ObservableCollection<Person> GDCSource
        {
            get { return _gdcsource; }
            set { _gdcsource = value; RaisePropertyChanged("GDCSource"); }
        }
        private ObservableCollection<Person> Getsource1()
        {
            ObservableCollection<Person> items1 = new ObservableCollection<Person>();
            if (items1 != null)
            {
                items1.Add(new Person() { FirstName = "Mahen", LastName = "annamalai", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items1.Add(new Person() { FirstName = "Srithar", LastName = "Chinasamy", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items1.Add(new Person() { FirstName = "Ashok", LastName = "Natesan", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items1.Add(new Person() { FirstName = "Aravind", LastName = "Vijay", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items1.Add(new Person() { FirstName = "Prem", LastName = "Jayapaul", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items1.Add(new Person() { FirstName = "Vaithees", LastName = "Jayaram", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items1.Add(new Person() { FirstName = "Mohan", LastName = "Dhanapal", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items1.Add(new Person() { FirstName = "venkatesh", LastName = "Nataraj", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items1.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items1.Add(new Person() { FirstName = "Kavin", LastName = "Marimuthu", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items1.Add(new Person() { FirstName = "Karthic", LastName = "Swamynathan", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items1.Add(new Person() { FirstName = "Antony", LastName = "Michal", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items1.Add(new Person() { FirstName = "Dinesh", LastName = "Balakrishnan", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items1.Add(new Person() { FirstName = "Bala", LastName = "pandurangan", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items1.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items1.Add(new Person() { FirstName = "Farjana", LastName = "annamalai", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items1.Add(new Person() { FirstName = "Parveen", LastName = "Farjana", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items1.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
            }
            return items1;
        }

        private ObservableCollection<Person> Getsource()
        {
            ObservableCollection<Person> items = new ObservableCollection<Person>();
            if (items != null)
            {
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Parveen", LastName = "Farjana", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Parveen", LastName = "Farjana", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Parveen", LastName = "Farjana", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Parveen", LastName = "Farjana", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Parveen", LastName = "Farjana", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 23, Salary = 1999, GrandTotal = 898908, PF = 8798798, ESI = 2498, Tax = 4298, Income = 2389, Company = "SF", Loss = 880, Profit = 880980, TrunOver = 48193891, Incometax = 234113, Expense = 98798798, Payslip = 8789, Unitprice = 987, Stockdetails = "Avial", StockCount = 8989, Count = 43 });
                items.Add(new Person() { FirstName = "Parveen", LastName = "Farjana", Age = 24, Salary = 12349, GrandTotal = 234923408, PF = 8798798, ESI = 423598, Tax = 568, Income = 289, Company = "WP", Loss = 450, Profit = 54580, TrunOver = 28193891, Incometax = 2113, Expense = 1798798, Payslip = 68789, Unitprice = 8798, Stockdetails = "Avial", StockCount = 4389, Count = 83 });
                items.Add(new Person() { FirstName = "Farjana", LastName = "Parveen", Age = 26, Salary = 123499, GrandTotal = 123495508, PF = 88798, ESI = 345348, Tax = 55398, Income = 4489, Company = "TC", Loss = 250, Profit = 234423, TrunOver = 2448193891, Incometax = 78124, Expense = 9879814, Payslip = 458789, Unitprice = 798, Stockdetails = "Avial", StockCount = 8966, Count = 89 });
            }
            return items;
        }
        public void UpdateSummary()
        {
            if (SelectedItems.Count == 1)
                Summary = string.Format("{0} item  selected.", selectedItems.Count);
            else
                Summary = string.Format("{0} items are selected.", selectedItems.Count);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
