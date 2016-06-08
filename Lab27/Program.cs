using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab 27
// Date: 04/19/2016 09:15:19 pm
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab27
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare my array referrencing to objects
            Box[] boxes = new Box[10];

            // This line of code gets the path to the My Documents Folder
            string environment = System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal) + "\\";

            Console.WriteLine("Enter a file name in My Documents: ");
            string input = Console.ReadLine();

            // concatenate the path to the file name
            string path = environment + input;

            // now we can use the full path to get the document
            StreamReader myFile = new StreamReader(path);

            //Declare a file line outside of the loop
            string fileLine = "";

            //Declare my index outside of the loop
            int index = 0;

            do
            {
                //set file line to the line in the content file read
                fileLine = myFile.ReadLine();

                //Read in the values and send them to their object
                if (fileLine != null && index < 10)
                {
                    //declare the array of strings
                    string[] data = fileLine.Split();

                    //declare the ints and store the values
                    int
                        box1 = int.Parse(data[0]),
                        box2 = int.Parse(data[1]),
                        box3 = int.Parse(data[2]);
                    boxes[index++] = new Box(box1, box2, box3);
                }

                //Create a break from the loop
                if (fileLine == null)
                {
                    //break out of the loop
                    break;
                }
            } while (index < 10);

            //Create space between
            WriteLine("\n\n\n-------CONTENT FROM FILE EXECUTED-------\n");
            //Create a for loop that will display the content of the file
            for (int i = 0; i < index; i++)
            {
                //Write line of the appropriate information
                WriteLine($"Box #{i + 1}'s volume is {boxes[i].GetVolume()}\n");
            }

            //Readline for the users benefit
            ReadLine();
            
        }
    }
}
