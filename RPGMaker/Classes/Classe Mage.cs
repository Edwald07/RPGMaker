using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGMaker.Classes;

namespace RPGMaker.Classes
{
    public class Mage : Personnage
    {
      
        #region Caractéristiques

        public int Intelligence
        {
            get { return base.Intelligence + 4; }
            set { base.Intelligence = value; }
        }

        public int Sagesse
        {
            get { return base.Sagesse + 2; }
            set { base.Sagesse = value; }
        }
        
        #endregion

        
    }
}