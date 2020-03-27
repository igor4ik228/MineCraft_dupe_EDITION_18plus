using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Initialized(object sender, EventArgs e)
        {
            Bitmap myBitmap = new Bitmap(500, 500);
            Graphics g = Graphics.FromImage(myBitmap);
            g.Clear(System.Drawing.Color.White);
            System.Drawing.Pen a = new System.Drawing.Pen(System.Drawing.Color.Blue, 1);
            System.Drawing.Pen b = new System.Drawing.Pen(System.Drawing.Color.Green, 2);
            Font drawFont = new Font("Arial", 12);
            Font signatureFont = new Font("Arial", 7);

            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Blue);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            int sizeWidth = (int)myBitmap.Width;
            int sizeHeight = (int)myBitmap.Height;
            System.Windows.Point center = new System.Windows.Point(((int)(sizeWidth / 2) - 8), (int)(sizeHeight / 2) - 19);

            g.DrawLine(a, 10, (int)center.Y, (int)center.X, (int)center.Y);
            g.DrawLine(a, (int)center.X, (int)center.Y, 2 * (int)center.X - 10, (int)center.Y);
            g.DrawLine(a, (int)center.X, 10, (int)center.X, (int)center.Y);
            g.DrawLine(a, (int)center.X, (int)center.Y, (int)center.X, 2 * (int)center.Y - 10);

            g.DrawString("X", drawFont, drawBrush, new PointF(2 * (int)center.X - 5, (int)center.Y + 10), drawFormat);
            g.DrawString("Y", drawFont, drawBrush, new PointF((int)center.X + 20, 5), drawFormat);
            g.DrawString("0", drawFont, drawBrush, new PointF((int)center.X + 24, (int)center.Y + 11), drawFormat);

            g.DrawLine(a, (int)center.X, 10, (int)center.X + 5, 20);
            g.DrawLine(a, (int)center.X, 10, (int)center.X - 5, 20);

            g.DrawLine(a, 2 * (int)center.X - 10, (int)center.Y, 2 * (int)center.X - 20, (int)center.Y + 5);
            g.DrawLine(a, 2 * (int)center.X - 10, (int)center.Y, 2 * (int)center.X - 20, (int)center.Y - 5);

            int stepForAxes = 25;           //dani
            int lenghtShtrih = 3;
            int maxValueForAxesX = 20;
            int maxValueForAxesY = 20;

            float oneDelenieX = (float)maxValueForAxesX / ((float)center.X / (float)stepForAxes);
            float oneDelenieY = (float)maxValueForAxesY / ((float)center.Y / (float)stepForAxes);

            for (int i = (int)center.X, j = (int)center.X, k = 1; i < 2 * center.X - 30;
                j -= stepForAxes, i += stepForAxes, k++)
            {
                g.DrawLine(a, i, (int)center.Y - lenghtShtrih, i, (int)center.Y + lenghtShtrih);
                g.DrawLine(a, j, (int)center.Y - lenghtShtrih, j, (int)center.Y + lenghtShtrih);

                if (i < 2 * center.X - 55)
                {
                    g.DrawString((k * oneDelenieX).ToString("0.0"), signatureFont, drawBrush, new PointF(i + stepForAxes + 9, (int)center.Y + 6), drawFormat);
                    g.DrawString(((k * oneDelenieX).ToString("0.0").ToString() + "-"), signatureFont, drawBrush, new PointF(j + stepForAxes + 9, (int)center.Y + 6), drawFormat);
                }
            }

            for (int i = (int)center.Y, j = (int)center.Y, k = 1; i < 2 * center.Y - 30;
                j -= stepForAxes, i += stepForAxes, k++)
            {
                g.DrawLine(a, (int)center.X - lenghtShtrih, i, (int)center.X + lenghtShtrih, i);
                g.DrawLine(a, (int)center.X - lenghtShtrih, j, (int)center.X + lenghtShtrih, j);

                if (i < 2 * center.Y - 55)
                {
                    g.DrawString(((k * oneDelenieY).ToString("0.0").ToString() + "-"), signatureFont, drawBrush, new PointF((int)center.X + 20, i + stepForAxes), drawFormat);
                    g.DrawString((k * oneDelenieY).ToString("0.0"), signatureFont, drawBrush, new PointF((int)center.X + 20, j + stepForAxes), drawFormat);
                }
            }

            int numOfPoint = 100;

            float[] first = new float[numOfPoint];

            for (int i = 0; i < numOfPoint; i++)
            {
                first[i] = (float)maxValueForAxesX / (float)numOfPoint * (i + 1) - 10; // vidstan
            }

            float[] second = new float[numOfPoint];

            for (int i = 0; i < numOfPoint; i++)
            {
                second[i] = (float)(Math.Pow(Math.Cos(10 * first[i]),2)+ first[i]);//rivnist
            }

            System.Drawing.Point[] pointOne = new System.Drawing.Point[numOfPoint];

            float tempX = 1 / oneDelenieX * stepForAxes;
            float tempY = 1 / oneDelenieY * stepForAxes;

            for (int i = 0; i < numOfPoint; i++)
            {
                pointOne[i].X = (int)center.X + (int)(first[i] * tempX);
                pointOne[i].Y = (int)center.Y + (int)(second[i] * tempY);
            }

            g.DrawLines(b, pointOne);
            g.DrawCurve(b, pointOne);
            BitmapSource bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(myBitmap.GetHbitmap(), IntPtr.Zero, System.Windows.Int32Rect.Empty, BitmapSizeOptions.FromWidthAndHeight(myBitmap.Width, myBitmap.Height));
            ImageBrush ib = new ImageBrush(bs);
            Form1.Background = ib;
            g.Dispose();
        }
}
}
