namespace BakuLondon
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
            bakuBtn = new Button();
            londonBtn = new Button();
            SuspendLayout();
            // 
            // bakuBtn
            // 
            bakuBtn.BackColor = SystemColors.Highlight;
            bakuBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bakuBtn.ForeColor = SystemColors.ControlLightLight;
            bakuBtn.Location = new Point(261, 166);
            bakuBtn.Name = "bakuBtn";
            bakuBtn.Size = new Size(123, 55);
            bakuBtn.TabIndex = 0;
            bakuBtn.Text = "Baku";
            bakuBtn.UseVisualStyleBackColor = false;
            bakuBtn.Click += bakuBtn_Click;
            // 
            // londonBtn
            // 
            londonBtn.BackColor = Color.Indigo;
            londonBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            londonBtn.ForeColor = SystemColors.ControlLightLight;
            londonBtn.Location = new Point(421, 166);
            londonBtn.Name = "londonBtn";
            londonBtn.Size = new Size(123, 55);
            londonBtn.TabIndex = 1;
            londonBtn.Text = "London";
            londonBtn.UseVisualStyleBackColor = false;
            londonBtn.Click += londonBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(londonBtn);
            Controls.Add(bakuBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bakuBtn;
        private Button londonBtn;
    }
}