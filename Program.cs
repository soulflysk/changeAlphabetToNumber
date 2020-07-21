using System;

namespace changealphabettonumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
            string word = Convert.ToString(Console.ReadLine());
            char[] chars = word.ToCharArray();
            int score = 0;
            string result = "";
            foreach (char c in chars)
            {
                switch (c)
                {
                    case 'a':
                        score += 2;
                        result += "(A)";
                        break;
                    case 'e':
                        score += 3;
                        result += "(E)";
                        break;
                    case 'i':
                        score += 4;
                        result += "(I)";
                        break;
                    case 'o':
                        score += 5;
                        result += "(O)";
                        break;
                    case 'u':
                        score += 6;
                        result += "(U)";
                        break;
                    default:
                        score += 1;
                        result += c;
                        break;
                }
                
            }
            Console.WriteLine(result);
            Console.WriteLine("score = {0}", score);
            Console.ReadLine();
        }
    }
}
