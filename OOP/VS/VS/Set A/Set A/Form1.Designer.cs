namespace Set_A
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.Option = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.Label();
            this.fi = new System.Windows.Forms.Label();
            this.pref = new System.Windows.Forms.Label();
            this.mid = new System.Windows.Forms.Label();
            this.pre = new System.Windows.Forms.Label();
            this.GradeInformation = new System.Windows.Forms.Label();
            this.gradeEquivalent = new System.Windows.Forms.Label();
            this.Compute = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.GPA = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NewScheme = new System.Windows.Forms.RadioButton();
            this.OldScheme = new System.Windows.Forms.RadioButton();
            this.Parse = new System.Windows.Forms.GroupBox();
            this.final = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prefinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.midterm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prelim = new System.Windows.Forms.TextBox();
            this.prelimGrade = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Parse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.Option);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(15, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(502, 51);
            this.panel5.TabIndex = 26;
            // 
            // Option
            // 
            this.Option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Option.FormattingEnabled = true;
            this.Option.Items.AddRange(new object[] {
            "Letter Grade",
            "Number Grade"});
            this.Option.Location = new System.Drawing.Point(219, 10);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(259, 30);
            this.Option.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Choose an Option:";
            // 
            // Remarks
            // 
            this.Remarks.AutoSize = true;
            this.Remarks.Location = new System.Drawing.Point(16, 245);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(90, 22);
            this.Remarks.TabIndex = 7;
            this.Remarks.Text = "Remarks:";
            // 
            // fi
            // 
            this.fi.AutoSize = true;
            this.fi.Location = new System.Drawing.Point(16, 155);
            this.fi.Name = "fi";
            this.fi.Size = new System.Drawing.Size(70, 22);
            this.fi.TabIndex = 6;
            this.fi.Text = "Final:";
            // 
            // pref
            // 
            this.pref.AutoSize = true;
            this.pref.Location = new System.Drawing.Point(16, 125);
            this.pref.Name = "pref";
            this.pref.Size = new System.Drawing.Size(110, 22);
            this.pref.TabIndex = 5;
            this.pref.Text = "Pre Final:";
            // 
            // mid
            // 
            this.mid.AutoSize = true;
            this.mid.Location = new System.Drawing.Point(16, 95);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(90, 22);
            this.mid.TabIndex = 4;
            this.mid.Text = "Midterm:";
            // 
            // pre
            // 
            this.pre.AutoSize = true;
            this.pre.Location = new System.Drawing.Point(16, 65);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(80, 22);
            this.pre.TabIndex = 3;
            this.pre.Text = "Prelim:";
            // 
            // GradeInformation
            // 
            this.GradeInformation.AutoSize = true;
            this.GradeInformation.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GradeInformation.Location = new System.Drawing.Point(16, 16);
            this.GradeInformation.Name = "GradeInformation";
            this.GradeInformation.Size = new System.Drawing.Size(180, 22);
            this.GradeInformation.TabIndex = 2;
            this.GradeInformation.Text = "Grade Information";
            // 
            // gradeEquivalent
            // 
            this.gradeEquivalent.AutoSize = true;
            this.gradeEquivalent.Location = new System.Drawing.Point(16, 215);
            this.gradeEquivalent.Name = "gradeEquivalent";
            this.gradeEquivalent.Size = new System.Drawing.Size(170, 22);
            this.gradeEquivalent.TabIndex = 1;
            this.gradeEquivalent.Text = "gradeEquivalent:";
            // 
            // Compute
            // 
            this.Compute.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compute.Location = new System.Drawing.Point(96, 715);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(110, 30);
            this.Compute.TabIndex = 31;
            this.Compute.Text = "Compute";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.compute);
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(323, 715);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(80, 30);
            this.About.TabIndex = 29;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.about);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(423, 715);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(80, 30);
            this.Close.TabIndex = 28;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.close);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.Remarks);
            this.panel6.Controls.Add(this.fi);
            this.panel6.Controls.Add(this.pref);
            this.panel6.Controls.Add(this.mid);
            this.panel6.Controls.Add(this.pre);
            this.panel6.Controls.Add(this.GradeInformation);
            this.panel6.Controls.Add(this.gradeEquivalent);
            this.panel6.Controls.Add(this.GPA);
            this.panel6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(15, 375);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(502, 323);
            this.panel6.TabIndex = 27;
            // 
            // GPA
            // 
            this.GPA.AutoSize = true;
            this.GPA.Location = new System.Drawing.Point(16, 185);
            this.GPA.Name = "GPA";
            this.GPA.Size = new System.Drawing.Size(50, 22);
            this.GPA.TabIndex = 0;
            this.GPA.Text = "GPA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(15, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 39);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 39);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(-1, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 39);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.NewScheme);
            this.panel4.Controls.Add(this.OldScheme);
            this.panel4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(-1, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 39);
            this.panel4.TabIndex = 4;
            // 
            // NewScheme
            // 
            this.NewScheme.AutoSize = true;
            this.NewScheme.Location = new System.Drawing.Point(291, 5);
            this.NewScheme.Name = "NewScheme";
            this.NewScheme.Size = new System.Drawing.Size(135, 26);
            this.NewScheme.TabIndex = 1;
            this.NewScheme.TabStop = true;
            this.NewScheme.Text = "New Scheme";
            this.NewScheme.UseVisualStyleBackColor = true;
            // 
            // OldScheme
            // 
            this.OldScheme.AutoSize = true;
            this.OldScheme.Location = new System.Drawing.Point(56, 5);
            this.OldScheme.Name = "OldScheme";
            this.OldScheme.Size = new System.Drawing.Size(135, 26);
            this.OldScheme.TabIndex = 0;
            this.OldScheme.TabStop = true;
            this.OldScheme.Text = "Old Scheme";
            this.OldScheme.UseVisualStyleBackColor = true;
            // 
            // Parse
            // 
            this.Parse.Controls.Add(this.final);
            this.Parse.Controls.Add(this.label3);
            this.Parse.Controls.Add(this.prefinal);
            this.Parse.Controls.Add(this.label2);
            this.Parse.Controls.Add(this.midterm);
            this.Parse.Controls.Add(this.label1);
            this.Parse.Controls.Add(this.prelim);
            this.Parse.Controls.Add(this.prelimGrade);
            this.Parse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Parse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parse.Location = new System.Drawing.Point(15, 12);
            this.Parse.Name = "Parse";
            this.Parse.Size = new System.Drawing.Size(502, 223);
            this.Parse.TabIndex = 24;
            this.Parse.TabStop = false;
            this.Parse.Text = "Input Grade";
            // 
            // final
            // 
            this.final.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final.Location = new System.Drawing.Point(221, 160);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(259, 29);
            this.final.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Final Grade";
            // 
            // prefinal
            // 
            this.prefinal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefinal.Location = new System.Drawing.Point(221, 120);
            this.prefinal.Name = "prefinal";
            this.prefinal.Size = new System.Drawing.Size(259, 29);
            this.prefinal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pre Final Grade";
            // 
            // midterm
            // 
            this.midterm.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midterm.Location = new System.Drawing.Point(221, 80);
            this.midterm.Name = "midterm";
            this.midterm.Size = new System.Drawing.Size(259, 29);
            this.midterm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Midterm Grade";
            // 
            // prelim
            // 
            this.prelim.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prelim.Location = new System.Drawing.Point(221, 40);
            this.prelim.Name = "prelim";
            this.prelim.Size = new System.Drawing.Size(259, 29);
            this.prelim.TabIndex = 1;
            // 
            // prelimGrade
            // 
            this.prelimGrade.AutoSize = true;
            this.prelimGrade.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prelimGrade.Location = new System.Drawing.Point(16, 40);
            this.prelimGrade.Name = "prelimGrade";
            this.prelimGrade.Size = new System.Drawing.Size(130, 22);
            this.prelimGrade.TabIndex = 0;
            this.prelimGrade.Text = "Prelim Grade";
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(223, 715);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(80, 30);
            this.Reset.TabIndex = 30;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.reset);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 757);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Parse);
            this.Controls.Add(this.Reset);
            this.MaximumSize = new System.Drawing.Size(555, 813);
            this.MinimumSize = new System.Drawing.Size(555, 813);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Parse.ResumeLayout(false);
            this.Parse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox Option;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Remarks;
        private System.Windows.Forms.Label fi;
        private System.Windows.Forms.Label pref;
        private System.Windows.Forms.Label mid;
        private System.Windows.Forms.Label pre;
        private System.Windows.Forms.Label GradeInformation;
        private System.Windows.Forms.Label gradeEquivalent;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label GPA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton NewScheme;
        private System.Windows.Forms.RadioButton OldScheme;
        private System.Windows.Forms.GroupBox Parse;
        private System.Windows.Forms.TextBox final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prefinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox midterm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prelim;
        private System.Windows.Forms.Label prelimGrade;
        private System.Windows.Forms.Button Reset;
    }
}

