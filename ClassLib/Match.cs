using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
   
    public class Match
    {
        private Club home;
        private Club away;
        private int awayGoals;
        private int homeGoals;
        private bool isAwayForfeit;
        private bool isHomeForfeit;



        public Match(Club homeName, Club awayName)
        {
            this.home = homeName;
            this.away = awayName;

        }
        public int GetGoals(bool club)
        {

            if (club == true)
            {
                return this.homeGoals;
            }
            else
            {
                return this.awayGoals;
            }
         
        }



        public Club Away
        {
            get
            {
                return this.away;
            }
        }

        public int AwayGoals
        {
            get 
            {
                return this.awayGoals;

            }

            set
            {
                this.awayGoals = value;
            }
        }
        public Club Home
        {
            get
            {
                return this.home;
            }
        }
        public int HomeGoals
        {
            get
            {
                return this.homeGoals;
            }
            set
            {
                this.homeGoals = value;
            }
        }
        public bool IsAwayForfeit
        {
            get 
            {
                return this.isAwayForfeit;
            }
            set
            {
                this.isAwayForfeit = value;
            }
        }
        public bool IsDraw
        {
            get
            {
                if (homeGoals == awayGoals)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsHomeForfeit
        {
            get
            {
                return this.isHomeForfeit;
            }
            set
            {
                this.isHomeForfeit = value;
            }

        }



    }
}
