using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class FrenchLeague1PointSystem : PointSystem
    {
        private class PointTotal : ITotal
        {
            //private int goalaverage;
            private int points;


            public PointTotal()
            {
                this.points = 0;
            }

            public PointTotal(Match m, bool home)
            {
                this.points = m.GetGoals(home) - m.GetGoals(!home);
                //this.goalaverage = m.GetGoals(home) / m.GetGoals(!home);
            }


            public int CompareTo(object obj)
            {
                return this.points - ((PointTotal)obj).points;
    
            }

            public void Increment(PointSystem.ITotal with)
            {
                this.points += ((PointTotal)with).points;
            }




            public override string ToString()
            {
                return base.ToString();
            }

            

        }
        
        private static FrenchLeague1PointSystem theInstance;


        private FrenchLeague1PointSystem()
        {

        }


        public static FrenchLeague1PointSystem Instance // A modifier, ne permet pas d'éviter une double instanciation dans un contexte multithread
        {
            get
            {
                //throw new NotImplementedException();
                if (theInstance == null)
                {
                    theInstance = new FrenchLeague1PointSystem();
                }
                return theInstance;
            }
        }


        public override PointSystem.ITotal InitialPoints
        {
            get
            {
                return new PointTotal();
            }
        }

        public override ITotal GetPointsFromMatch(Match m, bool IsHome)
        {
            return new PointTotal(m, IsHome);
        }


    }
}
