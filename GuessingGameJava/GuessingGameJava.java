import java.util.Scanner;
import java.util.Random;
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
public class GuessingGameJava
{
static int getguess()
        {
        Scanner scan = new Scanner (System.in);
            System.out.println("Enter your guess: ");
            int guess = scan.nextInt();
            return guess;
        }
        static boolean ProcessGuess(int target, int guess)
        {
            if (guess < target)
            {
                System.out.println("My number is higher. Try Again");
                return false;
            }
            else if (guess > target)
            {
                System.out.println("My number is lower. Tray Again");
                return false;
            }
            else
            {
                System.out.println("That's it! You got my numebr");
                return true;
            }
        }
        public static void main(String[] args)
        {
            Random random = new Random();
            char ch = 'y';
            Scanner scan = new Scanner (System.in);
            while ((Character.toUpperCase(ch) == 'Y'))
                {
                int tries = 0;
                System.out.println("Enter the upper limit for this game");
                int uppernum = scan.nextInt();
                int guess = -12;
                int target = random.nextInt(uppernum);
                while (guess != target)
                {
                    tries++;
                    guess = getguess();
                    if (ProcessGuess(target, guess))
                        {
                        System.out.println("It only took you " + tries + " tries to guess it!");
                        System.out.println("Want to play Again? (Y/N)");
                        ch = scan.next().charAt(0);
                    }
                }
            }
        }
}