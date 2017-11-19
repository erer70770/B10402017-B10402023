using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClassA
    {
            Random crandom = new Random();
            label1.Text = crandom.Next(0, 99).ToString(); 
    }
}
