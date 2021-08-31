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
        Mat dst_img;
        bool drug = false;
        int[] b_x = { 0, 0 };
        int[] b_y= { 0,0};
        Dictionary<string, List<System.Windows.Forms.Control>> rem_add_Controls;
        Mat disp_img;

        public Form1()
        {
            this.Load += new EventHandler(Form1_Load);
            InitializeComponent();
            //paintingupdatetimer.Interval = 1000 / 60;
            ///
            rem_add_Controls = new Dictionary<string, List<Control>>() {
                {"Resize",new List<Control>(){resize_width_label,resize_height_label,resize_height,resize_width}},{"Crop",new List<Control>(){
                        CropResize_h_label,
                        CropResize_w_label,
                        CropEndPoints_y_label,
                        CropEndPoints_x_label,
                        CropStartPoints_y_label,
                        CropStartPoints_x_label,
                        Crop_resize_label,
                        Cropend_label,
                        Cropstart_label,
                        CropResize_w,
                        CropResize_h,
                        CropEndPomints_x,
                        CropEndPoints_y,
                        CropStartPoints_x,
                        CropStartPoints_y
                    }} };
        }
        /// <summary>
        /// 画像ファイルを開く際に使用する
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
            disp_img = new Mat();
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
            switch (selected)
            {
                case "Crop":
                    this.pictureBox2.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.DrawBox_start);
                    this.pictureBox2.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.DrawBoxEnd);
                    this.pictureBox2.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
                    break;
            }
        }

        /// <summary>
        /// コンボボックスが閉じられた際に
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
            //Console.WriteLine("ASDFGHJKL+");
            switch (selected){
                case "Crop":
                    this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawBox_start);
                    this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawBoxEnd);
                    this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
                    //this.paintingupdatetimer.Tick += new EventHandler(this.Timer_event);
                    break;
            }
        }

        /// <summary>
        /// 処理画像を初期化し、処理画像表示ウィンドウはすべて閉じる
        /// </summary>
        private void init_img()
        {
            dst_img = new Mat();
            Cv2.DestroyAllWindows();
        }

        /// <summary>
        /// 選択した処理の実行ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excutetion_button_Click(object sender, EventArgs e)
        {
            string selected = (string)comboBox1.SelectedItem;
            init_img();
            if (image == null)
            {
                MessageBox.Show("ファイルから画像開いといてくれ頼むわ", "画像開かれとらんよ", MessageBoxButtons.OK);
                return;
            }
            switch (selected)
            {
                case "Resize":
                    int h;
                    int w;
                    if(!Int32.TryParse(resize_width.Text,out h))
                    {
                        MessageBox.Show("ハイ雑魚！！！！お前は整数が打てないのか？\n小学生からやり直せ!!!!", "サイズ変更で整数以外はダメよ", MessageBoxButtons.OK);
                        return;
                    }
                    if (!Int32.TryParse(resize_height.Text, out w))
                    {
                        MessageBox.Show("ハイ雑魚！！！！お前は整数が打てないのか？\n小学生からやり直せ!!!!", "サイズ変更で整数以外はダメよ", MessageBoxButtons.OK);
                        return;
                    }
                    OpenCvSharp.Size resize_size = new OpenCvSharp.Size(h, w);
                    Cv2.Resize(cv_img, dst_img, resize_size);
                    Cv2.ImShow(selected, dst_img);
                    break;
                case "Crop":
                    Console.WriteLine(cv_img.Size());
                    Console.WriteLine(picBox2Pic_pos(b_x.Min()));
                    Console.WriteLine(picBox2Pic_pos(b_y.Min(),"y"));
                    Console.WriteLine(picBox2Pic_pos(b_y.Max() - b_y.Min(),"y"));
                    Console.WriteLine(b_x.Max() - b_x.Min());



                    dst_img = new Mat(cv_img,new Rect(picBox2Pic_pos(b_x.Min())
                        , picBox2Pic_pos(b_y.Min(),"y")
                        , picBox2Pic_pos((b_x.Max() - b_x.Min()))
                        , picBox2Pic_pos((b_y.Max() - b_y.Min()), "y")));
                    Cv2.ImShow(selected, dst_img);
                    break;

            }
        }
        /// <summary>
        /// pictureBoxの座標から画像座標への変換
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        int picBox2Pic_pos(int picBox_pos,string axis="x")
        {
            if (axis == "x")
            {
                return ((int)((picBox_pos) * ((float)cv_img.Width / pictureBox2.Width)));
            }
            else
            {
                return ((int)((picBox_pos) * ((float)cv_img.Height / pictureBox2.Height)));
            }
        }
        /// <summary>
        /// 画像保存時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cv_img == null) return;
            var sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.Filter= "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png";
            sfd.FilterIndex = 2;
            sfd.Title = "処理した画像どこにやる?";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (dst_img == null)
                {
                    Cv2.ImWrite(sfd.FileName,cv_img);
                }
                else
                {
                    Cv2.ImWrite(sfd.FileName, dst_img);
                }
                
            }
            
        }

        /// <summary>
        /// pictureBox内でマウスがクリックされた際の処理
        /// クリックした後はdrugがTrueになる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawBox_start(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("AAAAAAAAA");
            CropStartPoints_x.Text = e.X.ToString();
            CropStartPoints_y.Text = e.Y.ToString();
            b_x[0] = e.X;
            b_y[0] = e.Y;
            b_x[1] = e.X;
            b_y[1] = e.Y;
            drug = true;
            Painting_Rect();
        }
        /// <summary>
        /// Formのサイズを固定する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // MaximumSizeとMinimumSizeを同じにすることでサイズ固定にする
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            // 最大化・最小化の無効
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        /// <summary>
        /// クリックを離すとその地点の座標を保管して
        /// drugをFalseにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawBoxEnd(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("CCCCCCCCCCCCCCCCCCCCCC");
            b_x[1] = Math.Max(Math.Min(e.X, pictureBox2.Width), 0);
            b_y[1] = Math.Max(Math.Min(e.Y, pictureBox2.Height), 0);
            //float resize_h_ratio = ((float)cv_img.Height / pictureBox2.Height);
            int h = picBox2Pic_pos(b_y.Max() - b_y.Min(), "y");
            int w = picBox2Pic_pos(b_x.Max() - b_x.Min());

            CropResize_h.Text = picBox2Pic_pos(b_y.Max() - b_y.Min(),"y").ToString();
            CropResize_w.Text = picBox2Pic_pos(b_x.Max() - b_x.Min()).ToString();

            drug = false;
        }

        /// <summary>
        /// drugがTrueの時のみマウスを動かしていると
        /// ボックスの終点を更新する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (drug)
            {
                //Console.WriteLine("BBBBBBB");
                b_x[1] = Math.Max(Math.Min(e.X,pictureBox2.Width),0);
                b_y[1] = Math.Max(Math.Min(e.Y, pictureBox2.Height), 0);
                CropEndPomints_x.Text = b_x[1].ToString();
                CropEndPoints_y.Text = b_y[1].ToString();
                Painting_Rect();
            }
        }
        /// <summary>
        /// 四角形を描く処理
        /// </summary>
        private void Painting_Rect()
        {
            if (disp_img == null) return;
            Rect Crop_rect = new Rect(b_x.Min(),b_y.Min(),(b_x.Max()-b_x.Min()), (b_y.Max() - b_y.Min()));
            Mat Rect_img = disp_img.Clone();
            Cv2.Rectangle(Rect_img, Crop_rect, Scalar.Red);
            pictureBox2.Image = BitmapConverter.ToBitmap(Rect_img);
        }

        /// <summary>
        /// CropEndPomints_xのテキスト処理が変更された際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CropEndPomints_x_TextChanged(object sender, EventArgs e)
        {
            if (drug == true) return;
            int o;
            if(int.TryParse(CropEndPomints_x.Text,out o))
            {
                b_x[1] = Math.Max(Math.Min(o, pictureBox2.Width), 0);
                CropEndPomints_x.Text = b_x[1].ToString();
            }
            else
            {
                CropEndPomints_x.Text = b_x[0].ToString();
            }
            Painting_Rect();
        }

        /// <summary>
        ///  CropStartPoints_xのテキスト処理が変更された際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CropStartPoints_x_TextChanged(object sender, EventArgs e)
        {
            if (drug == true) return;
            int o;
            if (int.TryParse(CropStartPoints_x.Text, out o))
            {
                b_x[0] = Math.Max(Math.Min(o, pictureBox2.Width), 0);
                CropStartPoints_x.Text = b_x[0].ToString();
            }
            else
            {
                CropStartPoints_x.Text = b_x[0].ToString();
            }
            Painting_Rect();
        }
        /// <summary>
        /// CropStartPoints_yのテキスト処理が変更された際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CropStartPoints_y_TextChanged(object sender, EventArgs e)
        {
            if (drug == true) return;
            int o;
            if (int.TryParse(CropStartPoints_y.Text, out o))
            {
                b_y[0] = Math.Max(Math.Min(o, pictureBox2.Height), 0);
                CropStartPoints_y.Text = b_y[0].ToString();
            }
            else
            {
                CropStartPoints_y.Text = b_y[0].ToString();
            }
            Painting_Rect();
        }

        /// <summary>
        /// CropEndPoints_yのテキスト処理が変更された際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CropEndPoints_y_TextChanged(object sender, EventArgs e)
        {
            if (drug == true) return;
            int o;
            if (int.TryParse(CropEndPoints_y.Text, out o))
            {
                b_y[1] = Math.Max(Math.Min(o, pictureBox2.Height), 0);
                CropEndPoints_y.Text = b_y[1].ToString();
            }
            else
            {
                CropEndPoints_y.Text = b_y[1].ToString();
            }
            Painting_Rect();
        }
    }
}
///TODO

///

///DiD
///1.Timerイベントの追加
///2.画像上に四角形を描画する関数作成
///3.Timerイベントに２とpictureboxをRefreshする処理を追加する
///4.UIの非表示処理
///5_0.text入力からCrop領域表示の更新
///5_1.Crop処理を追加した(b_x1,b_x2,b_y1,b_y2からpictureboxの画像サイズと本物画像のサイズの比率を考慮してクリッピングを実行)