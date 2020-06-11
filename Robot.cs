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
        public Weapon robotsWeapon;

        // constructor (SPAWNER)

        public Robot(string nameOfRobot, string nameOfWeapon)
        {
            name = nameOfRobot;
            health = 100;
            powerLevel = 100;
            robotsWeapon = new Weapon(nameOfWeapon);        //ChooseWeaponForRobot();

        }

        // member methods (CAN DO)
        public void RobotAttacks(Dinosaur dinosaur)
        {
            // robotWeapon, attack, powerLevel, dinosaurs and there health
            // robot loses energy from attack 

            dinosaur.health -= robotsWeapon.attackPower;          
            
            
            //powerLevel -= attack;

        }
        //public Weapon ChooseWeaponForRobot()
        //{
        //    Console.WriteLine("Type in a name for the weapon you want to use");
        //    string weapon = Console.ReadLine();
        //    return robotsWeapon = new Weapon(weapon);

        //}

    }

}
