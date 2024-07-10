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
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

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
