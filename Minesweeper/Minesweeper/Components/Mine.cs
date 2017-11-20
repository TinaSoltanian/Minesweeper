using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Minesweeper.Components
{
    public class Mine : System.Windows.Forms.Control
    {
        public event System.EventHandler BombDetected;

        public void RaiseEvent()
        {
            if (BombDetected != null)
                BombDetected(this, EventArgs.Empty);
        }

        public Mine()
        {
            Height = Configuration.Configuration.GameConfiguration.ButtonSize;
            Width = Configuration.Configuration.GameConfiguration.ButtonSize;

            IsHidden = true;
            IsFlagged = false;
            IsMarked = false;
            IsBomb = false;
            IsExploded = false;
            BombCount = 0;
            Tag = 0;
        }
       
        public int LocationColumn { get; set; }
        public int LocationRow { get; set; }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            int y = 0;

            if (this.IsHidden && !this.IsFlagged && !this.IsMarked)
                y = 0;
            else if (this.IsHidden && this.IsFlagged && !this.IsMarked)
            {
                y = 1;
                this.RaiseEvent();
            }
            else if (this.IsHidden && !this.IsFlagged && this.IsMarked)
            {
                y = 2;
                this.RaiseEvent();
            }
            else if (!this.IsHidden && this.IsExploded)
                y = 3;
            else if (!this.IsHidden && this.IsFlagged && !this.IsMarked && !this.IsBomb)
                y = 4;
            else if (!this.IsHidden && !this.IsFlagged && !this.IsMarked && this.IsBomb)
                y = 5;
            else if (!this.IsHidden && this.IsMarked)
                y = 6;
            else
                y = 15 - BombCount;

            e.Graphics.DrawImage(Properties.Resources.ButtonsColor,
                new Rectangle(0, 0, this.Height, this.Width),
                new Rectangle(0, 
                    y * Configuration.Configuration.GameConfiguration.ButtonSize, 
                    Configuration.Configuration.GameConfiguration.ButtonSize, 
                    Configuration.Configuration.GameConfiguration.ButtonSize),
                GraphicsUnit.Pixel);

        }

        private bool _IsHidden;
        public bool IsHidden {
            get
            {
                return _IsHidden;
            }
            set
            {
                _IsHidden = value;
                this.Invalidate();
            }
        }

        private bool _IsFlagged;
        public bool IsFlagged
        {
            get
            {
                return _IsFlagged;
            }
            set
            {
                _IsFlagged = value;
                this.Invalidate();
            }
        }

        private bool _IsMarked;
        public bool IsMarked {
            get
            {
                return _IsMarked;
            }
            set
            {
                _IsMarked = value;
                this.Invalidate();
            }
        }

        private bool _IsExploded;
        public bool IsExploded {
            get
            {
                return _IsExploded;
            }
            set
            {
                _IsExploded = value;
                this.Invalidate();
            }
        }

        private bool _IsBoomb;
        public bool IsBomb
        {
            get
            {
                return _IsBoomb;
            }
            set
            {
                _IsBoomb = value;
                this.Invalidate();
            }
        }

        private int _BombCount;
        public int BombCount {
            get
            {
                return _BombCount;
            }
            set
            {
                _BombCount = value;
                this.Invalidate();
            }
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            if (!this.IsHidden)
                return;

            if (e.Button == MouseButtons.Left)
            {
                if (!this.IsFlagged && !this.IsMarked)
                    this.IsHidden = false;
            }
            else
            {
                if (this.IsMarked)
                {
                    this.IsFlagged = false;
                    this.IsMarked = false;
                }
                else if (!this.IsFlagged)
                {
                    this.IsFlagged = true;
                    this.IsMarked = false;
                }
                else if (!this.IsMarked)
                {
                    this.IsFlagged = false;
                    this.IsMarked = true;
                }
            }


            base.OnMouseUp(e);

        }


    }
}
