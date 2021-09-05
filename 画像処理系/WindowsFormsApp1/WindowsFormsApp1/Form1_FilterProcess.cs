using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://chigusa-web.com/blog/opencvsharp%E3%81%A7%E7%94%BB%E5%83%8F%E5%87%A6%E7%90%86/#OpenCVSharp
//http://tantan2014.blogspot.com/2017/11/matformpicturebox.html
//を参考にした
using OpenCvSharp.Extensions;
using OpenCvSharp;

namespace WindowsFormsApp1
{
    /// <summary>
    /// フィルター処理で新しく追加する関数
    /// </summary>
    public partial class Form1
    {

        /// <summary>
        /// Filter用の
        /// pictureBox内でマウスがクリックされた際の処理
        /// クリックした後はdrugがTrueになる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filters_DrawBox_start(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("AAAAAAAAA");
            filter_pos_x.Text = e.X.ToString();
            filter_pos_y.Text = e.Y.ToString();
            b_x[0] = e.X;
            b_y[0] = e.Y;
            b_x[1] = e.X;
            b_y[1] = e.Y;
            drug = true;
            Painting_Rect();
        }


        /// <summary>
        /// Filter処理用の
        /// クリックを離すとその地点の座標を保管して
        /// drugをFalseにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filters_DrawBoxEnd(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("CCCCCCCCCCCCCCCCCCCCCC");
            b_x[1] = Math.Max(Math.Min(e.X, pictureBox2.Width), 0);
            b_y[1] = Math.Max(Math.Min(e.Y, pictureBox2.Height), 0);
            //float resize_h_ratio = ((float)cv_img.Height / pictureBox2.Height);
            int h = picBox2Pic_pos(b_y.Max() - b_y.Min(), "y");
            int w = picBox2Pic_pos(b_x.Max() - b_x.Min());

            filter_scale_h.Text = picBox2Pic_pos(b_y.Max() - b_y.Min(), "y").ToString();
            filter_scale_w.Text = picBox2Pic_pos(b_x.Max() - b_x.Min()).ToString();

            drug = false;
        }

        /// <summary>
        /// Filter処理用の
        /// drugがTrueの時のみマウスを動かしていると
        /// ボックスの終点を更新する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filters_MouseMove(object sender, MouseEventArgs e)
        {

            if (drug)
            {
                //Console.WriteLine("BBBBBBB");
                b_x[1] = Math.Max(Math.Min(e.X, pictureBox2.Width), 0);
                b_y[1] = Math.Max(Math.Min(e.Y, pictureBox2.Height), 0);
                filter_scale_h.Text = picBox2Pic_pos(b_y.Max() - b_y.Min(), "y").ToString();
                filter_scale_w.Text = picBox2Pic_pos(b_x.Max() - b_x.Min()).ToString();
                Painting_Rect();
            }
        }


        /// <summary>
        ///  FilterStartPoints_xのテキスト処理が変更された際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterStartPoints_x_TextChanged(object sender, EventArgs e)
        {
            if (drug == true) return;
            int o;
            if (int.TryParse(filter_pos_x.Text, out o))
            {
                b_x[0] = Math.Max(Math.Min(o, pictureBox2.Width), 0);
                filter_pos_x.Text = b_x[0].ToString();
            }
            else
            {
                filter_pos_x.Text = b_x[0].ToString();
            }
            Painting_Rect();
        }


        /// <summary>
        /// filterStartPoints_yのテキスト処理が変更された際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterStartPoints_y_TextChanged(object sender, EventArgs e)
        {
            if (drug == true) return;
            int o;
            if (int.TryParse(filter_pos_y.Text, out o))
            {
                b_y[0] = Math.Max(Math.Min(o, pictureBox2.Height), 0);
                filter_pos_y.Text = b_y[0].ToString();
            }
            else
            {
                filter_pos_y.Text = b_y[0].ToString();
            }
            Painting_Rect();
        }

        /// <summary>
        /// Filtersize_wのテキスト処理が変更された際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterSize_w_TextChanged(object sender, EventArgs e)
        {
            if (drug == true) return;
            int o;
            if (int.TryParse(filter_scale_w.Text, out o))
            {
                b_x[1] = Math.Max(Math.Min(b_x[0]+o, pictureBox2.Width), 0);
                filter_scale_w.Text =Math.Abs(b_x[0]-b_x[2]).ToString();
            }
            else
            {
                filter_scale_w.Text = Math.Abs(b_x[1] - b_x[2]).ToString();
            }
            Painting_Rect();
        }

        /// <summary>
        /// FilterSize_hのテキスト処理が変更された際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterSize_h_TextChanged(object sender, EventArgs e)
        {
            if (drug == true) return;
            int o;
            if (int.TryParse(filter_scale_h.Text, out o))
            {
                b_y[1] = Math.Max(Math.Min(b_y[0]+o, pictureBox2.Height), 0);
                CropEndPoints_y.Text = Math.Abs(b_x[0] - b_x[2]).ToString();
            }
            else
            {
                CropEndPoints_y.Text = Math.Abs(b_x[0] - b_x[2]).ToString();
            }
            Painting_Rect();
        }

    }
}

