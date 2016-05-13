using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Aurthor: Abhinav Sharda
 * DAte: 13 May,2016
 * Student ID: 300868625
 * 
 * Discruption: This program demonstrate Github control and vision contro
 *best practicse
 *Version: 0.6 -  refracted using the ternary operator
 */


namespace COMP123_S2016_lESSON1B
    /**
     * This is the driver class of our program
     * 
     * @class Program
     */



public  class Program
    {
        /**
         * Main method for class of our program
         * 
         * @class program
         * @construct main
         */
        static void Main(string[] args)
        {
            GetUserName();
        }

        /**
         * This method Read User name From Console
         * 
         * @method GetUSer Name
         * @return {String} UserName
         * */
        public static string GetUserName()
        
        {
       // initalize variable
            string UserName = "";
             OutPutStringConsole("Enter User Name");
            UserName = Console.ReadLine();

            Console.WriteLine("/=========================");
            Console.WriteLine("You Entered:" + UserName);
            return UserName;
        }
        /**
         * This method Writes a string to console
         * chooseto add 
         */

public static string OutPutStringConsole(string outputString,bool hasNewLine)
{
      /**f(hasNewLine)
        {
    Console.Write(outputString);
        }
    
        else
        {
            Console.WriteLine(outputString);
        }
       */
         // refracted using the ternary operator
    string suffixString = hasNewLine ? "\n" : "";
    Console.Write(outputString+suffixString);
    return outputString;
}
    }
