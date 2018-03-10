using System;
/*********************************************************************************************************************************
Copyright and Licensing Message
This code is copyright 2018 Gary Cole Jr. 
This code is licensed by Gary Cole to others under the GPLv.3 https://opensource.org/licenses/GPL-3.0 
If you find the code useful or just feel generous a donation is appreciated.
Donate with this link: paypal.me/GColeJr
Please choose Friends and Family

Alternative Licensing Options
If you prefer to license under the LGPL for a project, https://opensource.org/licenses/LGPL-3.0
Single Developers working on their own project can do so with a donation of $20 or more. 
Small and medium companies can do so with a donation of $50 or more. 
Corporations can do so with a donation of $1000 or more.

If you prefer to license under the MS-RL for a project, https://opensource.org/licenses/MS-RL
Single Developers working on their own project can do so with a donation of $40 or more. 
Small and medium companies can do so with a donation of $100 or more.
Corporations can do so with a donation of $2000 or more.

if you prefer to license under the MS-PL for a project, https://opensource.org/licenses/MS-PL
Single Developers working on their own project can do so with a donation of $1000 or more. 
Small and medium companies can do so with a donation of $2000 or more.
Corporations can do so with a donation of $10000 or more.

If you use the code in more than one project, a separate license is required for each project.
Any modifications to this code must retain this message. 
*************************************************************************************************************************************/
namespace GuessingGame
{
    class Program
    {
        static int getguess()
        {
            Console.Write("Enter your guess: ");
            if (Int32.TryParse(Console.ReadLine(), out int guess))
                return guess;
            else
                throw new Exception("Your guess needs to be a number!!!!");

        }
        static bool ProcessGuess(int target, int guess)
        {
            if (guess < target)
            {
                Console.WriteLine("My number is higher. Try Again");
                return false;
            }
            else if (guess > target)
            {
                Console.WriteLine("My number is lower. Tray Again");
                return false;
            }
            else
            {
                Console.WriteLine("That's it! You got my numebr");
                return true;
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            char ch = 'y';
            while ((Char.ToUpper(ch) == 'Y'))
                {
                int tries = 0;
                Console.WriteLine("Enter the upper limit for this game");
                int uppernum = Int32.Parse(Console.ReadLine());
                int guess = -12;
                int target = random.Next(uppernum);
                while (guess != target)
                {
                    tries++;
                    guess = getguess();
                    if (ProcessGuess(target, guess))
                        {
                        Console.WriteLine($"It only took you {tries} tries to guess it!");
                        Console.WriteLine("Want to play Again? (Y/N)");
                        ch = Char.Parse(Console.ReadLine());
                    }
                }               
            }
        }
    }
}
