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
        public void Click(Button button,int index)      //common method for each of buttons according to its object and index (for placing gameBoard array)
        {
            if (button.Text == "X" || button.Text == "O")
            {
                goto end;
            }
            button.Text = turn % 2 == 0 ? "X" : "O";
            this.BackColor = button.Text == "O" ? Color.Salmon : Color.LimeGreen;
            Fill(index, button.Text);
            if (IsThereWinner(Form1.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    this.label4.Text = (Convert.ToInt32(this.label4.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    this.label5.Text = (Convert.ToInt32(this.label5.Text) + 1).ToString();
                }
            }
        end:
            Form1.turn++;
        }

        private void Button1_Click(object sender, EventArgs e) => Click(button1,1);
        private void Button2_Click(object sender, EventArgs e) => Click(button2,2);
        private void Button3_Click(object sender, EventArgs e) => Click(button3,3);
        private void Button4_Click(object sender, EventArgs e) => Click(button4,4);
        private void Button5_Click(object sender, EventArgs e) => Click(button5,5);
        private void Button6_Click(object sender, EventArgs e) => Click(button6,6);
        private void Button7_Click(object sender, EventArgs e) => Click(button7,7);
        private void Button8_Click(object sender, EventArgs e) => Click(button8,8);
        private void Button9_Click(object sender, EventArgs e) => Click(button9,9);

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
