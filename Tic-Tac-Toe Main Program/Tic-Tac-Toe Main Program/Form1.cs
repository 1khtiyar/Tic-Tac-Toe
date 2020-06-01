using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Main_Program
{
    public partial class GameForm : Form
    {
        public static int turn = 0;
        public static string[,] gameBoard = new string[3, 3];
        public static string winner = " ";
        public Buttons buttons = new Buttons(3, 3);

        public GameForm()
        {
            InitializeComponent();
            this.BackColor = Color.Gray;
            buttons[0, 0] = button1; buttons[0, 1] = button2; buttons[0, 2] = button3;
            buttons[1, 0] = button4; buttons[1, 1] = button5; buttons[1, 2] = button6;
            buttons[2, 0] = button7; buttons[2, 1] = button8; buttons[2, 2] = button9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GameForm.gameBoard[i, j] = " ";
                    buttons[i, j].BackgroundImage = turn % 2 == 0 ? global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellUndefXSmall :
                        global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellUndefOSmall;
                }
            }
        }

        private bool isCrowded()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (GameForm.gameBoard[i, j] == "" || GameForm.gameBoard[i, j] == " ")
                        return false;

            return true;
        }

        private bool IsThereWinner(string[,] array, ref string winner)
        {
            for (int i = 0; i < 3; i++)
            {
                if (array[i, 0] != " " && array[i, 0] == array[i, 1] && array[i, 0] == array[i, 2])
                {
                    winner = array[i, 0];
                    return true;
                }
                else if (array[0, i] != " " && array[0, i] == array[1, i] && array[0, i] == array[2, i])
                {
                    winner = array[0, i];
                    return true;
                }
            }
            if (array[0, 0] != " " && array[0, 0] == array[1, 1] && array[0, 0] == array[2, 2])    //diagonal left-right
            {
                winner = array[0, 0];
                return true;
            }
            else if (array[2, 0] != " " && array[0, 2] == array[1, 1] && array[0, 2] == array[2, 0])    //diagonal right-left
            {
                winner = array[0, 2];
                return true;
            }
            return false;
        }

        public static bool blockGame = false; //become true when there is a winnner, to restrict clicking for user on game board
        //the  blockGame var should be switched off in next round of game (corrections on NextRoundButton)

        public new void Click(Button button, byte rowPosition, byte columnPosition)      //common method for each of buttons according to its object and index (for placing gameBoard array)
        {
            string buttonText = button.Text;
            if (buttonText == "X" || buttonText == "O" || blockGame)
                return;
            if (GameForm.turn % 2 == 0)
            {
                buttonText = "X";
                button.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellUndefXSmall;
                button.Image = global::Tic_Tac_Toe_Main_Program.Properties.Resources.ForCellXLast;
            }
            else
            {
                buttonText = "O";
                button.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellUndefOSmall;
                button.Image = global::Tic_Tac_Toe_Main_Program.Properties.Resources.ForCellOLast;
            }

            GameForm.gameBoard[rowPosition, columnPosition] = buttonText;

            if (IsThereWinner(GameForm.gameBoard, ref winner))
            {
                if (winner == "X")
                {
                    this.counterLabelXs.Text = (Convert.ToInt32(this.counterLabelXs.Text) + 1).ToString();
                }
                else if (winner == "O")
                {
                    this.counterLabelOs.Text = (Convert.ToInt32(this.counterLabelOs.Text) + 1).ToString();
                }

                HandleNextRoundButtonsProperties(true);

                blockGame = true;
                return;
            }
            button.Text = buttonText;
            GameForm.turn++;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j].Text != "")
                        continue;

                    buttons[i, j].BackgroundImage = buttonText == "O" ? global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellUndefXSmall :
                    global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellUndefOSmall;
                }
            }
            if (isCrowded())
            {
                GameForm.blockGame = true;

                HandleNextRoundButtonsProperties(true);
            }
        }

        private void Button1_Click(object sender, EventArgs e) => Click(button1, 0, 0);
        private void Button2_Click(object sender, EventArgs e) => Click(button2, 0, 1);
        private void Button3_Click(object sender, EventArgs e) => Click(button3, 0, 2);
        private void Button4_Click(object sender, EventArgs e) => Click(button4, 1, 0);
        private void Button5_Click(object sender, EventArgs e) => Click(button5, 1, 1);
        private void Button6_Click(object sender, EventArgs e) => Click(button6, 1, 2);
        private void Button7_Click(object sender, EventArgs e) => Click(button7, 2, 0);
        private void Button8_Click(object sender, EventArgs e) => Click(button8, 2, 1);
        private void Button9_Click(object sender, EventArgs e) => Click(button9, 2, 2);

        private void QuitButtonClick(object sender, EventArgs e) => this.Close();

        private void NextRoundButtonClick(object sender, EventArgs e)
        {
            if (IsThereWinner(GameForm.gameBoard, ref winner) || isCrowded())
            {
                roundCounterLabel.Text = (Convert.ToInt32(roundCounterLabel.Text) + 1).ToString();
                GameForm.turn = winner == "O" ? 1 : 0;
            }
            else
                return;

            blockGame = false;

            HandleNextRoundButtonsProperties(false);
            ClearBoardAndArray("Clear");
        }

        private void RestartButtonClick(object sender, EventArgs e)
        {
            HandleNextRoundButtonsProperties(false);
            ClearBoardAndArray("Restart");

            blockGame = false;
            GameForm.turn = 0;
            counterLabelXs.Text = counterLabelOs.Text = roundCounterLabel.Text = "0";
        }

        private void ClearBoardAndArray(string typeOfOperation)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GameForm.gameBoard[i, j] = " ";
                    buttons[i, j].Text = null;
                    buttons[i, j].Image = null;
                    if (typeOfOperation == "Restart")
                        buttons[i, j].BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellUndefXSmall;
                    else
                        buttons[i, j].BackgroundImage = turn % 2 == 0 ? global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellUndefXSmall :
                        global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellUndefOSmall;
                }
            }
        }

        private void HandleNextRoundButtonsProperties(bool isActive) //false - make it disabled;  true - enabled;
        {
            nextRoundButton.BackgroundImage = isActive ? global::Tic_Tac_Toe_Main_Program.Properties.Resources.ButtonRed : global::Tic_Tac_Toe_Main_Program.Properties.Resources.TheButton;
            nextRoundButton.Cursor = isActive ? System.Windows.Forms.Cursors.Hand : System.Windows.Forms.Cursors.No;
        }

    }
    public class Buttons : Button
    {
        Button[,] buttonsGroup;

        public Buttons(int rows, int columns) => buttonsGroup = new Button[rows, columns];

        public Button this[int i, int j]
        {
            get
            {
                return buttonsGroup[i, j];
            }
            set
            {
                buttonsGroup[i, j] = value;
            }
        }
    }
}
