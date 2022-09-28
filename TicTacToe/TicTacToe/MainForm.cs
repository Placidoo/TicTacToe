using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class MainForm : Form
	{
		int round,score1,score2,game;
		bool x1,x2,x3,x4,x5,x6,x7,x8,x9;
		bool o1,o2,o3,o4,o5,o6,o7,o8,o9;
		public MainForm()
		{
			InitializeComponent();
			x1=false;x2=false;x3=false;x4=false;x5=false;x6=false;x7=false;x8=false;x9=false;
			o1=false;o2=false;o3=false;o4=false;o5=false;o6=false;o7=false;o9=false;o9=false;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			round=1;score1=0;score2=0;game=1;
			turn1.Hide();
			turn2.Hide();
			winner.Hide();
		}
		void Btn1Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round%2==0) {
				btn1.Text=("X");
				round++;
				btn1.Enabled=false;
				x1=true;
			}
			else{
				btn1.Text=("O");
				round++;
				btn1.Enabled=false;
				o1=true;
			}
			}
			else{
				if (round%2==0) {
				btn1.Text=("O");
				round++;
				btn1.Enabled=false;
				o1=true;
			}
			else{
				btn1.Text=("X");
				round++;
				btn1.Enabled=false;
				x1=true;
			}
			}
			
		}
		void Btn2Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round%2==0) {
				btn2.Text=("X");
				round++;
				btn2.Enabled=false;
				x2=true;
			}
			else{
				btn2.Text=("O");
				round++;
				btn2.Enabled=false;
				o2=true;
			}
			}
			else{
				if (round%2==0) {
				btn2.Text=("O");
				round++;
				btn2.Enabled=false;
				o2=true;
			}
			else{
				btn2.Text=("X");
				round++;
				btn2.Enabled=false;
				x2=true;
			}
			}
		}
		void Btn3Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round%2==0) {
				btn3.Text=("X");
				round++;
				btn3.Enabled=false;
				x3=true;
			}
			else{
				btn3.Text=("O");
				round++;
				btn3.Enabled=false;
				o3=true;
			}
			}
			else{
				if (round%2==0) {
				btn3.Text=("O");
				round++;
				btn3.Enabled=false;
				o3=true;
			}
			else{
				btn3.Text=("X");
				round++;
				btn3.Enabled=false;
				x3=true;
			}
			}
		}
		void Btn4Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round%2==0) {
				btn4.Text=("X");
				round++;
				btn4.Enabled=false;
				x4=true;
			}
			else{
				btn4.Text=("O");
				round++;
				btn4.Enabled=false;
				o4=true;
			}
			}
			else{
				if (round%2==0) {
				btn4.Text=("O");
				round++;
				btn4.Enabled=false;
				o4=true;
			}
			else{
				btn4.Text=("X");
				round++;
				btn4.Enabled=false;
				x4=true;
			}
			}
		}
		void Btn5Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round%2==0) {
				btn5.Text=("X");
				round++;
				btn5.Enabled=false;
				x5=true;
			}
			else{
				btn5.Text=("O");
				round++;
				btn5.Enabled=false;
				o5=true;
			}
			}
			else{
				if (round%2==0) {
				btn5.Text=("O");
				round++;
				btn5.Enabled=false;
				o5=true;
			}
			else{
				btn5.Text=("X");
				round++;
				btn5.Enabled=false;
				x5=true;
			}
			}
		}
		void Btn6Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round%2==0) {
				btn6.Text=("X");
				round++;
				btn6.Enabled=false;
				x6=true;
			}
			else{
				btn6.Text=("O");
				round++;
				btn6.Enabled=false;
				o6=true;
			}
			}
			else{
				if (round%2==0) {
				btn6.Text=("O");
				round++;
				btn6.Enabled=false;
				o6=true;
			}
			else{
				btn6.Text=("X");
				round++;
				btn6.Enabled=false;
				x6=true;
			}
			}
		}
		void Btn7Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round%2==0) {
				btn7.Text=("X");
				round++;
				btn7.Enabled=false;
				x7=true;
			}
			else{
				btn7.Text=("O");
				round++;
				btn7.Enabled=false;
				o7=true;
			}
			}
			else{
				if (round%2==0) {
				btn7.Text=("O");
				round++;
				btn7.Enabled=false;
				o7=true;
			}
			else{
				btn7.Text=("X");
				round++;
				btn7.Enabled=false;
				x7=true;
			}
			}
		}
		void Btn8Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round%2==0) {
				btn8.Text=("X");
				round++;
				btn8.Enabled=false;
				x8=true;
			}
			else{
				btn8.Text=("O");
				round++;
				btn8.Enabled=false;
				o8=true;
			}
			}
			else{
				if (round%2==0) {
				btn8.Text=("O");
				round++;
				btn8.Enabled=false;
				o8=true;
			}
			else{
				btn8.Text=("X");
				round++;
				btn8.Enabled=false;
				x8=true;
			}
			}
		}
		void Btn9Click(object sender, EventArgs e)
		{
			if (game%2==0) {
				if (round%2==0) {
				btn9.Text=("X");
				round++;
				btn9.Enabled=false;
				x9=true;
			}
			else{
				btn9.Text=("O");
				round++;
				btn9.Enabled=false;
				o9=true;
			}
			}
			else{
				if (round%2==0) {
				btn9.Text=("O");
				round++;
				btn9.Enabled=false;
				o9=true;
			}
			else{
				btn9.Text=("X");
				round++;
				btn9.Enabled=false;
				x9=true;
			}
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
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
				lblRound.Text=Convert.ToString(round);
			if (x1==true && x2==true&& x3==true || x1==true && x4==true&& x7==true || x1==true && x5==true&& x9==true || x7==true && x8==true&& x9==true || x3==true && x6==true&& x9==true || x2==true && x5==true && x8==true || x3==true && x5==true && x7==true || x4==true && x5==true && x6==true) {
				timer1.Enabled=false;
				winner.Show();
				lblwin.Text=(@"Player 1 (X) Wins!");
				score1++;
				scr1.Text=Convert.ToString(score1);
				btn1.Enabled=false;btn2.Enabled=false;btn3.Enabled=false;btn4.Enabled=false;btn5.Enabled=false;btn6.Enabled=false;btn7.Enabled=false;btn8.Enabled=false;btn9.Enabled=false;
				game++;
				round=1;
				
			}
			if (o1==true && o2==true&& o3==true || o1==true && o4==true&& o7==true || o1==true && o5==true&& o9==true || o7==true && o8==true&& o9==true || o3==true && o6==true&& o9==true || o8==true && o5==true && o2==true || o3==true && o5==true && o7==true || o4==true && o5==true && o6==true) {
				timer1.Enabled=false;
				winner.Show();
				lblwin.Text=(@"PLAYER 2 (O) WINS!");
				score2++;
				scr2.Text=Convert.ToString(score2);
				btn1.Enabled=false;btn2.Enabled=false;btn3.Enabled=false;btn4.Enabled=false;btn5.Enabled=false;btn6.Enabled=false;btn7.Enabled=false;btn8.Enabled=false;btn9.Enabled=false;
				game++;
				round=1;
			}
			if (round==10) {
				timer1.Enabled=false;
				winner.Show();
				lblwin.Text=(@"DRAW!");
				btn1.Enabled=false;btn2.Enabled=false;btn3.Enabled=false;btn4.Enabled=false;btn5.Enabled=false;btn6.Enabled=false;btn7.Enabled=false;btn8.Enabled=false;btn9.Enabled=false;
				game++;
				round=1;
			}
		}
		void RestartGameToolStripMenuItemClick(object sender, EventArgs e)
		{
				timer1.Enabled=false;
				winner.Hide();
				btn1.Text=("");btn2.Text=("");btn3.Text=("");btn4.Text=("");btn5.Text=("");btn6.Text=("");btn7.Text=("");btn8.Text=("");btn9.Text=("");
				btn1.Enabled=true;btn2.Enabled=true;btn3.Enabled=true;btn4.Enabled=true;btn5.Enabled=true;btn6.Enabled=true;btn7.Enabled=true;btn8.Enabled=true;btn9.Enabled=true;
				score1=0;score2=0;
				game=1;
				round=1;
				timer1.Enabled=true;
		}
		void WindoneClick(object sender, EventArgs e)
		{
			x1=false;x2=false;x3=false;x4=false;x5=false;x6=false;x7=false;x8=false;x9=false;
			o1=false;o2=false;o3=false;o4=false;o5=false;o6=false;o7=false;o9=false;o9=false;
			btn1.Text=("");btn2.Text=("");btn3.Text=("");btn4.Text=("");btn5.Text=("");btn6.Text=("");btn7.Text=("");btn8.Text=("");btn9.Text=("");
			btn1.Enabled=true;btn2.Enabled=true;btn3.Enabled=true;btn4.Enabled=true;btn5.Enabled=true;btn6.Enabled=true;btn7.Enabled=true;btn8.Enabled=true;btn9.Enabled=true;
			winner.Hide();
			timer1.Enabled=true;
		}
		void AboutTheGameToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("C# Tic-Tac-Toe\nMade by Joed Michael");
		}
			
	}
}
