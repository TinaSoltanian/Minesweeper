using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper.Components
{
    public class Smiley : System.Windows.Forms.Control
    {
        public Smiley()
        {
            Width = 24;
            Height = 24;

            IsHappy = true;
            IsSad = false;
            IsAmazed = false;
            IsGlassWeared = false;

        }

        private bool _IsHappy;
        private bool _IsGlassWeared;
        private bool _IsSad;
        private bool _IsAmazed;

        public bool IsHappy {
            get
            {
                return _IsHappy;
            }
            set
            {
                _IsHappy = value;



                this.Invalidate();
            }
            }

        public bool IsGlassWeared
        {
            get
            {
                return _IsGlassWeared;
            }
            set
            {
                _IsGlassWeared = value;

                this.Invalidate();
            }
        }

        public bool IsSad
        {
            get
            {
                return _IsSad;
            }
            set
            {
                _IsSad = value;

                this.Invalidate();
            }
        }

        public bool IsAmazed
        {
            get
            {
                return _IsAmazed;
            }
            set
            {
                _IsAmazed = value;

                this.Invalidate();
            }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            int y = 0;

            if (IsHappy)
                y = 4;
            else if (IsGlassWeared)
                y = 1;
            else if (IsSad)
                y = 2;
            else if (IsAmazed)
                y = 3;

            e.Graphics.DrawImage(Properties.Resources.Smily,
                new System.Drawing.Rectangle(0, 0, 24, 24),
                new System.Drawing.Rectangle(0, y * 24, 24, 24),
                System.Drawing.GraphicsUnit.Pixel);

        }
    }
}
