using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_BindingToList_Solution
{
    public class Person : ViewModelBase
    {
        private string firstName;
        private string lastName;
        private int birth;
        private int death;

        public Person(string firstName, string lastName, int birth, int death)
        {
            FirstName = firstName;
            LastName = lastName;
            Birth = birth;
            Death = death;
        }

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

        public int Birth
        {
            get => birth;
            set => SetValue(ref birth, value);
        }

        public int Death
        {
            get => death;
            set => SetValue(ref death, value);
        }

        public override string ToString()
        {
            return $"{LastName}, {firstName}";
        }
    }
}
