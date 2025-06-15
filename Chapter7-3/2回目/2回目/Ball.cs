using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2回目
{
    internal class Ball
    {


        //非公開で外部からは変更することができない値
        private const int radius = 40; // 円の半径
        private string kanji;
        private string fontName;
        private Brush brashcolor;
        private PictureBox pictureBox;
        private Bitmap? canvas;
        private Point position = new Point(0, 0);                                                                                                                                                       
        private Point previouns= new Point(0, 0);
        private Point direction = new Point(1, 1);

        //公開し外部から触ることができる値
        public int Pitch { get; set; } = radius / 2;　// 移動の割合

        //Ballのコンストラクタ
        public Ball(PictureBox pb, Bitmap? cv, Brush cl, string st, string fn)
        {
            //内部で使用する変数に引数の値で初期値を設定
            pictureBox = pb;
            canvas = cv;
            brashcolor = cl;
            kanji = st;
            fontName = fn;
        }

        public void PutCircle(int x, int y)
        {
            position.X = x;
            position.Y = y;
            using var g = Graphics.FromImage(canvas);

            g.FillEllipse(brashcolor, x, y, radius * 2, radius * 2);

            // 文字列を描画する
            g.DrawString(kanji, new Font(fontName, radius), Brushes.Black, x + 4, y + 12, new StringFormat());

            pictureBox.Image = canvas; //MainPictureBoxに表示する
        }

        public void DeleteCircle()
        {
            previouns = (previouns == new Point(0, 0)) ? position : previouns;
            using Graphics g = Graphics.FromImage(canvas);

            // 円を白で描く
            g.FillEllipse(Brushes.White, previouns.X, previouns.Y, radius * 2, radius * 2);
            pictureBox.Image = canvas;
        }

        public void Move()
        {
            DeleteCircle();

            var x = position.X + Pitch * direction.X;
            var y = position.Y + Pitch * direction.Y;

            //壁で跳ね返る補正
            if(x >= pictureBox?.Width - radius * 2)// 右端に来た場合の判定
            {
                direction.X = -1; // 進む方向を反転(左方向)
            }
            if (x <= 0)//左端に来た場合の判定
            {
                direction.X = +1; // 進む方向を反転(右方向)
            }
            if(y >= pictureBox?.Height - radius * 2)// 下端に来た場合の判定
            {
                direction.Y = -1; // 進む方向を反転(上方向)
            }
            if(y <= 0)// 上端に来た場合の判定
            {
                direction.Y = +1;
            }

            // 跳ね返り補正を反映した値で新しい位置を計算
            position.X = x + direction.X;
            position.Y = y + direction.Y;

            PutCircle(position.X, position.Y);
            previouns = position;
        }
    }
}
