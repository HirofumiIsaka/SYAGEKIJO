using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYAGEKIJO
{
    // darumaクラス
    internal class Daruma: PictureBox
    {

        // コンストラクタで初期設定（例：背景色や画像の設定）
        public Daruma()
        {
            // ここで画像やその他の初期設定を行います
            BackColor= System.Drawing.Color.Red;
        }

        public int Left { get; internal set; }
        public int Top{ get; private set; }

        // 動く処理
        public void Move()
        {
            // PictureBoxのY座標（Topプロパティ）を更新
            Top += 20;
        }

        // イベントハンドラとして使用するためのラッパーメソッド
        internal void DropEvent(object sender, EventArgs e)
        {
            Move();
        }

    }
}



