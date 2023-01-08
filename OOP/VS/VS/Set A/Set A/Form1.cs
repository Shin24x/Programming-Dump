using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Set_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pre.Text = "";
            mid.Text = "";
            pref.Text = "";
            fi.Text = "";
            GPA.Text = "";
            gradeEquivalent.Text = "";
            Remarks.Text = "";
        }

        private void compute(object sender, EventArgs e)
        {
            if (!float.TryParse(prelim.Text, out float prelimGrade) ||
                !float.TryParse(midterm.Text, out float midtermGrade) ||
                !float.TryParse(prefinal.Text, out float preFinalGrade) ||
                !float.TryParse(final.Text, out float finalGrade))
            {
                MessageBox.Show("Enter valid grades");
                return;
            }

            // Compute GPA
            float gpa;
            if (OldScheme.Checked)
            {
                gpa = (0.3f * prelimGrade) + (0.3f * midtermGrade) + (0.2f * preFinalGrade) + (0.2f * finalGrade);
            }
            else if (NewScheme.Checked)
            {
                gpa = (prelimGrade + midtermGrade + preFinalGrade + finalGrade) / 4;
            }
            else
            {
                MessageBox.Show("Please select either the old scheme or the new scheme.");
                return;
            }

            string grade;
            if (Option.SelectedItem.ToString() == "Number Grade")
            {
                if (gpa >= 97)
                {
                    grade = "Number Grade:                   1.0";
                }
                else if (gpa >= 94)
                {
                    grade = "Number Grade:                   1.25";
                }
                else if (gpa >= 90)
                {
                    grade = "Number Grade:                   1.50";
                }
                else if (gpa >= 87)
                {
                    grade = "Number Grade:                   1.75";
                }
                else if (gpa >= 84)
                {
                    grade = "Number Grade:                   2.0";
                }
                else if (gpa >= 81)
                {
                    grade = "Number Grade:                   2.25";
                }
                else if (gpa >= 78)
                {
                    grade = "Number Grade:                   2.50";
                }
                else if (gpa >= 76)
                {
                    grade = "Number Grade:                   2.75";
                }
                else if (gpa >= 75)
                {
                    grade = "Number Grade:                   3.0";
                }
                else if (gpa >= 65)
                {
                    grade = "Number Grade:                   5.0";
                }
                else
                {
                    grade = "Invalid GPA";
                }
            }

            else if (Option.SelectedItem.ToString() == "Letter Grade")
            {
                if (gpa >= 96)
                {
                    grade = "Letter Grade:                   A";
                }
                else if (gpa >= 93)
                {
                    grade = "Letter Grade:                   A+";
                }
                else if (gpa >= 88)
                {
                    grade = "Letter Grade:                   B";
                }
                else if (gpa >= 83)
                {
                    grade = "Letter Grade:                   B-";
                }
                else if (gpa >= 78)
                {
                    grade = "Letter Grade:                   C";
                }
                else if (gpa >= 76)
                {
                    grade = "Letter Grade:                   D";
                }
                else if (gpa >= 75)
                {
                    grade = "Letter Grade:                   E";
                }
                else if (gpa >= 65)
                {
                    grade = "Letter Grade:                   F";
                }

                else
                {
                    grade = "Invalid GPA";
                }
            }
            else
            {
                grade = "Invalid selection";
            }

            pre.Text = "Prelim:" + "                         " + prelimGrade;
            mid.Text = "Midterm:" + "                        " + midtermGrade;
            pref.Text = "Pre Final:" + "                      " + preFinalGrade;
            fi.Text = "Final:" + "                          " + finalGrade;
            GPA.Text = "GPA:" + "                            " + gpa;

            switch (gpa)
            {
                case float n when (gpa >= 75):
                    Remarks.Text = "Remarks:                        Passed";
                    break;

                default:
                    Remarks.Text = "Remarks:                        Failed";
                    break;
            }

            gradeEquivalent.Text = grade;
        }

        private void reset(object sender, EventArgs e)
        {
            OldScheme.Checked = false;
            NewScheme.Checked = false;
            Option.SelectedItem = null;
            prelim.Clear();
            midterm.Clear();
            prefinal.Clear();
            final.Clear();
            pre.Text = "";
            mid.Text = "";
            pref.Text = "";
            fi.Text = "";
            GPA.Text = "";
            gradeEquivalent.Text = "";
            Remarks.Text = "";
        }

        private void about(object sender, EventArgs e)
        {
            MessageBox.Show("Hello I'm ");
        }

        private void close(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
