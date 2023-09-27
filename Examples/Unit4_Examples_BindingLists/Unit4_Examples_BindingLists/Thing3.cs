using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4_Examples_BindingLists
{
    public class Thing3 : ViewModelBase
    {
        List<string> dwarves;
        string selectedDwarf;

        public Thing3()
        {
            dwarves = new List<string>()
            {
                "Sneezy", "Grumpy", "Dopey", "Bashful", "Sleepy", "Doc", "Happy", "Pensive"
            };
            selectedDwarf = null;
        }

        public List<string> Dwarves
        {
            get => dwarves;
        }

        public string SelectedDwarf
        {
            get => selectedDwarf;
            set => SetValue(ref selectedDwarf, value);
        }
    }
}
