using System;

namespace Question_1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CharacterCount();

        }
        static void CharacterCount()
        {
           string password = "Dog231Lover";
           int alpha = 1;
           int digit = 1;


            for (int i = 0; i < password.Length; i++)
            {
                while (i >= 0)
                {
                    if ((password[i] >= 'a' && password[i] <= 'z') || (password[i] >= 'A' && password[i] <= 'Z'))
                    {
                        alpha++;
                    }
                    else
                    {
                        digit++;
                    }
                    i++;
                }
            }
            Console.WriteLine("The number of text characters are: {0}", alpha);
            Console.WriteLine("The number of numeric characters are: {0}", digit);
        }
    }
}
