using System.Diagnostics.Eventing.Reader;

namespace GameForm
{
    public partial class TicTacToe : Form
    {
        private int playerTurn = 1;
        private string[] boardNums = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private int playedNo = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void picTL_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                picTL.Image = Properties.Resources.x;
                boardNums[1] = "x";
                playerTurn = 2;
            }
            else
            {
                picTL.Image = Properties.Resources.o;
                boardNums[1] = "o";
                playerTurn = 1;
            }
            picTL.Enabled = false;
            playedNo++;
            checkWin();
        }

        private void picTM_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                picTM.Image = Properties.Resources.x;
                boardNums[2] = "x";
                playerTurn = 2;
            }
            else
            {
                picTM.Image = Properties.Resources.o;
                boardNums[2] = "o";
                playerTurn = 1;
            }
            picTM.Enabled = false;
            playedNo++;
            checkWin();
        }

        private void picTR_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                picTR.Image = Properties.Resources.x;
                boardNums[3] = "x";
                playerTurn = 2;
            }
            else
            {
                picTR.Image = Properties.Resources.o;
                boardNums[3] = "o";
                playerTurn = 1;
            }
            picTR.Enabled = false;
            playedNo++;
            checkWin();
        }

        private void picML_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                picML.Image = Properties.Resources.x;
                boardNums[4] = "x";
                playerTurn = 2;
            }
            else
            {
                picML.Image = Properties.Resources.o;
                boardNums[4] = "o";
                playerTurn = 1;
            }
            picML.Enabled = false;
            playedNo++;
            checkWin();
        }

        private void picMM_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                picMM.Image = Properties.Resources.x;
                boardNums[5] = "x";
                playerTurn = 2;
            }
            else
            {
                picMM.Image = Properties.Resources.o;
                boardNums[5] = "o";
                playerTurn = 1;
            }
            picMM.Enabled = false;
            playedNo++;
            checkWin();
        }

        private void picMR_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                picMR.Image = Properties.Resources.x;
                boardNums[6] = "x";
                playerTurn = 2;
            }
            else
            {
                picMR.Image = Properties.Resources.o;
                boardNums[6] = "o";
                playerTurn = 1;
            }
            picMR.Enabled = false;
            playedNo++;
            checkWin();
        }

        private void picBL_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                picBL.Image = Properties.Resources.x;
                boardNums[7] = "x";
                playerTurn = 2;
            }
            else
            {
                picBL.Image = Properties.Resources.o;
                boardNums[7] = "o";
                playerTurn = 1;
            }
            picBL.Enabled = false;
            playedNo++;
            checkWin();
        }

        private void picBM_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                picBM.Image = Properties.Resources.x;
                boardNums[8] = "x";
                playerTurn = 2;
            }
            else
            {
                picBM.Image = Properties.Resources.o;
                boardNums[8] = "o";
                playerTurn = 1;
            }
            picBM.Enabled = false;
            playedNo++;
            checkWin();
        }

        private void picBR_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {
                picBR.Image = Properties.Resources.x;
                boardNums[9] = "x";
                playerTurn = 2;
            }
            else
            {
                picBR.Image = Properties.Resources.o;
                boardNums[9] = "o";
                playerTurn = 1;
            }
            picBR.Enabled = false;
            playedNo++;
            checkWin();
        }
        public void checkWin()
        {   //check wins in rows
            bool row1 = boardNums[1] == boardNums[2] && boardNums[2] == boardNums[3];
            bool row2 = boardNums[4] == boardNums[5] && boardNums[5] == boardNums[6];
            bool row3 = boardNums[7] == boardNums[8] && boardNums[8] == boardNums[9];

            //check wins in columns
            bool column1 = boardNums[1] == boardNums[4] && boardNums[4] == boardNums[7];
            bool column2 = boardNums[2] == boardNums[5] && boardNums[5] == boardNums[8];
            bool column3 = boardNums[3] == boardNums[6] && boardNums[6] == boardNums[9];

            //check wins diagnoally
            bool diagDown = boardNums[1] == boardNums[5] && boardNums[5] == boardNums[9];
            bool diagUp = boardNums[7] == boardNums[5] && boardNums[5] == boardNums[3];

            if (row1 == row2 == row3)
            {
                MessageBox.Show("You Won!");
                Application.Restart();
            }
            else if (column1 && column2 && column3)
            {
                MessageBox.Show("You Won!");
                Application.Restart();
            }
            else if (diagDown)
            {
                MessageBox.Show("Yon Won!");
                Application.Restart();
            }
            else if (diagUp)
            {
                MessageBox.Show("Yon Won!");
                Application.Restart();
            }
            else if (playedNo == 9)
            {
                MessageBox.Show("Tie!");
                Application.Restart();
            }
        }

    }
}          




