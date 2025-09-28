namespace Generare_calcule
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NegChk = new CheckBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            button4 = new Button();
            label8 = new Label();
            label9 = new Label();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            label3 = new Label();
            lbes = new Label();
            label7 = new Label();
            label11 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // NegChk
            // 
            NegChk.AutoSize = true;
            NegChk.BackColor = Color.White;
            NegChk.Checked = true;
            NegChk.CheckState = CheckState.Checked;
            NegChk.Font = new Font("Segoe UI", 20F);
            NegChk.Location = new Point(12, 95);
            NegChk.Name = "NegChk";
            NegChk.Size = new Size(248, 41);
            NegChk.TabIndex = 2;
            NegChk.Text = "negative numbers";
            NegChk.UseVisualStyleBackColor = false;
            NegChk.Visible = false;
            NegChk.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(398, 241);
            label1.Name = "label1";
            label1.Size = new Size(296, 54);
            label1.TabIndex = 3;
            label1.Text = "1000 + 1000= ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Font = new Font("Segoe UI", 30F);
            textBox1.Location = new Point(670, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 61);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label2.Location = new Point(461, 44);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(407, 72);
            label2.TabIndex = 8;
            label2.Text = "Wrong Answer";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.OliveDrab;
            label5.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label5.Location = new Point(474, 44);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(370, 72);
            label5.TabIndex = 9;
            label5.Text = "Right Answer";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            button4.Location = new Point(835, 241);
            button4.Name = "button4";
            button4.Size = new Size(183, 61);
            button4.TabIndex = 15;
            button4.Text = "check";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Yellow;
            label8.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label8.Location = new Point(398, 9);
            label8.Name = "label8";
            label8.Size = new Size(898, 144);
            label8.TabIndex = 16;
            label8.Text = "42601: invalid character\r\nPlease only use numbers or . and -\r\n";
            label8.Visible = false;
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Yellow;
            label9.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label9.Location = new Point(824, 9);
            label9.Name = "label9";
            label9.Size = new Size(472, 144);
            label9.TabIndex = 17;
            label9.Text = "65 (EX_DATAERR)\r\nExpected input";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 20F);
            button5.Location = new Point(12, 556);
            button5.Name = "button5";
            button5.Size = new Size(176, 43);
            button5.TabIndex = 19;
            button5.Text = "Leave app";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(-105, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 12);
            label6.Name = "label6";
            label6.Size = new Size(196, 34);
            label6.TabIndex = 22;
            label6.Text = "Calcul Generator";
            label6.Visible = false;
            label6.Click += label6_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Segoe UI", 20F);
            checkBox1.Location = new Point(12, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(192, 41);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Integer result";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.Visible = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(12, 186);
            label3.Name = "label3";
            label3.Size = new Size(182, 37);
            label3.TabIndex = 23;
            label3.Text = "▲ Difficulty ▲";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // lbes
            // 
            lbes.AutoSize = true;
            lbes.BackColor = Color.White;
            lbes.Font = new Font("Segoe UI", 20F);
            lbes.Location = new Point(12, 226);
            lbes.Name = "lbes";
            lbes.Size = new Size(69, 37);
            lbes.TabIndex = 25;
            lbes.Text = "Easy";
            lbes.Visible = false;
            lbes.Click += label4_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(12, 265);
            label7.Name = "label7";
            label7.Size = new Size(116, 37);
            label7.TabIndex = 26;
            label7.Text = "Medium";
            label7.Visible = false;
            label7.Click += label7_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 20F);
            label11.Location = new Point(12, 304);
            label11.Name = "label11";
            label11.Size = new Size(75, 37);
            label11.TabIndex = 27;
            label11.Text = "Hard";
            label11.Visible = false;
            label11.Click += label11_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LimeGreen;
            pictureBox3.Location = new Point(134, 226);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 37);
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LimeGreen;
            pictureBox4.Location = new Point(134, 304);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 37);
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.LimeGreen;
            pictureBox5.Location = new Point(134, 265);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 37);
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Red;
            pictureBox6.Location = new Point(134, 226);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 37);
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Red;
            pictureBox7.Location = new Point(134, 265);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(37, 37);
            pictureBox7.TabIndex = 32;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Red;
            pictureBox8.Location = new Point(134, 304);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(37, 37);
            pictureBox8.TabIndex = 33;
            pictureBox8.TabStop = false;
            pictureBox8.Visible = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.White;
            checkBox2.Font = new Font("Segoe UI", 20F);
            checkBox2.ForeColor = Color.Black;
            checkBox2.Location = new Point(12, 347);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(168, 41);
            checkBox2.TabIndex = 34;
            checkBox2.Text = "Dark Mode";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.Visible = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1304, 611);
            Controls.Add(checkBox2);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(lbes);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(NegChk);
            Controls.Add(checkBox1);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "mp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox NegChk;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label5;
        private Button button4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private CheckBox checkBox1;
        private Label label3;
        private Label lbes;
        private Label label7;
        private Label label11;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private CheckBox checkBox2;
    }
}
