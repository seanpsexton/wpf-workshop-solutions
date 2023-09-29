using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Exercise_8_Control_Survey_Solution
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand myCommand;
        private IList<Dog> dogs;

        public MainViewModel()
        {
            myCommand = new DelegateCommand(
                (_) => MessageBox.Show("Hello MTS"),
                (_) => true);

            dogs = new List<Dog>()
            {
                new Dog("Bowser", 4),
                new Dog("Lassie", 12),
                new Dog("Rover", 3),
                new Dog("Pluto", 38)
            };
            dogs[0].DogChildren = new List<Dog>()
            {
                new Dog("Billy", 1),
                new Dog("Buddy", 2)
            };
            dogs[1].DogChildren = new List<Dog>()
            {
                new Dog("Lily", 1),
                new Dog("Lady", 2)
            };
            dogs[2].DogChildren = new List<Dog>()
            {
                new Dog("Rufus", 1),
                new Dog("Rose", 2)
            };
        }

        public ICommand MyCommand => myCommand;

        public IList<Dog> Dogs => dogs;
    }
}
