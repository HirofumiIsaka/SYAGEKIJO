using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SYAGEKIJO
{
    internal class CounterTimer
    {
        /// <summary>
        /// 一定間隔でカウントアップするタイマー管理クラス
        /// </summary>
  
            private Timer timer;
            private Counter counter;
            private Label displayLabel;


            public CounterTimer(Counter counterInstance, Label label, Timer timerInstance)
            {
                counter = counterInstance;
                displayLabel = label;
                timer = timerInstance;
                timer.Interval = 1000; //１秒ごとにカウント
                timer.Tick += (sender, e) =>
                {
                    counter.Increment();
                    displayLabel.Text = counter.Value.ToString();   //ベタ打ち
                };
            }
            /// <summary>
            /// タイマー開始
            /// </summary>
            public void Start()
            {
                timer.Start();
            }
            /// <summary>
            /// タイマー停止
            /// </summary>
            public void Stop()
            {
                timer.Stop();
            }
    }
}
