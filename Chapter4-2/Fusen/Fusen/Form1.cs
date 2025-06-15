namespace Fusen
{
    public partial class FormFUsen : Form
    {
        private int mouseX;// �}�E�X�̉��ʒu(x���W)
        private int mouseY;// �}�E�X�̏c�ʒu(y���W)
        public FormFUsen()
        {
            InitializeComponent();
        }

        //�@�e�L�X�g�{�b�N�X�ɃL�[�{�[�h���當������͂����Ƃ�
        private void textFusenMemo_KeyDown(object sender, KeyEventArgs e)
        {
            //�@<����>������ăL�[��ESC�L�[���ǂ���
            if (e.KeyCode == Keys.Escape)
            {
          �@�@�@// Yes�̏ꍇ
                // �A�v���P�[�V�������I��
                this.Close();

            }
        }


        //�@�e�L�X�g�{�b�N�X���}�E�X�ŃN���b�N�����Ƃ�
        private void textFusenMemo_MouseDown(object sender, MouseEventArgs e)
        {
            //�@<����>�����ꂽ�{�^�����}�E�X�̍��N���b�N�H
            if(e.Button == MouseButtons.Left)
            {
                //�@Yes�̏ꍇ
                this.mouseX = e.X;//�@�}�E�X�̉��ʒu(x���W)���L��
                this.mouseY = e.Y;//�@�}�E�X�̏c�ʒu(y���W)���L��
            }

        }

        private void textFusenMemo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //�@�F�̐ݒ�_�C�A���O��\��
            colorDialogFusen.ShowDialog();
            //�@�e�L�X�g�{�b�N�X�̔w�i�F��F�̐ݒ�_�C�A���O�őI�񂾐F�ɐݒ肷��
            textFusenMemo.BackColor = colorDialogFusen.Color;
        }

        //�@�e�L�X�g�{�b�N�X�ŃN���b�N�����}�E�X���ړ��������Ƃ�
        private void textFusenMemo_MouseMove(object sender, MouseEventArgs e)
        {
            //�@<����>�����ꂽ�{�^�����}�E�X�̍��N���b�N�H
            if (e.Button == MouseButtons.Left)
            {
                //�@Yes�̏ꍇ
                this.Left += e.X - mouseX;//  �t�H�[���̉��ʒu(x���W)���X�V
                this.Top += e.Y - mouseY;//  �t�H�[���̏c�ʒu(y���W)���X�V}

            }
        }

    }
}
    
