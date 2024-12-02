using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class Figure
    {
        protected int centerX;
        protected int centerY;

        //public Figure()
        //{
        //    this.centerX = 0;
        //    this.centerY = 0;
        //}

        public Figure(int centerX, int centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }

        public int CenterX
        {
            get
            {
                return centerX;
            }

            set
            {
                centerX = value;
            }
        }

        public int CenterY
        {
            get
            {
                return centerY;
            }

            set
            {
                centerY = value;
            }
        }

        public abstract void DrawBlack();

        public abstract void HideDrawingBackGround();

        public void MoveRight()
        {
            for (int i = 0; i < 50; i++)
            {
                DrawBlack();
                Wait();
                Erase();
                UpdateCoordinateX();
            }
        }

        public void Wait()
        {
            System.Threading.Thread.Sleep(100);
        }

        public void Erase()
        {
            HideDrawingBackGround();
        }

        public void UpdateCoordinateX()
        {
            centerX++;
        }
    }
}
