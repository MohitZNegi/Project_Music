using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project_Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCaptcha();
        }
        int clickcounter = 1;
        int number = 0;
        
        
        private void LoadCaptcha()
        {

            Random refresh = new Random();
            number = refresh.Next(5, 6 );
            int capnum = 0;
            string captcha = "";

            do
            {
                
                int chr = refresh.Next(48, 123);
                if ((chr >= 48 && chr <= 57) ||( chr >= 97 && chr <= 123) || (chr >= 65 && chr <= 90))
                {
                    captcha = captcha + (char)chr;
                    capnum++;
                    if (capnum == number)
                        break;

                }
            }
            while (true);
            label14.Text =captcha.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadCaptcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            char let;
            string email = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            string NZ_Mobile = (@"^[0-9]{10}$");

            if (textBox1.Text == "")
            {
                MessageBox.Show("*First Name can't be empty*");
                textBox1.BackColor = Color.OrangeRed;
                textBox1.Focus();

            }
            else if (int.TryParse(textBox1.Text, out num) == true)
            {
                MessageBox.Show("*First Name can't contain numbers/symbols*");
                textBox1.BackColor = Color.OrangeRed;
                textBox1.Focus();

            }
            else if (char.TryParse(textBox1.Text, out let) == true)
            {
                MessageBox.Show("*First Name can't contain numbers/symbols*");
                textBox1.BackColor = Color.OrangeRed;
                textBox1.Focus();

            }
            else if (textBox2.Text == "")
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("*Last Name needs to be filled*");
                textBox2.BackColor = Color.OrangeRed;
                textBox2.Focus();
            }
            else if (int.TryParse(textBox2.Text, out num) == true)
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("*Last Name can't contain numbers/symbols*");
                textBox2.BackColor = Color.OrangeRed;
                textBox2.Focus();

            }
            else if (char.TryParse(textBox2.Text, out let) == true)
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("*Last Name can't contain numbers/symbols*");
                textBox2.BackColor = Color.OrangeRed;
                textBox2.Focus();

            }
            else if (dateTimePicker1.Value > DateTime.Today)
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("*Please select a vaild Date of Birth*");

            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("*Please select a country*");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("*Please enter a UserName*");
                textBox6.BackColor = Color.OrangeRed;
                textBox6.Focus();

            }
            else if (textBox6.Text.Length < 6)
            {
                MessageBox.Show("*UserName must be atleast 6 characters long.*");
                textBox6.BackColor = Color.OrangeRed;
                textBox6.Focus();

            }
            else if (textBox5.Text == "")
            {

                textBox6.BackColor = Color.White;
                MessageBox.Show("*Email Address required*");
                textBox5.BackColor = Color.OrangeRed;
                textBox5.Focus();
            }
            else if (Regex.IsMatch(textBox5.Text, email) == false)
            {
                textBox6.BackColor = Color.White;
                MessageBox.Show("*Please enter a vaild email address*");
                textBox5.BackColor = Color.OrangeRed;
                textBox5.Focus();
            }
            else if (textBox4.Text == "")
            {
                textBox5.BackColor = Color.White;
                MessageBox.Show("*Please enter a password*");
                textBox4.BackColor = Color.OrangeRed;
                textBox4.Focus();

            }
            else if (textBox4.Text.Length < 10)
            {
                textBox5.BackColor = Color.White;
                MessageBox.Show("*Password must be atleast 10 characters long.*");
                textBox4.BackColor = Color.OrangeRed;
                textBox4.Focus();

            }
            else if (textBox7.Text == "")
            {
                textBox4.BackColor = Color.White;
                MessageBox.Show("*Please confirm your password*");
                textBox7.BackColor = Color.OrangeRed;
                textBox7.Focus();
            }
            else if (textBox4.Text != textBox7.Text)
            {
                textBox4.BackColor = Color.White;
                MessageBox.Show("*Confirmed Password does not match*");
                textBox7.BackColor = Color.OrangeRed;
                textBox7.Focus();
            }
            else if (checkBox1.Checked == false)
            {
                textBox7.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                MessageBox.Show("Please read the Privacy Policy.");
                checkBox1.Focus();
            }
            else if (textBox8.Text != label14.Text.ToString())
            {
                textBox7.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                MessageBox.Show("Please enter the CAPTCHA correctly.");
                textBox8.BackColor = Color.OrangeRed;
                textBox8.Focus();
            }
            else if (textBox3.Text == "")
            {
                textBox3.Text = "N/A";
            }
            else if (int.TryParse(textBox3.Text, out num) == false && textBox3.Text != "N/A")
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("*Mobile number can't contain letters/symbols*");
                textBox3.BackColor = Color.OrangeRed;
                textBox3.Focus();
            }
            else if (char.TryParse(textBox3.Text, out let) == true && textBox3.Text != "N/A")
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("*Mobile number can't contain letters/symbols*");
                textBox3.BackColor = Color.OrangeRed;
                textBox3.Focus();

            }
            else if (Regex.IsMatch(textBox3.Text, NZ_Mobile) == false && textBox3.Text != "N/A")
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("*Please enter a valid Mobile number of ten digits " +
                    "\n                     and must start with 0*");
                textBox3.BackColor = Color.OrangeRed;
                textBox3.Focus();

            }

            else
            {
                
              
                    Registration sign_up = new Registration(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToShortDateString(), textBox3.Text, comboBox1.Text, textBox6.Text, textBox5.Text, textBox4.Text);
                    resetFields();
                    Form2 login = new Form2();
                    login.ShowDialog();
                    this.Hide();
                
     

            }


        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
 
            Form2 login = new Form2();
            login.ShowDialog();
            this.Hide();
            
        }

        void resetFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            comboBox1.Text = "Select one";

            dateTimePicker1.Text = "1 / 01 / 2000";

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            comboBox1.BackColor = Color.LightGray;

        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            // initially form size is this and its zoomed in 0% and zoomed out 100%
            this.Font = new Font("Ebrima", 5);
            label1.Font = new Font("Ebrima", 17, FontStyle.Bold);
            label2.Font = new Font("Ebrima", 6);
            label3.Font = new Font("Ebrima", 6);
            label4.Font = new Font("Ebrima", 6);
            label5.Font = new Font("Ebrima", 6);
            label6.Font = new Font("Ebrima", 6);
            label7.Font = new Font("Ebrima", 6);
            label8.Font = new Font("Ebrima", 6);
            label9.Font = new Font("Ebrima", 6);
            label10.Font = new Font("Ebrima", 6);
            label11.Font = new Font("Ebrima", 6);
            label12.Font = new Font("Ebrima", 6);
            label13.Font = new Font("Ebrima", 6);
            label14.Font = new Font("Ink Free", 25);
            linkLabel1.Font = new Font("Ebrima", 8, FontStyle.Italic);
            groupBox1.Font = new Font("Ebrima", 7, FontStyle.Bold | FontStyle.Underline);
            groupBox2.Font = new Font("Ebrima", 7, FontStyle.Bold | FontStyle.Underline);
            groupBox3.Font = new Font("Ebrima", 7, FontStyle.Bold | FontStyle.Underline);
            button2.Font = new Font("Ebrima", 7);
            button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
            


        }


        private void pictureBox2_Click(object sender, EventArgs e)
        { // every time the zoom in picturebox is clicked the form will be zoomed in 25%.

            if (clickcounter == 1)// zoom in to 25%
            {
                this.Font = new Font("Ebrima", 6);
                label1.Font = new Font("Ebrima", 18, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 7);
                label3.Font = new Font("Ebrima", 7);
                label4.Font = new Font("Ebrima", 7);
                label5.Font = new Font("Ebrima", 7);
                label6.Font = new Font("Ebrima", 7);
                label7.Font = new Font("Ebrima", 7);
                label8.Font = new Font("Ebrima", 7);
                label9.Font = new Font("Ebrima", 7);
                label10.Font = new Font("Ebrima", 7);
                label11.Font = new Font("Ebrima", 7);
                label12.Font = new Font("Ebrima", 7);
                label13.Font = new Font("Ebrima", 7);
                label14.Font = new Font("Ink Free", 30);
                linkLabel1.Font = new Font("Ebrima", 8, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 8, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 8, FontStyle.Bold | FontStyle.Underline);
                groupBox3.Font = new Font("Ebrima", 8, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 8);
                button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 25%";
                toolTip2.ToolTipTitle = "zoomed out 75%";

            }
            else if (clickcounter == 2)// zoom in to 50%
            {
                this.Font = new Font("Ebrima", 7);
                label1.Font = new Font("Ebrima", 20, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 8);
                label3.Font = new Font("Ebrima", 8);
                label4.Font = new Font("Ebrima", 8);
                label5.Font = new Font("Ebrima", 8);
                label6.Font = new Font("Ebrima", 8);
                label7.Font = new Font("Ebrima", 8);
                label8.Font = new Font("Ebrima", 8);
                label9.Font = new Font("Ebrima", 8);
                label10.Font = new Font("Ebrima", 8);
                label11.Font = new Font("Ebrima", 8);
                label12.Font = new Font("Ebrima", 8);
                label13.Font = new Font("Ebrima", 8);
                label14.Font = new Font("Ink Free", 33);
                linkLabel1.Font = new Font("Ebrima", 9, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 9, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 9, FontStyle.Bold | FontStyle.Underline);
                groupBox3.Font = new Font("Ebrima", 9, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 9);
                button1.Font = new Font("Ebrima", 11, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 50%";
                toolTip2.ToolTipTitle = "zoomed out 50%";
            }

            else if (clickcounter == 3) // zoom in to 75%
            {
                this.Font = new Font("Ebrima", 8);
                label1.Font = new Font("Ebrima", 22, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 9);
                label3.Font = new Font("Ebrima", 9);
                label4.Font = new Font("Ebrima", 9);
                label5.Font = new Font("Ebrima", 9);
                label6.Font = new Font("Ebrima", 9);
                label7.Font = new Font("Ebrima", 9);
                label8.Font = new Font("Ebrima", 9);
                label9.Font = new Font("Ebrima", 9);
                label10.Font = new Font("Ebrima", 9);
                label11.Font = new Font("Ebrima", 9);
                label12.Font = new Font("Ebrima", 9);
                label13.Font = new Font("Ebrima", 9);
                label14.Font = new Font("Ink Free", 37);
                linkLabel1.Font = new Font("Ebrima", 10, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 10, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 10, FontStyle.Bold | FontStyle.Underline);
                groupBox3.Font = new Font("Ebrima", 10, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 10);
                button1.Font = new Font("Ebrima", 12, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 75%";
                toolTip2.ToolTipTitle = "zoomed out 25%";
            }
            else if (clickcounter == 4)// zoom in to 100%
            {
                this.Font = new Font("Ebrima", 9);
                label1.Font = new Font("Ebrima", 26, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 10);
                label3.Font = new Font("Ebrima", 10);
                label4.Font = new Font("Ebrima", 10);
                label5.Font = new Font("Ebrima", 10);
                label6.Font = new Font("Ebrima", 10);
                label7.Font = new Font("Ebrima", 10);
                label8.Font = new Font("Ebrima", 10);
                label9.Font = new Font("Ebrima", 10);
                label10.Font = new Font("Ebrima", 10);
                label11.Font = new Font("Ebrima", 10);
                label12.Font = new Font("Ebrima", 10);
                label13.Font = new Font("Ebrima", 10);
                label14.Font = new Font("Ink Free", 42);
                linkLabel1.Font = new Font("Ebrima", 11, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 11, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 11, FontStyle.Bold | FontStyle.Underline);
                groupBox3.Font = new Font("Ebrima", 11, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 11);
                button1.Font = new Font("Ebrima", 13, FontStyle.Bold);
                clickcounter++;
                toolTip1.ToolTipTitle = "zoomed in 100%";
                toolTip2.ToolTipTitle = "";
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        { // every time the zoom out picturebox is clicked the form will be zoomed out 25%.

            if(clickcounter == 2)//zoom out to 100%
            {

                this.Font = new Font("Ebrima", 5);
                label1.Font = new Font("Ebrima", 17, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 6);
                label3.Font = new Font("Ebrima", 6);
                label4.Font = new Font("Ebrima", 6);
                label5.Font = new Font("Ebrima", 6);
                label6.Font = new Font("Ebrima", 6);
                label7.Font = new Font("Ebrima", 6);
                label8.Font = new Font("Ebrima", 6);
                label9.Font = new Font("Ebrima", 6);
                label10.Font = new Font("Ebrima", 6);
                label11.Font = new Font("Ebrima", 6);
                label12.Font = new Font("Ebrima", 6);
                label13.Font = new Font("Ebrima", 6);
                label14.Font = new Font("Ink Free", 25);
                linkLabel1.Font = new Font("Ebrima", 8, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 7, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 7, FontStyle.Bold | FontStyle.Underline);
                groupBox3.Font = new Font("Ebrima", 7, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 7);
                button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "";
                toolTip2.ToolTipTitle = "zoomed out 100%";
            }

            else if (clickcounter == 3)// zoom out to 75%
            {
                this.Font = new Font("Ebrima", 6);
                label1.Font = new Font("Ebrima", 17, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 7);
                label3.Font = new Font("Ebrima", 7);
                label4.Font = new Font("Ebrima", 7);
                label5.Font = new Font("Ebrima", 7);
                label6.Font = new Font("Ebrima", 7);
                label7.Font = new Font("Ebrima", 7);
                label8.Font = new Font("Ebrima", 7);
                label9.Font = new Font("Ebrima", 7);
                label10.Font = new Font("Ebrima", 7);
                label11.Font = new Font("Ebrima", 7);
                label12.Font = new Font("Ebrima", 7);
                label13.Font = new Font("Ebrima", 7);
                label14.Font = new Font("Ink Free", 30);
                linkLabel1.Font = new Font("Ebrima", 8, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 8, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 8, FontStyle.Bold | FontStyle.Underline);
                groupBox3.Font = new Font("Ebrima", 8, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 8);
                button1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 25%";
                toolTip2.ToolTipTitle = "zoomed out 75%";
            }
            else if (clickcounter == 4)// zoom out to 50%
            {
                this.Font = new Font("Ebrima", 7);
                label1.Font = new Font("Ebrima", 18, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 8);
                label3.Font = new Font("Ebrima", 8);
                label4.Font = new Font("Ebrima", 8);
                label5.Font = new Font("Ebrima", 8);
                label6.Font = new Font("Ebrima", 8);
                label7.Font = new Font("Ebrima", 8);
                label8.Font = new Font("Ebrima", 8);
                label9.Font = new Font("Ebrima", 8);
                label10.Font = new Font("Ebrima", 8);
                label11.Font = new Font("Ebrima", 8);
                label12.Font = new Font("Ebrima", 8);
                label13.Font = new Font("Ebrima", 8);
                label14.Font = new Font("Ink Free", 33);
                linkLabel1.Font = new Font("Ebrima", 9, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 9, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 9, FontStyle.Bold | FontStyle.Underline);
                groupBox3.Font = new Font("Ebrima", 9, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 9);
                button1.Font = new Font("Ebrima", 11, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 50%";
                toolTip2.ToolTipTitle = "zoomed out 50%";
            }

            else if (clickcounter == 5)// zoom out to 25%
            {
                this.Font = new Font("Ebrima", 8);
                label1.Font = new Font("Ebrima", 20, FontStyle.Bold);
                label2.Font = new Font("Ebrima", 9);
                label3.Font = new Font("Ebrima", 9);
                label4.Font = new Font("Ebrima", 9);
                label5.Font = new Font("Ebrima", 9);
                label6.Font = new Font("Ebrima", 9);
                label7.Font = new Font("Ebrima", 9);
                label8.Font = new Font("Ebrima", 9);
                label9.Font = new Font("Ebrima", 9);
                label10.Font = new Font("Ebrima", 9);
                label11.Font = new Font("Ebrima", 9);
                label12.Font = new Font("Ebrima", 9);
                label13.Font = new Font("Ebrima", 9);
                label14.Font = new Font("Ink Free", 37);
                linkLabel1.Font = new Font("Ebrima", 10, FontStyle.Italic);
                groupBox1.Font = new Font("Ebrima", 10, FontStyle.Bold | FontStyle.Underline);
                groupBox2.Font = new Font("Ebrima", 10, FontStyle.Bold | FontStyle.Underline);
                groupBox3.Font = new Font("Ebrima", 10, FontStyle.Bold | FontStyle.Underline);
                button2.Font = new Font("Ebrima", 10);
                button1.Font = new Font("Ebrima", 12, FontStyle.Bold);
                clickcounter--;
                toolTip1.ToolTipTitle = "zoomed in 75%";
                toolTip2.ToolTipTitle = "zoomed out 25%";
            }
            else if(clickcounter == 6)//zoom out to 0%
            {
                toolTip1.ToolTipTitle = "zoomed in 100%";
                toolTip2.ToolTipTitle = "";
            }
           
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            

        }

 
    }
}
