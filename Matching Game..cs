using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMatchingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Visible = false;
            //AssignIconsToSquares();
            //MessageBoxButtons MsgBtn = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show("Ready to play?", "Let's Start", MsgBtn);
            //if (result == DialogResult.Yes)
            //{
            //    timer2.Start();
            //}
            //else
            //{
            //    Task.Delay(500);
            //    this.Close();
            //}
        }

        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!",     // Exclamation mark - speaker
            "N", "N",     // Flag
            "k", "k",     // Airplane
            "y", "y",     // Checkmark
            "b", "b",     // Star
            "v", "v",     // Key
            "w", "w",     // Lock
            "z", "z",     // Heart
            "d", "d",     // Clock
            "t", "t",     // Mail
            "f", "f",     // Note
            "h", "h",     // Pen
            "j", "j",     // Globe
            "l", "l",     // Eye
            "p", "p"      // Thumbs up
        };

        Label firstClicked = null;
        Label secondClicked = null;
        private int elapsedSeconds = 0;
        private int elapsedMinutes = 0;
        private int elapsedHours = 0;
        private int animationStep = 0;
        private int rows = 0;
        private int columns = 0;


        private void ResetValues()
        {
            //firstClicked = null;
            //secondClicked = null;
            elapsedSeconds = 0;
            elapsedMinutes = 0;
            elapsedHours = 0;
            animationStep = 0;
            icons = new List<string>()
            {
            "!", "!","N", "N","k", "k","y", "y","b", "b","v", "v","w", "w","z", "z","d", "d","t", "t","f", "f","h", "h","j", "j","l", "l","p", "p"
            };
            AssignIconsToSquares();
            timer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // ignore the click when the label already revealed
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // If firstClicked is null,
                // so set firstClicked to the label that the player 
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    HighlightMatch(firstClicked, secondClicked);
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                timer1.Start();
            }
        }
        private void CheckForWinner()
        {
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            timer2.Stop();
            string timeDisplay = string.Format("{0:00}:{1:00}:{2:00}", elapsedHours, elapsedMinutes, elapsedSeconds);
            MessageBox.Show("Fantastic! You matched all the icons in " + timeDisplay + "", "Congratulations");
            //Close();
            ResetValues();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            //HighlightMisMatch(firstClicked, secondClicked);
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;

            CheckForWinner();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            if (elapsedSeconds == 60)
            {
                elapsedMinutes++;
                elapsedSeconds = 0;
            }
            if (elapsedMinutes == 60)
            {
                elapsedHours++;
                elapsedMinutes = 0;
            }

            // Format the time as HH:MM:SS
            string timeDisplay = string.Format("{0:00}:{1:00}:{2:00}", elapsedHours, elapsedMinutes, elapsedSeconds);

            this.label17.Text = "Timer :" + timeDisplay;

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                float newFontSize = this.Width / 30f; // Adjust this value as needed
                c.Font = new Font("Webdings", newFontSize, FontStyle.Bold);
            }
        }
        private async void HighlightMatch(Label card1, Label card2)
        {
            var temp = card1.BackColor;
            card1.BackColor = Color.LimeGreen;
            card2.BackColor = Color.LimeGreen;
            await Task.Delay(300);
            card1.BackColor = temp;
            card2.BackColor = temp;
        }
        private async void HighlightMisMatch(Label card1, Label card2)
        {
            var temp = card1.BackColor;
            card1.BackColor = Color.DarkRed;
            card2.BackColor = Color.DarkRed;
            await Task.Delay(300);
            card1.ForeColor = Color.Black;
            card2.ForeColor = Color.Black;
            card1.BackColor = temp;
            card2.BackColor = temp;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            string playerName = nameTextBox.Text;
            string selectedLevel = levelComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Please enter your name.", "Information");
                return;
            }

            if (string.IsNullOrEmpty(selectedLevel))
            {
                MessageBox.Show("Please select a game level.", "Information");
                return;
            }
            SetGridSizeByLevel(selectedLevel);

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            tableLayoutPanel1.RowCount = rows;
            tableLayoutPanel1.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / rows));
            }
            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columns));
            }

            InitializeGameGrid();

            nameLevelPanel.Visible = false;
            tableLayoutPanel1.Visible = true;
        }

        private void SetGridSizeByLevel(string level)
        {
            // Your logic to determine rows and columns based on the level
            switch (level)
            {
                case "Easy":
                    rows = 2;
                    columns = 4;
                    break;
                case "Medium":
                    rows = 4;
                    columns = 4;
                    break;
                case "Hard":
                    rows = 4;
                    columns = 6;
                    break;
                default:
                    rows = 2;
                    columns = 4;
                    break;
            }
        }
        private void InitializeGameGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Label iconLabel = CreateIconLabel();
                    tableLayoutPanel1.Controls.Add(iconLabel, j, i);
                }
            }
            AssignIconsToSquares();
            timer2.Start();
        }

        private Label CreateIconLabel()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("Webdings", 48F, FontStyle.Bold); // Example icon font
            label.ForeColor = label.BackColor;
            label.Click += new EventHandler(label1_Click); // Your click event handler
            return label;
        }
        private void AssignIconsToSquares()
        {
            var temp = icons.Take(tableLayoutPanel1.Controls.Count).ToList();
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(temp.Count);
                    iconLabel.Text = temp[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    temp.RemoveAt(randomNumber);
                }
            }
        }
    }


}

