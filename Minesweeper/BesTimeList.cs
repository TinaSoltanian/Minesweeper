using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Minesweeper
{
    public class BestTimeList
    {
        private Dictionary<Configuration.GameLevel, BestTimes> _BestTimesList;
        public Dictionary<Configuration.GameLevel, BestTimes> BestTimesList


        {
            get
            {
                return _BestTimesList ;
            }
        }

        public void LoadFromFile(string path)
        {
            _BestTimesList.Clear();
            FileStream file = new FileStream(_Path, FileMode.Open, FileAccess.Read, FileShare.None);
            file.Position = file.Length - 4;
            Byte[] buffer = new Byte[4];

            file.Read(buffer, 0, 4);
            int size = BitConverter.ToInt32(buffer, 0);
            file.Position = 0;
            buffer = new Byte[size];

            file.Read(buffer, 0, size);

            MemoryStream stream = new MemoryStream(buffer);
            BinaryFormatter serializer = new BinaryFormatter();
            _BestTimesList = ((Dictionary<Configuration.GameLevel, BestTimes>)serializer.Deserialize(stream));

            file.Close();
            stream.Close();
        }


        public void SaveToFile( BestTimes BestTime )
        {


            if (File.Exists(_Path))
                File.Delete(_Path);

            if (BestTime != null)
            {
                if (IsPlayerChangeTheRecord(BestTime.BestTime))
                {
                    _BestTimesList[Configuration.Configuration.GameConfiguration.Level].BestTime = BestTime.BestTime;
                    _BestTimesList[Configuration.Configuration.GameConfiguration.Level].WinDateTime = BestTime.WinDateTime;
                    _BestTimesList[Configuration.Configuration.GameConfiguration.Level].WinnerName = BestTime.WinnerName;
                }
            }


            try
            {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, _BestTimesList);

            FileStream savedData = new FileStream(_Path, FileMode.Create, FileAccess.Write, FileShare.None);
            byte[] buffer = stream.ToArray();
            savedData.Write(buffer, 0, buffer.Length);

            stream.Close();
            savedData.Close();

            }
            catch
            {
            }
        }

        public Boolean IsPlayerChangeTheRecord(int seconds)
        {
            if (_BestTimesList[Configuration.Configuration.GameConfiguration.Level].BestTime == 0)
                return true;

            if (seconds < _BestTimesList[Configuration.Configuration.GameConfiguration.Level].BestTime)
                return true;
            else
                return false;
        }

                private string _Path;

        

        private BestTimeList()
        {
            _Path = "BestTime";
            _BestTimesList = new Dictionary<Configuration.GameLevel, BestTimes>();

            if (File.Exists(_Path))
                this.LoadFromFile(_Path);
            else
            {
                BestTimes tmp = new BestTimes { BestTime = 0, WinnerName = "Anonymouse", WinDateTime = DateTime.Now };
                if (!_BestTimesList.ContainsKey(Configuration.GameLevel.Beginner))
                {
                    _BestTimesList.Add(Configuration.GameLevel.Beginner,
                        new BestTimes { BestTime = 0, WinnerName = "Anonymouse", WinDateTime = DateTime.Now });
                }

                if (!_BestTimesList.ContainsKey(Configuration.GameLevel.Intermediate))
                {

                    _BestTimesList.Add(Configuration.GameLevel.Intermediate,
                        new BestTimes { BestTime = 0, WinnerName = "1", WinDateTime = DateTime.Now });
                }

                if (!_BestTimesList.ContainsKey(Configuration.GameLevel.Advanced))
                {

                    _BestTimesList.Add(Configuration.GameLevel.Advanced,
                        new BestTimes { BestTime = 0, WinnerName = "2", WinDateTime = DateTime.Now });
                }
                SaveToFile(null);
            }

        }

        private static BestTimeList _Statisticts;
        public static BestTimeList Statisticts
        {
            get
            {
                if (_Statisticts == null)
                    _Statisticts = new BestTimeList();

                return _Statisticts;

            }
        }
    }
}
