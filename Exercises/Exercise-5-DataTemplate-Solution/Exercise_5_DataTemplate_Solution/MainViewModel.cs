﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_DataTemplate_Solution
{
    public class MainViewModel : ViewModelBase
    {
        private List<Person> people;
        private Person selectedPerson;

        public MainViewModel()
        {
            people = new List<Person>()
            {
                new Person("Joan", "Crawford", 1904, 1977),
                new Person("Ingrid", "Bergman", 1915, 1982),
                new Person("Marlene", "Dietrich", 1901, 1992),
                new Person("Joan", "Fontaine", 1917, 2013)
            };
        }

        public List<Person> People
        {
            get => people;
            set => SetValue(ref people, value);
        }

        public Person SelectedPerson
        {
            get => selectedPerson;
            set => SetValue(ref selectedPerson, value);
        }
    }
}
