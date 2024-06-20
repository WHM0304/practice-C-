using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_0001
{
    public partial class Form1 : Form
    {
        // 여기서 시작
        // 랜덤 수 개체 만들기
        Random randomizer = new Random();

        // 변수선언만
        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int TimeLeft;


        // 퀴즈 시작 함수만들기
        public void StartTheQuiz()
        {

            // 플러스 랜덤수 부여하기
            // 51미만의 랜덤한 수 return = randomizer.Next(51);
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;

            // 마이너스 랜덤수 부여하기
            // 1<=return <= 101 의 랜덤한 값 리턴;
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // 곱셈 랜덤수 부여하기
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // 나눗셈 랜덤수 부여하기
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // 시간초 설정
            TimeLeft = 50;
            timeLabel.Text = "50 초";
            timer1.Start();




        }

        // 정답이 맞는지 체크하는 메소드
        private bool CheckTheAnswer()
        {
            if((addend1+ addend2) == sum.Value && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
                
        }
    

        public Form1()
        {
            InitializeComponent();
        }


       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // 버튼클릭이벤트
        private void startButton_Click_1(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        // 시간이벤트
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("다맞았습니다!",
                                 "축하합니다!");
                startButton.Enabled = true;
            }
            else if(TimeLeft > 0)
            {
                TimeLeft = TimeLeft - 1;
                timeLabel.Text = TimeLeft + " 초";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "시간끝";
                MessageBox.Show("시간안에 못풀었습니다!" , "Bye!");

                // 정답 설정해주기
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if(answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("정지!");
            stopButton.Enabled = false;
            startButton.Enabled = true;
            timeLabel.Text = "required startbutton!";
        }
    }
}
