namespace CS162_SlotMachineSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global vairables
        int[] slotSpinned = new int[3]; // Array with three spots for containing the actual values that were spinned.
        decimal amountInserted = 0m; // Variable to track the amount inserted.
        decimal amountWon = 0m; //Vairbale to track the total amount of winnings.

        private int randomSlot() // Method that picks a random value that is stored into the slotsSpinned vairbale.
        {
            Random rand = new Random();

            return rand.Next(1, 5); //We have 4 possible values for each slot. Pick a random value from 1 to (including) 4.
        }

        private void randomSpin() //Method that generates three random values for our SlotsSPinned vairbale. Then assigns it.
        {
            int slot1 = randomSlot(); //Get a random value,
            int slot2 = randomSlot();
            int slot3 = randomSlot();

            slotSpinned = [slot1, slot2, slot3]; //Assign it to our slotsSpinned vairable.
        }

        private void displaySpin() //Method that displays our slots value, sets the image.
        {
            PictureBox[] slotsPictueBox = [slot1_pictureBox, slot2_pictureBox, slot3_pictureBox]; //Array of pictureboxes for eahc each slot.


            int index = 0; //Index tracking vairable.
            foreach (var slotSpin in slotSpinned) //For each of the three slots, update the coressponding picturebox.
            {
                switch (slotSpin) //Switch case that determines what image to show based on the slot value,
                {
                    case 1:
                        slotsPictueBox[index].Image = Resource.Reputation; break;
                    case 2:
                        slotsPictueBox[index].Image = Resource._1989TV; break;
                    case 3:
                        slotsPictueBox[index].Image = Resource.SpeakNowTV; break;
                    case 4:
                        slotsPictueBox[index].Image = Resource.RedTV; break;
                }
                index++;
            }
        }

        private void calculateWinnings() //Method that determins the result of the slot spin,
        {
            try
            {
                decimal bet = decimal.Parse(bet_TextBox.Text); //Vairables that holds the amount inserted for this spin.
                decimal won = 0m; //Vairable that stores how much was won this session.

                if (slotSpinned[0] == slotSpinned[1] || slotSpinned[1] == slotSpinned[2]) //Checks for two of the three possible winnings. LWW & WWL.
                {
                    won = bet / 2m; //Sets the winning prize to half of the bet.
                }

                if (slotSpinned[0] == slotSpinned[1] && slotSpinned[1] == slotSpinned[2]) //Checks for the third way of winning. A jackpot, WWW.
                {
                    won = bet * 2m; //Sets the winning prize to twice the amount of the bet.
                }

                amountInserted = amountInserted + bet; //Updates the global amount inserted.
                amountWon = amountWon + won; //Updates the global amount won.

                if(won == bet / 2m) // Displays the winning condition message for the two of the three possible winning options.
                {
                    MessageBox.Show($"You've won ${won.ToString("c")}! You have inserted ${amountInserted.ToString("c")} and have won ${amountWon} so far.");
                    return;
                }

                if(won == bet * 2m) //Displays the winning xondition message for the jackpots.
                {
                    MessageBox.Show($"You got a jackpot and doubled your amount! You've won ${won.ToString("c")}! You have inserted ${amountInserted.ToString("c")} and have won ${amountWon} so far.");
                    return;
                }

                MessageBox.Show($"You lost, try again. You have inserted ${amountInserted.ToString("c")} and have won ${amountWon} so far."); //If no winnings occured, let the player know.

               
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message); // Catch any errors.
            }
        }

        private void spin(object sender, EventArgs e) //The method the main mehtod that makes the game go when the player wants to spin.
        {
            try
            {
                decimal bet = decimal.Parse(bet_TextBox.Text); //We check the bet.

                Random random = new Random();
                int loops = random.Next(6, 16); // we pick a random amount of times to make the slots spin.

                for (int i = 0; i < loops; i++) //For each loop.
                {
                    randomSpin(); //Randomnize the slots value.
                    displaySpin(); //Display the slots.
                    wait(0300); //Wait .3 of a second before contiuning.
                }

                calculateWinnings(); //then at the end, calculate any winnings.
            }catch(Exception ee){
                MessageBox.Show(ee.Message); //Cathc any errors.
            }
        }

  

        /// 
        /// “Wait One Second in Running Program.” Stack Overflow, stackoverflow.com/a/52906286/24042647. Accessed 5 Apr. 2024.
        /// Method that delays a task from contiuning, using this to visually show he slots spinning.

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
      
            Application.Exit(); // Closes the actual application, not just the window,
            this.Close();
        }
    }
}
