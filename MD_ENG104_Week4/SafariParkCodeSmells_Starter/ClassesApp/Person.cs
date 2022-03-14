using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    // A Class to represent a Person
    public class Person 
    {
        private string fistName;
        private string _lastName;
        private int _age;
        private Adress _adress;

        public Person() { }
        public Person(string fName, string lName, Adress adress = null)
        {
            fistName = fName;
            _lastName = lName;
            _adress = adress;
            //_adress = new Adress(24, "Birt", "London");
        }

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public string GetFullName()
        {
            return $"{fistName} {_lastName}";
        }

        public string Move()
        {
            return "Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}. {GetAddress()}";
        }

        private string GetAddress()
        {
            return $"Address: {_adress.GetAdress()}";
        }
    }
}
