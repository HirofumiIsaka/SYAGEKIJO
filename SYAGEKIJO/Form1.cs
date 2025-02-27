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

namespace SYAGEKIJO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MediaPlayer player1=new MediaPlayer();
            player1.Open(new Uri("ks039.wav", UriKind.Relative));
            player1.Play();

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
    }
}

      
