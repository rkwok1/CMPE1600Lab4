namespace CMPE1600Lab4
{
    partial class NewPattern
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_GroupBox_Color = new System.Windows.Forms.GroupBox();
            this.UI_RadioButton_Grey = new System.Windows.Forms.RadioButton();
            this.UI_RadioButton_Green = new System.Windows.Forms.RadioButton();
            this.UI_RadioButton_Red = new System.Windows.Forms.RadioButton();
            this.Fixed_Label_CellCount = new System.Windows.Forms.Label();
            this.UI_Label_CellCount = new System.Windows.Forms.Label();
            this.Fixed_Label_NumberOfCells = new System.Windows.Forms.Label();
            this.UI_TrackBar_NumberOfCells = new System.Windows.Forms.TrackBar();
            this.Fixed_Label_MinCells = new System.Windows.Forms.Label();
            this.Fixed_Label_MaxCells = new System.Windows.Forms.Label();
            this.UI_Button_OK = new System.Windows.Forms.Button();
            this.UI_Button_Cancel = new System.Windows.Forms.Button();
            this.UI_GroupBox_Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar_NumberOfCells)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_GroupBox_Color
            // 
            this.UI_GroupBox_Color.Controls.Add(this.UI_RadioButton_Grey);
            this.UI_GroupBox_Color.Controls.Add(this.UI_RadioButton_Green);
            this.UI_GroupBox_Color.Controls.Add(this.UI_RadioButton_Red);
            this.UI_GroupBox_Color.Location = new System.Drawing.Point(13, 28);
            this.UI_GroupBox_Color.Name = "UI_GroupBox_Color";
            this.UI_GroupBox_Color.Size = new System.Drawing.Size(129, 95);
            this.UI_GroupBox_Color.TabIndex = 0;
            this.UI_GroupBox_Color.TabStop = false;
            this.UI_GroupBox_Color.Text = "Color";
            // 
            // UI_RadioButton_Grey
            // 
            this.UI_RadioButton_Grey.AutoSize = true;
            this.UI_RadioButton_Grey.Location = new System.Drawing.Point(7, 68);
            this.UI_RadioButton_Grey.Name = "UI_RadioButton_Grey";
            this.UI_RadioButton_Grey.Size = new System.Drawing.Size(47, 17);
            this.UI_RadioButton_Grey.TabIndex = 2;
            this.UI_RadioButton_Grey.TabStop = true;
            this.UI_RadioButton_Grey.Text = "Grey";
            this.UI_RadioButton_Grey.UseVisualStyleBackColor = true;
            this.UI_RadioButton_Grey.CheckedChanged += new System.EventHandler(this.UI_RadioButton_Grey_CheckedChanged);
            // 
            // UI_RadioButton_Green
            // 
            this.UI_RadioButton_Green.AutoSize = true;
            this.UI_RadioButton_Green.Location = new System.Drawing.Point(7, 44);
            this.UI_RadioButton_Green.Name = "UI_RadioButton_Green";
            this.UI_RadioButton_Green.Size = new System.Drawing.Size(54, 17);
            this.UI_RadioButton_Green.TabIndex = 1;
            this.UI_RadioButton_Green.TabStop = true;
            this.UI_RadioButton_Green.Text = "Green";
            this.UI_RadioButton_Green.UseVisualStyleBackColor = true;
            this.UI_RadioButton_Green.CheckedChanged += new System.EventHandler(this.UI_RadioButton_Green_CheckedChanged);
            // 
            // UI_RadioButton_Red
            // 
            this.UI_RadioButton_Red.AutoSize = true;
            this.UI_RadioButton_Red.Location = new System.Drawing.Point(7, 20);
            this.UI_RadioButton_Red.Name = "UI_RadioButton_Red";
            this.UI_RadioButton_Red.Size = new System.Drawing.Size(45, 17);
            this.UI_RadioButton_Red.TabIndex = 0;
            this.UI_RadioButton_Red.TabStop = true;
            this.UI_RadioButton_Red.Text = "Red";
            this.UI_RadioButton_Red.UseVisualStyleBackColor = true;
            this.UI_RadioButton_Red.CheckedChanged += new System.EventHandler(this.UI_RadioButton_Red_CheckedChanged);
            // 
            // Fixed_Label_CellCount
            // 
            this.Fixed_Label_CellCount.AutoSize = true;
            this.Fixed_Label_CellCount.Location = new System.Drawing.Point(164, 76);
            this.Fixed_Label_CellCount.Name = "Fixed_Label_CellCount";
            this.Fixed_Label_CellCount.Size = new System.Drawing.Size(58, 13);
            this.Fixed_Label_CellCount.TabIndex = 1;
            this.Fixed_Label_CellCount.Text = "Cell Count:";
            // 
            // UI_Label_CellCount
            // 
            this.UI_Label_CellCount.AutoSize = true;
            this.UI_Label_CellCount.Location = new System.Drawing.Point(228, 76);
            this.UI_Label_CellCount.Name = "UI_Label_CellCount";
            this.UI_Label_CellCount.Size = new System.Drawing.Size(13, 13);
            this.UI_Label_CellCount.TabIndex = 2;
            this.UI_Label_CellCount.Text = "0";
            // 
            // Fixed_Label_NumberOfCells
            // 
            this.Fixed_Label_NumberOfCells.AutoSize = true;
            this.Fixed_Label_NumberOfCells.Location = new System.Drawing.Point(130, 139);
            this.Fixed_Label_NumberOfCells.Name = "Fixed_Label_NumberOfCells";
            this.Fixed_Label_NumberOfCells.Size = new System.Drawing.Size(81, 13);
            this.Fixed_Label_NumberOfCells.TabIndex = 3;
            this.Fixed_Label_NumberOfCells.Text = "Number of Cells";
            // 
            // UI_TrackBar_NumberOfCells
            // 
            this.UI_TrackBar_NumberOfCells.Location = new System.Drawing.Point(12, 155);
            this.UI_TrackBar_NumberOfCells.Maximum = 2000;
            this.UI_TrackBar_NumberOfCells.Minimum = 100;
            this.UI_TrackBar_NumberOfCells.Name = "UI_TrackBar_NumberOfCells";
            this.UI_TrackBar_NumberOfCells.Size = new System.Drawing.Size(330, 45);
            this.UI_TrackBar_NumberOfCells.TabIndex = 4;
            this.UI_TrackBar_NumberOfCells.TickFrequency = 100;
            this.UI_TrackBar_NumberOfCells.Value = 100;
            this.UI_TrackBar_NumberOfCells.Scroll += new System.EventHandler(this.UI_TrackBar_NumberOfCells_Scroll);
            // 
            // Fixed_Label_MinCells
            // 
            this.Fixed_Label_MinCells.AutoSize = true;
            this.Fixed_Label_MinCells.Location = new System.Drawing.Point(12, 187);
            this.Fixed_Label_MinCells.Name = "Fixed_Label_MinCells";
            this.Fixed_Label_MinCells.Size = new System.Drawing.Size(25, 13);
            this.Fixed_Label_MinCells.TabIndex = 5;
            this.Fixed_Label_MinCells.Text = "100";
            // 
            // Fixed_Label_MaxCells
            // 
            this.Fixed_Label_MaxCells.AutoSize = true;
            this.Fixed_Label_MaxCells.Location = new System.Drawing.Point(312, 187);
            this.Fixed_Label_MaxCells.Name = "Fixed_Label_MaxCells";
            this.Fixed_Label_MaxCells.Size = new System.Drawing.Size(31, 13);
            this.Fixed_Label_MaxCells.TabIndex = 6;
            this.Fixed_Label_MaxCells.Text = "2000";
            // 
            // UI_Button_OK
            // 
            this.UI_Button_OK.Location = new System.Drawing.Point(67, 228);
            this.UI_Button_OK.Name = "UI_Button_OK";
            this.UI_Button_OK.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_OK.TabIndex = 7;
            this.UI_Button_OK.Text = "OK";
            this.UI_Button_OK.UseVisualStyleBackColor = true;
            this.UI_Button_OK.Click += new System.EventHandler(this.UI_Button_OK_Click);
            // 
            // UI_Button_Cancel
            // 
            this.UI_Button_Cancel.Location = new System.Drawing.Point(200, 228);
            this.UI_Button_Cancel.Name = "UI_Button_Cancel";
            this.UI_Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_Cancel.TabIndex = 8;
            this.UI_Button_Cancel.Text = "Cancel";
            this.UI_Button_Cancel.UseVisualStyleBackColor = true;
            this.UI_Button_Cancel.Click += new System.EventHandler(this.UI_Button_Cancel_Click);
            // 
            // NewPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 280);
            this.ControlBox = false;
            this.Controls.Add(this.UI_Button_Cancel);
            this.Controls.Add(this.UI_Button_OK);
            this.Controls.Add(this.Fixed_Label_MaxCells);
            this.Controls.Add(this.Fixed_Label_MinCells);
            this.Controls.Add(this.UI_TrackBar_NumberOfCells);
            this.Controls.Add(this.Fixed_Label_NumberOfCells);
            this.Controls.Add(this.UI_Label_CellCount);
            this.Controls.Add(this.Fixed_Label_CellCount);
            this.Controls.Add(this.UI_GroupBox_Color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPattern";
            this.Text = "NewPattern";
            this.UI_GroupBox_Color.ResumeLayout(false);
            this.UI_GroupBox_Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar_NumberOfCells)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_GroupBox_Color;
        private System.Windows.Forms.RadioButton UI_RadioButton_Grey;
        private System.Windows.Forms.RadioButton UI_RadioButton_Green;
        private System.Windows.Forms.RadioButton UI_RadioButton_Red;
        private System.Windows.Forms.Label Fixed_Label_CellCount;
        private System.Windows.Forms.Label UI_Label_CellCount;
        private System.Windows.Forms.Label Fixed_Label_NumberOfCells;
        private System.Windows.Forms.TrackBar UI_TrackBar_NumberOfCells;
        private System.Windows.Forms.Label Fixed_Label_MinCells;
        private System.Windows.Forms.Label Fixed_Label_MaxCells;
        private System.Windows.Forms.Button UI_Button_OK;
        private System.Windows.Forms.Button UI_Button_Cancel;
    }
}