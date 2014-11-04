namespace CookieMonster
	{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnThrowAwayCookie = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lvCookieJar = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.lblCookieJarStatus = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel12 = new System.Windows.Forms.Panel();
			this.cbCookieFlavors = new System.Windows.Forms.ComboBox();
			this.btnBakeACookie = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCookieMakerStatus = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel11 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnPutBackCookie = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lvCookieMonster = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnEatCookie = new System.Windows.Forms.Button();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel12.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SeaGreen;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnThrowAwayCookie);
			this.panel2.Location = new System.Drawing.Point(12, 387);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(165, 41);
			this.panel2.TabIndex = 1;
			// 
			// btnThrowAwayCookie
			// 
			this.btnThrowAwayCookie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThrowAwayCookie.Location = new System.Drawing.Point(5, 5);
			this.btnThrowAwayCookie.Name = "btnThrowAwayCookie";
			this.btnThrowAwayCookie.Size = new System.Drawing.Size(154, 28);
			this.btnThrowAwayCookie.TabIndex = 1;
			this.btnThrowAwayCookie.Text = "Take Cookie && Throw Away!";
			this.btnThrowAwayCookie.UseVisualStyleBackColor = true;
			this.btnThrowAwayCookie.Click += new System.EventHandler(this.btnThrowAwayCookie_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Maroon;
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Controls.Add(this.lvCookieJar);
			this.panel7.Controls.Add(this.label2);
			this.panel7.Location = new System.Drawing.Point(363, 51);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(192, 377);
			this.panel7.TabIndex = 4;
			// 
			// lvCookieJar
			// 
			this.lvCookieJar.BackColor = System.Drawing.Color.IndianRed;
			this.lvCookieJar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
			this.lvCookieJar.Location = new System.Drawing.Point(7, 51);
			this.lvCookieJar.Name = "lvCookieJar";
			this.lvCookieJar.Size = new System.Drawing.Size(176, 307);
			this.lvCookieJar.TabIndex = 1;
			this.lvCookieJar.UseCompatibleStateImageBehavior = false;
			this.lvCookieJar.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Baked";
			this.columnHeader4.Width = 53;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Cookie Flavor";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 102;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gold;
			this.label2.Location = new System.Drawing.Point(3, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "Cookie Jar";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Salmon;
			this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel8.Controls.Add(this.lblCookieJarStatus);
			this.panel8.Location = new System.Drawing.Point(357, 15);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(203, 52);
			this.panel8.TabIndex = 5;
			// 
			// lblCookieJarStatus
			// 
			this.lblCookieJarStatus.Location = new System.Drawing.Point(14, 13);
			this.lblCookieJarStatus.Name = "lblCookieJarStatus";
			this.lblCookieJarStatus.Size = new System.Drawing.Size(174, 24);
			this.lblCookieJarStatus.TabIndex = 0;
			this.lblCookieJarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Silver;
			this.panel9.Controls.Add(this.panel12);
			this.panel9.Controls.Add(this.lblCookieMakerStatus);
			this.panel9.Controls.Add(this.label1);
			this.panel9.Location = new System.Drawing.Point(579, 15);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(203, 384);
			this.panel9.TabIndex = 6;
			// 
			// panel12
			// 
			this.panel12.BackColor = System.Drawing.Color.Gainsboro;
			this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel12.Controls.Add(this.cbCookieFlavors);
			this.panel12.Controls.Add(this.btnBakeACookie);
			this.panel12.Controls.Add(this.label3);
			this.panel12.Location = new System.Drawing.Point(12, 58);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(179, 113);
			this.panel12.TabIndex = 5;
			// 
			// cbCookieFlavors
			// 
			this.cbCookieFlavors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCookieFlavors.FormattingEnabled = true;
			this.cbCookieFlavors.Location = new System.Drawing.Point(18, 41);
			this.cbCookieFlavors.Name = "cbCookieFlavors";
			this.cbCookieFlavors.Size = new System.Drawing.Size(144, 21);
			this.cbCookieFlavors.Sorted = true;
			this.cbCookieFlavors.TabIndex = 2;
			// 
			// btnBakeACookie
			// 
			this.btnBakeACookie.Location = new System.Drawing.Point(18, 68);
			this.btnBakeACookie.Name = "btnBakeACookie";
			this.btnBakeACookie.Size = new System.Drawing.Size(144, 23);
			this.btnBakeACookie.TabIndex = 1;
			this.btnBakeACookie.Text = "Bake A Cookie";
			this.btnBakeACookie.UseVisualStyleBackColor = true;
			this.btnBakeACookie.Click += new System.EventHandler(this.btnBakeACookie_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(18, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "Cookie Flavor";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCookieMakerStatus
			// 
			this.lblCookieMakerStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCookieMakerStatus.Location = new System.Drawing.Point(12, 323);
			this.lblCookieMakerStatus.Name = "lblCookieMakerStatus";
			this.lblCookieMakerStatus.Size = new System.Drawing.Size(179, 40);
			this.lblCookieMakerStatus.TabIndex = 4;
			this.lblCookieMakerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cookie Maker";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(579, 405);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(203, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "DONE";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.SeaGreen;
			this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel11.Location = new System.Drawing.Point(12, 115);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(22, 149);
			this.panel11.TabIndex = 9;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SeaGreen;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(324, 115);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(22, 149);
			this.panel1.TabIndex = 10;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.SeaGreen;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.btnPutBackCookie);
			this.panel3.Location = new System.Drawing.Point(181, 387);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(165, 41);
			this.panel3.TabIndex = 2;
			// 
			// btnPutBackCookie
			// 
			this.btnPutBackCookie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPutBackCookie.Location = new System.Drawing.Point(4, 5);
			this.btnPutBackCookie.Name = "btnPutBackCookie";
			this.btnPutBackCookie.Size = new System.Drawing.Size(154, 28);
			this.btnPutBackCookie.TabIndex = 1;
			this.btnPutBackCookie.Text = "Take Cookie && Put Back!";
			this.btnPutBackCookie.UseVisualStyleBackColor = true;
			this.btnPutBackCookie.Click += new System.EventHandler(this.btnPutBackCookie_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Turquoise;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.lvCookieMonster);
			this.panel4.Location = new System.Drawing.Point(43, 116);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(271, 262);
			this.panel4.TabIndex = 11;
			// 
			// lvCookieMonster
			// 
			this.lvCookieMonster.BackColor = System.Drawing.Color.Aquamarine;
			this.lvCookieMonster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvCookieMonster.Location = new System.Drawing.Point(11, 13);
			this.lvCookieMonster.Name = "lvCookieMonster";
			this.lvCookieMonster.Size = new System.Drawing.Size(247, 236);
			this.lvCookieMonster.TabIndex = 0;
			this.lvCookieMonster.UseCompatibleStateImageBehavior = false;
			this.lvCookieMonster.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Time";
			this.columnHeader1.Width = 57;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Action";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 77;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Cookie Flavor";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 92;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.MediumTurquoise;
			this.panel5.Controls.Add(this.btnEatCookie);
			this.panel5.Controls.Add(this.panel10);
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Location = new System.Drawing.Point(89, 15);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(185, 93);
			this.panel5.TabIndex = 12;
			// 
			// btnEatCookie
			// 
			this.btnEatCookie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEatCookie.Location = new System.Drawing.Point(18, 53);
			this.btnEatCookie.Name = "btnEatCookie";
			this.btnEatCookie.Size = new System.Drawing.Size(149, 28);
			this.btnEatCookie.TabIndex = 2;
			this.btnEatCookie.Text = "Take Cookie && Eat It!";
			this.btnEatCookie.UseVisualStyleBackColor = true;
			this.btnEatCookie.Click += new System.EventHandler(this.btnEatCookie_Click);
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Yellow;
			this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel10.Location = new System.Drawing.Point(109, 15);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(58, 23);
			this.panel10.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Yellow;
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Location = new System.Drawing.Point(18, 15);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(58, 23);
			this.panel6.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 440);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel11);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel9);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Cookie Monster Demo";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.panel2.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnThrowAwayCookie;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label lblCookieJarStatus;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbCookieFlavors;
		private System.Windows.Forms.Button btnBakeACookie;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lblCookieMakerStatus;
		private System.Windows.Forms.ListView lvCookieJar;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnPutBackCookie;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ListView lvCookieMonster;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnEatCookie;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel6;
		}
	}

