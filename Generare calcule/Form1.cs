using System.Text;

namespace Generare_calcule
{
    public partial class Form1 : Form
    {
        bool ngb = true, inb = false;
        int Lv = 1, a, b, c;
        double d;
        void check()
        {
            if (textBox1.Text == "")
            {
                label2.Visible = false;
                label5.Visible = false;
                label8.Visible = false;
                label9.Visible = true;
                wait(5000);
                label9.Visible = false;
            }
            else
            if (vrn(textBox1.Text) == false)
            {
                label9.Visible = false;
                label2.Visible = false;
                label5.Visible = false;
                label8.Visible = true;

                wait(5000);
                label8.Visible = false;
            }
            else


                if (d == double.Parse(textBox1.Text))
            {
                label8.Visible = false;
                label2.Visible = false;
                label9.Visible = false;
                label5.Visible = true;
                generate();
                wait(5000);
                label5.Visible = false;
            }
            else
            {
                label8.Visible = false;
                label5.Visible = false;
                label9.Visible = false;
                label2.Visible = true;
                wait(5000);
                label2.Visible = false;
            }
        }
        bool vrn(string x)
        {
            int i = 0, np = 0, nn = 0;
            if (x[i] >= '0' && x[i] <= '9')
                nn++;
            if ((x[i] < '0' || x[i] > '9') && (x[i] != '-' && x[i] != '.'))
                return false;
            for (i = 1; i < x.Length; i++)
            {
                if (x[i] == '.')
                    np++;
                else
                    nn++;
                if ((x[i] < '0' || x[i] > '9') && (x[i] != '.'))
                    return false;
            }
            if (np > 1 || nn == 0)
                return false;
            return true;
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        void generate()
        {
            int emi, ema;
            if (Lv == 1)
            {
                emi = 0;
                ema = 10;
            }
            else
            if (Lv == 2)
            {
                emi = 0;
                ema = 100;
            }
            else
            {
                emi = 0;
                ema = 1000;
            }
            if (ngb == true)
            {
                emi = 0 - ema;
            }
            Random rnd = new Random();
            a = rnd.Next(emi, ema);
            b = rnd.Next(emi, ema);
            c = rnd.Next(0, 4);
            if (c == 1 && ngb == false && a - b < 0)
            {
                int aux = a;
                a = b;
                b = aux;
            }
            if (c == 3)
            {
                if (b == 0)
                    b++;
                if (inb == true && a % b != 0)
                {
                    a = a / b * b;
                }
            }


            switch (c)
            {
                case 0:
                    label1.Text = a.ToString() + " + " + b.ToString() + "= ";
                    d = a + b;
                    break;
                case 1:
                    label1.Text = a.ToString() + " - " + b.ToString() + "= ";
                    d = a - b;
                    break;
                case 2:
                    label1.Text = a.ToString() + " * " + b.ToString() + "= ";
                    d = a * b;
                    break;
                case 3:
                    label1.Text = a.ToString() + " / " + b.ToString() + "= ";
                    d = (double)(a * 100 / b) / 100;
                    break;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate();
        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            check();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox1.Text[textBox1.Text.Length - 1] == '\n')
            {
                /*StringBuilder s= new StringBuilder(textBox1.Text);
                s[s.Length - 1] = '\0';
                textBox1.Text = s.ToString();  
                check();
                textBox1.Text = "";
            }*/
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }




        /// <summary>
        /// Here starts the menu function
        /// </summary>

        bool menuopen = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuopen == false)
            {
                //pictureBox1.BackColor = Color.White;
                pictureBox2.Size = new Size(275, 650);
                label6.Visible = true;
                checkBox1.Visible = true;
                NegChk.Visible = true;
                menuopen = true;
                button5.Visible = true;
                checkBox2.Visible = true;
                label3.Visible = true;
                for (int i = 1; i <= 60; i++)
                {
                    pictureBox2.Location = new Point(-275 + 275 * i / 60, 0);
                    label6.Location = new Point(-275 + 287 * i / 60, 15);
                    NegChk.Location = new Point(-275 + 287 * i / 60, 95);
                    checkBox1.Location = new Point(-275 + 287 * i / 60, 142);
                    button5.Location = new Point(-275 + 287 * i / 60, 556);
                    pictureBox1.Location = new Point(12 + 263 * i / 60, 12);
                    label3.Location = new Point(-275 + 287 * i / 60, 186);
                    checkBox2.Location = new Point(-275 + 287 * i / 60, 347);
                    wait(100 / 60);
                }
                if (difmenu == true)
                {
                    label3.Text = "▲ Difficulty ▲";
                    //pictureBox3.Visible = true;
                    lbes.Visible = true;
                    lbes.BringToFront();
                    label7.Visible = true;
                    label11.Visible = true;
                    if (Lv == 1)
                    {
                        pictureBox3.Visible = true;
                        pictureBox7.Visible = true;
                        pictureBox8.Visible = true;
                    }
                    else
                        if (Lv == 2)
                    {
                        pictureBox5.Visible = true;
                        pictureBox6.Visible = true;
                        pictureBox8.Visible = true;
                    }
                    else
                    {
                        pictureBox4.Visible = true;
                        pictureBox6.Visible = true;
                        pictureBox7.Visible = true;
                    }
                }

            }
            else
            {
                menuopen = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                lbes.Visible = false;
                label7.Visible = false;
                label11.Visible = false;
                for (int i = 1; i <= 60; i++)
                {

                    pictureBox2.Location = new Point(0 - 275 * i / 60, 0);
                    label6.Location = new Point(12 - 287 * i / 60, 15);
                    NegChk.Location = new Point(12 - 287 * i / 60, 95);
                    checkBox1.Location = new Point(12 - 287 * i / 60, 142);
                    button5.Location = new Point(12 - 287 * i / 60, 556);
                    pictureBox1.Location = new Point(275 - 263 * i / 60, 12);
                    label3.Location = new Point(12 - 287 * i / 60, 186);
                    checkBox2.Location = new Point(12 - 287 * i / 60, 347);
                    wait(100 / 60);
                }
                //pictureBox1.BackColor = Color.Transparent;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (NegChk.Checked == true)
            {
                ngb = true;
            }
            else
            {
                ngb = false;
            }
            generate();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                inb = true;
            }
            else
            {
                inb = false;
            }
            generate();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool difmenu = false;
        private void label3_Click(object sender, EventArgs e)
        {
            if (difmenu == false)
            {
                label3.Text = "▲ Difficulty ▲";
                //pictureBox3.Visible = true;
                lbes.Visible = true;
                lbes.BringToFront();
                label7.Visible = true;
                label11.Visible = true;
                difmenu = true;
                if (Lv == 1)
                {
                    pictureBox3.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                }
                else
                    if (Lv == 2)
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox8.Visible = true;
                }
                else
                {
                    pictureBox4.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                }
            }
            else
            {
                label3.Text = "▼ Difficulty ▼";
                difmenu = false;
                //pictureBox3.Visible = false;
                lbes.Visible = false;
                label7.Visible = false;
                label11.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            /// easy green
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            /// medium green
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            /// hard green
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            /// easy red
            Lv = 1;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox3.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            /// medium red
            Lv = 2;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = true;
            pictureBox5.Visible = true;
            pictureBox8.Visible = true;
            pictureBox7.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            /// hard red
            Lv = 3;
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox4.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                BackColor = Color.DimGray;
                button5.BackColor = Color.Black;
                button5.ForeColor = Color.White;
                label1.BackColor = Color.DimGray;
                label1.ForeColor = Color.White;
                textBox1.BackColor = Color.Black;
                textBox1.ForeColor = Color.White;
                button4.BackColor = Color.Black;
                button4.ForeColor = Color.White;
                pictureBox1.BackColor = Color.DimGray;
                label6.BackColor = Color.Black;
                label6.ForeColor = Color.White;
                checkBox2.BackColor = Color.Black;
                checkBox2.ForeColor = Color.White;
                checkBox1.BackColor = Color.Black;
                checkBox1.ForeColor = Color.White;
                NegChk.BackColor = Color.Black;
                NegChk.ForeColor = Color.White;
                label3.BackColor = Color.Black;
                label3.ForeColor = Color.White;
                lbes.BackColor = Color.Black;
                lbes.ForeColor = Color.White;
                label7.BackColor = Color.Black;
                label7.ForeColor = Color.White;
                label11.BackColor = Color.Black;
                label11.ForeColor = Color.White;
                label2.BackColor = Color.Black;
                pictureBox2.BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.LightGray;
                button5.BackColor = SystemColors.Control;
                button5.ForeColor = Color.Black;
                label1.BackColor = Color.LightGray;
                label1.ForeColor = Color.Black;
                textBox1.BackColor = Color.Silver;
                textBox1.ForeColor = Color.Black;
                button4.BackColor = Color.Silver;
                button4.ForeColor = Color.Black;
                pictureBox1.BackColor = Color.Transparent;
                label6.BackColor = SystemColors.Control;
                label6.ForeColor = Color.Black;
                checkBox2.BackColor = SystemColors.Control;
                checkBox2.ForeColor = Color.Black;
                checkBox1.BackColor = SystemColors.Control;
                checkBox1.ForeColor = Color.Black;
                NegChk.BackColor = SystemColors.Control;
                NegChk.ForeColor = Color.Black;
                label3.BackColor = SystemColors.Control;
                label3.ForeColor = Color.Black;
                lbes.BackColor = SystemColors.Control;
                lbes.ForeColor = Color.Black;
                label7.BackColor = SystemColors.Control;
                label7.ForeColor = Color.Black;
                label11.BackColor = SystemColors.Control;
                label11.ForeColor = Color.Black;
                label2.BackColor = SystemColors.Control;
                pictureBox2.BackColor = SystemColors.Control;
            }
        }
    }
}
