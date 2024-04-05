namespace CS162_SlotMachineSim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            slot3_pictureBox = new PictureBox();
            slot2_pictureBox = new PictureBox();
            slot1_pictureBox = new PictureBox();
            spinButton = new Button();
            groupBox1 = new GroupBox();
            bet_TextBox = new TextBox();
            exitButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slot3_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot2_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot1_pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(slot3_pictureBox);
            panel1.Controls.Add(slot2_pictureBox);
            panel1.Controls.Add(slot1_pictureBox);
            panel1.Location = new Point(63, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 207);
            panel1.TabIndex = 0;
            // 
            // slot3_pictureBox
            // 
            slot3_pictureBox.BackColor = SystemColors.Control;
            slot3_pictureBox.Location = new Point(490, 35);
            slot3_pictureBox.Name = "slot3_pictureBox";
            slot3_pictureBox.Size = new Size(133, 138);
            slot3_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            slot3_pictureBox.TabIndex = 2;
            slot3_pictureBox.TabStop = false;
            // 
            // slot2_pictureBox
            // 
            slot2_pictureBox.BackColor = SystemColors.Control;
            slot2_pictureBox.Location = new Point(253, 35);
            slot2_pictureBox.Name = "slot2_pictureBox";
            slot2_pictureBox.Size = new Size(133, 138);
            slot2_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            slot2_pictureBox.TabIndex = 1;
            slot2_pictureBox.TabStop = false;
            // 
            // slot1_pictureBox
            // 
            slot1_pictureBox.BackColor = SystemColors.Control;
            slot1_pictureBox.Location = new Point(16, 35);
            slot1_pictureBox.Name = "slot1_pictureBox";
            slot1_pictureBox.Size = new Size(133, 138);
            slot1_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            slot1_pictureBox.TabIndex = 0;
            slot1_pictureBox.TabStop = false;
            // 
            // spinButton
            // 
            spinButton.BackColor = Color.PaleGreen;
            spinButton.Location = new Point(6, 57);
            spinButton.Name = "spinButton";
            spinButton.Size = new Size(154, 23);
            spinButton.TabIndex = 1;
            spinButton.Text = "SPIN";
            spinButton.UseVisualStyleBackColor = false;
            spinButton.Click += spin;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bet_TextBox);
            groupBox1.Controls.Add(spinButton);
            groupBox1.Location = new Point(303, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 90);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Your Bet";
            // 
            // bet_TextBox
            // 
            bet_TextBox.Location = new Point(6, 28);
            bet_TextBox.Name = "bet_TextBox";
            bet_TextBox.Size = new Size(154, 23);
            bet_TextBox.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(688, 411);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Slot Machine Sim";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)slot3_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot2_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot1_pictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button spinButton;
        private PictureBox slot3_pictureBox;
        private PictureBox slot2_pictureBox;
        private PictureBox slot1_pictureBox;
        private GroupBox groupBox1;
        private TextBox bet_TextBox;
        private Button exitButton;
    }
}
