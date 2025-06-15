namespace _2回目
{
    public partial class FormBallGama : Form
    {


        private Bitmap? canvas;
        private string correctText = "荻";
        private string mistakeText = "萩";
        //private Ball balls;
        private Ball[] balls;
        private string? fontName;
        private double nowTime = 0.0;
        private string[] kanjis;
        private Brush[] ballColor = new[]
        {
            Brushes.LightPink,
            Brushes.LightBlue,
            Brushes.LightGray,
            Brushes.LightCoral,
            Brushes.LightGreen,
        };
        private int ballCount = 5;
        private int randomResult = 0;

        public FormBallGama()
        {
            InitializeComponent();
        }

        private void FormBallGama_Load(object sender, EventArgs e)
        {
            DrawCircleSelectPictureBox();
            DrawMainPictureBox(Brushes.Gray, correctText);

            textHunt.Text = correctText; //正解の文字を設定
            fontName = textHunt.Font.Name;// textHuntに設定したフォントと同じフォントにする

            //balls = new Ball(mainPictureBox, canvas, Brushes.LightBlue, correctText, fontName);
            balls = new Ball[ballCount];

            // 漢字の設定
            kanjis = new string[ballCount];
            for (int  i= 0; i<ballCount; i++)
            {
                kanjis[i] = mistakeText; //間違いの文字をセットする
            }
            randomResult = new Random().Next(ballCount);
            kanjis[randomResult] = correctText;

            // ballCount分Ballインスタンスを生成、背景色をballColor,表示する漢字もkanjisに用意する
            for (int i = 0; i < ballCount; i++)
            {
                balls[i] = new Ball(mainPictureBox, canvas, ballColor[i], kanjis[i], fontName);
                balls[i].PutCircle(new Random().Next(mainPictureBox.Width), new Random().Next(mainPictureBox.Height));
            }

            //balls.PutCircle(100, 100);
            //タイマースタート
            nowTime = 0.0;
            timer1.Start();
        }

        private void selectPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // 押されたx座標で正解判定する
            if (e.Button == MouseButtons.Left)
            {
                int selectCircle = e.X / selectPictureBox.Height;
                if (randomResult == selectCircle) // 正解の円を選んだ
                {
                    timer1.Stop();
                    DrawMainPictureBox(Brushes.Red, "〇"); //　正解
                }
                else // 失敗
                {
                    for (int i=0; i< ballCount; i++)
                    {
                        balls[i].Pitch -= balls[i].Pitch / 2;　// 移動の割合を半分にする
                    }
                    nowTime = nowTime + 10; //　ペナルティー
                    DrawMainPictureBox(Brushes.Red, correctText);
                }
            }

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            canvas = null;
            FormBallGama_Load( sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //balls.Move();

            for (int i = 0; i<ballCount; i++)
            {
                balls[i].Move();
            }
            nowTime += 0.02;
            textTimer.Text = nowTime.ToString("0.00");
        }

        private void DrawCircleSelectPictureBox()
        {
            var height = selectPictureBox.Height; //高さをselectPictureBoxから取得
            var width = selectPictureBox.Width; // 幅をselectPictureBoxから取得
            var selectCanvas = new Bitmap(width, height); //幅×高さでキャンバスを作成
            using var g = Graphics.FromImage(selectCanvas);
            //g.FillEllipse(Brushes.LightBlue, 0, 0, height, height);
            for (int i = 0; i < ballCount; i++)
            {
                g.FillEllipse(ballColor[i], i * height, 0, height, height);
            }
            selectPictureBox.Image = selectCanvas;
        }

        private void DrawMainPictureBox(Brush Color, string text)
        {
            canvas ??= new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            using var g = Graphics.FromImage(canvas);

            g.DrawString(text, new Font(textHunt.Font.FontFamily, mainPictureBox.Height / 2), Color, mainPictureBox.Width / 8, -mainPictureBox.Height / 8);
            mainPictureBox.Image = canvas;
        }


    }
}
