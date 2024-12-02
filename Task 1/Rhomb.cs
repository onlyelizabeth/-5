using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Rhomb : Figure
    {
        protected int horDiagLen;
        protected int vertDiagLen;

        //public Rhomb() : base()
        //{
        //    this.horDiagLen = 6;
        //    this.vertDiagLen = 8;
        //}

        public Rhomb(int centerX, int centerY, int horDiagLen, int vertDiagLen) : base(centerX, centerY)
        {
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
        }

        private Point[] GetCurrPoints()
        {
            return new Point[] {
                 new Point(centerX, centerY - vertDiagLen),
                 new Point(centerX - horDiagLen, centerY),
                 new Point(centerX, centerY + vertDiagLen),
                 new Point(centerX + horDiagLen, centerY),
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
