using Csv;
using System.Data;
using System.Text;


namespace CsvReadWrite
{
    public partial class Form1 : Form
    {
        //�����Ńf�[�^��ێ�����e�[�u����p�ӂ���
        DataTable dateTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCsvRead_Click(object sender, EventArgs e)
        {
            var openFileDialogCsv = new OpenFileDialog();
            if (openFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                textBoxInputCSVFileName.Text = openFileDialogCsv.FileName;

                string csv = File.ReadAllText(openFileDialogCsv.FileName, Encoding.GetEncoding("utf-8"));

                dateTable.TableName = "CSVTable"; //�e�[�u������
                dateTable.Columns.Clear();
                dateTable.Clear();

                //csv����w�b�_�[�����̃f�[�^���擾���A�����̃e�[�u���̃J�����ɐݒ�
                //csv����1�s�擾���A���ʂ�line�ϐ��ɓ����
                foreach (ICsvLine line in CsvReader.ReadFromText(csv))
                {
                    //1�s���̃f�[�^�̃w�b�_�[�̏������o��
                    foreach (var item in line.Headers)
                    {
                        dateTable.Columns.Add(item);//�e�[�u���̃J�����ɐݒ�
                    }
                    break;
                }
                foreach (ICsvLine line in CsvReader.ReadFromText(csv))
                {
                    dateTable.Rows.Add(line.Values);
                }
                dateGridViewCsv.DataSource = dateTable;//�\���p��DateGridView�Ƀe�[�u�������蓖��

            }
        }

        private void buttonCsvWrite_Click(object sender, EventArgs e)
        {
            //SaveFileDialog�N���X�̃C���X�^���X���쐬
            saveFileDialogCsv = new SaveFileDialog();
            //�͂��߂̃t�@�C�������w�肷��
            saveFileDialogCsv.FileName = "all.csv";
            //[�t�@�C���̎��]�ɕ\�������I�������w�肷��
            saveFileDialogCsv.Filter = "csv�t�@�C��(*.csv)|*.csv";
            saveFileDialogCsv.Title = "�ۑ���̃t�@�C�������w�肵�Ă�������";

            if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                //�t�@�C����ۑ�����E�B���h�E�őI��CSV�̃t�@�C�������e�L�X�g�{�b�N�X�ɔ��f
                textBoxOutputCSVFileName.Text = saveFileDialogCsv.FileName;

                string[] header = new string[dateTable.Columns.Count];
                
                //�J�����̐��������[�v���ăJ�����̃f�[�^��ݒ�
                for (int i = 0; i< dateTable.Columns.Count; i++)
                {
                    header[i] = dateTable.Columns[i].ColumnName;
                }

                string[][] newLine = new string[dateTable.Rows.Count][];

                for (int i = 0;i< dateTable.Rows.Count;i++)
                {
                    newLine[i] = new string[dateTable.Columns.Count];

                    //�Y������J�����A��̒l������̃e�[�u������AnewLine�ɐݒ�
                    for (int j = 0;j< dateTable.Columns.Count; j++)
                    {
                        newLine[i][j] = (string)dateTable.Rows[i][j] ?? "";
                    }
                }

                //�f�[�^����CSV�`���̕�����𐶐�����
                string outcsv = CsvWriter.WriteToText(header, newLine);

                File.WriteAllText(saveFileDialogCsv.FileName, outcsv, Encoding.GetEncoding("utf-16"));
                    


            }
        }
    }
}
