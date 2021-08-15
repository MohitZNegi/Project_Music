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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadCaptcha();
        }
        int clickcounter = 1;
        int number = 0;

        private void LoadCaptcha()
        {

            Random refresh = new Random();//random is a special class that randomises an object
            number = refresh.Next(6, 7);//the range of the randomly generated object
            string captcha = "";
            int capnum = 0;

            do
            {
                int chr = refresh.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 97 && chr <= 123) || (chr >= 65 && chr <= 90))
                {
                    captcha = captcha + (char)chr;
                    capnum++;
                    if (capnum == number)
                        break;

                }
            }
            while (true);
            label14.Text = captcha.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadCaptcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != label14.Text.ToString())
            {
                MessageBox.Show("Please enter the CAPTCHA correctly.");
                textBox8.BackColor = Color.OrangeRed;
                textBox8.Focus();
            }
            else
            {
                Login sign_in = new Login(textBox4.Text, textBox4.Text, textBox1.Text);
            }

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // initially form size is this and its zoomed in 0% and zoomed out 100%
            this.Font = new Font("Ebrima", 6);
            label1.Font = new Font("Ebrima", 17, FontStyle.Bold);
            label3.Font = new Font("Ebrima", 8);
            label8.Font = new Font("Ebrima", 8);
            label9.Font = new Font("Ebrima", 8);
            label11.Font = new Font("Ebrima", 8);
            label14.Font = new Font("Ink Free", 15);
            linkLabel1.Font = new Font("Ebrima", 8, FontStyle.Italic);
            button2.Font = new Font("Ebrima", 7);
            button1.Font = new Font("Ebrima", 10, FontStyle.Bold);

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // every time the zoom in picturebox is clicked the form will be zoomed in 25%.

            if (clickcounter == 1)// zoom in to 25%
            {
                this.Font = new Font("Ebrima", 8);
                label1.Font = new Font("Ebrima", 18, FontStyle.Bold);
                label3.Font = new Font("Ebrima", 10);
                label8.Font = new Font("Ebrima", 10);
                label9.Font = new Font("Ebrima", 10);
                label11.Font = new Font("Ebrima", 10);
                label14.Font = new Font("Ink Free", 20);
                linkLabel1.Font = new Font("Ebrima", 9, FontStyle.Italic);
                button2.Font = new Font("Ebrima", 9);
                button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                clickcounter++;
                toolTip2.ToolTipTitle = "zoomed in 25%";
                toolTip3.ToolTipTitle = "zoomed out 75%";

            }
            else if (clickcounter == 2)// zoom in to 50%
            {
                this.Font = new Font("Ebrima", 10);
                label1.Font = new Font("Ebrima", 23, FontStyle.Bold);
                label3.Font = new Font("Ebrima", 12);
                label8.Font = new Font("Ebrima", 12);
                label9.Font = new Font("Ebrima", 12);
                label11.Font = new Font("Ebrima", 12);
                label14.Font = new Font("Ink Free", 23);
                linkLabel1.Font = new Font("Ebrima", 10, FontStyle.Italic);
                button2.Font = new Font("Ebrima", 10);
                button1.Font = new Font("Ebrima", 13, FontStyle.Bold);
                clickcounter++;
                toolTip2.ToolTipTitle = "zoomed in 50%";
                toolTip3.ToolTipTitle = "zoomed out 50%";
            }

            else if (clickcounter == 3) // zoom in to 75%
            {
                this.Font = new Font("Ebrima", 12);
                label1.Font = new Font("Ebrima", 27, FontStyle.Bold);
                label3.Font = new Font("Ebrima", 14);
                label8.Font = new Font("Ebrima", 14);
                label9.Font = new Font("Ebrima", 14);
                label11.Font = new Font("Ebrima", 14);
                label14.Font = new Font("Ink Free", 27);
                linkLabel1.Font = new Font("Ebrima", 11, FontStyle.Italic);
                button2.Font = new Font("Ebrima", 11);
                button1.Font = new Font("Ebrima", 16, FontStyle.Bold);
                clickcounter++;
                toolTip2.ToolTipTitle = "zoomed in 75%";
                toolTip3.ToolTipTitle = "zoomed out 25%";
            }
            else if (clickcounter == 4)// zoom in to 100%
            {
                this.Font = new Font("Ebrima", 14);
                label1.Font = new Font("Ebrima", 32, FontStyle.Bold);
                label3.Font = new Font("Ebrima", 16);
                label8.Font = new Font("Ebrima", 16);
                label9.Font = new Font("Ebrima", 16);
                label11.Font = new Font("Ebrima", 16);
                label14.Font = new Font("Ink Free", 32);
                linkLabel1.Font = new Font("Ebrima", 12, FontStyle.Italic);
                button2.Font = new Font("Ebrima", 12);
                button1.Font = new Font("Ebrima", 20, FontStyle.Bold);
                clickcounter++;
                toolTip2.ToolTipTitle = "zoomed in 100%";
                toolTip3.ToolTipTitle = "";
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // every time the zoom out picturebox is clicked the form will be zoomed out 25%.

            if (clickcounter == 2)//zoom out to 100%
            {

                this.Font = new Font("Ebrima", 6);
                label1.Font = new Font("Ebrima", 17, FontStyle.Bold);
                label3.Font = new Font("Ebrima", 8);
                label8.Font = new Font("Ebrima", 8);
                label9.Font = new Font("Ebrima", 8);
                label11.Font = new Font("Ebrima", 8);
                label14.Font = new Font("Ink Free", 15);
                linkLabel1.Font = new Font("Ebrima", 8, FontStyle.Italic);
                button2.Font = new Font("Ebrima", 7);
                button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                clickcounter--;
                toolTip2.ToolTipTitle = "";
                toolTip3.ToolTipTitle = "zoomed out 100%";
            }

            else if (clickcounter == 3)// zoom out to 75%
            {
                this.Font = new Font("Ebrima", 8);
                label1.Font = new Font("Ebrima", 18, FontStyle.Bold);
                label3.Font = new Font("Ebrima", 10);
                label8.Font = new Font("Ebrima", 10);
                label9.Font = new Font("Ebrima", 10);
                label11.Font = new Font("Ebrima", 10);
                label14.Font = new Font("Ink Free", 20);
                linkLabel1.Font = new Font("Ebrima", 9, FontStyle.Italic);
                button2.Font = new Font("Ebrima", 9);
                button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                clickcounter--;
                toolTip2.ToolTipTitle = "zoomed in 25%";
                toolTip3.ToolTipTitle = "zoomed out 75%";
            }
            else if (clickcounter == 4)// zoom out to 50%
            {
                this.Font = new Font("Ebrima", 10);
                label1.Font = new Font("Ebrima", 23, FontStyle.Bold);
                label3.Font = new Font("Ebrima", 12);
                label8.Font = new Font("Ebrima", 12);
                label9.Font = new Font("Ebrima", 12);
                label11.Font = new Font("Ebrima", 12);
                label14.Font = new Font("Ink Free", 23);
                linkLabel1.Font = new Font("Ebrima", 10, FontStyle.Italic);
                button2.Font = new Font("Ebrima", 10);
                button1.Font = new Font("Ebrima", 13, FontStyle.Bold);
                clickcounter--;
                toolTip2.ToolTipTitle = "zoomed in 50%";
                toolTip3.ToolTipTitle = "zoomed out 50%";
            }

            else if (clickcounter == 5)// zoom out to 25%
            {
                this.Font = new Font("Ebrima", 12);
                label1.Font = new Font("Ebrima", 27, FontStyle.Bold);
                label3.Font = new Font("Ebrima", 14);
                label8.Font = new Font("Ebrima", 14);
                label9.Font = new Font("Ebrima", 14);
                label11.Font = new Font("Ebrima", 14);
                label14.Font = new Font("Ink Free", 27);
                linkLabel1.Font = new Font("Ebrima", 11, FontStyle.Italic);
                button2.Font = new Font("Ebrima", 11);
                button1.Font = new Font("Ebrima", 16, FontStyle.Bold);
                clickcounter--;
                toolTip2.ToolTipTitle = "zoomed in 75%";
                toolTip3.ToolTipTitle = "zoomed out 25%";
            }
            else if (clickcounter == 6)//zoom out to 0%
            {
                toolTip2.ToolTipTitle = "zoomed in 100%";
                toolTip3.ToolTipTitle = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 forgot_password = new Form3();
            forgot_password.ShowDialog();
        }
    }

}
