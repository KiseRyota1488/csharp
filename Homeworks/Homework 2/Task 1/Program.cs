using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;

            Console.Write("Enter letter: ");
            letter = (char)Console.Read();
            string revertLetter;

            if ((char)letter >= 'a' && (char)letter <= 'z')
                revertLetter = Convert.ToString(letter).ToUpper();
            else
                revertLetter = Convert.ToString(letter).ToLower();

            Console.WriteLine("Revert: {0}", revertLetter);
        }
    }
}
