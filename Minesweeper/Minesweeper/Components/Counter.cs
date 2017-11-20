using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Minesweeper.Components
{
    public class Counter : System.Windows.Forms.Control
    {
        private int _Length;
        private int _Value;
        private bool _IsColored;

        public int Length
        {
            get
            {
                return _Length;
            }
            set
            {
                _Length = value;
                this.Width = value * 13;
                this.Height = 23;
            }
        }

        public int Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                this.Invalidate();
            }
        }

        public bool IsColored
        {
            get
            {
                return _IsColored;
            }
            set
            {
                _IsColored = value;
                this.Invalidate();
            }
        }

        public Counter()
        {
            Length = 3;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (Length < 1)
                return;

            string checkNumber = string.Empty;
            for (int i = 0; i < Length - 1 ; i++ , checkNumber += '9' );
            checkNumber = '-' + checkNumber;

            if (Value < int.Parse( checkNumber ))
                return;

            string format;
            if (Value < 0)
                format = string.Format("{{0:d{0}}}", Length - 1);
            else
                format = string.Format("{{0:d{0}}}", Length);
            string result = string.Format(format, Value);
            result = result.Substring(result.Length - Length, Length); // 023

            int index;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].ToString() == "-")
                    index = 11;
                else
                    index = int.Parse(result[i].ToString());

                e.Graphics.DrawImage( Properties.Resources.NumbersColor ,
                    new Rectangle(i * 13, 0, 13, 23),
                    new Rectangle(0, (11 - index) * 23, 13, 23),
                    GraphicsUnit.Pixel);
            }

        }
    }
}
