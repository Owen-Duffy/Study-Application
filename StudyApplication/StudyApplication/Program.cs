using System;
using static System.Console;
//Created by Owen Duffy
//Intro to Programming Fall 2020 Jeff Myers
//With assistance from: Rigo Cervantes, Kharissma Thompson, Ishan Dutta, Angelo de Mello
namespace StudyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Clear();
            string TitleText = @"
                            
                 Press any key to begin!";
            Title = "Vocab Matchin'";
            Write(TitleText);
            WriteLine("");
            ReadKey();
            Clear();
            BackgroundColor = ConsoleColor.Black;
            Game game = new Game();
            BackgroundColor = ConsoleColor.Black;
            Clear();
            string EndText = @"
   Hope you learned something!";
            Write(EndText);
            ReadKey();
            Clear();

        }
    }
}
