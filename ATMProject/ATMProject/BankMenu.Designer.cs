﻿namespace ATMProject
{
	partial class BankMenu
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 6;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(606, 324);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(154, 83);
			this.button1.TabIndex = 0;
			this.button1.Text = "Log in";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(43, 34);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(527, 76);
			this.button2.TabIndex = 2;
			this.button2.Text = "FREE CASH WITHDRAWALS";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(76, 116);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(461, 35);
			this.button3.TabIndex = 3;
			this.button3.Text = "You will not be charged for using this ATM";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(43, 229);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(527, 76);
			this.button4.TabIndex = 4;
			this.button4.Text = "MOBILE PHONE TOP-UP NOT AVAILABLE";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(89, 324);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(461, 35);
			this.button6.TabIndex = 6;
			this.button6.Text = "Insert your card and select log in to continue";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// BankMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ATMProject.Properties.Resources.backk;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "BankMenu";
			this.Text = "BankMenu";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
	}
}

