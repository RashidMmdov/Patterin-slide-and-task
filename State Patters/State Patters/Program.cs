using System;

namespace State_Patters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.X();
            game.Triangle();
            game.Square();
            game.TopAlindi();
            game.DefanceyeKec();
        }
    }
}
