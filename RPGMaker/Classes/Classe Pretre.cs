using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGMaker.Classes;

namespace RPGMaker.Classes
{
    public class Pretre : Personnage
    {
        

        #region Caractéristiques
         
        public int Intelligence
        {
            get { return base.Intelligence + 2; }
            set { base.Intelligence = value; }
        }
        
        public int Sagesse
        {
            get { return base.Sagesse + 4; }
            set { base.Sagesse = value; }
        }
       
        #endregion

    }
}