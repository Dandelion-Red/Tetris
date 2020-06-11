﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private Guideform guideform;

        public Form3(Guideform that)
        {
            InitializeComponent();
            guideform = that;
        }

        //使得关闭按钮灰化
        protected override CreateParams CreateParams
        {
            get
            {
                int CS_NOCLOSE = 0x200;
                CreateParams parameters = base.CreateParams;
                parameters.ClassStyle |= CS_NOCLOSE;
                return parameters;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 netconnect = new Form2();
            netconnect.Show();
        }

        /// <summary>
        /// 绘制远端地图
        /// </summary>
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            //创建窗体画布
            //Graphics g = Graphics.FromImage(yourImage);
            //清除以前画的图形
            //g.Clear(this.BackColor);
            //画出已经掉下的方块
            //对于已经落下的砖块，统一用一种颜色表示
            for (int bgy = 0; bgy < 20; bgy++)
            {
                for (int bgx = 0; bgx < 14; bgx++)
                {
                    //if (bgGroundRemote[bgy, bgx] == 1)
                    //{
                    //    g.FillRectangle(new SolidBrush(Color.FromArgb(204, 255, 204)), bgx * 5, bgy * 5, 5, 5);
                    //    g.DrawRectangle(new Pen(Color.FromArgb(46, 139, 87), 1), bgx * 5, bgy * 5, 5, 5);
                    //}
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            guideform.Show();            
            this.Dispose(true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
