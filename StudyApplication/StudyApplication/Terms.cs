using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace StudyApplication
{
    class Terms
    {
        public int score = 0;
        public int total = 15;

        public void somequestions()
        {
            string[] aryTerms = new string[15];
            aryTerms[0] = "function/method argument";
            aryTerms[1] = "function/method parameter";
            aryTerms[2] = "array";
            aryTerms[3] = "instance";
            aryTerms[4] = "array element";
            aryTerms[5] = "array index number";
            aryTerms[6] = "private";
            aryTerms[7] = "public";
            aryTerms[8] = "static";
            aryTerms[9] = "void";
            aryTerms[10] = "conditional statement";
            aryTerms[11] = "increment";
            aryTerms[12] = "while loop";
            aryTerms[13] = "for loop";
            aryTerms[14] = "switch";

            string[] aryDefs = new string[15];
            aryDefs[0] = "any expression within the parentheses of a function call";
            aryDefs[1] = "identifies values that are passed into a function";
            aryDefs[2] = "structures that organize related data into sets";
            aryDefs[3] = "have unique information, but will also have properties and/or operations that identify it as part of a specific class";
            aryDefs[4] = "a value or variable identified by at least one array index or key";
            aryDefs[5] = "the location of an item in an array";
            aryDefs[6] = "may be accessed only by other methods within the class";
            aryDefs[7] = "can be accessed by any other code";
            aryDefs[8] = "will not allow an instance of the class to be made";
            aryDefs[9] = "function will not return a value";
            aryDefs[10] = "runs only if a certain condition is met";
            aryDefs[11] = "increasing or decreasing a numeric value by another value";
            aryDefs[12] = "a loop that will run as long as the expression within the parentheses is true";
            aryDefs[13] = "a loop that collapses the counter initialization, the expression, and the increment into a header";
            aryDefs[14] = "will run statements if the value in the parentheses matches the value after \"case\"";

            Random random = new Random();
            int randomindex;

            string answer = "";

            for (int i = 0; i < aryDefs.Length; i++)
            {

                Clear();
                WriteLine($"Write the term that relates to: ");
                randomindex = random.Next(0, aryDefs.Length);


                WriteLine(aryDefs[randomindex]);

                answer = ReadLine();



                if (answer.ToLower() == aryTerms[randomindex])
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Nice job!");

                    ResetColor();

                    score++;
                    ReadKey();
                }

                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"The correct answer was: {aryTerms[randomindex]}.");

                    ResetColor();

                    ReadKey();
                }
                Clear();
            }
        }
    }
}
