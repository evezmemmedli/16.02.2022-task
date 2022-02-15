using System;

namespace _16._02._2022_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string mixLetters = "SALAM usaqlar";
            string newMixLetters = "";

            for (int i = 0; i < mixLetters.Length; i++)
            {
                if (char.IsUpper(mixLetters[i]))
                {
                    newMixLetters += mixLetters[i].ToString().ToLower();

                }
                else
                {
                    newMixLetters += mixLetters[i].ToString().ToUpper();

                }

            }
            Console.WriteLine(newMixLetters);

        }
    }
}
