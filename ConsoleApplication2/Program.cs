﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.ServiceReference;
using System.Data;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Viewer view = new Viewer();
            view.Choices();
        }
    }
}
