using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramDrawer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawDiagram(Graphics g, Pen pen, int x, int y, int radius, int[] triangelsValues, int triagnelsNum)
        {
            void drawDiagram(int[] _triangelsAngels, int _triangleAmmount, int _triagnelsNum)
            {
                int startPos = 0;
                const double twicePI = Math.PI * 2.0d;
                List<PointF> points = new List<PointF>();

                for (int i = 0; i < _triagnelsNum; i++)
                {
                    points.Add(new PointF(x, y));

                    for (int j = startPos; j <= startPos + _triangelsAngels[i]; j++)
                    {
                        double t = (twicePI * j / _triangleAmmount) + Math.PI;
                        points.Add(new PointF(Convert.ToSingle(x - Math.Sin(t) * radius), Convert.ToSingle(y + Math.Cos(t) * radius)));
                    }

                    startPos += _triangelsAngels[i];
                }

                g.DrawPolygon(pen, points.ToArray());
            };

            int triangleAmmount = 0;  //Ammount of triangels for draw circle
            int totalValues = 0;
            int[] triangelsAngels = new int[triagnelsNum];

            triangelsAngels[0] = 100;

            for (int i = 0; i < triagnelsNum; i++)
            {
                totalValues += triangelsValues[i];
            }

            if (totalValues != 100)
            {
                drawDiagram(new int[1] { 100 }, 100, 1);
                return;
            }

            for (int i = 0; i < triagnelsNum; i++)
            {
                triangelsAngels[i] = (int)((float)triangelsValues[i] / (float)totalValues * 100);
            }

            for (int i = 0; i < triagnelsNum; i++)
            {
                triangleAmmount += triangelsAngels[i];
            }

            drawDiagram(triangelsAngels, triangleAmmount, triagnelsNum);
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            var panel = sender as Panel;

            using (Graphics g = e.Graphics)
            {
                Pen redPen = new Pen(Color.Red, 2);
                Pen bluePen = new Pen(Color.Blue, 2);

                DrawDiagram(g, redPen, 100, 100, 100, new int[] { (int)FirstNumber.Value, (int)SecondNumber.Value }, 2);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawPanel.Refresh();
        }

        private void FixValue(int first, int second)
        {
            if (first + second != 100)
            {
                if (first > second)
                    second = 100 - first;
                else
                    first = 100 - second;
            }
        }

        private void FirstNumber_ValueChanged(object sender, EventArgs e)
        {
            FixValue((int)FirstNumber.Value, (int)SecondNumber.Value);
            DrawPanel.Refresh();
        }

        private void SecondNumber_ValueChanged(object sender, EventArgs e)
        {
            FixValue((int)FirstNumber.Value, (int)SecondNumber.Value);
            DrawPanel.Refresh();
        }
    }
}
