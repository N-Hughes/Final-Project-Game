using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Game
{
    public class Player
    {

        //Player Stats 
        public static int health = 200;
        public static int defence = 10;

        //Player Attacks
        int strike = 40, slash = 20, ice = 45, chargedStrike = 70, peck = 5;

        //Player Misc Moves
        bool defend, rest;

        public int width = 15, height = 10, x, y;

        public int playerAttack = 0;

        public Player(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Move(string direction)
        {


            if (direction == "up")
            {
                y -= 55;
            }
            if (direction == "down")
            {
                y += 55;
            }

            if (direction == "left")
            {
                x -= 173;
            }
            if (direction == "right")
            {
                x += 173;
            }

        }

        public void PlayerTurn(int playerAttack, string buttonName)
        {
            strike = 40;
            slash = 20;
            ice = 45;
            chargedStrike = 70;
            peck = 5;



            #region Attacks
            if (buttonName == "strike")
            {
                playerAttack = strike - Enemy.defence;
                Enemy.health -= playerAttack;
            }
            else if (buttonName == "slash")
            {
                playerAttack = slash - Enemy.defence;
                Enemy.health -= playerAttack;
            }
            else if (buttonName == "ice")
            {
                playerAttack = ice - Enemy.defence;
                Enemy.health -= playerAttack;
            }
            else if (buttonName == "chargedStrike")
            {
                playerAttack = chargedStrike - Enemy.defence;
                Enemy.health -= playerAttack;
            }
            else if (buttonName == "peck")
            {
                playerAttack = peck - Enemy.defence;
                Enemy.health -= playerAttack;
            }

            #endregion
            if(GameScreen.turn == 1)
            {
                playerAttack = 0;
            }
        }

    }
}
