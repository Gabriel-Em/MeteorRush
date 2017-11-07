using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Drawing.Text;

namespace MeteorRush
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private int SpaceShip;
        private List<PictureBox> Gloante;
        private List<PictureBox> Enemies;
        private List<PictureBox> Lives;
        private List<PictureBox> FBGloante;
        private List<PictureBox> Rockets;
        private bool EnterDown;
        private int EnemySpeed;
        private int SpaceShipSpeed;
        private int Limitator;
        private bool Playing;
        private int Vieti;
        private Image b = MeteorRush.Properties.Resources.BadBadThing;
        private Image s = MeteorRush.Properties.Resources.Shield;
        private Image h = MeteorRush.Properties.Resources.LiveP;
        private bool Scut;
        private bool FinalBossScut;
        private int FBM;        // Nr de frameuri generate random pentru miscarea Bossului la dreapta/stanga
        private int FBMS;
        private bool FBD;    // Final Boss Direction (true = dreapta, false = stanga)
        private bool FBDS;
        private int BossDiff;
        private int Between;
        private bool RocketD;
        private bool LastScene;
        private List<string> Scoruri;

        private void GUI_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            SpaceShip = 0;

            Gloante = new List<PictureBox>();
            Enemies = new List<PictureBox>();
            Lives = new List<PictureBox>();
            FBGloante = new List<PictureBox>();
            Rockets = new List<PictureBox>();
            Scoruri = new List<string>();

            Lives.Add(picLive1);
            Lives.Add(picLive2);
            Lives.Add(picLive3);
            Lives.Add(picLive4);
            Lives.Add(picLive5);
            Lives.Add(picLive6);

            EnterDown = false;
            Playing = false;

            EnemySpeed = 1;
            SpaceShipSpeed = 3;
            Limitator = 1;
            Vieti = 6;
            Scut = false;
            FinalBossScut = true;
            FBM = 0;
            FBD = true;
            FBMS = 0;
            FBDS = true;
            BossDiff = 2;
            Between = 0;
            RocketD = true;
            LastScene = false;

            if (File.Exists(@".\Scores.mr"))
            {
                string Fisier = File.ReadAllText(@".\Scores.mr");
                Scoruri = Fisier.Split('\n').ToList<string>();

                for(int i =0 ;i<Scoruri.Count;i++)
                    if (Scoruri[i] == "")
                    {
                        Scoruri.RemoveAt(i);
                        i--;
                    }

                if (Scoruri.Count >= 1)
                    lblHighScore.Text = Scoruri[0].Split(',')[1];
            }
            else
                File.Create(@".\Scores.mr");
        }

        private void btnStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && EnterDown == false && Playing && !LastScene)
            {
                EnterDown = true;
                Trage();
            }
        }

        private void btnStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Playing)
            {
                if (e.KeyChar == 97 || e.KeyChar == 65)
                    TimerStanga.Enabled = true;
                if (e.KeyChar == 100 || e.KeyChar == 68)
                    TimerDreapta.Enabled = true;
                if (e.KeyChar == 114 || e.KeyChar == 82)
                {
                    Playing = false;
                    btnStart.PerformClick();
                    btnStart.Focus();
                }
            }
        }

        private void btnStart_KeyUp(object sender, KeyEventArgs e)
        {
            if (Playing)
            {
                if (e.KeyCode == Keys.A)
                {
                    TimerStanga.Enabled = false;
                    if (SpaceShip != 0)
                        TimerRelease.Enabled = true;
                }

                if (e.KeyCode == Keys.D)
                {
                    TimerDreapta.Enabled = false;
                    if (SpaceShip != 0)
                        TimerRelease.Enabled = true;
                }

                if (e.KeyCode == Keys.Space)
                    EnterDown = false;
            }
        }

        private void Trage()
        {
            if (Gloante.Count < Limitator)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Gold;

                pic.Width = 5;
                pic.Height = 20;

                pic.Location = new Point(SpaceShipPic.Location.X + 34, SpaceShipPic.Location.Y - 30);
                pic.BorderStyle = BorderStyle.FixedSingle;

                pic.Visible = true;
                pic.BringToFront();
                Controls.Add(pic);
                Gloante.Add(pic);
            }
        }

        private void Spawner()
        {
            PictureBox pic = new PictureBox();

            pic.Width = 50;
            pic.Height = 50;

            Random R = new Random();

            if (R.Next(1, 10) % 2 == 0)
                pic.Location = new Point(R.Next(1, 200), -50);
            else
                pic.Location = new Point(R.Next(200, 400), -50);

            pic.BackgroundImage = b;
            pic.Visible = true;

            int x = R.Next(1000, 10000);
            if (x % 100 >= 1 && x % 100 <= 5)
                pic.BackgroundImage = h;
            if (x % 100 >= 6 && x % 100 <= 15)
                pic.BackgroundImage = s;


            Controls.Add(pic);
            Enemies.Add(pic);
        }

        private void TimerStanga_Tick(object sender, EventArgs e)
        {
            if (SpaceShipPic.Location.X > 0)
                SpaceShipPic.Location = new Point(SpaceShipPic.Location.X - SpaceShipSpeed, SpaceShipPic.Location.Y);

            if (SpaceShip < 8)
                SpaceShip++;

            Inclina();
        }

        private void TimerDreapta_Tick(object sender, EventArgs e)
        {
            if (SpaceShipPic.Location.X < 400)
                SpaceShipPic.Location = new Point(SpaceShipPic.Location.X + SpaceShipSpeed, SpaceShipPic.Location.Y);

            if (SpaceShip > -8)
                  SpaceShip--;

            Inclina();
        }

        private void Inclina()
        {
            if (Scut)
                switch (SpaceShip)
                {
                    case -8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS8; break;
                    case -7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS7; break;
                    case -6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS6; break;
                    case -5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS5; break;
                    case -4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS4; break;
                    case -3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS3; break;
                    case -2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS2; break;
                    case -1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS1; break;
                    case 0: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS; break;
                    case 1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD1; break;
                    case 2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD2; break;
                    case 3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD3; break;
                    case 4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD4; break;
                    case 5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD5; break;
                    case 6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD6; break;
                    case 7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD7; break;
                    case 8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD8; break;
                }
            else
                switch (SpaceShip)
                {
                    case -8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS8; break;
                    case -7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS7; break;
                    case -6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS6; break;
                    case -5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS5; break;
                    case -4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS4; break;
                    case -3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS3; break;
                    case -2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS2; break;
                    case -1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS1; break;
                    case 0: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShip; break;
                    case 1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD1; break;
                    case 2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD2; break;
                    case 3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD3; break;
                    case 4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD4; break;
                    case 5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD5; break;
                    case 6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD6; break;
                    case 7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD7; break;
                    case 8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD8; break;
                }
        }

        private void TimerRelease_Tick(object sender, EventArgs e)
        {
            if (SpaceShip < 0)
                SpaceShip++;
            if (SpaceShip > 0)
                SpaceShip--;
            if (SpaceShip == 0)
            {
                Inclina();
                TimerRelease.Enabled = false;
            }
            Inclina();
        }

        private void TimerBeam_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Gloante.Count; i++)
            {
                Gloante[i].Location = new Point(Gloante[i].Location.X, Gloante[i].Location.Y - 12);

                if(Gloante[i].Location.Y < -10)
                {
                    Gloante[i].Dispose();
                    Gloante.RemoveAt(i);
                }
            }
        }

        private void TimerBadBadThing_Tick(object sender, EventArgs e)
        {
            Spawner();
        }

        private void TimerBadBadThingMove_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Enemies.Count; i++)
            {
                Enemies[i].Location = new Point(Enemies[i].Location.X, Enemies[i].Location.Y + EnemySpeed);

                if (Enemies[i].Location.Y >= 570)
                {
                    Enemies[i].Dispose();
                    Enemies.RemoveAt(i);

                    Vieti--;

                    if (Vieti < 0)
                    {
                        GameOver();
                        break;
                    }
                    else
                        Lives[Vieti].Visible = false;
                }
            }
        }

        private void GameOver()
        {
            btnOverStart.Visible = false;
            TimerBadBadThingSpawn.Enabled = false;
            TimerBadBadThingMove.Enabled = false;
            TimerCheck.Enabled = false;
            TimerDifficuly.Enabled = false;
            TimerBeam.Enabled = false;
            TimerDreapta.Enabled = false;
            TimerStanga.Enabled = false;
            TimerRelease.Enabled = false;
            TimerFinalBossOrizontal.Enabled = false;
            TimerFinalBossVertical.Enabled = false;
            TimerFinalBossBeam.Enabled = false;
            TimerFinalBossBeamSpawn.Enabled = false;
            TimerFBCheck.Enabled = false;
            TimerBetween.Enabled = false;
            FinalBossPic.Visible = false;
            TimerRocketFB.Enabled = false;
            TimerRocketSpawn.Enabled = false;

            btnScoruri.Enabled = true;
            txtName.Enabled = true;
            btnDespre.Enabled = true;
            btnReset.Enabled = true;
            btnInstructiuni.Enabled = true;
            btnFocus.Focus();

            while (Gloante.Count > 0)
            {
                Gloante[0].Dispose();
                Gloante.RemoveAt(0);
            }

            while (Enemies.Count > 0)
            {
                Enemies[0].Dispose();
                Enemies.RemoveAt(0);
            }

            while (FBGloante.Count > 0)
            {
                FBGloante[0].Dispose();
                FBGloante.RemoveAt(0);
            }

            while (Rockets.Count > 0)
            {
                Rockets[0].Dispose();
                Rockets.RemoveAt(0);
            }

            Playing = false;
            btnOverStart.Visible = false;
            picGameOver.Visible = true;

            if (Int32.Parse(lblScor.Text) > Int32.Parse(lblHighScore.Text))
                lblHighScore.Text = lblScor.Text;

            Scoruri.Add(txtName.Text + "," + lblScor.Text);
            Sorteaza();
            scoresToFile();
        }

        private void TimerCheck_Tick(object sender, EventArgs e)
        {
            bool ok = true;

            for (int j = 0; j < Enemies.Count; j++)
            {
                ok = true;

                for (int i = 0; i < Gloante.Count; i++)
                {
                    if (Gloante[i].Location.Y <= Enemies[j].Location.Y + 50 && Gloante[i].Location.Y >= Enemies[j].Location.Y && Gloante[i].Location.X >= Enemies[j].Location.X - 8 && Gloante[i].Location.X <= Enemies[j].Location.X + 58)
                    {
                        string S = "";
                        int scor = Int32.Parse(lblScor.Text);

                        if (Enemies[j].BackgroundImage == b)            // daca tragi in meteorit
                            scor += 10 * Int32.Parse(lblDiff.Text);
                        else
                            if (Enemies[j].BackgroundImage == s)        // daca tragi in scut
                                scor -= 5 * Int32.Parse(lblDiff.Text);
                            else                                        // daca tragi in inima (viata)
                                scor -= 7 * Int32.Parse(lblDiff.Text);

                        if (scor < 0)
                            scor = 0;

                        S = scor.ToString();

                        while (S.Length < 6)
                            S = "0" + S;

                        lblScor.Text = S;

                        ok = false;

                        Gloante[i].Dispose();
                        Gloante.RemoveAt(i);
                        Enemies[j].Dispose();
                        Enemies.RemoveAt(j);

                        break;
                    }
                }
                                                                        // Coliziune
                if(ok)
                    if (SpaceShipPic.Location.Y <= Enemies[j].Location.Y + 50 && SpaceShipPic.Location.Y + 75 >= Enemies[j].Location.Y && SpaceShipPic.Location.X <= Enemies[j].Location.X + 50 && SpaceShipPic.Location.X + 75 >= Enemies[j].Location.X)
                    {
                        if (Enemies[j].BackgroundImage == b)
                        {
                            if (Scut)
                            {
                                Scut = false;

                                switch (SpaceShip)
                                {
                                    case -8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS8; break;
                                    case -7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS7; break;
                                    case -6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS6; break;
                                    case -5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS5; break;
                                    case -4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS4; break;
                                    case -3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS3; break;
                                    case -2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS2; break;
                                    case -1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS1; break;
                                    case 0: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShip; break;
                                    case 1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD1; break;
                                    case 2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD2; break;
                                    case 3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD3; break;
                                    case 4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD4; break;
                                    case 5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD5; break;
                                    case 6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD6; break;
                                    case 7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD7; break;
                                    case 8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD8; break;
                                }
                            }
                            else
                            {
                                Vieti--;

                                if (Vieti < 0)
                                {
                                    GameOver();
                                    break;
                                }
                                else
                                    Lives[Vieti].Visible = false;
                                
                            }
                        }
                        else
                            if (Enemies[j].BackgroundImage == s)
                            {
                                Scut = true;

                                switch (SpaceShip)
                                {
                                    case -8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS8; break;
                                    case -7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS7; break;
                                    case -6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS6; break;
                                    case -5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS5; break;
                                    case -4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS4; break;
                                    case -3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS3; break;
                                    case -2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS2; break;
                                    case -1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSS1; break;
                                    case 0: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS; break;
                                    case 1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD1; break;
                                    case 2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD2; break;
                                    case 3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD3; break;
                                    case 4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD4; break;
                                    case 5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD5; break;
                                    case 6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD6; break;
                                    case 7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD7; break;
                                    case 8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipSD8; break;
                                }

                                int scor = Int32.Parse(lblScor.Text);
                                scor += 12;
                                string S = "";

                                S = scor.ToString();

                                while (S.Length < 6)
                                    S = "0" + S;

                                lblScor.Text = S;
                            }
                            else
                            {
                                if (Vieti < 6)
                                {
                                    Lives[Vieti].Visible = true;
                                    Vieti++;
                                }

                                int scor = Int32.Parse(lblScor.Text);
                                scor += 24;
                                string S = "";

                                S = scor.ToString();

                                while (S.Length < 6)
                                    S = "0" + S;

                                lblScor.Text = S;
                            }

                        Enemies[j].Dispose();
                        Enemies.RemoveAt(j);
                    }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Playing)
            {
                btnOverStart.Visible = true;

                TimerBadBadThingSpawn.Enabled = true;
                TimerBadBadThingMove.Enabled = true;
                TimerCheck.Enabled = true;
                TimerDifficuly.Enabled = false;
                TimerDifficuly.Enabled = true;
                TimerBeam.Enabled = true;
                TimerStanga.Enabled = false;
                TimerDreapta.Enabled = false;
                TimerRelease.Enabled = false;
                TimerFinalBossOrizontal.Enabled = false;
                TimerFinalBossVertical.Enabled = false;
                TimerBetween.Enabled = false;
                TimerBetween.Interval = 15;
                TimerFinal.Enabled = false;
                TimerFinal.Interval = 15;
                TimerRocketFB.Enabled = false;
                TimerRocketSpawn.Enabled = false;
                TimerRocketSpawn.Interval = 6000;
                btnScoruri.Enabled = false;
                txtName.Enabled = false;
                btnDespre.Enabled = false;
                btnInstructiuni.Enabled = false;
                btnReset.Enabled = false;
                picGameOver.Visible = false;
                lblDiff.Location = new Point(213, 250);
                FinalBossPic.Location = new Point(155, -182);
                FinalBossPic.Visible = true;
                BetweenPic.Visible = true;
                FinalBossScut = true;
                FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossS;
                TimerFinalBossBeam.Enabled = false;
                TimerFinalBossBeamSpawn.Enabled = false;
                TimerFBCheck.Enabled = false;
                FinalBossScut = true;

                LastScene = false;
                BossDiff = 2;
                FBMS = 0;
                FBDS = true;
                Between = 0;
                FBD = true;
                FBM = 0;
                RocketD = true;

                BetweenPic.Location = new Point(-306, 92);
                FBScutPic.Size = new Size(100, FBScutPic.Height);
                ViataFBPic.Size = new Size(100, ViataFBPic.Height);
                GratsPic.Visible = false;

                while (Gloante.Count > 0)
                {
                    Gloante[0].Dispose();
                    Gloante.RemoveAt(0);
                }

                while (Enemies.Count > 0)
                {
                    Enemies[0].Dispose();
                    Enemies.RemoveAt(0);
                }

                while (FBGloante.Count > 0)
                {
                    FBGloante[0].Dispose();
                    FBGloante.RemoveAt(0);
                }

                while (Rockets.Count > 0)
                {
                    Rockets[0].Dispose();
                    Rockets.RemoveAt(0);
                }

                SpaceShipPic.Location = new Point(216, 476);
                SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShip;
                SpaceShipPic.Visible = true;

                lblScor.Text = "000000";

                for (int i = 0; i < Lives.Count; i++)
                    Lives[i].Visible = true;

                lblDiff.Text = "1";
                Vieti = 6;
                EnemySpeed = 1;
                SpaceShipSpeed = 3;
                Limitator = 1;
                TimerBadBadThingSpawn.Interval = 1500;
                Scut = false;
                Playing = true;
            }
        }

        private void TimerDifficuly_Tick(object sender, EventArgs e)
        {
            if (TimerBadBadThingSpawn.Interval > 500)
                TimerBadBadThingSpawn.Interval = TimerBadBadThingSpawn.Interval - 250;

            if (Int32.Parse(lblDiff.Text) <= 9)
            {
                EnemySpeed++;
                if (Int32.Parse(lblDiff.Text) <= 7)
                    SpaceShipSpeed++;

                lblDiff.Text = (Int32.Parse(lblDiff.Text) + 1).ToString();

                if (Int32.Parse(lblDiff.Text) == 10)
                {
                    lblDiff.Location = new Point(206, 250);
                    StartFinalBoss();
                }
            }
        }

        private void scoresToFile()
        {
            StreamWriter file = new StreamWriter(@".\Scores.mr");

            for (int i = 0; i < Scoruri.Count; i++)
                file.Write(Scoruri[i] + "\n");

            file.Close();
        }
        private void btnIesire_Click(object sender, EventArgs e)
        {
            scoresToFile();
            Application.Exit();
        }

        private void StartFinalBoss()
        {
            TimerBadBadThingSpawn.Enabled = false;
            TimerBetween.Enabled = true;
        }

        private void FBTrage()
        {
            PictureBox pic = new PictureBox();
            pic.BackColor = Color.Red;

            pic.Width = 7;
            pic.Height = 30;

            pic.Location = new Point(FinalBossPic.Location.X + 82, FinalBossPic.Location.Y + 200);
            pic.BorderStyle = BorderStyle.FixedSingle;

            pic.SendToBack();
            pic.Visible = true;
            
            Controls.Add(pic);
            FBGloante.Add(pic);
        }

        private void TimerFinalBossBeamSpawn_Tick(object sender, EventArgs e)
        {
            Random R = new Random();

            if (BossDiff == 2)
            {
                if (R.Next(1, 100) % 4 == 0)
                    FBTrage();
            }
            else
                if (R.Next(1, 100) % 2 == 0)
                    FBTrage();

        }

        private void TimerFinalBossBeam_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < FBGloante.Count; i++)
            {
                FBGloante[i].Location = new Point(FBGloante[i].Location.X, FBGloante[i].Location.Y + 5);
                if (FBGloante[i].Location.Y > 570)
                {
                    FBGloante[i].Dispose();
                    FBGloante.RemoveAt(i);
                    i--;
                }
            }
        }
        
        private void TimerFBCheck_Tick(object sender, EventArgs e)
        {

            bool ok2 = true;
            for (int i = 0; i < Rockets.Count; i++)
            {

                for (int j = 0; j < Gloante.Count; j++)
                {
                    if (Rockets[i].Location.Y + 90 >= Gloante[j].Location.Y && Rockets[i].Location.X <= Gloante[j].Location.X + 5 && Rockets[i].Location.X + 25 >= Gloante[j].Location.X)
                    {
                        Gloante[j].Dispose();
                        Gloante.RemoveAt(j);
                        Rockets[i].Dispose();
                        Rockets.RemoveAt(i);

                        int score = Int32.Parse(lblScor.Text);
                        score += 75;
                        string S = "";
                        S = score.ToString();

                        while (S.Length < 6)
                            S = "0" + S;

                        lblScor.Text = S;

                        ok2 = false;
                        break;
                    }

                    if (!ok2)
                        break;

                    for (int k = 0; k < FBGloante.Count; k++)
                    {
                        if (Rockets[i].Location.Y + 90 >= FBGloante[k].Location.Y && Rockets[i].Location.Y <= FBGloante[k].Location.Y + 25 && Rockets[i].Location.X <= FBGloante[k].Location.X + 7 && Rockets[i].Location.X + 30 >= FBGloante[k].Location.X)
                        {
                            FBGloante[k].Dispose();
                            FBGloante.RemoveAt(k);
                            ok2 = false;
                            break;
                        }
                    }

                    if (!ok2)
                        break;
                }

                if (!ok2)
                    break;

                if (Rockets[i].Location.Y + 90 >= SpaceShipPic.Location.Y && Rockets[i].Location.Y <= SpaceShipPic.Location.Y + 75 && Rockets[i].Location.X + 25 >= SpaceShipPic.Location.X && Rockets[i].Location.X <= SpaceShipPic.Location.X + 75)
                {
                    if (Scut)
                    {
                        Scut = false;

                        switch (SpaceShip)
                        {
                            case -8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS8; break;
                            case -7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS7; break;
                            case -6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS6; break;
                            case -5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS5; break;
                            case -4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS4; break;
                            case -3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS3; break;
                            case -2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS2; break;
                            case -1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS1; break;
                            case 0: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShip; break;
                            case 1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD1; break;
                            case 2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD2; break;
                            case 3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD3; break;
                            case 4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD4; break;
                            case 5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD5; break;
                            case 6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD6; break;
                            case 7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD7; break;
                            case 8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD8; break;
                        }
                    }
                    else
                    {
                        Vieti--;

                        if (Vieti < 0)
                        {
                            GameOver();
                            break;
                        }
                        else
                            Lives[Vieti].Visible = false;

                    }

                    Rockets[i].Dispose();
                    Rockets.RemoveAt(i);
                    break;
                }
            }

            bool ok = true;

            for (int j = 0; j < FBGloante.Count; j++)
            {
                for (int i = 0; i < Gloante.Count; i++)
                {
                    if (Gloante[i].Location.Y <= FBGloante[j].Location.Y + 30 && Gloante[i].Location.X + 5 >= FBGloante[j].Location.X && Gloante[i].Location.X <= FBGloante[j].Location.X + 7)
                    {
                        int scor = Int32.Parse(lblScor.Text);
                        string S = "";

                        scor += 50;

                        S = scor.ToString();

                        while (S.Length < 6)
                            S = "0" + S;

                        lblScor.Text = S;

                        Gloante[i].Dispose();
                        Gloante.RemoveAt(i);
                        FBGloante[j].Dispose();
                        FBGloante.RemoveAt(j);
                        ok = false;
                        break;
                    }
                }

                if (!ok)
                    break;

                if (SpaceShipPic.Location.Y <= FBGloante[j].Location.Y + 30 && SpaceShipPic.Location.Y + 75 >= FBGloante[j].Location.Y && SpaceShipPic.Location.X <= FBGloante[j].Location.X + 7 && SpaceShipPic.Location.X + 75 >= FBGloante[j].Location.X)
                {
                    if (Scut)
                    {
                        Scut = false;

                        switch (SpaceShip)
                        {
                            case -8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS8; break;
                            case -7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS7; break;
                            case -6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS6; break;
                            case -5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS5; break;
                            case -4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS4; break;
                            case -3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS3; break;
                            case -2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS2; break;
                            case -1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipS1; break;
                            case 0: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShip; break;
                            case 1: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD1; break;
                            case 2: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD2; break;
                            case 3: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD3; break;
                            case 4: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD4; break;
                            case 5: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD5; break;
                            case 6: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD6; break;
                            case 7: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD7; break;
                            case 8: SpaceShipPic.BackgroundImage = MeteorRush.Properties.Resources.SpaceShipD8; break;
                        }
                    }
                    else
                    {
                        Vieti--;

                        if (Vieti < 0)
                        {
                            GameOver();
                            break;
                        }
                        else
                            Lives[Vieti].Visible = false;
                    }
                    FBGloante[j].Dispose();
                    FBGloante.RemoveAt(j);
                    j--;
                }
            }

            for (int i = 0; i < Gloante.Count; i++)
            {
                if (Gloante[i].Location.Y <= FinalBossPic.Location.Y + 170 && Gloante[i].Location.Y + 20 >= FinalBossPic.Location.Y && Gloante[i].Location.X + 5 >= FinalBossPic.Location.X && Gloante[i].Location.X <= FinalBossPic.Location.X + 170)
                {
                    if (FinalBossScut)
                    {

                        if (FBScutPic.Width > 0)
                        {
                            FBScutPic.Size = new Size(FBScutPic.Width - 10, FBScutPic.Height);

                            int score = Int32.Parse(lblScor.Text);
                            score += 250;
                            string S = "";
                            S = score.ToString();

                            while (S.Length < 6)
                                S = "0" + S;

                            lblScor.Text = S;

                            if (FBScutPic.Width <= 1)
                            {
                                FinalBossScut = false;
                                BossDiff = 4;
                                lblDiff.Text = (Int32.Parse(lblDiff.Text) + 1).ToString();
                                FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBoss;
                            }
                        }
                    }
                    else
                    {

                        if (ViataFBPic.Width > 0)
                        {
                            ViataFBPic.Size = new Size(ViataFBPic.Width - 5, ViataFBPic.Height);

                            if (ViataFBPic.Width > 50)
                            {

                                int score = Int32.Parse(lblScor.Text);
                                score += 350;
                                string S = "";
                                S = score.ToString();

                                while (S.Length < 6)
                                    S = "0" + S;

                                lblScor.Text = S;
                            }
                            else
                            {
                                int score = Int32.Parse(lblScor.Text);
                                score += 500;
                                string S = "";
                                S = score.ToString();

                                while (S.Length < 6)
                                    S = "0" + S;

                                lblScor.Text = S;
                            }

                            if (ViataFBPic.Width <= 50 && TimerFinalBossVertical.Enabled == false)
                            {
                                lblDiff.Text = (Int32.Parse(lblDiff.Text) + 1).ToString();
                                TimerFinalBossVertical.Enabled = true;
                            }
                            

                            if (ViataFBPic.Width <= 1)
                            {
                                Final();
                                break;
                            }
                        }

                    }
                    Gloante[i].Dispose();
                    Gloante.RemoveAt(i);
                    break;
                }
            }
        }

        private void Final()
        {
            btnOverStart.Visible = false;
            TimerBadBadThingSpawn.Enabled = false;
            TimerBadBadThingMove.Enabled = false;
            TimerCheck.Enabled = false;
            TimerDifficuly.Enabled = false;
            TimerBeam.Enabled = false;
            TimerFinalBossOrizontal.Enabled = false;
            TimerFinalBossVertical.Enabled = false;
            TimerFinalBossBeam.Enabled = false;
            TimerFinalBossBeamSpawn.Enabled = false;
            TimerFBCheck.Enabled = false;
            TimerBetween.Enabled = false;
            TimerRocketFB.Enabled = false;
            TimerRocketSpawn.Enabled = false;
            LastScene = true;

            int score = Int32.Parse(lblScor.Text);
            score += 25000;
            string S = "";
            S = score.ToString();

            while (S.Length < 6)
                S = "0" + S;

            lblScor.Text = S;

            while (Gloante.Count > 0)
            {
                Gloante[0].Dispose();
                Gloante.RemoveAt(0);
            }

            while (Enemies.Count > 0)
            {
                Enemies[0].Dispose();
                Enemies.RemoveAt(0);
            }

            while (FBGloante.Count > 0)
            {
                FBGloante[0].Dispose();
                FBGloante.RemoveAt(0);
            }

            while (Rockets.Count > 0)
            {
                Rockets[0].Dispose();
                Rockets.RemoveAt(0);
            }

            if (Int32.Parse(lblScor.Text) > Int32.Parse(lblHighScore.Text))
                lblHighScore.Text = lblScor.Text;

            TimerFinal.Enabled = true;
        }

        private void TimerFinalBossOrizontal_Tick(object sender, EventArgs e)
        {
            if (FinalBossPic.Location.Y < 5)
                FinalBossPic.Location = new Point(FinalBossPic.Location.X, FinalBossPic.Location.Y + 1);
            else
            {
                if (TimerFinalBossBeamSpawn.Enabled == false)
                {
                    TimerRocketSpawn.Enabled = true;
                    TimerRocketFB.Enabled = true;
                    TimerFinalBossBeamSpawn.Enabled = true;
                    TimerFinalBossBeam.Enabled = true;
                    TimerFBCheck.Enabled = true;
                }

                Random R = new Random();

                if (FBM == 0)
                {
                    FBM = R.Next(10, 100);
                    if (FBD)
                        FBD = false;
                    else
                        FBD = true;
                }

                if (FBD)
                {

                    if (FinalBossPic.Location.X <= 304)
                    {
                        FinalBossPic.Location = new Point(FinalBossPic.Location.X + BossDiff, FinalBossPic.Location.Y);
                        FBM--;
                    }
                    else
                        FBM = 0;


                }
                else
                    if (FinalBossPic.Location.X >= 5)
                    {
                        FinalBossPic.Location = new Point(FinalBossPic.Location.X - BossDiff, FinalBossPic.Location.Y);
                        FBM--;
                    }
                    else
                        FBM = 0;
            }
        }

        private void TimerFinalBossVertical_Tick(object sender, EventArgs e)
        {
            Random R = new Random();

            if (FBMS == 0)
            {
                FBMS = R.Next(10, 100);
                if (FBDS)
                    FBDS = false;
                else
                    FBDS = true;
            }

            if (FBDS)
            {

                if (FinalBossPic.Location.Y <= 94)
                {
                    FinalBossPic.Location = new Point(FinalBossPic.Location.X, FinalBossPic.Location.Y + BossDiff);
                    FBMS--;
                }
                else
                    FBMS = 0;


            }
            else
                if (FinalBossPic.Location.Y >= 5)
                {
                    FinalBossPic.Location = new Point(FinalBossPic.Location.X, FinalBossPic.Location.Y - BossDiff);
                    FBMS--;
                }
                else
                    FBMS = 0;

        }

        private void TimerBetween_Tick(object sender, EventArgs e)
        {
            if (Between < 80)
            {
                BetweenPic.Location = new Point(BetweenPic.Location.X + 5, BetweenPic.Location.Y);
                Between++;
            }
            else
            if (Between < 90)
            {
                TimerBetween.Interval = 250;
                if (Between % 2 == 0)
                    BetweenPic.BackgroundImage = MeteorRush.Properties.Resources.Between1;
                else
                    BetweenPic.BackgroundImage = MeteorRush.Properties.Resources.Between2;
                Between++;
            }

            if (Between == 90)
            {
                BetweenPic.Visible = false;
                TimerBadBadThingMove.Enabled = false;
                TimerFinalBossOrizontal.Enabled = true;
                TimerBetween.Enabled = false;
            }
           
        }

        private void TimerFinal_Tick(object sender, EventArgs e)
        {
            Random R = new Random();

            if (Between < 180)
            {
                int x = R.Next(1, 100);

                if (x % 4 == 0)
                    FinalBossPic.Location = new Point(FinalBossPic.Location.X + 5, FinalBossPic.Location.Y + 5);
                else
                    if(x%4==1)
                        FinalBossPic.Location = new Point(FinalBossPic.Location.X + 5, FinalBossPic.Location.Y - 5);
                    else
                        if(x%4==2)
                            FinalBossPic.Location = new Point(FinalBossPic.Location.X - 5, FinalBossPic.Location.Y + 5);
                        else
                            FinalBossPic.Location = new Point(FinalBossPic.Location.X - 5, FinalBossPic.Location.Y - 5);
            }
            Between++;
            switch (Between - 179)
            {
                case 1: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF1; TimerFinal.Interval = 45; break;
                case 2: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF2; break;
                case 3: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF3; break;
                case 4: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF4; break;
                case 5: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF5; break;
                case 6: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF6; break;
                case 7: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF7; break;
                case 8: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF8; break;
                case 9: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF9; break;
                case 10: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF10; break;
                case 11: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF11; break;
                case 12: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF12; break;
                case 13: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF13; break;
                case 14: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF14; break;
                case 15: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF15; break;
                case 16: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF16; break;
                case 17: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF17; break;
                case 18: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF18; break;
                case 19: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF19; break;
                case 20: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF20; break;
                case 21: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF21; break;
                case 22: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF22; break;
                case 23: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF23; break;
                case 24: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF24; break;
                case 25: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF25; break;
                case 26: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF26; break;
                case 27: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF27; break;
                case 28: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF28; break;
                case 29: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF29; break;
                case 30: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF30; break;
                case 31: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF31; break;
                case 32: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF32; break;
                case 33: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF33; break;
                case 34: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF34; break;
                case 35: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF35; break;
                case 36: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF36; break;
                case 37: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF37; break;
                case 38: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF38; break;
                case 39: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF39; break;
                case 40: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF40; break;
                case 41: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF41; break;
                case 42: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF42; break;
                case 43: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF43; break;
                case 44: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF44; break;
                case 45: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBoss; break;
                case 46: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF45; break;
                case 47: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF46; break;
                case 48: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF47; break;
                case 49: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF48; break;
                case 50: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF49; break;
                case 51: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF50; break;
                case 52: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF51; break;
                case 53: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF52; break;
                case 54: FinalBossPic.BackgroundImage = MeteorRush.Properties.Resources.FinalBossF53; break;
                case 55: FinalBossPic.Visible = false; break;
                
            }
            if (Between == 270)
            {
                TimerDreapta.Enabled = false;
                TimerStanga.Enabled = false;
                TimerRelease.Enabled = false;
                GratsPic.Visible = true;
                TimerFinal.Enabled = false;

                btnScoruri.Enabled = true;
                txtName.Enabled = true;
                btnDespre.Enabled = true;
                btnReset.Enabled = true;
                btnInstructiuni.Enabled = true;

                Playing = false;
                btnOverStart.Visible = false;

                Scoruri.Add(txtName.Text + "," + lblScor.Text);
                Sorteaza();
                scoresToFile();
            }
        }

        private void Sorteaza()
        {
            for(int i = 0; i <Scoruri.Count;i++)
                for (int j = 0; j < Scoruri.Count - 1; j++)
                {
                    if (Int32.Parse(Scoruri[j].Split(',')[1]) < Int32.Parse(Scoruri[j + 1].Split(',')[1]))
                    {
                        string x = Scoruri[j];
                        Scoruri[j] = Scoruri[j + 1];
                        Scoruri[j + 1] = x;
                    }
                }

            while (Scoruri.Count > 10)
                Scoruri.RemoveAt(Scoruri.Count - 1);
        }

        private void btnInstructiuni_Click(object sender, EventArgs e)
        {
            Instructions f = new Instructions();

            f.ShowDialog();
        }

        private void btnDespre_Click(object sender, EventArgs e)
        {
            Despre f = new Despre();

            f.ShowDialog();
        }

        private void TimerRocketSpawn_Tick(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic.BackgroundImage = MeteorRush.Properties.Resources.Rocket;
            pic.BackgroundImageLayout = ImageLayout.None;
            pic.Width = 25;
            pic.Height = 90;

            if (RocketD)
            {
                pic.Location = new Point(FinalBossPic.Location.X + 20, FinalBossPic.Location.Y + 170);
                TimerRocketSpawn.Interval = 1500;
                RocketD = false;
            }
            else
            {
                pic.Location = new Point(FinalBossPic.Location.X + 115, FinalBossPic.Location.Y + 170);
                TimerRocketSpawn.Interval = 6000;
                RocketD = true;
            }

            pic.BringToFront();
            pic.Visible = true;

            Controls.Add(pic);
            Rockets.Add(pic);
        }

        private void TimerRocketFB_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Rockets.Count; i++)
            {
                Rockets[i].Location = new Point(Rockets[i].Location.X, Rockets[i].Location.Y + 8);

                for (int j = 0; j < FBGloante.Count; j++)
                    FBGloante[j].SendToBack();

                if (Rockets[i].Location.Y >= 570)
                {
                    Rockets[i].Dispose();
                    Rockets.RemoveAt(i);
                    i--;
                }
            }
        }

        private void btnScoruri_Click(object sender, EventArgs e)
        {
            Scores f = new Scores(Scoruri);
            f.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to erase all the scores? This action cannot be undone!", "WARNING!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Scoruri.Clear();
                lblHighScore.Text = "000000";
            }
        }
    }
}
