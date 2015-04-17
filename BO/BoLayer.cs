using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Drawing;

namespace BO
{
    public class BoLayer
    {
        Graphics g;
        Car c = new Car();
        DalLayer d = new DalLayer();
        public int x = 12;
        public int y = 126;
        public char key = 'r';
        public bool saveSpeed(Car c)
        {
            return d.save(Convert.ToString(c.speed));
        }
        public int speedCalculation()
        {
            Car c = d.getData();
            return c.speed;
        }

        public int getData()
        {
            Car c = d.getData();
            int speed = c.speed;
            return speed;
        }
        public void changeAxes(char key)
        {
            if (key == 'u')
            {
                if(y!=60)
                    y = y -  3;
            }
            else if (key == 'd')
            {
                if(y!=180)
                    y = y + 3;
            }
            else if (key == 'l')
            {
                if(x!=0)
                    x = x - 3;
            }
            else if (key == 'r')
            {
                
                if ( x != 400)
                {
                    if(x==394&& y==140)
                    {
                        x = 0;
                    }
                    else
                       x = x + 3;
                   
                }
                   
            }
        }
        public void setKey(char c)
        {
            key = 'c';
        }
        public char getKey()
        {
            return key;
        }
        public void getRight(Graphics g)
        {
            c.carRight(g);
        }
        public void getLeft(Graphics g)
        {
            c.carLeft(g);
        }
        public void getUp(Graphics g)
        {
            c.carUp(g);
        }
        public void getDown(Graphics g)
        {
            c.carDown(g);
        }
    }
}
