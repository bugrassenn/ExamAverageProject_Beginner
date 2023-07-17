using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamAverageProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int exam1, exam2, exam3, average;
            string status;

            exam1 = Convert.ToInt16(TxtExam1.Text);
            exam2 = Convert.ToInt16(TxtExam2.Text);
            exam3 = Convert.ToInt16(TxtExam3.Text);

            average = (exam1 * 40 / 100) + (exam2 * 30 / 100) + (exam3 * 30 / 100);
            
            if ( average >= 50 )
            {
               status = "Success";
            }
            else
            {
                status = "Failed";
            }

            TxtStatus.Text = average + " " + status;
        }
    }
}
