using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using NAudio.Wave; 

namespace SYAGEKIJO
{
    public partial class Form1 : Form
    {

        //タイマー間隔
        private const int TimerInterval = 15;



        private WaveOutEvent outputDevice1;

        MediaPlayer player1;
        private AudioFileReader audioFile1;
        public Form1()
        {
            InitializeComponent();
            // audioFile1 = new AudioFileReader(@"Sounds\ks039.wav");

            // 出力デバイスの初期化
            // outputDevice1 = new WaveOutEvent();

            player1 = new MediaPlayer();
            player1.Open(new Uri(@"Sounds\ks039.wav", UriKind.Relative));
            // player1.Play();

            //タイマーの設定
            Timer timer = new Timer();
            timer.Interval = 75;
            timer.Tick += MoveChr;
            timer.Start();
        }

        private void MoveChr(object sender, EventArgs e)
        {
            star.Left += 10;
            daruma.Left += 10;
            oni.Left += 10;
            syougi.Left += 10;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            player1.Play();

            //if (outputDevice1.PlaybackState != PlaybackState.Playing)
            //{
            //    outputDevice1.Init(audioFile1);
            //    outputDevice1.Play();
            //}
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // プレイヤー1の停止
            outputDevice1.Stop();

        }
    }
}

      
