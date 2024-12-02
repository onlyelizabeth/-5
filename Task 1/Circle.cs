using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Circle : Figure
    {
        protected int radius;

        //public Circle() : base()
        //{
        //    this.radius = 5;
        //}
        public Circle(int centerX, int centerY, int radius) : base(centerX, centerY)
        {
            this.radius = radius;
        }

        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), centerX - radius, centerY - radius, radius * 2, radius * 2);
        }
    }
}
