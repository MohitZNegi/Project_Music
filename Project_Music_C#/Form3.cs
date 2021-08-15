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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int clickcounter = 1;

        private void Form3_Load(object sender, EventArgs e)
        {
            // initially form size is this and its zoomed in 0% and zoomed out 100%
            this.Font = new Font("Ebrima", 6);
            label1.Font = new Font("Ebrima", 11, FontStyle.Bold);
            label2.Font = new Font("Ebrima", 8);
            label9.Font = new Font("Ebrima", 8);
            label11.Font = new Font("Ebrima", 8);
            button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // every time the zoom in picturebox is clicked the form will be zoomed in 25%.

            if (clickcounter == 1)// zoom in to 25%
            {
                this.Font = new Font("Ebrima", 8);
                label1.Font = new Font("Ebrima", 18, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 10);
                label9.Font = new Font("Ebrima", 10);
                label11.Font = new Font("Ebrima", 10);
                button1.Font = new Font("Ebrima", 14, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 25%";
                toolTip2.ToolTipTitle = "zoomed out 75%";

            }
            else if (clickcounter == 2)// zoom in to 50%
            {
                this.Font = new Font("Ebrima", 10);
                label1.Font = new Font("Ebrima", 21, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 12);
                label9.Font = new Font("Ebrima", 12);
                label11.Font = new Font("Ebrima", 12);
                button1.Font = new Font("Ebrima", 16, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 50%";
                toolTip2.ToolTipTitle = "zoomed out 50%";
            }

            else if (clickcounter == 3) // zoom in to 75%
            {
                this.Font = new Font("Ebrima", 12);
                label1.Font = new Font("Ebrima", 27, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 14);
                label9.Font = new Font("Ebrima", 14);
                label11.Font = new Font("Ebrima", 14);
                button1.Font = new Font("Ebrima", 18, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 75%";
                toolTip2.ToolTipTitle = "zoomed out 25%";
            }
            else if (clickcounter == 4)// zoom in to 100%
            {
                this.Font = new Font("Ebrima", 14);
                label1.Font = new Font("Ebrima", 32, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 16);
                label9.Font = new Font("Ebrima", 16);
                label11.Font = new Font("Ebrima", 16);
                button1.Font = new Font("Ebrima", 20, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 100%";
                toolTip2.ToolTipTitle = "";
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // every time the zoom out picturebox is clicked the form will be zoomed out 25%.
            if (clickcounter == 2)// zoom out to 100%
            {
                this.Font = new Font("Ebrima", 6);
                label1.Font = new Font("Ebrima", 11, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 8);
                label9.Font = new Font("Ebrima", 8);
                label11.Font = new Font("Ebrima", 8);
                button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "";
                toolTip2.ToolTipTitle = "zoomed out 100%";

            }
            else if (clickcounter == 3)//zoom out to 75%
            {
                this.Font = new Font("Ebrima", 8);
                label1.Font = new Font("Ebrima", 18, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 10);
                label9.Font = new Font("Ebrima", 10);
                label11.Font = new Font("Ebrima", 10);
                button1.Font = new Font("Ebrima", 14, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 25%";
                toolTip2.ToolTipTitle = "zoomed out 75%";

            }
            else if (clickcounter == 4)//zoom out to 50%
            {
                this.Font = new Font("Ebrima", 10);
                label1.Font = new Font("Ebrima", 21, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 12);
                label9.Font = new Font("Ebrima", 12);
                label11.Font = new Font("Ebrima", 12);
                button1.Font = new Font("Ebrima", 16, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 50%";
                toolTip2.ToolTipTitle = "zoomed out 50%";
            }

            else if (clickcounter == 5) // zoom in to 25%
            {
                this.Font = new Font("Ebrima", 12);
                label1.Font = new Font("Ebrima", 27, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 14);
                label9.Font = new Font("Ebrima", 14);
                label11.Font = new Font("Ebrima", 14);
                button1.Font = new Font("Ebrima", 18, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 75%";
                toolTip2.ToolTipTitle = "zoomed out 25%";
            }
            else if (clickcounter == 6)
            {
                toolTip1.ToolTipTitle = "zoomed in 100%";
                toolTip2.ToolTipTitle = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
