using Microsoft.EntityFrameworkCore;
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
        public Payment()
        {
            InitializeComponent();
            _context= new DataContext();
            _context.Database.EnsureCreated();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context= new DataContext();
            _context.VehicleTypes.Load();

            VehicleTypess();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
        }

        private void VehicleTypess()
        {
            _context.VehicleTypes.Load();
            var data = _context.VehicleTypes.Local.ToList();
            cmbVehicleType.DisplayMember = "Name";
            cmbVehicleType.ValueMember = "Id";
            cmbVehicleType.DataSource = data;
        }
    }
}
