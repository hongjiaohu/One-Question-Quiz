using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Question_Quiz
{
    public partial class frmOneQuestionQuiz : Form
    {
        public frmOneQuestionQuiz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "correct";
        }

        private void lblQuestion_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void re5_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            lblResult.Text = "flase";

        }

        private void re0_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "ture";
        }

        private void re3_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "great";
        }

        private void re2_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "bad";
        }

        private void re4_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "good";
        }

        private void grbRadiobattons_Enter(object sender, EventArgs e)
        {

        }
    }
}
