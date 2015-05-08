using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontTapTheWhiteTiles
{
    public partial class NewGame : Form
    {

        private Timer timer;
        private GAME_TYPE gameType;
        private int counter;
        private int seconds;
        private int tiles;
        private Leaderboard leaderBoard;
        public  FirstForm firstForm { get; set; }
        public bool music { get; set; }
        private Stopwatch stopwatch;
        private String[] sounds = { "piano1.wav", "piano2.wav", "piano3.wav", "piano4.wav", "piano5.wav", "piano6.wav", "piano7.wav" };
        private Random random;

        public enum GAME_TYPE
        {
            TIMER_GAME,
            TILES_GAME
        }

        public NewGame(int seconds, int tiles, GAME_TYPE gameType)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.gameType = gameType;
            this.tiles = tiles;
            this.seconds = seconds;
            counter = 0;
            leaderBoard = new Leaderboard();
            stopwatch = new Stopwatch();
            random = new Random();

            if (gameType == GAME_TYPE.TIMER_GAME)
            {
                timer = new Timer();
                timer.Interval = seconds * 1000;
                timer.Tick += timer_Tick;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            gameOver();
        }

        private void checkIsGameFinished()
        {
            if (counter >= tiles)
            {
                gameOver();
            }
        }

        private void gameOver()
        {
            EnterNameAndSurname form = new EnterNameAndSurname();

            if (gameType == GAME_TYPE.TIMER_GAME)
            {
                timer.Stop();
                
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (seconds == 60)
                    {
                        leaderBoard.checkScoreFor1MinGame(new Player_Time(form.Name, form.Surname, counter));
                    }
                    else if (seconds == 30)
                    {
                        leaderBoard.checkScoreFor30SecGame(new Player_Time(form.Name, form.Surname, counter));
                    }
                }
                
            }
            else if (gameType == GAME_TYPE.TILES_GAME)
            {
                stopwatch.Stop();
                seconds = Convert.ToInt32(stopwatch.ElapsedMilliseconds) / 1000;

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (tiles == 100)
                    {
                        leaderBoard.checkScoreFor100TilesGame(new Player_Tiles(form.Name, form.Surname, seconds));
                    }
                    else if (tiles == 300)
                    {
                        leaderBoard.checkScoreFor300TilesGame(new Player_Tiles(form.Name, form.Surname, seconds));
                    }
                }
            }

            String str = "Congratulations "+ form.Name + " " + form.Surname + " you have completed the game.\nYou hit " + counter + " black tiles for " + seconds + " sec.";
            DialogResult result = MessageBox.Show(str, "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                firstForm.Show();
            }
        }

        private void playSound()
        {
            if (music)
            {
                int x = random.Next(6);
                (new SoundPlayer(@sounds[x])).Play();
            }
        }

        private void btnBlack1_Click(object sender, EventArgs e)
        {
            playSound();
            counter++;
            if (gameType == GAME_TYPE.TILES_GAME)
            {
                checkIsGameFinished();
            }

            btnWhite1.Location = new Point(btnWhite1.Left, btnWhite1.Top + 116);
            btnWhite2.Location = new Point(btnWhite2.Left, btnWhite2.Top + 116);
            btnWhite3.Location = new Point(btnWhite3.Left, btnWhite3.Top + 116);
            btnWhite4.Location = new Point(btnWhite4.Left, btnWhite4.Top + 116);
            btnWhite5.Location = new Point(btnWhite5.Left, btnWhite5.Top + 116);
            btnWhite6.Location = new Point(btnWhite6.Left, btnWhite6.Top + 116);
            btnWhite7.Location = new Point(btnWhite7.Left, btnWhite7.Top + 116);
            btnWhite8.Location = new Point(btnWhite8.Left, btnWhite8.Top + 116);
            btnWhite9.Location = new Point(btnWhite9.Left, btnWhite9.Top + 116);
            btnWhite10.Location = new Point(btnWhite10.Left, btnWhite10.Top + 116);
            btnWhite11.Location = new Point(btnWhite11.Left, btnWhite11.Top + 116);
            btnWhite12.Location = new Point(btnWhite12.Left, btnWhite12.Top + 116);
            btnWhite13.Location = new Point(btnWhite13.Left, btnWhite13.Top + 116);
            btnWhite14.Location = new Point(btnWhite14.Left, btnWhite14.Top + 116);
            btnWhite15.Location = new Point(btnWhite15.Left, btnWhite15.Top + 116);

            btnBlack1.Location = new Point(btnBlack1.Left, btnBlack1.Top + 116);
            btnBlack2.Location = new Point(btnBlack2.Left, btnBlack2.Top + 116);
            btnBlack3.Location = new Point(btnBlack3.Left, btnBlack3.Top + 116);
            btnBlack4.Location = new Point(btnBlack4.Left, btnBlack4.Top + 116);
            btnBlack5.Location = new Point(btnBlack5.Left, btnBlack5.Top + 116);

            if (btnBlack1.Location.Y >= 521)
            {
                btnBlack1.Location = new Point(btnBlack1.Left, 0);
                btnWhite1.Location = new Point(btnWhite1.Left, 0);
                btnWhite2.Location = new Point(btnWhite2.Left, 0);
                btnWhite3.Location = new Point(btnWhite3.Left, 0);
                RandomPlaceForBlackButtonForRowOne();
            }
            if (btnBlack2.Location.Y >= 521)
            {
                btnBlack2.Location = new Point(btnBlack2.Left, 0);
                btnWhite4.Location = new Point(btnWhite4.Left, 0);
                btnWhite5.Location = new Point(btnWhite5.Left, 0);
                btnWhite6.Location = new Point(btnWhite6.Left, 0);
                RandomPlaceForBlackButtonForRowTwo();
            }
            if (btnBlack3.Location.Y >= 521)
            {
                btnBlack3.Location = new Point(btnBlack3.Left, 0);
                btnWhite7.Location = new Point(btnWhite7.Left, 0);
                btnWhite8.Location = new Point(btnWhite8.Left, 0);
                btnWhite9.Location = new Point(btnWhite9.Left, 0);
                RandomPlaceForBlackButtonForRowThree();
            }
            if (btnBlack4.Location.Y >= 521)
            {
                btnBlack4.Location = new Point(btnBlack4.Left, 0);
                btnWhite10.Location = new Point(btnWhite10.Left, 0);
                btnWhite11.Location = new Point(btnWhite11.Left, 0);
                btnWhite12.Location = new Point(btnWhite12.Left, 0);
                RandomPlaceForBlackButtonForRowFour();
            }
            if (btnBlack5.Location.Y >= 521)
            {
                btnBlack5.Location = new Point(btnBlack5.Left, 0);
                btnWhite13.Location = new Point(btnWhite13.Left, 0);
                btnWhite14.Location = new Point(btnWhite14.Left, 0);
                btnWhite15.Location = new Point(btnWhite15.Left, 0);
                RandomPlaceForBlackButtonForRowFive();
            }
        }

        

        private void btnBlack4_Click(object sender, EventArgs e)
        {
            playSound();
            counter++;
            if (gameType == GAME_TYPE.TILES_GAME)
            {
                checkIsGameFinished();
            }

            btnWhite1.Location = new Point(btnWhite1.Left, btnWhite1.Top + 116);
            btnWhite2.Location = new Point(btnWhite2.Left, btnWhite2.Top + 116);
            btnWhite3.Location = new Point(btnWhite3.Left, btnWhite3.Top + 116);
            btnWhite4.Location = new Point(btnWhite4.Left, btnWhite4.Top + 116);
            btnWhite5.Location = new Point(btnWhite5.Left, btnWhite5.Top + 116);
            btnWhite6.Location = new Point(btnWhite6.Left, btnWhite6.Top + 116);
            btnWhite7.Location = new Point(btnWhite7.Left, btnWhite7.Top + 116);
            btnWhite8.Location = new Point(btnWhite8.Left, btnWhite8.Top + 116);
            btnWhite9.Location = new Point(btnWhite9.Left, btnWhite9.Top + 116);
            btnWhite10.Location = new Point(btnWhite10.Left, btnWhite10.Top + 116);
            btnWhite11.Location = new Point(btnWhite11.Left, btnWhite11.Top + 116);
            btnWhite12.Location = new Point(btnWhite12.Left, btnWhite12.Top + 116);
            btnWhite13.Location = new Point(btnWhite13.Left, btnWhite13.Top + 116);
            btnWhite14.Location = new Point(btnWhite14.Left, btnWhite14.Top + 116);
            btnWhite15.Location = new Point(btnWhite15.Left, btnWhite15.Top + 116);

            btnBlack1.Location = new Point(btnBlack1.Left, btnBlack1.Top + 116);
            btnBlack2.Location = new Point(btnBlack2.Left, btnBlack2.Top + 116);
            btnBlack3.Location = new Point(btnBlack3.Left, btnBlack3.Top + 116);
            btnBlack4.Location = new Point(btnBlack4.Left, btnBlack4.Top + 116);
            btnBlack5.Location = new Point(btnBlack5.Left, btnBlack5.Top + 116);

            if (btnBlack1.Location.Y >= 521)
            {
                btnBlack1.Location = new Point(btnBlack1.Left, 0);
                btnWhite1.Location = new Point(btnWhite1.Left, 0);
                btnWhite2.Location = new Point(btnWhite2.Left, 0);
                btnWhite3.Location = new Point(btnWhite3.Left, 0);
                RandomPlaceForBlackButtonForRowOne();
            }
            if (btnBlack2.Location.Y >= 521)
            {
                btnBlack2.Location = new Point(btnBlack2.Left, 0);
                btnWhite4.Location = new Point(btnWhite4.Left, 0);
                btnWhite5.Location = new Point(btnWhite5.Left, 0);
                btnWhite6.Location = new Point(btnWhite6.Left, 0);
                RandomPlaceForBlackButtonForRowTwo();
            }
            if (btnBlack3.Location.Y >= 521)
            {
                btnBlack3.Location = new Point(btnBlack3.Left, 0);
                btnWhite7.Location = new Point(btnWhite7.Left, 0);
                btnWhite8.Location = new Point(btnWhite8.Left, 0);
                btnWhite9.Location = new Point(btnWhite9.Left, 0);
                RandomPlaceForBlackButtonForRowThree();
            }
            if (btnBlack4.Location.Y >= 521)
            {
                btnBlack4.Location = new Point(btnBlack4.Left, 0);
                btnWhite10.Location = new Point(btnWhite10.Left, 0);
                btnWhite11.Location = new Point(btnWhite11.Left, 0);
                btnWhite12.Location = new Point(btnWhite12.Left, 0);
                RandomPlaceForBlackButtonForRowFour();
            }
            if (btnBlack5.Location.Y >= 521)
            {
                btnBlack5.Location = new Point(btnBlack5.Left, 0);
                btnWhite13.Location = new Point(btnWhite13.Left, 0);
                btnWhite14.Location = new Point(btnWhite14.Left, 0);
                btnWhite15.Location = new Point(btnWhite15.Left, 0);
                RandomPlaceForBlackButtonForRowFive();
            }
        }

        private void btnBlack5_Click(object sender, EventArgs e)
        {
            playSound();
            counter++;
            if (gameType == GAME_TYPE.TILES_GAME)
            {
                stopwatch.Start();
                checkIsGameFinished();
            }
            else if (gameType == GAME_TYPE.TIMER_GAME)
            {
                timer.Start();
            }

            btnBlack5.Text = "";
            btnBlack1.Enabled = true;
            btnBlack2.Enabled = true;
            btnBlack3.Enabled = true;
            btnBlack4.Enabled = true;

            btnWhite1.Location = new Point(btnWhite1.Left, btnWhite1.Top + 116);
            btnWhite2.Location = new Point(btnWhite2.Left, btnWhite2.Top + 116);
            btnWhite3.Location = new Point(btnWhite3.Left, btnWhite3.Top + 116);
            btnWhite4.Location = new Point(btnWhite4.Left, btnWhite4.Top + 116);
            btnWhite5.Location = new Point(btnWhite5.Left, btnWhite5.Top + 116);
            btnWhite6.Location = new Point(btnWhite6.Left, btnWhite6.Top + 116);
            btnWhite7.Location = new Point(btnWhite7.Left, btnWhite7.Top + 116);
            btnWhite8.Location = new Point(btnWhite8.Left, btnWhite8.Top + 116);
            btnWhite9.Location = new Point(btnWhite9.Left, btnWhite9.Top + 116);
            btnWhite10.Location = new Point(btnWhite10.Left, btnWhite10.Top + 116);
            btnWhite11.Location = new Point(btnWhite11.Left, btnWhite11.Top + 116);
            btnWhite12.Location = new Point(btnWhite12.Left, btnWhite12.Top + 116);
            btnWhite13.Location = new Point(btnWhite13.Left, btnWhite13.Top + 116);
            btnWhite14.Location = new Point(btnWhite14.Left, btnWhite14.Top + 116);
            btnWhite15.Location = new Point(btnWhite15.Left, btnWhite15.Top + 116);

            btnBlack1.Location = new Point(btnBlack1.Left, btnBlack1.Top + 116);
            btnBlack2.Location = new Point(btnBlack2.Left, btnBlack2.Top + 116);
            btnBlack3.Location = new Point(btnBlack3.Left, btnBlack3.Top + 116);
            btnBlack4.Location = new Point(btnBlack4.Left, btnBlack4.Top + 116);
            btnBlack5.Location = new Point(btnBlack5.Left, btnBlack5.Top + 116);

            if (btnBlack1.Location.Y >= 521)
            {
                btnBlack1.Location = new Point(btnBlack1.Left, 0);
                btnWhite1.Location = new Point(btnWhite1.Left, 0);
                btnWhite2.Location = new Point(btnWhite2.Left, 0);
                btnWhite3.Location = new Point(btnWhite3.Left, 0);
                RandomPlaceForBlackButtonForRowOne();
            }
            if (btnBlack2.Location.Y >= 521)
            {
                btnBlack2.Location = new Point(btnBlack2.Left, 0);
                btnWhite4.Location = new Point(btnWhite4.Left, 0);
                btnWhite5.Location = new Point(btnWhite5.Left, 0);
                btnWhite6.Location = new Point(btnWhite6.Left, 0);
                RandomPlaceForBlackButtonForRowTwo();
            }
            if (btnBlack3.Location.Y >= 521)
            {
                btnBlack3.Location = new Point(btnBlack3.Left, 0);
                btnWhite7.Location = new Point(btnWhite7.Left, 0);
                btnWhite8.Location = new Point(btnWhite8.Left, 0);
                btnWhite9.Location = new Point(btnWhite9.Left, 0);
                RandomPlaceForBlackButtonForRowThree();
            }
            if (btnBlack4.Location.Y >= 521)
            {
                btnBlack4.Location = new Point(btnBlack4.Left, 0);
                btnWhite10.Location = new Point(btnWhite10.Left, 0);
                btnWhite11.Location = new Point(btnWhite11.Left, 0);
                btnWhite12.Location = new Point(btnWhite12.Left, 0);
                RandomPlaceForBlackButtonForRowFour();
            }
            if (btnBlack5.Location.Y >= 521)
            {
                btnBlack5.Location = new Point(btnBlack5.Left, 0);
                btnWhite13.Location = new Point(btnWhite13.Left, 0);
                btnWhite14.Location = new Point(btnWhite14.Left, 0);
                btnWhite15.Location = new Point(btnWhite15.Left, 0);
                RandomPlaceForBlackButtonForRowFive();
            }
        }

        private void btnBlack3_Click(object sender, EventArgs e)
        {
            playSound();
            counter++;
            if (gameType == GAME_TYPE.TILES_GAME)
            {
                checkIsGameFinished();
            }

            btnWhite1.Location = new Point(btnWhite1.Left, btnWhite1.Top + 116);
            btnWhite2.Location = new Point(btnWhite2.Left, btnWhite2.Top + 116);
            btnWhite3.Location = new Point(btnWhite3.Left, btnWhite3.Top + 116);
            btnWhite4.Location = new Point(btnWhite4.Left, btnWhite4.Top + 116);
            btnWhite5.Location = new Point(btnWhite5.Left, btnWhite5.Top + 116);
            btnWhite6.Location = new Point(btnWhite6.Left, btnWhite6.Top + 116);
            btnWhite7.Location = new Point(btnWhite7.Left, btnWhite7.Top + 116);
            btnWhite8.Location = new Point(btnWhite8.Left, btnWhite8.Top + 116);
            btnWhite9.Location = new Point(btnWhite9.Left, btnWhite9.Top + 116);
            btnWhite10.Location = new Point(btnWhite10.Left, btnWhite10.Top + 116);
            btnWhite11.Location = new Point(btnWhite11.Left, btnWhite11.Top + 116);
            btnWhite12.Location = new Point(btnWhite12.Left, btnWhite12.Top + 116);
            btnWhite13.Location = new Point(btnWhite13.Left, btnWhite13.Top + 116);
            btnWhite14.Location = new Point(btnWhite14.Left, btnWhite14.Top + 116);
            btnWhite15.Location = new Point(btnWhite15.Left, btnWhite15.Top + 116);

            btnBlack1.Location = new Point(btnBlack1.Left, btnBlack1.Top + 116);
            btnBlack2.Location = new Point(btnBlack2.Left, btnBlack2.Top + 116);
            btnBlack3.Location = new Point(btnBlack3.Left, btnBlack3.Top + 116);
            btnBlack4.Location = new Point(btnBlack4.Left, btnBlack4.Top + 116);
            btnBlack5.Location = new Point(btnBlack5.Left, btnBlack5.Top + 116);

            if (btnBlack1.Location.Y >= 521)
            {
                btnBlack1.Location = new Point(btnBlack1.Left, 0);
                btnWhite1.Location = new Point(btnWhite1.Left, 0);
                btnWhite2.Location = new Point(btnWhite2.Left, 0);
                btnWhite3.Location = new Point(btnWhite3.Left, 0);
                RandomPlaceForBlackButtonForRowOne();
            }
            if (btnBlack2.Location.Y >= 521)
            {
                btnBlack2.Location = new Point(btnBlack2.Left, 0);
                btnWhite4.Location = new Point(btnWhite4.Left, 0);
                btnWhite5.Location = new Point(btnWhite5.Left, 0);
                btnWhite6.Location = new Point(btnWhite6.Left, 0);
                RandomPlaceForBlackButtonForRowTwo();
            }
            if (btnBlack3.Location.Y >= 521)
            {
                btnBlack3.Location = new Point(btnBlack3.Left, 0);
                btnWhite7.Location = new Point(btnWhite7.Left, 0);
                btnWhite8.Location = new Point(btnWhite8.Left, 0);
                btnWhite9.Location = new Point(btnWhite9.Left, 0);
                RandomPlaceForBlackButtonForRowThree();
            }
            if (btnBlack4.Location.Y >= 521)
            {
                btnBlack4.Location = new Point(btnBlack4.Left, 0);
                btnWhite10.Location = new Point(btnWhite10.Left, 0);
                btnWhite11.Location = new Point(btnWhite11.Left, 0);
                btnWhite12.Location = new Point(btnWhite12.Left, 0);
                RandomPlaceForBlackButtonForRowFour();
            }
            if (btnBlack5.Location.Y >= 521)
            {
                btnBlack5.Location = new Point(btnBlack5.Left, 0);
                btnWhite13.Location = new Point(btnWhite13.Left, 0);
                btnWhite14.Location = new Point(btnWhite14.Left, 0);
                btnWhite15.Location = new Point(btnWhite15.Left, 0);
                RandomPlaceForBlackButtonForRowFive();
            }
        }

        private void btnBlack2_Click(object sender, EventArgs e)
        {
            playSound();
            counter++;
            if (gameType == GAME_TYPE.TILES_GAME)
            {
                checkIsGameFinished();
            }

            btnWhite1.Location = new Point(btnWhite1.Left, btnWhite1.Top + 116);
            btnWhite2.Location = new Point(btnWhite2.Left, btnWhite2.Top + 116);
            btnWhite3.Location = new Point(btnWhite3.Left, btnWhite3.Top + 116);
            btnWhite4.Location = new Point(btnWhite4.Left, btnWhite4.Top + 116);
            btnWhite5.Location = new Point(btnWhite5.Left, btnWhite5.Top + 116);
            btnWhite6.Location = new Point(btnWhite6.Left, btnWhite6.Top + 116);
            btnWhite7.Location = new Point(btnWhite7.Left, btnWhite7.Top + 116);
            btnWhite8.Location = new Point(btnWhite8.Left, btnWhite8.Top + 116);
            btnWhite9.Location = new Point(btnWhite9.Left, btnWhite9.Top + 116);
            btnWhite10.Location = new Point(btnWhite10.Left, btnWhite10.Top + 116);
            btnWhite11.Location = new Point(btnWhite11.Left, btnWhite11.Top + 116);
            btnWhite12.Location = new Point(btnWhite12.Left, btnWhite12.Top + 116);
            btnWhite13.Location = new Point(btnWhite13.Left, btnWhite13.Top + 116);
            btnWhite14.Location = new Point(btnWhite14.Left, btnWhite14.Top + 116);
            btnWhite15.Location = new Point(btnWhite15.Left, btnWhite15.Top + 116);

            btnBlack1.Location = new Point(btnBlack1.Left, btnBlack1.Top + 116);
            btnBlack2.Location = new Point(btnBlack2.Left, btnBlack2.Top + 116);
            btnBlack3.Location = new Point(btnBlack3.Left, btnBlack3.Top + 116);
            btnBlack4.Location = new Point(btnBlack4.Left, btnBlack4.Top + 116);
            btnBlack5.Location = new Point(btnBlack5.Left, btnBlack5.Top + 116);

            if (btnBlack1.Location.Y >= 521)
            {
                btnBlack1.Location = new Point(btnBlack1.Left, 0);
                btnWhite1.Location = new Point(btnWhite1.Left, 0);
                btnWhite2.Location = new Point(btnWhite2.Left, 0);
                btnWhite3.Location = new Point(btnWhite3.Left, 0);
                RandomPlaceForBlackButtonForRowOne();
            }
            if (btnBlack2.Location.Y >= 521)
            {
                btnBlack2.Location = new Point(btnBlack2.Left, 0);
                btnWhite4.Location = new Point(btnWhite4.Left, 0);
                btnWhite5.Location = new Point(btnWhite5.Left, 0);
                btnWhite6.Location = new Point(btnWhite6.Left, 0);
                RandomPlaceForBlackButtonForRowTwo();
            }
            if (btnBlack3.Location.Y >= 521)
            {
                btnBlack3.Location = new Point(btnBlack3.Left, 0);
                btnWhite7.Location = new Point(btnWhite7.Left, 0);
                btnWhite8.Location = new Point(btnWhite8.Left, 0);
                btnWhite9.Location = new Point(btnWhite9.Left, 0);
                RandomPlaceForBlackButtonForRowThree();
            }
            if (btnBlack4.Location.Y >= 521)
            {
                btnBlack4.Location = new Point(btnBlack4.Left, 0);
                btnWhite10.Location = new Point(btnWhite10.Left, 0);
                btnWhite11.Location = new Point(btnWhite11.Left, 0);
                btnWhite12.Location = new Point(btnWhite12.Left, 0);
                RandomPlaceForBlackButtonForRowFour();
            }
            if (btnBlack5.Location.Y >= 521)
            {
                btnBlack5.Location = new Point(btnBlack5.Left, 0);
                btnWhite13.Location = new Point(btnWhite13.Left, 0);
                btnWhite14.Location = new Point(btnWhite14.Left, 0);
                btnWhite15.Location = new Point(btnWhite15.Left, 0);
                RandomPlaceForBlackButtonForRowFive();
            }
        }

        private void RandomPlaceForBlackButtonForRowOne(){

            //Random random = new Random(); 
            int place = random.Next(4);
            
            if (place == 0)
            {
                btnBlack1.Location = new Point(0, btnBlack1.Top);
                btnWhite1.Location = new Point(100, btnWhite1.Top);
                btnWhite2.Location = new Point(200, btnWhite2.Top);
                btnWhite3.Location = new Point(300, btnWhite3.Top);
            }
            if (place == 1)
            {
                btnBlack1.Location = new Point(100, btnBlack1.Top);
                btnWhite1.Location = new Point(0, btnWhite1.Top);
                btnWhite2.Location = new Point(200, btnWhite2.Top);
                btnWhite3.Location = new Point(300, btnWhite3.Top);
            }
            if (place == 2)
            {
                btnBlack1.Location = new Point(200, btnBlack1.Top);
                btnWhite1.Location = new Point(100, btnWhite1.Top);
                btnWhite2.Location = new Point(0, btnWhite2.Top);
                btnWhite3.Location = new Point(300, btnWhite3.Top);
            }
            if (place == 3)
            {
                btnBlack1.Location = new Point(300, btnBlack1.Top);
                btnWhite1.Location = new Point(100, btnWhite1.Top);
                btnWhite2.Location = new Point(200, btnWhite2.Top);
                btnWhite3.Location = new Point(0, btnWhite3.Top);
            }
            
        }

        private void RandomPlaceForBlackButtonForRowTwo()
        {
            //Random random = new Random(); 
            int place = random.Next(4);

            if (place == 0)
            {
                btnBlack2.Location = new Point(0, btnBlack2.Top);
                btnWhite4.Location = new Point(100, btnWhite4.Top);
                btnWhite5.Location = new Point(200, btnWhite5.Top);
                btnWhite6.Location = new Point(300, btnWhite6.Top);
            }
            if (place == 1)
            {
                btnBlack2.Location = new Point(100, btnBlack2.Top);
                btnWhite4.Location = new Point(0, btnWhite4.Top);
                btnWhite5.Location = new Point(200, btnWhite5.Top);
                btnWhite6.Location = new Point(300, btnWhite6.Top);
            }
            if (place == 2)
            {
                btnBlack2.Location = new Point(200, btnBlack2.Top);
                btnWhite4.Location = new Point(100, btnWhite4.Top);
                btnWhite5.Location = new Point(0, btnWhite5.Top);
                btnWhite6.Location = new Point(300, btnWhite6.Top);
            }
            if (place == 3)
            {
                btnBlack2.Location = new Point(300, btnBlack2.Top);
                btnWhite4.Location = new Point(100, btnWhite4.Top);
                btnWhite5.Location = new Point(200, btnWhite5.Top);
                btnWhite6.Location = new Point(0, btnWhite6.Top);
            }

        }

        private void RandomPlaceForBlackButtonForRowThree()
        {

            //Random random = new Random();
            int place = random.Next(4);

            if (place == 0)
            {
                btnBlack3.Location = new Point(0, btnBlack3.Top);
                btnWhite7.Location = new Point(100, btnWhite7.Top);
                btnWhite8.Location = new Point(200, btnWhite8.Top);
                btnWhite9.Location = new Point(300, btnWhite9.Top);
            }
            if (place == 1)
            {
                btnBlack3.Location = new Point(100, btnBlack3.Top);
                btnWhite7.Location = new Point(0, btnWhite7.Top);
                btnWhite8.Location = new Point(200, btnWhite8.Top);
                btnWhite9.Location = new Point(300, btnWhite9.Top);
            }
            if (place == 2)
            {
                btnBlack3.Location = new Point(200, btnBlack3.Top);
                btnWhite7.Location = new Point(100, btnWhite7.Top);
                btnWhite8.Location = new Point(0, btnWhite8.Top);
                btnWhite9.Location = new Point(300, btnWhite9.Top);
            }
            if (place == 3)
            {
                btnBlack3.Location = new Point(300, btnBlack3.Top);
                btnWhite7.Location = new Point(100, btnWhite7.Top);
                btnWhite8.Location = new Point(200, btnWhite8.Top);
                btnWhite9.Location = new Point(0, btnWhite9.Top);
            }

        }

        private void RandomPlaceForBlackButtonForRowFour()
        {
            //Random random = new Random();
            int place = random.Next(4);

            if (place == 0)
            {
                btnBlack4.Location = new Point(0, btnBlack4.Top);
                btnWhite10.Location = new Point(100, btnWhite10.Top);
                btnWhite11.Location = new Point(200, btnWhite11.Top);
                btnWhite12.Location = new Point(300, btnWhite12.Top);
            }
            if (place == 1)
            {
                btnBlack4.Location = new Point(100, btnBlack4.Top);
                btnWhite10.Location = new Point(0, btnWhite10.Top);
                btnWhite11.Location = new Point(200, btnWhite11.Top);
                btnWhite12.Location = new Point(300, btnWhite12.Top);
            }
            if (place == 2)
            {
                btnBlack4.Location = new Point(200, btnBlack4.Top);
                btnWhite10.Location = new Point(100, btnWhite10.Top);
                btnWhite11.Location = new Point(0, btnWhite11.Top);
                btnWhite12.Location = new Point(300, btnWhite12.Top);
            }
            if (place == 3)
            {
                btnBlack4.Location = new Point(300, btnBlack4.Top);
                btnWhite10.Location = new Point(100, btnWhite10.Top);
                btnWhite11.Location = new Point(200, btnWhite11.Top);
                btnWhite12.Location = new Point(0, btnWhite12.Top);
            }

        }

        private void RandomPlaceForBlackButtonForRowFive()
        {
            //Random random = new Random(); 
            int place = random.Next(4);

            if (place == 0)
            {
                btnBlack5.Location = new Point(0, btnBlack5.Top);
                btnWhite13.Location = new Point(100, btnWhite13.Top);
                btnWhite14.Location = new Point(200, btnWhite14.Top);
                btnWhite15.Location = new Point(300, btnWhite15.Top);
            }
            if (place == 1)
            {
                btnBlack5.Location = new Point(100, btnBlack5.Top);
                btnWhite13.Location = new Point(0, btnWhite13.Top);
                btnWhite14.Location = new Point(200, btnWhite14.Top);
                btnWhite15.Location = new Point(300, btnWhite15.Top);
            }
            if (place == 2)
            {
                btnBlack5.Location = new Point(200, btnBlack5.Top);
                btnWhite13.Location = new Point(100, btnWhite13.Top);
                btnWhite14.Location = new Point(0, btnWhite14.Top);
                btnWhite15.Location = new Point(300, btnWhite15.Top);
            }
            if (place == 3)
            {
                btnBlack5.Location = new Point(300, btnBlack5.Top);
                btnWhite13.Location = new Point(100, btnWhite13.Top);
                btnWhite14.Location = new Point(200, btnWhite14.Top);
                btnWhite15.Location = new Point(0, btnWhite15.Top);
            }

        }

        private void youLose(object sender, EventArgs e)
        {
            if (music)
            {
                (new SoundPlayer(@"youLose.wav")).Play();
            }

            if (gameType == GAME_TYPE.TIMER_GAME)
            {
                timer.Stop();
            }
            else if (gameType == GAME_TYPE.TILES_GAME)
            {
                stopwatch.Stop();
                seconds = Convert.ToInt32(stopwatch.ElapsedMilliseconds) / 1000;
            }

            String str = "Game over! YOU DIDN'T COMPLETE THE GAME\n" + "You hit " + counter + " black tiles for " + seconds + " sec.";
            DialogResult result = MessageBox.Show(str, "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                firstForm.Show();
            }
        }

    }
}
