using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_chapter9
{
    class HockeyPlayer
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _jerseyNumber;
        private int _goalsScored;

        public HockeyPlayer(string name, int number, int goals)
        {
            this._name = name;
            this._jerseyNumber = number;
            this._goalsScored = goals;
        }

        public override string ToString()
        {
            return string.Format("Player Name: {0}\nJersey Number: {1}\nGoals Scored: {2}",
                this._name, this._jerseyNumber, this._goalsScored);
        }
    }
}
