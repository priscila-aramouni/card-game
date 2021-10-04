namespace Card_Game
{
    partial class EndOfGame
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
            this.label_GameOverMessage = new System.Windows.Forms.Label();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_GameOverMessage
            // 
            this.label_GameOverMessage.AutoSize = true;
            this.label_GameOverMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_GameOverMessage.Location = new System.Drawing.Point(115, 58);
            this.label_GameOverMessage.Name = "label_GameOverMessage";
            this.label_GameOverMessage.Size = new System.Drawing.Size(172, 17);
            this.label_GameOverMessage.TabIndex = 0;
            this.label_GameOverMessage.Text = "label_GameOverMessage";
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btn_PlayAgain.Location = new System.Drawing.Point(67, 102);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(135, 39);
            this.btn_PlayAgain.TabIndex = 1;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = true;
            // 
            // btn_Quit
            // 
            this.btn_Quit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btn_Quit.Location = new System.Drawing.Point(277, 103);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(135, 38);
            this.btn_Quit.TabIndex = 2;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            // 
            // EndOfGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(483, 171);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.label_GameOverMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndOfGame";
            this.Text = "EndOfGame";
            this.Load += new System.EventHandler(this.EndOfGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_GameOverMessage;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Button btn_Quit;
    }
}