using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;


namespace Minesweeper.DAL
{
    public class SetDAL
    {
        DB_MinesweeperDataContext db;
        public SetDAL()
        {
            db = new DB_MinesweeperDataContext();
        }

        //Cách sét lại giá trị identity về giá trị mới
        //db.ExecuteCommand("DBCC CHECKIDENT('<MyTable>', RESEED, <NewValue>);");

        public bool SaveLuotChoi(LuotChoi lc, List<Cell> dsCell)
        {
            db.Connection.Open(); //Mở 1 connection tới DB
            //Khởi tạo 1 transactions với SQL
            DbTransaction trans = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = trans;
                //Thêm lượt chơi
                db.LuotChois.InsertOnSubmit(lc);
                db.SubmitChanges();

                //Thêm danh sách Cell
                foreach (Cell c in dsCell)
                {
                    db.Cells.InsertOnSubmit(c);
                    db.SubmitChanges();
                }
                
                db.Transaction.Commit();
                db.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                db.Transaction.Rollback();
                db.Connection.Close();
                throw new Exception("Lỗi SQL: " + ex.Message);

            }
        }

        public void DeleteLuotChoi(int malc, List<Cell> dsCell)
        {
            db.Connection.Open();
            DbTransaction trans = db.Connection.BeginTransaction();
            try
            {
                db.Transaction = trans;
                
                //Xóa lượt chơi (sẽ xóa luôn được tham chiếu đến bảng DSCell_LuotChoi ứng với lượt chơi đã xóa)
                var q = db.LuotChois.FirstOrDefault(l => l.maLuotChoi == malc);
                //db.LuotChois.Attach(lc);
                db.LuotChois.DeleteOnSubmit(q);
                db.SubmitChanges();
                
                
                db.Transaction.Commit();
                db.Connection.Close();
            }
            catch (Exception ex)
            {
                db.Transaction.Rollback();
                db.Connection.Close();
                throw new Exception("Lỗi SQL: " + ex.Message);

            }
        }

    }
}
