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
 * Version: 0.0.1 - Innitial Commit
 */
namespace COMP123_Assignment_2
{
    class SuperHero 
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
    }
}
