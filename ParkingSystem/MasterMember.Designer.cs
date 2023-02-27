namespace ParkingSystem
{
    partial class MasterMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.viewMasterMemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.viewMasterMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtBirthDay = new System.Windows.Forms.TextBox();
            this.RTAddress = new System.Windows.Forms.RichTextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.cmbMemberType = new System.Windows.Forms.ComboBox();
            this.viewMasterMemberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMasterMemberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMasterMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMasterMemberBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(348, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEMBER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.MembershipName,
            this.IdMember,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.viewMasterMemberBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(31, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(734, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(ParkingSystem.Model.Member);
            // 
            // memberBindingSource3
            // 
            this.memberBindingSource3.DataSource = typeof(ParkingSystem.Model.Member);
            // 
            // viewMasterMemberBindingSource1
            // 
            this.viewMasterMemberBindingSource1.DataSource = typeof(ParkingSystem.Model.ViewMasterMember);
            // 
            // memberBindingSource2
            // 
            this.memberBindingSource2.DataSource = typeof(ParkingSystem.Model.Member);
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataSource = typeof(ParkingSystem.Model.Member);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Membership Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date Of Birth";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 269);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 27);
            this.txtName.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 27);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(193, 370);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(253, 27);
            this.txtPhoneNum.TabIndex = 12;
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.Location = new System.Drawing.Point(193, 483);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(253, 27);
            this.txtBirthDay.TabIndex = 13;
            // 
            // RTAddress
            // 
            this.RTAddress.Location = new System.Drawing.Point(193, 403);
            this.RTAddress.Name = "RTAddress";
            this.RTAddress.Size = new System.Drawing.Size(253, 65);
            this.RTAddress.TabIndex = 15;
            this.RTAddress.Text = "";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(492, 306);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(105, 42);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(492, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(631, 438);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 42);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(631, 337);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(105, 42);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(492, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 42);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(193, 520);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(63, 24);
            this.radMale.TabIndex = 21;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(329, 518);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(78, 24);
            this.radFemale.TabIndex = 22;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // cmbMemberType
            // 
            this.cmbMemberType.FormattingEnabled = true;
            this.cmbMemberType.Location = new System.Drawing.Point(193, 302);
            this.cmbMemberType.Name = "cmbMemberType";
            this.cmbMemberType.Size = new System.Drawing.Size(253, 28);
            this.cmbMemberType.TabIndex = 23;
            // 
            // viewMasterMemberBindingSource2
            // 
            this.viewMasterMemberBindingSource2.DataSource = typeof(ParkingSystem.Model.ViewMasterMember);
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // MembershipName
            // 
            this.MembershipName.DataPropertyName = "MembershipName";
            this.MembershipName.HeaderText = "MembershipName";
            this.MembershipName.MinimumWidth = 6;
            this.MembershipName.Name = "MembershipName";
            this.MembershipName.Width = 125;
            // 
            // IdMember
            // 
            this.IdMember.DataPropertyName = "IdMember";
            this.IdMember.HeaderText = "IdMember";
            this.IdMember.MinimumWidth = 6;
            this.IdMember.Name = "IdMember";
            this.IdMember.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // MasterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.cmbMemberType);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.RTAddress);
            this.Controls.Add(this.txtBirthDay);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MasterMember";
            this.Text = "MasterMember";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMasterMemberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMasterMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMasterMemberBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhoneNum;
        private TextBox txtBirthDay;
        private RichTextBox RTAddress;
        private Button btnInsert;
        private DataGridViewTextBoxColumn membershipTypeDataGridViewTextBoxColumn;
        private BindingSource memberBindingSource;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnSubmit;
        private Button btnUpdate;
        private RadioButton radMale;
        private RadioButton radFemale;
        private ComboBox cmbMemberType;
        private BindingSource memberBindingSource1;
        private BindingSource viewMasterMemberBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private BindingSource viewMasterMemberBindingSource1;
        private BindingSource memberBindingSource2;
        private BindingSource memberBindingSource3;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn MembershipName;
        private DataGridViewTextBoxColumn IdMember;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BindingSource viewMasterMemberBindingSource2;
    }
}