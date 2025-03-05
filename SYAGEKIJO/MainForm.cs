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
        // ゲーム状態とスコア
        private int score = 0;
        private bool isGameOver = false;
        //タイマー間隔
        private const int TimerInterval = 15;
        private Timer gameTimer;



        private WaveOutEvent outputDevice1;

        MediaPlayer player1;
        private AudioFileReader audioFile1;
        public MainForm()
        {
            InitializeComponent();

            scoreLabel.Text = score.ToString();


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
        // スコアを更新するメソッド
        private void UpdateScore(int additionalPoints)
        {
            score += additionalPoints;
            scoreLabel.Text = score.ToString();
        }

        private void MoveChr(object sender, EventArgs e)
        {
            star.Left += 10;
            daruma.Left += 20;
            oni.Left += 20;
            syougi.Left += 10;

            if (star.Right > this.ClientSize.Width)
            {
                // ResetFallingObject();   // 移動の座標をリセット
                star.Left = 0;
            }
            if (daruma.Right > this.ClientSize.Width)
            {
                //ResetFallingObject();
                daruma.Left = 0;
            }
            if (oni.Right > this.ClientSize.Width)
            {
                //ResetFallingObject();
                oni.Left= 0;
            }
            if (syougi.Right > this.ClientSize.Width)
            {
                //ResetFallingObject();
                syougi.Left = 0;
            }
            // 衝突判定を実施
            CheckCollision();
        }
        private void ResetFallingObject()
        {
            // 景品リセット
            star.Left= -star.Right;
            daruma.Left= -daruma.Right;
            oni.Left= -oni.Right;
            syougi.Left= -syougi.Right;

            // X座標は画面幅内のランダムな位置に配置
            Random rnd = new Random();
        }

        bool isStarAlive = true;
        bool isDarumaAlive = true;
        bool isOniAlive = true;
        bool isSyougiAlive = true;

        private void CheckCollision()
        {
            if (isStarAlive && star.Bounds.IntersectsWith(Hunter.Bounds))
            {
                //star.Visible =  false;
                isStarAlive = false;
                Controls.Remove(star);

                // 衝突時の処理（例：得点加算、メッセージ表示、落ち物の再配置など）
                ResetFallingObject();
               // MessageBox.Show("射撃成功！");
                UpdateScore(10); 
            }
            if (isDarumaAlive && daruma.Bounds.IntersectsWith(Hunter.Bounds))
            {
                //star.Visible =  false;
                isDarumaAlive = false;
                Controls.Remove(daruma);

                // 衝突時の処理（例：得点加算、メッセージ表示、落ち物の再配置など）
                ResetFallingObject();
                //MessageBox.Show("射撃成功！");
                UpdateScore(10);
            }
            if (isOniAlive && oni.Bounds.IntersectsWith(Hunter.Bounds))
            {
                //star.Visible =  false;
                isOniAlive = false;
                Controls.Remove(oni);
                UpdateScore(-10);


                // 衝突時の処理（例：得点加算、メッセージ表示、落ち物の再配置など）
                ResetFallingObject();
              //  MessageBox.Show("射撃失敗！");
            }
            if (isSyougiAlive && syougi.Bounds.IntersectsWith(Hunter.Bounds))
            {
                //star.Visible =  false;
                isSyougiAlive = false;
                Controls.Remove(syougi);
                UpdateScore(-10);

                // 衝突時の処理（例：得点加算、メッセージ表示、落ち物の再配置など）
                ResetFallingObject();
               // MessageBox.Show("射撃失敗！");
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
        int remainTime = 120;


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


