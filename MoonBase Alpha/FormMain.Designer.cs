namespace MoonBase_Alpha
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            Navigation = new GroupBox();
            buttonSouth = new Button();
            buttonEast = new Button();
            buttonWest = new Button();
            buttonNorth = new Button();
            Label_1 = new Label();
            textBox1 = new TextBox();
            BaseInformation = new GroupBox();
            HomeButton = new Button();
            Navigation.SuspendLayout();
            BaseInformation.SuspendLayout();
            SuspendLayout();
            // 
            // Navigation
            // 
            Navigation.Controls.Add(HomeButton);
            Navigation.Controls.Add(buttonSouth);
            Navigation.Controls.Add(buttonEast);
            Navigation.Controls.Add(buttonWest);
            Navigation.Controls.Add(buttonNorth);
            Navigation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Navigation.Location = new Point(12, 899);
            Navigation.Name = "Navigation";
            Navigation.Size = new Size(398, 130);
            Navigation.TabIndex = 1;
            Navigation.TabStop = false;
            Navigation.Text = "Personal Nav Device";
            // 
            // buttonSouth
            // 
            buttonSouth.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSouth.Location = new Point(172, 94);
            buttonSouth.Name = "buttonSouth";
            buttonSouth.Size = new Size(75, 23);
            buttonSouth.TabIndex = 3;
            buttonSouth.Text = "South";
            buttonSouth.UseVisualStyleBackColor = true;
            buttonSouth.Click += buttonSouth_Click;
            // 
            // buttonEast
            // 
            buttonEast.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEast.Location = new Point(294, 61);
            buttonEast.Name = "buttonEast";
            buttonEast.Size = new Size(75, 23);
            buttonEast.TabIndex = 2;
            buttonEast.Text = "East";
            buttonEast.UseVisualStyleBackColor = true;
            buttonEast.Click += buttonEast_Click;
            // 
            // buttonWest
            // 
            buttonWest.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWest.Location = new Point(31, 61);
            buttonWest.Name = "buttonWest";
            buttonWest.Size = new Size(80, 23);
            buttonWest.TabIndex = 1;
            buttonWest.Text = "West";
            buttonWest.UseVisualStyleBackColor = true;
            buttonWest.Click += buttonWest_Click;
            // 
            // buttonNorth
            // 
            buttonNorth.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNorth.Location = new Point(172, 28);
            buttonNorth.Name = "buttonNorth";
            buttonNorth.Size = new Size(75, 23);
            buttonNorth.TabIndex = 0;
            buttonNorth.Text = "North";
            buttonNorth.UseVisualStyleBackColor = true;
            buttonNorth.Click += buttonNorth_Click;
            // 
            // Label_1
            // 
            Label_1.AutoSize = true;
            Label_1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label_1.Location = new Point(16, 25);
            Label_1.Name = "Label_1";
            Label_1.Size = new Size(76, 21);
            Label_1.TabIndex = 0;
            Label_1.Text = "Overview";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(16, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(420, 140);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // BaseInformation
            // 
            BaseInformation.BackColor = SystemColors.Control;
            BaseInformation.Controls.Add(textBox1);
            BaseInformation.Controls.Add(Label_1);
            BaseInformation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BaseInformation.Location = new Point(12, 12);
            BaseInformation.Name = "BaseInformation";
            BaseInformation.Size = new Size(450, 210);
            BaseInformation.TabIndex = 0;
            BaseInformation.TabStop = false;
            BaseInformation.Text = "Icarus Landing Moon Base";
            // 
            // HomeButton
            // 
            HomeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            HomeButton.Location = new Point(172, 61);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(75, 23);
            HomeButton.TabIndex = 4;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Moon_base_image;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Navigation);
            Controls.Add(BaseInformation);
            Name = "FormMain";
            Text = "Icarus Landing";
            Navigation.ResumeLayout(false);
            BaseInformation.ResumeLayout(false);
            BaseInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox Navigation;
        private Button buttonSouth;
        private Button buttonEast;
        private Button buttonWest;
        private Button buttonNorth;
        private Label Label_1;
        private TextBox textBox1;
        private GroupBox BaseInformation;
        private Button HomeButton;
    }
}