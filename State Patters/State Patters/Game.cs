using System;
using System.Collections.Generic;
using System.Text;

namespace State_Patters
{
    internal class Game
    {
       private Console console;
        public Game()
        {
            System.Console.WriteLine("Oyun Basladi:\n");
            console = new Hucum();
        }
        public void Triangle()
        {
            console.PressTriangle();
        }
        public void Square()
        {
            console.PressSquare();
        }
        public void Circle()
        {
            console.PressCircle();
        }
        public void X()
        {
            console.PressX();
        }
        public void TopAlindi()
        {
            System.Console.WriteLine("Topu reqib komanda aldi ve hucum edirler.");
            console = new Hucum();
        }
        public void DefanceyeKec()
        {
            System.Console.WriteLine("Hucum edirler mudafiyyeye gelin.");
            console = new Mudafiyye();
        }
    }
}
