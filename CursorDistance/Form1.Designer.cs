namespace CursorDistance
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(6, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "OFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(20, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 71);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1.00";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(164, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 65);
            this.label5.TabIndex = 6;
            this.label5.Text = "Multiplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 65);
            this.label6.TabIndex = 7;
            this.label6.Text = "0";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(6, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 65);
            this.button2.TabIndex = 8;
            this.button2.Text = "Overlay OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox1);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Distance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage Settings;
        private CheckBox LeftMouseButtonCheckbox;
        private CheckBox MiddleMouseButtonCheckbox;
        private CheckBox RightMouseButtonCheckbox;
    }
}