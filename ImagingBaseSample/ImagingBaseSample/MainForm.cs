using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImagingBaseSample
{
    /// <summary>
    /// patical=="部分クラス"
    /// 同名のクラスとファイルを分割しながら
    /// 一つのクラスをかける機能
    /// </summary>
    public partial class MainForm : Form
    {
        // 画像データ管理クラス（ImageDataクラス）
        /// <summary>
        /// そこで、OpenCVのIplImage構造体やMatクラスのエッセンスを取り入れつつ、
        /// .NETのBitmapクラスっぽく、さらに画像データを簡単に扱えるようにすることを目指した
        /// ImageDataクラスなるライブラリを作成してみました
        /// https://imagingsolution.net/program/csharp/imagedata_class_open/
        /// </summary>
        ImagingSolution.Imaging.ImageData _imageData;

        // ヒストグラムのY軸の最大値の初期値
        double _histMaxAxisValue;

        public MainForm()
        {
            //Form画面の生成
            //particalによって定義されているクラス
            InitializeComponent();
        }

        /// <summary>
        /// ファイルを開く
        /// .NET の標準のパターンに従うイベントをクラス
        /// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines
        /// </summary>
        /// <param name="sender">イベントを送信したオブジェクト。thisだとこのオブジェクトを呼び出すFormが取得されてしまい呼び出し元がわからなくなる</param>
        /// <param name="e">イベント各固有の情報が渡される（ボタンオブジェクトならあまり意味はない）</param>
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            //ファイルを開くダイアログボックスの作成  
            var ofd = new OpenFileDialog();
            //ファイルフィルタ  
            ofd.Filter = "Image File(*.bmp,*.jpg,*.png,*.tif)|*.bmp;*.jpg;*.png;*.tif|Bitmap(*.bmp)|*.bmp|Jpeg(*.jpg)|*.jpg|PNG(*.png)|*.png";
            //ダイアログの表示 （Cancelボタンがクリックされた場合は何もしない）
            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            // フォームのタイトル変更(上のダイヤログで取得されたパスからファイル名を取得してフォームのタイトルにする)
            //フォームは.textで変更可能
            this.Text = System.IO.Path.GetFileName(ofd.FileName);

            //	ImageDataクラスで使用されているリソースを解放します
            // リソース開放セナずっとメモリに残りっぱなしでやばいことになる
            if (_imageData != null) _imageData.Dispose();

            // 画像データ管理クラス(ImageDataクラス)の作成
            _imageData = new ImagingSolution.Imaging.ImageData(ofd.FileName);

            // 画像の描画
            DrawImage(_imageData);
            // ヒストラム描画
            DrawHistogram(_imageData);
        }

        /// <summary>
        /// 名前を付けて保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if (_imageData == null) return;

            //ファイルを開くダイアログボックスの作成  
            var sfd = new SaveFileDialog();
            //ファイルフィルタ  
            sfd.Filter = "Bitmap(*.bmp)|*.bmp|Jpeg(*.jpg)|*.jpg|Tiff(*.tif)|*.tif|PNG(*.png)|*.png";
            //ダイアログの表示 （Cancelボタンがクリックされた場合は何もしない）
            if (sfd.ShowDialog() == DialogResult.Cancel) return;

            // 画像のファイル保存
            _imageData.Save(sfd.FileName);
        }

        /// <summary>
        /// 終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void graphicsBox_Resize(object sender, EventArgs e)
        {
            // 画像の再描画
            DrawImage(_imageData);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="img">描画する画像</param>
        private void DrawImage(ImagingSolution.Imaging.ImageData img)
        {
            //画像がなければ無視する
            if (img == null) return;

            _imageData = img;
            //particalで定義されたgraphicsBoxで
            graphicsBox.Graphics.Clear(graphicsBox.BackColor);
            graphicsBox.Graphics.DrawImage(_imageData.ToBitmap(), 0, 0, _imageData.Width, _imageData.Height);
            graphicsBox.Refresh();
        }

        /// <summary>
        /// Chartを使ったヒストグラム表示
        /// </summary>
        /// <param name="img"></param>
        private void DrawHistogram(ImagingSolution.Imaging.ImageData img)
        {
            // ヒストグラムの取得
            var hist = Filter.CalcHistogram(img);

            ///////////////////////////////////////////////////////
            // Chartコントロール内のグラフ、凡例、目盛り領域を削除
            chtHistogram.Series.Clear();
            chtHistogram.Legends.Clear();
            chtHistogram.ChartAreas.Clear();

            // /////////////////////////////////////////////////////
            // 目盛り領域の設定
            var ca = chtHistogram.ChartAreas.Add("Histogram");

            // X軸
            //ca.AxisX.Title = "Brightness";  // タイトル
            ca.AxisX.Minimum = 0;           // 最小値
            ca.AxisX.Maximum = 256;         // 最大値
            ca.AxisX.Interval = 64;         // 目盛りの間隔
                                            // Y軸
            //ca.AxisY.Title = "Count";
            ca.AxisY.Minimum = 0;
            ca.AxisY.LabelStyle.Format = "D"; 

            // グラフの系列を追加
            var ser = new System.Windows.Forms.DataVisualization.Charting.Series[4];
            ser[0] = chtHistogram.Series.Add("HistogramB");
            ser[1] = chtHistogram.Series.Add("HistogramG");
            ser[2] = chtHistogram.Series.Add("HistogramR");
            ser[3] = chtHistogram.Series.Add("HistogramAlpha");

            // グラフの種類をスプライン面グラフに設定する
            ser[0].ChartType = ser[1].ChartType = ser[2].ChartType
                = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;

            // 輪郭線の太さ
            //sR.BorderWidth = sG.BorderWidth = sB.BorderWidth = 2;

            // 輪郭線の色
            ser[0].BorderColor = Color.Blue;
            ser[1].BorderColor = Color.Green;
            ser[2].BorderColor = Color.Red;
            ser[3].BorderColor = Color.Black;

            // 塗りつぶしの色の設定（半透明）
            ser[0].Color = Color.FromArgb(150, Color.Blue);
            ser[1].Color = Color.FromArgb(150, Color.Green);
            ser[2].Color = Color.FromArgb(150, Color.Red);
            ser[3].Color = Color.FromArgb(150, Color.Black);

            // データ設定
            for (int ch = 0; ch < img.Channel; ch++)
            {
                for (int i = 0; i < 256; i++)
                {
                    ser[ch].Points.AddXY(i, hist[ch, i]);
                }
            }

            // Chartの描画
            chtHistogram.Update();

            // Autoスケールで表示したときのY軸の最大値を取得
            _histMaxAxisValue = ca.AxisY.Maximum;
        }


        private void nudHistogramScale_ValueChanged(object sender, EventArgs e)
        {
            var scaleValue = ((float)nudHistogramScale.Value - 50) / 10f;

            chtHistogram.ChartAreas[0].AxisY.Maximum = _histMaxAxisValue * Math.Pow(0.1, scaleValue);
        }

    }
}

