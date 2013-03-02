using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    class FrenchLeague1PointSystem : PointSystem
    {
        private class PointTotal : ITotal
        {
            private int goalaverage;
            private int points;

            public int CompareTo(Object obj)
            {
                throw new NotImplementedException();
            }

            public void Increment(ITotal with)
            {
                throw new NotImplementedException();
            }

            public PointTotal()
            {
            }

            public PointTotal(Match m, bool home)
            {
                throw new NotImplementedException();
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


        public override ITotal InitialPoints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static FrenchLeague1PointSystem Instance // A modifier, ne permet pas d'éviter une double instanciation dans un contexte multithread
        {
            get
            {
                throw new NotImplementedException();
                /*if (theInstance == null)
                {
                    theInstance = new FrenchLeague1PointSystem();
                }
                return theInstance;*/
            }
        }

        public override ITotal GetPointsFromMatch(Match m, bool IsHome)
        {
            throw new NotImplementedException();
        }


    }
}
