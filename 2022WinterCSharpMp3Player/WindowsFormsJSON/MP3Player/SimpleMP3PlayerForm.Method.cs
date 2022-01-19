using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3Player
{
    public partial class SimpleMP3PlayerForm : Form
    {
        MP3Player mp3Player;
        bool isScrolled = false;
        int trackBarBlankSize = 10;
        int trackBarLength = 0;
        int trackBarMouseX = 0;


        public void MP3Method()
        {
            btnOpen.Click += BtnOpen_Click;
            btnPlay.Click += BtnPlay_Click;
            btnPause.Click += BtnPause_Click;
            btnStop.Click += BtnStop_Click;
            mp3Timer.Tick += Mp3Timer_Tick;
            playerTrackBar.MouseDown += PlayerTrackBar_MouseDown;
            playerTrackBar.MouseMove += PlayerTrackBar_MouseMove;
            playerTrackBar.MouseUp += PlayerTrackBar_MouseUp;

            mp3Player = new MP3Player();
            trackBarLength = playerTrackBar.Size.Width - (trackBarBlankSize * 2);
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            Console.WriteLine("#파일 열기 버튼 클릭");
            openFileDialog.Filter = "*.*|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mp3Player.Open(openFileDialog.FileName);                
                lbTitle.Text = Path.GetFileName(openFileDialog.FileName);
                playerTrackBar.Maximum = mp3Player.GetLength();
                mp3Timer.Enabled = true;
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Console.WriteLine("#재생 버튼 클릭");
            mp3Player.Play();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            Console.WriteLine("#중지 버튼 클릭");
            mp3Player.Pause();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Console.WriteLine("#종료 버튼 클릭");
            mp3Player.Stop();
        }

        private void Mp3Timer_Tick(object sender, EventArgs e)
        {
            if (!mp3Player.isOpened)
            {
                return;
            }

            if (isScrolled == false)
            {
                playerTrackBar.Value = mp3Player.GetPosition();
            }

            if (!mp3Player.loop && mp3Player.GetPosition() == mp3Player.GetLength())
            {
                mp3Player.Stop();
            }

            setMusicTimer();
        }

        private void PlayerTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("PlayerTrackBar_MouseDown");
            isScrolled = true;
            trackBarMouseX = e.X - trackBarBlankSize;
            SetPositionByMouse(trackBarMouseX);
        }

        private void PlayerTrackBar_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("PlayerTrackBar_MouseMove");
            if (isScrolled)
            {
                trackBarMouseX = e.X - trackBarBlankSize;
                SetPositionByMouse(trackBarMouseX);
            }
        }

        private void PlayerTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("PlayerTrackBar_MouseUp");
            if (mp3Player.isOpened)
            {
                string status = mp3Player.GetStatus();

                mp3Player.Seek(playerTrackBar.Value);

                if (status == "playing")
                {
                    mp3Player.Play();
                }
                else
                {
                    mp3Player.Pause();
                }                
            }
            isScrolled = false; 
        }   
             
        private void SetPositionByMouse(int position)
        {
            if (position < 0 || position > trackBarLength)
            {
                return;
            }

            float rate = (float)position / (float)trackBarLength;
            playerTrackBar.Value = (int)(rate * (float)(playerTrackBar.Maximum - playerTrackBar.Minimum));  
        }

        private void setMusicTimer()
        {
            if (mp3Player.isOpened)
            {
                TimeSpan t = TimeSpan.FromMilliseconds(mp3Player.GetPosition());
                lbMP3Timer.Text = String.Format("{0:D2}:{1:D2}:{2:D2}",
                    t.Minutes, t.Seconds, t.Milliseconds);
            }
        }
    }
}
