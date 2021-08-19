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
    public partial class Form1 : Form
    {
        Image image;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image File(*.bmp,*.jpg,*.png,*.tif)|*.bmp;*.jpg;*.png;*.tif|Bitmap(*.bmp)|*.bmp|Jpeg(*.jpg)|*.jpg|PNG(*.png)|*.png";
            ///メッセージウィンドウを表示する
            ///詳しくはhttps://dobon.net/vb/dotnet/form/msgbox.html
            ///多分resultが得られるまでwait処理が実行される
            DialogResult result = MessageBox.Show("このボタンをyesするとfileDialogを表示する", "ちょいと確認用ダイヤログ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;
            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            this.Text = System.IO.Path.GetFileName(ofd.FileName);
            //	ImageDataクラスで使用されているリソースを解放します
            // リソース開放セナずっとメモリに残りっぱなしでやばいことになる
            if (image != null) image.Dispose();
            //画像パスからファイル読み込み
            Mat cv_img = new Mat(ofd.FileName);
            image = BitmapConverter.ToBitmap(cv_img);
            pictureBox2.Image = image;


        }


    }
}
