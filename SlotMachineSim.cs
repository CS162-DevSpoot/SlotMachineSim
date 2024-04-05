namespace CS162_SlotMachineSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] slotSpinned = new int[3];
        decimal amountInserted = 0m;
        decimal amountWon = 0m;

        private int randomSlot()
        {
            Random rand = new Random();

            return rand.Next(1, 5);
        }

        private void randomSpin()
        {
            int slot1 = randomSlot();
            int slot2 = randomSlot();
            int slot3 = randomSlot();

            slotSpinned = [slot1, slot2, slot3];
        }

        private void displaySpin()
        {
            PictureBox[] slotsPictueBox = [slot1_pictureBox, slot2_pictureBox, slot3_pictureBox];


            int index = 0;
            foreach (var slotSpin in slotSpinned)
            {
                switch (slotSpin)
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

        private void calculateWinnings()
        {
            try
            {
                decimal bet = decimal.Parse(bet_TextBox.Text);
                decimal won = 0m;

                if (slotSpinned[0] == slotSpinned[1] || slotSpinned[1] == slotSpinned[2])
                {
                    won = bet / 2m;
                }

                if (slotSpinned[0] == slotSpinned[1] && slotSpinned[1] == slotSpinned[2])
                {
                    won = bet * 2m;
                }

                amountInserted = amountInserted + bet;
                amountWon = amountWon + won;

                if(won == bet / 2m)
                {
                    MessageBox.Show($"You've won ${won.ToString("c")}! You have inserted ${amountInserted.ToString("c")} and have won ${amountWon} so far.");
                    return;
                }

                if(won == bet * 2m)
                {
                    MessageBox.Show($"You got a jackpot and doubled your amount! You've won ${won.ToString("c")}! You have inserted ${amountInserted.ToString("c")} and have won ${amountWon} so far.");
                    return;
                }

                MessageBox.Show("You lost. Try again.");

               
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message);
            }
        }

        private void spin(object sender, EventArgs e)
        {
            try
            {
                decimal bet = decimal.Parse(bet_TextBox.Text);

                Random random = new Random();
                int loops = random.Next(6, 16);

                for (int i = 0; i < loops; i++)
                {
                    randomSpin();
                    displaySpin();
                    wait(0300);
                }

                calculateWinnings();
            }catch(Exception ee){
                MessageBox.Show(ee.Message);
            }
        }

  

        /// 
        /// “Wait One Second in Running Program.” Stack Overflow, stackoverflow.com/a/52906286/24042647. Accessed 5 Apr. 2024.
        /// Method that delays a task from contiuning, using this to visuallt show he slots spinning.

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
      
            Application.Exit();
            this.Close();
        }
    }
}
