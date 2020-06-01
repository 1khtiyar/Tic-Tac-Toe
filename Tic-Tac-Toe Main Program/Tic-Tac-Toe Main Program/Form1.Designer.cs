namespace Tic_Tac_Toe_Main_Program
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.counterLabelOs = new System.Windows.Forms.Label();
            this.panelCounters = new System.Windows.Forms.Panel();
            this.XsLabel = new System.Windows.Forms.Button();
            this.OsLabel = new System.Windows.Forms.Button();
            this.counterLabelXs = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundCounterLabel = new System.Windows.Forms.Label();
            this.panelGameBoard = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.nextRoundButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelCounters.SuspendLayout();
            this.panelGameBoard.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // counterLabelOs
            // 
            this.counterLabelOs.AutoSize = true;
            this.counterLabelOs.BackColor = System.Drawing.Color.Transparent;
            this.counterLabelOs.Font = new System.Drawing.Font("Lucida Sans Typewriter", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabelOs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.counterLabelOs.Location = new System.Drawing.Point(374, 0);
            this.counterLabelOs.Name = "counterLabelOs";
            this.counterLabelOs.Size = new System.Drawing.Size(33, 34);
            this.counterLabelOs.TabIndex = 2;
            this.counterLabelOs.Text = "0";
            // 
            // panelCounters
            // 
            this.panelCounters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCounters.BackColor = System.Drawing.Color.Transparent;
            this.panelCounters.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.TheLongButtonMiddle;
            this.panelCounters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCounters.Controls.Add(this.XsLabel);
            this.panelCounters.Controls.Add(this.OsLabel);
            this.panelCounters.Controls.Add(this.counterLabelOs);
            this.panelCounters.Controls.Add(this.counterLabelXs);
            this.panelCounters.Controls.Add(this.roundLabel);
            this.panelCounters.Controls.Add(this.roundCounterLabel);
            this.panelCounters.Location = new System.Drawing.Point(12, 468);
            this.panelCounters.Name = "panelCounters";
            this.panelCounters.Size = new System.Drawing.Size(450, 45);
            this.panelCounters.TabIndex = 4;
            // 
            // XsLabel
            // 
            this.XsLabel.BackColor = System.Drawing.Color.Transparent;
            this.XsLabel.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.XsymbolSmall;
            this.XsLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.XsLabel.FlatAppearance.BorderSize = 0;
            this.XsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XsLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XsLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.XsLabel.Location = new System.Drawing.Point(34, 3);
            this.XsLabel.Name = "XsLabel";
            this.XsLabel.Size = new System.Drawing.Size(40, 30);
            this.XsLabel.TabIndex = 3;
            this.XsLabel.UseVisualStyleBackColor = false;
            // 
            // OsLabel
            // 
            this.OsLabel.BackColor = System.Drawing.Color.Transparent;
            this.OsLabel.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.OsymbolSmall;
            this.OsLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OsLabel.FlatAppearance.BorderSize = 0;
            this.OsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OsLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OsLabel.Location = new System.Drawing.Point(337, 2);
            this.OsLabel.Name = "OsLabel";
            this.OsLabel.Size = new System.Drawing.Size(40, 30);
            this.OsLabel.TabIndex = 1;
            this.OsLabel.UseVisualStyleBackColor = false;
            // 
            // counterLabelXs
            // 
            this.counterLabelXs.AutoSize = true;
            this.counterLabelXs.BackColor = System.Drawing.Color.Transparent;
            this.counterLabelXs.Font = new System.Drawing.Font("Lucida Sans Typewriter", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabelXs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.counterLabelXs.Location = new System.Drawing.Point(71, 0);
            this.counterLabelXs.Name = "counterLabelXs";
            this.counterLabelXs.Size = new System.Drawing.Size(33, 34);
            this.counterLabelXs.TabIndex = 2;
            this.counterLabelXs.Text = "0";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundLabel.Location = new System.Drawing.Point(148, -1);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(123, 34);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round:";
            // 
            // roundCounterLabel
            // 
            this.roundCounterLabel.AutoSize = true;
            this.roundCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundCounterLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundCounterLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundCounterLabel.Location = new System.Drawing.Point(265, 0);
            this.roundCounterLabel.Name = "roundCounterLabel";
            this.roundCounterLabel.Size = new System.Drawing.Size(33, 34);
            this.roundCounterLabel.TabIndex = 2;
            this.roundCounterLabel.Text = "0";
            // 
            // panelGameBoard
            // 
            this.panelGameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGameBoard.AutoSize = true;
            this.panelGameBoard.BackColor = System.Drawing.Color.Transparent;
            this.panelGameBoard.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.TheGameBoard;
            this.panelGameBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelGameBoard.Controls.Add(this.button9);
            this.panelGameBoard.Controls.Add(this.button6);
            this.panelGameBoard.Controls.Add(this.button3);
            this.panelGameBoard.Controls.Add(this.button8);
            this.panelGameBoard.Controls.Add(this.button7);
            this.panelGameBoard.Controls.Add(this.button5);
            this.panelGameBoard.Controls.Add(this.button4);
            this.panelGameBoard.Controls.Add(this.button2);
            this.panelGameBoard.Controls.Add(this.button1);
            this.panelGameBoard.Location = new System.Drawing.Point(13, 12);
            this.panelGameBoard.Name = "panelGameBoard";
            this.panelGameBoard.Size = new System.Drawing.Size(450, 453);
            this.panelGameBoard.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellSmall;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(310, 302);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 130);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellSmall;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(310, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 130);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellSmall;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(310, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 130);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellSmall;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Cursor = System.Windows.Forms.Cursors.Default;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(160, 302);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 130);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellSmall;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(10, 302);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 130);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellSmall;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(160, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 130);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellSmall;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(10, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 130);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellSmall;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(160, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 130);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.CellSmall;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(10, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 130);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.TheButton;
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(155, 1);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(140, 80);
            this.restartButton.TabIndex = 0;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.RestartButtonClick);
            // 
            // nextRoundButton
            // 
            this.nextRoundButton.BackColor = System.Drawing.Color.Transparent;
            this.nextRoundButton.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.TheButton;
            this.nextRoundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextRoundButton.Cursor = System.Windows.Forms.Cursors.No;
            this.nextRoundButton.FlatAppearance.BorderSize = 0;
            this.nextRoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextRoundButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextRoundButton.Location = new System.Drawing.Point(5, 1);
            this.nextRoundButton.Name = "nextRoundButton";
            this.nextRoundButton.Size = new System.Drawing.Size(140, 80);
            this.nextRoundButton.TabIndex = 0;
            this.nextRoundButton.Text = "NEXT ROUND";
            this.nextRoundButton.UseVisualStyleBackColor = false;
            this.nextRoundButton.Click += new System.EventHandler(this.NextRoundButtonClick);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quitButton.BackgroundImage")));
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.quitButton.Location = new System.Drawing.Point(305, 1);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(140, 80);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButtonClick);
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.TheLongButton;
            this.panelButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelButtons.Controls.Add(this.quitButton);
            this.panelButtons.Controls.Add(this.nextRoundButton);
            this.panelButtons.Controls.Add(this.restartButton);
            this.panelButtons.Location = new System.Drawing.Point(13, 519);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(450, 90);
            this.panelButtons.TabIndex = 3;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Tic_Tac_Toe_Main_Program.Properties.Resources.BackNewBlack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(475, 621);
            this.Controls.Add(this.panelCounters);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelGameBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.Text = "Tic-Tac-Toe";
            this.panelCounters.ResumeLayout(false);
            this.panelCounters.PerformLayout();
            this.panelGameBoard.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button nextRoundButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button XsLabel;
        private System.Windows.Forms.Button OsLabel;
        private System.Windows.Forms.Label counterLabelOs;
        private System.Windows.Forms.Label counterLabelXs;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label roundCounterLabel;
        private System.Windows.Forms.Panel panelCounters;
        private System.Windows.Forms.Panel panelGameBoard;
        private System.Windows.Forms.Panel panelButtons;
    }
}

