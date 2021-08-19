using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagingBaseSample
{
    public static class Filter
    {
        /// <summary>
        /// ヒストグラムデータの取得
        /// </summary>
        /// <param name="img">画像データ</param>
        /// <returns>ヒストグラムが格納された二次元配列、配列の１次元目の並びはB,G,Rの順番</returns>
        public static int[,] CalcHistogram(ImagingSolution.Imaging.ImageData img)
        {
            int i, j;
            int width = img.Width;
            int height = img.Height;

            // 色の数(モノクロの場合:1、カラー24bitの場合:3、カラー32bitの場合:4)
            int channel = img.Channel;

            var hist = new int[channel, 256];

            for (int ch = 0; ch < channel; ch++)
            {
                for (j = 0; j < height; j++)
                {
                    for (i = 0; i < width; i++)
                    {
                        hist[ch, img[j, i, ch]]++;
                    }
                }
            }
            return hist;
        }
    }
}
