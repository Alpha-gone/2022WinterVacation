using MyWcfWindowsForms.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWcfWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnMaxNum.Click += BtnMaxNum_Click;
        }

        private void BtnMaxNum_Click(object sender, EventArgs e)
        {
            Service1Client service = new Service1Client();
            txtMaxNum.Text = service.GetMax(txtInputNum.Text);
            txtMinNum.Text = service.GetMin(txtInputNum.Text);
            txtSumNum.Text = service.GetSum(txtInputNum.Text);
            txtAvgNum.Text = service.GetAvg(txtInputNum.Text);
            
        }
    }
}
