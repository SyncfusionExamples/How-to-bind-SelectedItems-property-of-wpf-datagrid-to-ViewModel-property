using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    class EmployeeDetails : ObservableCollection<BusinessObjects>
    {
        Random rand = new Random();
        public EmployeeDetails()
        {
            PopulateCollection();
        }

        private void PopulateCollection()
        {
            this.Clear();
            for (int i = 0; i < 10; i++)
            {
                BusinessObjects b = new BusinessObjects() { EmployeeName = "Robert", EmployeeArea = "Torino", EmployeeDesignation = "Analysts", EmployeeSalary = 10000, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Steve", EmployeeArea = "Montreal", EmployeeDesignation = "SoftwareEngineer", EmployeeSalary = 15000, EmployeeGender = "Male", EmployeeDate = null };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Nancy", EmployeeArea = "Bracke", EmployeeDesignation = "Manager", EmployeeSalary = 27000, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Andrew", EmployeeArea = "Kobenhavn", EmployeeDesignation = "SalesRepresentative", EmployeeSalary = 20500, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
                this.Add(b);
            }

        }
    }
}
