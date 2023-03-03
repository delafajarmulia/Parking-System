using Microsoft.EntityFrameworkCore;
using ParkingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class Payment : Form
    {
        DataContext? _context;
        private string plate;
        private int duration;
        private int pay;
        private int employeeId, memId, vehId, memTypeId, vehTypeId;

        public Payment()
        {
            InitializeComponent();
            _context = new DataContext();
            _context.Database.EnsureCreated();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DataContext();
            _context.VehicleTypes.Load();
            _context.Vehicles.Load();
            _context.MemberShipTypes.Load();
            _context.ParkingData.Load();
            _context.HourlyRates.Load();

            initAutocompleteVehiclePlate();

            dtTimeIn.Format = DateTimePickerFormat.Custom;
            dtTimeIn.CustomFormat = "hh:mm";
            dtTimeOut.Format = DateTimePickerFormat.Custom;
            dtTimeOut.CustomFormat = "hh:mm";

            dtIn.Format = DateTimePickerFormat.Custom;
            dtIn.CustomFormat = "dd:MM:yyyy";
            dtOut.Format = DateTimePickerFormat.Custom;
            dtOut.CustomFormat = "dd:MM:yyyy";
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
        }

        public async void HelloEmployee(string name)
        {
            _context.Employees.Load();
            Employee? employee = await _context.Employees
                                    .Where(e => e.Name == name)
                                    .FirstOrDefaultAsync();
            employeeId = employee.Id;
        }

        private async void initAutocompleteVehiclePlate()
        {
            _context.Vehicles.Load();
            var vehicleArray = _context.Vehicles.Local.Select(p => p.LicensePlate).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(vehicleArray);
            txtPlate.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPlate.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPlate.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtPay.Enabled = false;
            txtPay.BackColor = Color.WhiteSmoke;
        }


        private async void txtPlate_LeaveFocus(object sender, EventArgs e)
        {
            // get plate
            plate = txtPlate.Text;
            _context.Vehicles.Load();
            Vehicle? vehicle = await _context.Vehicles
                                .Where(v => v.LicensePlate == plate)
                                .FirstOrDefaultAsync();
            if (vehicle == null)
            {
                _context.VehicleTypes.Load();
                var data = _context.VehicleTypes.Local.ToList();
                cmbVehicleType.DisplayMember = "Name";
                cmbVehicleType.ValueMember = "Id";
                cmbVehicleType.DataSource = data;

                txtOwner.Text = "Non Member";
                txtMemberType.Text = "Non Member";
                txtOwner.Enabled = false;
                txtMemberType.Enabled = false;
            }
            else
            {
                // get member id
                memId = vehicle.MemberId;

                // get vehicle id
                vehId = vehicle.Id;

                // get vehicle type
                _context.VehicleTypes.Load();
                VehicleType? vehType = await _context.VehicleTypes
                                        .Where(v => v.Id == vehId)
                                        .FirstOrDefaultAsync();
                string vehTypeName = vehType.Name;
                vehTypeId = vehType.Id;

                // get member id
                _context.Members.Load();
                Member? member = await _context.Members
                                    .Where(m => m.Id == vehicle.MemberId)
                                    .FirstOrDefaultAsync();

                // get membership type
                _context.MemberShipTypes.Load();
                MembershipType? memType = await _context.MemberShipTypes
                                            .Where(m => m.Id == memId)
                                            .FirstOrDefaultAsync();
                memTypeId = memType.Id;

                if (memId != null)
                {
                    cmbVehicleType.Enabled = false;
                    cmbVehicleType.Text = vehTypeName.ToString();

                    txtOwner.Enabled = false;
                    txtOwner.Text = member.Name.ToString();

                    txtMemberType.Enabled = false;
                    txtMemberType.Text = memType.Name.ToString();
                }
            }
        }

        private void dtTimeOut_LeaveFocus(object sender, EventArgs e)
        {
            duration = (int)Math.Ceiling(
                (dtOut.Value.Add(dtTimeOut.Value.TimeOfDay).Subtract
                (dtIn.Value.Add(dtTimeIn.Value.TimeOfDay))
                .TotalMinutes / 60.00));

            txtDuration.Text = duration.ToString();
        }

        private void txtHourlyRate_LeaveFocus(object sender, EventArgs e)
        {
            pay = duration * int.Parse(txtHourlyRate.Text);
            txtPay.Text = pay.ToString();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var dateIn = dtIn.Value;
            var dateOut = dtOut.Value;

            if (memId != null)
            {
                HourlyRate hourlyRate = new HourlyRate();
                hourlyRate.MembershipId = memTypeId;
                hourlyRate.VehicleTypeId = vehTypeId;

                _context.HourlyRates.Add(hourlyRate);
                await _context.SaveChangesAsync();

                ParkingData data = new ParkingData();
                data.LicensePlate = plate;
                data.VehicleId = vehId;
                data.EmployeeId = employeeId;
                data.HourlyRatesId = hourlyRate.Id;
                data.DatetimeIn = dateIn;
                data.DatetimeOn = dateOut;
                data.AmountToPay = pay;

                _context.ParkingData.Add(data);
                await _context.SaveChangesAsync();
            } else
            {
                HourlyRate hourlyRate = new HourlyRate();
                hourlyRate.VehicleTypeId = vehTypeId;

                ParkingData data = new ParkingData();
                data.LicensePlate = plate;
                data.EmployeeId = employeeId;
                data.HourlyRatesId = hourlyRate.Id;
                data.DatetimeIn = dateIn;
                data.DatetimeOn = dateOut;
                data.AmountToPay = pay;

                _context.HourlyRates.Add(hourlyRate);
                await _context.SaveChangesAsync();
                _context.ParkingData.Add(data);
                await _context.SaveChangesAsync();
            }
        }
    }
}
