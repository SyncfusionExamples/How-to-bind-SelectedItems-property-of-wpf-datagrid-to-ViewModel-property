using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectedItemsBindingDemo
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _salary;
        private int _granttotal;
        private double _pf;
        private double _esi;
        private double _tax;
        private int _income;
        private string _company;
        private double _loss;
        private double _profit;
        private double _turnover;
        private double _incometax;
        private double _expense;
        private double _payslip;
        private double _unitprice;
        private string _stockdetails;
        private int _stockcount;
        private int _count;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnPropertyChanged("LastName"); }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged("Age"); }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; OnPropertyChanged("Salary"); }
        }

        public int GrandTotal
        {
            get { return _granttotal; }
            set { _granttotal = value; OnPropertyChanged("GrandTotal"); }
        }

        public double PF
        {
            get { return _pf; }
            set { _pf = value; OnPropertyChanged("PF"); }
        }

        public double ESI
        {
            get { return _esi; }
            set { _esi = value; OnPropertyChanged("ESI"); }
        }

        public double Tax
        {
            get { return _tax; }
            set { _tax = value; OnPropertyChanged("Tax"); }
        }

        public int Income
        {
            get { return _income; }
            set { _tax = value; OnPropertyChanged("Income"); }
        }
        public string Company
        {
            get { return _company; }
            set { _company = value; OnPropertyChanged("Company"); }
        }

        public double Loss
        {
            get { return _loss; }
            set { _loss = value; OnPropertyChanged("Loss"); }
        }

        public double Profit
        {
            get { return _profit; }
            set { _profit = value; OnPropertyChanged("Profit"); }
        }

        public double TrunOver
        {
            get { return _turnover; }
            set { _turnover = value; OnPropertyChanged("TrunOver"); }
        }

        public double Incometax
        {
            get { return _incometax; }
            set { _incometax = value; OnPropertyChanged("Incometax"); }
        }

        public double Expense
        {
            get { return _expense; }
            set { _expense = value; OnPropertyChanged("Expense"); }
        }

        public double Payslip
        {
            get { return _payslip; }
            set { _payslip = value; OnPropertyChanged("Payslip"); }
        }

        public double Unitprice
        {
            get { return _unitprice; }
            set { _unitprice = value; OnPropertyChanged("Unitprice"); }
        }

        public string Stockdetails
        {
            get { return _stockdetails; }
            set { _stockdetails = value; OnPropertyChanged("Stockdetails"); }
        }

        public int StockCount
        {
            get { return _stockcount; }
            set { _stockcount = value; OnPropertyChanged("StockCount"); }
        }

        public int Count
        {
            get { return _count; }
            set { _count = value; OnPropertyChanged("Count"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
