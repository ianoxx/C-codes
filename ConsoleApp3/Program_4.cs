using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int xc = this.Width / 2;
            int yc = this.Height / 2;
            g.TranslateTransform(xc, yc);
            g.DrawEllipse(new Pen(Color.Brown, 0.1f), 0, 0, 0, 0);
            double x;
            float z;
            g.DrawLine(new Pen(Color.Black, 3.0f), -500, 0, 500, 0);
            g.DrawLine(new Pen(Color.Black, 3.0f), 0, -500, 0, 500);
            for (x = -5; x <= 5; x++)
            {
                float zx = (float)x;
                g.DrawLine(new Pen(Color.Black, 1.0f), zx * 100, -5, zx * 100, 5);

                float x1 = (float)x;
                g.DrawLine(new Pen(Color.Black, 1.0f), -5, -x1 * 100, 5, -x1 * 100);
            }
            double X1 = 1, X2 = 3.0, dx = (X2 - X1) / 40.0;
            for (x = X1; x <= X2; x += dx)
            {
                z = (float)(3 - Math.Log(x) * Math.Log(x) + 6 * Math.Log(x) - 5);
                float zx = (float)x;
                g.DrawEllipse(new Pen(Color.Red, 4.0f), zx * 100, -z * 100, 1.0f, 1.0f);

                Font font = new Font("Arial", 14);
                SolidBrush brush = new SolidBrush(Color.Black);
                string s2 = "y"; float x2 = 5.0F; float y2 = -350.0F;
                g.DrawString(s2, font, brush, x2, y2);
                string s3 = "x"; float x3 = 450.0F; float y3 = 0.0F;
                g.DrawString(s3, font, brush, x3, y3);
                s3 = "0"; x3 = -20.0F; y3 = 0.0F;
                g.DrawString(s3, font, brush, x3, y3);
                s3 = "1"; x3 = 90.0F; y3 = -25.0F;
                g.DrawString(s3, font, brush, x3, y3);
                s3 = "1"; x3 = -25.0F; y3 = -110.0F;
                g.DrawString(s3, font, brush, x3, y3);
                s3 = "y= 3 – (ln(x))^2 + 6 ln(x)-5 "; x3 = 150.0F; y3 = 200.0F;
                g.DrawString(s3, font, brush, x3, y3);



            }
        }
    }
}

