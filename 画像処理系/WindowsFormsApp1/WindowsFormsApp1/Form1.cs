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
        Mat cv_img;
        Dictionary<string, List<System.Windows.Forms.Control>> rem_add_Controls;
        public Form1()
        {
            InitializeComponent();
            rem_add_Controls = new Dictionary<string, List<Control>>() {
                {"Resize",new List<Control>(){resize_width_label,resize_height_label,resize_height,resize_width} }
            };
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
            cv_img = new Mat(ofd.FileName);
            Mat disp_img = new Mat();
            OpenCvSharp.Size disp_size = new OpenCvSharp.Size(pictureBox2.Width, pictureBox2.Height);
            Cv2.Resize(cv_img, disp_img, disp_size);
            image = BitmapConverter.ToBitmap(disp_img);
            pictureBox2.Image = image;


        }
        /// <summary>
        /// コンボボックスのpullパネルが開かれた際の挙動
        /// 現在選択されている者に対応するコントロールを削除する(非表示にする)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_DropOpen(object sender, EventArgs e)
        {
            string selected = (string)comboBox1.SelectedItem;
            if (selected == null || !rem_add_Controls.ContainsKey(selected)) return;
            foreach (Control T in rem_add_Controls[selected])
            {
                Controls.Remove(T);
            }
        }
        /// <summary>
        /// コンボボックスが開かれた際に
        /// 選択したテキストに対応したコントロールを作成する(追加する)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_Dropclosed(object sender, EventArgs e)
        {
            string selected = (string)comboBox1.SelectedItem;
            if (selected == null || !rem_add_Controls.ContainsKey(selected)) return;
            foreach (Control T in rem_add_Controls[selected])
            {
                Controls.Add(T);
            }
        }

        private void excutetion_button_Click(object sender, EventArgs e)
        {
            string selected = (string)comboBox1.SelectedItem;
            switch (selected)
            {
                case "Resize":
                    int w;
                    int h;
                    if (image == null)
                    {
                        MessageBox.Show("ファイルから画像開いといてくれ頼むわ", "画像開かれとらんよ", MessageBoxButtons.OK);
                        return;
                    } 
                    if(!Int32.TryParse(resize_width.Text,out w))
                    {
                        MessageBox.Show("ハイ雑魚！！！！お前は整数が打てないのか？\n小学生からやり直せ!!!!", "サイズ変更で整数以外はダメよ", MessageBoxButtons.OK);
                        return;
                    }
                    if (!Int32.TryParse(resize_height.Text, out h))
                    {
                        MessageBox.Show("ハイ雑魚！！！！お前は整数が打てないのか？\n小学生からやり直せ!!!!", "サイズ変更で整数以外はダメよ", MessageBoxButtons.OK);
                        return;
                    }
                    OpenCvSharp.Size resize_size = new OpenCvSharp.Size(w, h);
                    Mat dst = new Mat();
                    Cv2.Resize(cv_img, dst, resize_size);
                    Cv2.ImShow(selected, dst);
                    break;
            }
        }
    }
}
