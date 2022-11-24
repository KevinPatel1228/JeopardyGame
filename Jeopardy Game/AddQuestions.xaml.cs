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
using Microsoft.Win32;
namespace Jeopardy_Game
{
    /// <summary>
    /// Interaction logic for AddQuestions.xaml
    /// </summary>
    public partial class AddQuestions : Window
    {
        AdminWindow admin;
        Game game;
        string fileName;
        public AddQuestions(Game game, string fileName)
        {
            InitializeComponent();
            
            this.fileName = fileName;
            this.game = game;
            admin = new AdminWindow(this.game, 1, topic1.Text);
            UpdateWindow();

        }

        private void UpdateWindow()
        {
            int questionNumber = 1;
            const string DOLLAR_SIGN = "$";
            try
            {
                question1.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question1.IsEnabled = false;
                questionNumber++;
                question2.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question2.IsEnabled = false;
                questionNumber++;
                question3.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question3.IsEnabled = false;
                questionNumber++;
                question4.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question4.IsEnabled = false;
                questionNumber++;
                question5.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question5.IsEnabled = false;
                questionNumber++;
                question6.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question6.IsEnabled = false;
                questionNumber++;
                question7.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question7.IsEnabled = false;
                questionNumber++;
                question8.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question8.IsEnabled = false;
                questionNumber++;
                question9.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question9.IsEnabled = false;
                questionNumber++;
                question10.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question10.IsEnabled = false;
                questionNumber++;
                question11.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question11.IsEnabled = false;
                questionNumber++;
                question12.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question12.IsEnabled = false;
                questionNumber++;
                question13.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question13.IsEnabled = false;
                questionNumber++;
                question14.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question14.IsEnabled = false;
                questionNumber++;
                question15.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question15.IsEnabled = false;
                questionNumber++;
                question16.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question16.IsEnabled = false;
                questionNumber++;
                question17.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question17.IsEnabled = false;
                questionNumber++;
                question18.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question18.IsEnabled = false;
                questionNumber++;
                question19.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question19.IsEnabled = false;
                questionNumber++;
                question20.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question20.IsEnabled = false;
                questionNumber++;
                question21.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question21.IsEnabled = false;
                questionNumber++;
                question22.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question22.IsEnabled = false;
                questionNumber++;
                question23.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question23.IsEnabled = false;
                questionNumber++;
                question24.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question24.IsEnabled = false;
                questionNumber++;
                question25.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question25.IsEnabled = false;
                questionNumber++;
                question26.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question26.IsEnabled = false;
                questionNumber++;
                question27.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question27.IsEnabled = false;
                questionNumber++;
                question28.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question28.IsEnabled = false;
                questionNumber++;
                question29.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question29.IsEnabled = false;
                questionNumber++;
                question30.Content = game.GetQuestionPoints(questionNumber) + DOLLAR_SIGN;
                question30.IsEnabled = false;
            }
            catch (Exception)
            {


            }
        }

        private void question_Click(object sender, RoutedEventArgs e)
        {
            
            if (sender.Equals(question1))
            {
                admin = new AdminWindow(game, 1, topic1.Text);
                
                question1.Content = (int)Points.oneHundred;
                question1.IsEnabled = false;
            }
            else if (sender.Equals(question2))
            {
                admin = new AdminWindow(game, 2, topic1.Text);
                question2.Content = (int)Points.twoHundred;
                question2.IsEnabled = false;
            }
            else if (sender.Equals(question3))
            {
                admin = new AdminWindow(game, 3, topic1.Text);
                question3.Content = (int)Points.threeHundred;
                question3.IsEnabled = false;
            }
            else if (sender.Equals(question4))
            {
                admin = new AdminWindow(game, 4, topic1.Text);
                question4.Content = (int)Points.fourHundred;
                question4.IsEnabled = false;
            }
            else if (sender.Equals(question5))
            {
                admin = new AdminWindow(game, 5, topic1.Text);
                question5.Content = (int)Points.fiveHundred;
                question5.IsEnabled = false;
            }
            else if (sender.Equals(question6))
            {
                admin = new AdminWindow(game, 6, topic2.Text);
                question6.Content = (int)Points.oneHundred;
                question6.IsEnabled = false;
            }
            else if (sender.Equals(question7))
            {
                admin = new AdminWindow(game, 7, topic2.Text);
                question7.Content = (int)Points.twoHundred;
                question7.IsEnabled = false;
            }
            else if (sender.Equals(question8))
            {
                admin = new AdminWindow(game, 8, topic2.Text);
                question8.Content = (int)Points.threeHundred;
                question8.IsEnabled = false;
            }
            else if (sender.Equals(question9))
            {
                admin = new AdminWindow(game, 9, topic2.Text);
                question9.Content = (int)Points.fourHundred;
                question9.IsEnabled = false;
            }
            else if (sender.Equals(question10))
            {
                admin = new AdminWindow(game, 10, topic2.Text);
                question10.Content = (int)Points.fiveHundred;
                question10.IsEnabled = false;
            }
            else if (sender.Equals(question11))
            {
                admin = new AdminWindow(game, 11, topic3.Text);
                question11.Content = (int)Points.oneHundred;
                question11.IsEnabled = false;
            }
            else if (sender.Equals(question12))
            {
                admin = new AdminWindow(game, 12, topic3.Text);
                question12.Content = (int)Points.twoHundred;
                question12.IsEnabled = false;
            }
            else if (sender.Equals(question13))
            {
                admin = new AdminWindow(game, 13, topic3.Text);
                question13.Content = (int)Points.threeHundred;
                question13.IsEnabled = false;
            }
            else if (sender.Equals(question14))
            {
                admin = new AdminWindow(game, 14, topic3.Text);
                question14.Content = (int)Points.fourHundred;
                question14.IsEnabled = false;
            }
            else if (sender.Equals(question15))
            {
                admin = new AdminWindow(game, 15, topic3.Text);
                question15.Content = (int)Points.fiveHundred;
                question15.IsEnabled = false;
            }
            else if (sender.Equals(question16))
            {
                admin = new AdminWindow(game, 16, topic4.Text);
                question16.Content = (int)Points.oneHundred;
                question16.IsEnabled = false;
            }
            else if (sender.Equals(question17))
            {
                admin = new AdminWindow(game, 17, topic4.Text);
                question17.Content = (int)Points.twoHundred;
                question17.IsEnabled = false;
            }
            else if (sender.Equals(question18))
            {
                admin = new AdminWindow(game, 18, topic4.Text);
                question18.Content = (int)Points.threeHundred;
                question18.IsEnabled = false;
            }
            else if (sender.Equals(question19))
            {
                admin = new AdminWindow(game, 19, topic4.Text);
                question19.Content = (int)Points.fourHundred;
                question19.IsEnabled = false;
            }
            else if (sender.Equals(question20))
            {
                admin = new AdminWindow(game, 20, topic4.Text);
                question20.Content = (int)Points.fiveHundred;
                question20.IsEnabled = false;
            }
            else if (sender.Equals(question21))
            {
                admin = new AdminWindow(game, 21, topic5.Text);
                question21.Content = (int)Points.oneHundred;
                question21.IsEnabled = false;
            }
            else if (sender.Equals(question22))
            {
                admin = new AdminWindow(game, 22, topic5.Text);
                question22.Content = (int)Points.twoHundred;
                question22.IsEnabled = false;
            }
            else if (sender.Equals(question23))
            {
                admin = new AdminWindow(game, 23, topic5.Text);
                question23.Content = (int)Points.threeHundred;
                question23.IsEnabled = false;
            }
            else if (sender.Equals(question24))
            {
                admin = new AdminWindow(game, 24, topic5.Text);
                question24.Content = (int)Points.fourHundred;
                question24.IsEnabled = false;
            }
            else if (sender.Equals(question25))
            {
                admin = new AdminWindow(game, 25, topic5.Text);
                question25.Content = (int)Points.fiveHundred;
                question25.IsEnabled = false;
            }
            else if (sender.Equals(question26))
            {
                admin = new AdminWindow(game, 26, topic6.Text);
                question26.Content = (int)Points.oneHundred;
                question26.IsEnabled = false;
            }
            else if (sender.Equals(question27))
            {
                admin = new AdminWindow(game, 27, topic6.Text);
                question27.Content = (int)Points.twoHundred;
                question27.IsEnabled = false;
            }
            else if (sender.Equals(question28))
            {
                admin = new AdminWindow(game, 28, topic6.Text);
                question28.Content = (int)Points.threeHundred;
                question28.IsEnabled = false;
            }
            else if (sender.Equals(question29))
            {
                admin = new AdminWindow(game, 29, topic6.Text);
                question29.Content = (int)Points.fourHundred;
                question29.IsEnabled = false;
            }
            else if (sender.Equals(question30))
            {
                admin = new AdminWindow(game, 30, topic6.Text);
                question30.Content = (int)Points.fiveHundred;
                question30.IsEnabled = false;
            }

            admin.ShowDialog();

            game = admin.GetGameInfo();
        }

        private void startGameBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public Game GetGameInfo()
        {
            return game;
        }

        private void saveQuestionBtn_Click(object sender, RoutedEventArgs e)
        {
            string fileName;
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == true)
            {
                try
                {
                    fileName = fileDialog.FileName;
                    game.SaveQuestions(fileName);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            const int REQUIRED_QUESTIONS = 30;
            game = admin.GetGameInfo();

            if (game.GetNumberOfQuestions() < REQUIRED_QUESTIONS)
            {
                MessageBox.Show("All questions must be added before starting game (total of " + REQUIRED_QUESTIONS + " questions)", Title, MessageBoxButton.OK, MessageBoxImage.Exclamation);
                e.Cancel = true;
            }
        }
    }
}
