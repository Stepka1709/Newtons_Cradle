using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportTwo
{
    public partial class Cradle : Form
    {
        private Bitmap bitmap;                                       
        private Graphics graphix;                

        SolidBrush background = new SolidBrush(Color.Blue);         
        SolidBrush circles = new SolidBrush(Color.White);         
        
        float parameter1, parameter2, parameter3, parameter4, parameter5;           
        float step;                                         
        float angle;                                         
        float x1, y1, x2, y2, x3, y3, x4, y4, x5, y5;

        public Cradle()
        {
            InitializeComponent();
        }

        private void CirclesLoading()
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphix = Graphics.FromImage(bitmap);
            graphix.FillRectangle(background, 0, 0, pictureBox.Width, pictureBox.Height);    
            graphix.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;       
            graphix.TranslateTransform((float)pictureBox.Width / 2, (float)pictureBox.Height / 2);     

            pictureBox.BackgroundImage = bitmap;       
        }

        private void Cradle_Load(object sender, EventArgs e)
        {
            timerGo.Start();
        }

        private void timerGo_Tick(object sender, EventArgs e)
        {
            CirclesLoading();                                   
            step++;                                           
            angle += (float)0.02262;                      

            if (step >= 0)
            {
                x1 = -30 + (float)(180 * (float)Math.Sin(0.20285 + angle + parameter1));       
                y1 = -30 + (float)(180 * (float)Math.Cos(0.20285 + angle + parameter1));
                x2 = -30 + (float)(180 * (float)Math.Sin(-0.05285 + angle + parameter2));
                y2 = -30 + (float)(180 * (float)Math.Cos(-0.05285 + angle + parameter2));
                x3 = -30 + (float)(180 * (float)Math.Sin(-0.31295 + angle + parameter3));
                y3 = -30 + (float)(180 * (float)Math.Cos(-0.31295 + angle + parameter3));
                x4 = -30 + (float)(180 * (float)Math.Sin(-0.55295 + angle + parameter4));
                y4 = -30 + (float)(180 * (float)Math.Cos(-0.55295 + angle + parameter4));
                x5 = -30 + (float)(180 * (float)Math.Sin(-0.80095 + angle + parameter5));
                y5 = -30 + (float)(180 * (float)Math.Cos(-0.80095 + angle + parameter5));

                graphix.FillEllipse(circles, x1, y1, 50, 50);      
                graphix.FillEllipse(circles, x2, y2, 50, 50);
                graphix.FillEllipse(circles, x3, y3, 50, 50);
                graphix.FillEllipse(circles, x4, y4, 50, 50);
                graphix.FillEllipse(circles, x5, y5, 50, 50);

                parameter1 += (float)0.16312;

                if (step > 31)
                {
                    parameter1 -= (float)0.16312;  
                    parameter2 += (float)0.16312; 
                }
                if (step > 62)
                {
                    parameter2 -= (float)0.16312; 
                    parameter3 += (float)0.16312; 
                }
                if (step > 93)
                {
                    parameter3 -= (float)0.16312;  
                    parameter4 += (float)0.16312; 
                }
                if (step > 124)
                {
                    parameter4 -= (float)0.16312;  
                    parameter5 += (float)0.16312; 
                }
                if (step > 155)
                {
                    parameter5 -= (float)0.16312; 
                    parameter1 += (float)0.16312;
                }
                if (step > 186)
                {
                    parameter1 -= (float)0.16312;
                    parameter2 += (float)0.16312;
                }
                if (step > 217)
                {
                    parameter2 -= (float)0.16312;
                    parameter3 += (float)0.16312;
                }
                if (step > 248)
                {
                    parameter3 -= (float)0.16312;
                    parameter4 += (float)0.16312;
                }
                if (step > 279)
                {
                    parameter4 -= (float)0.16312;
                    parameter5 += (float)0.16312;
                }
                if (step > 310)
                {
                    parameter5 -= (float)0.16312;
                    parameter1 += (float)0.16312;
                }
                if (step > 341)
                {
                    parameter1 -= (float)0.16312;
                    parameter2 += (float)0.16312;
                }
                if (step > 372)
                {
                    parameter2 -= (float)0.16312;
                    parameter3 += (float)0.16312;
                }
                if (step > 403)
                {
                    parameter3 -= (float)0.16312;
                }
                if (step == 420)           
                {
                    parameter1 = 0;         
                    parameter2 = 0;
                    parameter3 = 0;
                    parameter4 = 0;
                    parameter5 = 0;
                    angle = 0;
                    step = 0;
                }
            }
        }
    }
}
