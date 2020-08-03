using Minesweeper.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minesweeper.DAL;
using Microsoft.VisualBasic;

namespace Minesweeper
{
    public partial class frmPlay : Form
    {
        DB_MinesweeperDataContext db;
        GetDAL getData;
        SetDAL setData;
        Board board;
        CapDo c;
        private enum menuChucNang : int
        {
            setup = 0,
            play1 = 1,
            play2 = 2
        };
        menuChucNang chucNang;
        

        public frmPlay(int setupState)
        {
            InitializeComponent();
            this.chucNang = (menuChucNang) setupState;

            getData = new GetDAL();
            setData = new SetDAL();
        }

   
        private void frmPlay_Load(object sender, EventArgs e)
        {
            //Thêm dữ liệu cho combobox Level & thêm menu con của mnuLevel
            LoadComboBoxLevel();

            //Load game theo điều kiện, nếu cấp độ có game đã lưu => Load lại game lưu
            if ((int)this.chucNang == 1)
            {
                LoadGameByLevelFor1Player(1);
            }
            else if ((int)this.chucNang == 2)
                LoadGame(1);
            else // ((int)this.chucNang == 0)
                LoadGameBySetup();
            
            // set hiển thị trạng thái form ban đầu
            btnStart.Enabled = true;
            this.pnlPlay.Enabled = false;
            btnGuide.Enabled = false;
            btnResetGame.Enabled = false;
            
            switch (chucNang)
            {
                case menuChucNang.play1:
                    rdo1Player.Checked = true;
                    break;
                case menuChucNang.play2:
                    rdo2Player.Checked = true;
                    break;
                default:
                    rdo1Player.Checked = rdo2Player.Checked = false;
                    break;
            }
        }

        // Load game theo cấp độ ở chức năng chơi 1 người
        void LoadGameByLevelFor1Player(int maCD)
        {
            LuotChoi lcdaluu = getData.GetLuotChoiDaLuu(maCD);
            if (lcdaluu != null)
            {
                List<Cell> lstCell = new List<Cell>();
                lstCell = lcdaluu.Cells.ToList();

                setData.DeleteLuotChoi(lcdaluu.maLuotChoi, lstCell);
                LoadGameByGameSaved(maCD, lstCell, (int)lcdaluu.thoiGian);
            }
            else
                LoadGame(maCD);
        }

        // nút để bắt đầu trò chơi, lúc này thời gian mới đc tính
        private void btnStart_Click(object sender, EventArgs e)
        {
            //chức năng setup
            if (chucNang == menuChucNang.setup) 
            {
                // sau khi chi=ọn mìn xong, và bắt đầu chơi game
                if (this.board.btnCells[0, 0].CellState == CellState.Closed)
                {
                    board.TimeRun.Start();
                    btnGuide.Enabled = true;
                    btnResetGame.Enabled = false;
                }
                else // đang chọn mìn
                {
                    btnResetGame.Enabled = false;
                    btnGuide.Enabled = false;
                }
            }
            else // chức năng chơi 1 người hoặc 2 người
            {
                board.TimeRun.Start();
                btnResetGame.Enabled = true;
                btnGuide.Enabled = true;
            }
            btnStart.Enabled = false;
            this.pnlPlay.Enabled = true;
        }

        // thêm dữ liệu cho combobox level
        void LoadComboBoxLevel()
        {
            //gán dữ liệu cho combobox
            db = new DB_MinesweeperDataContext();
            var q = db.CapDos.ToList();

            cboLevel.DataSource = q;
            cboLevel.ValueMember = "maCapDo";
            cboLevel.DisplayMember = "tenCapDo";
            cboLevel.SelectedIndex = 0;

            
        }

        // Load boad cho game mới
        void LoadGame(int ma)
        {
            getData = new GetDAL();
            c = getData.GetLevelByMa(ma);
            lblSoMinFlag.Text = c.soMin.ToString();
            board = new Board(pnlLayOut, pnlPlay, (int)c.soCot, (int)c.soDong, (int)c.soMin, pnlPlayState, (int)chucNang);

            board.SetupBoard(false);
            board.PlaceMines();
        }

        // Load boad cho game đã lưu
        void LoadGameByGameSaved(int ma,List<Cell> lstCell,int tg)
        {
            getData = new GetDAL();
            c = getData.GetLevelByMa(ma);
            lblSoMinFlag.Text = c.soMin.ToString();
            board = new Board(pnlLayOut, pnlPlay, (int)c.soCot, (int)c.soDong, (int)c.soMin, pnlPlayState, (int)chucNang);
            board.SetupBoardCoSan(lstCell, tg);
        }

        //Load boad cho chức năng setup
        void LoadGameBySetup()
        {
            btnStart.Enabled = true;
            getData = new GetDAL();
            CapDo c = getData.GetLevelByMa((int)cboLevel.SelectedValue);
            lblSoMinFlag.Text = c.soMin.ToString();
            board = new Board(pnlLayOut, pnlPlay, (int)c.soCot, (int)c.soDong, (int)c.soMin, pnlPlayState, (int)chucNang);
            board.pnlPlay.Controls.Clear();
            board.SetupBoard(true);
        }

        //Thực hiện khi người chơi thay đổi chức năng chơi 1 người hoặc 2 người; hay là thay đổi cấp độ chơi
        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            pnlPlay.Enabled = false;
            btnGuide.Enabled = false;
            btnResetGame.Enabled = false;

            //thay đổi trạng thái form theo chức năng người chơi chọn
            if (rdo1Player.Checked)
                chucNang = menuChucNang.play1;
            else if (rdo2Player.Checked)
                chucNang = menuChucNang.play2;
            else
            {
                MessageBox.Show("Bạn hãy chọn số Players!!");
                return;
            }
            
            // Load game ứng với từng chức năng được chọn
            try
            {
                board.TimeRun.Stop();
                pnlPlay.Controls.Clear();
                int ma = (int)cboLevel.SelectedValue;
                if ((int)this.chucNang == 1)
                {
                    LoadGameByLevelFor1Player(ma);
                }
                else //if ((int)this.chucNang == 2)
                    LoadGame(ma);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Thực hiện lưu game trước khi người chơi chưa chơi xong (đối với chức năng chơi 1 người)
        private void frmPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            board.TimeRun.Stop();
            if (chucNang==menuChucNang.play1 && !board.checkThua && !board.checkLuuGameThang)
            {
                SaveGame(null);
            }
        }

        // thực hiện khi có thay đổi cấp độ trong chức năng setup
        private void btnSetup_Click(object sender, EventArgs e)
        {
            rdo1Player.Checked = rdo2Player.Checked = false;
            chucNang = menuChucNang.setup;
            pnlPlay.Enabled = false;
            if (!btnStart.Enabled)
                this.board.TimeRun.Stop();
            LoadGameBySetup();
            
        }

        // Lưu kết quả khi người chơi chiến thắng và lọt vào top 10 người có kết quả cao nhất
        private void LuuKetQua()
        {
            if (chucNang==menuChucNang.play1)
            {
                List<LuotChoi> lcLuu = getData.GetLuotChoiCoKetQua();
                if (lcLuu.Count < 10)
                {
                    object ten = Interaction.InputBox("Bạn đã lọt vào Top 10, nếu bạn muốn lưu kết quả => hãy nhập tên của bạn!!", "Nhập tên");
                    if ((string)ten != "")
                        SaveGame((string)ten);
                }
                else
                {
                    float xepHangCuoi = (float)lcLuu[0].thoiGian / (float)lcLuu[0].CapDo.soMin;
                    int malc = lcLuu[0].maLuotChoi;
                    for (int i = 1; i < lcLuu.Count; i++)
                    {
                        float xepHang = (float)lcLuu[i].thoiGian / (float)lcLuu[i].CapDo.soMin;
                        if (xepHang > xepHangCuoi)
                        {
                            xepHangCuoi = xepHang;
                            malc = lcLuu[i].maLuotChoi;
                        }
                    }
                    float xepHangBoard = (float)board.SoGiay / (float)board.NumMines;
                    if (xepHangBoard < xepHangCuoi)
                    {
                        object ten = Interaction.InputBox("Bạn đã lọt vào Top 10, nếu bạn muốn lưu kết quả => hãy nhập tên của bạn!!", "Nhập tên");
                        if ((string)ten != "")
                        {
                            SaveGame((string)ten);
                            setData.DeleteLuotChoi(malc, getData.GetDSCellByMaLuotChoi(malc));
                        }
                    }
                }
            }
        }

        //Lưu lượt chơi đang chơi dở chưa xong vào bảng lượt chơi với tên người chơi là null
        public void SaveGame(string tenNguoiChoi)
        {
            try
            {
                int maCapDo = this.c.maCapDo;
                LuotChoi luot = new LuotChoi();
                var temp = getData.GetMaLuotChoiCuoi();
                luot.maLuotChoi = temp + 1;
                if (tenNguoiChoi != null)
                    luot.tenNguoiChoi = tenNguoiChoi;
                else
                    luot.tenNguoiChoi = null;
                luot.thoiGian = int.Parse(lblTime.Text);
                luot.maCapDo = maCapDo;

                List<Cell> lstCell = this.board.GetDSCell();
                foreach (Cell c in lstCell)
                {
                    int maC = getData.GetMaCellCuoi();
                    c.maCell = maC + 1+lstCell.IndexOf(c);
                    c.maLuotChoi = luot.maLuotChoi;
                }
                if (setData.SaveLuotChoi(luot, lstCell))
                {
                    MessageBox.Show("Thành công!!");
                }
                else
                    MessageBox.Show("Thất bại!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void pbxState_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (!board.checkThua && board.checkLuuGameThang)
            {
                btnGuide.Enabled = false;
                if (this.chucNang == menuChucNang.play1)
                    LuuKetQua();
                else
                    MessageBox.Show("Chúc mừng bạn đã thắng!!");
            }
            else if (!btnStart.Enabled)
                btnGuide.Enabled = false;
            if (chucNang == menuChucNang.setup && board.btnCells[0,0].CellState == CellState.Closed)
            {
                btnStart.Enabled = true;
                pnlPlay.Enabled = false;
            }
        }
        
        // nút hiển thị gợi ý cho người chơi
        private void btnGuide_Click(object sender, EventArgs e)
        {
            // tìm 1 vị trí không có mìn chưa được mở
            Random ran = new Random();
            int x = ran.Next(0, (int)this.c.soCot -1);
            int y = ran.Next(0, (int)this.c.soDong -1);
            if (!board.btnCells[x, y].IsMine() && board.btnCells[x, y].CellState == CellState.Closed)
            {
                board.btnCells[x, y].CellState = CellState.Opened;
                board.btnCells[x, y].UpdateDisplay();
            }
            else
                if(!HienThiCellGoiY())
                    MessageBox.Show("Tất cả đều là mìn");
        }

        // mở ô không có mìn mà hiển thị lên cho người chơi thấy
        private bool HienThiCellGoiY()
        {
            for(int y=0;y<this.c.soDong;y++)
                for(int x =0;x<this.c.soCot;x++)
                    if(!board.btnCells[x, y].IsMine() && board.btnCells[x, y].CellState == CellState.Closed)
                    {
                        board.btnCells[x, y].CellState = CellState.Opened;
                        board.btnCells[x, y].UpdateDisplay();
                        return true;
                    }
            return false;
        }

        // cho phép người chơi load lại 1 game mới ở cấp đô đang đc chọn
        private void btnResetGame_Click(object sender, EventArgs e)
        {
            board.RestartGame();
            board.pnlPlay.Enabled = false;
            btnStart.Enabled = true;
            btnResetGame.Enabled = false;
            btnGuide.Enabled = false;
        }

        #region Sự kiện của Menu

       
        private void mnu1PlayerLevel1_Click(object sender, EventArgs e)
        {
            if (this.board.pnlPlay.Enabled)
                this.board.TimeRun.Stop();
            btnStart.Enabled = true;
            this.pnlPlay.Enabled = false;
            btnGuide.Enabled = false;
            btnResetGame.Enabled = false;

            rdo1Player.Checked = true;
            chucNang = menuChucNang.play1;
            cboLevel.SelectedIndex = 0;
            LoadGameByLevelFor1Player(1);
        }
        
        private void mnu1PlayerLevel2_Click(object sender, EventArgs e)
        {
            if (this.board.pnlPlay.Enabled)
                this.board.TimeRun.Stop();
            btnStart.Enabled = true;
            this.pnlPlay.Enabled = false;
            btnGuide.Enabled = false;
            btnResetGame.Enabled = false;

            rdo1Player.Checked = true;
            chucNang = menuChucNang.play1;
            cboLevel.SelectedIndex = 1;
            LoadGameByLevelFor1Player(2);
        }
        
        private void mnu1PlayerLevel3_Click(object sender, EventArgs e)
        {
            if (this.board.pnlPlay.Enabled)
                this.board.TimeRun.Stop();
            btnStart.Enabled = true;
            this.pnlPlay.Enabled = false;
            btnGuide.Enabled = false;
            btnResetGame.Enabled = false;

            rdo1Player.Checked = true;
            chucNang = menuChucNang.play1;
            cboLevel.SelectedIndex = 2;
            LoadGameByLevelFor1Player(3);
        }
        
        private void mnu2PlayerLevel1_Click(object sender, EventArgs e)
        {
            if (this.board.pnlPlay.Enabled)
                this.board.TimeRun.Stop();
            btnStart.Enabled = true;
            this.pnlPlay.Enabled = false;
            btnGuide.Enabled = false;
            btnResetGame.Enabled = false;

            rdo2Player.Checked = true;
            chucNang = menuChucNang.play2;
            cboLevel.SelectedIndex = 0;
            LoadGame(1);
        }
        
        private void mnu2PlayerLevel2_Click(object sender, EventArgs e)
        {
            if (this.board.pnlPlay.Enabled)
                this.board.TimeRun.Stop();
            btnStart.Enabled = true;
            this.pnlPlay.Enabled = false;
            btnGuide.Enabled = false;
            btnResetGame.Enabled = false;

            rdo2Player.Checked = true;
            chucNang = menuChucNang.play2;
            cboLevel.SelectedIndex = 1;
            LoadGame(2);
        }

        private void mnu2PlayerLevel3_Click(object sender, EventArgs e)
        {
            if (this.board.pnlPlay.Enabled)
                this.board.TimeRun.Stop();
            btnStart.Enabled = true;
            this.pnlPlay.Enabled = false;
            btnGuide.Enabled = false;
            btnResetGame.Enabled = false;

            rdo2Player.Checked = true;
            chucNang = menuChucNang.play2;
            cboLevel.SelectedIndex = 2;
            LoadGame(3);
        }

        private void mnuSetupGame_Click(object sender, EventArgs e)
        {
            if (this.board.pnlPlay.Enabled)
                this.board.TimeRun.Stop();
            btnStart.Enabled = true;
            this.pnlPlay.Enabled = false;
            btnGuide.Enabled = false;
            btnResetGame.Enabled = false;

            rdo1Player.Checked = rdo2Player.Checked = false;
            chucNang = menuChucNang.setup;
            LoadGameBySetup();
        }
        

        private void mnuSeeRankings_Click(object sender, EventArgs e)
        {
            frmShow frm = new frmShow(1);
            frm.ShowDialog();
        }

        private void mnuSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này nhóm em chưa làm kịp!!");
        }

        private void mnuSeeRules_Click(object sender, EventArgs e)
        {
            frmShow frm = new frmShow(2);
            frm.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        
    }
}
