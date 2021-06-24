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
            this.btnSummary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoursTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUnapproved = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewTrip
            // 
            this.btnNewTrip.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTrip.Location = new System.Drawing.Point(162, 464);
            this.btnNewTrip.Name = "btnNewTrip";
            this.btnNewTrip.Size = new System.Drawing.Size(89, 23);
            this.btnNewTrip.TabIndex = 0;
            this.btnNewTrip.Text = "New Trip";
            this.btnNewTrip.UseVisualStyleBackColor = true;
            this.btnNewTrip.Click += new System.EventHandler(this.BtnNewTrip_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(13, 464);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(89, 23);
            this.btnSummary.TabIndex = 1;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "You have driven:";
            // 
            // lblHoursTotal
            // 
            this.lblHoursTotal.AutoSize = true;
            this.lblHoursTotal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursTotal.Location = new System.Drawing.Point(77, 42);
            this.lblHoursTotal.Name = "lblHoursTotal";
            this.lblHoursTotal.Size = new System.Drawing.Size(104, 28);
            this.lblHoursTotal.TabIndex = 3;
            this.lblHoursTotal.Text = "0 minutes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "0 Night hours total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "0 Daytime hours total";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 212);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recent Trips";
            // 
            // lblUnapproved
            // 
            this.lblUnapproved.AutoSize = true;
            this.lblUnapproved.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnapproved.Location = new System.Drawing.Point(75, 78);
            this.lblUnapproved.Name = "lblUnapproved";
            this.lblUnapproved.Size = new System.Drawing.Size(114, 13);
            this.lblUnapproved.TabIndex = 6;
            this.lblUnapproved.Text = "0 Unapproved Hours";
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(13, 434);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(238, 23);
            this.btnApprove.TabIndex = 7;
            this.btnApprove.Text = "Unapproved Trips";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.BtnApprove_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 499);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblUnapproved);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHoursTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnNewTrip);
            this.Name = "Home";
            this.Text = "Digital Logbook";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewTrip;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoursTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUnapproved;
        private System.Windows.Forms.Button btnApprove;
    }
}

