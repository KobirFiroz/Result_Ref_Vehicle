using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultAppPractice1
{
    public partial class ResultUi : Form
    {
        public ResultUi()
        {
            InitializeComponent();
        }

        Result result = new Result();
        private void ShowButton_Click(object sender, EventArgs e)
        {
            result.Chemistry =Convert.ToInt32( chemistryTextBox.Text);
            result.Math = Convert.ToInt32(mathTextBox.Text);
            result.Physics = Convert.ToInt32(physicsTextBox.Text);

            averageTextBox.Text = result.GetAverage().ToString();
            greadeLetterTextBox.Text = result.GetGrade().ToString();

        }
    }
}
