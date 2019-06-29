using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public VehicleUi()
        {
            InitializeComponent();
        }
        VehicleClass vehicleClass = new VehicleClass();

        private void ShowButton_Click(object sender, EventArgs e)
        {
            maxSpeedTextBox.Text = vehicleClass.GetMaximumSpeed().ToString();
            minSpeedTextBox.Text = vehicleClass.GetMinimumSpeed().ToString();
            averageSpeedTextBox.Text = vehicleClass.GetAverageSpeed().ToString();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            vehicleClass.Name = vehicleNameTextBox.Text;
            vehicleClass.Name = regNoTextBox.Text;
            vehicleClass.Speed = new List<int>();
            MessageBox.Show("Create successfull");
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(speedTextBox.Text);
            vehicleClass.Speed.Add(speed);
            MessageBox.Show("Speed  is Entered");
        }

    }
}
