using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        private Button buttonCircle;
        private Button buttonSquare;
        private Button buttonRhomb;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Figure App";
            this.Width = 730;
            this.Height = 650;

            buttonCircle = new Button
            {
                Text = "buttonCircle",
                Font = new Font("Arial", 12),
                Location = new Point(120, 530),
                Width = 150,
                Height = 40
            };
            buttonCircle.Click += buttonCircle_Click;

            buttonSquare = new Button
            {
                Text = "buttonSquare",
                Font = new Font("Arial", 12),
                Location = new Point(290, 530),
                Width = 150,
                Height = 40
            };
            buttonSquare.Click += buttonSquare_Click;

            buttonRhomb = new Button
            {
                Text = "buttonRhomb",
                Font = new Font("Arial", 12),
                Location = new Point(460, 530),
                Width = 150,
                Height = 40
            };
            buttonRhomb.Click += buttonRhomb_Click;

            this.Controls.Add(buttonCircle);
            this.Controls.Add(buttonSquare);
            this.Controls.Add(buttonRhomb);
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(250, 250, 80);
            circle.MoveRight();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            Square square = new Square(250, 250, 80);
            square.MoveRight();
        }

        private void buttonRhomb_Click(object sender, EventArgs e)
        {
            Rhomb rhomb = new Rhomb(250, 250, 80, 100);
            rhomb.MoveRight();
        }
    }
}
