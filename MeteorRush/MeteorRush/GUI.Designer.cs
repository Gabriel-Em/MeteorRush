namespace MeteorRush
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerStanga = new System.Windows.Forms.Timer(this.components);
            this.TimerDreapta = new System.Windows.Forms.Timer(this.components);
            this.TimerRelease = new System.Windows.Forms.Timer(this.components);
            this.TimerBeam = new System.Windows.Forms.Timer(this.components);
            this.TimerBadBadThingSpawn = new System.Windows.Forms.Timer(this.components);
            this.TimerBadBadThingMove = new System.Windows.Forms.Timer(this.components);
            this.TimerCheck = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.TimerDifficuly = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScor = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.btnOverStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIesire = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnScoruri = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDespre = new System.Windows.Forms.Button();
            this.btnInstructiuni = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFocus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.TimerFinalBossOrizontal = new System.Windows.Forms.Timer(this.components);
            this.TimerFinalBossBeamSpawn = new System.Windows.Forms.Timer(this.components);
            this.TimerFinalBossBeam = new System.Windows.Forms.Timer(this.components);
            this.TimerFBCheck = new System.Windows.Forms.Timer(this.components);
            this.TimerFinalBossVertical = new System.Windows.Forms.Timer(this.components);
            this.TimerBetween = new System.Windows.Forms.Timer(this.components);
            this.TimerFinal = new System.Windows.Forms.Timer(this.components);
            this.TimerRocketFB = new System.Windows.Forms.Timer(this.components);
            this.TimerRocketSpawn = new System.Windows.Forms.Timer(this.components);
            this.FBScutPic = new System.Windows.Forms.PictureBox();
            this.ViataFBPic = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.picLive6 = new System.Windows.Forms.PictureBox();
            this.picLive5 = new System.Windows.Forms.PictureBox();
            this.picLive4 = new System.Windows.Forms.PictureBox();
            this.picLive1 = new System.Windows.Forms.PictureBox();
            this.picLive3 = new System.Windows.Forms.PictureBox();
            this.picLive2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GratsPic = new System.Windows.Forms.PictureBox();
            this.BetweenPic = new System.Windows.Forms.PictureBox();
            this.FinalBossPic = new System.Windows.Forms.PictureBox();
            this.picGameOver = new System.Windows.Forms.PictureBox();
            this.SpaceShipPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FBScutPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViataFBPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GratsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetweenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBossPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShipPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerStanga
            // 
            this.TimerStanga.Interval = 15;
            this.TimerStanga.Tick += new System.EventHandler(this.TimerStanga_Tick);
            // 
            // TimerDreapta
            // 
            this.TimerDreapta.Interval = 15;
            this.TimerDreapta.Tick += new System.EventHandler(this.TimerDreapta_Tick);
            // 
            // TimerRelease
            // 
            this.TimerRelease.Interval = 15;
            this.TimerRelease.Tick += new System.EventHandler(this.TimerRelease_Tick);
            // 
            // TimerBeam
            // 
            this.TimerBeam.Interval = 15;
            this.TimerBeam.Tick += new System.EventHandler(this.TimerBeam_Tick);
            // 
            // TimerBadBadThingSpawn
            // 
            this.TimerBadBadThingSpawn.Interval = 1500;
            this.TimerBadBadThingSpawn.Tick += new System.EventHandler(this.TimerBadBadThing_Tick);
            // 
            // TimerBadBadThingMove
            // 
            this.TimerBadBadThingMove.Interval = 15;
            this.TimerBadBadThingMove.Tick += new System.EventHandler(this.TimerBadBadThingMove_Tick);
            // 
            // TimerCheck
            // 
            this.TimerCheck.Interval = 15;
            this.TimerCheck.Tick += new System.EventHandler(this.TimerCheck_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnStart.Location = new System.Drawing.Point(19, 359);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(217, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStart_KeyDown);
            this.btnStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnStart_KeyPress);
            this.btnStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnStart_KeyUp);
            // 
            // TimerDifficuly
            // 
            this.TimerDifficuly.Interval = 30000;
            this.TimerDifficuly.Tick += new System.EventHandler(this.TimerDifficuly_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Difficulty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.GreenYellow;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // lblScor
            // 
            this.lblScor.AutoSize = true;
            this.lblScor.BackColor = System.Drawing.Color.GreenYellow;
            this.lblScor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScor.ForeColor = System.Drawing.Color.Black;
            this.lblScor.Location = new System.Drawing.Point(178, 199);
            this.lblScor.Name = "lblScor";
            this.lblScor.Size = new System.Drawing.Size(49, 15);
            this.lblScor.TabIndex = 10;
            this.lblScor.Text = "000000";
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.BackColor = System.Drawing.Color.GreenYellow;
            this.lblDiff.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiff.ForeColor = System.Drawing.Color.Black;
            this.lblDiff.Location = new System.Drawing.Point(213, 250);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(14, 15);
            this.lblDiff.TabIndex = 11;
            this.lblDiff.Text = "1";
            // 
            // btnOverStart
            // 
            this.btnOverStart.BackColor = System.Drawing.Color.Transparent;
            this.btnOverStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverStart.Enabled = false;
            this.btnOverStart.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnOverStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnOverStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnOverStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverStart.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverStart.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnOverStart.Location = new System.Drawing.Point(19, 359);
            this.btnOverStart.Name = "btnOverStart";
            this.btnOverStart.Size = new System.Drawing.Size(217, 35);
            this.btnOverStart.TabIndex = 15;
            this.btnOverStart.Text = "START";
            this.btnOverStart.UseVisualStyleBackColor = false;
            this.btnOverStart.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lives:";
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.Color.Transparent;
            this.btnIesire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIesire.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnIesire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnIesire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnIesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnIesire.Location = new System.Drawing.Point(19, 523);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(217, 35);
            this.btnIesire.TabIndex = 24;
            this.btnIesire.Text = "QUIT GAME";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.GreenYellow;
            this.txtName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(88, 300);
            this.txtName.MaxLength = 22;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 25;
            // 
            // btnScoruri
            // 
            this.btnScoruri.BackColor = System.Drawing.Color.Transparent;
            this.btnScoruri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScoruri.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnScoruri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnScoruri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnScoruri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoruri.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoruri.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnScoruri.Location = new System.Drawing.Point(19, 400);
            this.btnScoruri.Name = "btnScoruri";
            this.btnScoruri.Size = new System.Drawing.Size(217, 35);
            this.btnScoruri.TabIndex = 26;
            this.btnScoruri.Text = "SCORES";
            this.btnScoruri.UseVisualStyleBackColor = false;
            this.btnScoruri.Click += new System.EventHandler(this.btnScoruri_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.GreenYellow;
            this.lblHighScore.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Black;
            this.lblHighScore.Location = new System.Drawing.Point(178, 225);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(49, 15);
            this.lblHighScore.TabIndex = 33;
            this.lblHighScore.Text = "000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "High Score:";
            // 
            // btnDespre
            // 
            this.btnDespre.BackColor = System.Drawing.Color.Transparent;
            this.btnDespre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespre.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnDespre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnDespre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDespre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespre.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnDespre.Location = new System.Drawing.Point(19, 482);
            this.btnDespre.Name = "btnDespre";
            this.btnDespre.Size = new System.Drawing.Size(217, 35);
            this.btnDespre.TabIndex = 34;
            this.btnDespre.Text = "ABOUT";
            this.btnDespre.UseVisualStyleBackColor = false;
            this.btnDespre.Click += new System.EventHandler(this.btnDespre_Click);
            // 
            // btnInstructiuni
            // 
            this.btnInstructiuni.BackColor = System.Drawing.Color.Transparent;
            this.btnInstructiuni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstructiuni.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnInstructiuni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnInstructiuni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnInstructiuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructiuni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructiuni.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnInstructiuni.Location = new System.Drawing.Point(19, 441);
            this.btnInstructiuni.Name = "btnInstructiuni";
            this.btnInstructiuni.Size = new System.Drawing.Size(217, 35);
            this.btnInstructiuni.TabIndex = 35;
            this.btnInstructiuni.Text = "INSTRUCTIONS";
            this.btnInstructiuni.UseVisualStyleBackColor = false;
            this.btnInstructiuni.Click += new System.EventHandler(this.btnInstructiuni_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnFocus);
            this.panel1.Controls.Add(this.FBScutPic);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ViataFBPic);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnOverStart);
            this.panel1.Controls.Add(this.btnInstructiuni);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.btnDespre);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.lblHighScore);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.btnScoruri);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnIesire);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picLive6);
            this.panel1.Controls.Add(this.lblScor);
            this.panel1.Controls.Add(this.picLive5);
            this.panel1.Controls.Add(this.lblDiff);
            this.panel1.Controls.Add(this.picLive4);
            this.panel1.Controls.Add(this.picLive1);
            this.panel1.Controls.Add(this.picLive3);
            this.panel1.Controls.Add(this.picLive2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(480, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 571);
            this.panel1.TabIndex = 36;
            // 
            // btnFocus
            // 
            this.btnFocus.BackColor = System.Drawing.Color.Transparent;
            this.btnFocus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFocus.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnFocus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnFocus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnFocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFocus.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFocus.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnFocus.Location = new System.Drawing.Point(275, 125);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(27, 35);
            this.btnFocus.TabIndex = 43;
            this.btnFocus.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Boss Health:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnReset.Location = new System.Drawing.Point(26, 325);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(202, 23);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "RESET SCORES";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TimerFinalBossOrizontal
            // 
            this.TimerFinalBossOrizontal.Interval = 15;
            this.TimerFinalBossOrizontal.Tick += new System.EventHandler(this.TimerFinalBossOrizontal_Tick);
            // 
            // TimerFinalBossBeamSpawn
            // 
            this.TimerFinalBossBeamSpawn.Interval = 250;
            this.TimerFinalBossBeamSpawn.Tick += new System.EventHandler(this.TimerFinalBossBeamSpawn_Tick);
            // 
            // TimerFinalBossBeam
            // 
            this.TimerFinalBossBeam.Interval = 15;
            this.TimerFinalBossBeam.Tick += new System.EventHandler(this.TimerFinalBossBeam_Tick);
            // 
            // TimerFBCheck
            // 
            this.TimerFBCheck.Interval = 15;
            this.TimerFBCheck.Tick += new System.EventHandler(this.TimerFBCheck_Tick);
            // 
            // TimerFinalBossVertical
            // 
            this.TimerFinalBossVertical.Interval = 15;
            this.TimerFinalBossVertical.Tick += new System.EventHandler(this.TimerFinalBossVertical_Tick);
            // 
            // TimerBetween
            // 
            this.TimerBetween.Interval = 15;
            this.TimerBetween.Tick += new System.EventHandler(this.TimerBetween_Tick);
            // 
            // TimerFinal
            // 
            this.TimerFinal.Interval = 30;
            this.TimerFinal.Tick += new System.EventHandler(this.TimerFinal_Tick);
            // 
            // TimerRocketFB
            // 
            this.TimerRocketFB.Interval = 15;
            this.TimerRocketFB.Tick += new System.EventHandler(this.TimerRocketFB_Tick);
            // 
            // TimerRocketSpawn
            // 
            this.TimerRocketSpawn.Interval = 6000;
            this.TimerRocketSpawn.Tick += new System.EventHandler(this.TimerRocketSpawn_Tick);
            // 
            // FBScutPic
            // 
            this.FBScutPic.BackColor = System.Drawing.Color.Yellow;
            this.FBScutPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FBScutPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBScutPic.Location = new System.Drawing.Point(125, 277);
            this.FBScutPic.Name = "FBScutPic";
            this.FBScutPic.Size = new System.Drawing.Size(100, 14);
            this.FBScutPic.TabIndex = 42;
            this.FBScutPic.TabStop = false;
            // 
            // ViataFBPic
            // 
            this.ViataFBPic.BackColor = System.Drawing.Color.Red;
            this.ViataFBPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ViataFBPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViataFBPic.Location = new System.Drawing.Point(125, 277);
            this.ViataFBPic.Name = "ViataFBPic";
            this.ViataFBPic.Size = new System.Drawing.Size(100, 14);
            this.ViataFBPic.TabIndex = 41;
            this.ViataFBPic.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(26, 274);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(202, 20);
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::MeteorRush.Properties.Resources.Title;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Location = new System.Drawing.Point(-11, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(265, 150);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Location = new System.Drawing.Point(26, 222);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(202, 20);
            this.pictureBox8.TabIndex = 32;
            this.pictureBox8.TabStop = false;
            // 
            // picLive6
            // 
            this.picLive6.BackColor = System.Drawing.Color.Transparent;
            this.picLive6.BackgroundImage = global::MeteorRush.Properties.Resources.Live;
            this.picLive6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLive6.Location = new System.Drawing.Point(207, 172);
            this.picLive6.Name = "picLive6";
            this.picLive6.Size = new System.Drawing.Size(20, 20);
            this.picLive6.TabIndex = 23;
            this.picLive6.TabStop = false;
            // 
            // picLive5
            // 
            this.picLive5.BackColor = System.Drawing.Color.Transparent;
            this.picLive5.BackgroundImage = global::MeteorRush.Properties.Resources.Live;
            this.picLive5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLive5.Location = new System.Drawing.Point(184, 172);
            this.picLive5.Name = "picLive5";
            this.picLive5.Size = new System.Drawing.Size(20, 20);
            this.picLive5.TabIndex = 22;
            this.picLive5.TabStop = false;
            // 
            // picLive4
            // 
            this.picLive4.BackColor = System.Drawing.Color.Transparent;
            this.picLive4.BackgroundImage = global::MeteorRush.Properties.Resources.Live;
            this.picLive4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLive4.Location = new System.Drawing.Point(161, 172);
            this.picLive4.Name = "picLive4";
            this.picLive4.Size = new System.Drawing.Size(20, 20);
            this.picLive4.TabIndex = 21;
            this.picLive4.TabStop = false;
            // 
            // picLive1
            // 
            this.picLive1.BackColor = System.Drawing.Color.Transparent;
            this.picLive1.BackgroundImage = global::MeteorRush.Properties.Resources.Live;
            this.picLive1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLive1.Location = new System.Drawing.Point(92, 172);
            this.picLive1.Name = "picLive1";
            this.picLive1.Size = new System.Drawing.Size(20, 20);
            this.picLive1.TabIndex = 16;
            this.picLive1.TabStop = false;
            // 
            // picLive3
            // 
            this.picLive3.BackColor = System.Drawing.Color.Transparent;
            this.picLive3.BackgroundImage = global::MeteorRush.Properties.Resources.Live;
            this.picLive3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLive3.Location = new System.Drawing.Point(138, 172);
            this.picLive3.Name = "picLive3";
            this.picLive3.Size = new System.Drawing.Size(20, 20);
            this.picLive3.TabIndex = 20;
            this.picLive3.TabStop = false;
            // 
            // picLive2
            // 
            this.picLive2.BackColor = System.Drawing.Color.Transparent;
            this.picLive2.BackgroundImage = global::MeteorRush.Properties.Resources.Live;
            this.picLive2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLive2.Location = new System.Drawing.Point(115, 172);
            this.picLive2.Name = "picLive2";
            this.picLive2.Size = new System.Drawing.Size(20, 20);
            this.picLive2.TabIndex = 19;
            this.picLive2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(26, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 20);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Location = new System.Drawing.Point(26, 172);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 20);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(26, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 20);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(26, 300);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 20);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(19, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 187);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // GratsPic
            // 
            this.GratsPic.BackColor = System.Drawing.Color.Transparent;
            this.GratsPic.BackgroundImage = global::MeteorRush.Properties.Resources.Winner;
            this.GratsPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GratsPic.Location = new System.Drawing.Point(-8, 27);
            this.GratsPic.Name = "GratsPic";
            this.GratsPic.Size = new System.Drawing.Size(496, 571);
            this.GratsPic.TabIndex = 44;
            this.GratsPic.TabStop = false;
            this.GratsPic.Visible = false;
            // 
            // BetweenPic
            // 
            this.BetweenPic.BackColor = System.Drawing.Color.Transparent;
            this.BetweenPic.BackgroundImage = global::MeteorRush.Properties.Resources.Between1;
            this.BetweenPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BetweenPic.Location = new System.Drawing.Point(-306, 92);
            this.BetweenPic.Name = "BetweenPic";
            this.BetweenPic.Size = new System.Drawing.Size(298, 277);
            this.BetweenPic.TabIndex = 43;
            this.BetweenPic.TabStop = false;
            // 
            // FinalBossPic
            // 
            this.FinalBossPic.BackColor = System.Drawing.Color.Transparent;
            this.FinalBossPic.BackgroundImage = global::MeteorRush.Properties.Resources.FinalBossS;
            this.FinalBossPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FinalBossPic.Location = new System.Drawing.Point(155, -182);
            this.FinalBossPic.Name = "FinalBossPic";
            this.FinalBossPic.Size = new System.Drawing.Size(170, 170);
            this.FinalBossPic.TabIndex = 40;
            this.FinalBossPic.TabStop = false;
            // 
            // picGameOver
            // 
            this.picGameOver.BackColor = System.Drawing.Color.Transparent;
            this.picGameOver.BackgroundImage = global::MeteorRush.Properties.Resources.GameOver;
            this.picGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picGameOver.Location = new System.Drawing.Point(-1, -7);
            this.picGameOver.Name = "picGameOver";
            this.picGameOver.Size = new System.Drawing.Size(496, 571);
            this.picGameOver.TabIndex = 39;
            this.picGameOver.TabStop = false;
            this.picGameOver.Visible = false;
            // 
            // SpaceShipPic
            // 
            this.SpaceShipPic.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShipPic.BackgroundImage = global::MeteorRush.Properties.Resources.SpaceShip;
            this.SpaceShipPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SpaceShipPic.Location = new System.Drawing.Point(216, 476);
            this.SpaceShipPic.Name = "SpaceShipPic";
            this.SpaceShipPic.Size = new System.Drawing.Size(75, 75);
            this.SpaceShipPic.TabIndex = 0;
            this.SpaceShipPic.TabStop = false;
            this.SpaceShipPic.Visible = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 563);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GratsPic);
            this.Controls.Add(this.BetweenPic);
            this.Controls.Add(this.FinalBossPic);
            this.Controls.Add(this.picGameOver);
            this.Controls.Add(this.SpaceShipPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "Meteor Rush";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FBScutPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViataFBPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLive2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GratsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetweenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBossPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShipPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceShipPic;
        private System.Windows.Forms.Timer TimerStanga;
        private System.Windows.Forms.Timer TimerDreapta;
        private System.Windows.Forms.Timer TimerRelease;
        private System.Windows.Forms.Timer TimerBeam;
        private System.Windows.Forms.Timer TimerBadBadThingSpawn;
        private System.Windows.Forms.Timer TimerBadBadThingMove;
        private System.Windows.Forms.Timer TimerCheck;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer TimerDifficuly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblScor;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Button btnOverStart;
        private System.Windows.Forms.PictureBox picLive1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox picLive2;
        private System.Windows.Forms.PictureBox picLive4;
        private System.Windows.Forms.PictureBox picLive3;
        private System.Windows.Forms.PictureBox picLive6;
        private System.Windows.Forms.PictureBox picLive5;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnScoruri;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btnDespre;
        private System.Windows.Forms.Button btnInstructiuni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picGameOver;
        private System.Windows.Forms.Timer TimerFinalBossOrizontal;
        private System.Windows.Forms.PictureBox FinalBossPic;
        private System.Windows.Forms.Timer TimerFinalBossBeamSpawn;
        private System.Windows.Forms.Timer TimerFinalBossBeam;
        private System.Windows.Forms.Timer TimerFBCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ViataFBPic;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox FBScutPic;
        private System.Windows.Forms.Timer TimerFinalBossVertical;
        private System.Windows.Forms.Timer TimerBetween;
        private System.Windows.Forms.PictureBox BetweenPic;
        private System.Windows.Forms.PictureBox GratsPic;
        private System.Windows.Forms.Timer TimerFinal;
        private System.Windows.Forms.Button btnFocus;
        private System.Windows.Forms.Timer TimerRocketFB;
        private System.Windows.Forms.Timer TimerRocketSpawn;
    }
}