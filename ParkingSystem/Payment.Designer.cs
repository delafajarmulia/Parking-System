namespace ParkingSystem
{
    partial class Payment
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            dtTimeOut = new DateTimePicker();
            dtOut = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbVehicleType = new ComboBox();
            txtPlate = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dtTimeIn = new DateTimePicker();
            dtIn = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            txtMemberType = new TextBox();
            txtOwner = new TextBox();
            label11 = new Label();
            label10 = new Label();
            groupBox5 = new GroupBox();
            txtPay = new TextBox();
            txtHourlyRate = new TextBox();
            txtDuration = new TextBox();
            btnSubmit = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(396, 29);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 0;
            label1.Text = "PAYMENT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(cmbVehicleType);
            groupBox1.Controls.Add(txtPlate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(30, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 430);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtTimeOut);
            groupBox3.Controls.Add(dtOut);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(30, 269);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(362, 125);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // dtTimeOut
            // 
            dtTimeOut.Location = new Point(123, 81);
            dtTimeOut.Name = "dtTimeOut";
            dtTimeOut.Size = new Size(205, 27);
            dtTimeOut.TabIndex = 5;
            dtTimeOut.Leave += dtTimeOut_LeaveFocus;
            // 
            // dtOut
            // 
            dtOut.Location = new Point(123, 48);
            dtOut.Name = "dtOut";
            dtOut.Size = new Size(205, 27);
            dtOut.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 86);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 2;
            label7.Text = "Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 53);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 1;
            label8.Text = "Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(16, 23);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 0;
            label9.Text = "OUT Time";
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Location = new Point(153, 71);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(239, 28);
            cmbVehicleType.TabIndex = 4;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(153, 32);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(239, 27);
            txtPlate.TabIndex = 3;
            txtPlate.Leave += txtPlate_LeaveFocus;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 74);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Vehicle Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 35);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "License Plate";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtTimeIn);
            groupBox2.Controls.Add(dtIn);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(30, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // dtTimeIn
            // 
            dtTimeIn.Location = new Point(123, 81);
            dtTimeIn.Name = "dtTimeIn";
            dtTimeIn.Size = new Size(205, 27);
            dtTimeIn.TabIndex = 4;
            // 
            // dtIn
            // 
            dtIn.Location = new Point(123, 46);
            dtIn.Name = "dtIn";
            dtIn.Size = new Size(205, 27);
            dtIn.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 86);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 2;
            label6.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 53);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 1;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 23);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 0;
            label4.Text = "IN Time";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtMemberType);
            groupBox4.Controls.Add(txtOwner);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(484, 88);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(423, 125);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // txtMemberType
            // 
            txtMemberType.Location = new Point(157, 71);
            txtMemberType.Name = "txtMemberType";
            txtMemberType.Size = new Size(245, 27);
            txtMemberType.TabIndex = 3;
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(157, 28);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(245, 27);
            txtOwner.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 74);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 1;
            label11.Text = "Member Type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 35);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 0;
            label10.Text = "Owner";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtPay);
            groupBox5.Controls.Add(txtHourlyRate);
            groupBox5.Controls.Add(txtDuration);
            groupBox5.Controls.Add(btnSubmit);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Location = new Point(484, 240);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(423, 278);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Leave += txtHourlyRate_LeaveFocus;
            // 
            // txtPay
            // 
            txtPay.Location = new Point(157, 147);
            txtPay.Name = "txtPay";
            txtPay.Size = new Size(245, 27);
            txtPay.TabIndex = 8;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(157, 68);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(245, 27);
            txtHourlyRate.TabIndex = 7;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(157, 27);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(245, 27);
            txtDuration.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(272, 213);
            btnSubmit.Margin = new Padding(5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(111, 48);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(26, 150);
            label16.Name = "label16";
            label16.Size = new Size(108, 20);
            label16.TabIndex = 4;
            label16.Text = "Amount To Pay";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(381, 106);
            label15.Name = "label15";
            label15.Size = new Size(21, 23);
            label15.TabIndex = 3;
            label15.Text = "X";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(26, 106);
            label14.Name = "label14";
            label14.Size = new Size(360, 23);
            label14.TabIndex = 2;
            label14.Text = "__________________________________________________";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(26, 71);
            label13.Name = "label13";
            label13.Size = new Size(87, 20);
            label13.TabIndex = 1;
            label13.Text = "Hourly Rate";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 34);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 0;
            label12.Text = "Parking Duration";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 573);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtPlate;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private ComboBox cmbVehicleType;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox3;
        private DateTimePicker dtOut;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dtIn;
        private GroupBox groupBox4;
        private TextBox txtMemberType;
        private TextBox txtOwner;
        private Label label11;
        private Label label10;
        private GroupBox groupBox5;
        private TextBox txtPay;
        private TextBox txtHourlyRate;
        private TextBox txtDuration;
        private Button btnSubmit;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private DateTimePicker dtTimeIn;
        private DateTimePicker dtTimeOut;
    }
}