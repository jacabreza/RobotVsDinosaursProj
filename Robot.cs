using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        // member variables (HAS A)
        public string name;
        public int health;
        public int powerLevel;
        public int attack;
        public Weapon robotsWeapon;

        // constructor (SPAWNER)

        public Robot(string nameOfRobot, string nameOfWeapon)
        {
            name = nameOfRobot;
            health = 100;
            powerLevel = 100;
            attack = 25;
            robotsWeapon = new Weapon(nameOfWeapon);

        }

        // member methods (CAN DO)
        public int RobotAttacks(Dinosaur dinosaur)
        {
            // robotWeapon, attack, powerLevel, dinosaurs and there health
            // robot loses energy from attack 

            int result;

            result = dinosaur.health - attack;          // OR dinosaur.health -= attack;
            return result;
            
            //powerLevel -= attack;



        }

    }

}
