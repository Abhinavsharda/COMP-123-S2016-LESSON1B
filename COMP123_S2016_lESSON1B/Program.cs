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
 *Version: 0.2- Added GetusreName method
*/


namespace COMP123_S2016_lESSON1B
{
    class Program
    {
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
   {// initalize variable
            string UserName = "";
            Console.Write("Enter User Name");
            UserName = Console.ReadLine();

            Console.WriteLine("/n===========");
            Console.WriteLine("You Entered:" + UserName);}
} 

}
