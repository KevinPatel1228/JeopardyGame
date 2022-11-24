using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Jeopardy_Game
{
    /// <summary>
    /// Interaction logic for ShowQuestion.xaml
    /// </summary>
    public partial class ShowQuestion : Window
    {
        private const int NUM_RIGHT_ANSWER = 1;
        private const int NUM_WRONG_ANSWER = 1;

        private int team1NumWrongAnswer = 0;
        private int team2NumWrongAnswer = 0;
        int numPoints;
        private bool isPointChange;
        string questionAnswer;
        Game game;
        public ShowQuestion(Game mainGame, int points, string question, string answer)
        {
            InitializeComponent();
            numPoints = points;
            txtQuestion.Text = question;
            questionAnswer = answer;
            game = mainGame;
            team1.Text = game.GetTeamName(0);
            team2.Text = game.GetTeamName(1);
            scoreTeam1.Text = game.GetTeamScore(0).ToString();
            scoreTeam2.Text = game.GetTeamScore(1).ToString();
            isPointChange = false;

        }

        private void RightAnswer_Click(object sender, RoutedEventArgs e)
        {
            
            if (sender.Equals(txtteam1Right))
            {
                game.AddScore(team1.Text, numPoints);
                scoreTeam1.Text = game.GetTeamScore(0).ToString();
                isPointChange = true;
            }

            if (sender.Equals(txtteam2Right))
            {
                game.AddScore(team2.Text, numPoints);
                scoreTeam2.Text = game.GetTeamScore(1).ToString();
                isPointChange = true;
            }
            
            txtteam1Right.IsEnabled = false;
            txtteam1Wrong.IsEnabled = false;
            txtteam2Right.IsEnabled = false;
            txtteam2Wrong.IsEnabled = false;

        }

        private void WrongAnswer_Click(object sender, RoutedEventArgs e)
        {
            
            if (sender.Equals(txtteam1Wrong))
            {
                if (team1NumWrongAnswer == 0)
                {
                    game.AddScore(team1.Text, -numPoints);
                    team1NumWrongAnswer++;
                }
                txtteam1Right.IsEnabled = false;
                txtteam1Wrong.IsEnabled = false;
                scoreTeam1.Text = game.GetTeamScore(0).ToString();
                isPointChange = true;
            }

            if (sender.Equals(txtteam2Wrong))
            {
                if (team2NumWrongAnswer == 0)
                {
                    game.AddScore(team2.Text, -numPoints);
                    team2NumWrongAnswer++;
                }
                txtteam2Right.IsEnabled = false;
                txtteam2Wrong.IsEnabled = false;
                scoreTeam2.Text = game.GetTeamScore(1).ToString();
                isPointChange = true;
            }
            if (team1NumWrongAnswer == 1 && team2NumWrongAnswer == 1)
            {
                ShowAnswer showAnswer = new ShowAnswer(questionAnswer);
                showAnswer.ShowDialog();
                this.Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!isPointChange)
            {
                e.Cancel = true;
                MessageBox.Show("Select right or wrong before proceeding", Title, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void doneBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void seeAnswerBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowAnswer showAnswer = new ShowAnswer(questionAnswer);
            showAnswer.ShowDialog();
        }
    }
}
