using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Jeopardy_Game
{
    public class Game
    {
        private const int NUM_TEAMS = 2;
        private const int MIN_TOPICS = 1;
        private const int MIN_QUESTION_NUM = 1;

        private List<Question> _questions;
        private Team[] _teams = new Team[NUM_TEAMS];
        private Stopwatch _timer;
        private List<string> _topics;

        public Game(string teamName1, string teamName2)
        {
            if (teamName1 == teamName2)
                throw new ArgumentException("Team names cannot be identical, please change select different team names", "teamName1, teamName2");

            _teams[0] = new Team(teamName1);
            _teams[1] = new Team(teamName2);

            _questions = new List<Question>();
            _timer = new Stopwatch();

            _topics = new List<string>();
        }

        public Game()
        {
            _teams[0] = new Team();
            _teams[1] = new Team();

            _questions = new List<Question>();
            _timer = new Stopwatch();

            _topics = new List<string>();
        }

        public string GetTeamName(int teamNumber)
        {
            return _teams[teamNumber].GetTeamName();
        }

        public int GetTeamScore(int teamNumber)
        {
            if (teamNumber < 0 || teamNumber >= _teams.Length)
                throw new ArgumentException("given team number is not valid", "teamNumber");

            return _teams[teamNumber].GetScore();
        }

        public void ChangeTeamName(string teamName1, string teamName2)
        {
            if (teamName1 == teamName2)
                throw new ArgumentException("Team names cannot be identical, please change select different team names", "teamName1, teamName2");

            _teams[0].ChangeName(teamName1);
            _teams[1].ChangeName(teamName2);

        }
        public string GetQuestion(int questionNumber)
        {
            if (questionNumber < MIN_QUESTION_NUM)
                throw new ArgumentException("Given question number must be greater or equal to " + MIN_QUESTION_NUM, "questionNum");

            int questionIndex = GetQuestionIndex(questionNumber);
            if (questionIndex < MIN_QUESTION_NUM - 1)
                throw new ArgumentException("Given question number doesn't exist", "questionNumber");

            return _questions[questionIndex].GetQuestion();
        }

        public string GetAnswer(int questionNumber)
        {
            if (questionNumber < MIN_QUESTION_NUM)
                throw new ArgumentException("Given question number must be greater or equal to " + MIN_QUESTION_NUM, "questionNum");

            int questionIndex = GetQuestionIndex(questionNumber);
            if (questionIndex < MIN_QUESTION_NUM - 1)
                throw new ArgumentException("Given question number doesn't exist", "questionNumber");

            return _questions[questionIndex].GetAnswer();
        }

        public void Start()
        {
            GC.Collect();
            _timer.Start();
        }

        public void End()
        {
            _timer.Stop();
        }

        public int GetQuestionPoints(int questionNum)
        {
            int index = GetQuestionIndex(questionNum);

            if (index < MIN_QUESTION_NUM - 1)
                throw new ArgumentException("Given question number doesn't exist", "questionNum");

            return _questions[index].GetPoints();


        }
        public void AddScore(string teamName, int points)
        {
            for (int i = 0; i < _teams.Length; i++)
            {
                if (_teams[i].GetTeamName() == teamName)
                {
                    _teams[i].AddPoints(points);
                    return;
                }

            }

            throw new ArgumentException("Team does not exist", teamName);
        }
        public void AddQuestion(int questionNum, string question, string answer, int points, string topic)
        {
            if (questionNum < MIN_QUESTION_NUM)
                throw new ArgumentException("question number must be greater or equal to " + MIN_QUESTION_NUM, "questionNum");

            for (int i = 0; i < _questions.Count; i++)
            {
                if (_questions[i].GetQuestionNum() == questionNum)
                    throw new ArgumentException("Two questions cannot have the same number", "questionNum");
            }
            if (!_topics.Contains(topic))
                _topics.Add(topic);

            _questions.Add(new Question(questionNum, question, answer, points, topic));

            SortQuestionList();
        }
        private void SortQuestionList()
        {
            

            bool isSorted;
            Question toSwap;
            for (int i = 0; i < _questions.Count - 1; i++)
            {
                isSorted = true;
                for (int j = 0; j < _questions.Count - 2; j++)
                {
                    if (_questions[j].GetQuestionNum() > _questions[j + 1].GetQuestionNum())
                    {
                        toSwap = _questions[j];
                        _questions[j] = _questions[j + 1];
                        _questions[j + 1] = toSwap;
                        //isSorted = false;
                    }
                }
                if (isSorted)
                    break;
            }
        }
        public void RemoveQuestion(int questionNum)
        {
            const int minNum = 1;
            if (questionNum < minNum)
                throw new ArgumentException("question number must be greater or equal to " + minNum, "questionNum");

            int questionIndex = GetQuestionIndex(questionNum);
            if (questionIndex < 0)
                throw new ArgumentException("the specified question number doesn't exist", "questionNum");

            _questions.RemoveAt(questionIndex);

        }
        private int GetQuestionIndex(int questionNum)
        {
            if (questionNum < MIN_QUESTION_NUM)
                throw new ArgumentException("question number must be greater or equal to " + MIN_QUESTION_NUM, "questionNum");

            int left = 0;
            int right = _questions.Count - 1;
            int middle;
            const int DIVISION = 2;
            while (left <= right)
            {
                middle = left + (right-left) / DIVISION;

                if (_questions[middle].GetQuestionNum() == questionNum)
                {
                    return middle;
                }

                if (questionNum < _questions[middle].GetQuestionNum())
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return -1;
        }
        public void LoadQuestions(string fileName)
        {
            _questions.Clear();

            if (File.Exists(fileName))
            {
                string line;
                const int numInfo = 3;
                const int LINE_PER_CATEGORY = 6;

                string[] questionInfo;
                int lineNum = 0;
                int questionNum = 0;
                const int POINTS_INDEX = 2;
                const int QUESTION_INDEX = 0;
                const int ANSWER_INDEX = 1;
                string topic = string.Empty;
                int points;
                StreamReader reader = new StreamReader(fileName);

                while ((line = reader.ReadLine()) != null)
                {

                    if (lineNum % LINE_PER_CATEGORY == 0)
                    {
                        topic = line;
                        _topics.Add(topic);
                    }
                    else
                    {
                        questionNum++;
                        questionInfo = line.Split(',');

                        if (questionInfo.Length != numInfo)
                            throw new FileFormatException(string.Format("file must have {0} values seprated by a coma ',' on each line after the topic name. Order is (question, answer, points)", numInfo));

                        try
                        {
                            points = int.Parse(questionInfo[POINTS_INDEX]);
                        }
                        catch (Exception)
                        {
                            throw new FileFormatException(string.Format("file must have {0} values seprated by a coma ',' on each line after the topic name. Order is (question, answer, points)", numInfo));
                        }

                        AddQuestion(questionNum, (string)questionInfo[QUESTION_INDEX], (string)questionInfo[ANSWER_INDEX], points, topic);
                    }

                    lineNum++;
                }
                reader.Close();
            }
            else
            {
                throw new FileNotFoundException("provided file name is not valid", fileName);
            }


        }
        public string GetTopic(int topicNum)
        {
            const int MIN_TOPIC_NUM = 1;

            if (topicNum < MIN_TOPIC_NUM || topicNum > _topics.Count)
                throw new ArgumentException("Given topic number doesn't exist", "topicNum");

            return _topics[topicNum - 1];

        }

        public void SaveQuestions(string fileName)
        {

            StreamWriter questionList = null;

            try
            {
                questionList = new StreamWriter(fileName, false);
                for (int i = 0; i < _questions.Count; i++)
                {
                    questionList.WriteLine(string.Format("{0},{1},{2},{3}", _questions[i].GetQuestion(), _questions[i].GetAnswer(), _questions[i].GetPoints(), _questions[i].GetTopic()));
                }
            }
            catch (Exception)
            {
                throw new FileLoadException("Unable to write to file", fileName);
            }
            finally
            {
                if (questionList != null)
                    questionList.Close();
            }

            /*StreamWriter questionList = null;
            SortQuestionList();
            try
            {
                questionList = new StreamWriter(fileName, false);
                string topic = string.Empty;
               
                for (int i = 0; i < _questions.Count; i++)
                {
                    if (_questions[i].GetTopic() != topic)
                    {
                        questionList.WriteLine(_questions[i].GetTopic());
                        topic = _questions[i].GetTopic();
                    }
                    questionList.WriteLine(string.Format("{0},{1},{2}", _questions[i].GetQuestion(), _questions[i].GetAnswer(), _questions[i].GetPoints()));
                }
            }
            catch (Exception)
            {
                throw new FileLoadException("Unable to write to file", fileName);
            }
            finally
            {
                if (questionList != null)
                    questionList.Close();
            }*/

        }

        public void SaveGame(string fileName)
        {
            StreamWriter writer = null;
            StringBuilder gameInfo = new StringBuilder();

            try
            {
                long seconds = _timer.ElapsedMilliseconds / 1000;
                long milliseconds = _timer.ElapsedMilliseconds - 1000 * seconds;

                gameInfo.AppendLine(string.Format("Game Lasted {0} seconds and {1} milliseconds", seconds, milliseconds));
                int highestScoreIndex = 0;
                for (int i = 0; i < _teams.Length; i++)
                {
                    gameInfo.AppendLine(string.Format("Team Name {0}: {1}\tScore: {2}", i + 1, _teams[i].GetTeamName(), _teams[i].GetScore()));

                    if (_teams[i].GetScore() > _teams[highestScoreIndex].GetScore())
                        highestScoreIndex = i;
                }

                gameInfo.AppendLine();
                gameInfo.AppendLine(string.Format("Winning Team is {0} with a score of {1}", _teams[highestScoreIndex].GetTeamName(), _teams[highestScoreIndex].GetScore()));

                writer = new StreamWriter(fileName, false);

                writer.WriteLine(gameInfo.ToString());


            }
            catch (Exception)
            {
                throw new FileLoadException("Unable to write to file", fileName);
            }
            finally
            {
                if (writer != null)
                    writer.Close();

            }
        }
        public void SetQuestionChosen(int questionNum)
        {
            int questionIndex = GetQuestionIndex(questionNum);

            if (questionIndex < 0)
                throw new ArgumentException("Specified question number doesn't exist", "questionNum");

            _questions[questionIndex].SetChosen(true);
        }
        public bool AllQuestionsDone()
        {
            for (int i = 0; i < _questions.Count; i++)
            {
                if (!_questions[i].IsChosen())
                    return false;
            }

            return true;
        }
        public int GetNumberOfQuestions()
        {
            return _questions.Count;
        }
    }
}
