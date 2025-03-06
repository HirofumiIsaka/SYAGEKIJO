using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYAGEKIJO.Properties
{
    public static class SoundManager
    {
        ///<summary>
        ///指定されたサウンドファイルを再生します。
        /// </summary>
        /// <param name="soundPath">サウンドファイルのパス</param>"
        public static void PlaySound(string soundPath)
        {
            if (File.Exists(soundPath))
            {
                try
                {
                    using (SoundPlayer player = new SoundPlayer(soundPath))
                    {
                        player.Play();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"サウンド再生エラー:{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("サウンドファイルが見つかりません。");
            }
        }
    }

}

