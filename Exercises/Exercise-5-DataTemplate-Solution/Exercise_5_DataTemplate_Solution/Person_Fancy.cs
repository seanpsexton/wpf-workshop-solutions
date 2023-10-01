using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_DataTemplate_Solution
{
    public class Person_Fancy : ViewModelBase
    {
        private string firstName;
        private string lastName;
        private int birth;
        private int death;
        private string knownFor;

        public Person_Fancy(string firstName, string lastName, int birth, int death, string knownFor)
        {
            FirstName = firstName;
            LastName = lastName;
            Birth = birth;
            Death = death;
            KnownFor = knownFor;
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

        public string KnownFor
        {
            get => knownFor;
            set => SetValue(ref knownFor, value);
        }

        public string FullName => $"{firstName} {LastName}";

        public string Dates => $"({Birth} - {Death})";

        public string ImageSource => $"pack://application:,,,/Exercise_5_DataTemplate_Solution;component/Images/{LastName}.jpg";

        public override string ToString()
        {
            return $"{LastName}, {firstName}";
        }
    }
}
