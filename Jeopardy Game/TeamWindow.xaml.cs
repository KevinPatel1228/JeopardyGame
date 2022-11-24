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
using System.IO;
using Microsoft.Win32;

namespace Jeopardy_Game
{
    /// <summary>
    /// Interaction logic for TeamWindow.xaml
    /// </summary>
    public partial class TeamWindow : Window
    {
        string loadFile;
        Game game;
        public TeamWindow()
        {
            InitializeComponent();
            loadFile = string.Empty;
            game = new Game();
        }

        private void confirm_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (team1Name.Text == string.Empty || team2Name.Text == string.Empty || topic1.Text == string.Empty || topic2.Text == string.Empty || topic3.Text == string.Empty || topic4.Text == string.Empty || topic5.Text == string.Empty || topic6.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all of the information", Title, MessageBoxButton.OK, MessageBoxImage.Error);
                e.Cancel = true;
                return;
            }

            try
            {
                game.ChangeTeamName(team1Name.Text, team2Name.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
                e.Cancel = true;
                return;
            }



        }

        private void loadQ_btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == true)
            {
                try
                {
                    loadFile = fileDialog.FileName;
                    game.LoadQuestions(loadFile);
                    SetLoadedTopic();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
               
            }

        }

        private void SetLoadedTopic()
        {
            try
            {
                int topicNum = 1;
                topic1.Text = game.GetTopic(topicNum);
                topic1.IsEnabled = false;
                topicNum++;
                topic2.Text = game.GetTopic(topicNum);
                topic2.IsEnabled = false;
                topicNum++;
                topic3.Text = game.GetTopic(topicNum);
                topic3.IsEnabled = false;
                topicNum++;
                topic4.Text = game.GetTopic(topicNum);
                topic4.IsEnabled = false;
                topicNum++;
                topic5.Text = game.GetTopic(topicNum);
                topic5.IsEnabled = false;
                topicNum++;
                topic6.Text = game.GetTopic(topicNum);
                topic6.IsEnabled = false;

            }
            catch (Exception)
            {

                
            }
            
        }
        public string GetLoadFile()
        {
            return loadFile;
        }
        public Game GetGameInfo()
        {
            return game;
        }
    }
}
