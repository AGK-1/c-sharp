// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

Random random = new Random();
bool play=true;
int min=1;
int max=100;
int guess;
int number;
int cehd;
string res;
while (play)
{
    number = random.Next(min, max + 1);
    guess = 0;
    cehd = 0;

    Console.WriteLine("Guess number between " + min + " " + max);
    while (guess !=number) {
        
        guess = Convert.ToInt32(Console.ReadLine());
        if (guess > number)
        {
            Console.WriteLine(guess + " is to high");
        }
        else if (guess < number) 
        { 
         Console.WriteLine(guess+ " is to low");
        }
        cehd++;
    }
    Console.WriteLine("Congratulation you WIN \n number is:"+number);
    Console.Beep();
    Console.WriteLine("Your attempts " + cehd);
    Console.WriteLine("Would you like to play again (Y/N)");
    res = Console.ReadLine();
    res = res.ToUpper();
    if (res == "Y")
    {
        play = true;
    }
    else
    {
        play = false;
    }
}

Console.WriteLine("Thanks or playing");

Console.ReadKey();
