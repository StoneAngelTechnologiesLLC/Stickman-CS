// John Pietrangelo 9am CIS340
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//                                         !!! EXPAND CONSOLE SCREEN RIGHT AFTER STARTING PROGRAM FOR BEST EFFECT !!!
namespace JohnPietrangelo7Arrays
{
    class Program
    {
        static void Main(string[] args)
        { 
         // Used in Stickman Animation
            bool legsShouldPrint = true;
            int i, move;
            string head1 = " 0 ";
            string body1 = "!T!";
            string legs1 = "/ \\";
            string legs2 = " | ";
            
         // Used in Array Assignment   
            double average1, average2, result1, result2;
            double[] myGradesArray = new double[3] {99.5, 92, 90};
            double total = 0;
         // int i; 
            string[] words = new string[3] {"Brown", "Green", "John"};
            string eMail = "jjpietra@asu.edu";

         // To move Stickman across screen
            for (i = 0; i < 65; i++)
            {
             // To clear each previous move across screen
                Console.Clear();

             
                move = i + 4;//         PadLeft() method took me a while to find.
                Console.WriteLine(head1.PadLeft(move));
                Console.WriteLine(body1.PadLeft(move));

             // Moves legs across screen while rotating display of leg1 & leg2 each cycle through loop.
                if (legsShouldPrint)
                {
                    Console.WriteLine(legs1.PadLeft(move,' '));
                }
                else
                {
                    Console.WriteLine(legs2.PadLeft(move,' '));
                }
                legsShouldPrint = !legsShouldPrint;

             // Slows down Console display of each cycle, through loop. 
                System.Threading.Thread.Sleep(50);
            }
 
         // Totals all exam scores together.
            for (i = 0; i < myGradesArray.Length; i++)
            {
                total += myGradesArray[i];    
            }

         // Creates 2 variables to store exam average. 
            average1 = (total / 3);
            average2 = myGradesArray.Average();

         // Creates variable to store the total of multiplying exam 1 & 2 together.
            result1 = (myGradesArray[0] * myGradesArray[1]);

         // Creates variable to store the total of dividing exam3 score into exam2 score.
            result2 = (myGradesArray[2] / myGradesArray[1]);

         // Displays average exam score and multiplication/divition problems/answers.   
            Console.WriteLine("Exam Average: {0:0.000}\t\t\t        Exam Average: {1:0.000}\n", average1, average2);
            Console.WriteLine("Exam Score #1({0}) Multiplied by Exam Score #2({1}) = \t  {2,10:N0}\n", myGradesArray[0], myGradesArray[1], result1);
            Console.WriteLine("Exam Score #3({0}) Divided by Exam Score #2({1}) =     {2,15:0.000}\n", myGradesArray[2], myGradesArray[1], result2);
         
         // Displays the use of the Word array, in 4 statements.
            Console.WriteLine("My hair color is {0}.\n\nMy favorite color is {1}.\n\n" +
                              "{2} is my name.\n\nThe 3 words in my array are: {0}, {1}" + 
                              " & {2}.\n", words[0], words[1], words[2]);

            Console.WriteLine("    *** Working with a String as an Array ***\n\n\t\t Viertical Example\n\t\t -----------------");
         
         // Cycles through string, identifing each index and the stored element within.
            for (i = 0; i < eMail.Length; i++)
            {
             // Vertical example of using a string as an array.
             // Displays Each inedx and the stored element within.
                Console.WriteLine("{0,25} {1}", i, eMail[i]);
            }

            Console.WriteLine("\n\t\tHorizontal Example\n\t\t------------------");

         // Cycles through string, identifing each index and the stored element within.
            for (i = 0; i < eMail.Length; i++)
            {
             // Horizontal example of using a string as an array.
             // Displays Each index.   ".ToString()" method is optional, just wanted to see if it compiled. 
                Console.Write("{0,3}", i); 
            }

            Console.WriteLine();

            for (i = 0; i < eMail.Length; i++)
            {
             // Displays Each element in index.
                Console.Write("{0,3}", eMail[i]);
            }

            Console.WriteLine("\n\nEmail Reversed\n--------------");

         // Cycles through String as an array, from last index to 1st.
            for (i = 15; i >= 0; i--)
            {
             // Displays e-mail string in reverse order.
                Console.Write("{0}", eMail[i]);
            }

            Console.WriteLine("\n\n\t      Finding Element in Index\n\t      ------------------------" );

         // Cycles through string as an array.
            for (i = 0; i < eMail.Length; i++)
            {
             // to make decision when element '@' is found in a string index.
                if (eMail[i] == '@')
                {
                 // Displays index # and '@' element.
                    Console.WriteLine("\t     Found Symbol:{1}, in Index:{0}", i, eMail[i]);
                }
            }
         // Prompts user to exit program.
            Console.Write("\n*******************************************************************"+
                          "\n\n\t\tpress any key to exit");
            
            Console.ReadKey();
        }
    }
}
