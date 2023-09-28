﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise_7_Resources_Styles_Solution
{
    /// <summary>
    /// Interaction logic for Part1Window.xaml
    /// </summary>
    public partial class Part1Window : Window
    {
        public Part1Window()
        {
            InitializeComponent();
            var part2 = new Part2Window();
            part2.Show();
            var part3 = new Part3Window();
            part3.Show();
        }
    }
}
