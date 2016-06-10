using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   /*
    * Author: Joanne (Hyunjung) Jung
    * Student # : 300432364
    * Date Modified: June 9th, 2016
    * Description: Main method fror driver class Program for Assignment 2
    * Version: 0.0.1 - Innitial Commit
    */
namespace COMP123_Assignment_2
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Hero Class
            Hero Ken = new Hero("KEN");
            Ken.Show();
            Ken.Fight();

        }
    }
}
