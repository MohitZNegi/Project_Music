using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Music
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int counter = 1;
        int clickcounter = 1;

        private void Form5_Load(object sender, EventArgs e)
        {
            // initially form size is this and its zoomed in 0% and zoomed out 100%
            this.Font = new Font("Arial", 7);
            linkLabel1.Font = new Font("hooge 05_53", 7);
            linkLabel2.Font = new Font("hooge 05_53", 7);
            linkLabel3.Font = new Font("hooge 05_53", 7);
            linkLabel4.Font = new Font("hooge 05_53", 7);
            linkLabel5.Font = new Font("hooge 05_53", 7);
            linkLabel6.Font = new Font("hooge 05_53", 7);
            linkLabel7.Font = new Font("hooge 05_53", 7);
            linkLabel8.Font = new Font("hooge 05_53", 7);
            label13.Font = new Font("Ebrima", 7);
            label9.Font = new Font("LCDMono2", 8, FontStyle.Bold);
            label10.Font = new Font("LCDMono2", 8, FontStyle.Bold);
            label11.Font = new Font("Ebrima", 8);
            label12.Font = new Font("Tahoma", 15, FontStyle.Bold);
            label14.Font = new Font("Segoe Print", 18, FontStyle.Bold);
            
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
            {
                if (listView1.Items[i].Index % 2 == 0)
                {
                    listView1.Items[i].BackColor = Color.Teal;
                }
                else
                {
                    listView1.Items[i].BackColor = Color.LightSeaGreen;
                }

            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (counter % 2 != 0)
            {
                pictureBox22.Visible = true;
                pictureBox12.Visible = false;
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (counter % 2 != 0)
            {
                pictureBox12.Visible = true;
                pictureBox22.Visible = false;
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 myaccount = new Form4();
            myaccount.ShowDialog();
        }

        private void pictureBox24_Click_1(object sender, EventArgs e)
        {
            // every time the zoom in picturebox is clicked the form will be zoomed in 25%.

            if (clickcounter == 1)// zoom in to 25%
            {
                this.Font = new Font("Arial", 8);
                linkLabel1.Font = new Font("hooge 05_53", 8);
                linkLabel2.Font = new Font("hooge 05_53", 8);
                linkLabel3.Font = new Font("hooge 05_53", 8);
                linkLabel4.Font = new Font("hooge 05_53", 8);
                linkLabel5.Font = new Font("hooge 05_53", 8);
                linkLabel6.Font = new Font("hooge 05_53", 8);
                linkLabel7.Font = new Font("hooge 05_53", 8);
                linkLabel8.Font = new Font("hooge 05_53", 8);
                label13.Font = new Font("Ebrima", 8);
                label9.Font = new Font("LCDMono2", 9, FontStyle.Bold);
                label10.Font = new Font("LCDMono2", 9, FontStyle.Bold);
                label11.Font = new Font("Ebrima", 10);
                label14.Font = new Font("Segoe Print", 20, FontStyle.Bold);
                label12.Font = new Font("Tahoma", 20, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 25%";
                toolTip2.ToolTipTitle = "zoomed out 75%";
            }
            else if (clickcounter == 2)// zoom in to 50%
            {
                this.Font = new Font("Arial", 9);
                linkLabel1.Font = new Font("hooge 05_53", 9);
                linkLabel2.Font = new Font("hooge 05_53", 9);
                linkLabel3.Font = new Font("hooge 05_53", 9);
                linkLabel4.Font = new Font("hooge 05_53", 9);
                linkLabel5.Font = new Font("hooge 05_53", 9);
                linkLabel6.Font = new Font("hooge 05_53", 9);
                linkLabel7.Font = new Font("hooge 05_53", 9);
                linkLabel8.Font = new Font("hooge 05_53", 9);
                label13.Font = new Font("Ebrima", 9);
                label9.Font = new Font("LCDMono2", 10, FontStyle.Bold);
                label10.Font = new Font("LCDMono2", 10, FontStyle.Bold);
                label11.Font = new Font("Ebrima", 11);
                label14.Font = new Font("Segoe Print", 22, FontStyle.Bold);
                label12.Font = new Font("Tahoma", 22, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 50%";
                toolTip2.ToolTipTitle = "zoomed out 50%";
            }
            else if (clickcounter == 3)// zoom in to 75%
            {
                this.Font = new Font("Arial", 10);
                linkLabel1.Font = new Font("hooge 05_53", 9);
                linkLabel2.Font = new Font("hooge 05_53", 9);
                linkLabel3.Font = new Font("hooge 05_53", 9);
                linkLabel4.Font = new Font("hooge 05_53", 9);
                linkLabel5.Font = new Font("hooge 05_53", 9);
                linkLabel6.Font = new Font("hooge 05_53", 9);
                linkLabel7.Font = new Font("hooge 05_53", 9);
                linkLabel8.Font = new Font("hooge 05_53", 9);
                label13.Font = new Font("Ebrima", 10);
                label9.Font = new Font("LCDMono2", 11, FontStyle.Bold);
                label10.Font = new Font("LCDMono2", 11, FontStyle.Bold);
                label11.Font = new Font("Ebrima", 12);
                label14.Font = new Font("Segoe Print", 25, FontStyle.Bold);
                label12.Font = new Font("Tahoma", 24, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 75%";
                toolTip2.ToolTipTitle = "zoomed out 25%";
            }
            else if (clickcounter == 4)// zoom in to 100%
            {
                this.Font = new Font("Arial", 11);
                linkLabel1.Font = new Font("hooge 05_53", 10);
                linkLabel2.Font = new Font("hooge 05_53", 10);
                linkLabel3.Font = new Font("hooge 05_53", 10);
                linkLabel4.Font = new Font("hooge 05_53", 10);
                linkLabel5.Font = new Font("hooge 05_53", 10);
                linkLabel6.Font = new Font("hooge 05_53", 10);
                linkLabel7.Font = new Font("hooge 05_53", 10);
                linkLabel8.Font = new Font("hooge 05_53", 10);
                label13.Font = new Font("Ebrima", 12);
                label9.Font = new Font("LCDMono2", 11, FontStyle.Bold);
                label10.Font = new Font("LCDMono2", 11, FontStyle.Bold);
                label11.Font = new Font("Ebrima", 13);
                label14.Font = new Font("Segoe Print", 29, FontStyle.Bold);
                label12.Font = new Font("Tahoma", 26, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 100%";
                toolTip2.ToolTipTitle = "";
            }
        }

        private void pictureBox23_Click_1(object sender, EventArgs e)
        {

            // every time the zoom out picturebox is clicked the form will be zoomed out 25%.

            if (clickcounter == 2)// zoom out to 100%
            {
                this.Font = new Font("Arial", 7);
                linkLabel1.Font = new Font("hooge 05_53", 7);
                linkLabel2.Font = new Font("hooge 05_53", 7);
                linkLabel3.Font = new Font("hooge 05_53", 7);
                linkLabel4.Font = new Font("hooge 05_53", 7);
                linkLabel5.Font = new Font("hooge 05_53", 7);
                linkLabel6.Font = new Font("hooge 05_53", 7);
                linkLabel7.Font = new Font("hooge 05_53", 7);
                linkLabel8.Font = new Font("hooge 05_53", 7);
                label13.Font = new Font("Ebrima", 7);
                label9.Font = new Font("LCDMono2", 8, FontStyle.Bold);
                label10.Font = new Font("LCDMono2", 8, FontStyle.Bold);
                label11.Font = new Font("Ebrima", 8);
                label14.Font = new Font("Segoe Print", 15, FontStyle.Bold);
                toolTip1.ToolTipTitle = "";
                toolTip2.ToolTipTitle = "zoomed out 100%";
                clickcounter--;
            }
            else if (clickcounter == 3)// zoom out to 75%
            {
                this.Font = new Font("Arial", 8);
                linkLabel1.Font = new Font("hooge 05_53", 8);
                linkLabel2.Font = new Font("hooge 05_53", 8);
                linkLabel3.Font = new Font("hooge 05_53", 8);
                linkLabel4.Font = new Font("hooge 05_53", 8);
                linkLabel5.Font = new Font("hooge 05_53", 8);
                linkLabel6.Font = new Font("hooge 05_53", 8);
                linkLabel7.Font = new Font("hooge 05_53", 8);
                linkLabel8.Font = new Font("hooge 05_53", 8);
                label13.Font = new Font("Ebrima", 8);
                label9.Font = new Font("LCDMono2", 9, FontStyle.Bold);
                label10.Font = new Font("LCDMono2", 9, FontStyle.Bold);
                label11.Font = new Font("Ebrima", 10);
                label14.Font = new Font("Segoe Print", 19, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 25%";
                toolTip2.ToolTipTitle = "zoomed out 75%";
            }
            else if (clickcounter == 4)// zoom out to 50%
            {
                this.Font = new Font("Arial", 9);
                linkLabel1.Font = new Font("hooge 05_53", 9);
                linkLabel2.Font = new Font("hooge 05_53", 9);
                linkLabel3.Font = new Font("hooge 05_53", 9);
                linkLabel4.Font = new Font("hooge 05_53", 9);
                linkLabel5.Font = new Font("hooge 05_53", 9);
                linkLabel6.Font = new Font("hooge 05_53", 9);
                linkLabel7.Font = new Font("hooge 05_53", 9);
                linkLabel8.Font = new Font("hooge 05_53", 9);
                label13.Font = new Font("Ebrima", 9);
                label9.Font = new Font("LCDMono2", 10, FontStyle.Bold);
                label10.Font = new Font("LCDMono2", 10, FontStyle.Bold);
                label11.Font = new Font("Ebrima", 11);
                label14.Font = new Font("Segoe Print", 22, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 50%";
                toolTip2.ToolTipTitle = "zoomed out 50%";
            }
            else if (clickcounter == 5)// zoom out to 25%
            {
                this.Font = new Font("Arial", 10);
                linkLabel1.Font = new Font("hooge 05_53", 9);
                linkLabel2.Font = new Font("hooge 05_53", 9);
                linkLabel3.Font = new Font("hooge 05_53", 9);
                linkLabel4.Font = new Font("hooge 05_53", 9);
                linkLabel5.Font = new Font("hooge 05_53", 9);
                linkLabel6.Font = new Font("hooge 05_53", 9);
                linkLabel7.Font = new Font("hooge 05_53", 9);
                linkLabel8.Font = new Font("hooge 05_53", 9);
                label13.Font = new Font("Ebrima", 10);
                label9.Font = new Font("LCDMono2", 11, FontStyle.Bold);
                label10.Font = new Font("LCDMono2", 11, FontStyle.Bold);
                label11.Font = new Font("Ebrima", 12);
                label14.Font = new Font("Segoe Print", 25, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 75%";
                toolTip2.ToolTipTitle = "zoomed out 25%";
            }
            else if (clickcounter == 6)// zoom out to 0%
            {
                toolTip1.ToolTipTitle = "zoomed in 100%";
                toolTip2.ToolTipTitle = "";
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
    }
}
