namespace Fusen
{
    public partial class FormFUsen : Form
    {
        private int mouseX;// マウスの横位置(x座標)
        private int mouseY;// マウスの縦位置(y座標)
        public FormFUsen()
        {
            InitializeComponent();
        }

        //　テキストボックスにキーボードから文字を入力したとき
        private void textFusenMemo_KeyDown(object sender, KeyEventArgs e)
        {
            //　<判定>押されてキーがESCキーかどうか
            if (e.KeyCode == Keys.Escape)
            {
          　　　// Yesの場合
                // アプリケーションを終了
                this.Close();

            }
        }


        //　テキストボックスをマウスでクリックしたとき
        private void textFusenMemo_MouseDown(object sender, MouseEventArgs e)
        {
            //　<判定>押されたボタンがマウスの左クリック？
            if(e.Button == MouseButtons.Left)
            {
                //　Yesの場合
                this.mouseX = e.X;//　マウスの横位置(x座標)を記憶
                this.mouseY = e.Y;//　マウスの縦位置(y座標)を記憶
            }

        }

        private void textFusenMemo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //　色の設定ダイアログを表示
            colorDialogFusen.ShowDialog();
            //　テキストボックスの背景色を色の設定ダイアログで選んだ色に設定する
            textFusenMemo.BackColor = colorDialogFusen.Color;
        }

        //　テキストボックスでクリックしたマウスを移動させたとき
        private void textFusenMemo_MouseMove(object sender, MouseEventArgs e)
        {
            //　<判定>押されたボタンがマウスの左クリック？
            if (e.Button == MouseButtons.Left)
            {
                //　Yesの場合
                this.Left += e.X - mouseX;//  フォームの横位置(x座標)を更新
                this.Top += e.Y - mouseY;//  フォームの縦位置(y座標)を更新}

            }
        }

    }
}
    
