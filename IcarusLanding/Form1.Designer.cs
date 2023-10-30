namespace IcarusLanding
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
            Navigation = new GroupBox();
            DescriptionBox = new TextBox();
            buttonNorth = new Button();
            buttonEast = new Button();
            buttonSouth = new Button();
            buttonWest = new Button();
            Navigation.SuspendLayout();
            SuspendLayout();
            // 
            // Navigation
            // 
            Navigation.Controls.Add(buttonWest);
            Navigation.Controls.Add(buttonSouth);
            Navigation.Controls.Add(buttonEast);
            Navigation.Controls.Add(buttonNorth);
            Navigation.Controls.Add(DescriptionBox);
            Navigation.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Navigation.Location = new Point(60, 658);
            Navigation.Name = "Navigation";
            Navigation.Size = new Size(647, 345);
            Navigation.TabIndex = 0;
            Navigation.TabStop = false;
            Navigation.Text = "Navigation";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionBox.Location = new Point(16, 36);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(612, 142);
            DescriptionBox.TabIndex = 0;
            DescriptionBox.Text = "Description of the current location";
            // 
            // buttonNorth
            // 
            buttonNorth.BackColor = Color.YellowGreen;
            buttonNorth.Location = new Point(265, 184);
            buttonNorth.Name = "buttonNorth";
            buttonNorth.Size = new Size(115, 45);
            buttonNorth.TabIndex = 1;
            buttonNorth.Text = "North";
            buttonNorth.UseVisualStyleBackColor = false;
            buttonNorth.Click += buttonNorth_Click;
            // 
            // buttonEast
            // 
            buttonEast.BackColor = Color.YellowGreen;
            buttonEast.Location = new Point(513, 245);
            buttonEast.Name = "buttonEast";
            buttonEast.Size = new Size(115, 45);
            buttonEast.TabIndex = 2;
            buttonEast.Text = "East";
            buttonEast.UseVisualStyleBackColor = false;
            buttonEast.Click += buttonEast_Click;
            // 
            // buttonSouth
            // 
            buttonSouth.BackColor = Color.YellowGreen;
            buttonSouth.Location = new Point(265, 294);
            buttonSouth.Name = "buttonSouth";
            buttonSouth.Size = new Size(115, 45);
            buttonSouth.TabIndex = 3;
            buttonSouth.Text = "South";
            buttonSouth.UseVisualStyleBackColor = false;
            buttonSouth.Click += buttonSouth_Click;
            // 
            // buttonWest
            // 
            buttonWest.BackColor = Color.YellowGreen;
            buttonWest.Location = new Point(16, 245);
            buttonWest.Name = "buttonWest";
            buttonWest.Size = new Size(115, 45);
            buttonWest.TabIndex = 4;
            buttonWest.Text = "West";
            buttonWest.UseVisualStyleBackColor = false;
            buttonWest.Click += buttonWest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Moon_base_image;
            ClientSize = new Size(1890, 1034);
            Controls.Add(Navigation);
            Name = "Form1";
            Text = "Form1";
            Navigation.ResumeLayout(false);
            Navigation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Navigation;
        private Button buttonWest;
        private Button buttonSouth;
        private Button buttonEast;
        private Button buttonNorth;
        private TextBox DescriptionBox;
    }
}