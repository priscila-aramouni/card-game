namespace Card_Game
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.grpBox_P1 = new System.Windows.Forms.GroupBox();
            this.Score_P1 = new System.Windows.Forms.Label();
            this.Type_P1 = new System.Windows.Forms.Label();
            this.Name_P1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_P2 = new System.Windows.Forms.Label();
            this.grpBox_P2 = new System.Windows.Forms.GroupBox();
            this.Score_P2 = new System.Windows.Forms.Label();
            this.Type_P2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpBox_P3 = new System.Windows.Forms.GroupBox();
            this.Score_P3 = new System.Windows.Forms.Label();
            this.Type_P3 = new System.Windows.Forms.Label();
            this.Name_P3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_OneRound = new System.Windows.Forms.Button();
            this.btn_AllRounds = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label_NbOfCardsRemaining = new System.Windows.Forms.Label();
            this.timerBetweenRounds = new System.Windows.Forms.Timer(this.components);
            this.lstBox_RoundLog = new System.Windows.Forms.ListBox();
            this.grpBox_AcitvityLog = new System.Windows.Forms.GroupBox();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.lstBox_GameHistory = new System.Windows.Forms.ListBox();
            this.btn_ViewDetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBox_P1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBox_P2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpBox_P3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grpBox_AcitvityLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_P1
            // 
            this.grpBox_P1.Controls.Add(this.Score_P1);
            this.grpBox_P1.Controls.Add(this.Type_P1);
            this.grpBox_P1.Controls.Add(this.Name_P1);
            this.grpBox_P1.Controls.Add(this.pictureBox1);
            this.grpBox_P1.Controls.Add(this.label4);
            this.grpBox_P1.Controls.Add(this.label3);
            this.grpBox_P1.Controls.Add(this.label2);
            this.grpBox_P1.Controls.Add(this.label1);
            this.grpBox_P1.Location = new System.Drawing.Point(13, 13);
            this.grpBox_P1.Name = "grpBox_P1";
            this.grpBox_P1.Size = new System.Drawing.Size(314, 565);
            this.grpBox_P1.TabIndex = 0;
            this.grpBox_P1.TabStop = false;
            this.grpBox_P1.Text = "Player 1";
            // 
            // Score_P1
            // 
            this.Score_P1.AutoSize = true;
            this.Score_P1.Location = new System.Drawing.Point(63, 88);
            this.Score_P1.Name = "Score_P1";
            this.Score_P1.Size = new System.Drawing.Size(70, 17);
            this.Score_P1.TabIndex = 8;
            this.Score_P1.Text = "Score_P1";
            // 
            // Type_P1
            // 
            this.Type_P1.AutoSize = true;
            this.Type_P1.Location = new System.Drawing.Point(62, 61);
            this.Type_P1.Name = "Type_P1";
            this.Type_P1.Size = new System.Drawing.Size(65, 17);
            this.Type_P1.TabIndex = 7;
            this.Type_P1.Text = "Type_P1";
            // 
            // Name_P1
            // 
            this.Name_P1.AutoSize = true;
            this.Name_P1.Location = new System.Drawing.Point(62, 29);
            this.Name_P1.Name = "Name_P1";
            this.Name_P1.Size = new System.Drawing.Size(70, 17);
            this.Name_P1.TabIndex = 6;
            this.Name_P1.Text = "Name_P1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Card Dealt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // Name_P2
            // 
            this.Name_P2.AutoSize = true;
            this.Name_P2.Location = new System.Drawing.Point(62, 29);
            this.Name_P2.Name = "Name_P2";
            this.Name_P2.Size = new System.Drawing.Size(70, 17);
            this.Name_P2.TabIndex = 5;
            this.Name_P2.Text = "Name_P2";
            // 
            // grpBox_P2
            // 
            this.grpBox_P2.Controls.Add(this.Score_P2);
            this.grpBox_P2.Controls.Add(this.Type_P2);
            this.grpBox_P2.Controls.Add(this.pictureBox2);
            this.grpBox_P2.Controls.Add(this.Name_P2);
            this.grpBox_P2.Controls.Add(this.label5);
            this.grpBox_P2.Controls.Add(this.label6);
            this.grpBox_P2.Controls.Add(this.label7);
            this.grpBox_P2.Controls.Add(this.label8);
            this.grpBox_P2.Location = new System.Drawing.Point(333, 13);
            this.grpBox_P2.Name = "grpBox_P2";
            this.grpBox_P2.Size = new System.Drawing.Size(314, 565);
            this.grpBox_P2.TabIndex = 5;
            this.grpBox_P2.TabStop = false;
            this.grpBox_P2.Text = "Player 2";
            // 
            // Score_P2
            // 
            this.Score_P2.AutoSize = true;
            this.Score_P2.Location = new System.Drawing.Point(63, 88);
            this.Score_P2.Name = "Score_P2";
            this.Score_P2.Size = new System.Drawing.Size(70, 17);
            this.Score_P2.TabIndex = 9;
            this.Score_P2.Text = "Score_P2";
            // 
            // Type_P2
            // 
            this.Type_P2.AutoSize = true;
            this.Type_P2.Location = new System.Drawing.Point(62, 61);
            this.Type_P2.Name = "Type_P2";
            this.Type_P2.Size = new System.Drawing.Size(65, 17);
            this.Type_P2.TabIndex = 8;
            this.Type_P2.Text = "Type_P2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(10, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 411);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Last Card Dealt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // grpBox_P3
            // 
            this.grpBox_P3.Controls.Add(this.Score_P3);
            this.grpBox_P3.Controls.Add(this.Type_P3);
            this.grpBox_P3.Controls.Add(this.Name_P3);
            this.grpBox_P3.Controls.Add(this.pictureBox3);
            this.grpBox_P3.Controls.Add(this.label9);
            this.grpBox_P3.Controls.Add(this.label10);
            this.grpBox_P3.Controls.Add(this.label11);
            this.grpBox_P3.Controls.Add(this.label12);
            this.grpBox_P3.Location = new System.Drawing.Point(653, 13);
            this.grpBox_P3.Name = "grpBox_P3";
            this.grpBox_P3.Size = new System.Drawing.Size(314, 565);
            this.grpBox_P3.TabIndex = 6;
            this.grpBox_P3.TabStop = false;
            this.grpBox_P3.Text = "Player 3";
            this.grpBox_P3.Visible = false;
            // 
            // Score_P3
            // 
            this.Score_P3.AutoSize = true;
            this.Score_P3.Location = new System.Drawing.Point(63, 88);
            this.Score_P3.Name = "Score_P3";
            this.Score_P3.Size = new System.Drawing.Size(70, 17);
            this.Score_P3.TabIndex = 10;
            this.Score_P3.Text = "Score_P3";
            // 
            // Type_P3
            // 
            this.Type_P3.AutoSize = true;
            this.Type_P3.Location = new System.Drawing.Point(62, 61);
            this.Type_P3.Name = "Type_P3";
            this.Type_P3.Size = new System.Drawing.Size(65, 17);
            this.Type_P3.TabIndex = 9;
            this.Type_P3.Text = "Type_P3";
            // 
            // Name_P3
            // 
            this.Name_P3.AutoSize = true;
            this.Name_P3.Location = new System.Drawing.Point(62, 29);
            this.Name_P3.Name = "Name_P3";
            this.Name_P3.Size = new System.Drawing.Size(70, 17);
            this.Name_P3.TabIndex = 6;
            this.Name_P3.Text = "Name_P3";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(10, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(298, 411);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Last Card Dealt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Score:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Type:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name:";
            // 
            // btn_OneRound
            // 
            this.btn_OneRound.Location = new System.Drawing.Point(44, 606);
            this.btn_OneRound.Name = "btn_OneRound";
            this.btn_OneRound.Size = new System.Drawing.Size(247, 86);
            this.btn_OneRound.TabIndex = 7;
            this.btn_OneRound.Text = "One Round";
            this.btn_OneRound.UseVisualStyleBackColor = true;
            this.btn_OneRound.Click += new System.EventHandler(this.btn_OneRound_Click);
            // 
            // btn_AllRounds
            // 
            this.btn_AllRounds.Location = new System.Drawing.Point(366, 606);
            this.btn_AllRounds.Name = "btn_AllRounds";
            this.btn_AllRounds.Size = new System.Drawing.Size(247, 86);
            this.btn_AllRounds.TabIndex = 8;
            this.btn_AllRounds.Text = "All Rounds";
            this.btn_AllRounds.UseVisualStyleBackColor = true;
            this.btn_AllRounds.Click += new System.EventHandler(this.btn_AllRounds_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 717);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Number of cards remaining:";
            // 
            // label_NbOfCardsRemaining
            // 
            this.label_NbOfCardsRemaining.AutoSize = true;
            this.label_NbOfCardsRemaining.Location = new System.Drawing.Point(230, 717);
            this.label_NbOfCardsRemaining.Name = "label_NbOfCardsRemaining";
            this.label_NbOfCardsRemaining.Size = new System.Drawing.Size(78, 17);
            this.label_NbOfCardsRemaining.TabIndex = 10;
            this.label_NbOfCardsRemaining.Text = "NbOfCards";
            // 
            // timerBetweenRounds
            // 
            this.timerBetweenRounds.Interval = 1250;
            this.timerBetweenRounds.Tick += new System.EventHandler(this.timerBetweenRounds_Tick);
            // 
            // lstBox_RoundLog
            // 
            this.lstBox_RoundLog.FormattingEnabled = true;
            this.lstBox_RoundLog.ItemHeight = 16;
            this.lstBox_RoundLog.Location = new System.Drawing.Point(6, 29);
            this.lstBox_RoundLog.Name = "lstBox_RoundLog";
            this.lstBox_RoundLog.Size = new System.Drawing.Size(554, 228);
            this.lstBox_RoundLog.TabIndex = 11;
            this.lstBox_RoundLog.SelectedIndexChanged += new System.EventHandler(this.lstBox_RoundLog_SelectedIndexChanged);
            // 
            // grpBox_AcitvityLog
            // 
            this.grpBox_AcitvityLog.Controls.Add(this.btn_Undo);
            this.grpBox_AcitvityLog.Controls.Add(this.lstBox_RoundLog);
            this.grpBox_AcitvityLog.Location = new System.Drawing.Point(994, 13);
            this.grpBox_AcitvityLog.Name = "grpBox_AcitvityLog";
            this.grpBox_AcitvityLog.Size = new System.Drawing.Size(566, 308);
            this.grpBox_AcitvityLog.TabIndex = 12;
            this.grpBox_AcitvityLog.TabStop = false;
            this.grpBox_AcitvityLog.Text = "Acitvity Log";
            // 
            // btn_Undo
            // 
            this.btn_Undo.Location = new System.Drawing.Point(6, 263);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(554, 37);
            this.btn_Undo.TabIndex = 13;
            this.btn_Undo.Text = "Undo Round";
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // lstBox_GameHistory
            // 
            this.lstBox_GameHistory.FormattingEnabled = true;
            this.lstBox_GameHistory.ItemHeight = 16;
            this.lstBox_GameHistory.Location = new System.Drawing.Point(6, 23);
            this.lstBox_GameHistory.Name = "lstBox_GameHistory";
            this.lstBox_GameHistory.Size = new System.Drawing.Size(554, 228);
            this.lstBox_GameHistory.TabIndex = 12;
            // 
            // btn_ViewDetails
            // 
            this.btn_ViewDetails.Location = new System.Drawing.Point(6, 257);
            this.btn_ViewDetails.Name = "btn_ViewDetails";
            this.btn_ViewDetails.Size = new System.Drawing.Size(554, 37);
            this.btn_ViewDetails.TabIndex = 14;
            this.btn_ViewDetails.Text = "View Details";
            this.btn_ViewDetails.UseVisualStyleBackColor = true;
            this.btn_ViewDetails.Click += new System.EventHandler(this.btn_ViewDetails_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBox_GameHistory);
            this.groupBox1.Controls.Add(this.btn_ViewDetails);
            this.groupBox1.Location = new System.Drawing.Point(994, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 303);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game History";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 755);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBox_AcitvityLog);
            this.Controls.Add(this.label_NbOfCardsRemaining);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_AllRounds);
            this.Controls.Add(this.btn_OneRound);
            this.Controls.Add(this.grpBox_P3);
            this.Controls.Add(this.grpBox_P2);
            this.Controls.Add(this.grpBox_P1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "Card Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.grpBox_P1.ResumeLayout(false);
            this.grpBox_P1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBox_P2.ResumeLayout(false);
            this.grpBox_P2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpBox_P3.ResumeLayout(false);
            this.grpBox_P3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.grpBox_AcitvityLog.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_P1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox_P2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpBox_P3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Name_P2;
        private System.Windows.Forms.Label Name_P1;
        private System.Windows.Forms.Label Name_P3;
        private System.Windows.Forms.Label Type_P1;
        private System.Windows.Forms.Label Type_P2;
        private System.Windows.Forms.Label Type_P3;
        private System.Windows.Forms.Label Score_P1;
        private System.Windows.Forms.Label Score_P2;
        private System.Windows.Forms.Label Score_P3;
        private System.Windows.Forms.Button btn_OneRound;
        private System.Windows.Forms.Button btn_AllRounds;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_NbOfCardsRemaining;
        private System.Windows.Forms.Timer timerBetweenRounds;
        private System.Windows.Forms.ListBox lstBox_RoundLog;
        private System.Windows.Forms.GroupBox grpBox_AcitvityLog;
        private System.Windows.Forms.ListBox lstBox_GameHistory;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_ViewDetails;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}