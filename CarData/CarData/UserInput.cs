using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarData
{
    internal class UserInput
    {
        #region Public Properties 
        public List<DataSet> Attribute1 { get; private set; }
        #endregion

        #region Constructor 
        public UserInput()
        {
            Attribute1 = new List<DataSet>();
        }
        #endregion

        #region Public Methods 
        public void AddCarDistanceTime(double distance, double time)
        {
            DataSet dataSet = new DataSet();
            dataSet.Distance = distance;
            dataSet.Time = time;
            dataSet.Speed = distance / time;
            Attribute1.Add(dataSet);
        }

        public List<DataSet> GetAttribute1()
        {
            return Attribute1;
        }
        #endregion



    }
}
