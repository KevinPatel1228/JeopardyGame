using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Windows.Threading;

namespace Jeopardy_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game;
        TeamWindow infoWindow;
        AddQuestions addQuestions;
        
        string fileName;
        public MainWindow()
        {
            InitializeComponent();

            infoWindow = new TeamWindow();
            infoWindow.ShowDialog();

            game = infoWindow.GetGameInfo();
            fileName = infoWindow.GetLoadFile();

            addQuestions = new AddQuestions(game,fileName);
            SetTopics();
            SetTeam();

            addQuestions.ShowDialog();
            game = addQuestions.GetGameInfo();
            game.Start();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();


        }
        private int seconds;
        public void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            txtTime.Text = "Timer : " + seconds.ToString();
        }
        public void SetTeam()
        {
            this.team1.Text = infoWindow.team1Name.Text;
            this.team2.Text = infoWindow.team2Name.Text;
        }

        public void SetTopics()
        {
            this.topic1.Text = infoWindow.topic1.Text;
            this.topic2.Text = infoWindow.topic2.Text;
            this.topic3.Text = infoWindow.topic3.Text;
            this.topic4.Text = infoWindow.topic4.Text;
            this.topic5.Text = infoWindow.topic5.Text;
            this.topic6.Text = infoWindow.topic6.Text;

            addQuestions.topic1.Text = infoWindow.topic1.Text;
            addQuestions.topic2.Text = infoWindow.topic2.Text;
            addQuestions.topic3.Text = infoWindow.topic3.Text;
            addQuestions.topic4.Text = infoWindow.topic4.Text;
            addQuestions.topic5.Text = infoWindow.topic5.Text;
            addQuestions.topic6.Text = infoWindow.topic6.Text;

        }

        private void Display_Question(object sender, RoutedEventArgs e)
        {
            int questionNum = 1;
            if (sender.Equals(question1))
            {
                questionNum = 1;
                ShowQuestion question = new ShowQuestion(game, 100, game.GetQuestion(questionNum), game.GetAnswer(1));
                question.ShowDialog();
                question1.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question2))
            {
                questionNum = 2;
                ShowQuestion question = new ShowQuestion(game, 200, game.GetQuestion(questionNum), game.GetAnswer(2));
                question.ShowDialog();
                question2.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question3))
            {
                questionNum = 3;
                ShowQuestion question = new ShowQuestion(game, 300, game.GetQuestion(questionNum), game.GetAnswer(3));
                question.ShowDialog();
                question3.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question4))
            {
                questionNum = 4;
                ShowQuestion question = new ShowQuestion(game, 400, game.GetQuestion(questionNum), game.GetAnswer(4));
                question.ShowDialog();
                question4.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question5))
            {
                questionNum = 5;
                ShowQuestion question = new ShowQuestion(game, 500, game.GetQuestion(questionNum), game.GetAnswer(5));
                question.ShowDialog();
                question5.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question6))
            {
                questionNum = 6;
                ShowQuestion question = new ShowQuestion(game, 100, game.GetQuestion(questionNum), game.GetAnswer(6));
                question.ShowDialog();
                question6.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question7))
            {
                questionNum = 7;
                ShowQuestion question = new ShowQuestion(game, 200, game.GetQuestion(questionNum), game.GetAnswer(7));
                question.ShowDialog();
                question7.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question8))
            {
                questionNum = 8;
                ShowQuestion question = new ShowQuestion(game, 300, game.GetQuestion(questionNum), game.GetAnswer(8));
                question.ShowDialog();
                question8.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question9))
            {
                questionNum = 9;
                ShowQuestion question = new ShowQuestion(game, 400, game.GetQuestion(questionNum), game.GetAnswer(9));
                question.ShowDialog();
                question9.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question10))
            {
                questionNum = 10;
                ShowQuestion question = new ShowQuestion(game, 500, game.GetQuestion(questionNum), game.GetAnswer(10));
                question.ShowDialog();
                question10.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question11))
            {
                questionNum = 11;
                ShowQuestion question = new ShowQuestion(game, 100, game.GetQuestion(questionNum), game.GetAnswer(11));
                question.ShowDialog();
                question11.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question12))
            {
                questionNum = 12;
                ShowQuestion question = new ShowQuestion(game, 200, game.GetQuestion(questionNum), game.GetAnswer(12));
                question.ShowDialog();
                question12.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question13))
            {
                questionNum = 13;
                ShowQuestion question = new ShowQuestion(game, 300, game.GetQuestion(questionNum), game.GetAnswer(13));
                question.ShowDialog();
                question13.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question14))
            {
                questionNum = 14;
                ShowQuestion question = new ShowQuestion(game, 400, game.GetQuestion(questionNum), game.GetAnswer(14));
                question.ShowDialog();
                question14.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question15))
            {
                questionNum = 15;
                ShowQuestion question = new ShowQuestion(game, 500, game.GetQuestion(questionNum), game.GetAnswer(15));
                question.ShowDialog();
                question15.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question16))
            {
                questionNum = 16;
                ShowQuestion question = new ShowQuestion(game, 100, game.GetQuestion(questionNum), game.GetAnswer(16));
                question.ShowDialog();
                question16.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question17))
            {
                questionNum = 17;

                ShowQuestion question = new ShowQuestion(game, 200, game.GetQuestion(questionNum), game.GetAnswer(17));
                question.ShowDialog();
                question17.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question18))
            {
                questionNum = 18;
                ShowQuestion question = new ShowQuestion(game, 300, game.GetQuestion(questionNum), game.GetAnswer(18));
                question.ShowDialog();
                question18.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question19))
            {
                questionNum = 19;
                ShowQuestion question = new ShowQuestion(game, 400, game.GetQuestion(questionNum), game.GetAnswer(19));
                question.ShowDialog();
                question19.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question20))
            {
                questionNum = 20;
                ShowQuestion question = new ShowQuestion(game, 500, game.GetQuestion(questionNum), game.GetAnswer(20));
                question.ShowDialog();
                question20.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question21))
            {
                questionNum = 21;
                ShowQuestion question = new ShowQuestion(game, 100, game.GetQuestion(questionNum), game.GetAnswer(21));
                question.ShowDialog();
                question21.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question22))
            {
                questionNum = 22;
                ShowQuestion question = new ShowQuestion(game, 200, game.GetQuestion(questionNum), game.GetAnswer(22));
                question.ShowDialog();
                question22.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question23))
            {
                questionNum = 23;
                ShowQuestion question = new ShowQuestion(game, 300, game.GetQuestion(questionNum), game.GetAnswer(23));
                question.ShowDialog();
                question23.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question24))
            {
                questionNum = 24;
                ShowQuestion question = new ShowQuestion(game, 400, game.GetQuestion(questionNum), game.GetAnswer(24));
                question.ShowDialog();
                question24.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question25))
            {
                questionNum = 25;
                ShowQuestion question = new ShowQuestion(game, 500, game.GetQuestion(questionNum), game.GetAnswer(25));
                question.ShowDialog();
                question25.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question26))
            {
                questionNum = 26;
                ShowQuestion question = new ShowQuestion(game, 100, game.GetQuestion(questionNum), game.GetAnswer(26));
                question.ShowDialog();
                question26.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question27))
            {
                questionNum = 27;
                ShowQuestion question = new ShowQuestion(game, 200, game.GetQuestion(questionNum), game.GetAnswer(27));
                question.ShowDialog();
                question27.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question28))
            {
                questionNum = 28;
                ShowQuestion question = new ShowQuestion(game, 300, game.GetQuestion(questionNum), game.GetAnswer(28));
                question.ShowDialog();
                question28.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question29))
            {
                questionNum = 29;
                ShowQuestion question = new ShowQuestion(game, 400, game.GetQuestion(questionNum), game.GetAnswer(29));
                question.ShowDialog();
                question29.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }
            else if (sender.Equals(question30))
            {
                questionNum = 30;
                ShowQuestion question = new ShowQuestion(game, 500, game.GetQuestion(questionNum), game.GetAnswer(30));
                question.ShowDialog();
                question30.IsEnabled = false;
                team1Score.Text = game.GetTeamScore(0).ToString();
                team2Score.Text = game.GetTeamScore(1).ToString();
            }

            game.SetQuestionChosen(questionNum);

            if (game.AllQuestionsDone())
            {
                EndScreen(sender, e);
            }
        }
        private void EndScreen(object sender, RoutedEventArgs e)
        {
            if (game.GetTeamScore(0) > game.GetTeamScore(1))
            {
                MessageBox.Show(game.GetTeamName(0) + " Won!!!");
            }
            else
            {
                MessageBox.Show(game.GetTeamName(1) + " Won!!!");
            }
            game.End();
            
        }

        private void saveGameBtn_Click(object sender, RoutedEventArgs e)
        {
            string fileName;
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == true)
            {
                try
                {
                    fileName = fileDialog.FileName;
                    game.SaveGame(fileName);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
        }
    }
}
