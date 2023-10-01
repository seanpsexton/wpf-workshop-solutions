using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_DataTemplate_Solution
{
    public class MainViewModel_Fancy : ViewModelBase
    {
        private List<Person_Fancy> people;
        private Person selectedPerson;

        public MainViewModel_Fancy()
        {
            people = new List<Person_Fancy>()
            {
                new Person_Fancy("Joan", "Crawford", 1904, 1977, "Mildred Pierce"),
                new Person_Fancy("Ingrid", "Bergman", 1915, 1982, "Gaslight"),
                new Person_Fancy("Marlene", "Dietrich", 1901, 1992, "The Blue Angel"),
                new Person_Fancy("Joan", "Fontaine", 1917, 2013, "Suspicion")
            };
        }

        public List<Person_Fancy> People
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
