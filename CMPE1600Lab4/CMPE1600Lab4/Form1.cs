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
        
        public UI_MainForm()
        {
            InitializeComponent();

            //Scales GDI Drawer Window
            drawSpace.Scale = 10;
        }

        ///////////////////////////////Methods\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        /************************************************************************************************
         * Method: ClearArray()
         * Effect: Erases all data within passed array
         * **********************************************************************************************/
         public static void ClearArray(byte [,] array1, byte[,] array2)
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
    }
}
