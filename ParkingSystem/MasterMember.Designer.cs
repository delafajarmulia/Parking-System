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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            MembershipName = new DataGridViewTextBoxColumn();
            IdMembership = new DataGridViewTextBoxColumn();
            IdMember = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            LastUpdatedAt = new DataGridViewTextBoxColumn();
            DeletedAt = new DataGridViewTextBoxColumn();
            viewMasterMemberBindingSource2 = new BindingSource(components);
            memberBindingSource = new BindingSource(components);
            memberBindingSource3 = new BindingSource(components);
            viewMasterMemberBindingSource1 = new BindingSource(components);
            memberBindingSource2 = new BindingSource(components);
            viewMasterMemberBindingSource = new BindingSource(components);
            memberBindingSource1 = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNum = new TextBox();
            txtBirthDay = new TextBox();
            RTAddress = new RichTextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSubmit = new Button();
            btnUpdate = new Button();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            cmbMemberType = new ComboBox();
            lblModifed = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewMasterMemberBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewMasterMemberBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewMasterMemberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(348, 23);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "MEMBER";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MembershipName, IdMembership, IdMember, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, CreatedAt, LastUpdatedAt, DeletedAt });
            dataGridView1.DataSource = viewMasterMemberBindingSource2;
            dataGridView1.Location = new Point(31, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(734, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // MembershipName
            // 
            MembershipName.DataPropertyName = "MembershipName";
            MembershipName.HeaderText = "MembershipName";
            MembershipName.MinimumWidth = 6;
            MembershipName.Name = "MembershipName";
            MembershipName.Width = 125;
            // 
            // IdMembership
            // 
            IdMembership.DataPropertyName = "TypeId";
            IdMembership.HeaderText = "IdMembership";
            IdMembership.MinimumWidth = 6;
            IdMembership.Name = "IdMembership";
            IdMembership.Width = 125;
            // 
            // IdMember
            // 
            IdMember.DataPropertyName = "IdMember";
            IdMember.HeaderText = "IdMember";
            IdMember.MinimumWidth = 6;
            IdMember.Name = "IdMember";
            IdMember.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Email";
            dataGridViewTextBoxColumn2.HeaderText = "Email";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "PhoneNumber";
            dataGridViewTextBoxColumn3.HeaderText = "PhoneNumber";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            dataGridViewTextBoxColumn4.HeaderText = "Address";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "DateOfBirth";
            dataGridViewTextBoxColumn5.HeaderText = "DateOfBirth";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Gender";
            dataGridViewTextBoxColumn6.HeaderText = "Gender";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // CreatedAt
            // 
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "CreatedAt";
            CreatedAt.MinimumWidth = 6;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.Width = 125;
            // 
            // LastUpdatedAt
            // 
            LastUpdatedAt.DataPropertyName = "LastUpdatedAt";
            LastUpdatedAt.HeaderText = "LastUpdatedAt";
            LastUpdatedAt.MinimumWidth = 6;
            LastUpdatedAt.Name = "LastUpdatedAt";
            LastUpdatedAt.Width = 125;
            // 
            // DeletedAt
            // 
            DeletedAt.DataPropertyName = "DeletedAt";
            DeletedAt.HeaderText = "DeletedAt";
            DeletedAt.MinimumWidth = 6;
            DeletedAt.Name = "DeletedAt";
            DeletedAt.Width = 125;
            // 
            // viewMasterMemberBindingSource2
            // 
            viewMasterMemberBindingSource2.DataSource = typeof(Model.ViewMasterMember);
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Model.Member);
            // 
            // memberBindingSource3
            // 
            memberBindingSource3.DataSource = typeof(Model.Member);
            // 
            // viewMasterMemberBindingSource1
            // 
            viewMasterMemberBindingSource1.DataSource = typeof(Model.ViewMasterMember);
            // 
            // memberBindingSource2
            // 
            memberBindingSource2.DataSource = typeof(Model.Member);
            // 
            // memberBindingSource1
            // 
            memberBindingSource1.DataSource = typeof(Model.Member);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 276);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 310);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 3;
            label3.Text = "Membership Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 344);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 373);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 5;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 403);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 520);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 7;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 490);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 8;
            label8.Text = "Date Of Birth";
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 269);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 27);
            txtName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(193, 337);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(193, 370);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(253, 27);
            txtPhoneNum.TabIndex = 12;
            // 
            // txtBirthDay
            // 
            txtBirthDay.Location = new Point(193, 483);
            txtBirthDay.Name = "txtBirthDay";
            txtBirthDay.Size = new Size(253, 27);
            txtBirthDay.TabIndex = 13;
            // 
            // RTAddress
            // 
            RTAddress.Location = new Point(193, 403);
            RTAddress.Name = "RTAddress";
            RTAddress.Size = new Size(253, 65);
            RTAddress.TabIndex = 15;
            RTAddress.Text = "";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(492, 306);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(105, 42);
            btnInsert.TabIndex = 16;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(492, 475);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 42);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(631, 438);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 42);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(631, 337);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(105, 42);
            btnSubmit.TabIndex = 19;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(492, 392);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 42);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(193, 520);
            radMale.Name = "radMale";
            radMale.Size = new Size(63, 24);
            radMale.TabIndex = 21;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(329, 518);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(78, 24);
            radFemale.TabIndex = 22;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // cmbMemberType
            // 
            cmbMemberType.FormattingEnabled = true;
            cmbMemberType.Location = new Point(193, 302);
            cmbMemberType.Name = "cmbMemberType";
            cmbMemberType.Size = new Size(253, 28);
            cmbMemberType.TabIndex = 23;
            // 
            // lblModifed
            // 
            lblModifed.AutoSize = true;
            lblModifed.Location = new Point(440, 538);
            lblModifed.Name = "lblModifed";
            lblModifed.Size = new Size(0, 20);
            lblModifed.TabIndex = 24;
            // 
            // MasterMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(lblModifed);
            Controls.Add(cmbMemberType);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(RTAddress);
            Controls.Add(txtBirthDay);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "MasterMember";
            Text = "MasterMember";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewMasterMemberBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewMasterMemberBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewMasterMemberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private BindingSource viewMasterMemberBindingSource2;
        private DataGridViewTextBoxColumn MembershipName;
        private DataGridViewTextBoxColumn IdMembership;
        private DataGridViewTextBoxColumn IdMember;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn LastUpdatedAt;
        private DataGridViewTextBoxColumn DeletedAt;
        private Label lblModifed;
    }
}