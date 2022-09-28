/*
 * Created by SharpDevelop.
 * User: joedm
 * Date: 28/09/2022
 * Time: 2:09 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TicTacToe
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private practiceLogin.roundedPanel roundedPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private practiceLogin.roundedPanel roundedPanel2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private practiceLogin.roundedPanel roundedPanel3;
		private System.Windows.Forms.Label lblRound;
		private System.Windows.Forms.Timer timer1;
		private practiceLogin.roundedPanel turn2;
		private System.Windows.Forms.Label lblturn2;
		private practiceLogin.roundedPanel turn1;
		private System.Windows.Forms.Label lblturn;
		private System.Windows.Forms.Label scr2;
		private System.Windows.Forms.Label scr1;
		private practiceLogin.roundedPanel winner;
		private System.Windows.Forms.Label lblwin;
		private System.Windows.Forms.Button windone;
		private System.Windows.Forms.ToolStripMenuItem aboutTheGameToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutTheGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.roundedPanel1 = new practiceLogin.roundedPanel();
			this.scr2 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.roundedPanel2 = new practiceLogin.roundedPanel();
			this.scr1 = new System.Windows.Forms.Label();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.roundedPanel3 = new practiceLogin.roundedPanel();
			this.lblRound = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.turn2 = new practiceLogin.roundedPanel();
			this.lblturn2 = new System.Windows.Forms.Label();
			this.turn1 = new practiceLogin.roundedPanel();
			this.lblturn = new System.Windows.Forms.Label();
			this.winner = new practiceLogin.roundedPanel();
			this.windone = new System.Windows.Forms.Button();
			this.lblwin = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.roundedPanel1.SuspendLayout();
			this.roundedPanel2.SuspendLayout();
			this.roundedPanel3.SuspendLayout();
			this.turn2.SuspendLayout();
			this.turn1.SuspendLayout();
			this.winner.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 108);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(414, 376);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.restartGameToolStripMenuItem,
			this.aboutTheGameToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 487);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(438, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// restartGameToolStripMenuItem
			// 
			this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
			this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.restartGameToolStripMenuItem.Text = "Restart Game";
			this.restartGameToolStripMenuItem.Click += new System.EventHandler(this.RestartGameToolStripMenuItemClick);
			// 
			// aboutTheGameToolStripMenuItem
			// 
			this.aboutTheGameToolStripMenuItem.Name = "aboutTheGameToolStripMenuItem";
			this.aboutTheGameToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
			this.aboutTheGameToolStripMenuItem.Text = "About The Game";
			this.aboutTheGameToolStripMenuItem.Click += new System.EventHandler(this.AboutTheGameToolStripMenuItemClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(330, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Player1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedPanel1
			// 
			this.roundedPanel1.BackColor = System.Drawing.Color.Silver;
			this.roundedPanel1.BorderColor = System.Drawing.Color.White;
			this.roundedPanel1.Controls.Add(this.scr2);
			this.roundedPanel1.Edge = 20;
			this.roundedPanel1.Location = new System.Drawing.Point(304, 65);
			this.roundedPanel1.Name = "roundedPanel1";
			this.roundedPanel1.Size = new System.Drawing.Size(122, 28);
			this.roundedPanel1.TabIndex = 3;
			// 
			// scr2
			// 
			this.scr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scr2.Location = new System.Drawing.Point(3, 0);
			this.scr2.Name = "scr2";
			this.scr2.Size = new System.Drawing.Size(116, 28);
			this.scr2.TabIndex = 0;
			this.scr2.Text = "0";
			this.scr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(319, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Player 2 (O)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Player1";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Player 1 (X)";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedPanel2
			// 
			this.roundedPanel2.BackColor = System.Drawing.Color.Silver;
			this.roundedPanel2.BorderColor = System.Drawing.Color.White;
			this.roundedPanel2.Controls.Add(this.scr1);
			this.roundedPanel2.Edge = 20;
			this.roundedPanel2.Location = new System.Drawing.Point(12, 65);
			this.roundedPanel2.Name = "roundedPanel2";
			this.roundedPanel2.Size = new System.Drawing.Size(122, 28);
			this.roundedPanel2.TabIndex = 3;
			// 
			// scr1
			// 
			this.scr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scr1.Location = new System.Drawing.Point(3, 0);
			this.scr1.Name = "scr1";
			this.scr1.Size = new System.Drawing.Size(116, 28);
			this.scr1.TabIndex = 0;
			this.scr1.Text = "0";
			this.scr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.Color.Transparent;
			this.btn1.FlatAppearance.BorderSize = 0;
			this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(64, 139);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(97, 96);
			this.btn1.TabIndex = 0;
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.Color.Transparent;
			this.btn2.FlatAppearance.BorderSize = 0;
			this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.Location = new System.Drawing.Point(169, 139);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(97, 96);
			this.btn2.TabIndex = 0;
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.Color.Transparent;
			this.btn3.FlatAppearance.BorderSize = 0;
			this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.Location = new System.Drawing.Point(278, 139);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(97, 96);
			this.btn3.TabIndex = 0;
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.Btn3Click);
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.Color.Transparent;
			this.btn4.FlatAppearance.BorderSize = 0;
			this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.Location = new System.Drawing.Point(63, 245);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(97, 96);
			this.btn4.TabIndex = 0;
			this.btn4.UseVisualStyleBackColor = false;
			this.btn4.Click += new System.EventHandler(this.Btn4Click);
			// 
			// btn5
			// 
			this.btn5.BackColor = System.Drawing.Color.Transparent;
			this.btn5.FlatAppearance.BorderSize = 0;
			this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.Location = new System.Drawing.Point(168, 245);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(97, 96);
			this.btn5.TabIndex = 0;
			this.btn5.UseVisualStyleBackColor = false;
			this.btn5.Click += new System.EventHandler(this.Btn5Click);
			// 
			// btn6
			// 
			this.btn6.BackColor = System.Drawing.Color.Transparent;
			this.btn6.FlatAppearance.BorderSize = 0;
			this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.Location = new System.Drawing.Point(277, 245);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(97, 96);
			this.btn6.TabIndex = 0;
			this.btn6.UseVisualStyleBackColor = false;
			this.btn6.Click += new System.EventHandler(this.Btn6Click);
			// 
			// btn7
			// 
			this.btn7.BackColor = System.Drawing.Color.Transparent;
			this.btn7.FlatAppearance.BorderSize = 0;
			this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn7.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.Location = new System.Drawing.Point(63, 350);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(97, 96);
			this.btn7.TabIndex = 0;
			this.btn7.UseVisualStyleBackColor = false;
			this.btn7.Click += new System.EventHandler(this.Btn7Click);
			// 
			// btn8
			// 
			this.btn8.BackColor = System.Drawing.Color.Transparent;
			this.btn8.FlatAppearance.BorderSize = 0;
			this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn8.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.Location = new System.Drawing.Point(168, 350);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(97, 96);
			this.btn8.TabIndex = 0;
			this.btn8.UseVisualStyleBackColor = false;
			this.btn8.Click += new System.EventHandler(this.Btn8Click);
			// 
			// btn9
			// 
			this.btn9.BackColor = System.Drawing.Color.Transparent;
			this.btn9.FlatAppearance.BorderSize = 0;
			this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn9.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.Location = new System.Drawing.Point(277, 350);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(97, 96);
			this.btn9.TabIndex = 0;
			this.btn9.UseVisualStyleBackColor = false;
			this.btn9.Click += new System.EventHandler(this.Btn9Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(183, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Player1";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(183, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Round";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedPanel3
			// 
			this.roundedPanel3.BackColor = System.Drawing.Color.Silver;
			this.roundedPanel3.BorderColor = System.Drawing.Color.White;
			this.roundedPanel3.Controls.Add(this.lblRound);
			this.roundedPanel3.Edge = 20;
			this.roundedPanel3.Location = new System.Drawing.Point(157, 35);
			this.roundedPanel3.Name = "roundedPanel3";
			this.roundedPanel3.Size = new System.Drawing.Size(122, 67);
			this.roundedPanel3.TabIndex = 3;
			// 
			// lblRound
			// 
			this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRound.Location = new System.Drawing.Point(0, 0);
			this.lblRound.Name = "lblRound";
			this.lblRound.Size = new System.Drawing.Size(122, 67);
			this.lblRound.TabIndex = 0;
			this.lblRound.Text = "1";
			this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// turn2
			// 
			this.turn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
			this.turn2.BorderColor = System.Drawing.Color.White;
			this.turn2.Controls.Add(this.lblturn2);
			this.turn2.Edge = 20;
			this.turn2.Location = new System.Drawing.Point(330, 12);
			this.turn2.Name = "turn2";
			this.turn2.Size = new System.Drawing.Size(76, 28);
			this.turn2.TabIndex = 3;
			// 
			// lblturn2
			// 
			this.lblturn2.BackColor = System.Drawing.Color.Transparent;
			this.lblturn2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblturn2.ForeColor = System.Drawing.Color.White;
			this.lblturn2.Location = new System.Drawing.Point(0, 0);
			this.lblturn2.Name = "lblturn2";
			this.lblturn2.Size = new System.Drawing.Size(76, 28);
			this.lblturn2.TabIndex = 2;
			this.lblturn2.Text = "Your Turn";
			this.lblturn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// turn1
			// 
			this.turn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
			this.turn1.BorderColor = System.Drawing.Color.White;
			this.turn1.Controls.Add(this.lblturn);
			this.turn1.Edge = 20;
			this.turn1.Location = new System.Drawing.Point(38, 12);
			this.turn1.Name = "turn1";
			this.turn1.Size = new System.Drawing.Size(76, 28);
			this.turn1.TabIndex = 3;
			// 
			// lblturn
			// 
			this.lblturn.BackColor = System.Drawing.Color.Transparent;
			this.lblturn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblturn.ForeColor = System.Drawing.Color.White;
			this.lblturn.Location = new System.Drawing.Point(0, 0);
			this.lblturn.Name = "lblturn";
			this.lblturn.Size = new System.Drawing.Size(76, 28);
			this.lblturn.TabIndex = 2;
			this.lblturn.Text = "Your Turn";
			this.lblturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// winner
			// 
			this.winner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
			this.winner.BorderColor = System.Drawing.Color.White;
			this.winner.Controls.Add(this.windone);
			this.winner.Controls.Add(this.lblwin);
			this.winner.Edge = 20;
			this.winner.Location = new System.Drawing.Point(12, 9);
			this.winner.Name = "winner";
			this.winner.Size = new System.Drawing.Size(414, 93);
			this.winner.TabIndex = 4;
			// 
			// windone
			// 
			this.windone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
			this.windone.FlatAppearance.BorderSize = 0;
			this.windone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.windone.ForeColor = System.Drawing.SystemColors.Control;
			this.windone.Location = new System.Drawing.Point(295, 72);
			this.windone.Name = "windone";
			this.windone.Size = new System.Drawing.Size(121, 21);
			this.windone.TabIndex = 5;
			this.windone.TabStop = false;
			this.windone.Text = "Next Game!";
			this.windone.UseVisualStyleBackColor = false;
			this.windone.Click += new System.EventHandler(this.WindoneClick);
			// 
			// lblwin
			// 
			this.lblwin.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblwin.ForeColor = System.Drawing.Color.White;
			this.lblwin.Location = new System.Drawing.Point(3, 3);
			this.lblwin.Name = "lblwin";
			this.lblwin.Size = new System.Drawing.Size(408, 90);
			this.lblwin.TabIndex = 0;
			this.lblwin.Text = "X WINS!";
			this.lblwin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(438, 511);
			this.Controls.Add(this.winner);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.roundedPanel3);
			this.Controls.Add(this.turn1);
			this.Controls.Add(this.turn2);
			this.Controls.Add(this.roundedPanel2);
			this.Controls.Add(this.roundedPanel1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TicTacToe";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.roundedPanel1.ResumeLayout(false);
			this.roundedPanel2.ResumeLayout(false);
			this.roundedPanel3.ResumeLayout(false);
			this.turn2.ResumeLayout(false);
			this.turn1.ResumeLayout(false);
			this.winner.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
