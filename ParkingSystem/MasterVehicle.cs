using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using ParkingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace ParkingSystem
{
    public partial class MasterVehicle : Form
    {
        private DataContext? _context;
        private int? selectedVehicleId;
        private string? operation;
        private string? ownerName;
        private int? memIdSearch;
        private string? type;

        public MasterVehicle()
        {
            InitializeComponent();
            _context = new DataContext();
            _context.Database.EnsureCreated();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DataContext();
            _context = _context ?? new DataContext();
            _context.ViewMasterVehicles.Load();
            _context.Members.Load();
            _context.Vehicles.Load();
            viewMasterVehicleBindingSource.DataSource = _context.ViewMasterVehicles.Local.ToList();

            InitiateAutoComplete();
            cmbSeacrh.Items.Add("Owner name");
            cmbSeacrh.Items.Add("License plate");
        }

        private void AutoCompleteInSearch_LicensePlate()
        {
            var plateArray = _context.Vehicles.Local.Select(p => p.LicensePlate).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(plateArray);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void AutoCompleteInSearch_OwnerName()
        {
            var memberArray = _context.Members.Local.Select(p => p.Name).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(memberArray);
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private async void Search(object sender, EventArgs e)
        {
            if (cmbSeacrh.Text == "License plate")
            {
                AutoCompleteInSearch_LicensePlate();

                _context.ViewMasterVehicles.Load();
                string licensePlate = txtSearch.Text;
                List<ViewMasterVehicle>? viewVehicle = await _context.ViewMasterVehicles
                                    .Where(m => m.LicensePlate == licensePlate)
                                    .ToListAsync();

                viewMasterVehicleBindingSource.DataSource = viewVehicle.ToList();
                dataGridView1.Refresh();
            }
            else if (cmbSeacrh.Text == "Owner name")
            {
                AutoCompleteInSearch_OwnerName();

                _context.ViewMasterVehicles.Load();
                string ownerName = txtSearch.Text;
                List<ViewMasterVehicle>? viewVehicle = await _context.ViewMasterVehicles
                                            .Where(o => o.MemberName == ownerName)
                                            .ToListAsync();

                viewMasterVehicleBindingSource.DataSource = viewVehicle.ToList();
                dataGridView1.Refresh();
            }
            else
            {
                return;
            }
        }

        private async void txtSearch_LeaveFocus(object sender, EventArgs e)
        {
            if (cmbSeacrh.Text == "License plate")
            {
                _context.ViewMasterVehicles.Load();
                string licensePlate = txtSearch.Text;
                List<ViewMasterVehicle>? viewVehicle = await _context.ViewMasterVehicles
                                    .Where(m => m.LicensePlate == licensePlate)
                                    .ToListAsync();

                viewMasterVehicleBindingSource.DataSource = viewVehicle.ToList();
                dataGridView1.Refresh();
            }
            else if (cmbSeacrh.Text == "Owner name")
            {
                _context.ViewMasterVehicles.Load();
                string ownerName = txtSearch.Text;
                List<ViewMasterVehicle>? viewVehicle = await _context.ViewMasterVehicles
                                            .Where(o => o.MemberName == ownerName)
                                            .ToListAsync();

                viewMasterVehicleBindingSource.DataSource = viewVehicle.ToList();
                dataGridView1.Refresh();
            }
            else
            {
                return;
            }
        }

        private void InitiateAutoComplete()
        {
            var memberArray = _context.Members.Local.Select(m => m.Name).ToArray();
            AutoCompleteStringCollection srcAutoComplete = new AutoCompleteStringCollection();
            srcAutoComplete.AddRange(memberArray);
            txtOwner.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOwner.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtOwner.AutoCompleteCustomSource = srcAutoComplete;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void EnabledTrue()
        {
            txtOwner.Enabled = true;
            cmbVehicleType.Enabled = true;
            RTNote.Enabled = true;
            txtLicensePlate.Enabled = true;
        }

        private void SelectVehicleType()
        {
            _context.VehicleTypes.Load();
            var data = _context.VehicleTypes.Local.ToList();
            cmbVehicleType.DisplayMember = "Name";
            cmbVehicleType.ValueMember = "Id";
            cmbVehicleType.DataSource = data;
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedVehicle = (ViewMasterVehicle)viewMasterVehicleBindingSource.List[index];
            selectedVehicleId = selectedVehicle.VehicleId;

            txtOwner.Text = "[" + row.Cells[3].Value.ToString() + "] [" + row.Cells[4].Value.ToString() + "]";
            txtLicensePlate.Text = row.Cells[5].Value.ToString();
            RTNote.Text = row.Cells[6].Value.ToString();
            ownerName = row.Cells[4].Value.ToString();
            cmbVehicleType.Text = row.Cells[2].Value.ToString();
            type = row.Cells[2].Value.ToString();

            var created = row.Cells[7].Value;
            var updated = row.Cells[8].Value;

            if (updated != null)
            {
                lblModified.Text = "This record is last modifed at " + updated;
            }
            else if (created != null)
            {
                lblModified.Text = "This record is created at " + created;
            }
            else if (updated == null && created == null)
            {
                lblModified.Text = "";
            }

            txtOwner.Enabled = false;
            cmbVehicleType.Enabled = false;
            RTNote.Enabled = false;
            txtLicensePlate.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EnabledTrue();

            txtOwner.Text = "";
            RTNote.Text = "";
            txtLicensePlate.Text = "";
            SelectVehicleType();

            operation = "Insert";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnabledTrue();

            txtOwner.Text = ownerName;

            SelectVehicleType();
            cmbVehicleType.Text = type;

            operation = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            operation = "Delete";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnabledTrue();

            txtOwner.Text = "";
            RTNote.Text = "";
            txtLicensePlate.Text = "";
            SelectVehicleType();

            operation = null;
        }

        private int getMemberId(string name)
        {
            Member? member = _context.Members.Local.Where(m => m.Name == name).First();
            if (member == null)
            {
                return 0;
            }

            return member.Id;
        }

        private async void actionInsert()
        {
            if (txtLicensePlate.Text == "" || txtOwner.Text == "" || cmbVehicleType.Text == "" || RTNote.Text == "")
            {
                MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ambil vehicle type
                string vehicleType = cmbVehicleType.SelectedItem.ToString();
                int vehTypeId = int.Parse(cmbVehicleType.SelectedValue.ToString());
                VehicleType? vehType = await _context.VehicleTypes
                    .Where(m => m.Id == vehTypeId)
                    .FirstAsync();

                // get id dari db local member
                var memberId = getMemberId(txtOwner.Text);

                // simpen ke db
                Vehicle newVehicle = new Vehicle();

                newVehicle.VehicleTypeId = vehTypeId;
                newVehicle.Notes = RTNote.Text;
                newVehicle.LicensePlate = txtLicensePlate.Text;
                newVehicle.MemberId = memberId;
                newVehicle.CreatedAt = DateTime.Now;

                _context.Vehicles.Add(newVehicle);
                await _context.SaveChangesAsync();
                _context.Vehicles.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully inserted new vehicle data with ID : " + newVehicle.Id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void actionUpdate()
        {
            if (selectedVehicleId != null)
            {
                // get vehicle type
                string textVehicleType = cmbVehicleType.SelectedItem.ToString();
                int vehTypeId = int.Parse(cmbVehicleType.SelectedValue.ToString());
                VehicleType? vehType = await _context.VehicleTypes
                    .Where(m => m.Id == vehTypeId)
                    .FirstAsync();

                // get id dari db local member
                var memberId = getMemberId(txtOwner.Text);

                // get vehicle, dan update ke db
                var vehicle = await _context.Vehicles
                                .Where(v => v.Id == selectedVehicleId)
                                .FirstAsync();
                vehicle.VehicleTypeId = vehTypeId;
                vehicle.Notes = RTNote.Text;
                vehicle.MemberId = memberId;
                vehicle.LicensePlate = txtLicensePlate.Text;
                vehicle.LastUpdatedAt = DateTime.Now;

                _context.Vehicles.Update(vehicle);
                await _context.SaveChangesAsync();
                _context.Vehicles.Load();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully updated new vehicle data with ID : " + vehicle.Id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("the data does not exist in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void actionDelete()
        {
            if (selectedVehicleId != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    var vehicle = await _context.Vehicles.Where(x => x.Id == selectedVehicleId).FirstAsync();
                    _context.Vehicles.Remove(vehicle);
                    await _context.SaveChangesAsync();
                    selectedVehicleId = null;
                    _context.Vehicles.Load();
                    dataGridView1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("The data you want to delete is not available in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "Insert":
                    actionInsert();
                    break;
                case "Update":
                    actionUpdate();
                    break;
                case "Delete":
                    actionDelete();
                    break;
                default: break;
            }
        }
    }
}
