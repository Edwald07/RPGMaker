using RPGMaker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Classes
{
    public class Voleur : Personnage
    {
       
        #region Caractéristiques
  
        public int Endurance
        {
            get { return base.Endurance + 1; }
            set { base.Endurance = value; }
        }

        public int Intelligence
        {
            get { return base.Intelligence + 2; }
            set { base.Intelligence = value; }
        }

        public int Agilite
        {
            get { return base.Agilite + 2;}
            set { base.Agilite = value; }
        }


        #endregion

    }
}