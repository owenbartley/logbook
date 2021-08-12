namespace DriversLogbookApp
{
    partial class NewTrip
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
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxWeather = new System.Windows.Forms.GroupBox();
            this.chkBxRain = new System.Windows.Forms.CheckBox();
            this.chkBxClear = new System.Windows.Forms.CheckBox();
            this.grpBxTraffic = new System.Windows.Forms.GroupBox();
            this.chkBxHeavy = new System.Windows.Forms.CheckBox();
            this.chkBxMed = new System.Windows.Forms.CheckBox();
            this.chkBxLight = new System.Windows.Forms.CheckBox();
            this.grpBxRoad = new System.Windows.Forms.GroupBox();
            this.chkBxHighway = new System.Windows.Forms.CheckBox();
            this.chkBxRural = new System.Windows.Forms.CheckBox();
            this.chkBxLocal = new System.Windows.Forms.CheckBox();
            this.grpBxTime = new System.Windows.Forms.GroupBox();
            this.chkBxTime = new System.Windows.Forms.CheckBox();
            this.chkBxApproved = new System.Windows.Forms.CheckBox();
            this.grpBxWeather.SuspendLayout();
            this.grpBxTraffic.SuspendLayout();
            this.grpBxRoad.SuspendLayout();
            this.grpBxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(65, 97);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(129, 28);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(84, 40);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(94, 28);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "00:00:00";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(89, 68);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(83, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "00/00/0000";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Trip";
            // 
            // grpBxWeather
            // 
            this.grpBxWeather.Controls.Add(this.chkBxRain);
            this.grpBxWeather.Controls.Add(this.chkBxClear);
            this.grpBxWeather.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxWeather.Location = new System.Drawing.Point(13, 133);
            this.grpBxWeather.Name = "grpBxWeather";
            this.grpBxWeather.Size = new System.Drawing.Size(238, 64);
            this.grpBxWeather.TabIndex = 4;
            this.grpBxWeather.TabStop = false;
            this.grpBxWeather.Text = "Weather";
            // 
            // chkBxRain
            // 
            this.chkBxRain.AutoSize = true;
            this.chkBxRain.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxRain.Location = new System.Drawing.Point(137, 21);
            this.chkBxRain.Name = "chkBxRain";
            this.chkBxRain.Size = new System.Drawing.Size(72, 32);
            this.chkBxRain.TabIndex = 1;
            this.chkBxRain.Text = "Rain";
            this.chkBxRain.UseVisualStyleBackColor = true;
            // 
            // chkBxClear
            // 
            this.chkBxClear.AutoSize = true;
            this.chkBxClear.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxClear.Location = new System.Drawing.Point(30, 21);
            this.chkBxClear.Name = "chkBxClear";
            this.chkBxClear.Size = new System.Drawing.Size(79, 32);
            this.chkBxClear.TabIndex = 0;
            this.chkBxClear.Text = "Clear";
            this.chkBxClear.UseVisualStyleBackColor = true;
            this.chkBxClear.CheckedChanged += new System.EventHandler(this.ChkBxClear_CheckedChanged);
            // 
            // grpBxTraffic
            // 
            this.grpBxTraffic.Controls.Add(this.chkBxHeavy);
            this.grpBxTraffic.Controls.Add(this.chkBxMed);
            this.grpBxTraffic.Controls.Add(this.chkBxLight);
            this.grpBxTraffic.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxTraffic.Location = new System.Drawing.Point(13, 204);
            this.grpBxTraffic.Name = "grpBxTraffic";
            this.grpBxTraffic.Size = new System.Drawing.Size(238, 65);
            this.grpBxTraffic.TabIndex = 5;
            this.grpBxTraffic.TabStop = false;
            this.grpBxTraffic.Text = "Traffic Level";
            // 
            // chkBxHeavy
            // 
            this.chkBxHeavy.AutoSize = true;
            this.chkBxHeavy.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxHeavy.Location = new System.Drawing.Point(162, 32);
            this.chkBxHeavy.Name = "chkBxHeavy";
            this.chkBxHeavy.Size = new System.Drawing.Size(63, 19);
            this.chkBxHeavy.TabIndex = 2;
            this.chkBxHeavy.Text = "Heavy";
            this.chkBxHeavy.UseVisualStyleBackColor = true;
            // 
            // chkBxMed
            // 
            this.chkBxMed.AutoSize = true;
            this.chkBxMed.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxMed.Location = new System.Drawing.Point(79, 32);
            this.chkBxMed.Name = "chkBxMed";
            this.chkBxMed.Size = new System.Drawing.Size(75, 19);
            this.chkBxMed.TabIndex = 1;
            this.chkBxMed.Text = "Medium";
            this.chkBxMed.UseVisualStyleBackColor = true;
            // 
            // chkBxLight
            // 
            this.chkBxLight.AutoSize = true;
            this.chkBxLight.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxLight.Location = new System.Drawing.Point(12, 32);
            this.chkBxLight.Name = "chkBxLight";
            this.chkBxLight.Size = new System.Drawing.Size(58, 19);
            this.chkBxLight.TabIndex = 0;
            this.chkBxLight.Text = "Light";
            this.chkBxLight.UseVisualStyleBackColor = true;
            // 
            // grpBxRoad
            // 
            this.grpBxRoad.Controls.Add(this.chkBxHighway);
            this.grpBxRoad.Controls.Add(this.chkBxRural);
            this.grpBxRoad.Controls.Add(this.chkBxLocal);
            this.grpBxRoad.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxRoad.Location = new System.Drawing.Point(13, 276);
            this.grpBxRoad.Name = "grpBxRoad";
            this.grpBxRoad.Size = new System.Drawing.Size(118, 129);
            this.grpBxRoad.TabIndex = 6;
            this.grpBxRoad.TabStop = false;
            this.grpBxRoad.Text = "Road Type";
            // 
            // chkBxHighway
            // 
            this.chkBxHighway.AutoSize = true;
            this.chkBxHighway.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxHighway.Location = new System.Drawing.Point(12, 84);
            this.chkBxHighway.Name = "chkBxHighway";
            this.chkBxHighway.Size = new System.Drawing.Size(104, 32);
            this.chkBxHighway.TabIndex = 2;
            this.chkBxHighway.Text = "Highway";
            this.chkBxHighway.UseVisualStyleBackColor = true;
            this.chkBxHighway.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // chkBxRural
            // 
            this.chkBxRural.AutoSize = true;
            this.chkBxRural.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxRural.Location = new System.Drawing.Point(12, 55);
            this.chkBxRural.Name = "chkBxRural";
            this.chkBxRural.Size = new System.Drawing.Size(75, 32);
            this.chkBxRural.TabIndex = 1;
            this.chkBxRural.Text = "Rural";
            this.chkBxRural.UseVisualStyleBackColor = true;
            this.chkBxRural.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // chkBxLocal
            // 
            this.chkBxLocal.AutoSize = true;
            this.chkBxLocal.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxLocal.Location = new System.Drawing.Point(12, 25);
            this.chkBxLocal.Name = "chkBxLocal";
            this.chkBxLocal.Size = new System.Drawing.Size(74, 32);
            this.chkBxLocal.TabIndex = 0;
            this.chkBxLocal.Text = "Local";
            this.chkBxLocal.UseVisualStyleBackColor = true;
            this.chkBxLocal.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // grpBxTime
            // 
            this.grpBxTime.Controls.Add(this.chkBxTime);
            this.grpBxTime.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxTime.Location = new System.Drawing.Point(135, 276);
            this.grpBxTime.Name = "grpBxTime";
            this.grpBxTime.Size = new System.Drawing.Size(116, 57);
            this.grpBxTime.TabIndex = 7;
            this.grpBxTime.TabStop = false;
            this.grpBxTime.Text = "Time";
            // 
            // chkBxTime
            // 
            this.chkBxTime.AutoSize = true;
            this.chkBxTime.Font = new System.Drawing.Font("Leelawadee UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxTime.Location = new System.Drawing.Point(14, 24);
            this.chkBxTime.Name = "chkBxTime";
            this.chkBxTime.Size = new System.Drawing.Size(78, 23);
            this.chkBxTime.TabIndex = 0;
            this.chkBxTime.Text = "Daytime";
            this.chkBxTime.UseVisualStyleBackColor = true;
            // 
            // chkBxApproved
            // 
            this.chkBxApproved.AutoSize = true;
            this.chkBxApproved.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxApproved.Location = new System.Drawing.Point(149, 352);
            this.chkBxApproved.Name = "chkBxApproved";
            this.chkBxApproved.Size = new System.Drawing.Size(81, 30);
            this.chkBxApproved.TabIndex = 8;
            this.chkBxApproved.Text = "Supervisor\r\nApproval";
            this.chkBxApproved.UseVisualStyleBackColor = true;
            // 
            // NewTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 499);
            this.Controls.Add(this.chkBxApproved);
            this.Controls.Add(this.grpBxTime);
            this.Controls.Add(this.grpBxRoad);
            this.Controls.Add(this.grpBxTraffic);
            this.Controls.Add(this.grpBxWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.btnStartStop);
            this.Name = "NewTrip";
            this.Text = "New Trip";
            this.Load += new System.EventHandler(this.NewTrip_Load);
            this.grpBxWeather.ResumeLayout(false);
            this.grpBxWeather.PerformLayout();
            this.grpBxTraffic.ResumeLayout(false);
            this.grpBxTraffic.PerformLayout();
            this.grpBxRoad.ResumeLayout(false);
            this.grpBxRoad.PerformLayout();
            this.grpBxTime.ResumeLayout(false);
            this.grpBxTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBxWeather;
        private System.Windows.Forms.CheckBox chkBxRain;
        private System.Windows.Forms.CheckBox chkBxClear;
        private System.Windows.Forms.GroupBox grpBxTraffic;
        private System.Windows.Forms.CheckBox chkBxHeavy;
        private System.Windows.Forms.CheckBox chkBxMed;
        private System.Windows.Forms.CheckBox chkBxLight;
        private System.Windows.Forms.GroupBox grpBxRoad;
        private System.Windows.Forms.CheckBox chkBxHighway;
        private System.Windows.Forms.CheckBox chkBxRural;
        private System.Windows.Forms.CheckBox chkBxLocal;
        private System.Windows.Forms.GroupBox grpBxTime;
        private System.Windows.Forms.CheckBox chkBxApproved;
        private System.Windows.Forms.CheckBox chkBxTime;
    }
}