using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omg_neil_cicierega
{
    internal abstract class Arrow
    {
        public float x;
        public float y;

        public Arrow(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void Draw(Graphics g);
        public abstract bool HandleInput(KeyEventArgs e);


    }
}
