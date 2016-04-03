﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dragon.Library.Objects;

namespace Dragon.Library.Entities
{
    public class CustomerCollection
    {
        public static ObservableCollection<Customer> CUS;
        public CustomerCollection()
        {
            CUS = new ObservableCollection<Customer>();
            CUS.Add(new Customer());
        }
    }

   public class Customer
    {
       public Customer()
       {
           _User = new UserProfile();
       }

        private Guid _CustomerID;
        public Guid CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
        private string _Name;
        public string Name {
            get { return _Name; }
            set { _Name = value; }
        }

        private UserProfile _User;
        public UserProfile User
        {
            get { return _User; }
            set { _User = value; }
        }

        private Employee[] _EmployeeList;
        public Employee EmployeeList(Guid ID)
        {
            return (Employee)from Employee emp in _EmployeeList where emp.ID == ID select emp;
        }

        private Communication _Contact;
        public Communication Contact
        {
            get { return _Contact; }
            set { _Contact = value; }
        }

        private string _OrginizationName;
        public string OrginizationName
        {
            get { return _OrginizationName; }
            set { _OrginizationName = value; }
        }

        private Address _BusinessAddress;
        public Address BusinessAddress
        {
            get { return _BusinessAddress; }
            set { _BusinessAddress = value; }
        }
    }
}
