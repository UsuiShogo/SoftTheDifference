namespace Timer
{
    public partial class FormTimer : Form
    {
        int endTime;//�@�I�����Ԃ̕ϐ��𐮐��^�Œ�`
        int nowTime;//�@�o�ߎ��Ԃ̕ϐ��𐮐��^�Œ�`
        private void test123() => Console.WriteLine("aiueo");
        public FormTimer()
        {
            InitializeComponent();
        }


        // �{�^���N���b�N���̏���

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //�@���Ԏw���Textbox�̓��e���I�����Ԃ̕ϐ��Ɏ擾
            if (!int.TryParse(textSetTime.Text, out endTime))
            {
                endTime = 1;
            }
            //�@�c�莞�Ԃ��v�Z���邽�ߌo�ߎ��Ԃ̕ϐ����O�ŏ�����
            nowTime = 0;
            //�@�^�C�}�[�X�^�[�g
            timerControl.Start();

        }

        private void timerControl_Tick(object sender, EventArgs e)
        {
            int remainingTime; //�@�c�莞�Ԃ̕ϐ��𐮐��^�Œ�`

            nowTime++;         //�@�o�ߎ��ԂɂP�b��������

            //�@�c�莞�Ԃ��v�Z���ĕ\��
            remainingTime = endTime - nowTime;
            textRemainingTime.Text = remainingTime.ToString();
            //�@<����>�ݒ莞�ԂɂȂ����H
            if (endTime == nowTime)
            {
                //�@�uYes]�̏ꍇ�̏���
                //�@�^�C�}�[���~�߂�
                timerControl.Stop();
                //�@�I�����ԂɂȂ������Ƃ�m�点��
                MessageBox.Show("���ԂɂȂ�܂����I");
            }

        }
    }
}



