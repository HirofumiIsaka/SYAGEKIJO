using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYAGEKIJO
{
    // Starクラス
    internal class Star : PictureBox
    {
        // コンストラクタで初期設定（例：背景色や画像の設定）
        public Star()
        {
            // ここで画像やその他の初期設定を行います
            BackColor = System.Drawing.Color.Yellow;
        }

        // 動く処理
        public void Move()
        {
            // PictureBoxのY座標（Topプロパティ）を更新
            Top += 10;
        }

        // イベントハンドラとして使用するためのラッパーメソッド
        internal void DropEvent(object sender, EventArgs e)
        {
            Move();
        }
    }
}


