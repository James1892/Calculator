namespace Calculator
{
    partial class mainWinodw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWinodw));
            this.display = new System.Windows.Forms.Label();
            this.zeroButton = new Guna.UI2.WinForms.Guna2Button();
            this.decimalButton = new Guna.UI2.WinForms.Guna2Button();
            this.equalsButtom = new Guna.UI2.WinForms.Guna2Button();
            this.eightButton = new Guna.UI2.WinForms.Guna2Button();
            this.sevenButton = new Guna.UI2.WinForms.Guna2Button();
            this.nineButton = new Guna.UI2.WinForms.Guna2Button();
            this.sixButton = new Guna.UI2.WinForms.Guna2Button();
            this.fiveButton = new Guna.UI2.WinForms.Guna2Button();
            this.fourButton = new Guna.UI2.WinForms.Guna2Button();
            this.minusButton = new Guna.UI2.WinForms.Guna2Button();
            this.plusButton = new Guna.UI2.WinForms.Guna2Button();
            this.timesButton = new Guna.UI2.WinForms.Guna2Button();
            this.threeButton = new Guna.UI2.WinForms.Guna2Button();
            this.twoButton = new Guna.UI2.WinForms.Guna2Button();
            this.oneButton = new Guna.UI2.WinForms.Guna2Button();
            this.allClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.clearLeftButton = new Guna.UI2.WinForms.Guna2Button();
            this.exponentButton = new Guna.UI2.WinForms.Guna2Button();
            this.divisionButton = new Guna.UI2.WinForms.Guna2Button();
            this.displayHistory = new System.Windows.Forms.TextBox();
            this.wordsButton = new Guna.UI2.WinForms.Guna2Button();
            this.piButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display.Font = new System.Drawing.Font("Dubai", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(0, 37);
            this.display.Margin = new System.Windows.Forms.Padding(0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(358, 102);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zeroButton
            // 
            this.zeroButton.BorderRadius = 5;
            this.zeroButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.zeroButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.zeroButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.zeroButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.zeroButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.zeroButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zeroButton.ForeColor = System.Drawing.Color.White;
            this.zeroButton.Location = new System.Drawing.Point(3, 536);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(81, 70);
            this.zeroButton.TabIndex = 1;
            this.zeroButton.Text = "0";
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.BorderRadius = 5;
            this.decimalButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.decimalButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.decimalButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.decimalButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.decimalButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.decimalButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decimalButton.ForeColor = System.Drawing.Color.White;
            this.decimalButton.Location = new System.Drawing.Point(92, 536);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(81, 70);
            this.decimalButton.TabIndex = 2;
            this.decimalButton.Text = ".";
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // equalsButtom
            // 
            this.equalsButtom.BorderRadius = 5;
            this.equalsButtom.DisabledState.BorderColor = System.Drawing.Color.Coral;
            this.equalsButtom.DisabledState.CustomBorderColor = System.Drawing.Color.Coral;
            this.equalsButtom.DisabledState.FillColor = System.Drawing.Color.Coral;
            this.equalsButtom.DisabledState.ForeColor = System.Drawing.Color.White;
            this.equalsButtom.FillColor = System.Drawing.Color.Coral;
            this.equalsButtom.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equalsButtom.ForeColor = System.Drawing.Color.White;
            this.equalsButtom.Location = new System.Drawing.Point(178, 536);
            this.equalsButtom.Name = "equalsButtom";
            this.equalsButtom.Size = new System.Drawing.Size(170, 70);
            this.equalsButtom.TabIndex = 3;
            this.equalsButtom.Text = "=";
            this.equalsButtom.Click += new System.EventHandler(this.equalsButtom_Click);
            // 
            // eightButton
            // 
            this.eightButton.BorderRadius = 5;
            this.eightButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.eightButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.eightButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.eightButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.eightButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.eightButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eightButton.ForeColor = System.Drawing.Color.White;
            this.eightButton.Location = new System.Drawing.Point(93, 308);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(81, 70);
            this.eightButton.TabIndex = 5;
            this.eightButton.Text = "8";
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BorderRadius = 5;
            this.sevenButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.sevenButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.sevenButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.sevenButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.sevenButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.sevenButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sevenButton.ForeColor = System.Drawing.Color.White;
            this.sevenButton.Location = new System.Drawing.Point(3, 308);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(81, 70);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.Text = "7";
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BorderRadius = 5;
            this.nineButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.nineButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.nineButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.nineButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.nineButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.nineButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nineButton.ForeColor = System.Drawing.Color.White;
            this.nineButton.Location = new System.Drawing.Point(180, 308);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(81, 70);
            this.nineButton.TabIndex = 6;
            this.nineButton.Text = "9";
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BorderRadius = 5;
            this.sixButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.sixButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.sixButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.sixButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.sixButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.sixButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sixButton.ForeColor = System.Drawing.Color.White;
            this.sixButton.Location = new System.Drawing.Point(180, 384);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(81, 70);
            this.sixButton.TabIndex = 9;
            this.sixButton.Text = "6";
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BorderRadius = 5;
            this.fiveButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.fiveButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.fiveButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.fiveButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.fiveButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.fiveButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fiveButton.ForeColor = System.Drawing.Color.White;
            this.fiveButton.Location = new System.Drawing.Point(93, 384);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(81, 70);
            this.fiveButton.TabIndex = 8;
            this.fiveButton.Text = "5";
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BorderRadius = 5;
            this.fourButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.fourButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.fourButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.fourButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.fourButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.fourButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fourButton.ForeColor = System.Drawing.Color.White;
            this.fourButton.Location = new System.Drawing.Point(3, 384);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(81, 70);
            this.fourButton.TabIndex = 7;
            this.fourButton.Text = "4";
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BorderRadius = 5;
            this.minusButton.DisabledState.BorderColor = System.Drawing.Color.Coral;
            this.minusButton.DisabledState.CustomBorderColor = System.Drawing.Color.Coral;
            this.minusButton.DisabledState.FillColor = System.Drawing.Color.Coral;
            this.minusButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.minusButton.FillColor = System.Drawing.Color.Coral;
            this.minusButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minusButton.ForeColor = System.Drawing.Color.White;
            this.minusButton.Location = new System.Drawing.Point(267, 460);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(81, 70);
            this.minusButton.TabIndex = 10;
            this.minusButton.Text = "-";
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BorderRadius = 5;
            this.plusButton.DisabledState.BorderColor = System.Drawing.Color.Coral;
            this.plusButton.DisabledState.CustomBorderColor = System.Drawing.Color.Coral;
            this.plusButton.DisabledState.FillColor = System.Drawing.Color.Coral;
            this.plusButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.plusButton.FillColor = System.Drawing.Color.Coral;
            this.plusButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plusButton.ForeColor = System.Drawing.Color.White;
            this.plusButton.Location = new System.Drawing.Point(267, 384);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(81, 70);
            this.plusButton.TabIndex = 11;
            this.plusButton.Text = "+";
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // timesButton
            // 
            this.timesButton.BorderRadius = 5;
            this.timesButton.DisabledState.BorderColor = System.Drawing.Color.Coral;
            this.timesButton.DisabledState.CustomBorderColor = System.Drawing.Color.Coral;
            this.timesButton.DisabledState.FillColor = System.Drawing.Color.Coral;
            this.timesButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.timesButton.FillColor = System.Drawing.Color.Coral;
            this.timesButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timesButton.ForeColor = System.Drawing.Color.White;
            this.timesButton.Location = new System.Drawing.Point(267, 308);
            this.timesButton.Name = "timesButton";
            this.timesButton.Size = new System.Drawing.Size(81, 70);
            this.timesButton.TabIndex = 15;
            this.timesButton.Text = "x";
            this.timesButton.Click += new System.EventHandler(this.timesButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BorderRadius = 5;
            this.threeButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.threeButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.threeButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.threeButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.threeButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.threeButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.threeButton.ForeColor = System.Drawing.Color.White;
            this.threeButton.Location = new System.Drawing.Point(180, 460);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(81, 70);
            this.threeButton.TabIndex = 14;
            this.threeButton.Text = "3";
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BorderRadius = 5;
            this.twoButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.twoButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.twoButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.twoButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.twoButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.twoButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twoButton.ForeColor = System.Drawing.Color.White;
            this.twoButton.Location = new System.Drawing.Point(92, 460);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(81, 70);
            this.twoButton.TabIndex = 13;
            this.twoButton.Text = "2";
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BorderRadius = 5;
            this.oneButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.oneButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.oneButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.oneButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.oneButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.oneButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oneButton.ForeColor = System.Drawing.Color.White;
            this.oneButton.Location = new System.Drawing.Point(3, 460);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(81, 70);
            this.oneButton.TabIndex = 12;
            this.oneButton.Text = "1";
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // allClearButton
            // 
            this.allClearButton.BorderRadius = 5;
            this.allClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.allClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.allClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.allClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.allClearButton.FillColor = System.Drawing.Color.Black;
            this.allClearButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allClearButton.ForeColor = System.Drawing.Color.White;
            this.allClearButton.Location = new System.Drawing.Point(3, 156);
            this.allClearButton.Name = "allClearButton";
            this.allClearButton.Size = new System.Drawing.Size(171, 70);
            this.allClearButton.TabIndex = 16;
            this.allClearButton.Text = "AC";
            this.allClearButton.Click += new System.EventHandler(this.allClearButton_Click);
            // 
            // clearLeftButton
            // 
            this.clearLeftButton.BorderRadius = 5;
            this.clearLeftButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.clearLeftButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.clearLeftButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.clearLeftButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.clearLeftButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.clearLeftButton.Font = new System.Drawing.Font("Digital-7", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearLeftButton.ForeColor = System.Drawing.Color.White;
            this.clearLeftButton.Location = new System.Drawing.Point(3, 232);
            this.clearLeftButton.Name = "clearLeftButton";
            this.clearLeftButton.Size = new System.Drawing.Size(81, 70);
            this.clearLeftButton.TabIndex = 19;
            this.clearLeftButton.Text = "⌫";
            this.clearLeftButton.Click += new System.EventHandler(this.clearLeftButton_Click);
            // 
            // exponentButton
            // 
            this.exponentButton.BorderRadius = 5;
            this.exponentButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.exponentButton.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.exponentButton.DisabledState.FillColor = System.Drawing.Color.Black;
            this.exponentButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.exponentButton.FillColor = System.Drawing.Color.Black;
            this.exponentButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exponentButton.ForeColor = System.Drawing.Color.White;
            this.exponentButton.Location = new System.Drawing.Point(180, 156);
            this.exponentButton.Name = "exponentButton";
            this.exponentButton.Size = new System.Drawing.Size(81, 70);
            this.exponentButton.TabIndex = 18;
            this.exponentButton.Text = "^";
            this.exponentButton.Click += new System.EventHandler(this.exponentButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.divisionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.divisionButton.BorderRadius = 5;
            this.divisionButton.DisabledState.BorderColor = System.Drawing.Color.Coral;
            this.divisionButton.DisabledState.CustomBorderColor = System.Drawing.Color.Coral;
            this.divisionButton.DisabledState.FillColor = System.Drawing.Color.Coral;
            this.divisionButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.divisionButton.FillColor = System.Drawing.Color.Coral;
            this.divisionButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divisionButton.ForeColor = System.Drawing.Color.White;
            this.divisionButton.Location = new System.Drawing.Point(267, 232);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(81, 70);
            this.divisionButton.TabIndex = 22;
            this.divisionButton.Text = "÷";
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // displayHistory
            // 
            this.displayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.displayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayHistory.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayHistory.ForeColor = System.Drawing.Color.White;
            this.displayHistory.Location = new System.Drawing.Point(0, 0);
            this.displayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.displayHistory.Name = "displayHistory";
            this.displayHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayHistory.Size = new System.Drawing.Size(350, 54);
            this.displayHistory.TabIndex = 24;
            this.displayHistory.Text = "0";
            this.displayHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayHistory.TextChanged += new System.EventHandler(this.displayHistory_TextChanged);
            // 
            // wordsButton
            // 
            this.wordsButton.BorderRadius = 5;
            this.wordsButton.DisabledState.BorderColor = System.Drawing.SystemColors.GrayText;
            this.wordsButton.DisabledState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.wordsButton.DisabledState.FillColor = System.Drawing.SystemColors.GrayText;
            this.wordsButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.wordsButton.FillColor = System.Drawing.SystemColors.GrayText;
            this.wordsButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordsButton.ForeColor = System.Drawing.Color.White;
            this.wordsButton.Location = new System.Drawing.Point(93, 232);
            this.wordsButton.Name = "wordsButton";
            this.wordsButton.Size = new System.Drawing.Size(170, 70);
            this.wordsButton.TabIndex = 20;
            this.wordsButton.Text = "Words";
            this.wordsButton.Click += new System.EventHandler(this.wordsButton_Click);
            // 
            // piButton
            // 
            this.piButton.BorderRadius = 5;
            this.piButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.piButton.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.piButton.DisabledState.FillColor = System.Drawing.Color.Black;
            this.piButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.piButton.FillColor = System.Drawing.Color.Black;
            this.piButton.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.piButton.ForeColor = System.Drawing.Color.White;
            this.piButton.Location = new System.Drawing.Point(267, 156);
            this.piButton.Name = "piButton";
            this.piButton.Size = new System.Drawing.Size(81, 70);
            this.piButton.TabIndex = 25;
            this.piButton.Text = "π";
            this.piButton.Click += new System.EventHandler(this.piButton_Click);
            // 
            // mainWinodw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 611);
            this.Controls.Add(this.piButton);
            this.Controls.Add(this.displayHistory);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.wordsButton);
            this.Controls.Add(this.clearLeftButton);
            this.Controls.Add(this.exponentButton);
            this.Controls.Add(this.allClearButton);
            this.Controls.Add(this.timesButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.equalsButtom);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.display);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "mainWinodw";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Calclator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button zeroButton;
        private Guna.UI2.WinForms.Guna2Button decimalButton;
        private Guna.UI2.WinForms.Guna2Button equalsButtom;
        private Guna.UI2.WinForms.Guna2Button eightButton;
        private Guna.UI2.WinForms.Guna2Button sevenButton;
        private Guna.UI2.WinForms.Guna2Button nineButton;
        private Guna.UI2.WinForms.Guna2Button sixButton;
        private Guna.UI2.WinForms.Guna2Button fiveButton;
        private Guna.UI2.WinForms.Guna2Button fourButton;
        private Guna.UI2.WinForms.Guna2Button minusButton;
        private Guna.UI2.WinForms.Guna2Button plusButton;
        private Guna.UI2.WinForms.Guna2Button timesButton;
        private Guna.UI2.WinForms.Guna2Button threeButton;
        private Guna.UI2.WinForms.Guna2Button twoButton;
        private Guna.UI2.WinForms.Guna2Button oneButton;
        private Guna.UI2.WinForms.Guna2Button allClearButton;
        private Guna.UI2.WinForms.Guna2Button clearLeftButton;
        private Guna.UI2.WinForms.Guna2Button exponentButton;
        private Guna.UI2.WinForms.Guna2Button divisionButton;
        private TextBox displayHistory;
        private Label display;
        private Guna.UI2.WinForms.Guna2Button wordsButton;
        private Guna.UI2.WinForms.Guna2Button piButton;
    }
}