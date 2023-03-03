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

namespace ParkingSystem
{
    public partial class MasterVehicle : Form
    {
        private DataContext? _context;
        private int? selectedVehicleId;
        private string? operation;
        private string? ownerName;

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
        }

        private void Search()
        {
            _context.Members.Load();
            var data = _context.Members.Local.ToList();
            cmbSeacrh.DisplayMember = "Name";
            cmbSeacrh.ValueMember = "Id";
            cmbSeacrh.DataSource = data;

            dataGridView1.DataSource = data;
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
            _context= null;
        }

        private void EnabledTrue()
        {
            txtOwner.Enabled = true;
            cmbVehicleType.Enabled = true;
            RTNote.Enabled = true;
            txtLicensePlate.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedVehicle = (ViewMasterVehicle)viewMasterVehicleBindingSource.List[index];
            selectedVehicleId = selectedVehicle.VehicleId;

            _context.VehicleTypes.Load();
            var data = _context.VehicleTypes.Local.ToList();
            cmbVehicleType.DisplayMember = "Name";
            cmbVehicleType.ValueMember = "Id";
            cmbVehicleType.DataSource = data;

            txtOwner.Text = "["+ row.Cells[3].Value.ToString() +"] ["+ row.Cells[4].Value.ToString() + "]";
            txtLicensePlate.Text = row.Cells[5].Value.ToString();
            RTNote.Text = row.Cells[6].Value.ToString();
            ownerName = row.Cells[4].Value.ToString();

            txtOwner.Enabled = false;
            cmbVehicleType.Enabled = false;
            RTNote.Enabled = false;
            txtLicensePlate.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EnabledTrue();

            txtOwner.Text = "";
            _context.VehicleTypes.Load();
            var data = _context.VehicleTypes.Local.ToList();
            cmbVehicleType.DisplayMember = "Name";
            cmbVehicleType.ValueMember = "Id";
            cmbVehicleType.DataSource = data;
            RTNote.Text = "";
            txtLicensePlate.Text = "";

            operation = "Insert";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnabledTrue();

            txtOwner.Text = ownerName;

            _context.VehicleTypes.Load();
            var data = _context.VehicleTypes.Local.ToList();
            cmbVehicleType.DisplayMember = "Name";
            cmbVehicleType.ValueMember = "Id";
            cmbVehicleType.DataSource = data;

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
            _context.VehicleTypes.Load();
            var data = _context.VehicleTypes.Local.ToList();
            cmbVehicleType.DisplayMember = "Name";
            cmbVehicleType.ValueMember = "Id";
            cmbVehicleType.DataSource = data;
            RTNote.Text = "";
            txtLicensePlate.Text = "";

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
                MessageBox.Show("Anda harus mengisi data dengan lengkap");
            } else
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

                _context.Vehicles.Add(newVehicle);
                await _context.SaveChangesAsync();
                dataGridView1.Refresh();
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

                _context.Vehicles.Update(vehicle);
                await _context.SaveChangesAsync();
                dataGridView1 .Refresh();
            } else
            {
                MessageBox.Show("Vehicle yg ingin anda update unavaible");
            }
        }


        private async void actionDelete()
        {
            if (selectedVehicleId != null)
            {
                var vehicle = await _context.Vehicles.Where(x => x.Id == selectedVehicleId).FirstAsync();
                _context.Vehicles.Remove(vehicle);
                await _context.SaveChangesAsync();
                selectedVehicleId = null;
                dataGridView1.Refresh();
            } else
            {
                MessageBox.Show("Data yang ingin anda hapus tidak tersedia di database");
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

        private void cmbSeacrh_SelectedIndexChanged(object sender, EventArgs e)
        {
            _context.Members.Load();
            var data = _context.Members.Local.ToList();
            cmbSeacrh.DisplayMember = "Name";
            cmbSeacrh.ValueMember = "Id";
            cmbSeacrh.DataSource = data;

            dataGridView1.DataSource = data;
        }
    }
}
