namespace Card_Game
{
    partial class PlayerSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerSetup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_3P = new System.Windows.Forms.RadioButton();
            this.radioBtn_2P = new System.Windows.Forms.RadioButton();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.grpBox_P1 = new System.Windows.Forms.GroupBox();
            this.comboBox_P1 = new System.Windows.Forms.ComboBox();
            this.txtBox_P1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox_P2 = new System.Windows.Forms.GroupBox();
            this.comboBox_P2 = new System.Windows.Forms.ComboBox();
            this.txtBox_P2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBox_P3 = new System.Windows.Forms.GroupBox();
            this.comboBox_P3 = new System.Windows.Forms.ComboBox();
            this.txtBox_P3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpBox_P1.SuspendLayout();
            this.grpBox_P2.SuspendLayout();
            this.grpBox_P3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_3P);
            this.groupBox1.Controls.Add(this.radioBtn_2P);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of players";
            // 
            // radioBtn_3P
            // 
            this.radioBtn_3P.AutoSize = true;
            this.radioBtn_3P.Location = new System.Drawing.Point(6, 58);
            this.radioBtn_3P.Name = "radioBtn_3P";
            this.radioBtn_3P.Size = new System.Drawing.Size(117, 21);
            this.radioBtn_3P.TabIndex = 1;
            this.radioBtn_3P.TabStop = true;
            this.radioBtn_3P.Text = "Three players";
            this.radioBtn_3P.UseVisualStyleBackColor = true;
            this.radioBtn_3P.CheckedChanged += new System.EventHandler(this.radioBtn_3P_CheckedChanged);
            // 
            // radioBtn_2P
            // 
            this.radioBtn_2P.AutoSize = true;
            this.radioBtn_2P.Location = new System.Drawing.Point(6, 31);
            this.radioBtn_2P.Name = "radioBtn_2P";
            this.radioBtn_2P.Size = new System.Drawing.Size(105, 21);
            this.radioBtn_2P.TabIndex = 0;
            this.radioBtn_2P.TabStop = true;
            this.radioBtn_2P.Text = "Two players";
            this.radioBtn_2P.UseVisualStyleBackColor = true;
            this.radioBtn_2P.CheckedChanged += new System.EventHandler(this.radioBtn_2P_CheckedChanged);
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(338, 141);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(175, 58);
            this.btn_StartGame.TabIndex = 1;
            this.btn_StartGame.Text = "Start Game";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // grpBox_P1
            // 
            this.grpBox_P1.Controls.Add(this.comboBox_P1);
            this.grpBox_P1.Controls.Add(this.txtBox_P1);
            this.grpBox_P1.Controls.Add(this.label4);
            this.grpBox_P1.Controls.Add(this.label1);
            this.grpBox_P1.Location = new System.Drawing.Point(198, 13);
            this.grpBox_P1.Name = "grpBox_P1";
            this.grpBox_P1.Size = new System.Drawing.Size(200, 109);
            this.grpBox_P1.TabIndex = 2;
            this.grpBox_P1.TabStop = false;
            this.grpBox_P1.Text = "Player 1";
            // 
            // comboBox_P1
            // 
            this.comboBox_P1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_P1.FormattingEnabled = true;
            this.comboBox_P1.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Picture"});
            this.comboBox_P1.Location = new System.Drawing.Point(63, 59);
            this.comboBox_P1.Name = "comboBox_P1";
            this.comboBox_P1.Size = new System.Drawing.Size(131, 24);
            this.comboBox_P1.TabIndex = 3;
            // 
            // txtBox_P1
            // 
            this.txtBox_P1.Location = new System.Drawing.Point(63, 31);
            this.txtBox_P1.Name = "txtBox_P1";
            this.txtBox_P1.Size = new System.Drawing.Size(131, 22);
            this.txtBox_P1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // grpBox_P2
            // 
            this.grpBox_P2.Controls.Add(this.comboBox_P2);
            this.grpBox_P2.Controls.Add(this.txtBox_P2);
            this.grpBox_P2.Controls.Add(this.label6);
            this.grpBox_P2.Controls.Add(this.label3);
            this.grpBox_P2.Location = new System.Drawing.Point(404, 12);
            this.grpBox_P2.Name = "grpBox_P2";
            this.grpBox_P2.Size = new System.Drawing.Size(200, 110);
            this.grpBox_P2.TabIndex = 3;
            this.grpBox_P2.TabStop = false;
            this.grpBox_P2.Text = "Player 2";
            // 
            // comboBox_P2
            // 
            this.comboBox_P2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_P2.FormattingEnabled = true;
            this.comboBox_P2.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Picture"});
            this.comboBox_P2.Location = new System.Drawing.Point(61, 60);
            this.comboBox_P2.Name = "comboBox_P2";
            this.comboBox_P2.Size = new System.Drawing.Size(131, 24);
            this.comboBox_P2.TabIndex = 4;
            // 
            // txtBox_P2
            // 
            this.txtBox_P2.Location = new System.Drawing.Point(61, 32);
            this.txtBox_P2.Name = "txtBox_P2";
            this.txtBox_P2.Size = new System.Drawing.Size(131, 22);
            this.txtBox_P2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // grpBox_P3
            // 
            this.grpBox_P3.Controls.Add(this.comboBox_P3);
            this.grpBox_P3.Controls.Add(this.txtBox_P3);
            this.grpBox_P3.Controls.Add(this.label5);
            this.grpBox_P3.Controls.Add(this.label2);
            this.grpBox_P3.Enabled = false;
            this.grpBox_P3.Location = new System.Drawing.Point(610, 13);
            this.grpBox_P3.Name = "grpBox_P3";
            this.grpBox_P3.Size = new System.Drawing.Size(200, 109);
            this.grpBox_P3.TabIndex = 3;
            this.grpBox_P3.TabStop = false;
            this.grpBox_P3.Text = "Player 3";
            // 
            // comboBox_P3
            // 
            this.comboBox_P3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_P3.FormattingEnabled = true;
            this.comboBox_P3.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Picture"});
            this.comboBox_P3.Location = new System.Drawing.Point(61, 58);
            this.comboBox_P3.Name = "comboBox_P3";
            this.comboBox_P3.Size = new System.Drawing.Size(131, 24);
            this.comboBox_P3.TabIndex = 5;
            // 
            // txtBox_P3
            // 
            this.txtBox_P3.Location = new System.Drawing.Point(61, 30);
            this.txtBox_P3.Name = "txtBox_P3";
            this.txtBox_P3.Size = new System.Drawing.Size(131, 22);
            this.txtBox_P3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // PlayerSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 211);
            this.Controls.Add(this.grpBox_P2);
            this.Controls.Add(this.grpBox_P3);
            this.Controls.Add(this.grpBox_P1);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerSetup";
            this.Text = "Player Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBox_P1.ResumeLayout(false);
            this.grpBox_P1.PerformLayout();
            this.grpBox_P2.ResumeLayout(false);
            this.grpBox_P2.PerformLayout();
            this.grpBox_P3.ResumeLayout(false);
            this.grpBox_P3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_3P;
        private System.Windows.Forms.RadioButton radioBtn_2P;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.GroupBox grpBox_P1;
        private System.Windows.Forms.GroupBox grpBox_P2;
        private System.Windows.Forms.GroupBox grpBox_P3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5; 
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_P1;
        private System.Windows.Forms.TextBox txtBox_P1;
        private System.Windows.Forms.ComboBox comboBox_P2;
        private System.Windows.Forms.TextBox txtBox_P2;
        private System.Windows.Forms.ComboBox comboBox_P3;
        private System.Windows.Forms.TextBox txtBox_P3;
    } 
}