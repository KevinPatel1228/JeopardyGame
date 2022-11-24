using System;
using System.Collections.Generic;
using System.Text;

namespace Jeopardy_Game
{
    class Question
    {
        private int _questionNumber;
        private string _question;
        private string _answer;
        private int _points;
        private string _topic;
        private bool _chosen;

        public Question(int questionNumber, string question, string answer, int points, string topic)
        {
            _questionNumber = questionNumber;
            _question = question;
            _answer = answer;
            _points = points;
            _topic = topic;
            _chosen = false;
        }

        public int GetQuestionNum()
        {
            return _questionNumber;
        }
        public string GetQuestion()
        {
            return _question;
        }

        public void SetQuestion(string question)
        {
            _question = question;
        }

        public string GetAnswer()
        {
            return _answer;
        }

        public int GetPoints()
        {
            return _points;
        }

        public string GetTopic()
        {
            return _topic;
        }

        public bool IsChosen()
        {
            return _chosen;
        }

        public void SetChosen(bool chosen)
        {
            _chosen = chosen;
        }





    }
}
