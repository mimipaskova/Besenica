using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choveche
{
    class Choveche
    {
        public  const int BESILO = 4;
        public  const int HEAD = 3;
        public  const int ARMS = 2;
        public  const int BODY = 1;
        public  const int LEGS = 0;

        public static void DrawChoveche(int lives)
        {
           
            if (lives == BESILO)
            {
                Console.SetCursorPosition(Console.BufferWidth / 2, 0);
                Console.WriteLine("-------------------");
                Console.SetCursorPosition(Console.BufferWidth / 2, 1);
                Console.WriteLine("|                  |");
                Console.SetCursorPosition(Console.BufferWidth / 2, 2);
                Console.WriteLine("|                  |");
            }
            //head
            if (lives == HEAD)
            {
                Console.SetCursorPosition(Console.BufferWidth / 2, 3);
                Console.WriteLine("|                 ()");
                Console.SetCursorPosition(Console.BufferWidth / 2, 4);
                Console.WriteLine("|                ( )");
                Console.SetCursorPosition(Console.BufferWidth / 2, 5);
                Console.WriteLine("|               (   )");
                Console.SetCursorPosition(Console.BufferWidth / 2, 6);
                Console.WriteLine("|              (     )");
                Console.SetCursorPosition(Console.BufferWidth / 2, 7);
                Console.WriteLine("|              (     )");
                Console.SetCursorPosition(Console.BufferWidth / 2, 8);
                Console.WriteLine("|               (   )");
                Console.SetCursorPosition(Console.BufferWidth / 2, 9);
                Console.WriteLine("|                ( )");
            }
            //Arms
            if (lives == ARMS)
            {
                Console.SetCursorPosition(Console.BufferWidth / 2, 10);
                Console.WriteLine("|           \\     ()    /");
                Console.SetCursorPosition(Console.BufferWidth / 2, 11);
                Console.WriteLine("|            \\    |    /");
                Console.SetCursorPosition(Console.BufferWidth / 2, 12);
                Console.WriteLine("|             \\   |   /");
                Console.SetCursorPosition(Console.BufferWidth / 2, 13);
                Console.WriteLine("|              \\  |  /");
                Console.SetCursorPosition(Console.BufferWidth / 2, 14);
                Console.WriteLine("|               \\ | /");
                Console.SetCursorPosition(Console.BufferWidth / 2, 15);
                Console.WriteLine("|                \\|/");
            }
            //Body
            if (lives == BODY)
            {
                Console.SetCursorPosition(Console.BufferWidth / 2, 16);
                Console.WriteLine("|                 |");
                Console.SetCursorPosition(Console.BufferWidth / 2, 17);
                Console.WriteLine("|                 |");
                Console.SetCursorPosition(Console.BufferWidth / 2, 18);
                Console.WriteLine("|                 |");
                Console.SetCursorPosition(Console.BufferWidth / 2, 19);
                Console.WriteLine("|                 |");
                Console.SetCursorPosition(Console.BufferWidth / 2, 20);
                Console.WriteLine("|                 |");
                Console.SetCursorPosition(Console.BufferWidth / 2, 21);
                Console.WriteLine("|                 |");
                Console.SetCursorPosition(Console.BufferWidth / 2, 22);
                Console.WriteLine("|                 |");
                Console.SetCursorPosition(Console.BufferWidth / 2, 23);
                Console.WriteLine("|                 |");
                Console.SetCursorPosition(Console.BufferWidth / 2, 24);
                Console.WriteLine("|                 |");
            }
            //Legs
            if (lives == LEGS)
            {
                Console.SetCursorPosition(Console.BufferWidth / 2, 25);
                Console.WriteLine("|                /\\");
                Console.SetCursorPosition(Console.BufferWidth / 2, 26);
                Console.WriteLine("|               /  \\");
                Console.SetCursorPosition(Console.BufferWidth / 2, 27);
                Console.WriteLine("|              /    \\");
                Console.SetCursorPosition(Console.BufferWidth / 2, 28);
                Console.WriteLine("|             /      \\");
                Console.SetCursorPosition(Console.BufferWidth / 2, 29);
                Console.WriteLine("|            /        \\");
                Console.SetCursorPosition(Console.BufferWidth / 2, 30);
                Console.WriteLine("|           /          \\");
            }

        }
    }
}
