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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Attack_Character_2 = new System.Windows.Forms.Button();
            this.Attack_Character_1 = new System.Windows.Forms.Button();
            this.Defend_Character_1 = new System.Windows.Forms.Button();
            this.Defend_Character_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(316, 204);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 0;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Location = new System.Drawing.Point(316, 233);
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
            this.Give_Character_One.Text = "New Character";
            this.Give_Character_One.UseVisualStyleBackColor = true;
            this.Give_Character_One.Click += new System.EventHandler(this.Give_Character_One_Click);
            // 
            // Give_Character_Two
            // 
            this.Give_Character_Two.Location = new System.Drawing.Point(548, 12);
            this.Give_Character_Two.Name = "Give_Character_Two";
            this.Give_Character_Two.Size = new System.Drawing.Size(181, 23);
            this.Give_Character_Two.TabIndex = 3;
            this.Give_Character_Two.Text = "New Character";
            this.Give_Character_Two.UseVisualStyleBackColor = true;
            this.Give_Character_Two.Click += new System.EventHandler(this.Give_Character_Two_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Character 1";
            // 
            // Character_One_Health
            // 
            this.Character_One_Health.Enabled = false;
            this.Character_One_Health.Location = new System.Drawing.Point(51, 158);
            this.Character_One_Health.Name = "Character_One_Health";
            this.Character_One_Health.Size = new System.Drawing.Size(100, 20);
            this.Character_One_Health.TabIndex = 5;
            this.Character_One_Health.TextChanged += new System.EventHandler(this.Character_One_Health_TextChanged);
            // 
            // Character_One_Strength
            // 
            this.Character_One_Strength.Enabled = false;
            this.Character_One_Strength.Location = new System.Drawing.Point(51, 250);
            this.Character_One_Strength.Name = "Character_One_Strength";
            this.Character_One_Strength.Size = new System.Drawing.Size(100, 20);
            this.Character_One_Strength.TabIndex = 6;
            this.Character_One_Strength.TextChanged += new System.EventHandler(this.Character_One_Strength_TextChanged);
            // 
            // Character_One_Defense
            // 
            this.Character_One_Defense.Enabled = false;
            this.Character_One_Defense.Location = new System.Drawing.Point(51, 199);
            this.Character_One_Defense.Name = "Character_One_Defense";
            this.Character_One_Defense.Size = new System.Drawing.Size(100, 20);
            this.Character_One_Defense.TabIndex = 7;
            this.Character_One_Defense.TextChanged += new System.EventHandler(this.Character_One_Defense_TextChanged);
            // 
            // Character_One_Luck
            // 
            this.Character_One_Luck.Enabled = false;
            this.Character_One_Luck.Location = new System.Drawing.Point(51, 299);
            this.Character_One_Luck.Name = "Character_One_Luck";
            this.Character_One_Luck.Size = new System.Drawing.Size(100, 20);
            this.Character_One_Luck.TabIndex = 8;
            this.Character_One_Luck.TextChanged += new System.EventHandler(this.Character_One_Luck_TextChanged);
            // 
            // Character_One_Speed
            // 
            this.Character_One_Speed.Enabled = false;
            this.Character_One_Speed.Location = new System.Drawing.Point(51, 351);
            this.Character_One_Speed.Name = "Character_One_Speed";
            this.Character_One_Speed.Size = new System.Drawing.Size(100, 20);
            this.Character_One_Speed.TabIndex = 9;
            this.Character_One_Speed.TextChanged += new System.EventHandler(this.Character_One_Speed_TextChanged);
            // 
            // Character_Two_Speed
            // 
            this.Character_Two_Speed.Enabled = false;
            this.Character_Two_Speed.Location = new System.Drawing.Point(591, 351);
            this.Character_Two_Speed.Name = "Character_Two_Speed";
            this.Character_Two_Speed.Size = new System.Drawing.Size(100, 20);
            this.Character_Two_Speed.TabIndex = 15;
            this.Character_Two_Speed.TextChanged += new System.EventHandler(this.Character_Two_Speed_TextChanged);
            // 
            // Character_Two_Luck
            // 
            this.Character_Two_Luck.Enabled = false;
            this.Character_Two_Luck.Location = new System.Drawing.Point(591, 299);
            this.Character_Two_Luck.Name = "Character_Two_Luck";
            this.Character_Two_Luck.Size = new System.Drawing.Size(100, 20);
            this.Character_Two_Luck.TabIndex = 14;
            this.Character_Two_Luck.TextChanged += new System.EventHandler(this.Character_Two_Luck_TextChanged);
            // 
            // Character_Two_Defense
            // 
            this.Character_Two_Defense.Enabled = false;
            this.Character_Two_Defense.Location = new System.Drawing.Point(591, 199);
            this.Character_Two_Defense.Name = "Character_Two_Defense";
            this.Character_Two_Defense.Size = new System.Drawing.Size(100, 20);
            this.Character_Two_Defense.TabIndex = 13;
            this.Character_Two_Defense.TextChanged += new System.EventHandler(this.Character_Two_Defense_TextChanged);
            // 
            // Character_Two_Strength
            // 
            this.Character_Two_Strength.Enabled = false;
            this.Character_Two_Strength.Location = new System.Drawing.Point(591, 250);
            this.Character_Two_Strength.Name = "Character_Two_Strength";
            this.Character_Two_Strength.Size = new System.Drawing.Size(100, 20);
            this.Character_Two_Strength.TabIndex = 12;
            this.Character_Two_Strength.TextChanged += new System.EventHandler(this.Character_Two_Strength_TextChanged);
            // 
            // Character_Two_Health
            // 
            this.Character_Two_Health.Enabled = false;
            this.Character_Two_Health.Location = new System.Drawing.Point(591, 158);
            this.Character_Two_Health.Name = "Character_Two_Health";
            this.Character_Two_Health.Size = new System.Drawing.Size(100, 20);
            this.Character_Two_Health.TabIndex = 11;
            this.Character_Two_Health.TextChanged += new System.EventHandler(this.Character_Two_Health_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Character 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Defense";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Strength";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Luck";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Health";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Defense";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(526, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Strength";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(526, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Luck";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(526, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Speed";
            // 
            // Attack_Character_2
            // 
            this.Attack_Character_2.Location = new System.Drawing.Point(548, 59);
            this.Attack_Character_2.Name = "Attack_Character_2";
            this.Attack_Character_2.Size = new System.Drawing.Size(181, 23);
            this.Attack_Character_2.TabIndex = 26;
            this.Attack_Character_2.Text = "Attack Character 2";
            this.Attack_Character_2.UseVisualStyleBackColor = true;
            this.Attack_Character_2.Click += new System.EventHandler(this.Attack_Character_2_Click);
            // 
            // Attack_Character_1
            // 
            this.Attack_Character_1.Location = new System.Drawing.Point(12, 58);
            this.Attack_Character_1.Name = "Attack_Character_1";
            this.Attack_Character_1.Size = new System.Drawing.Size(167, 23);
            this.Attack_Character_1.TabIndex = 27;
            this.Attack_Character_1.Text = "Attack Character 1";
            this.Attack_Character_1.UseVisualStyleBackColor = true;
            this.Attack_Character_1.Click += new System.EventHandler(this.Attack_Character_1_Click);
            // 
            // Defend_Character_1
            // 
            this.Defend_Character_1.Location = new System.Drawing.Point(12, 101);
            this.Defend_Character_1.Name = "Defend_Character_1";
            this.Defend_Character_1.Size = new System.Drawing.Size(167, 23);
            this.Defend_Character_1.TabIndex = 28;
            this.Defend_Character_1.Text = "Defend Character 1";
            this.Defend_Character_1.UseVisualStyleBackColor = true;
            this.Defend_Character_1.Click += new System.EventHandler(this.Defend_Character_1_Click);
            // 
            // Defend_Character_2
            // 
            this.Defend_Character_2.Location = new System.Drawing.Point(548, 101);
            this.Defend_Character_2.Name = "Defend_Character_2";
            this.Defend_Character_2.Size = new System.Drawing.Size(181, 23);
            this.Defend_Character_2.TabIndex = 29;
            this.Defend_Character_2.Text = "Defend Character 2";
            this.Defend_Character_2.UseVisualStyleBackColor = true;
            this.Defend_Character_2.Click += new System.EventHandler(this.Defend_Character_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(748, 557);
            this.Controls.Add(this.Defend_Character_2);
            this.Controls.Add(this.Defend_Character_1);
            this.Controls.Add(this.Attack_Character_1);
            this.Controls.Add(this.Attack_Character_2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Attack_Character_2;
        private System.Windows.Forms.Button Attack_Character_1;
        private System.Windows.Forms.Button Defend_Character_1;
        private System.Windows.Forms.Button Defend_Character_2;
    }
}

