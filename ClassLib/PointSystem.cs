﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public abstract class PointSystem
    {

            public interface ITotal : IComparable
            {
                void Increment(ITotal with);
                string ToString();
            }


        abstract public ITotal InitialPoints
        {
            get;
        }
      
        abstract public ITotal GetPointsFromMatch(Match m, bool IsHome);

    }
}

