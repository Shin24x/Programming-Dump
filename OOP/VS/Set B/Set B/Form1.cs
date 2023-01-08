using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Set_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            charge.Text = "";
            call.Text = "";
            code.Text = "";
            tcode.Text = "";
        }

        private void compute(object sender, EventArgs e)
        {
            double minutes;

            bool parseOkay = double.TryParse(mins.Text, out minutes);

            if (!parseOkay)
            {
                MessageBox.Show("Error: Please enter a valid number of minutes.");
                return;
            }

            double charge = 0;

            if (option.SelectedItem == null)
            {
                MessageBox.Show("Error: Please select a region.");
                return;
            }

            if (day.Checked)
            {
                switch (option.SelectedItem.ToString())
                {
                    case "American Region":
                        charge = minutes / 3 * 50;
                        break;
                    case "Asian Region":
                        charge = minutes / 2 * 30;
                        break;
                    case "African Region":
                        charge = minutes / 3 * 40;
                        break;
                    case "European Region":
                        charge = minutes / 2 * 35;
                        break;
                    default:
                        break;
                }
            }
            else if (night.Checked)
            {
                switch (option.SelectedItem.ToString())
                {
                    case "American Region":
                        charge = minutes / 3 * 45;
                        break;
                    case "Asian Region":
                        charge = minutes / 2 * 27;
                        break;
                    case "African Region":
                        charge = minutes / 3 * 36;
                        break;
                    case "European Region":
                        charge = minutes / 2 * 30;
                        break;
                    default:
                        break;
                }
            }

            this.call.Text = minutes.ToString();
            this.code.Text = option.SelectedItem.ToString();
            this.tcode.Text = day.Checked ? "Day" : "Night";
            this.charge.Text = charge.ToString();
        }

        private void reset(object sender, EventArgs e)
        {
            mins.Clear();
            option.SelectedItem = null;
            day.Checked = false;
            night.Checked = false;
            call.Text = null;
            code.Text = null;
            tcode.Text = null;
            charge.Text = null;
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
