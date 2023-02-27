using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ParkingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Data.Common;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace ParkingSystem
{
    public partial class MasterMember : Form
    {
        private DataContext? _context;
        private string? operation;
        private int? selectedMemberId;

        private DataGridView dgv = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public MasterMember()
        {
            InitializeComponent();

            _context = new DataContext();
            _context = _context ?? new DataContext();
            _context.Database.EnsureCreated();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DataContext();
            _context = _context ?? new DataContext();
            _context.Database.EnsureCreated();
            _context.ViewMasterMembers.Load();
            //var db = await _context.ViewMasterMembers.ToListAsync();

            viewMasterMemberBindingSource2.DataSource = _context.ViewMasterMembers.Local.ToBindingList();

            /*SqlConnection cnn = new SqlConnection("Data Source=.\\sqlexpress;database=parkingdb2;Trusted_Connection=true;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT m.Name , m.TypeId , m.Id , m.Email , m.PhoneNumber , m.Address , m.DateOfBirth , m.Gender , ms.Id , ms.Name FROM dbo.Members AS m LEFT OUTER JOIN dbo.MemberShipTypes AS ms ON m.TypeId = ms.Id");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "TypeId";
            dataGridView1.Columns[2].HeaderText = "Id";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "Phone Number";
            dataGridView1.Columns[5].HeaderText = "Address";
            dataGridView1.Columns[6].HeaderText = "Date of Birth";
            dataGridView1.Columns[7].HeaderText = "Gender";
            dataGridView1.Columns[8].HeaderText = "Id Membership";
            dataGridView1.Columns[9].HeaderText = "Name Membership";*/

            /*var select = "SELECT m.Name , m.TypeId , m.Id , m.Email , m.PhoneNumber , m.Address , m.DateOfBirth , m.Gender , ms.Id , ms.Name FROM dbo.Members AS m LEFT OUTER JOIN dbo.MemberShipTypes AS ms ON m.TypeId = ms.Id";
            var c = new SqlConnection("Data Source=.\\sqlexpress;database=parkingdb2;Trusted_Connection=true;TrustServerCertificate=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            //viewMasterMemberBindingSource1.ReadOnly = true;
            memberBindingSource.DataSource = ds.Tables[0];*/

            /*string connetionString;
            SqlConnection cnn;
            var select = "SELECT m.Name , m.TypeId , m.Id , m.Email , m.PhoneNumber , m.Address , m.DateOfBirth , m.Gender , ms.Id , ms.Name FROM dbo.Members AS m LEFT OUTER JOIN dbo.MemberShipTypes AS ms ON m.TypeId = ms.Id";
            connetionString = @"Data Source=.\sqlexpress;database=parkingdb2;Trusted_Connection=true;TrustServerCertificate=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            var dataAdapter = new SqlDataAdapter(select, connetionString);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            //viewMasterMemberBindingSource1.ReadOnly = true;
            memberBindingSource.DataSource = ds.Tables[0];*/

            /*SqlConnection conn = null;
            conn = new SqlConnection("Data Source=.\\sqlexpress;database=parkingdb2;Trusted_Connection=true;TrustServerCertificate=True");
            conn.Open();
            string strSQLCommand = "CREATE VIEW vw_ViewMasterMember AS SELECT m.Name AS NamaMember, \r\n\tm.TypeId AS TypeId, \r\n\tm.Id AS IdMember, \r\n\tm.Email AS EmailMember, \r\n\tm.PhoneNumber AS NomorHPMember, \r\n\tm.Address AS AddressMember, \r\n\tm.DateOfBirth AS DateOfBirthMember, \r\n\tm.Gender AS GenderMember, \r\n ms.Id AS IdMembership, ms.Name AS MembershipName\r\nFROM  dbo.Members AS m LEFT OUTER JOIN\r\n dbo.MemberShipTypes AS ms ON m.TypeId = ms.Id";
            SqlCommand command = new SqlCommand(strSQLCommand, conn);
            string returnvalue = (string)command.ExecuteScalar();*/

            /*string connectionString = "Data Source=.\\sqlexpress;database=parkingdb2;Trusted_Connection=true;TrustServerCertificate=True";
            string sql = "SELECT m.Name AS NamaMember, \r\n\tm.TypeId AS TypeId, \r\n\tm.Id AS IdMember, \r\n\tm.Email AS EmailMember, \r\n\tm.PhoneNumber AS NomorHPMember, \r\n\tm.Address AS AddressMember, \r\n\tm.DateOfBirth AS DateOfBirthMember, \r\n\tm.Gender AS GenderMember, \r\n ms.Id AS IdMembership, ms.Name AS MembershipName\r\nFROM  dbo.Members AS m LEFT OUTER JOIN\r\n dbo.MemberShipTypes AS ms ON m.TypeId = ms.Id";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds);
            connection.Close();
            dataGridView1.DataSource = ds;*/

        }

        /*private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string.
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.
                String connectionString = "Data Source=.\\sqlexpress;database=parkingdb2;Trusted_Connection=true;TrustServerCertificate=True";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                memberBindingSource3.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void MasterMember_Load(object sender, EventArgs e)
        {
            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            GetData("SELECT m.Name , m.TypeId , m.Id , m.Email , m.PhoneNumber , m.Address , m.DateOfBirth , m.Gender , ms.Id , ms.Name FROM dbo.Members AS m LEFT OUTER JOIN dbo.MemberShipTypes AS ms ON m.TypeId = ms.Id");
            dataGridView1.DataSource = memberBindingSource3;
        }*/

        /*public IQueryable<ViewMasterMember> viewMasterMembers
        {
                get
                {
                    return this.Database.SqlQuery<ViewMasterMember>("select * from dbo.ViewMasterMember");
                }
        }*/

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context= null;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhoneNum.Text = "";
            RTAddress.Text = "";
            txtBirthDay.Text = "";
            radMale.Checked = false;
            radFemale.Checked = false;
            cmbMemberType.Text = "";

            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhoneNum.Enabled = true;
            RTAddress.Enabled = true;
            txtBirthDay.Enabled = true;
            radMale.Enabled = true;
            radFemale.Enabled = true;
            cmbMemberType.Enabled = true;

            _context.MemberShipTypes.Load();
            var data = _context.MemberShipTypes.Local.ToList();
            cmbMemberType.DisplayMember = "Name";
            cmbMemberType.ValueMember = "Id";
            cmbMemberType.DataSource = data;

            operation = "insert";
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            operation = "delete";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhoneNum.Text = "";
            RTAddress.Text = "";
            txtBirthDay.Text = "";
            radMale.Checked = false;
            radFemale.Checked = false;
            cmbMemberType.Text = "";

            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhoneNum.Enabled = true;
            RTAddress.Enabled = true;
            txtBirthDay.Enabled = true;
            radMale.Enabled = true;
            radFemale.Enabled = true;
            cmbMemberType.Enabled = true;

            operation = null;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhoneNum.Enabled = true;
            RTAddress.Enabled = true;
            txtBirthDay.Enabled = true;
            radMale.Enabled = true;
            radFemale.Enabled = true;
            cmbMemberType.Enabled = true;

            _context.MemberShipTypes.Load();
            var data = _context.MemberShipTypes.Local.ToList();
            cmbMemberType.DisplayMember = "Name";
            cmbMemberType.ValueMember = "Id";
            cmbMemberType.DataSource = data;

            operation = "update";
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "insert" : 
                        actionInsert();
                    break;
                case "update":
                        actionUpdate();
                    break;
                case "delete":
                        actionDelete();
                    break;
                default: break;
            }

        }

        private async void actionInsert()
        {
            // cek dulu (validasi)
            bool cPhoneNum = int.TryParse(txtPhoneNum.Text, out var phoneNum);
            bool cDateBirth = int.TryParse(txtBirthDay.Text, out var dateBirth);

            if ( !cPhoneNum || !cDateBirth)
            {
                MessageBox.Show("Data yang Anda Masukkan tidak sesuai");
            } 
            else if (txtName.Text == "" || txtEmail.Text == "" || RTAddress.Text == "" || cmbMemberType.Text == "" )
            {
                MessageBox.Show("Anda harus memasukkan data dengan lengkap");
            } else
            {
                // abis itu get member type
                string textTypeid = cmbMemberType.SelectedItem.ToString();
                int memTypeId = int.Parse(cmbMemberType.SelectedValue.ToString());
                MembershipType? memType = await _context.MemberShipTypes
                    .Where(m => m.Id == memTypeId)
                    .FirstAsync();

                // baru simpan database
                var newMember = new Member();
                newMember.Name = txtName.Text;
                newMember.Type = memType;
                newMember.Email = txtEmail.Text;
                newMember.PhoneNumber = txtPhoneNum.Text;
                newMember.Address = RTAddress.Text;
                newMember.DateOfBirth = txtBirthDay.Text;
                if (radMale.Checked)
                {
                    newMember.Gender = "Male";
                }
                else if (radFemale.Checked) 
                {
                    newMember.Gender = "Female";
                } else
                {
                    MessageBox.Show("Anda harus menginput gender");
                }

                _context.Members.Add(newMember);
                await _context.SaveChangesAsync();
            }

        }

        private async void actionDelete()
        {
            // cek selected member id nya ada atau tidak, kalau tidak diem aja
            if (selectedMemberId != null)
            {
                var member = await _context.Members.Where(m => m.Id == selectedMemberId).FirstAsync();
                _context.Members.Remove(member);
                await _context.SaveChangesAsync();
                selectedMemberId = null;
            } else
            {
                MessageBox.Show("Member yang ingin anda hapus tidak ada dalam database");
            }
        }

        private async void actionUpdate()
        {
            if (selectedMemberId != null)
            {
                string textTypeid = cmbMemberType.SelectedItem.ToString();
                int memTypeId = int.Parse(cmbMemberType.SelectedValue.ToString());
                MembershipType? memType = await _context.MemberShipTypes
                    .Where(m => m.Id == memTypeId)
                    .FirstAsync();

                var member = await _context.Members
                                .Where(m => m.Id == selectedMemberId) 
                                .FirstAsync();
                member.Name = txtName.Text;
                member.Type = memType;
                member.Email = txtEmail.Text;
                member.PhoneNumber = txtPhoneNum.Text;
                member.Address = RTAddress.Text;
                member.DateOfBirth = txtBirthDay.Text;
                if (radMale.Checked)
                {
                    member.Gender = "Male";
                }
                else if (radFemale.Checked)
                {
                    member.Gender = "Female";
                }
                _context.Members.Update(member);
                await _context.SaveChangesAsync();
                dataGridView1.Refresh();
            } else
            {
                MessageBox.Show("Member yang ingin anda update tidak ada dalam database");
            }
        }
        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedMember = (Member)viewMasterMemberBindingSource2.List[index];
            selectedMemberId = selectedMember.Id;

            _context.MemberShipTypes.Load();
            var data = _context.MemberShipTypes.Local.ToList();
            cmbMemberType.DisplayMember = "Name";
            cmbMemberType.ValueMember = "Id";
            cmbMemberType.DataSource = data;

            txtName.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
            txtPhoneNum.Text = row.Cells[4].Value.ToString();
            RTAddress.Text = row.Cells[5].Value.ToString();
            txtBirthDay.Text = row.Cells[6].Value.ToString();
            if (row.Cells[7].Value.ToString() == "Male")
            {
                radMale.Checked = true;
            } else 
            {
                radFemale.Checked = true;
            }
            string type = row.Cells[0].Value.ToString();
            cmbMemberType.Text= type;

            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNum.Enabled = false;
            RTAddress.Enabled = false;
            txtBirthDay.Enabled = false;
            radMale.Enabled = false;
            radFemale.Enabled = false;
            cmbMemberType.Enabled = false;
        }
    }
}
