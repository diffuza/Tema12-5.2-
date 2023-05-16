using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema12_5._2_
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
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);
            Font myFont = new Font("Arial", 16, FontStyle.Bold);
            g.TranslateTransform(200, 200);
            g.RotateTransform(-45);
            g.DrawString("повернутый", myFont, Brushes.Black, 0, 0);
            g.RotateTransform(45);
            g.TranslateTransform(-200, -200);
            Pen myPen = new Pen(Color.Black, 4);
            g.DrawRectangle(myPen, 200, 200, 4, 4);

            g.TranslateTransform(150, 150);
            g.RotateTransform(45);
            g.DrawString("текст", myFont, Brushes.Black, 0, 0);


            g.RotateTransform(-45);
            g.TranslateTransform(-150, -150);
            g.DrawRectangle(myPen, 150, 150, 4, 4);

            myFont.Dispose();
        }
    }
}
