﻿using System;
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
    public partial class MainForm : Form
    {

        //タイマー間隔
        private const int TimerInterval = 15;



        private WaveOutEvent outputDevice1;

        MediaPlayer player1;
        private AudioFileReader audioFile1;
        public MainForm()
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
        int remainTime = 120;
        int score = 1;

        private void timer2_Tick(object sender, EventArgs e)
        {
            time.Text = (remainTime--).ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int moveSpeed = 10;

            if (keyData == Keys.Up)
            {
                if (Hunter.Top - moveSpeed >= 0)
                    Hunter.Top -= moveSpeed;
                return true;
            }
            else if (keyData == Keys.Down)
            {
                if (Hunter.Bottom + moveSpeed <= this.ClientSize.Height)
                    Hunter.Top += moveSpeed;
                return true;
            }
            else if (keyData == Keys.Left)
            {
                if (Hunter.Left - moveSpeed >= 0)
                    Hunter.Left -= moveSpeed;
                return true;
            }
            else if (keyData == Keys.Right)
            {
                if (Hunter.Right + moveSpeed <= this.ClientSize.Width)
                    Hunter.Left += moveSpeed;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    
}

      
