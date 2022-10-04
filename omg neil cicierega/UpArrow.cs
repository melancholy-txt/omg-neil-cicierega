using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omg_neil_cicierega
{
    internal class UpArrow : Arrow
    {
        
        public UpArrow(float x, float y) : base(x, y)
        {
        }

        public override void Draw(Graphics g)
        {
            Image arrowImg = Image.FromFile("upArrow.png");
            Image boom = Image.FromFile("boom.png");
            g.DrawImage(arrowImg, new PointF(x,y));

        }

        public override bool HandleInput(KeyEventArgs e)
        {
            return e.KeyCode == Keys.Up || e.KeyCode == Keys.W;
        }
    }
}
