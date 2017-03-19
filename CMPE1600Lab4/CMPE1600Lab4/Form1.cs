/********************************************************************************************************************************************************
 * Program:        CMPE1600Lab4.cs
 * Description:    The following program depicts and animates Conway's "Game of Life" through GDI drawer, using modal and modeless dialogs to adjust the
 *                 game settings. You can adjust the color, number of cells and speed at which the game plays.
 * Lab:            4
 * Date:           March 20, 2017
 * Author:         Ryan Kwok
 * Class:          A01
 * Instructor:     JD Silver
 * ******************************************************************************************************************************************************/
  
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
        Random rnd = new Random();                          //Random initializer
        static CDrawer drawSpace = new CDrawer();           //GDI drawing space initializer
        static bool[,] foregroundArray = new bool[80, 60];  //foreground array parameters and scale
        static bool[,] backgroundArray = new bool[80, 60];  //background array parameters and scale
        static Color patternColor = Color.Red;              //Holds the color of the selected color in modal dialog. Default is red
        int cellCount = 1000;                               //Holds the number of cells that will be produced on screen. Default is 1000
        int cycleSpeed = 200;                               //Holds speed at which the lifecycles occurs
        int cycleCounter = 0;                               //GOlds the number of cycles that have occured

        public UI_MainForm()
        {
            InitializeComponent();

            //Scales GDI Drawer Window
            drawSpace.Scale = 10;
            //Draws inital array upon boot up
            DrawInitialArray();
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
            DrawInitialArray();

        }
        //If the cycle button is pressed
        private void UI_Button_Cycle_Click(object sender, EventArgs e)
        {
            //Starts only one life cycle
            LifeCycle(foregroundArray, backgroundArray);
        }
        //While timer is enabled 
        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            UI_Timer.Interval = cycleSpeed; //Make interval equivalent to the cycle speed indicated by the modeless dialog
            LifeCycle(foregroundArray, backgroundArray); //Initiates Lifecycles while timer is enabled
        }


        /////////////////////////////////////////////////////////////////Methods\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        /************************************************************************************************
         * Method: ClearArray()
         * Effect: Erases all data within passed array
         * **********************************************************************************************/
        public static void ClearArrays()
        {
            Array.Clear(foregroundArray, 0, foregroundArray.Length);    //Clears foreground array
            Array.Clear(backgroundArray, 0, backgroundArray.Length);    //Clears background array
        }



        /************************************************************************************************
        * Method: LifeCycle()
        * Effect: Is passed two multi-dimensional arrays, one for foreground and one for background.
        *         The foreground will be responsible for outputting to the GDI drawer window, while the
        *         background will be responsible for developing the next cycle.
        ************************************************************************************************/
        public void LifeCycle(bool[,] array1, bool[,] array2)
        {
            //Variables
            int liveNeighbors = 0;

            //Examine all locations in the foreground for live tiles
            //Considers X values of 0 or 79 for, and y values of 0, 59. All other values beyond are considered dead
            for (int x = 1; x < 79; x++)
            {
                for (int y = 1; y < 59; y++)
                {

                    if (array1[x, y] == true || array1[x, y] == false)
                    {

                        //Eigth special Cases
                        //1.)live above
                        if (array1[x, y + 1] == true)
                        {
                            liveNeighbors++;
                        }
                        //2.)live below
                        if (array1[x, y - 1] == true)
                        {
                            liveNeighbors++;
                        }
                        //3.)live left
                        if (array1[x - 1, y] == true)
                        {
                            liveNeighbors++;
                        }
                        //4.)live right
                        if (array1[x + 1, y] == true)
                        {
                            liveNeighbors++;
                        }
                        //5.)live top left
                        if (array1[x - 1, y + 1] == true)
                        {
                            liveNeighbors++;
                        }
                        //6.)live top right
                        if (array1[x + 1, y + 1] == true)
                        {
                            liveNeighbors++;
                        }
                        //7.)live bottom left
                        if (array1[x - 1, y - 1] == true)
                        {
                            liveNeighbors++;
                        }
                        //8.)live bottom right
                        if (array1[x + 1, y - 1] == true)
                        {
                            liveNeighbors++;
                        }
                        //Determines how background will look based on the numbers of neighbors
                        switch (liveNeighbors)
                        {
                            case 0:
                            case 1:
                                //Cell Dies at next cycle
                                array2[x, y] = false;

                                break;
                            case 2:
                                //Cell remains alive to next cycle
                                if (array1[x, y] == true)
                                {
                                    array2[x, y] = true;
                                }
                                break;
                            case 3:
                                //cell remains alive point or becomes live if intially dead
                                //Cell with three live neighbors will go from dead to alive 
                                array2[x, y] = true;
                                break;

                                //If greater than 3 live cells nearby, overpopualtion occurs
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                                //Cell Dies
                                array2[x, y] = false;
                                break;
                        }
                        liveNeighbors = 0;

                    }
                }
            }
            //Increase ccyle count and outptus to label
            cycleCounter++;
            UI_Label_CycleCount.Text = cycleCounter.ToString();
            //Draw Next Cycle using background Method
            DrawNextCycle(backgroundArray);
            //Clears foregroundand copies contents of background back to foreground
            Array.Clear(foregroundArray, 0, foregroundArray.Length);
            foregroundArray = ((bool[,])array2.Clone());
            Array.Clear(backgroundArray, 0, backgroundArray.Length);
            //Consider exceptions for four corners

            //
        }
        /************************************************************************************************
         * Method: DrawNextCycle()
         * Effect: Draws next Cycle using background array
         * **********************************************************************************************/
        public static void DrawNextCycle(bool[,] array2)
        {
            //Initialize first by making GDI drawer black
            drawSpace.BBColour = Color.Black;
            for (int x = 0; x < 80; x++)
            {
                for (int y = 0; y < 60; y++)
                {
                    if (array2[x, y] == true)
                    {
                        drawSpace.SetBBScaledPixel(x, y, patternColor);
                    }

                }
            }


        }

        /************************************************************************************************
         * Method: DrawInitialArray()
         * Effect: First, clears the drawing window, then displays the cells found in the 2D byte array.
         *         Draws a color for live, and draws black for dead cells.
         ************************************************************************************************/
        public void DrawInitialArray()
        {
            
            int xCoor;           //Holds the x coordinates that the program iterates through
            int yCoor;           //Holds the y coordinates that the program iterates through
            int counter = 0;     //Counter to determine number of cells to initialize

            //Clears GDI Drawing window
            drawSpace.BBColour = Color.Black;
            //Clear array for a new pattern
            ClearArrays();

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
                    if (foregroundArray[x, y] == true)
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

