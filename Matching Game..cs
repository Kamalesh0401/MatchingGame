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
        private SQLlite _sqlLite;
        public Form1()
        {
            InitializeComponent();
            _sqlLite = new SQLlite(this.levelComboBox.Items);
            tableLayoutPanel1.Visible = false;
            gameOverPanel.Visible = false;
            TimerLbl.Visible = false;
            nameLevelPanel.Visible = true;
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
        private char[] ch = { ':' };
        private int elapsedSeconds = 0;
        private int elapsedMinutes = 0;
        private int elapsedHours = 0;
        private int animationStep = 0;
        private int rows = 0;
        private int columns = 0;
        private string _currentPlayerName = "";
        private string _currentPlayerScore = "";
        private int _currentLevel = 0;
        private string _highScore = "";

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
            //MessageBox.Show("Fantastic! You matched all the icons in " + timeDisplay + "", "Congratulations");
            var currenttime = new TimeSpan(elapsedHours, elapsedMinutes, elapsedSeconds);
            if (!string.IsNullOrEmpty(_currentPlayerScore))
            {
                string[] crntPlyrHghtime = _currentPlayerScore?.ToString().Split(ch);
                var score = new TimeSpan(Convert.ToInt32(crntPlyrHghtime[0]), Convert.ToInt32(crntPlyrHghtime[1]), Convert.ToInt32(crntPlyrHghtime[2]));
                if (score > currenttime)
                {
                    this.updatePlayerScrBgWorker.RunWorkerAsync(timeDisplay);
                    //_sqlLite.GameFinished(_currentPlayerName, timeDisplay, _currentLevel.ToString());
                }
            }
            else
            {
                this.updatePlayerScrBgWorker.RunWorkerAsync(timeDisplay);
                // _sqlLite.GameFinished(_currentPlayerName, timeDisplay, _currentLevel.ToString());

            }

            tableLayoutPanel1.Visible = false;
            TimerLbl.Visible = false;
            gameOverPanel.Visible = true;
            DataTable scoreTable = _sqlLite.GetHighScores(_currentLevel);

            var fastestPlayer = scoreTable?.AsEnumerable()
            .Where(row => row.Field<Int64>("Level").ToString() == _currentLevel.ToString() && row.Field<string>("Score").ToString() != "0")
            .Select(row => new
            {
                Name = row.Field<string>("Name").ToString(),
                Time = row.Field<string>("Score").ToString(),
                TimeParts = row.Field<string>("Score").ToString().Split(ch),
            })
           .Select(row => new
           {
               row.Name,
               Time = new TimeSpan(Convert.ToInt32(row.TimeParts[0]), Convert.ToInt32(row.TimeParts[1]), Convert.ToInt32(row.TimeParts[2]))
           })
           .OrderBy(row => row.Time).FirstOrDefault();

            this.yourNameLbl.Text = $"Name: {_currentPlayerName}";
            this.yourCurrentScoreLbl.Text = $"Current Score: {currenttime}";
            this.yourHighScoreLbl.Text = $"High Score: {(!string.IsNullOrEmpty(_currentPlayerScore) ? _currentPlayerScore : currenttime.ToString())}";

            if (!string.IsNullOrEmpty(fastestPlayer.ToString()))
            {
                this.highScoreLbl.Text = $"Fastest Player: {fastestPlayer?.Name ?? "N/A"}, Score: {fastestPlayer?.Time}"; //, Level: {(_currentLevel == 1 ? "Easy" : _currentLevel == 2 ? "Medium" : "Hard")}
            }
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

            string timeDisplay = string.Format("{0:00}:{1:00}:{2:00}", elapsedHours, elapsedMinutes, elapsedSeconds);

            this.TimerLbl.Text = "Timer :" + timeDisplay;

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                float newFontSize;
                if (this.Width > 1500)
                {
                    newFontSize = this.Width / 12f;
                }
                else if (this.Width <= 1500 && this.Width > 1000)
                {
                    newFontSize = this.Width / 15f;

                }
                else if (this.Width <= 1000 && this.Width > 600)
                {
                    newFontSize = this.Width / 17f;
                }
                else
                {
                    newFontSize = this.Width / 15f;
                }
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
            _currentPlayerName = nameTextBox.Text;
            string selectedLevel = levelComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(_currentPlayerName))
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
            TimerLbl.Visible = true;
            this.setPlayerBgWorker.RunWorkerAsync();
        }
        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            ResetValues();
            nameLevelPanel.Visible = false;
            gameOverPanel.Visible = false;
            tableLayoutPanel1.Visible = true;
            TimerLbl.Visible = true;
        }
        private void EixtsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetGridSizeByLevel(string level)
        {
            // Your logic to determine rows and columns based on the level
            switch (level)
            {
                case "Easy":
                    _currentLevel = 1;
                    rows = 2;
                    columns = 4;
                    break;
                case "Medium":
                    _currentLevel = 2;
                    rows = 4;
                    columns = 4;
                    break;
                case "Hard":
                    _currentLevel = 3;
                    rows = 4;
                    columns = 6;
                    break;
                default:
                    _currentLevel = 1;
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

        private void updatePlayerCurrentScrBgWorker(object sender, DoWorkEventArgs e)
        {
            string timeDisplay = "";
            if (e.Argument != null)
                if (e.Argument is string)
                {
                    timeDisplay = e.Argument as string;
                }
                else
                {
                    string[] parameters = (string[])e.Argument;
                    timeDisplay = parameters[0];

                }
            _sqlLite.GameFinished(_currentPlayerName, timeDisplay, _currentLevel.ToString());
        }

        private void updatePlayerCurrentScrBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            updatePlayerScrBgWorker.Dispose();
        }
        private void setPlayerCurrentScr(object sender, DoWorkEventArgs e)
        {
            _currentPlayerScore = _sqlLite.LoadOrCreatePlayerScore(_currentPlayerName, _currentLevel.ToString());
        }

        private void setPlayerBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            setPlayerBgWorker.Dispose();
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
        private string FormatTimeSpan(TimeSpan ts)
        {
            return $"{ts.Hours:D2}h:{ts.Minutes:D2} min:{ts.Seconds:D2} sec";
        }
    }


}

