using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Minesweeper.Components
{
    public class Game : System.Windows.Forms.Panel
    {
        private enum EventState
        {
            WinTheGame,
            TheGameOver,
            ItemCLicked,
            ItemDBLCLicked,
            ItemMouseUP,
            OnMineDetected,
            OnMouseDown
        }

        private Minesweeper.Components.Mine[,] Mines;
        private Timer _Timer = new Timer() { Interval = 1000, Enabled = false };

        public event System.EventHandler WinTheGame;
        public event System.EventHandler TheGameOver;
        public event System.EventHandler ItemCLicked;
        public event System.EventHandler ItemDBLCLicked;
        public event System.EventHandler ItemMouseUP;
        public event System.EventHandler MineDetected;
        public event System.EventHandler MouseDown;


        private void RaiseEvent( EventState State )
        {
            if ((WinTheGame != null) && (State == EventState.WinTheGame))
            {
                WinTheGame(this, EventArgs.Empty);
                //return;
            }

            if ((TheGameOver != null) && (State == EventState.TheGameOver))
            {
                TheGameOver(this, EventArgs.Empty);
                return;
            }

            if ((ItemCLicked != null) && (State == EventState.ItemCLicked))
            {
                ItemCLicked(this, EventArgs.Empty);
                return;
            }

            if ((ItemDBLCLicked != null) && (State == EventState.ItemDBLCLicked))
            {
                ItemDBLCLicked(this, EventArgs.Empty);
                return;
            }

            if ((ItemMouseUP != null) && (State == EventState.ItemMouseUP))
            {
                ItemMouseUP(this, EventArgs.Empty);
                return;
            }

            if ((MineDetected != null) && (State == EventState.OnMineDetected))
            {
                MineDetected(this, EventArgs.Empty);
                return;
            }

            if ((MouseDown != null) && (State == EventState.OnMouseDown))
            {
                MouseDown(this, EventArgs.Empty);
                return;
            }
        }

        private int _GameTime;
        public int GameTime
        {
            get
            {
                return _GameTime;
            }
        }

        private int _DetectedBombsCount;
        public int DetectedBombsCount
        {
            get
            {
                return _DetectedBombsCount;
            }
            private set
            {
                _DetectedBombsCount = value;
                if (_DetectedBombsCount == 0)
                {
                    _Winner = this.HasWon();
                }
            }
        }

        private void OnMouseUp( object sender , EventArgs e )
        {
            RaiseEvent(EventState.ItemMouseUP);
            if (this.HasWon())
            {
                _Winner = true;
                _Timer.Enabled = false;
                this.RaiseEvent( EventState.WinTheGame );
            }
        }

        private void OnMouseDown(object sender, EventArgs e)
        {
            if ( (sender as Mine).Tag.ToString()  == "0" )
            {
                (sender as Mine).Click += CubeClick;
                (sender as Mine).DoubleClick += CudeDoubleClick;
                (sender as Mine).BombDetected += (OnBombDetected);
                (sender as Mine).MouseUp += (OnMouseUp);
                (sender as Mine).MouseDown += (OnMouseDown);
                (sender as Mine).Tag = 1;
            }
            RaiseEvent(EventState.OnMouseDown);
        }

        private bool HasWon()
        {
            for (int i = 0; i < Configuration.Configuration.GameConfiguration.Column; i++)
            {
                for (int j = 0; j < Configuration.Configuration.GameConfiguration.Row; j++)
                {
                    if ((Mines[i, j].IsHidden )&& (!Mines[i, j].IsFlagged))
                        return false;

                    if ((!Mines[i, j].IsFlagged && Mines[i, j].IsBomb))
                        return false;
                }
            }

            return true;
        }
        private bool _Winner;
        public bool Winner
        {
            get
            {
                return _Winner;
            }
        }
         public void Initialize()
        {
            GameOver = false;
            FirstClick = false;
            _GameTime = 0;
            _DetectedBombsCount = Configuration.Configuration.GameConfiguration.MineCount;

            this.Height = (Configuration.Configuration.GameConfiguration.ButtonSize *
                Configuration.Configuration.GameConfiguration.Row) + 4;

            this.Width = (Configuration.Configuration.GameConfiguration.Column *
                Configuration.Configuration.GameConfiguration.ButtonSize) + 4;

            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            Mines = new Mine[Configuration.Configuration.GameConfiguration.Column,
                             Configuration.Configuration.GameConfiguration.Row];

            Control[] tmp = new Control[ Configuration.Configuration.GameConfiguration.Column * 
                                         Configuration.Configuration.GameConfiguration.Row ];
            int c = 0;
             //_DetectedBombsCount = 0;
            for (int i = 0; i < Configuration.Configuration.GameConfiguration.Column; i++)
            {
                for (int j = 0; j < Configuration.Configuration.GameConfiguration.Row; j++)
                {
                    Mines[i, j] = new Mine() 
                        { Top =  (j * 
                            Configuration.Configuration.GameConfiguration.ButtonSize ),
                        Left =   (i  *
                            Configuration.Configuration.GameConfiguration.ButtonSize),
                            //IsHidden = false,
                            LocationColumn = i,
                            LocationRow = j
                    
                        };
//                    Mines[i, j].Click += CubeClick;
//                    Mines[i, j].DoubleClick += CudeDoubleClick;
//                    Mines[i, j].BombDetected += (OnBombDetected);
//                    Mines[i, j].MouseUp += (OnMouseUp);
                    Mines[i, j].MouseDown += (OnMouseDown);
                    tmp[c] = Mines[i,j];
                    c++;
                }
            }
            this.Controls.Clear();
            this.Controls.AddRange(tmp);


            _GameTime = 0;
            _Timer.Tick += delegate { _GameTime++; };
            _Timer.Enabled = true;
        }

         private void OnBombDetected( object sender , EventArgs e )
         {

             if ((sender as Components.Mine).IsFlagged)
                 _DetectedBombsCount--;
             else if ((sender as Components.Mine).IsMarked)
                 if (_DetectedBombsCount < Configuration.Configuration.GameConfiguration.MineCount)
                     _DetectedBombsCount++;
                 else
                     _DetectedBombsCount = Configuration.Configuration.GameConfiguration.MineCount;

             RaiseEvent(EventState.OnMineDetected);
         }

        private void GameOvered()
        {
            for (int i = 0; i < Configuration.Configuration.GameConfiguration.Column; i++)
            {
                for (int j = 0; j < Configuration.Configuration.GameConfiguration.Row; j++)
                {
                    if (Mines[i, j].IsBomb)
                    {
                        Mines[i, j].IsHidden = Mines[i, j].IsFlagged = Mines[i, j].IsMarked = false;
                    }

                    if (Mines[i, j].IsFlagged && !Mines[i,j].IsBomb)
                    {
                        Mines[i, j].IsHidden = false; 
                    }
                }
            }
        }

        private bool _GameOver;
        public bool GameOver {
            get
            {
                return _GameOver;
            }
            private set
            {
                _GameOver = value;
                if (value == true)
                {
                    this.GameOvered();
                    _Timer.Enabled = false;
                    RaiseEvent( EventState.TheGameOver );
                }
            }
        }

        private Mine FirstClickedCude;
        private void CubeClick ( object sender, EventArgs e )
        {
            RaiseEvent( EventState.ItemCLicked );
            if ((e as MouseEventArgs).Button == System.Windows.Forms.MouseButtons.Right)
            {
                return;
            }

            if (!(sender as Mine).IsHidden)
                return;

            if (FirstClick == false)
            {
                FirstClickedCude = (sender as Mine);
                Count = 0;
                FirstClick = true;                
            }

            if ((sender as Mine).IsFlagged)
                return;

            if ((sender as Mine).IsMarked)
                return;

            if ((sender as Mine).IsBomb)
            {
                (sender as Mine).IsHidden = false;
                (sender as Mine).IsExploded = true;
                GameOver = true;
                return;
            }


            RaiseEvent(EventState.ItemMouseUP);
            if ((sender as Mine).IsHidden &&
                 (sender as Mine).BombCount == 0 &&
                 !(sender as Mine).IsBomb
                )
                OpenCubes(
                          (sender as Mine).LocationColumn,
                          (sender as Mine).LocationRow
                          );

        }

        private bool _FirstClick;
        public bool FirstClick {


            get
            {
                return _FirstClick;
            }
            set
            {
                _FirstClick = value;
                if (Count == 0 && _FirstClick)
                    this.ArrangeMins();
            }
        }

        private int Count;
        public void ArrangeMins()
        {
                Random random = new Random();
                int x, y;
                Count = 0;

                do
                {

                    x = random.Next(1, Configuration.Configuration.GameConfiguration.Column);
                    y = random.Next(1, Configuration.Configuration.GameConfiguration.Row);

                    if (Mines[x, y].IsBomb)
                        continue;

                    if ((FirstClickedCude.LocationColumn == x) && (FirstClickedCude.LocationRow == y))
                        continue;  

                    Mines[x, y].IsBomb = true;
                    Count++;
                }
                while (Count < Configuration.Configuration.GameConfiguration.MineCount);

                for (int i = 0; i < Configuration.Configuration.GameConfiguration.Column; i++)
                {
                    for (int j = 0; j < Configuration.Configuration.GameConfiguration.Row; j++)
                    {
                        if (Mines[i, j].IsBomb)
                            continue;

                        Mine[] neighbers = this.GetMineCount(i, j);
                        foreach (Mine item in neighbers)
                        {
                            if (item.IsBomb)
                                Mines[i, j].BombCount++;
                        }
                    }
                }
        }

        public Mine[] GetMineCount( int i, int j )
        {
            List<Point> indexes = new List<Point>();

            indexes.Add(new Point(i - 1, j - 1)); // سمت چپ بالا
            indexes.Add(new Point(i - 1, j)); // وسط بالا
            indexes.Add(new Point(i - 1, j + 1)); // سمت راست بالا
            indexes.Add(new Point(i, j - 1)); // وسط چپ
            indexes.Add(new Point(i, j + 1)); // وسط راست
            indexes.Add(new Point(i + 1, j - 1)); // سمت چپ پائین
            indexes.Add(new Point(i + 1, j)); // وسط پائین
            indexes.Add(new Point(i + 1, j + 1)); // سمت راست پائین
            
            var query = from p in indexes
                        where p.X >= 0 && p.Y >= 0 && // نباید از صفر کوچکتر باشد
                                p.X < Configuration.Configuration.GameConfiguration.Column && 
                                p.Y < Configuration.Configuration.GameConfiguration.Row // حذف مواردی که از تعداد ردیف ها و ستونها بیشتر میشود
                        select p;

            List<Mine> result = new List<Mine>();

            foreach (Point point in query)
                result.Add(Mines[point.X, point.Y]);

            return result.ToArray();            
        }

        Mine[] OpenQueue;
        private void OpenCubes(int i, int j)
        {
            OpenQueue = this.GetMineCount( i , j) ;
            foreach (Mine item in OpenQueue)
            {
                if (item.IsBomb)
                    continue;

                if (!item.IsHidden)
                    continue;

                if (item.BombCount > 0)
                {
                    item.IsHidden = false;                    
                }

                if (item.IsFlagged && !item.IsBomb)
                {
                    GameOver = true;
                    return;
                }

                if (item.IsFlagged || item.IsMarked)
                    continue;

                if (item.BombCount == 0 && item.IsHidden)
                {
                    item.IsHidden = false;
                    this.OpenCubes(item.LocationColumn, item.LocationRow);
                }
            }

        }

        private void CudeDoubleClick(object sender, EventArgs e)
        {
            RaiseEvent(EventState.ItemDBLCLicked);
            if (!(((sender as Mine).IsHidden == false) && ((sender as Mine).BombCount > 0)))
                return;
            int flagCount = 0;
            OpenQueue = this.GetMineCount( (sender as Mine).LocationColumn , (sender as Mine).LocationRow ) ;
            foreach (Mine item in OpenQueue)
            {
                if (item.IsMarked)
                    return;

                if (item.IsFlagged)
                    flagCount++;
            }

            if (flagCount != (sender as Mine).BombCount)
                return;

            OpenCubes( (sender as Mine).LocationColumn , (sender as Mine).LocationRow );
        }


    }
}
