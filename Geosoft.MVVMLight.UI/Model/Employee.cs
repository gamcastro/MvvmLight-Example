﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geosoft.MVVMLight.UI.Model
{
    public class Employee : ObservableObject
    {
        private int _id;
        private string _name;
        private int _age;
        private decimal _salary;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                Set<int>(() => this.ID, ref _id, value);
            }
        }

        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
                Set<string>(() => this.Name, ref _name, value);
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                Set<int>(() => this.Age, ref _age, value);
            }
        }

        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                Set<decimal>(() => this.Salary, ref _salary, value);
            }
        }

        public static ObservableCollection<Employee> GetSampleEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            for (int i = 0; i < 30; i++)
            {
                employees.Add(new Employee
                {
                    ID = i + 1,
                    Name = "Name " + (i + 1).ToString(),
                    Age=20+i,
                    Salary=20000 + (i*10)
                });
                
            }
            return employees;
        }
    }
}
