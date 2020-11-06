using System;
using System.Collections.Generic;

namespace CountingCharacters2
{
    class Program
    {
        static void Main(string[] args)
        {
            string loremIpsumString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] charactersInString = loremIpsumString.ToCharArray();
            CountChar(charactersInString);
        }

        public static void CountChar(char[] charactersInString)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            
            foreach (char item in charactersInString)
            {
                if (charCount.ContainsKey(item))
                {
                    int count = charCount[item];
                    charCount[item] = count + 1;
                }
                else
                {
                    charCount.Add(item, 1);
                }
            }

            foreach (KeyValuePair<char, int> kvp in charCount)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
        }
    }
}
