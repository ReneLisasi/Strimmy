using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geditor
{
    class Strim
    {
        public Stage Stage1;

        public Person Player1;

        public Person Player2;

        public Score Score1;
        public Score Score2;

        public Strim()
        {
            Stage1 = new Stage();
            Player1 = new Person();
            Player2 = new Person();
            Score1 = new Score();
            Score2 = new Score();
        }

        public Strim(Score score1, Score score2, Person player1, Person player2, Stage stage)
        {
            Stage1 = stage;
            Player1 = player1;
            Player2 = player2;
            Score1 = score1;
            Score2 = score2;
        }

        public void setStrim(Score score1, Score score2, Person player1, Person player2, Stage stage)
        {
            Stage1 = stage;
            Player1 = player1;
            Player2 = player2;
            Score1 = score1;
            Score2 = score2;
        }

        public void WriteStrim(Address address1)
        {
            File.WriteAllText(address1.getFilePath(),ToStringg());
        }

        public string ToStringg()
        {
            return $"{Score1.ToStringg()}\n" +
                   $"{Score2.ToStringg()}\n" +
                   $"{Player1.ToStringg()}\n" +
                   $"{Player2.ToStringg()}\n" +
                   $"{Stage1.ToStringg()}";
        }

    }
}
