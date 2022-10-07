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
		private System.Windows.Forms.Label p2nme;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label p1nme;
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
		private practiceLogin.roundedPanel pnlsetname;
		private System.Windows.Forms.Label dsgnpnl;
		private System.Windows.Forms.Label lblSetName;
		private System.Windows.Forms.Label lblp2;
		private System.Windows.Forms.Label lblp1;
		private System.Windows.Forms.TextBox txbxp2;
		private System.Windows.Forms.TextBox txbxp1;
		private practiceLogin.roundedPanel roundedPanel4;
		private System.Windows.Forms.Button btnsetname;
		private System.Windows.Forms.ToolStripMenuItem setNameToolStripMenuItem;
		private System.Windows.Forms.Button Xsetname;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label dsgnprps;
		private practiceLogin.roundedPanel pnlabtme;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label8;
		
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
            this.setNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vSBotBetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.p2nme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1nme = new System.Windows.Forms.Label();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.turn = new System.Windows.Forms.Timer(this.components);
            this.pnlvsbots = new practiceLogin.roundedPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlabtme = new practiceLogin.roundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.winner = new practiceLogin.roundedPanel();
            this.windone = new System.Windows.Forms.Button();
            this.lblwin = new System.Windows.Forms.Label();
            this.pnlsetname = new practiceLogin.roundedPanel();
            this.Xsetname = new System.Windows.Forms.Button();
            this.roundedPanel4 = new practiceLogin.roundedPanel();
            this.btnsetname = new System.Windows.Forms.Button();
            this.txbxp2 = new System.Windows.Forms.TextBox();
            this.txbxp1 = new System.Windows.Forms.TextBox();
            this.lblp2 = new System.Windows.Forms.Label();
            this.lblp1 = new System.Windows.Forms.Label();
            this.lblSetName = new System.Windows.Forms.Label();
            this.dsgnpnl = new System.Windows.Forms.Label();
            this.roundedPanel3 = new practiceLogin.roundedPanel();
            this.dsgnprps = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.turn1 = new practiceLogin.roundedPanel();
            this.lblturn = new System.Windows.Forms.Label();
            this.turn2 = new practiceLogin.roundedPanel();
            this.lblturn2 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new practiceLogin.roundedPanel();
            this.scr1 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new practiceLogin.roundedPanel();
            this.scr2 = new System.Windows.Forms.Label();
            this.waiting = new practiceLogin.roundedPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlvsbots.SuspendLayout();
            this.pnlabtme.SuspendLayout();
            this.winner.SuspendLayout();
            this.pnlsetname.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.turn1.SuspendLayout();
            this.turn2.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.waiting.SuspendLayout();
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
            this.setNameToolStripMenuItem,
            this.vSBotBetaToolStripMenuItem,
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
            // setNameToolStripMenuItem
            // 
            this.setNameToolStripMenuItem.Name = "setNameToolStripMenuItem";
            this.setNameToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.setNameToolStripMenuItem.Text = "Set Name";
            this.setNameToolStripMenuItem.Click += new System.EventHandler(this.SetNameToolStripMenuItemClick);
            // 
            // vSBotBetaToolStripMenuItem
            // 
            this.vSBotBetaToolStripMenuItem.Name = "vSBotBetaToolStripMenuItem";
            this.vSBotBetaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.vSBotBetaToolStripMenuItem.Text = "VS Bot (Beta)";
            this.vSBotBetaToolStripMenuItem.Click += new System.EventHandler(this.vSBotBetaToolStripMenuItem_Click);
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
            // p2nme
            // 
            this.p2nme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2nme.Location = new System.Drawing.Point(304, 39);
            this.p2nme.Name = "p2nme";
            this.p2nme.Size = new System.Drawing.Size(134, 23);
            this.p2nme.TabIndex = 2;
            this.p2nme.Text = "Player 2 (O)";
            this.p2nme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // p1nme
            // 
            this.p1nme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1nme.Location = new System.Drawing.Point(12, 39);
            this.p1nme.Name = "p1nme";
            this.p1nme.Size = new System.Drawing.Size(126, 23);
            this.p1nme.TabIndex = 2;
            this.p1nme.Text = "Player 1 (X)";
            this.p1nme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(62, 139);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(97, 96);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(170, 138);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(97, 96);
            this.btn2.TabIndex = 0;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Btn2Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(278, 138);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(97, 96);
            this.btn3.TabIndex = 0;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(62, 245);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(97, 96);
            this.btn4.TabIndex = 0;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(169, 245);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(97, 96);
            this.btn5.TabIndex = 0;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(62, 351);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(97, 96);
            this.btn7.TabIndex = 0;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Btn7Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(170, 351);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(97, 96);
            this.btn8.TabIndex = 0;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Btn8Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(277, 351);
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
            this.label6.Location = new System.Drawing.Point(155, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Game";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // turn
            // 
            this.turn.Enabled = true;
            this.turn.Interval = 10;
            this.turn.Tick += new System.EventHandler(this.turn_Tick);
            // 
            // pnlvsbots
            // 
            this.pnlvsbots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(140)))), ((int)(((byte)(163)))));
            this.pnlvsbots.BorderColor = System.Drawing.Color.White;
            this.pnlvsbots.Controls.Add(this.button3);
            this.pnlvsbots.Controls.Add(this.label11);
            this.pnlvsbots.Controls.Add(this.label12);
            this.pnlvsbots.Controls.Add(this.button2);
            this.pnlvsbots.Controls.Add(this.label13);
            this.pnlvsbots.Edge = 20;
            this.pnlvsbots.Location = new System.Drawing.Point(12, 108);
            this.pnlvsbots.Name = "pnlvsbots";
            this.pnlvsbots.Size = new System.Drawing.Size(414, 376);
            this.pnlvsbots.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(132, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "LET\'S GO!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(26, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(414, 58);
            this.label11.TabIndex = 7;
            this.label11.Text = "> Bots is still in early development!\r\n    so expect some bugs!\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(414, 77);
            this.label12.TabIndex = 7;
            this.label12.Text = "INTRODUCING BOTS!";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(369, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.label13.Location = new System.Drawing.Point(0, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(414, 23);
            this.label13.TabIndex = 0;
            // 
            // pnlabtme
            // 
            this.pnlabtme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(63)))));
            this.pnlabtme.BorderColor = System.Drawing.Color.White;
            this.pnlabtme.Controls.Add(this.label4);
            this.pnlabtme.Controls.Add(this.label2);
            this.pnlabtme.Controls.Add(this.button1);
            this.pnlabtme.Controls.Add(this.label8);
            this.pnlabtme.Edge = 20;
            this.pnlabtme.Location = new System.Drawing.Point(12, 108);
            this.pnlabtme.Name = "pnlabtme";
            this.pnlabtme.Size = new System.Drawing.Size(414, 376);
            this.pnlabtme.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 58);
            this.label4.TabIndex = 7;
            this.label4.Text = "Made by Joed Michael";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 77);
            this.label2.TabIndex = 7;
            this.label2.Text = "C# Tic-Tac-Toe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(369, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(0, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(414, 23);
            this.label8.TabIndex = 0;
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
            this.windone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windone.FlatAppearance.BorderSize = 0;
            this.windone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windone.ForeColor = System.Drawing.SystemColors.Control;
            this.windone.Location = new System.Drawing.Point(0, 72);
            this.windone.Name = "windone";
            this.windone.Size = new System.Drawing.Size(414, 21);
            this.windone.TabIndex = 5;
            this.windone.Text = "Next Game!";
            this.windone.UseVisualStyleBackColor = false;
            this.windone.Click += new System.EventHandler(this.WindoneClick);
            // 
            // lblwin
            // 
            this.lblwin.BackColor = System.Drawing.Color.Transparent;
            this.lblwin.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwin.ForeColor = System.Drawing.Color.White;
            this.lblwin.Location = new System.Drawing.Point(0, 0);
            this.lblwin.Name = "lblwin";
            this.lblwin.Size = new System.Drawing.Size(414, 93);
            this.lblwin.TabIndex = 0;
            this.lblwin.Text = "X WINS!";
            this.lblwin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlsetname
            // 
            this.pnlsetname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            this.pnlsetname.BorderColor = System.Drawing.Color.White;
            this.pnlsetname.Controls.Add(this.Xsetname);
            this.pnlsetname.Controls.Add(this.roundedPanel4);
            this.pnlsetname.Controls.Add(this.txbxp2);
            this.pnlsetname.Controls.Add(this.txbxp1);
            this.pnlsetname.Controls.Add(this.lblp2);
            this.pnlsetname.Controls.Add(this.lblp1);
            this.pnlsetname.Controls.Add(this.lblSetName);
            this.pnlsetname.Controls.Add(this.dsgnpnl);
            this.pnlsetname.Edge = 20;
            this.pnlsetname.Location = new System.Drawing.Point(12, 108);
            this.pnlsetname.Name = "pnlsetname";
            this.pnlsetname.Size = new System.Drawing.Size(414, 376);
            this.pnlsetname.TabIndex = 5;
            // 
            // Xsetname
            // 
            this.Xsetname.BackColor = System.Drawing.Color.Transparent;
            this.Xsetname.FlatAppearance.BorderSize = 0;
            this.Xsetname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Xsetname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Xsetname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xsetname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xsetname.Location = new System.Drawing.Point(369, 3);
            this.Xsetname.Name = "Xsetname";
            this.Xsetname.Size = new System.Drawing.Size(40, 40);
            this.Xsetname.TabIndex = 6;
            this.Xsetname.Text = "X";
            this.Xsetname.UseVisualStyleBackColor = false;
            this.Xsetname.Click += new System.EventHandler(this.XsetnameClick);
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.roundedPanel4.BorderColor = System.Drawing.Color.White;
            this.roundedPanel4.Controls.Add(this.btnsetname);
            this.roundedPanel4.Edge = 20;
            this.roundedPanel4.Location = new System.Drawing.Point(143, 218);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(147, 59);
            this.roundedPanel4.TabIndex = 5;
            // 
            // btnsetname
            // 
            this.btnsetname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnsetname.FlatAppearance.BorderSize = 0;
            this.btnsetname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetname.Location = new System.Drawing.Point(0, 0);
            this.btnsetname.Name = "btnsetname";
            this.btnsetname.Size = new System.Drawing.Size(147, 44);
            this.btnsetname.TabIndex = 0;
            this.btnsetname.Text = "Update";
            this.btnsetname.UseVisualStyleBackColor = false;
            this.btnsetname.Click += new System.EventHandler(this.BtnsetnameClick);
            // 
            // txbxp2
            // 
            this.txbxp2.Location = new System.Drawing.Point(143, 155);
            this.txbxp2.Multiline = true;
            this.txbxp2.Name = "txbxp2";
            this.txbxp2.Size = new System.Drawing.Size(219, 27);
            this.txbxp2.TabIndex = 4;
            // 
            // txbxp1
            // 
            this.txbxp1.Location = new System.Drawing.Point(143, 99);
            this.txbxp1.Multiline = true;
            this.txbxp1.Name = "txbxp1";
            this.txbxp1.Size = new System.Drawing.Size(219, 27);
            this.txbxp1.TabIndex = 4;
            // 
            // lblp2
            // 
            this.lblp2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp2.ForeColor = System.Drawing.Color.White;
            this.lblp2.Location = new System.Drawing.Point(26, 151);
            this.lblp2.Name = "lblp2";
            this.lblp2.Size = new System.Drawing.Size(100, 31);
            this.lblp2.TabIndex = 3;
            this.lblp2.Text = "Player 2:";
            this.lblp2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblp1
            // 
            this.lblp1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1.ForeColor = System.Drawing.Color.White;
            this.lblp1.Location = new System.Drawing.Point(26, 90);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(100, 36);
            this.lblp1.TabIndex = 2;
            this.lblp1.Text = "Player 1:";
            this.lblp1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSetName
            // 
            this.lblSetName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetName.ForeColor = System.Drawing.Color.White;
            this.lblSetName.Location = new System.Drawing.Point(0, 29);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(414, 41);
            this.lblSetName.TabIndex = 1;
            this.lblSetName.Text = "Set Name";
            this.lblSetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dsgnpnl
            // 
            this.dsgnpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.dsgnpnl.Location = new System.Drawing.Point(0, 353);
            this.dsgnpnl.Name = "dsgnpnl";
            this.dsgnpnl.Size = new System.Drawing.Size(414, 23);
            this.dsgnpnl.TabIndex = 0;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Silver;
            this.roundedPanel3.BorderColor = System.Drawing.Color.White;
            this.roundedPanel3.Controls.Add(this.dsgnprps);
            this.roundedPanel3.Controls.Add(this.lblRound);
            this.roundedPanel3.Edge = 20;
            this.roundedPanel3.Location = new System.Drawing.Point(157, 35);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(122, 67);
            this.roundedPanel3.TabIndex = 3;
            // 
            // dsgnprps
            // 
            this.dsgnprps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.dsgnprps.Location = new System.Drawing.Point(0, 59);
            this.dsgnprps.Name = "dsgnprps";
            this.dsgnprps.Size = new System.Drawing.Size(124, 11);
            this.dsgnprps.TabIndex = 1;
            // 
            // lblRound
            // 
            this.lblRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(0, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(122, 67);
            this.lblRound.TabIndex = 0;
            this.lblRound.Text = "1";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // waiting
            // 
            this.waiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.waiting.BorderColor = System.Drawing.Color.White;
            this.waiting.Controls.Add(this.label9);
            this.waiting.Controls.Add(this.label10);
            this.waiting.Controls.Add(this.label7);
            this.waiting.Edge = 20;
            this.waiting.Location = new System.Drawing.Point(-24, 190);
            this.waiting.Name = "waiting";
            this.waiting.Size = new System.Drawing.Size(497, 180);
            this.waiting.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.label9.Location = new System.Drawing.Point(25, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(472, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "                                                                                 " +
    "                                                                          ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(165, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "WAIT FOR YOUR TURN . . .";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(420, 45);
            this.label7.TabIndex = 0;
            this.label7.Text = "OPPONENT IS ATTACKING\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 511);
            this.Controls.Add(this.waiting);
            this.Controls.Add(this.pnlvsbots);
            this.Controls.Add(this.pnlabtme);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.pnlsetname);
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
            this.Controls.Add(this.p1nme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p2nme);
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
            this.pnlvsbots.ResumeLayout(false);
            this.pnlabtme.ResumeLayout(false);
            this.winner.ResumeLayout(false);
            this.pnlsetname.ResumeLayout(false);
            this.pnlsetname.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.turn1.ResumeLayout(false);
            this.turn2.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.waiting.ResumeLayout(false);
            this.waiting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ToolStripMenuItem vSBotBetaToolStripMenuItem;
        private System.Windows.Forms.Timer timer3;
        private practiceLogin.roundedPanel waiting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer turn;
        private practiceLogin.roundedPanel pnlvsbots;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
    }
}
