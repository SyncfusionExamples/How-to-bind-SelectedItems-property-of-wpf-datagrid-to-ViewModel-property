using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    class BusinessObjects : INotifyPropertyChanged
    {

        private string _ename;
        public string EmployeeName
        {
            get
            {
                return _ename;
            }
            set
            {
                _ename = value;
                OnPropertyChanged("EmployeeName");
            }
        }
        private bool hide = true;
        public bool Hide
        {
            get
            {
                return hide;
            }
            set
            {
                hide = value;
                OnPropertyChanged("Hide");
            }
        }
        private DateTime? datetime;
        public DateTime? EmployeeDate
        {
            get
            {
                return datetime;
            }
            set
            {
                datetime = value;
                OnPropertyChanged("EmployeeDate");
            }
        }

        private string _edesignation;
        public string EmployeeDesignation
        {
            get
            {
                return _edesignation;
            }
            set
            {
                _edesignation = value;
                OnPropertyChanged("EmployeeDesignation");
            }
        }


        private string _earea;
        public string EmployeeArea
        {
            get
            {
                return _earea;
            }
            set
            {
                _earea = value;
                OnPropertyChanged("EmployeeArea");
            }
        }

        private string _egender;
        public string EmployeeGender
        {
            get
            {
                return _egender;
            }
            set
            {
                _egender = value;
                OnPropertyChanged("EmployeeGender");
            }
        }

        private double _esalary;
        public double EmployeeSalary
        {
            get
            {
                return _esalary;
            }
            set
            {
                _esalary = value;
                OnPropertyChanged("EmployeeSalary");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
