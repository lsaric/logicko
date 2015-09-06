using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleChartSharp;

namespace Aplikacija_ZUSMR
{
    public partial class ucGraph : UserControl
    {
        public int[] Data { get; set; }

        public ucGraph()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        { //base.OnPaint(e);
            Graphics g = e.Graphics;
            int offset = 2;
            // border offset

            int offset2 = 15; // axis offset 
            int offset3 = 5; // data offset x 
            int offset4 = 2; // data offset y 
            int max = 10; 
            DrawFrame(g, offset); 
            DrawAxis(g, offset, offset2); 
            DrawData(g, offset, offset2, offset3, offset4, max);

        }

        private void DrawData(Graphics g, int offset, int offset2, int offset3, int offset4,int max)
        {

            if (Data != null)
            {

                for (int i = 0; i < Data.Length; i++)
                {

                    g.DrawLine(new Pen(Brushes.Red, 3), new Point(4 * i + offset2 + offset3,
                        this.Height - offset2 - offset - offset4), new Point(i * 4 + offset2 + offset3,
                            (this.Height - offset2 - offset) - (Data[i] / max)));

                }

            }

        } //DrawData

        private void DrawAxis(Graphics g, int offset, int offset2)
        {

            g.DrawLine(new Pen(Brushes.DarkSeaGreen, 2), new Point(offset + offset2,
                this.Height - offset - offset2), new Point(offset + offset2, offset + offset2));
            g.DrawLine(new Pen(Brushes.DarkSeaGreen, 2), new Point(offset + offset2,
                this.Height - offset - offset2), new Point(this.Width - offset - offset2,
                    this.Height - offset - offset2));

        } //drawAxis

        private void DrawFrame(Graphics g, int offset)
        {

            g.DrawLine(new Pen(Brushes.Gray), new Point(offset, offset), new Point(this.Width - offset, offset));
            g.DrawLine(new Pen(Brushes.Gray), new Point(offset, this.Height - offset), new Point(this.Width - offset,this.Height - offset));
            g.DrawLine(new Pen(Brushes.Gray), new Point(offset, offset), new Point(offset, this.Height - offset));
            g.DrawLine(new Pen(Brushes.Gray), new Point(this.Width - offset, offset), new Point(this.Width - offset, this.Height - offset));
        }
        //drawFrame

    }
}
