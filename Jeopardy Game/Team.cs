using System;
using System.Collections.Generic;
using System.Text;

namespace Jeopardy_Game
{
    class Team
    {
        string _teamName;
        int _score;

        public Team(string teamName)
        {
            _teamName = teamName;
            _score = 0;
        }

        public Team()
        {
            _score = 0;
            _teamName = string.Empty;
        }

        public void ChangeName(string teamName)
        {
            _teamName = teamName;
        }

        public string GetTeamName()
        {
            return _teamName;
        }

        public int GetScore()
        {
            return _score;
        }

        public void AddPoints(int value)
        {
            _score += value;
        }
    }
}
