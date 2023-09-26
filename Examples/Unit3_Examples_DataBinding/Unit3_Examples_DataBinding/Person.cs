﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3_Examples_DataBinding
{
    public class Person : ViewModelBase
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set => SetValue(ref firstName, value);
        }

        public string LastName
        {
            get => lastName;
            set => SetValue(ref lastName, value);
        }
    }
}
