using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYAGEKIJO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 

            //タイマーの設定
            Timer timer = new Timer();
            timer.Interval = 200;
            timer.Tick += MoveChr;
            timer.Start();
        }

        private void MoveChr(object sender, EventArgs e)
        {
            star.Left += 130;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
