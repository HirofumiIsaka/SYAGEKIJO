﻿namespace SYAGEKIJO
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.star = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.daruma = new System.Windows.Forms.PictureBox();
            this.oni = new System.Windows.Forms.PictureBox();
            this.syougi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daruma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syougi)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(149, 356);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(117, 59);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "タイムスタート";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "一時停止";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "ゲーム再開";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(542, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "射撃";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // star
            // 
            this.star.Image = ((System.Drawing.Image)(resources.GetObject("star.Image")));
            this.star.Location = new System.Drawing.Point(196, 212);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(100, 94);
            this.star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star.TabIndex = 4;
            this.star.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "残り時間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "得点";
            // 
            // daruma
            // 
            this.daruma.Image = ((System.Drawing.Image)(resources.GetObject("daruma.Image")));
            this.daruma.Location = new System.Drawing.Point(315, 213);
            this.daruma.Name = "daruma";
            this.daruma.Size = new System.Drawing.Size(100, 94);
            this.daruma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.daruma.TabIndex = 8;
            this.daruma.TabStop = false;
            // 
            // oni
            // 
            this.oni.ErrorImage = global::SYAGEKIJO.Properties.Resources.setsubun_oni_kowai;
            this.oni.Image = global::SYAGEKIJO.Properties.Resources.setsubun_oni_kowai;
            this.oni.Location = new System.Drawing.Point(436, 213);
            this.oni.Name = "oni";
            this.oni.Size = new System.Drawing.Size(100, 96);
            this.oni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oni.TabIndex = 9;
            this.oni.TabStop = false;
            // 
            // syougi
            // 
            this.syougi.ErrorImage = ((System.Drawing.Image)(resources.GetObject("syougi.ErrorImage")));
            this.syougi.Image = ((System.Drawing.Image)(resources.GetObject("syougi.Image")));
            this.syougi.InitialImage = ((System.Drawing.Image)(resources.GetObject("syougi.InitialImage")));
            this.syougi.Location = new System.Drawing.Point(576, 213);
            this.syougi.Name = "syougi";
            this.syougi.Size = new System.Drawing.Size(100, 96);
            this.syougi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.syougi.TabIndex = 10;
            this.syougi.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::SYAGEKIJO.Properties.Resources.gekijou_end_blank;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.syougi);
            this.Controls.Add(this.oni);
            this.Controls.Add(this.daruma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.star);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daruma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syougi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox star;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox daruma;
        private System.Windows.Forms.PictureBox oni;
        private System.Windows.Forms.PictureBox syougi;
    }
}

