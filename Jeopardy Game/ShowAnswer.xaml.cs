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
    /// Interaction logic for ShowAnswer.xaml
    /// </summary>
    public partial class ShowAnswer : Window
    {
        public ShowAnswer(string answer)
        {
            InitializeComponent();
            txtAnswer.Text = answer;
        }

        private void doneBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
