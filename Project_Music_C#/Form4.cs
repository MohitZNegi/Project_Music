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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int clickcounter = 1;

        private void Form4_Load(object sender, EventArgs e)
        {
            // initially form size is this and its zoomed in 0% and zoomed out 100%
            this.Font = new Font("Arial", 7);
            label7.Font = new Font("Ebrima", 17, FontStyle.Bold);
            label2.Font = new Font("Ebrima", 7);
            label3.Font = new Font("Ebrima", 7);
            label4.Font = new Font("Ebrima", 7);
            label5.Font = new Font("Ebrima", 7);
            label6.Font = new Font("Ebrima", 7);
            label1.Font = new Font("Ebrima", 7);
            label9.Font = new Font("Ebrima", 7);
            label10.Font = new Font("Ebrima", 7);
            label11.Font = new Font("Ebrima", 7);
            linkLabel1.Font = new Font("Ebrima", 6, FontStyle.Italic);
            groupBox1.Font = new Font("Ebrima", 9, FontStyle.Bold | FontStyle.Underline);
            groupBox2.Font = new Font("Ebrima", 9, FontStyle.Bold | FontStyle.Underline);
            button2.Font = new Font("Ebrima", 9, FontStyle.Bold );
            button1.Font = new Font("Ebrima", 8, FontStyle.Bold);
            button3.Font = new Font("Ebrima", 8, FontStyle.Bold);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            // every time the zoom in picturebox is clicked the form will be zoomed in 25%.

            if (clickcounter == 1)// zoom in to 25%
            {
                this.Font = new Font("Arial", 9);
                label7.Font = new Font("Ebrima", 18, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 9);
                label3.Font = new Font("Ebrima", 9);
                label4.Font = new Font("Ebrima", 9);
                label5.Font = new Font("Ebrima", 9);
                label6.Font = new Font("Ebrima", 9);
                label1.Font = new Font("Ebrima", 9);
                label9.Font = new Font("Ebrima", 9);
                label10.Font = new Font("Ebrima", 9);
                label11.Font = new Font("Ebrima", 9);
                linkLabel1.Font = new Font("Ebrima", 7, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 11, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 11, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 11, FontStyle.Bold);
                button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                button3.Font = new Font("Ebrima", 10, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 25%";
                toolTip2.ToolTipTitle = "zoomed out 75%";

            }
            else if (clickcounter == 2)// zoom in to 50%
            {
                this.Font = new Font("Arial", 10);
                label7.Font = new Font("Ebrima", 20, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 10);
                label3.Font = new Font("Ebrima", 10);
                label4.Font = new Font("Ebrima", 10);
                label5.Font = new Font("Ebrima", 10);
                label6.Font = new Font("Ebrima", 10);
                label1.Font = new Font("Ebrima", 10);
                label9.Font = new Font("Ebrima", 10);
                label10.Font = new Font("Ebrima", 10);
                label11.Font = new Font("Ebrima", 10);
                linkLabel1.Font = new Font("Ebrima", 8, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 12, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 12, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 12, FontStyle.Bold);
                button1.Font = new Font("Ebrima", 11, FontStyle.Bold);
                button3.Font = new Font("Ebrima", 11, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 50%";
                toolTip2.ToolTipTitle = "zoomed out 50%";
            }

            else if (clickcounter == 3) // zoom in to 75%
            {
                this.Font = new Font("Arial", 11);
                label7.Font = new Font("Ebrima", 22, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 11);
                label3.Font = new Font("Ebrima", 11);
                label4.Font = new Font("Ebrima", 11);
                label5.Font = new Font("Ebrima", 11);
                label6.Font = new Font("Ebrima", 11);
                label1.Font = new Font("Ebrima", 11);
                label9.Font = new Font("Ebrima", 11);
                label10.Font = new Font("Ebrima", 11);
                label11.Font = new Font("Ebrima", 11);
                linkLabel1.Font = new Font("Ebrima", 9, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 13, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 13, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 13, FontStyle.Bold);
                button1.Font = new Font("Ebrima", 12, FontStyle.Bold);
                button3.Font = new Font("Ebrima", 12, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 75%";
                toolTip2.ToolTipTitle = "zoomed out 25%";
            }
            else if (clickcounter == 4)// zoom in to 100%
            {
                this.Font = new Font("Arial", 12);
                label7.Font = new Font("Ebrima", 26, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 12);
                label3.Font = new Font("Ebrima", 12);
                label4.Font = new Font("Ebrima", 12);
                label5.Font = new Font("Ebrima", 12);
                label6.Font = new Font("Ebrima", 12);
                label1.Font = new Font("Ebrima", 12);
                label9.Font = new Font("Ebrima", 12);
                label10.Font = new Font("Ebrima", 12);
                label11.Font = new Font("Ebrima", 12);
                linkLabel1.Font = new Font("Ebrima", 10, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 14, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 14, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 14, FontStyle.Bold);
                button1.Font = new Font("Ebrima", 13, FontStyle.Bold);
                button3.Font = new Font("Ebrima", 13, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 100%";
                toolTip2.ToolTipTitle = "";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // every time the zoom in picturebox is clicked the form will be zoomed in 25%.

            if (clickcounter == 2)// zoom out to 100%
            {
                this.Font = new Font("Arial", 7);
                label7.Font = new Font("Ebrima", 17, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 7);
                label3.Font = new Font("Ebrima", 7);
                label4.Font = new Font("Ebrima", 7);
                label5.Font = new Font("Ebrima", 7);
                label6.Font = new Font("Ebrima", 7);
                label1.Font = new Font("Ebrima", 7);
                label9.Font = new Font("Ebrima", 7);
                label10.Font = new Font("Ebrima", 7);
                label11.Font = new Font("Ebrima", 7);
                linkLabel1.Font = new Font("Ebrima", 6, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 9, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 9, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 9, FontStyle.Bold);
                button1.Font = new Font("Ebrima", 8, FontStyle.Bold);
                button3.Font = new Font("Ebrima", 8, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "";
                toolTip2.ToolTipTitle = "zoomed out 100%";

            }
            else if (clickcounter == 3)// zoom out to 75%
            {
                this.Font = new Font("Arial", 9);
                label7.Font = new Font("Ebrima", 18, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 9);
                label3.Font = new Font("Ebrima", 9);
                label4.Font = new Font("Ebrima", 9);
                label5.Font = new Font("Ebrima", 9);
                label6.Font = new Font("Ebrima", 9);
                label1.Font = new Font("Ebrima", 9);
                label9.Font = new Font("Ebrima", 9);
                label10.Font = new Font("Ebrima", 9);
                label11.Font = new Font("Ebrima", 9);
                linkLabel1.Font = new Font("Ebrima", 7, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 11, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 11, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 11, FontStyle.Bold);
                button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                button3.Font = new Font("Ebrima", 10, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 25%";
                toolTip2.ToolTipTitle = "zoomed out 75%";

            }
            else if (clickcounter == 4)// zoom out to 50%
            {
                this.Font = new Font("Arial", 10);
                label7.Font = new Font("Ebrima", 20, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 10);
                label3.Font = new Font("Ebrima", 10);
                label4.Font = new Font("Ebrima", 10);
                label5.Font = new Font("Ebrima", 10);
                label6.Font = new Font("Ebrima", 10);
                label1.Font = new Font("Ebrima", 10);
                label9.Font = new Font("Ebrima", 10);
                label10.Font = new Font("Ebrima", 10);
                label11.Font = new Font("Ebrima", 10);
                linkLabel1.Font = new Font("Ebrima", 8, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 12, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 12, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 12, FontStyle.Bold);
                button1.Font = new Font("Ebrima", 11, FontStyle.Bold);
                button3.Font = new Font("Ebrima", 11, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 50%";
                toolTip2.ToolTipTitle = "zoomed out 50%";
            }

            else if (clickcounter == 5) // zoom out to 25%
            {
                this.Font = new Font("Arial", 11);
                label7.Font = new Font("Ebrima", 22, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 11);
                label3.Font = new Font("Ebrima", 11);
                label4.Font = new Font("Ebrima", 11);
                label5.Font = new Font("Ebrima", 11);
                label6.Font = new Font("Ebrima", 11);
                label1.Font = new Font("Ebrima", 11);
                label9.Font = new Font("Ebrima", 11);
                label10.Font = new Font("Ebrima", 11);
                label11.Font = new Font("Ebrima", 11);
                linkLabel1.Font = new Font("Ebrima", 9, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 13, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 13, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 13, FontStyle.Bold);
                button1.Font = new Font("Ebrima", 12, FontStyle.Bold);
                button3.Font = new Font("Ebrima", 12, FontStyle.Bold);
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
    }
}
