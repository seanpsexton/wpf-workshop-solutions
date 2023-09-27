using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4_Examples_BindingLists
{
    public class Thing2 : ViewModelBase
    {
        List<string> dwarves;

        public Thing2()
        {
            dwarves = new List<string>()
            {
                "Sneezy", "Grumpy", "Dopey", "Bashful", "Sleepy", "Doc", "Happy", "Pensive"
            };
        }

        public List<string> Dwarves
        {
            get => dwarves;
        }
    }
}
