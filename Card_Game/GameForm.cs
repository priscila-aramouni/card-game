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
    public partial class GameForm : Form
    {
        //Instance of game to be modified
        private Game _game = null;

        private Deck _deck = new Deck();

        public GameForm(Game game)
        {
            _game = game;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetCardsRemaining()
        {
            label_NbOfCardsRemaining.Text = _deck.deckSize.ToString();
        }

        private void SetPictures()
        {
            var path_P1 = _game.players[0].dealtCard.ToString();
            Image image1 = Image.FromFile(String.Format($"Cards\\{path_P1}.png"));
            pictureBox1.Image = image1;

            var path_P2 = _game.players[1].dealtCard.ToString();
            Image image2 = Image.FromFile(String.Format($"Cards\\{path_P2}.png"));
            pictureBox2.Image = image2;

            if (_game.has3Players())
            {
                var path_P3 = _game.players[2].dealtCard.ToString();
                Image image3 = Image.FromFile(String.Format($"Cards\\{path_P3}.png"));
                pictureBox3.Image = image3;
            }
        }

        private void SetScores()
        {
            Score_P1.Text = _game.players[0].score.ToString();
            Score_P2.Text = _game.players[1].score.ToString();

            if (_game.has3Players())
                Score_P3.Text = _game.players[2].score.ToString();
        }

        private void SetLabels()
        {
            Name_P1.Text = _game.players[0].name;
            Type_P1.Text = _game.players[0].type;
            
            Name_P2.Text = _game.players[1].name;
            Type_P2.Text = _game.players[1].type;
            
            if (_game.has3Players())
            {
                grpBox_P3.Visible = true;

                Name_P3.Text = _game.players[2].name;
                Type_P3.Text = _game.players[2].type;               
            }

            SetCardsRemaining();
            SetScores();
        }

        private bool NotEnoughCards()
        {
            if (_deck.deckSize == (52 % 2) && _game.has2Players())
            {
                return true;
            }
            else if (_deck.deckSize == (52 % 3) && _game.has3Players())
            {
                return true;
            }
            else
                return false;
        }

        private bool APlayerReachedMaxScore()
        {
            foreach(Player _player in _game.players)
            {
                if (_player.score >= _player.maxScore)
                    return true;
            }

            return false;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            SetLabels();
        }

        private void AddGameToHistory(Game game)
        {
            //lstBox_GameHistory.Items.Add()
        }

        private void btn_OneRound_Click(object sender, EventArgs e)
        {
            if (NotEnoughCards() || APlayerReachedMaxScore())
            {
                Player winner = _game.Winner();

                _game.GameEntry = _game.ToString();

                lstBox_GameHistory.DisplayMember = "GameEntry";
                lstBox_GameHistory.Items.Add(_game);

                EndOfGame EndDialog = new EndOfGame(winner);
                DialogResult result = EndDialog.ShowDialog();

                if(result == DialogResult.Retry)
                {
                    foreach (Player player in _game.players)
                    {
                        //Reset score for next game
                        player.score = 0;
                    }

                    GameForm NewForm = new GameForm(_game);
                    NewForm.lstBox_GameHistory = this.lstBox_GameHistory;
                    NewForm.Show();

                    EndDialog.Hide();
                    this.Hide();
               
                } else if (result == DialogResult.Abort)
                {
                    Close();
                }
            }
            else
            {
                ScoreAdjuster Scorer = new ScoreAdjuster();
                foreach (Player player in _game.players)
                {
                    player.dealtCard = _deck.Deal();
                    Scorer.AdjustScore(player);
                }

                Round _round = new Round(_game.players);
                _round.RoundEntry = _round.ToString();

                lstBox_RoundLog.DisplayMember = "RoundEntry";
                lstBox_RoundLog.Items.Add(_round);

                SetCardsRemaining();
                SetPictures();
                SetScores();
            }        
        }

        private void btn_AllRounds_Click(object sender, EventArgs e)
        {
            timerBetweenRounds.Start();
        }

        private void timerBetweenRounds_Tick(object sender, EventArgs e)
        {
            if (NotEnoughCards() || APlayerReachedMaxScore())
            {
                timerBetweenRounds.Stop();
            }

            btn_OneRound_Click(null, null);            
        }

        private void lstBox_RoundLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            Round _round = (Round)lstBox_RoundLog.Items[lstBox_RoundLog.SelectedIndex];

            _game.players[0].score -= _round.players[0].scoreDifference;
            _game.players[1].score -= _round.players[1].scoreDifference;

            if(_round.players.Count == 3)
            {
                _game.players[2].score -= _round.players[2].scoreDifference;
            }

            SetScores();
            
            lstBox_RoundLog.Items.RemoveAt(lstBox_RoundLog.SelectedIndex);
            lstBox_RoundLog.SelectedItem = null;
            lstBox_RoundLog.SelectedIndex = -1;
        }

        private void btn_ViewDetails_Click(object sender, EventArgs e)
        {
            Game _game = (Game)lstBox_GameHistory.SelectedItem;
            MessageBox.Show($"Game: \n{_game.Winner().name} won, Score = {_game.Winner().score}");
        }
    }
}
