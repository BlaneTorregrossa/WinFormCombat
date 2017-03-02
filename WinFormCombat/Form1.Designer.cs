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
            this.Character_Name_Box = new System.Windows.Forms.TextBox();
            this.Character_Defense_Box = new System.Windows.Forms.TextBox();
            this.Character_Health_Box = new System.Windows.Forms.TextBox();
            this.Character_Strength = new System.Windows.Forms.TextBox();
            this.Character_Luck = new System.Windows.Forms.TextBox();
            this.Character_Speed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(129, 15);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 0;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Location = new System.Drawing.Point(129, 44);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(75, 23);
            this.Load_Button.TabIndex = 1;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click_1);
            // 
            // Character_Name_Box
            // 
            this.Character_Name_Box.Location = new System.Drawing.Point(12, 15);
            this.Character_Name_Box.Name = "Character_Name_Box";
            this.Character_Name_Box.Size = new System.Drawing.Size(100, 20);
            this.Character_Name_Box.TabIndex = 2;
            // 
            // Character_Defense_Box
            // 
            this.Character_Defense_Box.Location = new System.Drawing.Point(12, 109);
            this.Character_Defense_Box.Name = "Character_Defense_Box";
            this.Character_Defense_Box.Size = new System.Drawing.Size(100, 20);
            this.Character_Defense_Box.TabIndex = 3;
            // 
            // Character_Health_Box
            // 
            this.Character_Health_Box.Location = new System.Drawing.Point(12, 70);
            this.Character_Health_Box.Name = "Character_Health_Box";
            this.Character_Health_Box.Size = new System.Drawing.Size(100, 20);
            this.Character_Health_Box.TabIndex = 4;
            // 
            // Character_Strength
            // 
            this.Character_Strength.Location = new System.Drawing.Point(12, 150);
            this.Character_Strength.Name = "Character_Strength";
            this.Character_Strength.Size = new System.Drawing.Size(100, 20);
            this.Character_Strength.TabIndex = 5;
            // 
            // Character_Luck
            // 
            this.Character_Luck.Location = new System.Drawing.Point(12, 186);
            this.Character_Luck.Name = "Character_Luck";
            this.Character_Luck.Size = new System.Drawing.Size(100, 20);
            this.Character_Luck.TabIndex = 6;
            // 
            // Character_Speed
            // 
            this.Character_Speed.Location = new System.Drawing.Point(12, 222);
            this.Character_Speed.Name = "Character_Speed";
            this.Character_Speed.Size = new System.Drawing.Size(100, 20);
            this.Character_Speed.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 557);
            this.Controls.Add(this.Character_Speed);
            this.Controls.Add(this.Character_Luck);
            this.Controls.Add(this.Character_Strength);
            this.Controls.Add(this.Character_Health_Box);
            this.Controls.Add(this.Character_Defense_Box);
            this.Controls.Add(this.Character_Name_Box);
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
        private System.Windows.Forms.TextBox Character_Name_Box;
        private System.Windows.Forms.TextBox Character_Defense_Box;
        private System.Windows.Forms.TextBox Character_Health_Box;
        private System.Windows.Forms.TextBox Character_Strength;
        private System.Windows.Forms.TextBox Character_Luck;
        private System.Windows.Forms.TextBox Character_Speed;
    }
}

