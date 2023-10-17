namespace RunLabel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            myLabel = new Label();
            SuspendLayout();
            // 
            // myLabel
            // 
            myLabel.AutoSize = true;
            myLabel.BackColor = Color.DarkRed;
            myLabel.ForeColor = SystemColors.ControlLightLight;
            myLabel.Location = new Point(347, 179);
            myLabel.Name = "myLabel";
            myLabel.Padding = new Padding(20, 10, 20, 10);
            myLabel.Size = new Size(101, 35);
            myLabel.TabIndex = 0;
            myLabel.Text = "lanet label";
            myLabel.MouseMove += myLabel_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label myLabel;
    }
}