namespace ParkingSystem
{
    partial class MasterVehicle
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
            label2 = new Label();
            cmbSeacrh = new ComboBox();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            vehicleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vehicleTypeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NameVehicleType = new DataGridViewTextBoxColumn();
            memberIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MemberName = new DataGridViewTextBoxColumn();
            licensePlateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            LastUpdatedAt = new DataGridViewTextBoxColumn();
            viewMasterVehicleBindingSource = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtOwner = new TextBox();
            cmbVehicleType = new ComboBox();
            RTNote = new RichTextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSubmit = new Button();
            btnCancel = new Button();
            txtLicensePlate = new TextBox();
            lblModified = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewMasterVehicleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(370, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 0;
            label1.Text = "VEHICLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 75);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Search by";
            // 
            // cmbSeacrh
            // 
            cmbSeacrh.FormattingEnabled = true;
            cmbSeacrh.Location = new Point(115, 72);
            cmbSeacrh.Name = "cmbSeacrh";
            cmbSeacrh.Size = new Size(136, 28);
            cmbSeacrh.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(257, 73);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(203, 27);
            txtSearch.TabIndex = 3;
            txtSearch.Click += Search;
            txtSearch.Leave += txtSearch_LeaveFocus;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vehicleIdDataGridViewTextBoxColumn, vehicleTypeIdDataGridViewTextBoxColumn, NameVehicleType, memberIdDataGridViewTextBoxColumn, MemberName, licensePlateDataGridViewTextBoxColumn, notesDataGridViewTextBoxColumn, CreatedAt, LastUpdatedAt });
            dataGridView1.DataSource = viewMasterVehicleBindingSource;
            dataGridView1.Location = new Point(27, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(760, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // vehicleIdDataGridViewTextBoxColumn
            // 
            vehicleIdDataGridViewTextBoxColumn.DataPropertyName = "VehicleId";
            vehicleIdDataGridViewTextBoxColumn.HeaderText = "VehicleId";
            vehicleIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            vehicleIdDataGridViewTextBoxColumn.Name = "vehicleIdDataGridViewTextBoxColumn";
            vehicleIdDataGridViewTextBoxColumn.ReadOnly = true;
            vehicleIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleTypeIdDataGridViewTextBoxColumn
            // 
            vehicleTypeIdDataGridViewTextBoxColumn.DataPropertyName = "VehicleTypeId";
            vehicleTypeIdDataGridViewTextBoxColumn.HeaderText = "VehicleTypeId";
            vehicleTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            vehicleTypeIdDataGridViewTextBoxColumn.Name = "vehicleTypeIdDataGridViewTextBoxColumn";
            vehicleTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            vehicleTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // NameVehicleType
            // 
            NameVehicleType.DataPropertyName = "NameVehicleType";
            NameVehicleType.HeaderText = "NameVehicleType";
            NameVehicleType.MinimumWidth = 6;
            NameVehicleType.Name = "NameVehicleType";
            NameVehicleType.Width = 125;
            // 
            // memberIdDataGridViewTextBoxColumn
            // 
            memberIdDataGridViewTextBoxColumn.DataPropertyName = "MemberId";
            memberIdDataGridViewTextBoxColumn.HeaderText = "MemberId";
            memberIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            memberIdDataGridViewTextBoxColumn.Name = "memberIdDataGridViewTextBoxColumn";
            memberIdDataGridViewTextBoxColumn.ReadOnly = true;
            memberIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // MemberName
            // 
            MemberName.DataPropertyName = "MemberName";
            MemberName.HeaderText = "MemberName";
            MemberName.MinimumWidth = 6;
            MemberName.Name = "MemberName";
            MemberName.Width = 125;
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            licensePlateDataGridViewTextBoxColumn.DataPropertyName = "LicensePlate";
            licensePlateDataGridViewTextBoxColumn.HeaderText = "LicensePlate";
            licensePlateDataGridViewTextBoxColumn.MinimumWidth = 6;
            licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            licensePlateDataGridViewTextBoxColumn.ReadOnly = true;
            licensePlateDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            notesDataGridViewTextBoxColumn.ReadOnly = true;
            notesDataGridViewTextBoxColumn.Width = 125;
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
            // viewMasterVehicleBindingSource
            // 
            viewMasterVehicleBindingSource.DataSource = typeof(Model.ViewMasterVehicle);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 330);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 5;
            label3.Text = "License Plate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 397);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 6;
            label4.Text = "Owner";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 433);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 7;
            label5.Text = "Vehicle Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 466);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 8;
            label6.Text = "Note";
            // 
            // txtOwner
            // 
            txtOwner.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOwner.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtOwner.Location = new Point(143, 394);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(317, 27);
            txtOwner.TabIndex = 9;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Location = new Point(143, 430);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(317, 28);
            cmbVehicleType.TabIndex = 10;
            // 
            // RTNote
            // 
            RTNote.Location = new Point(143, 466);
            RTNote.Name = "RTNote";
            RTNote.Size = new Size(317, 77);
            RTNote.TabIndex = 11;
            RTNote.Text = "";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(535, 321);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(110, 42);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(535, 414);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 42);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(535, 504);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 42);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(677, 365);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 42);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(677, 457);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 42);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Location = new Point(143, 330);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(317, 27);
            txtLicensePlate.TabIndex = 17;
            // 
            // lblModified
            // 
            lblModified.AutoSize = true;
            lblModified.Location = new Point(435, 593);
            lblModified.Name = "lblModified";
            lblModified.Size = new Size(0, 20);
            lblModified.TabIndex = 18;
            // 
            // MasterVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 622);
            Controls.Add(lblModified);
            Controls.Add(txtLicensePlate);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(RTNote);
            Controls.Add(cmbVehicleType);
            Controls.Add(txtOwner);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(cmbSeacrh);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MasterVehicle";
            Text = "MasterVehicle";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewMasterVehicleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbSeacrh;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtOwner;
        private ComboBox cmbVehicleType;
        private RichTextBox RTNote;
        private DataGridViewTextBoxColumn idVehicleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idMemberDataGridViewTextBoxColumn;
        private BindingSource viewMasterVehicleBindingSource;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSubmit;
        private Button btnCancel;
        private TextBox txtLicensePlate;
        private Label lblModified;
        private DataGridViewTextBoxColumn vehicleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vehicleTypeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NameVehicleType;
        private DataGridViewTextBoxColumn memberIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn MemberName;
        private DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn LastUpdatedAt;
    }
}