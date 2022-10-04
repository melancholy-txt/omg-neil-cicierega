using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omg_neil_cicierega
{
    public partial class Form1 : Form
    {
        List<Arrow> arrows = new List<Arrow>();
        int x = 10;
        int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
            //arrows.Add(new UpArrow(250, 10));
            //arrows.Add(new RightArrow(490, 250));
            //arrows.Add(new LeftArrow(10, 250));
            //arrows.Add(new DownArrow(250, 490));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var arrow in arrows)
            {
                arrow.Draw(e.Graphics);
            }       
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //panel1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    arrows.Add(new UpArrow(x, 10));
            //    x += 110;
            //    panel1.Refresh();
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    arrows.Add(new DownArrow(x, 10));
            //    x += 110;
            //    panel1.Refresh();
            //}
            //if (e.KeyCode == Keys.Left)
            //{
            //    arrows.Add(new LeftArrow(x, 10));
            //    x += 110;
            //    panel1.Refresh();
            //}
            //if (e.KeyCode == Keys.Right)
            //{
            //    arrows.Add(new RightArrow(x, 10));
            //    x += 110;
            //    panel1.Refresh();
            //}

            if (arrows[currentIndex].HandleInput(e))
            {
                if(currentIndex < arrows.Count - 1)
                    currentIndex++;
            }
        }
    }
}
