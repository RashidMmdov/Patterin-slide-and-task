using System;
using System.Collections.Generic;
using System.Text;

namespace State_Patters
{
    internal class Mudafiyye : Console
    {
       
        public void PressSquare()
        {
            System.Console.WriteLine("Mudaxile edildi.");
        }

        public void PressTriangle()
        {
            System.Console.WriteLine("Qapici qapini terk etdi edildi.");
        }

        public void PressCircle()
        {
            System.Console.WriteLine("Suruserek mudaxile edildi.");
        }

        public void PressX()
        {
            System.Console.WriteLine("Isaretlenen Top izlenilir.");
        }
    }
}
