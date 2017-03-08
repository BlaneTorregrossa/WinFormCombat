namespace WinFormCombat
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
            this.Save_Button = new System.Windows.Forms.Button();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Give_Character_One = new System.Windows.Forms.Button();
            this.Give_Character_Two = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Character_One_Health = new System.Windows.Forms.TextBox();
            this.Character_One_Strength = new System.Windows.Forms.TextBox();
            this.Character_One_Defense = new System.Windows.Forms.TextBox();
            this.Character_One_Luck = new System.Windows.Forms.TextBox();
            this.Character_One_Speed = new System.Windows.Forms.TextBox();
            this.Character_Two_Speed = new System.Windows.Forms.TextBox();
            this.Character_Two_Luck = new System.Windows.Forms.TextBox();
            this.Character_Two_Defense = new System.Windows.Forms.TextBox();
            this.Character_Two_Strength = new System.Windows.Forms.TextBox();
            this.Character_Two_Health = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(278, 218);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 0;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Location = new System.Drawing.Point(278, 247);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(75, 23);
            this.Load_Button.TabIndex = 1;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click_1);
            // 
            // Give_Character_One
            // 
            this.Give_Character_One.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Give_Character_One.Location = new System.Drawing.Point(12, 12);
            this.Give_Character_One.Name = "Give_Character_One";
            this.Give_Character_One.Size = new System.Drawing.Size(167, 23);
            this.Give_Character_One.TabIndex = 2;
            this.Give_Character_One.Text = "Give Character 1";
            this.Give_Character_One.UseVisualStyleBackColor = true;
            this.Give_Character_One.Click += new System.EventHandler(this.Give_Character_One_Click);
            // 
            // Give_Character_Two
            // 
            this.Give_Character_Two.Location = new System.Drawing.Point(488, 12);
            this.Give_Character_Two.Name = "Give_Character_Two";
            this.Give_Character_Two.Size = new System.Drawing.Size(181, 23);
            this.Give_Character_Two.TabIndex = 3;
            this.Give_Character_Two.Text = "Give Character 2";
            this.Give_Character_Two.UseVisualStyleBackColor = true;
            this.Give_Character_Two.Click += new System.EventHandler(this.Give_Character_Two_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Character 1";
            // 
            // Character_One_Health
            // 
            this.Character_One_Health.Enabled = false;
            this.Character_One_Health.Location = new System.Drawing.Point(46, 80);
            this.Character_One_Health.Name = "Character_One_Health";
            this.Character_One_Health.Size = new System.Drawing.Size(100, 20);
            this.Character_One_Health.TabIndex = 5;
            this.Character_One_Health.TextChanged += new System.EventHandler(this.Character_One_Health_TextChanged);
            // 
            // Character_One_Strength
            // 
            this.Character_One_Strength.Enabled = false;
            this.Character_One_Strength.Location = new System.Drawing.Point(46, 172);
            this.Character_One_Strength.Name = "Character_One_Strength";
            this.Character_One_Strength.Size = new System.Drawing.Size(100, 20);
            this.Character_One_Strength.TabIndex = 6;
            this.Character_One_Strength.TextChanged += new System.EventHandler(this.Character_One_Strength_TextChanged);
            // 
            // Character_One_Defense
            // 
            this.Character_One_Defense.Enabled = false;
            this.Character_One_Defense.Location = new System.Drawing.Point(46, 121);
            this.Character_One_Defense.Name = "Character_One_Defense";
            this.Character_One_Defense.Size = new System.Drawing.Size(100, 20);
            this.Character_One_Defense.TabIndex = 7;
            this.Character_One_Defense.TextChanged += new System.EventHandler(this.Character_One_Defense_TextChanged);
            // 
            // Character_One_Luck
            // 
            this.Character_One_Luck.Enabled = false;
            this.Character_One_Luck.Location = new System.Drawing.Point(46, 221);
            this.Character_One_Luck.Name = "Character_One_Luck";
            this.Character_One_Luck.Size = new System.Drawing.Size(100, 20);
            this.Character_One_Luck.TabIndex = 8;
            this.Character_One_Luck.TextChanged += new System.EventHandler(this.Character_One_Luck_TextChanged);
            // 
            // Character_One_Speed
            // 
            this.Character_One_Speed.Enabled = false;
            this.Character_One_Speed.Location = new System.Drawing.Point(46, 273);
            this.Character_One_Speed.Name = "Character_One_Speed";
            this.Character_One_Speed.Size = new System.Drawing.Size(100, 20);
            this.Character_One_Speed.TabIndex = 9;
            this.Character_One_Speed.TextChanged += new System.EventHandler(this.Character_One_Speed_TextChanged);
            // 
            // Character_Two_Speed
            // 
            this.Character_Two_Speed.Enabled = false;
            this.Character_Two_Speed.Location = new System.Drawing.Point(517, 273);
            this.Character_Two_Speed.Name = "Character_Two_Speed";
            this.Character_Two_Speed.Size = new System.Drawing.Size(100, 20);
            this.Character_Two_Speed.TabIndex = 15;
            this.Character_Two_Speed.TextChanged += new System.EventHandler(this.Character_Two_Speed_TextChanged);
            // 
            // Character_Two_Luck
            // 
            this.Character_Two_Luck.Enabled = false;
            this.Character_Two_Luck.Location = new System.Drawing.Point(517, 221);
            this.Character_Two_Luck.Name = "Character_Two_Luck";
            this.Character_Two_Luck.Size = new System.Drawing.Size(100, 20);
            this.Character_Two_Luck.TabIndex = 14;
            this.Character_Two_Luck.TextChanged += new System.EventHandler(this.Character_Two_Luck_TextChanged);
            // 
            // Character_Two_Defense
            // 
            this.Character_Two_Defense.Enabled = false;
            this.Character_Two_Defense.Location = new System.Drawing.Point(517, 121);
            this.Character_Two_Defense.Name = "Character_Two_Defense";
            this.Character_Two_Defense.Size = new System.Drawing.Size(100, 20);
            this.Character_Two_Defense.TabIndex = 13;
            this.Character_Two_Defense.TextChanged += new System.EventHandler(this.Character_Two_Defense_TextChanged);
            // 
            // Character_Two_Strength
            // 
            this.Character_Two_Strength.Enabled = false;
            this.Character_Two_Strength.Location = new System.Drawing.Point(517, 172);
            this.Character_Two_Strength.Name = "Character_Two_Strength";
            this.Character_Two_Strength.Size = new System.Drawing.Size(100, 20);
            this.Character_Two_Strength.TabIndex = 12;
            this.Character_Two_Strength.TextChanged += new System.EventHandler(this.Character_Two_Strength_TextChanged);
            // 
            // Character_Two_Health
            // 
            this.Character_Two_Health.Enabled = false;
            this.Character_Two_Health.Location = new System.Drawing.Point(517, 80);
            this.Character_Two_Health.Name = "Character_Two_Health";
            this.Character_Two_Health.Size = new System.Drawing.Size(100, 20);
            this.Character_Two_Health.TabIndex = 11;
            this.Character_Two_Health.TextChanged += new System.EventHandler(this.Character_Two_Health_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Character 2";
            // 
            // Form1
            // 
            this.AcceptButton = this.Give_Character_One;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(748, 557);
            this.Controls.Add(this.Character_Two_Speed);
            this.Controls.Add(this.Character_Two_Luck);
            this.Controls.Add(this.Character_Two_Defense);
            this.Controls.Add(this.Character_Two_Strength);
            this.Controls.Add(this.Character_Two_Health);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Character_One_Speed);
            this.Controls.Add(this.Character_One_Luck);
            this.Controls.Add(this.Character_One_Defense);
            this.Controls.Add(this.Character_One_Strength);
            this.Controls.Add(this.Character_One_Health);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Give_Character_Two);
            this.Controls.Add(this.Give_Character_One);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Save_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.Button Give_Character_One;
        private System.Windows.Forms.Button Give_Character_Two;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Character_One_Health;
        private System.Windows.Forms.TextBox Character_One_Strength;
        private System.Windows.Forms.TextBox Character_One_Defense;
        private System.Windows.Forms.TextBox Character_One_Luck;
        private System.Windows.Forms.TextBox Character_One_Speed;
        private System.Windows.Forms.TextBox Character_Two_Speed;
        private System.Windows.Forms.TextBox Character_Two_Luck;
        private System.Windows.Forms.TextBox Character_Two_Defense;
        private System.Windows.Forms.TextBox Character_Two_Strength;
        private System.Windows.Forms.TextBox Character_Two_Health;
        private System.Windows.Forms.Label label2;
    }
}

