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
    //Define delegate type
    public delegate void delIntInt(int value);  //Delegate for trackbar value
    public delegate void delVoidVoid();         //Delegate for hide function
    public partial class Speed : Form
    {
        int scrollValue = 0;
        //Delegate Reference that will contain the callback
        public delIntInt _dValueChanged = null;
        public delVoidVoid _dFormClosing = null;
        public Speed()
        {
            InitializeComponent();
        }
        //When Scroll Bar is adjusted
        private void UI_TrackBar_Speed_Scroll(object sender, EventArgs e)
        {
            //delegate function for value adjustment on track bar
            if(null != _dValueChanged)
            {   scrollValue = UI_TrackBar_Speed.Value;
                _dValueChanged.Invoke(scrollValue);

            }
        }

        private void Speed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //Check to ensure that the delegate reference was initalized
                if (null != _dFormClosing)
                {
                    //Invoke delegate
                    _dFormClosing();
                }
                e.Cancel = true;
                Hide();
            }
        }
    }
}
