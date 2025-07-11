using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesaplayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string panelHeightDifference = textBox1.Text; //Gets panel height diffrence value from textBox1

            double minimumSolarElevationAngleDeg = Convert.ToDouble(textBox2.Text) //Gets minimum solar elevation angle value from textBox2 and covnerts the string to double
           , angleRad = minimumSolarElevationAngleDeg * Math.PI / 180, tanAngle = Math.Tan(angleRad); 

            double pitchDistance = Convert.ToDouble(panelHeightDifference) / tanAngle; //Calculates the pitch distance by the formula ( pitch = (rear-to-front panel height difference) / tan(minimum solar elevation angle) )
            
            textBox3.Text = pitchDistance.ToString("F4"); //Displays the pitch distance rounded to 4 decimal places

        }
    }
}
