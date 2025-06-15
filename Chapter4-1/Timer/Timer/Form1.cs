namespace Timer
{
    public partial class FormTimer : Form
    {
        int endTime;//　終了時間の変数を整数型で定義
        int nowTime;//　経過時間の変数を整数型で定義
        private void test123() => Console.WriteLine("aiueo");
        public FormTimer()
        {
            InitializeComponent();
        }


        // ボタンクリック時の処理

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //　時間指定のTextboxの内容を終了時間の変数に取得
            if (!int.TryParse(textSetTime.Text, out endTime))
            {
                endTime = 1;
            }
            //　残り時間を計算するため経過時間の変数を０で初期化
            nowTime = 0;
            //　タイマースタート
            timerControl.Start();

        }

        private void timerControl_Tick(object sender, EventArgs e)
        {
            int remainingTime; //　残り時間の変数を整数型で定義

            nowTime++;         //　経過時間に１秒を加える

            //　残り時間を計算して表示
            remainingTime = endTime - nowTime;
            textRemainingTime.Text = remainingTime.ToString();
            //　<判定>設定時間になった？
            if (endTime == nowTime)
            {
                //　「Yes]の場合の処理
                //　タイマーを止める
                timerControl.Stop();
                //　終了時間になったことを知らせる
                MessageBox.Show("時間になりました！");
            }

        }
    }
}



