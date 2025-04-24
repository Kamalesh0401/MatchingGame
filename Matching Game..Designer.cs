using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WFMatchingGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimerLbl = new System.Windows.Forms.Label();
            this.StopBtn = new System.Windows.Forms.Button();
            this.ScoreTablePanel = new System.Windows.Forms.Panel();
            this.scoreTableGridView = new System.Windows.Forms.DataGridView();
            this.ScoreTableCloseBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.nameLevelPanel = new System.Windows.Forms.TableLayoutPanel();
            this.enterNameLbl = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.gamelevellbl = new System.Windows.Forms.Label();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.ThemeLbl = new System.Windows.Forms.Label();
            this.ComboBoxTheme = new System.Windows.Forms.ComboBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.matchGameLbl = new System.Windows.Forms.Label();
            this.gameOverPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.yourNameLbl = new System.Windows.Forms.Label();
            this.yourCurrentScoreLbl = new System.Windows.Forms.Label();
            this.yourHighScoreLbl = new System.Windows.Forms.Label();
            this.highScoreLbl = new System.Windows.Forms.Label();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.ExistBtn = new System.Windows.Forms.Button();
            this.viewScoreTableBtn = new System.Windows.Forms.Button();
            this.setPlayerBgWorker = new System.ComponentModel.BackgroundWorker();
            this.updatePlayerScrBgWorker = new System.ComponentModel.BackgroundWorker();
            this.ScoreTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTableGridView)).BeginInit();
            this.nameLevelPanel.SuspendLayout();
            this.gameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66668F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66668F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66668F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66668F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66668F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66661F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(500, 450);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Resize += new System.EventHandler(this.Form1_Resize);
            // 
            // TimerLbl
            // 
            this.TimerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLbl.Location = new System.Drawing.Point(51, 0);
            this.TimerLbl.MaximumSize = new System.Drawing.Size(300, 30);
            this.TimerLbl.MinimumSize = new System.Drawing.Size(200, 30);
            this.TimerLbl.Name = "TimerLbl";
            this.TimerLbl.Size = new System.Drawing.Size(200, 30);
            this.TimerLbl.TabIndex = 1;
            this.TimerLbl.Text = "Timer : ";
            this.TimerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimerLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StopBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.StopBtn.Location = new System.Drawing.Point(0, 0);
            this.StopBtn.MaximumSize = new System.Drawing.Size(50, 30);
            this.StopBtn.MinimumSize = new System.Drawing.Size(50, 30);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(50, 30);
            this.StopBtn.TabIndex = 6;
            this.StopBtn.Text = "▶";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // ScoreTablePanel
            // 
            this.ScoreTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ScoreTablePanel.Controls.Add(this.scoreTableGridView);
            this.ScoreTablePanel.Controls.Add(this.ScoreTableCloseBtn);
            this.ScoreTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreTablePanel.Location = new System.Drawing.Point(0, 0);
            this.ScoreTablePanel.MinimumSize = new System.Drawing.Size(500, 450);
            this.ScoreTablePanel.Name = "ScoreTablePanel";
            this.ScoreTablePanel.Size = new System.Drawing.Size(584, 450);
            this.ScoreTablePanel.TabIndex = 10;
            // 
            // scoreTableGridView
            // 
            this.scoreTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scoreTableGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.scoreTableGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scoreTableGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scoreTableGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scoreTableGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.scoreTableGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreTableGridView.EnableHeadersVisualStyles = false;
            this.scoreTableGridView.GridColor = System.Drawing.Color.Gray;
            this.scoreTableGridView.Location = new System.Drawing.Point(0, 38);
            this.scoreTableGridView.Name = "scoreTableGridView";
            this.scoreTableGridView.Size = new System.Drawing.Size(584, 412);
            this.scoreTableGridView.TabIndex = 0;
            // 
            // ScoreTableCloseBtn
            // 
            this.ScoreTableCloseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScoreTableCloseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ScoreTableCloseBtn.Location = new System.Drawing.Point(0, 0);
            this.ScoreTableCloseBtn.Name = "ScoreTableCloseBtn";
            this.ScoreTableCloseBtn.Size = new System.Drawing.Size(584, 38);
            this.ScoreTableCloseBtn.TabIndex = 6;
            this.ScoreTableCloseBtn.Text = "Close";
            this.ScoreTableCloseBtn.UseVisualStyleBackColor = true;
            this.ScoreTableCloseBtn.Click += new System.EventHandler(this.ScoreTableCloseBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // nameLevelPanel
            // 
            this.nameLevelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nameLevelPanel.ColumnCount = 4;
            this.nameLevelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.86329F));
            this.nameLevelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.29452F));
            this.nameLevelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.85616F));
            this.nameLevelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.nameLevelPanel.Controls.Add(this.enterNameLbl, 0, 1);
            this.nameLevelPanel.Controls.Add(this.nameTextBox, 1, 1);
            this.nameLevelPanel.Controls.Add(this.gamelevellbl, 0, 2);
            this.nameLevelPanel.Controls.Add(this.levelComboBox, 1, 2);
            this.nameLevelPanel.Controls.Add(this.ThemeLbl, 0, 3);
            this.nameLevelPanel.Controls.Add(this.ComboBoxTheme, 1, 3);
            this.nameLevelPanel.Controls.Add(this.startGameButton, 1, 4);
            this.nameLevelPanel.Controls.Add(this.matchGameLbl, 1, 0);
            this.nameLevelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLevelPanel.Location = new System.Drawing.Point(0, 0);
            this.nameLevelPanel.MinimumSize = new System.Drawing.Size(500, 450);
            this.nameLevelPanel.Name = "nameLevelPanel";
            this.nameLevelPanel.RowCount = 5;
            this.nameLevelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.nameLevelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.57143F));
            this.nameLevelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.571428F));
            this.nameLevelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.42857F));
            this.nameLevelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.42857F));
            this.nameLevelPanel.Size = new System.Drawing.Size(584, 450);
            this.nameLevelPanel.TabIndex = 0;
            // 
            // enterNameLbl
            // 
            this.enterNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.enterNameLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.enterNameLbl.ForeColor = System.Drawing.Color.White;
            this.enterNameLbl.Location = new System.Drawing.Point(3, 90);
            this.enterNameLbl.Name = "enterNameLbl";
            this.enterNameLbl.Size = new System.Drawing.Size(180, 46);
            this.enterNameLbl.TabIndex = 0;
            this.enterNameLbl.Text = "Enter Name:";
            this.enterNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Location = new System.Drawing.Point(189, 93);
            this.nameTextBox.MinimumSize = new System.Drawing.Size(246, 36);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(246, 36);
            this.nameTextBox.TabIndex = 1;
            // 
            // gamelevellbl
            // 
            this.gamelevellbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gamelevellbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gamelevellbl.ForeColor = System.Drawing.Color.White;
            this.gamelevellbl.Location = new System.Drawing.Point(3, 155);
            this.gamelevellbl.Name = "gamelevellbl";
            this.gamelevellbl.Size = new System.Drawing.Size(180, 30);
            this.gamelevellbl.TabIndex = 2;
            this.gamelevellbl.Text = "Select Level:";
            this.gamelevellbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // levelComboBox
            // 
            this.levelComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.levelComboBox.Location = new System.Drawing.Point(189, 158);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(182, 21);
            this.levelComboBox.TabIndex = 3;
            // 
            // ThemeLbl
            // 
            this.ThemeLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThemeLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.ThemeLbl.ForeColor = System.Drawing.Color.White;
            this.ThemeLbl.Location = new System.Drawing.Point(3, 193);
            this.ThemeLbl.Name = "ThemeLbl";
            this.ThemeLbl.Size = new System.Drawing.Size(180, 30);
            this.ThemeLbl.TabIndex = 2;
            this.ThemeLbl.Text = "Select Theme:";
            this.ThemeLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ComboBoxTheme
            // 
            this.ComboBoxTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTheme.Items.AddRange(new object[] {
            "Classic",
            "Animals",
            "Numbers",
            "Letters",
            "Fruits"});
            this.ComboBoxTheme.Location = new System.Drawing.Point(189, 196);
            this.ComboBoxTheme.Name = "ComboBoxTheme";
            this.ComboBoxTheme.Size = new System.Drawing.Size(182, 21);
            this.ComboBoxTheme.TabIndex = 3;
            // 
            // startGameButton
            // 
            this.startGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startGameButton.ForeColor = System.Drawing.Color.White;
            this.startGameButton.Location = new System.Drawing.Point(189, 256);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(182, 40);
            this.startGameButton.TabIndex = 4;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // matchGameLbl
            // 
            this.matchGameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchGameLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.matchGameLbl.ForeColor = System.Drawing.Color.White;
            this.matchGameLbl.Location = new System.Drawing.Point(189, 0);
            this.matchGameLbl.Name = "matchGameLbl";
            this.matchGameLbl.Size = new System.Drawing.Size(182, 90);
            this.matchGameLbl.TabIndex = 0;
            this.matchGameLbl.Text = "🧠 Matching Game";
            this.matchGameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gameOverPanel.ColumnCount = 3;
            this.gameOverPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameOverPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameOverPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameOverPanel.Controls.Add(this.labelGameOver, 1, 0);
            this.gameOverPanel.Controls.Add(this.yourNameLbl, 1, 1);
            this.gameOverPanel.Controls.Add(this.yourCurrentScoreLbl, 1, 2);
            this.gameOverPanel.Controls.Add(this.yourHighScoreLbl, 1, 3);
            this.gameOverPanel.Controls.Add(this.highScoreLbl, 1, 4);
            this.gameOverPanel.Controls.Add(this.playAgainBtn, 0, 5);
            this.gameOverPanel.Controls.Add(this.ExistBtn, 2, 5);
            this.gameOverPanel.Controls.Add(this.viewScoreTableBtn, 1, 5);
            this.gameOverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOverPanel.Location = new System.Drawing.Point(0, 0);
            this.gameOverPanel.MinimumSize = new System.Drawing.Size(500, 450);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.RowCount = 6;
            this.gameOverPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gameOverPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gameOverPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gameOverPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gameOverPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gameOverPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameOverPanel.Size = new System.Drawing.Size(584, 450);
            this.gameOverPanel.TabIndex = 9;
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGameOver.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Red;
            this.labelGameOver.Location = new System.Drawing.Point(149, 0);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(286, 67);
            this.labelGameOver.TabIndex = 0;
            this.labelGameOver.Text = "GAME OVER";
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yourNameLbl
            // 
            this.yourNameLbl.AutoSize = true;
            this.yourNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.yourNameLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.yourNameLbl.ForeColor = System.Drawing.Color.White;
            this.yourNameLbl.Location = new System.Drawing.Point(149, 67);
            this.yourNameLbl.Name = "yourNameLbl";
            this.yourNameLbl.Size = new System.Drawing.Size(286, 37);
            this.yourNameLbl.TabIndex = 1;
            this.yourNameLbl.Text = "Player: Kamalesh";
            this.yourNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yourCurrentScoreLbl
            // 
            this.yourCurrentScoreLbl.AutoSize = true;
            this.yourCurrentScoreLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.yourCurrentScoreLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.yourCurrentScoreLbl.ForeColor = System.Drawing.Color.LightGreen;
            this.yourCurrentScoreLbl.Location = new System.Drawing.Point(149, 134);
            this.yourCurrentScoreLbl.Name = "yourCurrentScoreLbl";
            this.yourCurrentScoreLbl.Size = new System.Drawing.Size(286, 32);
            this.yourCurrentScoreLbl.TabIndex = 2;
            this.yourCurrentScoreLbl.Text = "Current Score: 100";
            this.yourCurrentScoreLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yourHighScoreLbl
            // 
            this.yourHighScoreLbl.AutoSize = true;
            this.yourHighScoreLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.yourHighScoreLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.yourHighScoreLbl.ForeColor = System.Drawing.Color.Gold;
            this.yourHighScoreLbl.Location = new System.Drawing.Point(149, 201);
            this.yourHighScoreLbl.Name = "yourHighScoreLbl";
            this.yourHighScoreLbl.Size = new System.Drawing.Size(286, 32);
            this.yourHighScoreLbl.TabIndex = 3;
            this.yourHighScoreLbl.Text = "Your High Score: 150";
            this.yourHighScoreLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highScoreLbl
            // 
            this.highScoreLbl.AutoSize = true;
            this.highScoreLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.highScoreLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.highScoreLbl.ForeColor = System.Drawing.Color.Cyan;
            this.highScoreLbl.Location = new System.Drawing.Point(149, 268);
            this.highScoreLbl.Name = "highScoreLbl";
            this.highScoreLbl.Size = new System.Drawing.Size(286, 32);
            this.highScoreLbl.TabIndex = 4;
            this.highScoreLbl.Text = "Top Global Score: 200";
            this.highScoreLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.playAgainBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.playAgainBtn.Location = new System.Drawing.Point(3, 338);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(140, 35);
            this.playAgainBtn.TabIndex = 5;
            this.playAgainBtn.Text = "Play Again";
            this.playAgainBtn.UseVisualStyleBackColor = true;
            this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // ExistBtn
            // 
            this.ExistBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExistBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ExistBtn.Location = new System.Drawing.Point(441, 338);
            this.ExistBtn.Name = "ExistBtn";
            this.ExistBtn.Size = new System.Drawing.Size(140, 35);
            this.ExistBtn.TabIndex = 6;
            this.ExistBtn.Text = "Exit";
            this.ExistBtn.UseVisualStyleBackColor = true;
            this.ExistBtn.Click += new System.EventHandler(this.EixtsBtn_Click);
            // 
            // viewScoreTableBtn
            // 
            this.viewScoreTableBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewScoreTableBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.viewScoreTableBtn.Location = new System.Drawing.Point(149, 338);
            this.viewScoreTableBtn.Name = "viewScoreTableBtn";
            this.viewScoreTableBtn.Size = new System.Drawing.Size(286, 35);
            this.viewScoreTableBtn.TabIndex = 6;
            this.viewScoreTableBtn.Text = "View Score Table";
            this.viewScoreTableBtn.UseVisualStyleBackColor = true;
            this.viewScoreTableBtn.Click += new System.EventHandler(this.LoadLeaderboard);
            // 
            // setPlayerBgWorker
            // 
            this.setPlayerBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.setPlayerCurrentScr);
            this.setPlayerBgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.setPlayerBgWorker_RunWorkerCompleted);
            // 
            // updatePlayerScrBgWorker
            // 
            this.updatePlayerScrBgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updatePlayerCurrentScrBgWorker);
            this.updatePlayerScrBgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.updatePlayerCurrentScrBgWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.TimerLbl);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.nameLevelPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gameOverPanel);
            this.Controls.Add(this.ScoreTablePanel);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "Form1";
            this.Text = "Matching Game";
            this.ScoreTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scoreTableGridView)).EndInit();
            this.nameLevelPanel.ResumeLayout(false);
            this.nameLevelPanel.PerformLayout();
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLbl;
        private System.Windows.Forms.Timer timer2;
        private BackgroundWorker setPlayerBgWorker;
        private BackgroundWorker updatePlayerScrBgWorker;
        private TableLayoutPanel nameLevelPanel;
        private Label enterNameLbl;
        private TextBox nameTextBox;
        private Label gamelevellbl;
        private Label ThemeLbl;
        private ComboBox levelComboBox;
        private ComboBox ComboBoxTheme;
        private Button startGameButton;
        private Label matchGameLbl;
        private TableLayoutPanel gameOverPanel;
        private Label labelGameOver;
        private Button playAgainBtn;
        private Button viewScoreTableBtn;
        private Button ExistBtn;
        private Label highScoreLbl;
        private Label yourCurrentScoreLbl;
        private Label yourHighScoreLbl;
        private Label yourNameLbl;
        private Panel ScoreTablePanel;
        private DataGridView scoreTableGridView;
        private Button ScoreTableCloseBtn;
        private Button StopBtn;
        // this.StopBtn = new System.Windows.Forms.Button();
    }
}

