using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*
     * Author: Joanne (Hyunjung) Jung
     * Student # : 300432364
     * Date Modified: June 910th, 2016
     * Description: Main method fror driver class Program for Assignment 2
     * Version: 0.0.4 - Final commit
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
            // new instance of SuperHero class
            SuperHero earthMan = new SuperHero("Earthman");
            earthMan.Show();      
            earthMan.Fight();
            earthMan.ShowPowers();
        }
    }
}
