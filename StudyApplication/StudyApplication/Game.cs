using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace StudyApplication
{
    class Game
    {
        string input;
        Terms questions = new Terms();
        Player player;
        public Game()
        {
            Player player = new Player();
            WriteLine("What's your name.");
            player.name = ReadLine();
            WriteLine("It's time for a quiz, " + player.name + "! \n" +
                "For this quiz, you will asked questions that you must correctly answer. \n" +
                "Choose your answer that you think fits best.  \n" +
                "If you are correct, your score will increase.  \n" +
                "Your final score will be told to you at the end. \n" +
                "\n Best of luck!");
            WriteLine("Press any key to continue");
            ReadKey();
            Clear();
            play();
        }

        public void play()
        {
            questions.somequestions();
            WriteLine($"Your current score is {questions.score} out of {questions.total}.");
        }

        public void End()
        {
            WriteLine($"Would you like to retake the quiz?");
            input = ReadLine();

            if (input.ToLower() == "yes" || input.ToLower() == "y" || input.ToLower() == "ye" | input.ToLower() == "yeah")
            {
                play();
            }

            else
            {
                WriteLine("Okay, well I hope you learned something.");
                ReadKey();
            }

        }
    }
}

