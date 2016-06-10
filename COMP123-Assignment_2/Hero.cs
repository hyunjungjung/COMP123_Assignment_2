using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*
     * Author: Joanne (Hyunjung) Jung
     * Student # : 300432364
     * Date Modified: June 9th, 2016
     * Description: Hero class for Assignment 2
     * Version: 0.0.1 - Innitial Commit
     */
namespace COMP123_Assignment_2
{
    /**
    * This class defines a generic Hero
    * 
    * @class Hero
    * @field {int} _strength 
    * @field {int} _speed
    * @field {int} _health
    * @field {string} _name
    */
    class Hero
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // 1a
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // 1b
        /**
         * <summary>
         * This is a property for our _strength field
         * </summary>
         * @property {int} Strength
         */

        public int Strength
        {
            get { return this._strength; }
            set { this._strength = value; }
        }
        /**
         * <summary>
         * This is a property for our _speed field
         * </summary>
         * @property {int} Speed
         */
        public int Speed
        {
            get { return this._speed; }
            set { this._speed = value; }
        }
        /**
         * <summary>
         * This is a property for our _health field
         * </summary>
         * @property {int} Health
         */
        public int Health
        {
            get { return this._health; }
            set { this._health = value; }
        }
        /**
         * <summary>
         * This is a property for our _name field
         * </summary>
         * @property {string} Name
         */
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public Hero(string _name)
        {
            this.Name = _name;
            this._generateAbilities();
        }
        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method generates random integers for _strength, _ speed and _health.
         * </summary>
         * 
         * @private
         * @method _generateAbilities
         * @returns {void}
         */

        private void _generateAbilities()
        {

            Random number = new Random();
            _strength = number.Next(1, 101);
            _speed = number.Next(1, 101);
            _health = number.Next(1, 101);

        }
        /**
         * <summary>
         * This method generates the 20% of hit chance.
         * </summary>
         * 
         * @private
         * @method _hitAttempt
         * @returns {bool}
         */
        private bool _hitAttempt()
        {

            Random num = new Random();
            if (num.Next(1, 6) == 1)
            {
                return true;
            }
            else { return false; }
        }

        /**
         * <summary>
         * This method calculates the amount of damage based on Hero _strength by a randomly generated number.
         * </summary>
         * 
         * @private
         * @method _hitDamage
         * @returns {int} damage
         */
        private int _hitDamage()
        {
            Random num = new Random();
            int damage = _strength * num.Next(1, 7);
            return damage;
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method outputs value from _hitDamage based on _hitAttempt condition.
         * </summary>
         * 
         * @method Fight
         * @returns {void}
         */

        public void Fight()
        {
            if (_hitAttempt())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("      Your hit damage is {0}!!!!        ", _hitDamage());
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("         Hey Hero! You missed!          ");
                Console.ResetColor();
            }
            Console.WriteLine("==========================================");
        }

        /**
         * <summary>
         * This method outputs Strength, Speed and Health value for a hero.
         * </summary>
         * 
         * @method Show
         * @returns {void}
         */
        public void Show()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("    Strength     Speed      Health     ");
            Console.WriteLine("      {0}           {1}        {2}", _strength, _speed, _health);

        }

    }
}
