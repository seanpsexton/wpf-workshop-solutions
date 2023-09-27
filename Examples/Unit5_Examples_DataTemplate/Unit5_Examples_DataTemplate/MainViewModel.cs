using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit5_Examples_DataTemplate
{
    public class MainViewModel : ViewModelBase
    {
        private List<Person> people;
        private Person selectedPerson;

        public MainViewModel()
        {
            people = new List<Person>()
            {
                new Person("Charles", "Chaplin", 1889, 1977),
                new Person("Mary", "Pickford", 1892, 1979),
                new Person("Spencer", "Tracy", 1900, 1967),
                new Person("Katharine", "Hepburn", 1907, 2003)
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
