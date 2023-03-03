using Microsoft.EntityFrameworkCore;
using ParkingSystem.Model;

namespace ParkingSystem
{
    public partial class Form1 : Form
    {
        private DataContext? _context;

        public Form1()
        {
            InitializeComponent();

            _context = new DataContext();
            _context.Database.EnsureCreated();
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Employee? employee = await _context.Employees
                .Where(c => c.Id == int.Parse(txtId.Text))
                .FirstOrDefaultAsync();

            if (employee.Password != txtPw.Text)
            {
                MessageBox.Show("data tidak ditemukan");
            }
            else
            {
                Form2 frm2 = new Form2();
                frm2.SayHello(employee.Name);
                frm2.ShowDialog();
            }

        }
    }
}