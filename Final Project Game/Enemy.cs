using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Game
{
    internal class Enemy
    {

        public static int health, defence;

        #region Move List

        //Attacks
        int strike = 50, slash = 30, kick = 15, chargedStrike = 115, fire = 55, bolt = 70, ice = 60, peck = 5;

        //Debuffs
        bool poison;

        //Other Moves
        bool defend, rest;

        #endregion

        public void EnemyOne(int _strike, int _chargedStrike, int _kick, bool _defend, bool _rest, int _health, int _defence)
        {
            strike = _strike;
            chargedStrike = _chargedStrike;
            kick = _kick;
            defend = _defend;
            rest = _rest;

            health = _health;
            defence = _defence;
        }

        public void EnemyTwo(int _slash, int _fire, int _ice, bool _defend, bool _rest, int _health, int _defence)
        {
            slash = _slash;
            fire = _fire;
            ice = _ice;
            defend = _defend;
            rest = _rest;

            health = _health;
            defence = _defence;
        }

        public void EnemyThree(int _strike, int _slash, int _chargedStrike, int _ice, int _kick, bool _defend, bool _rest , int _defence, int _health)
        {
            strike = _strike;
            slash = _slash;
            chargedStrike = _chargedStrike;
            kick = _kick;
            ice = _ice;
            defend = _defend;
            rest = _rest;

            defence = _defence;
            health = _health;
        }



    }
}
