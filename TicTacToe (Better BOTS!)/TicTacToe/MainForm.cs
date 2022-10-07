using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class MainForm : Form
	{
		int round,score1,score2,game,time;
		bool x1,x2,x3,x4,x5,x6,x7,x8,x9;
		bool o1,o2,o3,o4,o5,o6,o7,o8,o9;
		bool vsbot, xmove, omove;
		string player1,player2;

        private void button3_Click(object sender, EventArgs e)
        {
			pnlvsbots.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
			pnlvsbots.Hide();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
			Random select = new Random();
			int botMove = select.Next(1, 10);
			if (game % 2 == 0)
			{
				if (round % 2 != 0)
				{
					// Prioritize Winning Moves
					if (o4 && o7 == true || o2 && o3 == true || o5 && o9 == true)
					{
						btn1.PerformClick();
					}
					if (o1 && o3 == true || o5 && o8 == true)
					{
						btn2.PerformClick();
					}
					if (o1 && o2 == true || o7 && o5 == true || o6 && o9 == true)
					{
						btn3.PerformClick();
					}
					if (o1 && o7 == true || o5 && o6 == true)
					{
						btn4.PerformClick();
					}
					if (o1 && o9 == true || o2 && o8 == true || o7 && o3 == true || o4 && o6 == true)
					{
						btn5.PerformClick();
					}
					if (o4 && o5 == true || o3 && o9 == true)
					{
						btn6.PerformClick();
					}
					if (o1 && o4 == true || o5 && o3 == true || o8 && o9 == true)
					{
						btn7.PerformClick();
					}
					if (o7 && o9 == true || o2 && o5 == true)
					{
						btn8.PerformClick();
					}
					if (o1 && o5 == true || o3 && o6 == true || o7 && o8 == true)
					{
						btn9.PerformClick();
					}

					// Defensive Moves
					if (x4 && x7 == true || x2 && x3 == true || x5 && x9 == true)
					{
						btn1.PerformClick();
					}
					if (x1 && x3 == true || x5 && x8 == true)
					{
						btn2.PerformClick();
					}
					if (x1 && x2 == true || x7 && x5 == true || x6 && x9 == true)
					{
						btn3.PerformClick();
					}
					if (x1 && x7 == true || x5 && x6 == true)
					{
						btn4.PerformClick();
					}
					if (x1 && x9 == true || x2 && x8 == true || x7 && x3 == true || x4 && x6 == true)
					{
						btn5.PerformClick();
					}
					if (x4 && x5 == true || x3 && x9 == true)
					{
						btn6.PerformClick();
					}
					if (x1 && x4 == true || x5 && x3 == true || x8 && x9 == true)
					{
						btn7.PerformClick();
					}
					if (x7 && x9 == true || x2 && x5 == true)
					{
						btn8.PerformClick();
					}
					if (x1 && x5 == true || x3 && x6 == true || x7 && x8 == true)
					{
						btn9.PerformClick();
					}

					//Random Moves
					if (botMove == 1)
                    {
						btn1.PerformClick();

					}
					if (botMove == 2)
					{
						btn2.PerformClick();

					}
					if (botMove == 3)
					{
						btn3.PerformClick();

					}
					if (botMove == 4)
					{
						btn4.PerformClick();

					}
					if (botMove == 5)
					{
						btn5.PerformClick();

					}
					if (botMove == 6)
					{
						btn6.PerformClick();

					}
					if (botMove == 7)
					{
						btn7.PerformClick();

					}
					if (botMove == 8)
					{
						btn8.PerformClick();

					}
					if (botMove == 9)
					{
						btn9.PerformClick();

					}
				}
			}
			if (game % 2 != 0)
			{
				if (round % 2 == 0)
				{
					// Prioritize Winning Moves
					if (o4 && o7 == true || o2 && o3 == true || o5 && o9 == true)
					{
						btn1.PerformClick();
					}
					if (o1 && o3 == true || o5 && o8 == true)
					{
						btn2.PerformClick();
					}
					if (o1 && o2 == true || o7 && o5 == true || o6 && o9 == true)
					{
						btn3.PerformClick();
					}
					if (o1 && o7 == true || o5 && o6 == true)
					{
						btn4.PerformClick();
					}
					if (o1 && o9 == true || o2 && o8 == true || o7 && o3 == true || o4 && o6 == true)
					{
						btn5.PerformClick();
					}
					if (o4 && o5 == true || o3 && o9 == true)
					{
						btn6.PerformClick();
					}
					if (o1 && o4 == true || o5 && o3 == true || o8 && o9 == true)
					{
						btn7.PerformClick();
					}
					if (o7 && o9 == true || o2 && o5 == true)
					{
						btn8.PerformClick();
					}
					if (o1 && o5 == true || o3 && o6 == true || o7 && o8 == true)
					{
						btn9.PerformClick();
					}

					// Defensive Moves
					if (x4 && x7 == true || x2 && x3 == true || x5 && x9 == true)
					{
						btn1.PerformClick();
					}
					if (x1 && x3 == true || x5 && x8 == true)
                    {
						btn2.PerformClick();
                    }
					if (x1 && x2 == true || x7 && x5 == true || x6 && x9 == true)
                    {
						btn3.PerformClick();
                    }
					if (x1 && x7 == true || x5 && x6 == true)
                    {
						btn4.PerformClick();
                    }
					if (x1 && x9 == true || x2 && x8 == true || x7 && x3 == true || x4 && x6 == true)
                    {
						btn5.PerformClick();
                    }
					if (x4 && x5 == true || x3 && x9 == true)
                    {
						btn6.PerformClick();
                    }
					if (x1 && x4 == true || x5 && x3 == true || x8 && x9 == true)
                    {
						btn7.PerformClick();
                    }
					if (x7 && x9 == true || x2 && x5 == true)
                    {
						btn8.PerformClick();
                    }
					if (x1 && x5 == true || x3 && x6 == true || x7 && x8 == true)
                    {
						btn9.PerformClick();
                    }

					//Random Moves
					if (botMove == 1)
					{
						btn1.PerformClick();

					}
					if (botMove == 2)
					{
						btn2.PerformClick();

					}
					if (botMove == 3)
					{
						btn3.PerformClick();

					}
					if (botMove == 4)
					{
						btn4.PerformClick();

					}
					if (botMove == 5)
					{
						btn5.PerformClick();

					}
					if (botMove == 6)
					{
						btn6.PerformClick();

					}
					if (botMove == 7)
					{
						btn7.PerformClick();

					}
					if (botMove == 8)
					{
						btn8.PerformClick();

					}
					if (botMove == 9)
					{
						btn9.PerformClick();

					}
					
				}
			}
		}

        private void turn_Tick(object sender, EventArgs e)
        {
			if (game % 2 == 0)
			{
				if (round % 2 == 0)
				{
					xmove = true;
				}
				else
				{
					xmove = false;
				}
			}
			else
			{
				if (round % 2 == 0)
				{
					xmove = false;
				}
				else
				{
					xmove = true;
				}
			}
		}

        private void vSBotBetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			pnlvsbots.Show();
			restartGameToolStripMenuItem.PerformClick();
			vsbot = true;
			player2 = ("BOT");
			timer3.Enabled = true;
        }

        public MainForm()
		{
			InitializeComponent();
			x1=false;x2=false;x3=false;x4=false;x5=false;x6=false;x7=false;x8=false;x9=false;
			o1=false;o2=false;o3=false;o4=false;o5=false;o6=false;o7=false;o9=false;o9=false;
			player1=@"Player 1 (X)";
			player2=@"Player 2 (O)";
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			round=1;score1=0;score2=0;game=1;time=1;
			turn1.Hide();
			turn2.Hide();
			winner.Hide();
			pnlsetname.Hide();
			pnlabtme.Hide();
			waiting.Hide();
			pnlvsbots.Hide();
		}
		void Btn1Click(object sender, EventArgs e)
		{
			if (game % 2 == 0)
			{
				if (round % 2 == 0 && xmove == true)
				{
					btn1.Text = ("X");
					round++;
					btn1.Enabled = false;
					x1 = true;
					if (vsbot == true && round != 10)
                    {
						waiting.Show();
                    }
				}
				if (round % 2 != 0 && xmove == false)
				{
					btn1.Text = ("O");
					round++;
					btn1.Enabled = false;
					o1 = true;
					if (vsbot == true)
                    {
						waiting.Hide();
                    }
				}
			}
			else
			{
				if (round % 2 == 0 && xmove == false)
				{
					btn1.Text = ("O");
					round++;
					btn1.Enabled = false;
					o1 = true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
				if (round % 2 != 0 && xmove == true)
				{
					btn1.Text = ("X");
					round++;
					btn1.Enabled = false;
					x1 = true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
			}
			
		}
		void Btn2Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round % 2 == 0 && xmove == true)
				{
				btn2.Text=("X");
				round++;
				btn2.Enabled=false;
				x2=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
				if (round % 2 != 0 && xmove == false)
				{
				btn2.Text=("O");
				round++;
				btn2.Enabled=false;
				o2=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
			}
			else{
				if (round % 2 == 0 && xmove == false)
				{
				btn2.Text=("O");
				round++;
				btn2.Enabled=false;
				o2=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
				if (round % 2 != 0 && xmove == true)
				{
				btn2.Text=("X");
				round++;
				btn2.Enabled=false;
				x2=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
			}
		}
		void Btn3Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round % 2 == 0 && xmove == true)
				{
				btn3.Text=("X");
				round++;
				btn3.Enabled=false;
				x3=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
				if (round % 2 != 0 && xmove == false)
				{
				btn3.Text=("O");
				round++;
				btn3.Enabled=false;
				o3=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
			}
			else{
				if (round % 2 == 0 && xmove == false)
				{
				btn3.Text=("O");
				round++;
				btn3.Enabled=false;
				o3=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
				if (round % 2 != 0 && xmove == true)
				{
				btn3.Text=("X");
				round++;
				btn3.Enabled=false;
				x3=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
			}
		}
		void Btn4Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round % 2 == 0 && xmove == true)
				{
				btn4.Text=("X");
				round++;
				btn4.Enabled=false;
				x4=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
				if (round % 2 != 0 && xmove == false)
				{
				btn4.Text=("O");
				round++;
				btn4.Enabled=false;
				o4=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
			}
			else{
				if (round % 2 == 0 && xmove == false)
				{
				btn4.Text=("O");
				round++;
				btn4.Enabled=false;
				o4=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
				if (round % 2 != 0 && xmove == true)
				{
				btn4.Text=("X");
				round++;
				btn4.Enabled=false;
				x4=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
			}
		}
		void Btn5Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round % 2 == 0 && xmove == true)
				{
				btn5.Text=("X");
				round++;
				btn5.Enabled=false;
				x5=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
				if (round % 2 != 0 && xmove == false)
				{
				btn5.Text=("O");
				round++;
				btn5.Enabled=false;
				o5=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
			}
			else{
				if (round % 2 == 0 && xmove == false)
				{
				btn5.Text=("O");
				round++;
				btn5.Enabled=false;
				o5=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
				if (round % 2 != 0 && xmove == true)
				{
				btn5.Text=("X");
				round++;
				btn5.Enabled=false;
				x5=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
			}
		}
		void Btn6Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round % 2 == 0 && xmove == true)
				{
				btn6.Text=("X");
				round++;
				btn6.Enabled=false;
				x6=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
				if (round % 2 != 0 && xmove == false)
				{
				btn6.Text=("O");
				round++;
				btn6.Enabled=false;
				o6=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
			}
			else{
				if (round % 2 == 0 && xmove == false)
				{
				btn6.Text=("O");
				round++;
				btn6.Enabled=false;
				o6=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
				if (round % 2 != 0 && xmove == true)
				{
				btn6.Text=("X");
				round++;
				btn6.Enabled=false;
				x6=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
			}
		}
		void Btn7Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round % 2 == 0 && xmove == true)
				{
				btn7.Text=("X");
				round++;
				btn7.Enabled=false;
				x7=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
				if (round % 2 != 0 && xmove == false)
				{
				btn7.Text=("O");
				round++;
				btn7.Enabled=false;
				o7=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
			}
			else{
				if (round % 2 == 0 && xmove == false)
				{
				btn7.Text=("O");
				round++;
				btn7.Enabled=false;
				o7=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
				if (round % 2 != 0 && xmove == true)
				{
				btn7.Text=("X");
				round++;
				btn7.Enabled=false;
				x7=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
			}
		}
		void Btn8Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round % 2 == 0 && xmove == true)
				{
				btn8.Text=("X");
				round++;
				btn8.Enabled=false;
				x8=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
				if (round % 2 != 0 && xmove == false)
				{
				btn8.Text=("O");
				round++;
				btn8.Enabled=false;
				o8=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
			}
			else{
				if (round % 2 == 0 && xmove == false)
				{
				btn8.Text=("O");
				round++;
				btn8.Enabled=false;
				o8=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
				if (round % 2 != 0 && xmove == true)
				{
				btn8.Text=("X");
				round++;
				btn8.Enabled=false;
				x8=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
			}
		}
		void Btn9Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round % 2 == 0 && xmove == true)
				{
				btn9.Text=("X");
				round++;
				btn9.Enabled=false;
				x9=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
				if (round % 2 != 0 && xmove == false)
				{
				btn9.Text=("O");
				round++;
				btn9.Enabled=false;
				o9=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
			}
			else{
				if (round % 2 == 0 && xmove == false)
				{
				btn9.Text=("O");
				round++;
				btn9.Enabled=false;
				o9=true;
					if (vsbot == true)
					{
						waiting.Hide();
					}
				}
				if (round % 2 != 0 && xmove == true)
				{
				btn9.Text=("X");
				round++;
				btn9.Enabled=false;
				x9=true;
					if (vsbot == true && round != 10)
					{
						waiting.Show();
					}
				}
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if (vsbot == true && game % 2 == 0 && round == 1)
            {
				waiting.Show();
            }
			if (vsbot==false && player2 == "BOT")
            {
				player2 = "Player 2: (O)";
            }
			p1nme.Text=(player1);
			p2nme.Text=(player2);
			scr1.Text=Convert.ToString(score1);
			scr2.Text=Convert.ToString(score2);
			if (game%2==0) {
				if (round%2==0) {
				turn2.Hide();
				turn1.Show();
			}
			else{
				turn1.Hide();
				turn2.Show();
			}
			}
			else{
				
				if (round%2==0) {
				turn1.Hide();
				turn2.Show();
			}
			else{
				turn2.Hide();
				turn1.Show();
			}
			}
			label6.Text=("Turn "+round);
				
			if (x1==true && x2==true&& x3==true || x1==true && x4==true&& x7==true || x1==true && x5==true&& x9==true || x7==true && x8==true&& x9==true || x3==true && x6==true&& x9==true || x2==true && x5==true && x8==true || x3==true && x5==true && x7==true || x4==true && x5==true && x6==true) {
				waiting.Hide();
				timer1.Enabled=false;
				timer2.Enabled=false;
				winner.Show();
				lblwin.Text=(player1+" WINS!");
				score1++;
				time=1;
				scr1.Text=Convert.ToString(score1);
				btn1.Enabled=false;btn2.Enabled=false;btn3.Enabled=false;btn4.Enabled=false;btn5.Enabled=false;btn6.Enabled=false;btn7.Enabled=false;btn8.Enabled=false;btn9.Enabled=false;
				game++;
				lblRound.Text=Convert.ToString(time);
				round=1;
				
			}
			if (o1==true && o2==true&& o3==true || o1==true && o4==true&& o7==true || o1==true && o5==true&& o9==true || o7==true && o8==true&& o9==true || o3==true && o6==true&& o9==true || o8==true && o5==true && o2==true || o3==true && o5==true && o7==true || o4==true && o5==true && o6==true) {
				waiting.Hide();
				timer1.Enabled=false;
				timer2.Enabled=false;
				winner.Show();
				lblwin.Text=(player2+" WINS!");
				score2++;
				time=1;
				scr2.Text=Convert.ToString(score2);
				btn1.Enabled=false;btn2.Enabled=false;btn3.Enabled=false;btn4.Enabled=false;btn5.Enabled=false;btn6.Enabled=false;btn7.Enabled=false;btn8.Enabled=false;btn9.Enabled=false;
				game++;
				lblRound.Text=Convert.ToString(time);
				round=1;
			}
			if (round==10) {
				waiting.Hide();
				timer1.Enabled=false;
				timer2.Enabled=false;
				winner.Show();
				lblwin.Text=(@"DRAW!");
				btn1.Enabled=false;btn2.Enabled=false;btn3.Enabled=false;btn4.Enabled=false;btn5.Enabled=false;btn6.Enabled=false;btn7.Enabled=false;btn8.Enabled=false;btn9.Enabled=false;
				game++;
				time=1;
				lblRound.Text=Convert.ToString(time);
				round=1;
			}
		}
		void RestartGameToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (vsbot == true)
            {
				vsbot = false;
				timer3.Enabled = false;
            }
				timer1.Enabled=false;
				timer2.Enabled=false;
				winner.Hide();
				x1=false;x2=false;x3=false;x4=false;x5=false;x6=false;x7=false;x8=false;x9=false;
				o1=false;o2=false;o3=false;o4=false;o5=false;o6=false;o7=false;o8=false;o9=false;
				btn1.Text=("");btn2.Text=("");btn3.Text=("");btn4.Text=("");btn5.Text=("");btn6.Text=("");btn7.Text=("");btn8.Text=("");btn9.Text=("");
				btn1.Enabled=true;btn2.Enabled=true;btn3.Enabled=true;btn4.Enabled=true;btn5.Enabled=true;btn6.Enabled=true;btn7.Enabled=true;btn8.Enabled=true;btn9.Enabled=true;
				score1=0;score2=0;
				game=1;
				round=1;
				time=1;
				lblRound.Text=Convert.ToString(time);
				timer1.Enabled=true;
				timer2.Enabled=true;
		}
		void WindoneClick(object sender, EventArgs e)
		{
			x1=false;x2=false;x3=false;x4=false;x5=false;x6=false;x7=false;x8=false;x9=false;
			o1=false;o2=false;o3=false;o4=false;o5=false;o6=false;o7=false;o8=false;o9=false;
			btn1.Text=("");btn2.Text=("");btn3.Text=("");btn4.Text=("");btn5.Text=("");btn6.Text=("");btn7.Text=("");btn8.Text=("");btn9.Text=("");
			btn1.Enabled=true;btn2.Enabled=true;btn3.Enabled=true;btn4.Enabled=true;btn5.Enabled=true;btn6.Enabled=true;btn7.Enabled=true;btn8.Enabled=true;btn9.Enabled=true;
			winner.Hide();
			timer1.Enabled=true;
			timer2.Enabled=true;
		}
		void AboutTheGameToolStripMenuItemClick(object sender, EventArgs e)
		{
			pnlabtme.Show();
		}
		void SetNameToolStripMenuItemClick(object sender, EventArgs e)
		{
			pnlsetname.Show();
		}
		void BtnsetnameClick(object sender, EventArgs e)
		{
			player1=txbxp1.Text;
			player2=txbxp2.Text;
			if (txbxp1.Text=="") {
				player1=@"Player 1: (X)";
			}
			if (txbxp2.Text=="") {
				player2=@"Player 2: (O)";
			}
		}
		void XsetnameClick(object sender, EventArgs e)
		{
			pnlsetname.Hide();
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			lblRound.Text=Convert.ToString(time++);
		}
		void Button1Click(object sender, EventArgs e)
		{
			pnlabtme.Hide();
		}
	}
}
