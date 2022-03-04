using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geditor
{
    class Stage
    {
        string[] sides = { "CASUALS","LOSERS", "WINNERS" };
        string[] legs = { "SET","ROUND","QUARTERS", "SEMIS", "FINALS" };
        string Side = "";
        string Leg = "";
        int Round = 0;

        public Stage()
        {
            Side = Leg = null;
            Round = 0;
        }

        public Stage(int side,int leg, int round)
        {
            Side = sides[side];
            Leg = legs[leg];
            Round = round;
        }


        public string ToStringg()
        {
            if (Round==0)
            {
                return $"{Side} {Leg}";
            }
            else
            {
                return $"{Side} {Leg} {Round}";
            }
           
        }
        //getters and setter
        public string getSide() { return Side; }
        public void setSide(int side) { Side = sides[side]; }
        public string getLeg() { return Leg; }
        public void setLeg(int leg) { Leg = legs[leg]; }
        public int getRound() { return Round; }
        public void setRound(int round) { Round = round; }


    }
}
