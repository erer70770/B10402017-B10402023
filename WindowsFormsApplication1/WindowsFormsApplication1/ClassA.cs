﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClassA
    {
        public int GetNumber()
        {
            Random crandom = new Random();
            return crandom.Next(0, 99);
        }
    }
}
