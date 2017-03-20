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
    public partial class NewPattern : Form
    {
        //Modal dialog return for cell and color
        public int pCellCount
        {
            get
            {
                return (cells);
            }
        }
        public Color pColor
        {
            get
            {
                return (chosenColor);
            }
        }
        
        //Global Variables
        int cells = 1000;
        Color chosenColor = Color.Red;
        public NewPattern()
        {
            InitializeComponent();
        }

        //When trackbar is changed, value is show on label and sent to cell variable to be returned to main code
        private void UI_TrackBar_NumberOfCells_Scroll(object sender, EventArgs e)
        {
            cells = UI_TrackBar_NumberOfCells.Value;
            UI_Label_CellCount.Text = cells.ToString();
        }
        //If user selects red
        private void UI_RadioButton_Red_CheckedChanged(object sender, EventArgs e)
        {
            if (chosenColor != Color.Red)
            {
                chosenColor = Color.Red;
            }
        }

        //If user selects green
        private void UI_RadioButton_Green_CheckedChanged(object sender, EventArgs e)
        {
            if (chosenColor != Color.Green)
            {
                chosenColor = Color.Green;
            }
        }
        //If user select grey
        private void UI_RadioButton_Grey_CheckedChanged(object sender, EventArgs e)
        {
            if (chosenColor != Color.Gray)
            {
                chosenColor = Color.Gray;
            }
        }
        //If user presses ok, close form and send values
        private void UI_Button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        //If user presses cancel, close form, does not allocate values to main form
        private void UI_Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;            
        }
    }
}
