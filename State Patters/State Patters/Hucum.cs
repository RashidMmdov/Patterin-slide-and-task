using System;
using System.Collections.Generic;
using System.Text;

namespace State_Patters
{
    internal class Hucum : Console
    {
        public void PressSquare()
        {
            System.Console.WriteLine("Shut atildi");
        }
        public void PressTriangle()
        {
            System.Console.WriteLine("Ara passi atildi");
        }
        public void PressCircle()
        {
            System.Console.WriteLine("Ortaya ust pass atildi");
        }

        public void PressX()
        {
            System.Console.WriteLine("Pass atildi");
        }
    }
}
