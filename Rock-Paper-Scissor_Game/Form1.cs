using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissor_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xFC, 0xF2, 0xF0);
            txtBox_Player.BackColor = Color.FromArgb(0xFC, 0xF2, 0xF0);
            txtBox_Enemy.BackColor = Color.FromArgb(0xFC, 0xF2, 0xF0);
            btn_confirm.BackColor = Color.FromArgb(0xFC, 0xF2, 0xF0);
            btn_rock.BackColor = Color.FromArgb(0xFC, 0xF2, 0xF0);
            btn_paper.BackColor = Color.FromArgb(0xFC, 0xF2, 0xF0);
            btn_scissor.BackColor = Color.FromArgb(0xFC, 0xF2, 0xF0);
        }


        bool selected = false;
        int pick;
        int enemy = 0;

        private void btn_rock_Click(object sender, EventArgs e)
        {
            pick = 1;
            selected = true;
            btn_rock.Size = new System.Drawing.Size(80, 80);
            btn_paper.Size = new System.Drawing.Size(89, 89);
            btn_scissor.Size = new System.Drawing.Size(89, 89);
            pBox_player.Image = Properties.Resources.ROCK;
            txtBox_Player.Text = "ROCK";
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            pick = 2;
            selected = true;
            btn_rock.Size = new System.Drawing.Size(89, 89);
            btn_paper.Size = new System.Drawing.Size(80, 80);
            btn_scissor.Size = new System.Drawing.Size(89, 89);
            pBox_player.Image = Properties.Resources.PAPER;
            txtBox_Player.Text = "PAPER";
        }

        private void btn_scissor_Click(object sender, EventArgs e)
        {
            pick = 3;
            selected = true;
            btn_rock.Size = new System.Drawing.Size(89, 89);
            btn_paper.Size = new System.Drawing.Size(89, 89);
            btn_scissor.Size = new System.Drawing.Size(80, 80);
            pBox_player.Image = Properties.Resources.SCISSOR;
            txtBox_Player.Text = "SCISSOR";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                Random random = new Random();
                enemy = random.Next(1, 4);
                //MessageBox.Show(enemy.ToString());

                switch (enemy)
                {
                    case 1:
                        pBox_enemy.Image = Properties.Resources.ROCK;
                        txtBox_Enemy.Text = "ROCK";
                        break;
                    case 2:
                        pBox_enemy.Image = Properties.Resources.PAPER;
                        txtBox_Enemy.Text = "PAPER";
                        break;
                    case 3:
                        pBox_enemy.Image = Properties.Resources.SCISSOR;
                        txtBox_Enemy.Text = "SCISSOR";
                        break;
                }

                gameCheck();
            }
            else
            {
                MessageBox.Show("Pick first!");
            }
        }

        private void gameCheck()
        {
            if (pick == 1 && enemy == 2)
            {
                MessageBox.Show("Enemy wins!");
            }
            else if (pick == 1 && enemy == 3)
            {
                MessageBox.Show("You wins!");
            }
            else if (pick == 2 && enemy == 1)
            {
                MessageBox.Show("You wins!");
            }
            else if(pick == 2 && enemy == 3)
            {
                MessageBox.Show("Enemy wins!");
            }
            else if (pick == 3 && enemy == 1) 
            {
                MessageBox.Show("Enemy wins!");
            }
            else if (pick == 3 && enemy == 2)
            {
                MessageBox.Show("You wins");
            }
            else if (pick == enemy)
            {
                MessageBox.Show("Its a tie!");
            }
            else
            {
                
            }
        }
    }
}
