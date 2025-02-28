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
    public partial class MainForm : Form
    {
        //タイマー間隔
        private const int TimerInterval = 15;

        private WaveOutEvent outputDevice1;

        MediaPlayer player1;
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
            if (daruma.Left > 1000)
            {
                daruma.Left = 0;
            }
            if (oni.Left > 1000)
            {
                oni.Left = 0;
            }
            if(syougi.Left > 1000)
            {
                syougi.Left = 0;
            }
            if (star.Left > 1000)
            {
                star.Left = 0;
            }
            if (pictureBox1Player.Bounds.IntersectsWith(pictureBox1Falling.Bounds)
            {
                // 衝突時の処理（例：得点加算、メッセージ表示、落ち物の再配置など）
                ResetFallingObject();
                MessageBox.Show("射撃成功！");
            }
            else
            {          
                Console.WriteLine("ゲームオーバー");
            }
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
        int remeinTime = 120;
        private object e;
        private object pictureBox1Player;

        private void timer2_Tick(object sender, EventArgs e)
        {
            time.Text = (remeinTime--).ToString();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int moveSpeed = 20; // 移動量の調整

            if (e.KeyCode == Keys.Up)
            {
                // 画面上端を越えないように移動
                if (player.Top - moveSpeed >= 0)
                    player.Top -= moveSpeed;
            }
            else if (e.KeyCode == Keys.Down)
            {
                // 画面下端を越えないように移動
                if (player.+ moveSpeed <= this.ClientSize.Height)
                    player.u+= moveSpeed;
            }
        }
    }
}

      
