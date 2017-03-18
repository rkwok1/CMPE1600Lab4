using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1600Lab4
{
    public partial class Speed : Form
    {
        int scrollValue = 0;
        //Define delegate type
        delegate int delInt ()
        public Speed()
        {
            InitializeComponent();
        }
        //When Scroll Bar is adjusted
        private void UI_TrackBar_Speed_Scroll(object sender, EventArgs e)
        {
            scrollValue = UI_TrackBar_Speed.Value;
        }
    }
}
