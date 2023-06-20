using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Game
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
            player = new Player(630, 732);
        }

        #region Game Values 

        public static int level = 0;

        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, enterKeyDown;

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Random randGen = new Random();

        Player player;
        public static int turn = 1;

        //bool attack = attackButton.Click;

        ///Player 
        //Attacks
        int playerStrike = 40, playerSlash = 20, playerIce = 45, playerChargedStrike = 70;

        //Other Moves

        ///Player

        ///Enemy  
        //Attacks
        int enemyAttack;
        int strike = 50, slash = 30, kick = 15, chargedStrike = 115, fire = 55, bolt = 70, ice = 60, peck = 5;

        //Debuffs
        bool poison;

        //Other Moves
        bool defend, rest;
        ///Enemy
        #endregion

        private void GameEngine_Tick(object sender, EventArgs e)
        {
            #region Moving 
            //if (downArrowDown && player.y < 732)
            //{
            //    player.Move("down");
            //}
            //else if (upArrowDown && player.y > 841)
            //{
            //    player.Move("up");
            //}


            //if (rightArrowDown && player.x < 630)
            //{
            //    player.Move("right");
            //}
            //else if (leftArrowDown && player.x > 808)
            //{
            //    player.Move("left");
            //}
            #endregion

            #region Player Rules
            if (Player.defence >= 50 && turn == 1)
            {
                Player.defence -= 50;
            }

            if (Player.health > 200)
            {
                Player.health = 200;
            }

            if (turn == 2)
            {
                strikeButton.Visible = false;
            }

            if (turn == 2)
            {
                outputLabel.Text += $"You dealt {player.playerAttack} damage\n\n";
            }
            else if (turn == 1)
            {
                outputLabel.Text += $"Enemy dealt {enemyAttack} damage\n\n";
                enemyAttack = 0;
            }
            #endregion

            #region Enemy Rules 
            if (turn == 2 && level == 1)
            {

                Enemy.EnemyOne(strike, chargedStrike, kick, defend, rest, 200, 15);
                EnemyTurn(1);
            }
            else if (turn == 2 && level == 2)
            {

                Enemy.EnemyTwo(strike, chargedStrike, kick, defend, rest, 200, 15);
                EnemyTurn(2);
            }
            else if (turn == 2 && level == 3)
            {

                Enemy.EnemyThree(strike, chargedStrike, kick, defend, rest, 200, 15);
                EnemyTurn(3);
            }


            if (Enemy.defence >= 30 && turn == 2)
            {
                Enemy.defence -= 30;
            }

            if (Enemy.health > 200)
            {
                Enemy.health = 200;
            }


            if (Enemy.health == 0)
            {
                level++;
                turn = 2;
            }
            #endregion



            Refresh();
        }

        public void EnemyTurn(int level)
        {
            int randAttack = randGen.Next(1, 4);
            int randMove = randGen.Next(1, 4);

            if (randMove == 1)
            {
                Enemy.defence += 50;
                turn = 1;
            }
            else if (randMove == 2)
            {
                Enemy.health += 30;
                turn = 1;
            }
            if (Player.health < 50 || randMove == 3)
            {
                if (randAttack == 1)
                {
                    enemyAttack = strike - Player.defence;
                    if (enemyAttack <= 0)
                    {
                        enemyAttack = 1;
                    }
                    Player.health -= enemyAttack;
                    turn--;

                }
                else if (randAttack == 2 && level == 2 || level == 3)
                {
                    enemyAttack = chargedStrike - Player.defence;
                    if (enemyAttack <= 0)
                    {
                        enemyAttack = 1;
                    }
                    Player.health -= enemyAttack;
                    turn--;
                }
                else
                {
                    enemyAttack = kick - Player.defence;
                    if (enemyAttack <= 0)
                    {
                        enemyAttack = 1;
                    }
                    Player.health -= enemyAttack;
                    turn--;
                }
            }
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            strikeButton.Visible = true;
        }

        private void defendButton_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                Player.defence += 50;
                turn++;
            }
        }

        private void restButton_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                int restGen = randGen.Next(1, 11);
                if (restGen < 6 && Player.health < 200)
                {
                    Player.health += 55;
                    turn++;
                }
                else
                {
                    turn++;
                }
            }
        }


        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(whiteBrush, 630, 732, player.width, player.height);
            //e.Graphics.FillRectangle(whiteBrush, 630, 732, 15, 10);
            //e.Graphics.FillRectangle(whiteBrush, 630, 787, 15, 10);
            //e.Graphics.FillRectangle(whiteBrush, 630, 841, 15, 10);

        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Enter:
                    enterKeyDown = true;
                    break;
            }

        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Enter:
                    enterKeyDown = false;
                    break;
            }


        }


        #region Attack Buttons
        private void strikeButton_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                player.PlayerTurn(0, "strike");
            }


        }
        private void slashButton_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                player.PlayerTurn(0, "slash");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                player.PlayerTurn(0, "chargedStrike");
            }
        }
        private void iceButton_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                player.PlayerTurn(0, "ice");
            }
        }
        #endregion

    }
}
