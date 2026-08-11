using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class Form1 : Form
    {
        string Result = "";
        int _QuestionNum = 0;
        int _WrongAnswers = 0;
        int _RightAnswers = 0;
        int _Counter = 1;
        enum _enButtonMode {Levels = 0, Types = 1};
        enum _enLevel {Easy = 0, Medeium = 1, Hard = 2,Mix = 3};
        enum _enType { Add = 0 , Sub = 1 , Mul = 2 ,Div = 3 , Mix = 4};

        _enType GlobalOperationType = _enType.Add;

        _enLevel GlobalLevel = _enLevel.Easy;

        _enButtonMode ButtonMode = _enButtonMode.Levels;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restart the game", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lblQuestion.Text = "How Many Questions do you want? from 1 to 5";
                _Counter = 1;
                _QuestionNum = 0;
                _WrongAnswers = 0;
                _RightAnswers = 0;

                panelSetting.Visible = false;
                panelFirst.Visible = true;
                panelPlayGame.Visible = false;
                tBAnswer.Clear();
                lblResults.Text = "Result : ";
                panelPlayGame.Enabled = true;
                lblResults.Visible = false;
                lblAnswer.Text = "";

                btn1.Text = "Easy";
                btn2.Text = "Medeium";
                btn3.Text = "Hard";
                btn4.Text = "Mix";

                ButtonMode = _enButtonMode.Levels;
                btn5.Visible = false;
                
            }
        }

        void EndGame()
        {
            panelPlayGame.Enabled = false;
            lblResults.Visible = true;
            lblResults.Text = "Results: Right Answer {" + _RightAnswers + "} Wrong Answers {" + _WrongAnswers + "}";
        }

         void StartGame()
        {
            _enType OperationType = GlobalOperationType;
            _enLevel Level = GlobalLevel;
            Random rnd = new Random();
            float Num1 = 0;
            float Num2 = 0;
            panelPlayGame.Visible = true;
            panelSetting.Visible = false;

            lblQuestion.Text = "Question Number{" + _Counter + "}";
            _Counter++;
                
             if(GlobalLevel == _enLevel.Mix)
                {
                    int rndLevel = rnd.Next(0, 3);
                    switch (rndLevel)
                    {
                        case 0:
                            {
                                Level = _enLevel.Easy;
                            }
                            break;
                        case 1:
                            {
                                Level = _enLevel.Medeium;
                            }
                            break;
                        case 2:
                            {
                                Level = _enLevel.Hard;
                            }
                            break;
                        default:
                            break;
                    }
                }

             switch (Level)
                {
                    case _enLevel.Easy:
                        {   
                            Num1 = rnd.Next(0, 10);
                            Num2 = rnd.Next(0, 10);
                        }
                        break;
                    case _enLevel.Medeium:
                        {                       
                            Num1 = rnd.Next(10, 50);
                            Num2 = rnd.Next(10, 50);
                        }
                        break;
                    case _enLevel.Hard:
                        {
                            Num1 = rnd.Next(50, 100);
                            Num2 = rnd.Next(50, 100);
                        }
                        break;
                    default:
                        break;
                }

             if (GlobalOperationType == _enType.Mix)
             {
                 int rndLevel = rnd.Next(0, 4);
                 switch (rndLevel)
                 {
                     case 0:
                         {
                             OperationType = _enType.Add;
                         }
                         break;
                     case 1:
                         {
                             OperationType = _enType.Sub;
                         }
                         break;
                     case 2:
                         {
                             OperationType = _enType.Mul;
                         }
                         break;
                     case 3:
                         {
                             OperationType = _enType.Div;
                         }
                         break;
                     default:
                         break;
                 }
             }

             switch (OperationType)
             {
                 case _enType.Add:
                     {
                         Result = (Num1 + Num2).ToString();
                         lblMath.Text = Num1 + " + " + Num2 + " = ";
                     }
                     break;
                 case _enType.Sub:
                     {
                         Result = (Num1 - Num2).ToString();
                         lblMath.Text = Num1 + " - " + Num2 + " = ";
                     }
                     break;
                 case _enType.Mul:
                     {
                         Result = (Num1 * Num2).ToString();
                         lblMath.Text = Num1 + " * " + Num2 + " = ";
                     }
                     break;
                 case _enType.Div:
                     {
                         Result = (Num1 / Num2).ToString();
                         lblMath.Text = Num1 + " / " + Num2 + " = ";
                     }
                     break;
             }

             btnCheck.Visible = true;
             _QuestionNum--;

        }

        void SwichButtons()
        {
            ButtonMode = _enButtonMode.Types;
            lblQuestion.Text = "Which Types of Questions do you want?";
            btn1.Text = "Add";
            btn2.Text = "Sub";
            btn3.Text = "Mul";
            btn4.Text = "Div";
            btn5.Visible = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                _QuestionNum = Convert.ToInt32(tB1.Text);

                if (_QuestionNum > 5 || _QuestionNum < 1)
                {
                    MessageBox.Show("Number should between 1 and 5","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                panelSetting.Visible = true;
                panelFirst.Visible = false;
                lblQuestion.Text = "Which level of questions do you want?";
                tB1.Clear();
            }
            catch
            {
                MessageBox.Show("Wrong Value Please Enter a Number!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tB1.Clear();
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ButtonMode == _enButtonMode.Types)
            {
                GlobalOperationType = _enType.Add;
                StartGame();
            }
            else if (ButtonMode == _enButtonMode.Levels)
            {
                GlobalLevel = _enLevel.Easy;
                SwichButtons();
            } 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ButtonMode == _enButtonMode.Types)
            {
                GlobalOperationType = _enType.Sub;
                StartGame();
            }
            else if (ButtonMode == _enButtonMode.Levels)
            {
                GlobalLevel = _enLevel.Medeium;
                SwichButtons();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ButtonMode == _enButtonMode.Types)
            {
                GlobalOperationType = _enType.Mul;
                StartGame();
            }
            else if (ButtonMode == _enButtonMode.Levels)
            {
                GlobalLevel = _enLevel.Hard;
                SwichButtons();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ButtonMode == _enButtonMode.Types)
            {
                GlobalOperationType = _enType.Div;
                StartGame();
            }
            else if (ButtonMode == _enButtonMode.Levels)
            {
                GlobalLevel = _enLevel.Mix;
                SwichButtons();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            GlobalOperationType = _enType.Mix;
            StartGame();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //if (!this.ValidateChildren())
            //{
            //    MessageBox.Show("Some fileds are not valide!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            lblAnswer.Visible = true;
            if (tBAnswer.Text == Result)
            {
                lblAnswer.Text = "Question Number " + (_Counter - 1) + " Answer is True : )";
                _RightAnswers++;
            }
            else
            {
                lblAnswer.Text = "Question Number " + (_Counter - 1) + " Wrong Ansewer : ( the True is :" + Result;
                _WrongAnswers++;
            }
            tBAnswer.Clear();
            if (_QuestionNum == 0)
            {
                EndGame();
                return;
            }            
            StartGame();
        }

        private void tBAnswer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBAnswer.Text.Trim()))
            {
                e.Cancel = true;
                tBAnswer.Focus();
                errorProvider1.SetError(tBAnswer, "add a value");
            }
        }

        private void tBAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back )
            {
                e.Handled = true;
            }
        }
    }
}
