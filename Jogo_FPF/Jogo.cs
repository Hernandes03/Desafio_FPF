using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_FPF
{
    public partial class Jogo : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHeath = 100;
        int monsterHeath = 100;
        int speed = 10;
        int ammo = 10;
        int score;
        int monsterSpeed = 3;
        Random randNum = new Random();

        List<PictureBox> monsterList = new List<PictureBox>();


        public Jogo()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Jogo_Load(object sender, EventArgs e)
        {

        }

        private void Evento_Pincipal_do_Temporizador(object sender, EventArgs e)
        {

            if (playerHeath > 1)
            {
                pgb_VPlayer.Value = playerHeath;
            }
            else
            {
                gameOver = true;
                pb_Player.Image = Properties.Resources.dead;
                T_PlayerTimer.Stop();

            }

            lb_Munição.Text = "Ammo: " + ammo;
            lb_Score.Text = "Kills: " + score;

            if (goLeft == true && pb_Player.Left > 200)
            {
                pb_Player.Left -= speed;
            }
            if (goRight == true && pb_Player.Left + pb_Player.Width < this.ClientSize.Width)
            {
                pb_Player.Left += speed;
            }
            if (goUp == true && pb_Player.Top > 0)
            {
                pb_Player.Top -= speed;
            }
            if (goDown == true && pb_Player.Top + pb_Player.Height < this.ClientSize.Height)
            {
                pb_Player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (pb_Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "monster")
                {

                    if (pb_Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHeath -= 1;
                    }


                    if (x.Left > pb_Player.Left)
                    {
                        x.Left -= monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < pb_Player.Left)
                    {
                        x.Left += monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > pb_Player.Top)
                    {
                        x.Top -= monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < pb_Player.Top)
                    {
                        x.Top += monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "monster")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            monsterList.Remove(((PictureBox)x));
                            MakeMonster();
                        }
                    }
                }
            }
        }

        private void KeyIsDonw(object sender, KeyEventArgs e)
        {
            
            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                pb_Player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                pb_Player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                pb_Player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                pb_Player.Image = Properties.Resources.down;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = pb_Player.Left + (pb_Player.Width / 2);
            shootBullet.bulletTop = pb_Player.Top + (pb_Player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeMonster()
        {
            PictureBox monster = new PictureBox();
            monster.Tag = "monster";
            monster.Image = Properties.Resources.zdown;
            monster.Left = randNum.Next(0, 1200);
            monster.Top = randNum.Next(0, 800);
            monster.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(monster);
            pb_Player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(200, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(10, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            pb_Player.BringToFront();
        }

        private void RestartGame()
        {
            pb_Player.Image = Properties.Resources.up;

            foreach (PictureBox i in monsterList)
            {
                this.Controls.Remove(i);
            }

            monsterList.Clear();

            for (int i = 0; i < 1; i++)
            {
                MakeMonster();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHeath = 100;
            score = 0;
            ammo = 10;

            T_PlayerTimer.Start();
        }
    }
}
