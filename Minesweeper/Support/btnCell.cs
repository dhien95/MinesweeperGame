using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minesweeper;

namespace Minesweeper.Support
{
    public enum CellType: byte
    {
        Regular = 0,
        Mine = 1
    }

    public enum CellState: int
    {
        Closed = 0,
        Opened = 1,
        Flag=2
    }

    public class btnCell : Button
    {
        public int XLoc { get; set; }
        public int YLoc { get; set; }
        public int CellSize { get; set; }
        public CellState CellState { get; set; }
        public CellType CellType { get; set; }
        public int NumMines { get; set; }
        public Board Board { get; set; }


        // gán giá trị Cell hiển thị lúc opened
        public void SetHienThiCell()
        {
            this.Location = new Point(XLoc * CellSize, YLoc * CellSize);
            this.Size = new Size(CellSize, CellSize);
            this.UseVisualStyleBackColor = false;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile("Images\\closed.PNG");
            this.Font = new Font("Verdana", 7.75F, FontStyle.Bold);
            this.UpdateDisplay();
        }

        // Return true nếu là mìn.
        public bool IsMine()
        {
            return this.CellType == CellType.Mine;
        }

        // xử lý sư kiện đặt cờ 
        public int OnFlag()
        {
            int dem=0;
            switch (this.CellState)
            {
                case CellState.Flag:
                    this.CellState = CellState.Closed;
                    dem = this.CellType==CellType.Mine ? -1 : -2;
                    break;
                case CellState.Closed:
                    this.CellState = CellState.Flag;
                    dem = this.CellType == CellType.Mine ? 1 : 2;
                    break;
                case CellState.Opened:
                    break;
                default:
                    throw new Exception(string.Format("Unknown cell type {0}", this.CellType));
            }
            this.UpdateDisplay();

            return dem;
        }

        // Xử lý sự kiện mở cell.
        public bool OnClick(bool recursiveCall = false)
        {
            // Đệ quy để mở các cell cho đến khi gặp những cell có mìn
            if (recursiveCall)
            {
                if (this.CellType != CellType.Regular || this.CellState != CellState.Closed)
                    return false;
            }

            // Nếu cell là mìn
            if (this.CellType == CellType.Mine)
            {
                this.CellState = CellState.Opened;
                this.UpdateDisplay();

                // mở hết tất cả các cell
                for (var x = 0; x < this.Board.Width; x++)
                {
                    for (var y = 0; y < this.Board.Height; y++)
                    {
                        this.Board.btnCells[x, y].CellState = CellState.Opened;
                        this.Board.btnCells[x, y].UpdateDisplay();
                    }
                }
                return true;
            }

            // Regular cell
            if (this.CellType == CellType.Regular)
            {
                this.CellState = CellState.Opened;
                this.UpdateDisplay();
            }

            // Mở các cell lân cận nếu không chứa mìn
            if (this.NumMines == 0)
            {
                var neighbors = this.GetNeighborCells();
                foreach (var n in neighbors)
                    n.OnClick(true);
            }
            return false;
        }

        // Lấy danh sách các cell lân cận
        public List<btnCell> GetNeighborCells()
        {
            var neighbors = new List<btnCell>();

            for (var x = -1; x < 2; x++)
            {
                for (var y = -1; y < 2; y++)
                {
                    // Không phải là neighbor!
                    if (x == 0 && y == 0)
                        continue;

                    // ngoài vùng neighbor
                    if (XLoc + x < 0 || XLoc + x >= Board.Width || YLoc + y < 0 || YLoc + y >= Board.Height)
                        continue;

                    neighbors.Add(Board.btnCells[XLoc + x, YLoc + y]);
                }
            }
            return neighbors;
        }
        
        // Cập nhật hiển thị cell
        public void UpdateDisplay()
        {
            // Cell is flagged
            if (this.CellState == CellState.Flag)
            {
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackgroundImage = Image.FromFile("Images\\flag.PNG");
                return;
            }

            // Cell is closed
            if (this.CellState == CellState.Closed)
            {
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackgroundImage = Image.FromFile("Images\\closed.PNG");
                return;
            }

            // Open mine
            if (this.CellType == CellType.Mine)
            {
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackgroundImage = Image.FromFile("Images\\mineOpened.PNG");
            }

            // Mở regular cell (Hiển thị số mìn xung quanh cell)
            if (this.CellType == CellType.Regular)
            {
                this.FlatStyle = FlatStyle.Standard;
                this.BackColor = Color.LightGray;
                this.ForeColor = this.GetCellColour();
                this.Text = this.NumMines > 0 ? string.Format("{0}", this.NumMines) : string.Empty;
                this.BackgroundImage = null;
            }
        }

        // set màu cho số hiển thị trên cell. 
        private Color GetCellColour()
        {
            switch (this.NumMines)
            {
                case 1:
                    return ColorTranslator.FromHtml("0x0000FE"); // 1
                case 2:
                    return ColorTranslator.FromHtml("0x186900"); // 2
                case 3:
                    return ColorTranslator.FromHtml("0xAE0107"); // 3
                case 4:
                    return ColorTranslator.FromHtml("0x000177"); // 4
                case 5:
                    return ColorTranslator.FromHtml("0x8D0107"); // 5
                case 6:
                    return ColorTranslator.FromHtml("0x007A7C"); // 6
                case 7:
                    return ColorTranslator.FromHtml("0x902E90"); // 7
                case 8:
                    return ColorTranslator.FromHtml("0x000000"); // 8
                default:
                    return ColorTranslator.FromHtml("0xffffff");
            }
        }
    }
}
