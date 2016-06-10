using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   /*
    * Author: Joanne (Hyunjung) Jung
    * Student # : 300432364
    * Date Modified: June 9th, 2016
    * Description: SuperHero class for Assignment 2
    * Version: 0.0.2 - Updated project with SuperHero class and other details
    */
namespace COMP123_Assignment_2
{ 
    public class SuperHero : Hero
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string[] _superPowers;

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
         * This method randomly generates three random superpowers from a list
         * </summary>
         * 
         * @private
         * @method _generateRandomPowers
         * @return {void}
         */

        private void _generateRandomPowers()
        {
           // int powerCount = this._superPowers;

            for (int Count = 0; Count < 3; Count++)
            {
                List<string> randomPowers = new List<string>();
                randomPowers.Add(("Super Speed"));
                randomPowers.Add("Super Strength");
                randomPowers.Add("Body Armour");
                randomPowers.Add("Flight");
                randomPowers.Add("Fire Generation");
                randomPowers.Add("Weather ControlSuper Speed");
            }
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
            Console.WriteLine("{0}", _superPowers);
        }
    }
}

