using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Minesweeper.DAL;

namespace Minesweeper
{
    public partial class frmShow : Form
    {
        GetDAL getData;

        enum chucNang : byte
        {
            seeRankings = 1,
            seeRules = 2
        };
        chucNang chucnangs;

        public frmShow(byte cn)
        {
            InitializeComponent();
            getData = new GetDAL();
            chucnangs = (chucNang)cn;
        }

        void HienThiFormTheoChucNang(chucNang cn)
        {
            if (cn == chucNang.seeRankings)
            {
                this.lvwRankings.Visible = true;
                this.lblTitle.Text = "TOP 10";

                //Get top 10
                List<LuotChoi> lst = getData.GetLuotChoiCoKetQua();
                LoadListView(lst);
            }
            else // (cn == chucNang.seeRules)
            {
                this.lvwRankings.Visible = false;
                this.lblTitle.Text = "Quy tắc chơi";

                //Thêm richtextbox hiển thi quy tắc chơi
                RichTextBox rtxtRule = new RichTextBox();
                rtxtRule.Location = lvwRankings.Location;
                rtxtRule.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                rtxtRule.ReadOnly = true;
                rtxtRule.ScrollBars = RichTextBoxScrollBars.Vertical;
                rtxtRule.Size = lvwRankings.Size;
                pnlFill.Controls.Add(rtxtRule);

                string str = GetNoiDungQuyTacChoi();
                if (str != null)
                    rtxtRule.Text = str;
            }
        }

        //Đọc file .txt lưu trong thư mục bin\Debug
        string GetNoiDungQuyTacChoi()
        {
            string filePath = @"Rule.txt";
            string str;
            if (File.Exists(filePath))
            {
                str = File.ReadAllText(filePath);
                return str;
            }
            else
                return null;
        }

        
        void LoadListView(List<LuotChoi> lst)
        {
            lvwRankings.Items.Clear();
            foreach (var item in lst)
            {
                ListViewItem lvi = new ListViewItem((lvwRankings.Items.Count + 1).ToString());
                lvi.SubItems.Add(item.tenNguoiChoi);
                lvi.SubItems.Add(item.thoiGian.ToString());
                string tenCD = getData.GetLevelByMa(item.maCapDo).tenCapDo;
                lvi.SubItems.Add(tenCD);
                lvi.Tag = item.maLuotChoi;
                lvwRankings.Items.Add(lvi);
                
            }
        }

        private void frmShow_Load(object sender, EventArgs e)
        {
            HienThiFormTheoChucNang(chucnangs);
        }
    }
}
