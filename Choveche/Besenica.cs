using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Choveche
{
    class Besenica
    {
        public static char[] usedLetters = new char[50];
        public static int k=0;
        public static int lives = 5;
        public static char[] finalWord;
        public static int br=0;

        /// <summary>
        /// Reading from text file
        /// </summary>
        /// <param name="args"></param>
        static string read()
        {
            Random rand = new Random();
           
            StreamReader reader = new StreamReader("Words.txt",System.Text.Encoding.Unicode);                      
            string line=reader.ReadLine();

            int i = 1;
            int lineNumber = rand.Next(1, 10);
            string word=line;

            while(line  != null)
            {
                if (i == lineNumber)
                {
                    word = line;
                }
                Console.WriteLine(line);
                line = reader.ReadLine();
                i++;
            }        
      
            reader.Close();
            return word;             
        }

        /// <summary>
        /// Ima li * v dumata
        /// </summary>
        /// <returns></returns>
        static bool isStars(string word)
        {           
            return !(br == word.Length);           
        }

        /// <summary>
        /// Method
        /// </summary>
        /// <param name="myWord">The word to search in</param>
        /// <param name="myLetter">The letter to search for</param>
        static void LetterFound(string myWord, char myLetter)
        {
            bool isFound=false;
            if (myLetter == '\r')
            {
                return;
            }
            for (int i = 0; i <myWord.Length ; i++)
            {
                if (myLetter == myWord[i])
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write(myLetter);
                    finalWord[i] = myLetter;
                    isFound = true;
                    br++;
                }                
            }

            if (!isFound)
            {
                Console.SetCursorPosition(myWord.Length + 2, 0);
                Console.WriteLine("{0} jivota",lives-1);
                lives--;
                Choveche.DrawChoveche(lives);
            }
            
            Console.SetCursorPosition(0,k+2);
            usedLetters[k] = myLetter;
            k++;
        }

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine(read());

            string word = read();
            Console.Clear();
            finalWord = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("*");
                finalWord[i] = '*';
            }
            Console.WriteLine();




            while (lives > 0 && isStars(word))
            {
                //Console.WriteLine(lives);
                //Console.SetCursorPosition(0, k+1);

                char letter = (char)Console.Read();

                LetterFound(word, letter);
                Console.ReadLine();

            }

        }




        public static void mimi()
        {
            int[] matrix = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
                {
                    Console.Write(matrix[j + i * (int)Math.Sqrt(matrix.Length)]);
                }
                Console.WriteLine();
            }
        }
    }
}
