using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_DinosZ
{
    class Weapon
    {
        //Memeber Varibles
        public string name;
        public int attackPower;
        public int powerLevelDecrease;

        //Constructor
        public Weapon(string name, int attackPower, int powerLevelDecrease)
        {
            this.name = name;
            this.attackPower = attackPower;
            this.powerLevelDecrease = powerLevelDecrease;
        }
    }
}
