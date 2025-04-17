using System;
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerLbl = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.nameLevelPanel = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.ExistBtn = new System.Windows.Forms.Button();
            this.highScoreLbl = new System.Windows.Forms.Label();
            this.yourCurrentScoreLbl = new System.Windows.Forms.Label();
            this.yourHighScoreLbl = new System.Windows.Forms.Label();
            this.yourNameLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.label31, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label30, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label29, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label28, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label27, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label26, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label25, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label24, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label23, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label21, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label19, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(350, 300);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 588);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label31
            // 
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label31.Location = new System.Drawing.Point(759, 469);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(144, 118);
            this.label31.TabIndex = 29;
            this.label31.Text = "c";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label31.Click += new System.EventHandler(this.label1_Click);
            // 
            // label30
            // 
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label30.Location = new System.Drawing.Point(759, 352);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(144, 116);
            this.label30.TabIndex = 28;
            this.label30.Text = "c";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label30.Click += new System.EventHandler(this.label1_Click);
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label29.Location = new System.Drawing.Point(759, 235);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(144, 116);
            this.label29.TabIndex = 27;
            this.label29.Text = "c";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label29.Click += new System.EventHandler(this.label1_Click);
            // 
            // label28
            // 
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label28.Location = new System.Drawing.Point(759, 118);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(144, 116);
            this.label28.TabIndex = 26;
            this.label28.Text = "c";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label28.Click += new System.EventHandler(this.label1_Click);
            // 
            // label27
            // 
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label27.Location = new System.Drawing.Point(759, 1);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(144, 116);
            this.label27.TabIndex = 25;
            this.label27.Text = "c";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.Click += new System.EventHandler(this.label1_Click);
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label26.Location = new System.Drawing.Point(608, 469);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(144, 118);
            this.label26.TabIndex = 24;
            this.label26.Text = "c";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.Click += new System.EventHandler(this.label1_Click);
            // 
            // label25
            // 
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label25.Location = new System.Drawing.Point(457, 469);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(144, 118);
            this.label25.TabIndex = 23;
            this.label25.Text = "c";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.Click += new System.EventHandler(this.label1_Click);
            // 
            // label24
            // 
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label24.Location = new System.Drawing.Point(306, 469);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(144, 118);
            this.label24.TabIndex = 22;
            this.label24.Text = "c";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label24.Click += new System.EventHandler(this.label1_Click);
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label23.Location = new System.Drawing.Point(155, 469);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(144, 118);
            this.label23.TabIndex = 21;
            this.label23.Text = "c";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.Click += new System.EventHandler(this.label1_Click);
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label22.Location = new System.Drawing.Point(4, 469);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 118);
            this.label22.TabIndex = 20;
            this.label22.Text = "c";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Click += new System.EventHandler(this.label1_Click);
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label21.Location = new System.Drawing.Point(608, 352);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(144, 116);
            this.label21.TabIndex = 19;
            this.label21.Text = "c";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Click += new System.EventHandler(this.label1_Click);
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label20.Location = new System.Drawing.Point(608, 235);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 116);
            this.label20.TabIndex = 18;
            this.label20.Text = "c";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.label1_Click);
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label19.Location = new System.Drawing.Point(608, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 116);
            this.label19.TabIndex = 17;
            this.label19.Text = "c";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.label1_Click);
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label18.Location = new System.Drawing.Point(608, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 116);
            this.label18.TabIndex = 16;
            this.label18.Text = "c";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.Location = new System.Drawing.Point(457, 352);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 116);
            this.label16.TabIndex = 15;
            this.label16.Text = "c";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label15.Location = new System.Drawing.Point(306, 352);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 116);
            this.label15.TabIndex = 14;
            this.label15.Text = "c";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.Location = new System.Drawing.Point(155, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 116);
            this.label14.TabIndex = 13;
            this.label14.Text = "c";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label13.Location = new System.Drawing.Point(4, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 116);
            this.label13.TabIndex = 12;
            this.label13.Text = "c";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.Location = new System.Drawing.Point(457, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 116);
            this.label12.TabIndex = 11;
            this.label12.Text = "c";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.Location = new System.Drawing.Point(306, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 116);
            this.label11.TabIndex = 10;
            this.label11.Text = "c";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.Location = new System.Drawing.Point(155, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 116);
            this.label10.TabIndex = 9;
            this.label10.Text = "c";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.Location = new System.Drawing.Point(4, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 116);
            this.label9.TabIndex = 8;
            this.label9.Text = "c";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.Location = new System.Drawing.Point(457, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 116);
            this.label8.TabIndex = 7;
            this.label8.Text = "c";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.Location = new System.Drawing.Point(306, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 116);
            this.label7.TabIndex = 6;
            this.label7.Text = "c";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.Location = new System.Drawing.Point(155, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 116);
            this.label6.TabIndex = 5;
            this.label6.Text = "c";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(4, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 116);
            this.label5.TabIndex = 4;
            this.label5.Text = "c";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(457, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 116);
            this.label4.TabIndex = 3;
            this.label4.Text = "c";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "c";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(155, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 116);
            this.label2.TabIndex = 1;
            this.label2.Text = "c";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(306, 1);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(144, 116);
            this.label3.TabIndex = 2;
            this.label3.Text = "c";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerLbl
            // 
            this.TimerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLbl.Location = new System.Drawing.Point(12, 9);
            this.TimerLbl.MaximumSize = new System.Drawing.Size(300, 30);
            this.TimerLbl.MinimumSize = new System.Drawing.Size(200, 30);
            this.TimerLbl.Name = "TimerLbl";
            this.TimerLbl.Size = new System.Drawing.Size(200, 30);
            this.TimerLbl.TabIndex = 1;
            this.TimerLbl.Text = "Timer : ";
            this.TimerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimerLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // nameLevelPanel
            // 
            this.nameLevelPanel.Controls.Add(this.label34);
            this.nameLevelPanel.Controls.Add(this.startGameButton);
            this.nameLevelPanel.Controls.Add(this.levelComboBox);
            this.nameLevelPanel.Controls.Add(this.label33);
            this.nameLevelPanel.Controls.Add(this.nameTextBox);
            this.nameLevelPanel.Controls.Add(this.label32);
            this.nameLevelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLevelPanel.Location = new System.Drawing.Point(0, 0);
            this.nameLevelPanel.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.nameLevelPanel.Name = "nameLevelPanel";
            this.nameLevelPanel.Size = new System.Drawing.Size(907, 588);
            this.nameLevelPanel.TabIndex = 3;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(320, 220);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(256, 37);
            this.label34.TabIndex = 8;
            this.label34.Text = "Matching Game";
            // 
            // startGameButton
            // 
            this.startGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startGameButton.Location = new System.Drawing.Point(447, 414);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(75, 23);
            this.startGameButton.TabIndex = 7;
            this.startGameButton.Text = "Start";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // levelComboBox
            // 
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.levelComboBox.Location = new System.Drawing.Point(489, 369);
            this.levelComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.levelComboBox.MinimumSize = new System.Drawing.Size(246, 0);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(246, 21);
            this.levelComboBox.TabIndex = 6;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(178, 354);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(302, 37);
            this.label33.TabIndex = 5;
            this.label33.Text = "Select game level :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(489, 285);
            this.nameTextBox.MinimumSize = new System.Drawing.Size(246, 36);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(246, 36);
            this.nameTextBox.TabIndex = 4;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(271, 284);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(212, 37);
            this.label32.TabIndex = 0;
            this.label32.Text = "Enter name :";
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.gameOverPanel.BackColor = System.Drawing.Color.FromArgb(30, 30, 30); // Optional: Dark background
            this.gameOverPanel.Controls.Add(this.labelGameOver);
            this.gameOverPanel.Controls.Add(this.yourNameLbl);
            this.gameOverPanel.Controls.Add(this.yourCurrentScoreLbl);
            this.gameOverPanel.Controls.Add(this.yourHighScoreLbl);
            this.gameOverPanel.Controls.Add(this.highScoreLbl);
            this.gameOverPanel.Controls.Add(this.playAgainBtn);
            this.gameOverPanel.Controls.Add(this.ExistBtn);
            this.gameOverPanel.Location = new System.Drawing.Point(0, 0);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(907, 588);
            this.gameOverPanel.TabIndex = 9;
            // 
            // label35
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = Color.Red;
            this.labelGameOver.Location = new Point(280, 100);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new Size(350, 65);
            this.labelGameOver.Text = "GAME OVER";
            // 
            // playAgainBtn
            // 
            //this.playAgainBtn.Location = new System.Drawing.Point(408, 420);
            //this.playAgainBtn.Name = "playAgainBtn";
            //this.playAgainBtn.Size = new System.Drawing.Size(75, 23);
            //this.playAgainBtn.TabIndex = 7;
            //this.playAgainBtn.Text = "Play again";
            //this.playAgainBtn.UseVisualStyleBackColor = true;
            //this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            this.playAgainBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.playAgainBtn.Size = new Size(130, 40);
            this.playAgainBtn.Location = new Point(270, 420);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Text = "Play Again";
            this.playAgainBtn.UseVisualStyleBackColor = true;
            this.playAgainBtn.Click += new EventHandler(this.playAgainBtn_Click);
            // 
            // ExistBtn
            // 
            //this.ExistBtn.Location = new System.Drawing.Point(550, 420);
            //this.ExistBtn.Name = "ExistBtn";
            //this.ExistBtn.Size = new System.Drawing.Size(75, 23);
            //this.ExistBtn.TabIndex = 7;
            //this.ExistBtn.Text = "Exist";
            //this.ExistBtn.UseVisualStyleBackColor = true;
            //this.ExistBtn.Click += new System.EventHandler(this.EixtsBtn_Click);
            this.ExistBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.ExistBtn.Size = new Size(130, 40);
            this.ExistBtn.Location = new Point(490, 420);
            this.ExistBtn.Name = "exitBtn";
            this.ExistBtn.Text = "Exit";
            this.ExistBtn.UseVisualStyleBackColor = true;
            this.ExistBtn.Click += new EventHandler(this.EixtsBtn_Click);
            // 
            // highScoreLbl
            // 
            //this.highScoreLbl.AutoSize = true;
            //this.highScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.highScoreLbl.Location = new System.Drawing.Point(335, 370);
            //this.highScoreLbl.Name = "highScoreLbl";
            //this.highScoreLbl.Size = new System.Drawing.Size(234, 37);
            //this.highScoreLbl.TabIndex = 5;
            //this.highScoreLbl.Text = "High Score : 0";
            this.highScoreLbl.AutoSize = true;
            this.highScoreLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.highScoreLbl.ForeColor = Color.Cyan;
            this.highScoreLbl.Location = new Point(290, 340);
            this.highScoreLbl.Name = "highScoreLbl";
            this.highScoreLbl.Text = "Top Global Score: 200";
            // 
            // yourCurrentScoreLbl
            // 
            //this.yourCurrentScoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));
            //this.yourCurrentScoreLbl.AutoSize = true;
            //this.yourCurrentScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.yourCurrentScoreLbl.Location = new System.Drawing.Point(332, 270);
            //this.yourCurrentScoreLbl.Name = "yourCurrentScoreLbl";
            //this.yourCurrentScoreLbl.Size = new System.Drawing.Size(237, 37);
            //this.yourCurrentScoreLbl.TabIndex = 0;
            //this.yourCurrentScoreLbl.Text = "Your Current Score : 0";
            this.yourCurrentScoreLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.yourCurrentScoreLbl.AutoSize = true;
            this.yourCurrentScoreLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.yourCurrentScoreLbl.ForeColor = Color.LightGreen;
            this.yourCurrentScoreLbl.Location = new Point(290, 240);
            this.yourCurrentScoreLbl.Name = "yourCurrentScoreLbl";
            this.yourCurrentScoreLbl.Text = "Current Score: 100";
            // 
            // yourHighScoreLbl
            // 
            //this.yourHighScoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));
            //this.yourHighScoreLbl.AutoSize = true;
            //this.yourHighScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.yourHighScoreLbl.Location = new System.Drawing.Point(332, 320);
            //this.yourHighScoreLbl.Name = "yourHighScoreLbl";
            //this.yourHighScoreLbl.Size = new System.Drawing.Size(237, 37);
            //this.yourHighScoreLbl.TabIndex = 0;
            //this.yourHighScoreLbl.Text = "Your High Score : 0";

            // yourHighScoreLbl
            this.yourHighScoreLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.yourHighScoreLbl.AutoSize = true;
            this.yourHighScoreLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.yourHighScoreLbl.ForeColor = Color.Gold;
            this.yourHighScoreLbl.Location = new Point(290, 290);
            this.yourHighScoreLbl.Name = "yourHighScoreLbl";
            this.yourHighScoreLbl.Text = "Your High Score: 150";
            //
            // yourNameLbl
            //
            //this.yourNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));
            //this.yourNameLbl.AutoSize = true;
            //this.yourNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.yourNameLbl.Location = new System.Drawing.Point(332, 220);
            //this.yourNameLbl.Name = "yourNameLbl";
            //this.yourNameLbl.Size = new System.Drawing.Size(237, 37);
            //this.yourNameLbl.TabIndex = 0;
            //this.yourNameLbl.Text = "Your Score : 0";

            this.yourNameLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.yourNameLbl.AutoSize = true;
            this.yourNameLbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.yourNameLbl.ForeColor = Color.White;
            this.yourNameLbl.Location = new Point(310, 190);
            this.yourNameLbl.Name = "yourNameLbl";
            this.yourNameLbl.Text = "Player: Kamalesh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(907, 588);
            this.Controls.Add(this.nameLevelPanel);
            this.Controls.Add(this.TimerLbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gameOverPanel);
            this.MinimumSize = new System.Drawing.Size(610, 610);
            this.Name = "Form1";
            this.Text = "Matching Game";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.nameLevelPanel.ResumeLayout(false);
            this.nameLevelPanel.PerformLayout();
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLbl;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private Panel nameLevelPanel;
        private Label label32;
        private TextBox nameTextBox;
        private Label label33;
        private ComboBox levelComboBox;
        private Button startGameButton;
        private Label label34;
        private Panel gameOverPanel;
        private Label labelGameOver;
        private Button playAgainBtn;
        private Button ExistBtn;
        private Label highScoreLbl;
        private Label yourCurrentScoreLbl;
        private Label yourHighScoreLbl;
        private Label yourNameLbl;
    }
}

