using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinalProject
{

    public partial class Form1 : Form
    {

        Stack st = new Stack();
        public Form1()
        {

            InitializeComponent();

        }
        private bool button1Clicked = false;
        private bool button11Clicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            Graphics m = this.CreateGraphics();
            m.DrawEllipse(Pens.Black, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            
        }       


        private void button2_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillEllipse(Brushes.Blue, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                
                Graphics g = this.CreateGraphics();
                g.FillRectangle(Brushes.Blue, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.Blue, pts);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1Clicked==true)
            {
                Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Red, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillRectangle(Brushes.Red, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.Red, pts);
            }
            
        }

private void button4_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Green, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                Graphics g = this.CreateGraphics();
              g.FillRectangle(Brushes.Green, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.Green, pts);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillEllipse(Brushes.Yellow, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillRectangle(Brushes.Yellow, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.Yellow, pts);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillEllipse(Brushes.Silver, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillRectangle(Brushes.Silver, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.Silver, pts);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillEllipse(Brushes.Orange, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillRectangle(Brushes.Orange, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.Orange, pts);
            }
        }
            private void button5_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Purple, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillRectangle(Brushes.Purple, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.Purple, pts);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Pink, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                Graphics g = this.CreateGraphics();
        g.FillRectangle(Brushes.Pink, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.Pink, pts);
            }
        }

      private void button14_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.MediumSpringGreen, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillRectangle(Brushes.MediumSpringGreen, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.MediumSpringGreen, pts);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                    Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Black, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillRectangle(Brushes.Black, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.Black, pts);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11Clicked = true;
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(Pens.Black, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.Invalidate();
            label3.Text = "";
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            

           Button L1 = new Button();

           L1.Width = 24;
           L1.Height = 23;
           L1.Location = new Point(706, 256);
           L1.FlatStyle = FlatStyle.Flat;
           L1.BackColor = Color.Brown; 

           L1.Click += L1_Click;

            this.Controls.Add(L1);
        }
        private void L1_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillEllipse(Brushes.Brown, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 291, 241);
            }
            else if (button11Clicked == true)
            {
                Graphics g = this.CreateGraphics();
                g.FillRectangle(Brushes.Brown, int.Parse(textBox2.Text), int.Parse(textBox3.Text), 250, 250);
            }
            else
            {
                Graphics tr = this.CreateGraphics();
                Point[] pts = new Point[3];
                pts[0] = new Point(630, 310);
                pts[1] = new Point(430, 90);
                pts[2] = new Point(230, 310);
                tr.FillPolygon(Brushes.Brown, pts);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Graphics tr = this.CreateGraphics();
            Point[] pts = new Point[3];
            pts[0] = new Point(630, 310);
            pts[1] = new Point(430, 90);
            pts[2] = new Point(230, 310);
            tr.DrawPolygon(Pens.Black, pts);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            Graphics g = this.CreateGraphics();
            g.DrawString(textBox1.Text, new Font("Times", 20), Brushes.Blue, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button17_Click(object sender, EventArgs e)
        {           
         string letters = textBox1.Text;
        foreach (char word in letters)
         st.Push(word);
         foreach (char word in letters)
         label3.Text += st.Pop().ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
