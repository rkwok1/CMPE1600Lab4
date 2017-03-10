namespace CMPE1600Lab4
{
    partial class Speed
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
            this.UI_TrackBar_Speed = new System.Windows.Forms.TrackBar();
            this.Fixed_Label_Fast = new System.Windows.Forms.Label();
            this.Fixed_Label_Slow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_TrackBar_Speed
            // 
            this.UI_TrackBar_Speed.Location = new System.Drawing.Point(12, 23);
            this.UI_TrackBar_Speed.Maximum = 2000;
            this.UI_TrackBar_Speed.Minimum = 200;
            this.UI_TrackBar_Speed.Name = "UI_TrackBar_Speed";
            this.UI_TrackBar_Speed.Size = new System.Drawing.Size(357, 45);
            this.UI_TrackBar_Speed.TabIndex = 0;
            this.UI_TrackBar_Speed.TickFrequency = 100;
            this.UI_TrackBar_Speed.Value = 200;
            // 
            // Fixed_Label_Fast
            // 
            this.Fixed_Label_Fast.AutoSize = true;
            this.Fixed_Label_Fast.Location = new System.Drawing.Point(13, 75);
            this.Fixed_Label_Fast.Name = "Fixed_Label_Fast";
            this.Fixed_Label_Fast.Size = new System.Drawing.Size(27, 13);
            this.Fixed_Label_Fast.TabIndex = 1;
            this.Fixed_Label_Fast.Text = "Fast";
            // 
            // Fixed_Label_Slow
            // 
            this.Fixed_Label_Slow.AutoSize = true;
            this.Fixed_Label_Slow.Location = new System.Drawing.Point(339, 75);
            this.Fixed_Label_Slow.Name = "Fixed_Label_Slow";
            this.Fixed_Label_Slow.Size = new System.Drawing.Size(30, 13);
            this.Fixed_Label_Slow.TabIndex = 2;
            this.Fixed_Label_Slow.Text = "Slow";
            // 
            // Speed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 97);
            this.Controls.Add(this.Fixed_Label_Slow);
            this.Controls.Add(this.Fixed_Label_Fast);
            this.Controls.Add(this.UI_TrackBar_Speed);
            this.Name = "Speed";
            this.Text = "Speed";
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar_Speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_TrackBar_Speed;
        private System.Windows.Forms.Label Fixed_Label_Fast;
        private System.Windows.Forms.Label Fixed_Label_Slow;
    }
}