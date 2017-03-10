namespace CMPE1600Lab4
{
    partial class UI_MainForm
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
            this.UI_Button_NewPattern = new System.Windows.Forms.Button();
            this.UI_Button_Start = new System.Windows.Forms.Button();
            this.UI_Button_Stop = new System.Windows.Forms.Button();
            this.UI_Button_Cycle = new System.Windows.Forms.Button();
            this.Fixed_Label_Cycle = new System.Windows.Forms.Label();
            this.UI_Label_CycleCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Button_NewPattern
            // 
            this.UI_Button_NewPattern.Location = new System.Drawing.Point(103, 62);
            this.UI_Button_NewPattern.Name = "UI_Button_NewPattern";
            this.UI_Button_NewPattern.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_NewPattern.TabIndex = 0;
            this.UI_Button_NewPattern.Text = "New Pattern";
            this.UI_Button_NewPattern.UseVisualStyleBackColor = true;
            // 
            // UI_Button_Start
            // 
            this.UI_Button_Start.Location = new System.Drawing.Point(13, 209);
            this.UI_Button_Start.Name = "UI_Button_Start";
            this.UI_Button_Start.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_Start.TabIndex = 1;
            this.UI_Button_Start.Text = "Start";
            this.UI_Button_Start.UseVisualStyleBackColor = true;
            // 
            // UI_Button_Stop
            // 
            this.UI_Button_Stop.Enabled = false;
            this.UI_Button_Stop.Location = new System.Drawing.Point(103, 209);
            this.UI_Button_Stop.Name = "UI_Button_Stop";
            this.UI_Button_Stop.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_Stop.TabIndex = 2;
            this.UI_Button_Stop.Text = "Stop";
            this.UI_Button_Stop.UseVisualStyleBackColor = true;
            // 
            // UI_Button_Cycle
            // 
            this.UI_Button_Cycle.Location = new System.Drawing.Point(197, 209);
            this.UI_Button_Cycle.Name = "UI_Button_Cycle";
            this.UI_Button_Cycle.Size = new System.Drawing.Size(75, 23);
            this.UI_Button_Cycle.TabIndex = 3;
            this.UI_Button_Cycle.Text = "Cycle";
            this.UI_Button_Cycle.UseVisualStyleBackColor = true;
            // 
            // Fixed_Label_Cycle
            // 
            this.Fixed_Label_Cycle.AutoSize = true;
            this.Fixed_Label_Cycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fixed_Label_Cycle.Location = new System.Drawing.Point(40, 124);
            this.Fixed_Label_Cycle.Name = "Fixed_Label_Cycle";
            this.Fixed_Label_Cycle.Size = new System.Drawing.Size(85, 29);
            this.Fixed_Label_Cycle.TabIndex = 4;
            this.Fixed_Label_Cycle.Text = "Cycle:";
            // 
            // UI_Label_CycleCount
            // 
            this.UI_Label_CycleCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_Label_CycleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Label_CycleCount.Location = new System.Drawing.Point(121, 124);
            this.UI_Label_CycleCount.Name = "UI_Label_CycleCount";
            this.UI_Label_CycleCount.Size = new System.Drawing.Size(103, 29);
            this.UI_Label_CycleCount.TabIndex = 5;
            this.UI_Label_CycleCount.Text = "0";
            // 
            // UI_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UI_Label_CycleCount);
            this.Controls.Add(this.Fixed_Label_Cycle);
            this.Controls.Add(this.UI_Button_Cycle);
            this.Controls.Add(this.UI_Button_Stop);
            this.Controls.Add(this.UI_Button_Start);
            this.Controls.Add(this.UI_Button_NewPattern);
            this.Name = "UI_MainForm";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Button_NewPattern;
        private System.Windows.Forms.Button UI_Button_Start;
        private System.Windows.Forms.Button UI_Button_Stop;
        private System.Windows.Forms.Button UI_Button_Cycle;
        private System.Windows.Forms.Label Fixed_Label_Cycle;
        private System.Windows.Forms.Label UI_Label_CycleCount;
    }
}

