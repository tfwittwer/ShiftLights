namespace ShiftLights
{
    partial class Form1
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
            this.rpmLbl = new System.Windows.Forms.Label();
            this.gearLbl = new System.Windows.Forms.Label();
            this.shiftLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rpmLbl
            // 
            this.rpmLbl.AutoSize = true;
            this.rpmLbl.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmLbl.Location = new System.Drawing.Point(143, 54);
            this.rpmLbl.Name = "rpmLbl";
            this.rpmLbl.Size = new System.Drawing.Size(167, 50);
            this.rpmLbl.TabIndex = 0;
            this.rpmLbl.Text = "10000";
            this.rpmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gearLbl
            // 
            this.gearLbl.AutoSize = true;
            this.gearLbl.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gearLbl.Location = new System.Drawing.Point(24, 54);
            this.gearLbl.Name = "gearLbl";
            this.gearLbl.Size = new System.Drawing.Size(51, 50);
            this.gearLbl.TabIndex = 2;
            this.gearLbl.Text = "5";
            this.gearLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shiftLbl
            // 
            this.shiftLbl.Location = new System.Drawing.Point(30, 9);
            this.shiftLbl.Name = "shiftLbl";
            this.shiftLbl.Size = new System.Drawing.Size(280, 35);
            this.shiftLbl.TabIndex = 3;
            this.shiftLbl.Text = "Shift";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 120);
            this.Controls.Add(this.shiftLbl);
            this.Controls.Add(this.gearLbl);
            this.Controls.Add(this.rpmLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ShiftLights";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rpmLbl;
        private System.Windows.Forms.Label gearLbl;
        private System.Windows.Forms.Label shiftLbl;
    }
}

