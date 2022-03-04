using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geditor
{
    class Score
    {

        int score = 0;

        public Score()
        {
            score = 0;
        }

        public Score(int sco)
        {
            score = sco;
        }


        public string ToStringg()
        {
            return $"{score.ToString()}";
        }
        //getters and setter
        public int getScore() { return score; }
        public void setScore(int sco) { score = sco; }
    }
}
