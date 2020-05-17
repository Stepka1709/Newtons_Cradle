using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class Pendulum : Form
    {
        private Bitmap bitmap;
        private Graphics graphix;

        SolidBrush background = new SolidBrush(Color.SlateGray);
        SolidBrush circles = new SolidBrush(Color.White);

        float parameter;
        float step;
        float angle;
        float x1, y1, x2, y2, x3, y3, x4, y4, x5, y5;
        float x6, y6, x7, y7, x8, y8, x9, y9, x10, y10;

        public Pendulum()
        {
            InitializeComponent();
        }

        private void CirclesLoading()
        {
            SolidBrush circles = new SolidBrush(Color.White);

            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphix = Graphics.FromImage(bitmap);
            graphix.FillRectangle(background, 0, 0, pictureBox.Width, pictureBox.Height);
            graphix.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphix.TranslateTransform((float)pictureBox.Width / 2, (float)pictureBox.Height / 2);

            pictureBox.BackgroundImage = bitmap;
        }

        private void Pendulum_Load(object sender, EventArgs e)
        {
            timerGo.Start();
        }

        private void timerGo_Tick(object sender, EventArgs e)
        {
            CirclesLoading();
            step++;
            angle += (float)0.362;

            if (step > 2)
            {
                x2 = -299;
                y2 = 0;
                x3 = -199;
                y3 = 0;
                x4 = -99;
                y4 = 0;
                graphix.FillEllipse(circles, x2, y2, 100, 100);
                graphix.FillEllipse(circles, x3, y3, 100, 100);
                graphix.FillEllipse(circles, x4, y4, 100, 100);

                Pen pen3 = new Pen(Color.Red);
                graphix.DrawLine(pen3, -250, -350, x2 + 50, y2);
                graphix.DrawLine(pen3, -150, -350, x3 + 50, y3);
                graphix.DrawLine(pen3, -50, -350, x4 + 50, y4);
                if (step < 7)
                {
                    x1 = -437 + (float)(200 * (float)Math.Cos(0.285 + angle + parameter));
                    y1 = -55 + (float)(50 * (float)Math.Sin(0.285 + angle + parameter));

                    parameter += (float)0.012;
                    graphix.FillEllipse(circles, x1, y1, 100, 100);
                    x5 = 0;
                    y5 = 0;
                    graphix.FillEllipse(circles, x5, y5, 100, 100);
                    SolidBrush circl = new SolidBrush(Color.Silver);
                    x6 = -467 + (float)(200 * (float)Math.Cos(0.285 + angle + parameter));
                    y6 = -15 + (float)(50 * (float)Math.Sin(0.285 + angle + parameter));
                    x7 = -427 + (float)(200 * (float)Math.Cos(0.285 + angle + parameter));
                    y7 = -15 + (float)(50 * (float)Math.Sin(0.285 + angle + parameter));
                    x8 = -377 + (float)(200 * (float)Math.Cos(0.285 + angle + parameter));
                    y8 = -15 + (float)(50 * (float)Math.Sin(0.285 + angle + parameter));
                    x9 = -450 + (float)(200 * (float)Math.Cos(0.285 + angle + parameter));
                    y9 = -50 + (float)(50 * (float)Math.Sin(0.285 + angle + parameter));
                    x10 = -410 + (float)(200 * (float)Math.Cos(0.285 + angle + parameter));
                    y10 = -40 + (float)(50 * (float)Math.Sin(0.285 + angle + parameter));
                    Pen pen1 = new Pen(Color.Red);
                    graphix.DrawLine(pen1, -350, -350, x9 + 60 + 3 * step, y9 - 5);
                    graphix.DrawLine(pen1, 50, -350, x5 + 50, y5);

                    graphix.FillEllipse(circl, x6, y6, 70, 70);
                    graphix.FillEllipse(circl, x7, y7, 70, 70);
                    graphix.FillEllipse(circl, x8, y8, 70, 70);
                    graphix.FillEllipse(circl, x9, y9, 70, 70);
                    graphix.FillEllipse(circl, x10, y10, 60, 60);
                }
                if (step > 6 && step < 9)
                {
                    x1 = -454 - (float)(200 * (float)Math.Sin(0.20285 + angle + parameter));
                    y1 = -49 - (float)(50 * (float)Math.Cos(0.20285 + angle + parameter));
                    parameter -= (float)0.042;
                    graphix.FillEllipse(circles, x1, y1, 100, 100);
                    x5 = 0;
                    y5 = 0;
                    graphix.FillEllipse(circles, x5, y5, 100, 100);

                    SolidBrush circl = new SolidBrush(Color.Silver);
                    x6 = -484 - (float)(200 * (float)Math.Sin(0.20285 + angle + parameter));
                    y6 = -9 - (float)(50 * (float)Math.Cos(0.20285 + angle + parameter));
                    x7 = -444 - (float)(200 * (float)Math.Sin(0.20285 + angle + parameter));
                    y7 = -9 - (float)(50 * (float)Math.Cos(0.20285 + angle + parameter));
                    x8 = -394 - (float)(200 * (float)Math.Sin(0.20285 + angle + parameter));
                    y8 = -9 - (float)(50 * (float)Math.Cos(0.20285 + angle + parameter));
                    x9 = -467 - (float)(200 * (float)Math.Sin(0.20285 + angle + parameter));
                    y9 = -44 - (float)(50 * (float)Math.Cos(0.20285 + angle + parameter));
                    x10 = -427 - (float)(200 * (float)Math.Sin(0.20285 * 1 + angle + parameter));
                    y10 = -34 - (float)(50 * (float)Math.Cos(0.20285 + angle + parameter));
                    parameter -= (float)0.042;
                    Pen pen1 = new Pen(Color.Red);
                    graphix.DrawLine(pen1, -350, -350, x9 + 70 + 2 * step, y9 - 5);
                    graphix.DrawLine(pen1, 50, -350, x5 + 50, y5);

                    graphix.FillEllipse(circl, x6, y6, 70, 70);
                    graphix.FillEllipse(circl, x7, y7, 70, 70);
                    graphix.FillEllipse(circl, x8, y8, 70, 70);
                    graphix.FillEllipse(circl, x9, y9, 70, 70);
                    graphix.FillEllipse(circl, x10, y10, 60, 60);

                }
                if (step > 8 && step < 13)
                {
                    SolidBrush background = new SolidBrush(Color.DodgerBlue);
                    graphix.FillRectangle(background, -605, -330, pictureBox.Width, pictureBox.Height);
                    x2 = -299;
                    y2 = 0;
                    x3 = -199;
                    y3 = 0;
                    x4 = -99;
                    y4 = 0;
                    graphix.FillEllipse(circles, x2, y2, 100, 100);
                    graphix.FillEllipse(circles, x3, y3, 100, 100);
                    graphix.FillEllipse(circles, x4, y4, 100, 100);
                    Pen pen2 = new Pen(Color.Red);
                    graphix.DrawLine(pen3, -250, -350, x2 + 50, y2);
                    graphix.DrawLine(pen3, -150, -350, x3 + 50, y3);
                    graphix.DrawLine(pen3, -50, -350, x4 + 50, y4);

                    x1 = -398;
                    y1 = -1;
                    graphix.FillEllipse(circles, x1, y1, 100, 100);
                    SolidBrush circle = new SolidBrush(Color.Yellow);
                    x5 = -55 - (float)(200 * (float)Math.Sin(0.285 + angle + parameter));
                    y5 = -47 - (float)(50 * (float)Math.Cos(0.285 + angle + parameter));

                    parameter += (float)0.030;
                    graphix.FillEllipse(circle, x5, y5, 100, 100);

                    graphix.DrawLine(pen2, -350, -350, x1 + 50, y1);
                    graphix.DrawLine(pen2, 50, -350, x5 + 75 - step * 3, y5);
                }

                if (step > 10 && step < 19)
                {
                    Pen pen1 = new Pen(Color.Yellow);
                    graphix.DrawLine(pen1, 70, 15, 270, 15);
                    graphix.DrawLine(pen1, 170, -85, 170, 115);
                    graphix.DrawLine(pen1, 90, 105, 260, -75);
                    graphix.DrawLine(pen1, 90, -75, 260, 105);
                }
                if (step > 12 && step < 17)
                {
                    SolidBrush background = new SolidBrush(Color.DodgerBlue);
                    graphix.FillRectangle(background, -605, -330, pictureBox.Width, pictureBox.Height);
                    x2 = -299;
                    y2 = 0;
                    x3 = -199;
                    y3 = 0;
                    x4 = -99;
                    y4 = 0;

                    graphix.FillEllipse(circles, x2, y2, 100, 100);
                    graphix.FillEllipse(circles, x3, y3, 100, 100);
                    graphix.FillEllipse(circles, x4, y4, 100, 100);

                    Pen pen4 = new Pen(Color.Red);
                    graphix.DrawLine(pen3, -250, -350, x2 + 50, y2);
                    graphix.DrawLine(pen3, -150, -350, x3 + 50, y3);
                    graphix.DrawLine(pen3, -50, -350, x4 + 50, y4);
                    x1 = -398;
                    y1 = -1;
                    graphix.FillEllipse(circles, x1, y1, 100, 100);

                    SolidBrush circle = new SolidBrush(Color.Yellow);
                    x5 = -68 - (float)(200 * (float)Math.Sin(0.285 + angle + parameter));
                    y5 = -47 + (float)(50 * (float)Math.Cos(0.285 + angle + parameter));

                    parameter -= (float)0.035;
                    graphix.FillEllipse(circle, x5, y5, 100, 100);
                    Pen pen2 = new Pen(Color.Red);
                    graphix.DrawLine(pen2, -350, -350, x1 + 50, y1);
                    graphix.DrawLine(pen2, 50, -350, x5 + 60 - (float)0.8 * step, y5);
                }
                if (step == 16)
                {

                    angle = (float)1.086;
                    step = 3;
                    parameter = 0;
                }
            }
        }
    }
}
