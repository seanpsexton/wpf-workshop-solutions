using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3_Examples_DataBinding
{
    public class Thing : ViewModelBase
    {
        private string name;

        public string Name
        {
            get => name;
            set => SetValue(ref name, value);
        }
    }
}
