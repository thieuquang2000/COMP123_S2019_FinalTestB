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
    public class Character
    {
        //Identity
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
        public CharacterClass Class { get; set; }
        public int Level { get; set; }

        //Equipment
        List<Item> inventory;

        //Constructor
        Character()
        {
            this.inventory = new List<Item>();
        }
    }
}
