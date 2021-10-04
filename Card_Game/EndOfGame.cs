using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Card_Game
{
    public partial class EndOfGame : Form
    {
        Player winner = null;

        public EndOfGame(Player Winner)
        {
            winner = Winner;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void EndOfGame_Load(object sender, EventArgs e)
        {
            label_GameOverMessage.Text = $"Game over! {winner.name} won, score = {winner.score}.";
        }
    }
}
