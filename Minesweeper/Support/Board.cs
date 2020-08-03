using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Media;

namespace Minesweeper.Support
{
    public class Board
    {
        public int SoGiay { get; set; }
        public int SoMinSetup { get; set; }
        public Panel pnlContain { get; set; }
        public Panel pnlPlay { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int NumMines { get; set; }
        public btnCell[,] btnCells { get; set; }
        private int CorrectMines { get; set; }
        private int IncorrectMines { get; set; }
        public Panel PnlPlayState { get; set; }
        public Timer TimeRun { get; set; }
        public bool checkThua { get; set; }
        public bool checkLuuGameThang { get; set; }
        public int ChucNang { get; set; }


        public Board()
        {

        }

        //constructor tạo board
        public Board(Panel pnlcontain, Panel pnlplay, int width, int height, int mines, Panel pnlTrangThaiChoi, int chucNang)
        {
            this.pnlContain = pnlcontain;
            this.pnlPlay = pnlplay;
            this.Width = width;
            this.Height = height;
            this.NumMines = mines;
            this.btnCells = new btnCell[width, height];
            this.PnlPlayState = pnlTrangThaiChoi;
            this.PnlPlayState.Controls[0].BackColor = Color.Lime;
            this.PnlPlayState.Controls[1].BackColor = Color.DimGray;
            this.SoMinSetup = 0;
            this.checkThua = false;
            this.checkLuuGameThang = false;
            this.ChucNang = chucNang;
            this.pnlPlay.Controls.Clear();

            if (chucNang != 2)
            {
                this.PnlPlayState.Controls[0].Visible = false;
                this.PnlPlayState.Controls[1].Visible = false;
            }
            else
            {
                this.PnlPlayState.Controls[0].Visible = true;
                this.PnlPlayState.Controls[1].Visible = true;
            }
        }

        public Timer SetTimer()
        {
            Timer time = new Timer();
            time.Interval = 1000;
            time.Tick += this.timeRun_Tick;
            return time;
        }

        private void timeRun_Tick(object sender, EventArgs e)
        {
            this.SoGiay++;
            this.PnlPlayState.Controls[3].Text = this.SoGiay.ToString();
        }

        //tạo 1 board mới cho trường hợp chơi mới hoặc trường hợp setup
        public void SetupBoard(bool setup)
        {
            for (var x = 1; x <= this.Width; x++)
            {
                for (var y = 1; y <= this.Height; y++)
                {
                    if (setup == false)
                    {
                        var c = new btnCell
                        {
                            XLoc = x - 1,
                            YLoc = y - 1,
                            CellState = CellState.Closed,
                            CellType = CellType.Regular,
                            CellSize = 40,
                            Board = this
                        };
                        c.SetHienThiCell();
                        c.MouseDown += Cell_MouseClick;
                        this.btnCells[x - 1, y - 1] = c;
                        this.pnlPlay.Controls.Add(c);
                    }
                    else
                    {
                        var c = new btnCell
                        {
                            XLoc = x - 1,
                            YLoc = y - 1,
                            CellState = CellState.Opened,
                            CellType = CellType.Regular,
                            CellSize = 40,
                            Board = this
                        };

                        c.SetHienThiCell();
                        c.Click += SetupCell_Click;
                        this.btnCells[x - 1, y - 1] = c;
                        this.pnlPlay.Controls.Add(c);
                    }
                }
            }

            this.SoGiay = 0;
            this.PnlPlayState.Controls[3].Text = this.SoGiay.ToString();
            this.TimeRun = SetTimer();
            //this.TimeRun.Start();
            this.CorrectMines = 0;
            this.IncorrectMines = 0;
            this.pnlPlay.SetBounds((this.pnlContain.Size.Width - this.Width * 40) / 2, (this.pnlContain.Size.Height - this.Height * 40) / 2, this.Width * 40, this.Height * 40);
            this.pnlPlay.Anchor = AnchorStyles.Top & AnchorStyles.Right & AnchorStyles.Bottom & AnchorStyles.Left;

            this.checkThua = false;
            this.checkLuuGameThang = false;
            this.PnlPlayState.Controls[4].BackgroundImage = Image.FromFile("Images\\faceVui.PNG");
        }

        //Tạo lại Board có sẵn từ database
        public void SetupBoardCoSan(List<Cell> lst, int thoiGian)
        {
            // tạo board với các cell được lấy từ DB
            for (var x = 1; x <= this.Width; x++)
            {
                for (var y = 1; y <= this.Height; y++)
                {
                    Cell cell = lst[(x - 1) * Height + y - 1];
                    var c = new btnCell
                    {
                        XLoc = x - 1,
                        YLoc = y - 1,
                        CellState = (CellState)cell.cellState,
                        CellType = (CellType)cell.cellType,
                        CellSize = 40,
                        Board = this
                    };

                    c.SetHienThiCell();
                    c.MouseDown += Cell_MouseClick;

                    this.btnCells[x - 1, y - 1] = c;
                    this.pnlPlay.Controls.Add(c);
                }
            }

            //hiển thị các số lân cận cell chứa mìn
            for (var x = 0; x < this.Width; x++)
            {
                for (var y = 0; y < this.Height; y++)
                {
                    this.btnCells[x, y].NumMines = this.btnCells[x, y].GetNeighborCells().Where(n => n.IsMine()).Count();
                    this.btnCells[x, y].UpdateDisplay();
                    if (this.btnCells[x, y].CellType == CellType.Mine && this.btnCells[x, y].CellState == CellState.Flag)
                        this.CorrectMines++;
                }
            }

            // cập nhật các hiển thị trên board, và panel chứa board
            this.PnlPlayState.Controls[2].Text = Convert.ToString(this.NumMines - this.CorrectMines);
            this.SoGiay = thoiGian;
            this.PnlPlayState.Controls[3].Text = this.SoGiay.ToString();
            this.TimeRun = SetTimer();

            this.pnlPlay.SetBounds((this.pnlContain.Size.Width - this.Width * 40) / 2, (this.pnlContain.Size.Height - this.Height * 40) / 2, this.Width * 40, this.Height * 40);
            this.pnlPlay.Anchor = AnchorStyles.Top & AnchorStyles.Right & AnchorStyles.Bottom & AnchorStyles.Left;

            this.checkThua = false;
            this.checkLuuGameThang = false;
            this.PnlPlayState.Controls[4].BackgroundImage = Image.FromFile("Images\\faceVui.PNG");
        }

        // xét vị trí ngẫu nhiên cho các mìn sẽ hiển thị trên board khi tạo 1 board mới
        public void PlaceMines()
        {
            var minesPlaced = 0;
            var random = new Random();

            while (minesPlaced < this.NumMines)
            {
                int x = random.Next(0, this.Width);
                int y = random.Next(0, this.Height);

                if (!this.btnCells[x, y].IsMine())
                {
                    this.btnCells[x, y].CellType = CellType.Mine;
                    minesPlaced += 1;
                }
            }

            for (var x = 0; x < this.Width; x++)
            {
                for (var y = 0; y < this.Height; y++)
                {
                    var c = this.btnCells[x, y];
                    c.UpdateDisplay();
                    c.NumMines = c.GetNeighborCells().Where(n => n.IsMine()).Count();
                }
            }
        }

        //hàm đổi màu của 2 control
        public void DoiBackColor(Control lbl1, Control lbl2)
        {
            Color temp;
            temp = lbl1.BackColor;
            lbl1.BackColor = lbl2.BackColor;
            lbl2.BackColor = temp;
        }

        // xử lý sự kiện khi người chơi click chuột trái để mở cell và chuột phải để đặt cờ
        private void Cell_MouseClick(object sender, MouseEventArgs e)
        {
            var cell = (btnCell)sender;

            // Cell đã mở
            if (cell.CellState == CellState.Opened)
                return;
            switch (e.Button)
            {
                // click chuột trái để mở cell
                case MouseButtons.Left:
                    if (cell.CellState != CellState.Flag)
                    {
                        if (cell.OnClick())
                        {
                            this.TimeRun.Stop();
                            SetAmThanh(false);
                            if (ChucNang == 2)
                            {
                                if (this.PnlPlayState.Controls[0].BackColor == Color.Lime)
                                    MessageBox.Show(this.PnlPlayState.Controls[0].Text + " đã thua!!");
                                else
                                    MessageBox.Show(this.PnlPlayState.Controls[1].Text + " đã thua!!");
                            }
                            else
                                MessageBox.Show("Bạn thua rồi!!");

                            foreach (btnCell c in btnCells)
                            {
                                c.CellState = CellState.Opened;
                                c.UpdateDisplay();
                            }
                            this.pnlPlay.Enabled = false;
                            this.checkThua = true;
                            this.PnlPlayState.Controls[4].BackgroundImage = Image.FromFile("Images\\faceFail.PNG");
                            //this.RestartGame();
                        }

                    }
                    break;

                // click chuột phải để đặt flag
                case MouseButtons.Right:
                    if (cell.CellState == CellState.Closed)
                        DoiBackColor(this.PnlPlayState.Controls[0], this.PnlPlayState.Controls[1]);
                    int flagMine = cell.OnFlag();
                    if (flagMine % 2 == 0)
                        this.IncorrectMines += flagMine / 2;
                    else this.CorrectMines += flagMine;
                    break;

                default:
                    return;
            }

            this.PnlPlayState.Controls[2].Text = Convert.ToString(this.NumMines - this.CorrectMines);
            //Kiểm tra thắng
            this.checkLuuGameThang = CheckWin();
            if (this.checkLuuGameThang)
                this.PnlPlayState.Controls[4].BackgroundImage = Image.FromFile("Images\\faceWin.PNG");
        }

        //hàm xử lý trường hợp chiến thắng
        public bool CheckWin()
        {
            if (this.CorrectMines == NumMines && this.IncorrectMines == 0)
            {
                this.TimeRun.Stop();
                SetAmThanh(true);
                foreach (btnCell cell in btnCells)
                {
                    cell.CellState = CellState.Opened;
                    cell.UpdateDisplay();
                    if (cell.CellType == CellType.Mine)
                    {
                        cell.BackgroundImageLayout = ImageLayout.Stretch;
                        cell.BackgroundImage = Image.FromFile("Images\\mineClosed.PNG");
                    }
                }

                if (ChucNang == 2)
                {
                    if (this.PnlPlayState.Controls[0].BackColor == Color.Lime)
                        MessageBox.Show(this.PnlPlayState.Controls[0].Text + " đã thắng!!");
                    else
                        MessageBox.Show(this.PnlPlayState.Controls[1].Text + " đã thắng!!");
                }

                pnlPlay.Enabled = false;
                return true;
            }

            return false;

        }
        
        //Sự kiện click khi setup game mới để chơi
        private void SetupCell_Click(object sender, EventArgs e)
        {
            var cell = (btnCell)sender;

            if (cell.CellType == CellType.Mine)
            {
                cell.CellType = CellType.Regular;
                this.SoMinSetup--;
            }
            else
            {
                if (this.SoMinSetup < this.NumMines)
                {
                    cell.CellType = CellType.Mine;
                    this.SoMinSetup++;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn đã chọn đủ số mìn!!\nClick nút OK để CHƠI!!",
                            "Thông báo:", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.OK)
                    {
                        ChoiGameSetup();
                        this.PnlPlayState.Controls[4].BackgroundImage = Image.FromFile("Images\\faceNgacNhien.PNG");

                    }
                    else
                        return;
                }
                cell.UpdateDisplay();
            }
        }

        //Tạo board sau khi người chơi chọn đủ số mìn tương ứng cho mỗi cấp
        public void ChoiGameSetup()
        {

            List<Cell> lstC = new List<Cell>();
            for (var y = 0; y < this.Height; y++)
            {
                for (var x = 0; x < this.Width; x++)
                {
                    Cell cell = new Cell();
                    var c = (btnCell)this.pnlPlay.Controls[y * this.Width + x];
                    cell.cellState = (int)CellState.Closed;
                    cell.cellType = (int)c.CellType;
                    lstC.Add(cell);
                }
            }
            this.pnlPlay.Controls.Clear();
            SetupBoardCoSan(lstC, 0);
        }

        //reset game mới
        public void RestartGame()
        {
            // Khởi tạo một game mới
            this.TimeRun.Stop();
            this.pnlPlay.Controls.Clear();
            this.SetupBoard(false);
            this.PlaceMines();
        }

        //Get danh sách cell để lưu database
        public List<Cell> GetDSCell()
        {
            List<Cell> lst = new List<Cell>();
            for (var x = 0; x < this.Width; x++)
            {
                for (var y = 0; y < this.Height; y++)
                {
                    Cell cell = new Cell();
                    cell.cellType = (int)this.btnCells[x, y].CellType;
                    cell.cellState = (int)this.btnCells[x, y].CellState;
                    lst.Add(cell);
                }
            }
            return lst;
        }

        //set âm thanh khi thắng hoặc thua
        public void SetAmThanh(bool checkThang)
        {
            SoundPlayer amThanh;
            if (checkThang)
            {
                amThanh = new SoundPlayer("Sounds\\win.wav");

            }
            else
            {
                amThanh = new SoundPlayer("Sounds\\fail.wav");
            }
            amThanh.Play();
        }
    }
}
