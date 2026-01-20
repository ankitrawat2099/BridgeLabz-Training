using System;

namespace PasswordCracker
{
    class PasswordGenerator : IPasswordOperation
    {
        private int length;                 // encapsulated data
        private char[] characters = { 'a', 'b', 'c' };
        //constructor 
        public PasswordGenerator(int length)
        {
            this.length = length;
        }
        //method to execute
        public void Execute()
        {
            Generate("", 0);
        }
        //method to generate
        private void Generate(string current, int index)
        {
            if (index == length)
            {
                Console.WriteLine(current);
                return;
            }

            foreach (char c in characters)
            {
                Generate(current + c, index + 1);
            }
        }
    }
}
