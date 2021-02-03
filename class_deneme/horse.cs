using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_deneme
{
    class horse
    {
        public bool IsInRace { get; set; }
        public PictureBox picture = new PictureBox();
        public Point startLoc = new Point();
        public int speed;
        public int score;
    }
}
