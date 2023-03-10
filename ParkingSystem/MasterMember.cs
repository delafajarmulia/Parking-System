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
        private string? type;

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
            var db = await _context.ViewMasterMembers.ToListAsync();

            viewMasterMemberBindingSource2.DataSource = _context.ViewMasterMembers.Local.ToBindingList();

        }


        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void EnabledTrue()
        {
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhoneNum.Enabled = true;
            RTAddress.Enabled = true;
            txtBirthDay.Enabled = true;
            radMale.Enabled = true;
            radFemale.Enabled = true;
            cmbMemberType.Enabled = true;
        }

        private void SelectMemType()
        {
            _context.MemberShipTypes.Load();
            var data = _context.MemberShipTypes.Local.ToList();
            cmbMemberType.DisplayMember = "Name";
            cmbMemberType.ValueMember = "Id";
            cmbMemberType.DataSource = data;
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

            EnabledTrue();
            SelectMemType();

            operation = "insert";
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

            EnabledTrue();

            operation = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnabledTrue();
            SelectMemType();
            cmbMemberType.Text = type;

            operation = "update";
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "insert":
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
            dataGridView1.Refresh();
        }

        private async void actionInsert()
        {
            // cek dulu (validasi)
            bool cPhoneNum = int.TryParse(txtPhoneNum.Text, out var phoneNum);
            bool cDateBirth = int.TryParse(txtBirthDay.Text, out var dateBirth);

            if (!cPhoneNum || !cDateBirth)
            {
                MessageBox.Show("The data you entered is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtName.Text == "" || txtEmail.Text == "" || RTAddress.Text == "" || cmbMemberType.Text == "")
            {
                MessageBox.Show("You must enter data completely", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                }
                else
                {
                    MessageBox.Show("You must input gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                newMember.CreatedAt = DateTime.Now;

                _context.Members.Add(newMember);
                await _context.SaveChangesAsync();
                _context.Members.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully inserted new member data with ID : " + newMember.Id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private async void actionDelete()
        {
            // cek selected member id nya ada atau tidak, kalau tidak diem aja
            if (selectedMemberId != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    var member = await _context.Members.Where(m => m.Id == selectedMemberId).FirstAsync();
                    _context.Members.Remove(member);
                    await _context.SaveChangesAsync();
                    selectedMemberId = null;
                    _context.Members.Load();
                    dataGridView1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Member yang ingin anda hapus tidak ada dalam database");
            }
        }

        private async void actionUpdate()
        {
            if (selectedMemberId != null)
            {
                // get membership type
                string textTypeid = cmbMemberType.SelectedItem.ToString();
                int memTypeId = int.Parse(cmbMemberType.SelectedValue.ToString());
                MembershipType? memType = await _context.MemberShipTypes
                    .Where(m => m.Id == memTypeId)
                    .FirstAsync();

                // get member dan simpan ke db
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
                member.LastUpdatedAt = DateTime.Now;

                _context.Members.Update(member);
                await _context.SaveChangesAsync();
                _context.Members.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully updated new vehicle data with ID : " + member.Id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("the data does not exist in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedMember = (ViewMasterMember)viewMasterMemberBindingSource2.List[index];
            selectedMemberId = selectedMember.IdMember;

            txtName.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtPhoneNum.Text = row.Cells[5].Value.ToString();
            RTAddress.Text = row.Cells[6].Value.ToString();
            txtBirthDay.Text = row.Cells[7].Value.ToString();
            if (row.Cells[8].Value.ToString() == "Male")
            {
                radMale.Checked = true;
            }
            else
            {
                radFemale.Checked = true;
            }
            type = row.Cells[0].Value.ToString();
            cmbMemberType.Text = type;

            var created = row.Cells[9].Value;
            var updated = row.Cells[10].Value;
            if (updated != null)
            {
                lblModifed.Text = "This record is last modifed at " + updated;
            }
            else if (created != null)
            {
                lblModifed.Text = "This record is created at " + created;
            }
            else if (updated == null && created == null)
            {
                lblModifed.Text = "";
            }

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
