namespace Traffic_Light_Project
{
    partial class frmMain
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
            this.ctrlTrafficLight1 = new Traffic_Light_Project.ctrlTrafficLight();
            this.ctrlTrafficLight2 = new Traffic_Light_Project.ctrlTrafficLight();
            this.ctrlTrafficLight3 = new Traffic_Light_Project.ctrlTrafficLight();
            this.SuspendLayout();
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTrafficLight1.CurrentLight = Traffic_Light_Project.ctrlTrafficLight.enLight.Red;
            this.ctrlTrafficLight1.GreenLightTime = 10;
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(55, 38);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.RedLightTime = 10;
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(72, 183);
            this.ctrlTrafficLight1.TabIndex = 3;
            this.ctrlTrafficLight1.YellowLightTime = 2;
            this.ctrlTrafficLight1.RedLightOn += new System.EventHandler<Traffic_Light_Project.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight1_RedLightOn);
            // 
            // ctrlTrafficLight2
            // 
            this.ctrlTrafficLight2.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTrafficLight2.CurrentLight = Traffic_Light_Project.ctrlTrafficLight.enLight.Green;
            this.ctrlTrafficLight2.GreenLightTime = 10;
            this.ctrlTrafficLight2.Location = new System.Drawing.Point(209, 38);
            this.ctrlTrafficLight2.Name = "ctrlTrafficLight2";
            this.ctrlTrafficLight2.RedLightTime = 10;
            this.ctrlTrafficLight2.Size = new System.Drawing.Size(72, 183);
            this.ctrlTrafficLight2.TabIndex = 4;
            this.ctrlTrafficLight2.YellowLightTime = 2;
            this.ctrlTrafficLight2.RedLightOn += new System.EventHandler<Traffic_Light_Project.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLight2_RedLightOn);
            // 
            // ctrlTrafficLight3
            // 
            this.ctrlTrafficLight3.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTrafficLight3.CurrentLight = Traffic_Light_Project.ctrlTrafficLight.enLight.Red;
            this.ctrlTrafficLight3.GreenLightTime = 10;
            this.ctrlTrafficLight3.Location = new System.Drawing.Point(363, 38);
            this.ctrlTrafficLight3.Name = "ctrlTrafficLight3";
            this.ctrlTrafficLight3.RedLightTime = 10;
            this.ctrlTrafficLight3.Size = new System.Drawing.Size(72, 183);
            this.ctrlTrafficLight3.TabIndex = 5;
            this.ctrlTrafficLight3.YellowLightTime = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(490, 258);
            this.Controls.Add(this.ctrlTrafficLight3);
            this.Controls.Add(this.ctrlTrafficLight2);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlTrafficLight ctrlTrafficLight1;
        private ctrlTrafficLight ctrlTrafficLight2;
        private ctrlTrafficLight ctrlTrafficLight3;
    }
}

