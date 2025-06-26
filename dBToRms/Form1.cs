using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dBToRms
{    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RmsCal rcal = new RmsCal();            
            
            double doubleValue = Double.Parse(dBTextbox.Text);

            rmsTextbox.Text = rcal.DecibellToRms(doubleValue).ToString();            
        }
    }

    public class RmsCal
    {
        public double step1;
        public double step2;

        public double DecibellToRms(double decibell)
        {
            step1 = decibell / 20;
            step2 = Math.Pow(10, step1);

            return step2;
        }
    }
}
