using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
using System.IO;

namespace CMPE1600Lab4
{
    public partial class UI_MainForm : Form
    {
        //Global Variables
        CDrawer drawSpace = new CDrawer();
        byte[,] foregroundArray = new byte[80, 60];
        byte[,] backgroundArray = new byte[80, 60];
        Color patternColor = Color.Red;
        int cellCount = 0;

        public UI_MainForm()
        {
            InitializeComponent();

            //Scales GDI Drawer Window
            drawSpace.Scale = 10;
        }

        //When pressing the start button, timer is enabled
            private void UI_Button_Start_Click(object sender, EventArgs e)
        {
            UI_Timer.Enabled = true;            //Timer is enabled
            UI_Button_Start.Enabled = false;    //Start button is disabled
            UI_Button_Stop.Enabled = true;      //Stop button is enabled
            
            //Delegate declaration for speed modeless dialog

        }
        //When stop button is clicked
        private void UI_Button_Stop_Click(object sender, EventArgs e)
        {
            UI_Timer.Enabled = false;         //Timer is disabled
            UI_Button_Start.Enabled = true;   //Start Button is re-enabled
            UI_Button_Stop.Enabled = false;   //Stop button is disabled
        }
        //When the new pattern button is clicked
        private void UI_Button_NewPattern_Click(object sender, EventArgs e)
        {
            NewPattern newPatternDialog = new NewPattern();

            if (DialogResult.OK == newPatternDialog.ShowDialog())
            {
                patternColor = newPatternDialog.pColor;
                cellCount = newPatternDialog.pCellCount;
            }

            
        }


        ///////////////////////////////Methods\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        /************************************************************************************************
         * Method: ClearArray()
         * Effect: Erases all data within passed array
         * **********************************************************************************************/
        public static void ClearArrays(byte[,] array1, byte[,] array2)
        {

        }

       





        /************************************************************************************************
        * Method: LifeCycle()
        * Effect: Is passed two multi-dimensional arrays, one for foreground and one for background.
        *         The foreground will be responsible for outputting to the GDI drawer window, while the
        *         background will be responsible for developing the next cycle.
        ************************************************************************************************/



        /************************************************************************************************
         * Method: DisplayArray()
         * Effect: First, clears the drawing window, then displays the cells found in the 2D byte array.
         *         Draws a color for live, and draws black for dead cells.
         ************************************************************************************************/
    } }

