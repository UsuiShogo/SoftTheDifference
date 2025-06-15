using Csv;
using System.Data;
using System.Text;


namespace CsvReadWrite
{
    public partial class Form1 : Form
    {
        //内部でデータを保持するテーブルを用意する
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

                dateTable.TableName = "CSVTable"; //テーブル生成
                dateTable.Columns.Clear();
                dateTable.Clear();

                //csvからヘッダー部分のデータを取得し、内部のテーブルのカラムに設定
                //csvから1行取得し、結果をline変数に入れる
                foreach (ICsvLine line in CsvReader.ReadFromText(csv))
                {
                    //1行分のデータのヘッダーの情報を取り出す
                    foreach (var item in line.Headers)
                    {
                        dateTable.Columns.Add(item);//テーブルのカラムに設定
                    }
                    break;
                }
                foreach (ICsvLine line in CsvReader.ReadFromText(csv))
                {
                    dateTable.Rows.Add(line.Values);
                }
                dateGridViewCsv.DataSource = dateTable;//表示用のDateGridViewにテーブルを割り当て

            }
        }

        private void buttonCsvWrite_Click(object sender, EventArgs e)
        {
            //SaveFileDialogクラスのインスタンスを作成
            saveFileDialogCsv = new SaveFileDialog();
            //はじめのファイル名を指定する
            saveFileDialogCsv.FileName = "all.csv";
            //[ファイルの種類]に表示される選択肢を指定する
            saveFileDialogCsv.Filter = "csvファイル(*.csv)|*.csv";
            saveFileDialogCsv.Title = "保存先のファイル名を指定してください";

            if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                //ファイルを保存するウィンドウで選んだCSVのファイル名をテキストボックスに反映
                textBoxOutputCSVFileName.Text = saveFileDialogCsv.FileName;

                string[] header = new string[dateTable.Columns.Count];
                
                //カラムの数だけループしてカラムのデータを設定
                for (int i = 0; i< dateTable.Columns.Count; i++)
                {
                    header[i] = dateTable.Columns[i].ColumnName;
                }

                string[][] newLine = new string[dateTable.Rows.Count][];

                for (int i = 0;i< dateTable.Rows.Count;i++)
                {
                    newLine[i] = new string[dateTable.Columns.Count];

                    //該当するカラム、列の値を内部のテーブルから、newLineに設定
                    for (int j = 0;j< dateTable.Columns.Count; j++)
                    {
                        newLine[i][j] = (string)dateTable.Rows[i][j] ?? "";
                    }
                }

                //データからCSV形式の文字列を生成する
                string outcsv = CsvWriter.WriteToText(header, newLine);

                File.WriteAllText(saveFileDialogCsv.FileName, outcsv, Encoding.GetEncoding("utf-16"));
                    


            }
        }
    }
}
