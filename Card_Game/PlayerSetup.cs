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
    public partial class PlayerSetup : Form
    {
        private List<Player> ListOfPlayers = new List<Player>();

        public PlayerSetup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
                Player Player1 = new Player(txtBox_P1.Text, comboBox_P1.SelectedItem.ToString());
                Player Player2 = new Player(txtBox_P2.Text, comboBox_P2.SelectedItem.ToString());
                ListOfPlayers.Add(Player1);
                ListOfPlayers.Add(Player2);

                if (grpBox_P3.Enabled)
                {
                    Player Player3 = new Player(txtBox_P3.Text, comboBox_P3.SelectedItem.ToString());
                    ListOfPlayers.Add(Player3);
                }

                Game game = new Game(ListOfPlayers);

                GameForm MainForm = new GameForm(game);
                MainForm.Show();
                this.Hide();
        }
         
        private void radioBtn_2P_CheckedChanged(object sender, EventArgs e)
        {
            grpBox_P3.Enabled = false;
        }

        private void radioBtn_3P_CheckedChanged(object sender, EventArgs e)
        {
            grpBox_P3.Enabled = true;
        }
    }
}
