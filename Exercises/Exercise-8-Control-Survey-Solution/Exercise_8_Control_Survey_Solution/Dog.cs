using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8_Control_Survey_Solution
{
    public class Dog : ViewModelBase
    {
        private string name;
        private int age;
        private IList<Dog> dogChildren;

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get => name;
            set => SetValue(ref name, value);
        }

        public int Age
        {
            get => age;
            set => SetValue(ref age, value);
        }

        public IList<Dog> DogChildren
        {
            get => dogChildren;
            set => SetValue(ref dogChildren, value);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
