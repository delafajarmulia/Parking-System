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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void SayHello(string name)
        {
            lblSayHay.Text = $"Welcome, {name}";
            lblDate.Text = DateTime.Now.ToString("[ddd] dd-MM-yyyy, hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterMember mastermember = new MasterMember();
            mastermember.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MasterVehicle mastervehicle = new MasterVehicle();
            mastervehicle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.ShowDialog();
        }
    }
}
