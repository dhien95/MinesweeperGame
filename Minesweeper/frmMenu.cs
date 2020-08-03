using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            frmPlay frm = new frmPlay(1);
            frm.ShowDialog();
           
        }

        private void btn2Player_Click(object sender, EventArgs e)
        {
            frmPlay frm = new frmPlay(2);
            frm.ShowDialog();
            
        }

        private void btnSetupGame_Click(object sender, EventArgs e)
        {
            frmPlay frm = new frmPlay(0);
            frm.ShowDialog();
            
        }

        private void btnSeeRankings_Click(object sender, EventArgs e)
        {
            frmShow frm = new frmShow(1);
            frm.ShowDialog();
        }

        private void btnSeeRules_Click(object sender, EventArgs e)
        {
            frmShow frm = new frmShow(2);
            frm.ShowDialog();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này nhóm em chưa làm kịp!!");
        }
    }
}
