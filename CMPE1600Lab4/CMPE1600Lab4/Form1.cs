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
        //Delegate declaration
        Speed dlg = null;
        //Global Variables
        Random rnd = new Random();
        CDrawer drawSpace = new CDrawer();
        bool[,] foregroundArray = new bool[80, 60];
        bool[,] backgroundArray = new bool[80, 60];
        Color patternColor = Color.Red;
        int cellCount = 1000;
        int cycleSpeed = 0;
        int cycleCounter = 0;

        public UI_MainForm()
        {
            InitializeComponent();

            //Scales GDI Drawer Window
            drawSpace.Scale = 10;
            DisplayArray();
        }

        //When pressing the start button, timer is enabled
        private void UI_Button_Start_Click(object sender, EventArgs e)
        {
            //Disables and enables specific buttons applicable at the time of press
            UI_Timer.Enabled = true;
            UI_Button_Start.Enabled = false;
            UI_Button_Stop.Enabled = true;
            UI_Button_NewPattern.Enabled = false;
            UI_Button_Cycle.Enabled = false;

            //Delegate declaration for speed modeless dialog
            if (UI_Button_Start.Enabled == false)
            {
                if (null == dlg)
                {
                    dlg = new Speed();
                    dlg._dValueChanged = new delIntInt(CallbackValueChanged);
                    dlg._dFormClosing = new delVoidVoid(CallbackDialogClosing);
                }
                dlg.Show();

            }
            else
            {
                dlg.Hide();
            }
          

        }
        //When stop button is clicked
        private void UI_Button_Stop_Click(object sender, EventArgs e)
        {
            //Disables and enables specific buttons applicable at the time of press
            UI_Timer.Enabled = false;
            UI_Button_Start.Enabled = true;
            UI_Button_Stop.Enabled = false;
            UI_Button_NewPattern.Enabled = true;
            UI_Button_Cycle.Enabled = true;
        }
        //When the new pattern button is clicked
        private void UI_Button_NewPattern_Click(object sender, EventArgs e)
        {
            NewPattern newPatternDialog = new NewPattern();

            if (DialogResult.OK == newPatternDialog.ShowDialog())
            {
                patternColor = newPatternDialog.pColor; //pulls chosen color from modal dialog
                cellCount = newPatternDialog.pCellCount; // pulls cell count from modal dialog
            }
            //Resets cycle counter with the new pattern
            cycleCounter = 0;
            UI_Label_CycleCount.Text = "0";
            //Display New Foreground
            DisplayArray();

        }
        //If the cycle button is pressed
        private void UI_Button_Cycle_Click(object sender, EventArgs e)
        {
            cycleCounter++;
            UI_Label_CycleCount.Text = cycleCounter.ToString();
        }


        ///////////////////////////////Methods\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        /************************************************************************************************
         * Method: ClearArray()
         * Effect: Erases all data within passed array
         * **********************************************************************************************/
        public static void ClearArrays(bool[,] array1, bool[,] array2)
        {
            Array.Clear(array1, 0, array1.Length);
            Array.Clear(array2, 0, array2.Length);
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
        public void DisplayArray()
        {
            
            int xCoor;
            int yCoor;
            int counter = 0;
            //Clears GDI Drawing window
            drawSpace.BBColour = Color.Black;
            //Clear array for a new pattern
            ClearArrays(foregroundArray, backgroundArray);


            
            //Draws Initial Setup without a pattern
            do
            {
                //Get Length used to get dimension, 0 is for x dimensions, 1 for y dimensions
                xCoor = rnd.Next(0, foregroundArray.GetLength(0)); 
                yCoor = rnd.Next(0, foregroundArray.GetLength(1));
                if (foregroundArray[xCoor, yCoor] == false) //If spot in array is not already taken
                {
                    foregroundArray[xCoor, yCoor] = true; // Take spot 
                    counter++;
                }
            } while (counter < cellCount);

            for (int x = 0; x < foregroundArray.GetLength(0); x++)
            {
                for (int y = 0; y < foregroundArray.GetLength(1); y++)
                {
                    if(foregroundArray[x,y] == true)
                    {
                        drawSpace.SetBBScaledPixel(x, y, patternColor); // Draw in all spots that have been labelled true
                    }
                }
            }

        }

        /************************************************************************************************
         * Method: CallbackValueChanged(int i)
         * Effect: Callback method to obtain scrollbar value for speed from modeless dialog
         * **********************************************************************************************/
        public void CallbackValueChanged(int i)
        {
            cycleSpeed = i;
        }

        /************************************************************************************************
         * Method: CallbackDialogClosing()
         * Effect: Callback method for when the form is closing
         * **********************************************************************************************/
         public void CallbackDialogClosing()
        {
            //Hides Application but callback method does nothing
        }

       
    }
}

