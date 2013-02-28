using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class Club
    {
        private string name;
    
        
        public Club(string name)
        {
            this.name = name;
      
        }

       


        public override string ToString() // il faut faire override
        {
            return this.name;

        }
            


    }
}
