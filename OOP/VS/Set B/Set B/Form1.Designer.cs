namespace Set_B
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mins = new System.Windows.Forms.TextBox();
            this.option = new System.Windows.Forms.ComboBox();
            this.day = new System.Windows.Forms.RadioButton();
            this.night = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelfg4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.charge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tcode = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.call = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.night);
            this.panel1.Controls.Add(this.day);
            this.panel1.Controls.Add(this.option);
            this.panel1.Controls.Add(this.mins);
            this.panel1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 255);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelfg4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 299);
            this.panel2.TabIndex = 1;
            // 
            // mins
            // 
            this.mins.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mins.Location = new System.Drawing.Point(355, 46);
            this.mins.Name = "mins";
            this.mins.Size = new System.Drawing.Size(311, 31);
            this.mins.TabIndex = 0;
            // 
            // option
            // 
            this.option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option.FormattingEnabled = true;
            this.option.Items.AddRange(new object[] {
            "American Region",
            "Asian Region",
            "African Region",
            "European Region"});
            this.option.Location = new System.Drawing.Point(355, 99);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(311, 31);
            this.option.TabIndex = 1;
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.ForeColor = System.Drawing.Color.Maroon;
            this.day.Location = new System.Drawing.Point(355, 161);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(123, 27);
            this.day.TabIndex = 2;
            this.day.TabStop = true;
            this.day.Text = "Day Time";
            this.day.UseVisualStyleBackColor = true;
            // 
            // night
            // 
            this.night.AutoSize = true;
            this.night.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.night.ForeColor = System.Drawing.Color.Maroon;
            this.night.Location = new System.Drawing.Point(521, 161);
            this.night.Name = "night";
            this.night.Size = new System.Drawing.Size(145, 27);
            this.night.TabIndex = 3;
            this.night.TabStop = true;
            this.night.Text = "Night Time";
            this.night.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Length of Call (In Minutes);";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination Code;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(29, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Code;";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.call);
            this.panel3.Controls.Add(this.code);
            this.panel3.Controls.Add(this.tcode);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.charge);
            this.panel3.Location = new System.Drawing.Point(210, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 215);
            this.panel3.TabIndex = 0;
            // 
            // labelfg4
            // 
            this.labelfg4.AutoSize = true;
            this.labelfg4.ForeColor = System.Drawing.Color.Maroon;
            this.labelfg4.Location = new System.Drawing.Point(29, 109);
            this.labelfg4.Name = "labelfg4";
            this.labelfg4.Size = new System.Drawing.Size(153, 23);
            this.labelfg4.TabIndex = 1;
            this.labelfg4.Text = "Total Charge:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.compute);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.reset);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.about);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(435, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.close);
            // 
            // charge
            // 
            this.charge.AutoSize = true;
            this.charge.Location = new System.Drawing.Point(180, 160);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(32, 23);
            this.charge.TabIndex = 0;
            this.charge.Text = "tc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Transaction Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Duration of Call:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Destination Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Time Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total Charge:";
            // 
            // tcode
            // 
            this.tcode.AutoSize = true;
            this.tcode.Location = new System.Drawing.Point(140, 130);
            this.tcode.Name = "tcode";
            this.tcode.Size = new System.Drawing.Size(32, 23);
            this.tcode.TabIndex = 6;
            this.tcode.Text = "tc";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(230, 100);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(32, 23);
            this.code.TabIndex = 7;
            this.code.Text = "tc";
            // 
            // call
            // 
            this.call.AutoSize = true;
            this.call.Location = new System.Drawing.Point(230, 70);
            this.call.Name = "call";
            this.call.Size = new System.Drawing.Size(32, 23);
            this.call.TabIndex = 8;
            this.call.Text = "tc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(751, 640);
            this.MinimumSize = new System.Drawing.Size(751, 640);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton night;
        private System.Windows.Forms.RadioButton day;
        private System.Windows.Forms.ComboBox option;
        private System.Windows.Forms.TextBox mins;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelfg4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label charge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label call;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Label tcode;
    }
}

