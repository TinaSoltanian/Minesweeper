using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Minesweeper
{
    [Serializable]
    public class BestTimes
    {        

        public string WinnerName { get; set; }
        public DateTime WinDateTime { get; set; }
        
        private int _BestTime;
        public int BestTime
        {
            get
            {
                return _BestTime;
            }
            set
            {
                _BestTime = value;
            }
        }


    }
}
