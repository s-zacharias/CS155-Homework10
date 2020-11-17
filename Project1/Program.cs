using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeAlien alien1 = new SnakeAlien(87, "snake", 12);
            OgreAlien alien2 = new OgreAlien(100, "ogre", 29);
            MarshallowManAlien alien3 = new
                MarshallowManAlien(10, "marshallow man", 5);

            Console.WriteLine(alien1.toString());
            Console.WriteLine(alien2.toString());
            Console.WriteLine(alien3.toString());
        }
    }
}
