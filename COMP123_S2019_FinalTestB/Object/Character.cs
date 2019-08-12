using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME:
 * STUDENT ID:
 * DESCRIPTION: This is the Character class used in chracter creation
 *              This is also the Data Container for the aplication
 */
namespace COMP123_S2019_FinalTestB.Object
{
    class Character
    {
        //Chracter Abilities
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }

        // Secondary Abilities
        public int ArmourClass { get; set; }
        public int HitPoint { get; set; }

        //Character Class
        public string CharacterClass { get; set; }
        public int Level { get; set; }

        //Equipment
        List<Item> Inventory;

        //Constructor
        Character()
        {
            this.Inventory = new List<Item>();
        }
    }
}
