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
    class ViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        EmployeeDetails emp = new EmployeeDetails();
        #region Constructor

        public ViewModel()
        {
            RefreshCommand = new DelegateCommand(Refresh);
            this.GDCSource = emp;
        }

        private void Refresh(object obj)
        {
            EmployeeDetails emp1 = new EmployeeDetails();

        }



        #endregion


        private ObservableCollection<BusinessObjects> gdcsource;
        public ObservableCollection<BusinessObjects> GDCSource
        {
            get
            {
                return gdcsource;
            }
            set
            {
                gdcsource = value;
                OnPropertyChanged("GDCSource");
            }
        }

        public DelegateCommand RefreshCommand { get; set; }
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
