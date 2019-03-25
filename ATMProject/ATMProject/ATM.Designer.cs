namespace ATMProject
{
	partial class ATM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PINbox = new System.Windows.Forms.TextBox();
            this.numberDisplay = new System.Windows.Forms.TextBox();
            this.d6 = new System.Windows.Forms.TextBox();
            this.d5 = new System.Windows.Forms.TextBox();
            this.d4 = new System.Windows.Forms.TextBox();
            this.d3 = new System.Windows.Forms.TextBox();
            this.d2 = new System.Windows.Forms.TextBox();
            this.d1 = new System.Windows.Forms.TextBox();
            this.mainDisplay = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enterBut = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.clearBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butA = new System.Windows.Forms.Button();
            this.butB = new System.Windows.Forms.Button();
            this.butC = new System.Windows.Forms.Button();
            this.butD = new System.Windows.Forms.Button();
            this.butE = new System.Windows.Forms.Button();
            this.butF = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::ATMProject.Properties.Resources.backk;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.PINbox);
            this.panel1.Controls.Add(this.numberDisplay);
            this.panel1.Controls.Add(this.d6);
            this.panel1.Controls.Add(this.d5);
            this.panel1.Controls.Add(this.d4);
            this.panel1.Controls.Add(this.d3);
            this.panel1.Controls.Add(this.d2);
            this.panel1.Controls.Add(this.d1);
            this.panel1.Controls.Add(this.mainDisplay);
            this.panel1.Location = new System.Drawing.Point(81, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 309);
            this.panel1.TabIndex = 0;
            // 
            // PINbox
            // 
            this.PINbox.BackColor = System.Drawing.Color.White;
            this.PINbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PINbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINbox.Location = new System.Drawing.Point(294, 233);
            this.PINbox.Name = "PINbox";
            this.PINbox.Size = new System.Drawing.Size(259, 40);
            this.PINbox.TabIndex = 8;
            this.PINbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberDisplay
            // 
            this.numberDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberDisplay.Location = new System.Drawing.Point(294, 233);
            this.numberDisplay.Name = "numberDisplay";
            this.numberDisplay.Size = new System.Drawing.Size(253, 31);
            this.numberDisplay.TabIndex = 7;
            // 
            // d6
            // 
            this.d6.BackColor = System.Drawing.Color.White;
            this.d6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d6.Location = new System.Drawing.Point(473, 183);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(338, 33);
            this.d6.TabIndex = 6;
            this.d6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d5
            // 
            this.d5.BackColor = System.Drawing.Color.White;
            this.d5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d5.Location = new System.Drawing.Point(473, 133);
            this.d5.Name = "d5";
            this.d5.Size = new System.Drawing.Size(338, 33);
            this.d5.TabIndex = 5;
            this.d5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.Color.White;
            this.d4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4.Location = new System.Drawing.Point(473, 83);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(338, 33);
            this.d4.TabIndex = 4;
            this.d4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.Color.White;
            this.d3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3.Location = new System.Drawing.Point(33, 183);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(338, 33);
            this.d3.TabIndex = 3;
            this.d3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.Color.White;
            this.d2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2.Location = new System.Drawing.Point(33, 130);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(338, 33);
            this.d2.TabIndex = 2;
            this.d2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.Color.White;
            this.d1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Location = new System.Drawing.Point(33, 80);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(338, 33);
            this.d1.TabIndex = 1;
            this.d1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainDisplay
            // 
            this.mainDisplay.BackColor = System.Drawing.Color.White;
            this.mainDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDisplay.Location = new System.Drawing.Point(139, 19);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(576, 31);
            this.mainDisplay.TabIndex = 0;
            this.mainDisplay.Text = "Please enter your account number:";
            this.mainDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::ATMProject.Properties.Resources.metpad;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.enterBut);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.clearBut);
            this.panel2.Controls.Add(this.cancelBut);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(320, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 295);
            this.panel2.TabIndex = 1;
            // 
            // enterBut
            // 
            this.enterBut.BackColor = System.Drawing.Color.Green;
            this.enterBut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.enterBut.FlatAppearance.BorderSize = 4;
            this.enterBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBut.Location = new System.Drawing.Point(370, 161);
            this.enterBut.Name = "enterBut";
            this.enterBut.Size = new System.Drawing.Size(145, 63);
            this.enterBut.TabIndex = 12;
            this.enterBut.Text = "ENTER";
            this.enterBut.UseVisualStyleBackColor = false;
            this.enterBut.Click += new System.EventHandler(this.enterBut_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::ATMProject.Properties.Resources.metpad;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button10.FlatAppearance.BorderSize = 4;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.button10.Location = new System.Drawing.Point(145, 230);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 63);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // clearBut
            // 
            this.clearBut.BackColor = System.Drawing.Color.Gold;
            this.clearBut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.clearBut.FlatAppearance.BorderSize = 4;
            this.clearBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBut.Location = new System.Drawing.Point(370, 92);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(145, 63);
            this.clearBut.TabIndex = 11;
            this.clearBut.Text = "CLEAR";
            this.clearBut.UseVisualStyleBackColor = false;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // cancelBut
            // 
            this.cancelBut.BackColor = System.Drawing.Color.Red;
            this.cancelBut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cancelBut.FlatAppearance.BorderSize = 4;
            this.cancelBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBut.ForeColor = System.Drawing.Color.Black;
            this.cancelBut.Location = new System.Drawing.Point(370, 23);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(145, 63);
            this.cancelBut.TabIndex = 10;
            this.cancelBut.Text = "CANCEL";
            this.cancelBut.UseVisualStyleBackColor = false;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::ATMProject.Properties.Resources.metpad;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button9.FlatAppearance.BorderSize = 4;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(231, 161);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 63);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::ATMProject.Properties.Resources.metpad;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button8.FlatAppearance.BorderSize = 4;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(145, 161);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 63);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::ATMProject.Properties.Resources.metpad;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button7.FlatAppearance.BorderSize = 4;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(59, 161);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 63);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::ATMProject.Properties.Resources.metpad;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button6.FlatAppearance.BorderSize = 4;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(231, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 63);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::ATMProject.Properties.Resources.metpad;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatAppearance.BorderSize = 4;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(145, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 63);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ATMProject.Properties.Resources.metpad;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(59, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ATMProject.Properties.Resources.metpad;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(231, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(145, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butA
            // 
            this.butA.BackColor = System.Drawing.Color.Transparent;
            this.butA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butA.BackgroundImage")));
            this.butA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butA.FlatAppearance.BorderSize = 0;
            this.butA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.butA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butA.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butA.ForeColor = System.Drawing.Color.Transparent;
            this.butA.Location = new System.Drawing.Point(0, 92);
            this.butA.Name = "butA";
            this.butA.Size = new System.Drawing.Size(75, 44);
            this.butA.TabIndex = 2;
            this.butA.UseVisualStyleBackColor = false;
            this.butA.Click += new System.EventHandler(this.butA_Click);
            // 
            // butB
            // 
            this.butB.BackColor = System.Drawing.Color.Transparent;
            this.butB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butB.BackgroundImage")));
            this.butB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butB.FlatAppearance.BorderSize = 0;
            this.butB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.butB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butB.Location = new System.Drawing.Point(0, 142);
            this.butB.Name = "butB";
            this.butB.Size = new System.Drawing.Size(75, 44);
            this.butB.TabIndex = 3;
            this.butB.UseVisualStyleBackColor = false;
            this.butB.Click += new System.EventHandler(this.butB_Click);
            // 
            // butC
            // 
            this.butC.BackColor = System.Drawing.Color.Transparent;
            this.butC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butC.BackgroundImage")));
            this.butC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butC.FlatAppearance.BorderSize = 0;
            this.butC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.butC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butC.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butC.Location = new System.Drawing.Point(0, 192);
            this.butC.Name = "butC";
            this.butC.Size = new System.Drawing.Size(75, 44);
            this.butC.TabIndex = 4;
            this.butC.UseVisualStyleBackColor = false;
            this.butC.Click += new System.EventHandler(this.butC_Click);
            // 
            // butD
            // 
            this.butD.BackColor = System.Drawing.Color.Transparent;
            this.butD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butD.BackgroundImage")));
            this.butD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butD.FlatAppearance.BorderSize = 0;
            this.butD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.butD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butD.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butD.Location = new System.Drawing.Point(928, 95);
            this.butD.Name = "butD";
            this.butD.Size = new System.Drawing.Size(75, 44);
            this.butD.TabIndex = 5;
            this.butD.UseVisualStyleBackColor = false;
            this.butD.Click += new System.EventHandler(this.butD_Click);
            // 
            // butE
            // 
            this.butE.BackColor = System.Drawing.Color.Transparent;
            this.butE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butE.BackgroundImage")));
            this.butE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butE.FlatAppearance.BorderSize = 0;
            this.butE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.butE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butE.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butE.Location = new System.Drawing.Point(928, 145);
            this.butE.Name = "butE";
            this.butE.Size = new System.Drawing.Size(75, 44);
            this.butE.TabIndex = 6;
            this.butE.UseVisualStyleBackColor = false;
            this.butE.Click += new System.EventHandler(this.butE_Click);
            // 
            // butF
            // 
            this.butF.BackColor = System.Drawing.Color.Transparent;
            this.butF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butF.BackgroundImage")));
            this.butF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butF.FlatAppearance.BorderSize = 0;
            this.butF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.butF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butF.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butF.Location = new System.Drawing.Point(928, 195);
            this.butF.Name = "butF";
            this.butF.Size = new System.Drawing.Size(75, 44);
            this.butF.TabIndex = 7;
            this.butF.UseVisualStyleBackColor = false;
            this.butF.Click += new System.EventHandler(this.butF_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::ATMProject.Properties.Resources.brushedM;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 337);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1003, 320);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1003, 654);
            this.Controls.Add(this.butF);
            this.Controls.Add(this.butE);
            this.Controls.Add(this.butD);
            this.Controls.Add(this.butC);
            this.Controls.Add(this.butB);
            this.Controls.Add(this.butA);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ATM";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox d6;
		private System.Windows.Forms.TextBox d5;
		private System.Windows.Forms.TextBox d4;
		private System.Windows.Forms.TextBox d3;
		private System.Windows.Forms.TextBox d2;
		private System.Windows.Forms.TextBox d1;
		private System.Windows.Forms.TextBox mainDisplay;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button butA;
		private System.Windows.Forms.Button butB;
		private System.Windows.Forms.Button butC;
		private System.Windows.Forms.Button butD;
		private System.Windows.Forms.Button butE;
		private System.Windows.Forms.Button butF;
		private System.Windows.Forms.TextBox numberDisplay;
		private System.Windows.Forms.Button enterBut;
		private System.Windows.Forms.Button clearBut;
		private System.Windows.Forms.Button cancelBut;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.TextBox PINbox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}