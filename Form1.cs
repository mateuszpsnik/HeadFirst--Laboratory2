using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirst__Laboratory2
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(117, 86, 630, 233));
            game.NewLevel(random);
            UpdateCharacters();
        }

        public void UpdateCharacters()
        {
            //player
            Player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            Player.Visible = true;


            //enemies
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                else
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (showBat)
            {
                bat.Visible = true;
            }
            else
            {
                bat.Visible = false;
                batHitPoints.Text = "0";
            }
            if (showGhost)
            {
                ghost.Visible = true;
            }
            else
            {
                ghost.Visible = false;
                ghostHitPoints.Text = "0";
            }
            if (showGhoul)
            {
                ghoul.Visible = true;
            }
            else
            {
                ghoul.Visible = false;
                ghoulHitPoints.Text = "0";
            }


            //weapons
            sword.Visible = false;
        }

        private void Sword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                swordInventory.BorderStyle = BorderStyle.FixedSingle;
                redPotionInventory.BorderStyle = BorderStyle.None;
                maceInventory.BorderStyle = BorderStyle.None;
                bluePotionInventory.BorderStyle = BorderStyle.None;
                bowInventory.BorderStyle = BorderStyle.None;

                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Text = "↑";
            }   
        }

        private void RedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red potion"))
            {
                game.Equip("Red potion");
                swordInventory.BorderStyle = BorderStyle.None;
                redPotionInventory.BorderStyle = BorderStyle.FixedSingle;
                maceInventory.BorderStyle = BorderStyle.None;
                bluePotionInventory.BorderStyle = BorderStyle.None;
                bowInventory.BorderStyle = BorderStyle.None;

                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Text = "D";
            }
        }

        private void Mace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                swordInventory.BorderStyle = BorderStyle.None;
                redPotionInventory.BorderStyle = BorderStyle.None;
                maceInventory.BorderStyle = BorderStyle.FixedSingle;
                bluePotionInventory.BorderStyle = BorderStyle.None;
                bowInventory.BorderStyle = BorderStyle.None;

                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Text = "↑";
            }
        }

        private void BluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue potion"))
            {
                game.Equip("Blue potion");
                swordInventory.BorderStyle = BorderStyle.None;
                redPotionInventory.BorderStyle = BorderStyle.None;
                maceInventory.BorderStyle = BorderStyle.None;
                bluePotionInventory.BorderStyle = BorderStyle.FixedSingle;
                bowInventory.BorderStyle = BorderStyle.None;

                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Text = "D";
            }
        }

        private void Bow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                swordInventory.BorderStyle = BorderStyle.None;
                redPotionInventory.BorderStyle = BorderStyle.None;
                maceInventory.BorderStyle = BorderStyle.None;
                bluePotionInventory.BorderStyle = BorderStyle.None;
                bowInventory.BorderStyle = BorderStyle.FixedSingle;

                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Text = "↑";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }
    }
}
