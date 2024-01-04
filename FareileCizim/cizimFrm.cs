using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareileCizim
{
    public partial class cizimFrm : Form
    {
        int x1,y1, x2, y2,t=0;
        Graphics g;
        Pen p = new Pen(Color.Red, 3);
        public cizimFrm()
        {
            InitializeComponent();
            g=this.CreateGraphics();
        }

        private void cizimFrm_MouseClick(object sender, MouseEventArgs e)
        {
            if(t==0)
            {
                x1 = e.X;
                y1 = e.Y;
                t = 1;
            }
            else
            {
                x2=e.X;
                y2=e.Y;
                t = 0;
                g.DrawLine(p, x1, y1, x2, y2);
            }           
        }
    }
}
