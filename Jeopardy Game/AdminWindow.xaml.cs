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
    enum Points
    {
        oneHundred = 100,
        twoHundred = 200,
        threeHundred = 300,
        fourHundred = 400,
        fiveHundred = 500
    };

    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {


        Game theGame;
        int questionNum;
        string topic;
        public AdminWindow(Game game, int questionNumber, string topic)
        {
            InitializeComponent();

            this.topic = topic;
            questionNum = questionNumber;
            theGame = game;
            GetStarted();
        }
        public void GetStarted()
        {
            txbQuestion.Text = string.Empty;
            txbAnswer.Text = string.Empty;
            
            if(questionNum == 1)
            {
                txbPoints.Text = ((int)Points.oneHundred).ToString();
                txbTopic.Text = topic;
            }
            else if(questionNum == 2)
            {
                txbPoints.Text = ((int)Points.twoHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 3)
            {
                txbPoints.Text = ((int)Points.threeHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 4)
            {
                txbPoints.Text = ((int)Points.fourHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 5)
            {
                txbPoints.Text = ((int)Points.fiveHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 6)
            {
                txbPoints.Text = ((int)Points.oneHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 7)
            {
                txbPoints.Text = ((int)Points.twoHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 8)
            {
                txbPoints.Text = ((int)Points.threeHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 9)
            {
                txbPoints.Text = ((int)Points.fourHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 10)
            {
                txbPoints.Text = ((int)Points.fiveHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 11)
            {
                txbPoints.Text = ((int)Points.oneHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 12)
            {
                txbPoints.Text = ((int)Points.twoHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 13)
            {
                txbPoints.Text = ((int)Points.threeHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 14)
            {
                txbPoints.Text = ((int)Points.fourHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 15)
            {
                txbPoints.Text = ((int)Points.fiveHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 16)
            {
                txbPoints.Text = ((int)Points.oneHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 17)
            {
                txbPoints.Text = ((int)Points.twoHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 18)
            {
                txbPoints.Text = ((int)Points.threeHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 19)
            {
                txbPoints.Text = ((int)Points.fourHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 20)
            {
                txbPoints.Text = ((int)Points.fiveHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 21)
            {
                txbPoints.Text = ((int)Points.oneHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 22)
            {
                txbPoints.Text = ((int)Points.twoHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 23)
            {
                txbPoints.Text = ((int)Points.threeHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 24)
            {
                txbPoints.Text = ((int)Points.fourHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 25)
            {
                txbPoints.Text = ((int)Points.fiveHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 26)
            {
                txbPoints.Text = ((int)Points.oneHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 27)
            {
                txbPoints.Text = ((int)Points.twoHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 28)
            {
                txbPoints.Text = ((int)Points.threeHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 29)
            {
                txbPoints.Text = ((int)Points.fourHundred).ToString();
                txbTopic.Text = topic;
            }
            else if (questionNum == 30)
            {
                txbPoints.Text = ((int)Points.fiveHundred).ToString();
                txbTopic.Text = topic;
            }

            txbTopic.Text = topic;
        }
        public void SetQuestionNum(int num)
        {
            questionNum = num;
        }

        private void AddQuestionBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public Game GetGameInfo()
        {
            return theGame;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txbQuestion.Text == string.Empty || txbAnswer.Text == string.Empty)
            {
                MessageBox.Show("Fill in all fields to add question", Title, MessageBoxButton.OK, MessageBoxImage.Error);
                e.Cancel = true;
            }
            else
            {
                int points = int.Parse(txbPoints.Text);
                theGame.AddQuestion(questionNum, txbQuestion.Text, txbAnswer.Text, points, txbTopic.Text);
            }
        }
    }
}
