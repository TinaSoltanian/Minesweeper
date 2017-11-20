using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper.Configuration
{
    public enum GameLevel : byte
    {
        Beginner = 0,
        Intermediate =1,
        Advanced = 2
    }

    public class Configuration
    {

        private Configuration()
        {
            Level = GameLevel.Intermediate;
        }

        private static Configuration _GameConfiguration;
        public static Configuration GameConfiguration
        {
            get
            {
                if (_GameConfiguration == null)
                    _GameConfiguration = new Configuration() { Level = GameLevel.Intermediate };

                return _GameConfiguration;

            }
        }

        private GameLevel _Level;
        public GameLevel Level
        {
            set
            {
                _Level = value;
                switch ( _Level )
                {
                    case GameLevel.Beginner  :
                        _Row = 9;
                        _Column = 9;
                        MineCount = 10;
                        break;
                    case GameLevel.Intermediate :
                        _Row = 16;
                        _Column = 16;
                        MineCount = 40;
                        break;
                    case GameLevel.Advanced :
                        _Row = 16;
                        _Column = 30;
                        MineCount = 99;
                        break;           
                }
            }
            get
            {
                return _Level;
            }
        }

        private int _Row;
        public int Row
        {
            get
            {
                return _Row;
            }
            set
            {
                _Row = value;
            }
        }

        public int _ButtonSize;
        public int ButtonSize
        {
            get
            {
                _ButtonSize = 16;
                return _ButtonSize;
            }
        }
        private int _Column;
        public int Column
        {
            get
            {
                return _Column;
            }
            set
            {
                _Column = value;
            }
        }

        public int MineCount { get; set; }

        public ImageList Images { get; set; }

    }
}
