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
            filter_scale_h.Text = (b_y.Max() - b_y.Min()).ToString();
            filter_scale_w.Text = (b_x.Max() - b_x.Min()).ToString();

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
                filter_scale_h.Text =(b_y.Max() - b_y.Min()).ToString();
                filter_scale_w.Text =(b_x.Max() - b_x.Min()).ToString();
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

        /// <summary>
        /// 画像を切り取りを実行する
        /// </summary>
        /// 
        /// <param name="rect">切り取り領域の参照</param>
        /// <param name="original">bool値が
        /// falseの場合はpicboxにおけるクロップ処理
        /// trueの場合は元画像における切り抜き
        /// </param>
        /// <returns></returns>
        private Mat Crop_image(out Rect rect, bool original = false)
        {
            int x = b_x[0];
            int y = b_y[0];
            int w = b_x.Max() - b_x.Min();
            int h = b_y.Max() - b_y.Min();
            Mat dst;
            if (original)
            {
                x = picBox2Pic_pos(x);
                y = picBox2Pic_pos(y);
                w = picBox2Pic_pos(w);
                h = picBox2Pic_pos(h);
                rect = new Rect(x, y, w, h);
                dst = new Mat(cv_img, rect);
            }
            else
            {
                rect = new Rect(x, y, w, h);
                dst = new Mat(disp_img, rect);
            }
            return dst;
        }


        /// <summary>
        /// 画像貼り付け
        /// </summary>
        /// <param name="Org">貼り付け先の画像</param>
        /// <param name="dst">貼り付ける画像</param>
        /// <param name="rect">貼り付け領域</param>
        /// <returns></returns>
        private Mat Marge_img(Mat Org,Mat dst,Rect rect)
        {
            Org[rect] = dst;
            return Org;
        }


        /// <summary>
        /// Laplacian二次微分フィルタ処理
        /// エッジを強調する
        /// グレースケールをカラー化して変換
        /// </summary>
        /// <param name="img">変換したい画像領域</param>
        /// <returns></returns>
        private Mat Laplacian(Mat img)
        {
            Mat dst = img.Clone();
            Cv2.Laplacian(img, dst,MatType.CV_8UC3);
            dst = dst * filetr_proc_strength.Value;
            return dst;
        }



        /// <summary>
        /// Blur処理
        /// ノイズを平均化して変換
        /// </summary>
        /// <param name="img">変換したい画像領域</param>
        /// <returns></returns>
        private Mat Blur(Mat img)
        {
            Mat dst = img.Clone();
            OpenCvSharp.Size ksize =new OpenCvSharp.Size((int)(((float)filetr_proc_strength.Value/100)*((float)img.Width/2)), (int)(((float)filetr_proc_strength.Value / 100) * ((float)img.Height/2)));
            Cv2.Blur(img, dst, ksize);
            return dst;
        }


        /// <summary>
        /// GaussianBlur
        /// GaussianBlur処理を
        /// 白色化ノイズに有効
        /// 実行する
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        private Mat GaussianBlur(Mat img)
        {
            Mat dst = img.Clone();
            OpenCvSharp.Size ksize = new OpenCvSharp.Size((int)(((float)filetr_proc_strength.Value / 100) * ((float)img.Width / 2)), (int)(((float)filetr_proc_strength.Value / 100) * ((float)img.Height / 2)));
            Cv2.GaussianBlur(img, dst, ksize,0);
            return dst;
        }


        /// <summary>
        /// MedianBlur
        /// カーネル内の全画素の中央値を計算します
        /// 中間値を使用してノイズ除去を行う
        /// ごま塩ノイズのようなノイズに対して効果
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        private Mat MedianBlur(Mat img)
        {
            Mat dst = img.Clone();
            int ksize =(int)(((float)filetr_proc_strength.Value / 100) * ((float)img.Width / 2));
            ksize = ksize % 2 == 0 ? ksize + 1 : ksize;
            Cv2.MedianBlur(img, dst,ksize);
            return dst;
        }

        /// <summary>
        /// フィルタリングは一般的にエッジまでぼかしてしまいますが， cv2.bilateralFilter() 
        /// によって使えるバイラテラルフィルタはエッジを保存しながら画像をぼかすことができます
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        private Mat BilateralBlur(Mat img)
        {
            Mat dst = img.Clone();
            int d = filetr_proc_strength.Value;
            const double sigmaColor = 75.0;
            const double sigmaSpace = 75.0;
            Cv2.BilateralFilter(img, dst,d,sigmaColor,sigmaSpace);
            return dst;
        }
        
        /// <summary>
        /// モザイク処理を実行する
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        private Mat Mozaic(Mat img)
        {
            Mat dst = img.Clone();
            OpenCvSharp.Size resizedSize = new OpenCvSharp.Size((int)(img.Width*(1-(double)filetr_proc_strength.Value/100)), (int)(img.Height * (1 - (double)filetr_proc_strength.Value / 100)));
            Cv2.Resize(img,dst,resizedSize,interpolation:InterpolationFlags.Cubic);
            return dst;
        }


    }
}

