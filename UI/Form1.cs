using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        Car c = new Car();
        BoLayer bl = new BoLayer();
        Graphics g;
        Char keyPress;
        int x;
        int y;
        
        public Form1()
        {
            InitializeComponent();
            g = carPanel.CreateGraphics();
            int x = bl.x;
            int y = bl.y;
            keyPress = 'r';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //currentInfoLabel.Text = Convert.ToString(bl.getData());
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            info.Text = null;
            //char c = keyPress;
            switch (keyPress)
            {
                case 'u':
                    c.carUp(g);
                    break;
                case 'd':
                    c.carDown(g);
                    break;
                case 'r':
                    c.carRight(g);
                    break;
                case 'l':
                    c.carLeft(g);
                    break;
            }
            if (bl.speedCalculation() != 0 && !String.IsNullOrEmpty(currentInfoLabel.Text))
            {
                timer1.Interval = bl.speedCalculation();
                timer1.Start();
            }
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void speedButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(trackBar1.Value.ToString()))
                MessageBox.Show("Please, enter speed correctly.");
            else
            {
                Car c = new Car();
                c.speed = Convert.ToInt32(trackBar1.Value)*10;
        
                if (bl.saveSpeed(c))
                {
                    info.Text = "Now, Press 'Start'";
                    currentInfoLabel.Text = Convert.ToString(bl.getData());
                }
                else
                {
                    MessageBox.Show("error");
                    info.Text = null;
                }

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bl.changeAxes(keyPress);
            carPanel.Location = new Point(bl.x, bl.y);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyPress = 'u';
                g.Clear(Color.Gray);
                c.carUp(g);
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyPress = 'd';
                g.Clear(Color.Gray);
                c.carDown(g);
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyPress = 'l';
                g.Clear(Color.Gray);
                c.carLeft(g);
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyPress = 'r';
                g.Clear(Color.Gray);
               c.carRight(g);
            }
        }

       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
       
        //ValueChanged event handler for your trackBar1
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value != c.speed) trackBar1.Value = c.speed;
            c.speed = trackBar1.Value;
        }

    }
}
