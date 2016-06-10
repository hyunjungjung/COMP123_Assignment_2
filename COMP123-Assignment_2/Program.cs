using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Joanne (Hyunjung) Jung
 * Student # : 300432364
 * Date Modified: May 31, 2016
 * Description: Main method fror driver class Program for Assignment 1
 * Version: 0.0.5 - Added public methods Fight and Show, and implemented the Hero class 
 * by creating a new hero object
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
