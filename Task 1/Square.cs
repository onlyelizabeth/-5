using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Square : Figure
    {
        protected int sideLength;

        //public Square() : base()
        //{
        //    this.sideLength = 5;
        //}

        public Square(int centerX, int centerY, int sideLength) : base(centerX, centerY)
        {
            this.sideLength = sideLength;
        }

        private Point[] GetCurrPoints()
        {
            return new Point[] {
                new Point(centerX - sideLength,  centerY - sideLength),
                new Point(centerX - sideLength,  centerY + sideLength),
                new Point(centerX + sideLength,  centerY + sideLength),
                new Point(centerX + sideLength,  centerY - sideLength),
            };
        }

        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(Pens.Black, GetCurrPoints());
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), GetCurrPoints());
        }
    }
}
