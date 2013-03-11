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
            private int goalaverage;
            private int points;
            

            public PointTotal()
            {
                this.points = 0;
            }

            public PointTotal(Match m, bool home)
            {

                this.goalaverage = m.GetGoals(home) - m.GetGoals(!home);

                int result = m.GetGoals(home) - m.GetGoals(!home);
                if (result > 0)
                {
                    this.points += 1;
                }
                else
                {
                    this.points += 0;
                }
              

            }


            public int CompareTo(object obj)
            {
                if(this.points != ((PointTotal)obj).points)
                {
                    return this.points - ((PointTotal)obj).points;
                }
                else
                {
                    return this.goalaverage - ((PointTotal)obj).goalaverage;
                }
    
            }

            public void Increment(PointSystem.ITotal with)
            {
                this.points += ((PointTotal)with).points;
                this.goalaverage += ((PointTotal)with).goalaverage;
            }




            /*public override string ToString()
            {
                return base.ToString();
            }*/

            

        }
        
        private static FrenchLeague1PointSystem theInstance;


        private FrenchLeague1PointSystem()
        {

        }


        public static FrenchLeague1PointSystem Instance //// Permet de ne pas instancier deux fois FrenchLeague1PointSystem. On pourrait améliorer le Singleton car il ne permet pas d'éviter une double instanciation dans un contexte multithread
        {
            get
            {

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
