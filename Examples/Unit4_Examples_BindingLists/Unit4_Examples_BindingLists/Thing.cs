using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4_Examples_BindingLists
{
    public class Thing : ViewModelBase
    {
        private double angle;
        private double scale = 1.0;

        public double Angle
        {
            get => angle;
            set => SetValue(ref angle, value);
        }

        public double Scale
        {
            get => scale;
            set => SetValue(ref scale, value); 
        }
    }
}
