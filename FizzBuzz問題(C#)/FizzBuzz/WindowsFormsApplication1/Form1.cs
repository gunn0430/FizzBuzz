using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class form_FizzBuzz : Form
    {
        string fizz;
        string buzz;
        int maxCount;

        public form_FizzBuzz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartFizzBuzz();
        }

        //フォームからFizzBuzz実行時に使用するパラメータを取得
        private void GetParameter()
        {
            fizz = textBox_3multiple.Text;
            buzz = textBox_5multiple.Text;
            //maxCountの入力チェック
            try{
                maxCount = int.Parse(textBox_maxCount.Text);
            }catch(Exception e){
                maxCount = 0;
                Console.WriteLine(e.Message);
            }
        }

        //FizzBuzz実行時に使用するパラメータの入力チェック
        private bool ValidateParam()
        {
            //fizzの入力チェック
            if (textBox_3multiple.Text == "")
            {
                //メッセージボックスを表示
                MessageBox.Show("文字を入力してください。",
                     "エラー",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return false;
            }

            //buzzの入力チェック
            if (textBox_5multiple.Text == "")
            {
                //メッセージボックスを表示
                MessageBox.Show("文字を入力してください。",
                     "エラー",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return false;
            }

            //maxCountの入力チェック
            int maxCount = 0;
            //入力チェック
            if (int.TryParse(textBox_maxCount.Text, out maxCount))
            {
                //入力値がint型に変換できた場合、入力値はそのまま
            }
            else
            {
                //入力値がint型に変換できない場合
                textBox_maxCount.Text = "";
                //メッセージボックスを表示
                MessageBox.Show("数字を入力してください。",
                     "エラー",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return false;
            }

            //エラーなしのためtrueを返す
            return true;
        }

        //FizzBuzz実行
        private void StartFizzBuzz()
        {
            //入力された値を取得
            GetParameter();
            //入力チェック
            ValidateParam();

            string result = "";
            for (int i = 1; i <= maxCount; i++)
            {
                //3の倍数かつ5の倍数の場合
                if(0 == (i % 3) && 0 == (i % 5)){
                    result += fizz + buzz;
                }
                //3の倍数の場合
                else if(0 == (i % 3)){
                    result += fizz;
                }
                //5の倍数の場合
                else if (0 == (i % 5))
                {
                    result += buzz;
                } else {
                    result += i.ToString();
                }
                result += Environment.NewLine;
            }
            textBox_result.Text = result;
        }

    }
}
