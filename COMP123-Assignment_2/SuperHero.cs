using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   /*
    * Author: Joanne (Hyunjung) Jung
    * Student # : 300432364
    * Date Modified: June 10th, 2016
    * Description: SuperHero class for Assignment 2
    * Version: 0.0.3 - Updated project with SuperHero class and other details
    */
namespace COMP123_Assignment_2
{ 
    public class SuperHero : Hero
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string[] _superPowers = new string[1];
       //List<string> _superPowers = new List<string>();

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This property is for _superPowers field
         * </summary>
         * 
         * @property {string[]} SuperPowers
         */
        public string[] SuperPowers
        {
            get { return this._superPowers; }
            set { this._superPowers = value; }
        }

        // CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is the constructor Method for Hero class
         * </summary>
         * 
         * @constructor Hero
         */
        public SuperHero(string _name) 
            :base(_name)
        {
            this.Name = _name;
            this._generateRandomPowers();
        }
        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method randomly generates three random superpowers from the list
         * </summary>
         * 
         * @private
         * @method _generateRandomPowers
         * @return {void}
         */

        private void _generateRandomPowers()
        {
            // int powerCount = this._superPowers;
            List<string> SuperPowers = new List<string>();
            SuperPowers.Add(("Super Speed"));
            SuperPowers.Add("Super Strength");
            SuperPowers.Add("Body Armour");
            SuperPowers.Add("Flight");
            SuperPowers.Add("Fire Generation");
            SuperPowers.Add("Weather Control");

            Random random = new Random();
            
            for (int Count = 0; Count < 3; Count++)
            {
                
               int randomPower = random.Next(1, SuperPowers.Count);

                _superPowers[Count] = SuperPowers.ElementAt(randomPower);
                Console.WriteLine("{0}", SuperPowers[randomPower]);
                SuperPowers.RemoveAt(randomPower);
               
                //Console.WriteLine(_superPowers[Count]);
                
                //string powers = string.Join("/", _superPowers);

            }
            Console.WriteLine();
            
        }
        // PIBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method outputs values from _generateRandomPowers
         * </summary>
         * 
         * @method ShowPowers
         * @retunrs {void}
         */

        public void ShowPowers()
        {
            //Console.WriteLine("==========================================");
            //Console.WriteLine("         Earthman's super powers     ");
           // Console.WriteLine("{0}", SuperPowers);
            _generateRandomPowers();
            //Console.WriteLine("      {0}          ", SuperPowers);
            //Console.WriteLine(_superPowers);

            
        }
    }
}

