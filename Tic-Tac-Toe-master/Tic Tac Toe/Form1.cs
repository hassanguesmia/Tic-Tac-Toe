using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int turncount = 0; //shows how many turns have passed
        private bool isplayerXturn = true; //X's turn
        private bool isplayerYturn = false;// Y's turn. This isn't necessary except to show who's turn it is
        //(there is a text box in the app that show's whos turn it is, so the boolean is neccesary)
        public Image xImage = Properties.Resources.font_illustration_letter_x_EM72Y5; //gets the X image from resources that I downloaded
        public Image oImage = Properties.Resources.font_illustration_letter_o_EM737K; //same as above, but for O
       public int[,] m_TicTacToArray = new int[3, 3]; 

        public Form1()
        {
            
            InitializeComponent();
            AttachClickHandlers();

        }
        private void AttachClickHandlers()
        {
            // Attach Button9_Click to all buttons' Click event
            this.Button1.Click += Button9_Click;
            this.Button2.Click += Button9_Click;
            this.Button3.Click += Button9_Click;
            this.Button4.Click += Button9_Click;
            this.Button5.Click += Button9_Click;
            this.Button6.Click += Button9_Click;
            this.Button7.Click += Button9_Click;
            this.Button8.Click += Button9_Click;
            this.Button9.Click += Button9_Click;

            //Initalizing the text box to show who's turn it is
            UpdateTurnTextBox();

        }


        private void UpdateTurnTextBox()
        {
            TurnTextBox.Text = isplayerXturn ? "Player X's turn" : "Player O's turn";
        }
        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void button4_Click(object sender, EventArgs e)
        //{

        //}

        //private void button5_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void Button3_Click(object sender, EventArgs e)
        //{

        //}

        //private void Button6_Click(object sender, EventArgs e)
        //{

        //}

        //private void Button7_Click(object sender, EventArgs e)
        //{

        //}

        //private void Button8_Click(object sender, EventArgs e)
        //{

        //}

        private void Button9_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
           
            if (button == null)
            {
                MessageBox.Show("Button is null");
                return;
            }
            if (button.BackgroundImage == null)

            {
                button.BackgroundImage = isplayerXturn ? xImage : oImage;
                // turn booleans stated below
            int iValue = isplayerXturn ? 1 : 2;
            if(Button1 == button)
            {
                m_TicTacToArray[0,0] = iValue;
            }
            else if(Button2 == button)
            {
                m_TicTacToArray[0,1] = iValue;
            }
            else if(Button3 == button)
            {
                m_TicTacToArray[0,2] = iValue;
            }
            else if(Button4 == button)
            {
                m_TicTacToArray[1,0] = iValue;
            }
            else if(Button5 == button)
            {
                m_TicTacToArray[1,1] = iValue;
            }
            else if(Button6 == button)
            {
                m_TicTacToArray[1,2] = iValue;
            }
            else if(Button7 == button)
            {
                m_TicTacToArray[2,0] = iValue;
            }
            else if(Button8 == button)
            {
                m_TicTacToArray[2,1] = iValue;
            }
            else if(Button9 == button)
            {
                m_TicTacToArray[2,2] = iValue;
            }
            int vx1 = 0;
            int vx2 = 0;
            int vx3 = 0;

            int hx1 = 0;
            int hx2 = 0;
            int hx3 = 0;

            int dx1 = 0;
            int dx2 = 0;

            int vO1 = 0;
            int vO2 = 0;
            int vO3 = 0;

            int hO1 = 0;
            int hO2 = 0;
            int hO3 = 0;

            int dO1 = 0;
            int dO2 = 0;


             for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //1st column
                    if(i == 0 && (j == 0 || j == 1 || j == 2))
                    {
                        if(m_TicTacToArray[i,j] == 1)
                        {
                            vx1 += m_TicTacToArray[i,j];
                        }
                        else if(m_TicTacToArray[i,j] == 2)
                        {
                            vO1 += m_TicTacToArray[i,j];
                        }
                    }
                    //2nd column
                    if(i == 1 && (j == 0 || j == 1 || j == 2))
                    {
                        if(m_TicTacToArray[i,j] == 1)
                        {
                            vx2 += m_TicTacToArray[i,j];
                        }
                        else if(m_TicTacToArray[i,j] == 2)
                        {
                            vO2 += m_TicTacToArray[i,j];
                        }
                    }
                    //3rd column
                    if(i == 2 && (j == 0 || j == 1 || j == 2))
                    {
                        if(m_TicTacToArray[i,j] == 1)
                        {                        
                            vx3 += m_TicTacToArray[i,j];
                        }
                        else if(m_TicTacToArray[i,j] == 2)
                        {
                            vO3 += m_TicTacToArray[i,j];
                        }
                    }
                    //1st row
                    if(j == 0 && (i == 0 || i == 1 || i == 2))
                    {
                        if(m_TicTacToArray[i,j] == 1)
                        { 
                            hx1+= m_TicTacToArray[i,j];
                        }
                        else if(m_TicTacToArray[i,j] == 2)
                        {
                            hO1 += m_TicTacToArray[i,j];
                        }
                    }
                    //2nd row
                    if(j == 1 && (i == 0 || i == 1 || i == 2))
                    {
                        if(m_TicTacToArray[i,j] == 1)
                        { 
                            hx2 += m_TicTacToArray[i,j];
                        }
                        else if(m_TicTacToArray[i,j] == 2)
                        {
                            hO2 += m_TicTacToArray[i,j];
                        }
                    }
                    //3rd row
                    if(j == 2 && (i == 0 || i == 1 || i == 2))
                    {
                        if(m_TicTacToArray[i,j] == 1)
                        {
                            hx3 += m_TicTacToArray[i,j];
                        }
                        else if(m_TicTacToArray[i,j] == 2)
                        {
                            hO3 += m_TicTacToArray[i,j];
                        }
                    }
                    //1st diagonal
                    if((i == 0 && j == 0) || (i == 1 && j == 1) || (i == 2 && j == 2))
                    {
                        if(m_TicTacToArray[i,j] == 1)
                        {
                            dx1 += m_TicTacToArray[i,j];
                        }
                        else if(m_TicTacToArray[i,j] == 2)
                        {
                            dO1 += m_TicTacToArray[i,j];
                        }
                    }
                    //2nd diagonal
                    if((i == 0 && j == 2) || (i == 1 && j == 1) || (i == 2 && j == 0))
                    {
                        if(m_TicTacToArray[i,j] == 1)
                        {
                            dx2 += m_TicTacToArray[i,j];
                        }
                        else if(m_TicTacToArray[i,j] == 2)
                        {
                            dO2 += m_TicTacToArray[i,j];
                        }
                    }
                    if(vx1 == 3 || vx2 == 3 || vx3 == 3  || hx1 == 3 || hx2 == 3 || hx3 == 3 || dx1== 3 || dx2 == 3)
                    {
                            MessageBox.Show("X has won!");
                            this.Close();
                    }
                    else if(vO1 == 6 || vO2 == 6 || vO3 ==8  || hO1 == 6 || hO2 == 6 || hO3 == 6 || dO1== 6 || dO2 == 6)
                    {
                            MessageBox.Show("O has won!");
                            this.Close();
                    }
                }
             }


            isplayerXturn = !isplayerXturn;
            isplayerYturn = !isplayerYturn;

                //Text box turn code
                UpdateTurnTextBox();
                //turncount with the ++ is the turn counter used by the game. turncount was declared an int variable earlier
                turncount++;
                //this is debug code below, still have not integrated it fully.
                Console.WriteLine($"Button clicked. isplayerXTurn is now: {isplayerXturn}, turnCount is now: {turncount}");
            }

        }
    }
}
