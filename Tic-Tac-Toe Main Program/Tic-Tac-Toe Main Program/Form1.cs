using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Main_Program
{
    public partial class Form1 : Form
    {
        public static int turn = 0;
        public static string sign = turn % 2 == 0 ? "X" : "O";
        public static string[,] gameBoard = new string[3, 3];
        public static string winner = " ";

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Gray;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Form1.gameBoard[i, j] = " ";
                }
            }
        }

        public static bool IsThereWinner(string[,] array, ref string winner)
        {
            bool result = false;
            for (int i = 0; i < 3; i++)
            {
                if (array[i, 0] != " " && array[i, 0] == array[i, 1] && array[i, 0] == array[i, 2])
                {
                    winner = array[i, 0];
                    result = true;
                    break;
                }
                else if (array[0, i] != " " && array[0, i] == array[1, i] && array[0, i] == array[2, i])
                {
                    winner = array[0, i];
                    result = true;
                    break;
                }
            }
            if (array[0, 0] != " " && array[0, 0] == array[1, 1] && array[0, 0] == array[2, 2])    //diagonal left-right
            {
                winner = array[0, 0];
                result = true;
            }
            else if (array[2, 0] != " " && array[0, 2] == array[1, 1] && array[0, 2] == array[2, 0])    //diagonal right-left
            {
                winner = array[0, 2];
                result = true;
            }
            return result;
        }

        public static void Fill(int command, string currentSign)
        {
            int position = 0;   //for placing the command
            bool end = false;   //to break loop of placing
            for (int j = 0; j < 3; j++) //placing
            {
                for (int k = 0; k < 3; k++)
                {
                    position++;
                    if (position == command)
                    {
                        Form1.gameBoard[j, k] = currentSign;
                        end = true;
                        break;
                    }
                }
                if (end)
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "X" || button1.Text == "O")
            {
                goto end;
            }
            button1.Text = turn % 2 == 0 ? "X" : "O";
            this.BackColor = button1.Text == "O" ? Color.Salmon : Color.LimeGreen;
            Fill(1, button1.Text);
            if (IsThereWinner(Form1.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                }
            }
        end:
            Form1.turn++;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "X" || button2.Text == "O")
            {
                goto end;
            }
            button2.Text = turn % 2 == 0 ? "X" : "O";
            this.BackColor = button2.Text == "O" ? Color.Salmon : Color.LimeGreen;
            Fill(2, button2.Text);
            if (IsThereWinner(Form1.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                }
            }
        end:
            Form1.turn++;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" || button3.Text == "O")
            {
                goto end;
            }
            button3.Text = turn % 2 == 0 ? "X" : "O";
            this.BackColor = button3.Text == "O" ? Color.Salmon : Color.LimeGreen;
            Fill(3, button3.Text);
            if (IsThereWinner(Form1.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                }
            }
        end:
            Form1.turn++;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "X" || button4.Text == "O")
            {
                goto end;
            }
            button4.Text = turn % 2 == 0 ? "X" : "O";
            this.BackColor = button4.Text == "O" ? Color.Salmon : Color.LimeGreen;
            Fill(4, button4.Text);
            if (IsThereWinner(Form1.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                }
            }
        end:
            Form1.turn++;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "X" || button5.Text == "O")
            {
                goto end;
            }
            button5.Text = turn % 2 == 0 ? "X" : "O";
            this.BackColor = button5.Text == "O" ? Color.Salmon : Color.LimeGreen;
            Fill(5, button5.Text);
            if (IsThereWinner(Form1.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                }
            }
        end:
            Form1.turn++;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "X" || button6.Text == "O")
            {
                goto end;
            }
            button6.Text = turn % 2 == 0 ? "X" : "O";
            this.BackColor = button6.Text == "O" ? Color.Salmon : Color.LimeGreen;
            Fill(6, button6.Text);
            if (IsThereWinner(Form1.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                }
            }
        end:
            Form1.turn++;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "X" || button7.Text == "O")
            {
                goto end;
            }
            button7.Text = turn % 2 == 0 ? "X" : "O";
            this.BackColor = button7.Text == "O" ? Color.Salmon : Color.LimeGreen;
            Fill(7, button7.Text);
            if (IsThereWinner(Form1.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                }
            }
        end:
            Form1.turn++;
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "X" || button8.Text == "O")
            {
                goto end;
            }
            button8.Text = turn % 2 == 0 ? "X" : "O";
            this.BackColor = button8.Text == "O" ? Color.Salmon : Color.LimeGreen;
            Fill(8, button8.Text);
            if (IsThereWinner(Form1.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                }
            }
        end:
            Form1.turn++;
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "X" || button9.Text == "O")
            {
                goto end;
            }
            button9.Text = turn % 2 == 0 ? "X" : "O";
            this.BackColor = button9.Text == "O" ? Color.Salmon : Color.LimeGreen;
            Fill(9, button9.Text);
            if (IsThereWinner(Form1.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                }
            }
        end:
            Form1.turn++;
        }

        private void QuitButton(object sender, EventArgs e) => this.Close();    //quit button


        private void NextRoundButton(object sender, EventArgs e)
        {
            //Next Round
            //Checking if someone won then allow to increase round number:
            label7.Text = IsThereWinner(Form1.gameBoard, ref winner) ? (Convert.ToInt32(label7.Text) + 1).ToString() : label7.Text;

            //Clear array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Form1.gameBoard[i, j] = " ";
                }
            }
            button1.Text = null;
            button2.Text = null;
            button3.Text = null;
            button4.Text = null;
            button5.Text = null;
            button6.Text = null;
            button7.Text = null;
            button8.Text = null;
            button9.Text = null;
        }

        private void RestartButton(object sender, EventArgs e)
        {
            //Reset
            //Clear array and all buttons' text
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Form1.gameBoard[i, j] = " ";
                }
            }

            button1.Text = null;
            button2.Text = null;
            button3.Text = null;
            button4.Text = null;
            button5.Text = null;
            button6.Text = null;
            button7.Text = null;
            button8.Text = null;
            button9.Text = null;
            label4.Text = "0";
            label5.Text = "0";
            label7.Text = "0";
        }

    }
}
