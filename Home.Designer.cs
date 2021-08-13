namespace DriversLogbookApp
{
    partial class Home
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
            this.btnNewTrip = new System.Windows.Forms.Button();
            this.lblYouHaveDriven = new System.Windows.Forms.Label();
            this.lblHoursTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNightTotal = new System.Windows.Forms.Label();
            this.lblDayTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLocalTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRuralTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHighwayTotal = new System.Windows.Forms.Label();
            this.lblUnapproved = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMedTotal = new System.Windows.Forms.Label();
            this.lblHeavyTotal = new System.Windows.Forms.Label();
            this.lblLightTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRainTotal = new System.Windows.Forms.Label();
            this.lblClearTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewTrip
            // 
            this.btnNewTrip.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTrip.Location = new System.Drawing.Point(65, 464);
            this.btnNewTrip.Name = "btnNewTrip";
            this.btnNewTrip.Size = new System.Drawing.Size(139, 23);
            this.btnNewTrip.TabIndex = 0;
            this.btnNewTrip.Text = "New Trip";
            this.btnNewTrip.UseVisualStyleBackColor = true;
            this.btnNewTrip.Click += new System.EventHandler(this.BtnNewTrip_Click);
            // 
            // lblYouHaveDriven
            // 
            this.lblYouHaveDriven.AutoSize = true;
            this.lblYouHaveDriven.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouHaveDriven.Location = new System.Drawing.Point(78, 20);
            this.lblYouHaveDriven.Name = "lblYouHaveDriven";
            this.lblYouHaveDriven.Size = new System.Drawing.Size(111, 19);
            this.lblYouHaveDriven.TabIndex = 2;
            this.lblYouHaveDriven.Text = "You have driven:";
            // 
            // lblHoursTotal
            // 
            this.lblHoursTotal.AutoSize = true;
            this.lblHoursTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursTotal.Location = new System.Drawing.Point(46, 39);
            this.lblHoursTotal.Name = "lblHoursTotal";
            this.lblHoursTotal.Size = new System.Drawing.Size(179, 28);
            this.lblHoursTotal.TabIndex = 3;
            this.lblHoursTotal.Text = "00:00 Total Hours";
            this.lblHoursTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNightTotal);
            this.groupBox1.Controls.Add(this.lblDayTotal);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time of Day";
            // 
            // lblNightTotal
            // 
            this.lblNightTotal.AutoSize = true;
            this.lblNightTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightTotal.Location = new System.Drawing.Point(15, 56);
            this.lblNightTotal.Name = "lblNightTotal";
            this.lblNightTotal.Size = new System.Drawing.Size(105, 17);
            this.lblNightTotal.TabIndex = 1;
            this.lblNightTotal.Text = "0 Night trips total";
            // 
            // lblDayTotal
            // 
            this.lblDayTotal.AutoSize = true;
            this.lblDayTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayTotal.Location = new System.Drawing.Point(15, 27);
            this.lblDayTotal.Name = "lblDayTotal";
            this.lblDayTotal.Size = new System.Drawing.Size(97, 17);
            this.lblDayTotal.TabIndex = 0;
            this.lblDayTotal.Text = "0 Day trips total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLocalTotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblRuralTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblHighwayTotal);
            this.groupBox2.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Road Types";
            // 
            // lblLocalTotal
            // 
            this.lblLocalTotal.AutoSize = true;
            this.lblLocalTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalTotal.Location = new System.Drawing.Point(103, 24);
            this.lblLocalTotal.Name = "lblLocalTotal";
            this.lblLocalTotal.Size = new System.Drawing.Size(24, 28);
            this.lblLocalTotal.TabIndex = 6;
            this.lblLocalTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Rural";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Local";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "0";
            // 
            // lblRuralTotal
            // 
            this.lblRuralTotal.AutoSize = true;
            this.lblRuralTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuralTotal.Location = new System.Drawing.Point(172, 24);
            this.lblRuralTotal.Name = "lblRuralTotal";
            this.lblRuralTotal.Size = new System.Drawing.Size(24, 28);
            this.lblRuralTotal.TabIndex = 2;
            this.lblRuralTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Highway";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lblHighwayTotal
            // 
            this.lblHighwayTotal.AutoSize = true;
            this.lblHighwayTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighwayTotal.Location = new System.Drawing.Point(36, 24);
            this.lblHighwayTotal.Name = "lblHighwayTotal";
            this.lblHighwayTotal.Size = new System.Drawing.Size(24, 28);
            this.lblHighwayTotal.TabIndex = 0;
            this.lblHighwayTotal.Text = "0";
            // 
            // lblUnapproved
            // 
            this.lblUnapproved.AutoSize = true;
            this.lblUnapproved.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnapproved.Location = new System.Drawing.Point(64, 74);
            this.lblUnapproved.Name = "lblUnapproved";
            this.lblUnapproved.Size = new System.Drawing.Size(135, 13);
            this.lblUnapproved.TabIndex = 6;
            this.lblUnapproved.Text = "00:00 Unapproved Hours";
            this.lblUnapproved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblMedTotal);
            this.groupBox3.Controls.Add(this.lblHeavyTotal);
            this.groupBox3.Controls.Add(this.lblLightTotal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(13, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 91);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Traffic Levels";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(165, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Heavy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Medium";
            // 
            // lblMedTotal
            // 
            this.lblMedTotal.AutoSize = true;
            this.lblMedTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedTotal.Location = new System.Drawing.Point(105, 25);
            this.lblMedTotal.Name = "lblMedTotal";
            this.lblMedTotal.Size = new System.Drawing.Size(24, 28);
            this.lblMedTotal.TabIndex = 8;
            this.lblMedTotal.Text = "0";
            // 
            // lblHeavyTotal
            // 
            this.lblHeavyTotal.AutoSize = true;
            this.lblHeavyTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeavyTotal.Location = new System.Drawing.Point(172, 25);
            this.lblHeavyTotal.Name = "lblHeavyTotal";
            this.lblHeavyTotal.Size = new System.Drawing.Size(24, 28);
            this.lblHeavyTotal.TabIndex = 7;
            this.lblHeavyTotal.Text = "0";
            // 
            // lblLightTotal
            // 
            this.lblLightTotal.AutoSize = true;
            this.lblLightTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightTotal.Location = new System.Drawing.Point(36, 25);
            this.lblLightTotal.Name = "lblLightTotal";
            this.lblLightTotal.Size = new System.Drawing.Size(24, 28);
            this.lblLightTotal.TabIndex = 6;
            this.lblLightTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Light";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblRainTotal);
            this.groupBox4.Controls.Add(this.lblClearTotal);
            this.groupBox4.Location = new System.Drawing.Point(13, 387);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 65);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Weather";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Clear";
            // 
            // lblRainTotal
            // 
            this.lblRainTotal.AutoSize = true;
            this.lblRainTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRainTotal.Location = new System.Drawing.Point(122, 23);
            this.lblRainTotal.Name = "lblRainTotal";
            this.lblRainTotal.Size = new System.Drawing.Size(24, 28);
            this.lblRainTotal.TabIndex = 11;
            this.lblRainTotal.Text = "0";
            // 
            // lblClearTotal
            // 
            this.lblClearTotal.AutoSize = true;
            this.lblClearTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearTotal.Location = new System.Drawing.Point(26, 23);
            this.lblClearTotal.Name = "lblClearTotal";
            this.lblClearTotal.Size = new System.Drawing.Size(24, 28);
            this.lblClearTotal.TabIndex = 12;
            this.lblClearTotal.Text = "0";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 499);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblUnapproved);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHoursTotal);
            this.Controls.Add(this.lblYouHaveDriven);
            this.Controls.Add(this.btnNewTrip);
            this.Name = "Home";
            this.Text = "Digital Logbook";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewTrip;
        private System.Windows.Forms.Label lblYouHaveDriven;
        private System.Windows.Forms.Label lblHoursTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNightTotal;
        private System.Windows.Forms.Label lblDayTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUnapproved;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRuralTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHighwayTotal;
        private System.Windows.Forms.Label lblLocalTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMedTotal;
        private System.Windows.Forms.Label lblHeavyTotal;
        private System.Windows.Forms.Label lblLightTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRainTotal;
        private System.Windows.Forms.Label lblClearTotal;
    }
}

