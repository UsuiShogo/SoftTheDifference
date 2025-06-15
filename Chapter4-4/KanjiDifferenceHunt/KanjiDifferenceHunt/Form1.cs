namespace KanjiDifferenceHunt
{
    public partial class FormGame : Form
    {
        string correctText = "��"; 
        string mistakeText = "��";
        double nowTime; //�o�ߎ���


        public FormGame()
        {
            InitializeComponent();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == correctText)
            {
                timer1.Stop(); //���Ԃ̌v���I��
            }
            else
            {
                nowTime = nowTime + 10; //�y�i���e�B�[
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textHunt.Text = correctText;
            Random rnd = new Random(); //�����𐶐����邽�߂̃C���X�^���X�𐶐�
            int randomResult = rnd.Next(25);

            for(int i = 0; i< splitContainer1.Panel2.Controls.Count; i++)
            {
                splitContainer1.Panel2.Controls[i].Text = mistakeText;
            }

            splitContainer1.Panel2.Controls[randomResult].Text = correctText;

            nowTime = 0;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime = nowTime + 0.02;
            textTimer.Text = nowTime.ToString("0.00");

        }
    }
}
