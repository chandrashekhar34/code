using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarData
{
    internal class DataSet
    {

        #region Private Properties 

        #endregion

        #region Public Properties 
        public double Distance { get; set; }
        public double Time { get; set; }
        public double Speed { get; set; }
        #endregion

        #region Constructor 
        public DataSet()
        {
            Distance = 0.0;
            Time = 0.0;
            Speed = 0.0;
        }
        #endregion

    }
}
