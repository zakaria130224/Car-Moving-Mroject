using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Entity
{
    public class Car
    {
        public int speed;
        public void carRight(Graphics g)
        {
            Pen p = new Pen(Color.Chocolate, 3);
            Pen p1 = new Pen(Color.Black, 3);
            Brush b = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            Brush b1 = new System.Drawing.SolidBrush(System.Drawing.Color.YellowGreen);
            g.DrawLine(p, 25, 10, 100, 10);
            g.DrawLine(p, 12, 30, 25, 10);
            g.DrawLine(p, 12, 30, 2, 30);
            g.DrawLine(p, 2, 45, 2, 30);
            g.DrawLine(p, 115, 30, 100, 10);
            g.DrawRectangle(p, 35, 15, 10, 15);
            g.DrawRectangle(p, 75, 15, 10, 15);
            g.DrawLine(p, 115, 30, 135, 30);
            g.DrawLine(p, 135, 45, 135, 30);
            g.DrawLine(p, 2, 45, 25, 45);
            g.FillEllipse(b1, 132, 30, 10, 10);

            g.FillEllipse(b, 23, 35, 20, 20);
            g.DrawLine(p, 42, 45, 90, 45);
            g.FillEllipse(b, 88, 35, 20, 20);
            g.DrawLine(p, 135, 45, 107, 45);
        }

        public void carLeft(Graphics g)
        {
            Pen p = new Pen(Color.Chocolate, 3);
            Pen p1 = new Pen(Color.Black, 3);
            Brush b = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            Brush b1 = new System.Drawing.SolidBrush(System.Drawing.Color.YellowGreen);
            g.DrawLine(p, 2, 30, 2, 45);
            g.DrawLine(p, 2, 30, 22, 30);
            g.DrawLine(p, 37, 10, 22, 30);
            g.DrawLine(p, 37, 10, 112, 10);
            g.DrawLine(p, 125, 30, 112, 10);
            g.DrawLine(p, 125, 30, 135, 30);
            g.DrawLine(p, 135, 45, 135, 30);
            g.DrawRectangle(p, 40, 15, 10, 15);
            g.DrawRectangle(p, 85, 15, 10, 15);
            g.FillEllipse(b1, -3, 30, 10, 10);

            g.DrawLine(p, 135, 45, 112, 45);
            g.DrawLine(p, 95, 45, 47, 45);
            g.DrawLine(p, 2, 45, 30, 45);
            //g.DrawEllipse(p1, 28, 35, 20, 20);
            g.FillEllipse(b, 93, 35, 20, 20);
            g.FillEllipse(b, 28, 35, 20, 20);

        }

        public void carUp(Graphics g)
        {
            Pen p = new Pen(Color.Chocolate, 3);

            g.DrawLine(p, 20, 20, 20, 80);
            g.DrawLine(p, 60, 80, 20, 80);
            g.DrawLine(p, 60, 80, 60, 20);
            g.DrawLine(p, 20, 20, 60, 20);
            g.DrawLine(p, 25, 10, 20, 20);
            g.DrawLine(p, 55, 10, 60, 20);
            g.DrawLine(p, 25, 10, 55, 10);
            g.DrawLine(p, 25, 90, 20, 80);
            g.DrawLine(p, 55, 90, 60, 80);
            g.DrawLine(p, 25, 90, 55, 90);

        }

        public void carDown(Graphics g)
        {
            Pen p = new Pen(Color.Chocolate, 3);

            g.DrawLine(p, 20, 20, 20, 80);
            g.DrawLine(p, 60, 80, 20, 80);
            g.DrawLine(p, 60, 80, 60, 20);
            g.DrawLine(p, 20, 20, 60, 20);
            g.DrawLine(p, 25, 10, 20, 20);
            g.DrawLine(p, 55, 10, 60, 20);
            g.DrawLine(p, 25, 10, 55, 10);
            g.DrawLine(p, 25, 90, 20, 80);
            g.DrawLine(p, 55, 90, 60, 80);
            g.DrawLine(p, 25, 90, 55, 90);



        }
    }
   
}
