namespace CursorDistance
{
    partial class MainForm
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
            this.TurnButton = new System.Windows.Forms.Button();
            this.MetersDistanceLabel = new System.Windows.Forms.Label();
            this.MultiplierTextBox = new System.Windows.Forms.TextBox();
            this.PixelDistanceLabel = new System.Windows.Forms.Label();
            this.MultiplierTextLabel = new System.Windows.Forms.Label();
            this.AzimuthLabel = new System.Windows.Forms.Label();
            this.OverlayButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.MiddleMouseButtonCheckbox = new System.Windows.Forms.CheckBox();
            this.RightMouseButtonCheckbox = new System.Windows.Forms.CheckBox();
            this.LeftMouseButtonCheckbox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // TurnButton
            // 
            this.TurnButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TurnButton.Location = new System.Drawing.Point(6, 300);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(390, 64);
            this.TurnButton.TabIndex = 0;
            this.TurnButton.Text = "OFF";
            this.TurnButton.UseVisualStyleBackColor = true;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // MetersDistanceLabel
            // 
            this.MetersDistanceLabel.AutoSize = true;
            this.MetersDistanceLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MetersDistanceLabel.Location = new System.Drawing.Point(20, 77);
            this.MetersDistanceLabel.Name = "MetersDistanceLabel";
            this.MetersDistanceLabel.Size = new System.Drawing.Size(54, 65);
            this.MetersDistanceLabel.TabIndex = 1;
            this.MetersDistanceLabel.Text = "0";
            // 
            // MultiplierTextBox
            // 
            this.MultiplierTextBox.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplierTextBox.Location = new System.Drawing.Point(20, 210);
            this.MultiplierTextBox.Name = "MultiplierTextBox";
            this.MultiplierTextBox.Size = new System.Drawing.Size(138, 71);
            this.MultiplierTextBox.TabIndex = 2;
            this.MultiplierTextBox.Text = "1.00";
            this.MultiplierTextBox.TextChanged += new System.EventHandler(this.MultiplierTextBox_TextChanged);
            this.MultiplierTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MuktiplierTextbox_KeyPress);
            // 
            // PixelDistanceLabel
            // 
            this.PixelDistanceLabel.AutoSize = true;
            this.PixelDistanceLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PixelDistanceLabel.Location = new System.Drawing.Point(20, 3);
            this.PixelDistanceLabel.Name = "PixelDistanceLabel";
            this.PixelDistanceLabel.Size = new System.Drawing.Size(54, 65);
            this.PixelDistanceLabel.TabIndex = 3;
            this.PixelDistanceLabel.Text = "0";
            // 
            // MultiplierTextLabel
            // 
            this.MultiplierTextLabel.AutoSize = true;
            this.MultiplierTextLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplierTextLabel.Location = new System.Drawing.Point(164, 213);
            this.MultiplierTextLabel.Name = "MultiplierTextLabel";
            this.MultiplierTextLabel.Size = new System.Drawing.Size(232, 65);
            this.MultiplierTextLabel.TabIndex = 6;
            this.MultiplierTextLabel.Text = "Multiplier";
            // 
            // AzimuthLabel
            // 
            this.AzimuthLabel.AutoSize = true;
            this.AzimuthLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AzimuthLabel.Location = new System.Drawing.Point(20, 142);
            this.AzimuthLabel.Name = "AzimuthLabel";
            this.AzimuthLabel.Size = new System.Drawing.Size(54, 65);
            this.AzimuthLabel.TabIndex = 7;
            this.AzimuthLabel.Text = "0";
            // 
            // OverlayButton
            // 
            this.OverlayButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OverlayButton.Location = new System.Drawing.Point(6, 370);
            this.OverlayButton.Name = "OverlayButton";
            this.OverlayButton.Size = new System.Drawing.Size(390, 65);
            this.OverlayButton.TabIndex = 8;
            this.OverlayButton.Text = "Overlay OFF";
            this.OverlayButton.UseVisualStyleBackColor = true;
            this.OverlayButton.Click += new System.EventHandler(this.OverlayButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 473);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PixelDistanceLabel);
            this.tabPage1.Controls.Add(this.OverlayButton);
            this.tabPage1.Controls.Add(this.MetersDistanceLabel);
            this.tabPage1.Controls.Add(this.TurnButton);
            this.tabPage1.Controls.Add(this.MultiplierTextLabel);
            this.tabPage1.Controls.Add(this.AzimuthLabel);
            this.tabPage1.Controls.Add(this.MultiplierTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.MiddleMouseButtonCheckbox);
            this.Settings.Controls.Add(this.RightMouseButtonCheckbox);
            this.Settings.Controls.Add(this.LeftMouseButtonCheckbox);
            this.Settings.Location = new System.Drawing.Point(4, 30);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(402, 439);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // MiddleMouseButtonCheckbox
            // 
            this.MiddleMouseButtonCheckbox.AutoSize = true;
            this.MiddleMouseButtonCheckbox.Checked = true;
            this.MiddleMouseButtonCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MiddleMouseButtonCheckbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiddleMouseButtonCheckbox.Location = new System.Drawing.Point(6, 82);
            this.MiddleMouseButtonCheckbox.Name = "MiddleMouseButtonCheckbox";
            this.MiddleMouseButtonCheckbox.Size = new System.Drawing.Size(139, 32);
            this.MiddleMouseButtonCheckbox.TabIndex = 2;
            this.MiddleMouseButtonCheckbox.Text = "Middle Click";
            this.MiddleMouseButtonCheckbox.UseVisualStyleBackColor = true;
            this.MiddleMouseButtonCheckbox.CheckedChanged += new System.EventHandler(this.MiddleMouseButtonCheckbox_CheckedChanged);
            // 
            // RightMouseButtonCheckbox
            // 
            this.RightMouseButtonCheckbox.AutoSize = true;
            this.RightMouseButtonCheckbox.Checked = true;
            this.RightMouseButtonCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RightMouseButtonCheckbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RightMouseButtonCheckbox.Location = new System.Drawing.Point(6, 44);
            this.RightMouseButtonCheckbox.Name = "RightMouseButtonCheckbox";
            this.RightMouseButtonCheckbox.Size = new System.Drawing.Size(124, 32);
            this.RightMouseButtonCheckbox.TabIndex = 1;
            this.RightMouseButtonCheckbox.Text = "Right Click";
            this.RightMouseButtonCheckbox.UseVisualStyleBackColor = true;
            this.RightMouseButtonCheckbox.CheckedChanged += new System.EventHandler(this.RightMouseButtonCheckbox_CheckedChanged);
            // 
            // LeftMouseButtonCheckbox
            // 
            this.LeftMouseButtonCheckbox.AutoSize = true;
            this.LeftMouseButtonCheckbox.Checked = true;
            this.LeftMouseButtonCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LeftMouseButtonCheckbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeftMouseButtonCheckbox.Location = new System.Drawing.Point(6, 6);
            this.LeftMouseButtonCheckbox.Name = "LeftMouseButtonCheckbox";
            this.LeftMouseButtonCheckbox.Size = new System.Drawing.Size(109, 32);
            this.LeftMouseButtonCheckbox.TabIndex = 0;
            this.LeftMouseButtonCheckbox.Text = "Left Click";
            this.LeftMouseButtonCheckbox.UseVisualStyleBackColor = true;
            this.LeftMouseButtonCheckbox.CheckedChanged += new System.EventHandler(this.LeftMouseButtonCheckbox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Distance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button TurnButton;
        private Label MetersDistanceLabel;
        private TextBox MultiplierTextBox;
        private Label PixelDistanceLabel;
        private Label MultiplierTextLabel;
        private Label AzimuthLabel;
        private Button OverlayButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage Settings;
        private CheckBox LeftMouseButtonCheckbox;
        private CheckBox MiddleMouseButtonCheckbox;
        private CheckBox RightMouseButtonCheckbox;
    }
}