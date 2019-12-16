using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace quan_ly_cafe.DAO
{
    public class HOADONDAO
    {
         private static HOADONDAO instance;

        public static HOADONDAO Instance
        {
            get { if (instance == null) instance = new HOADONDAO(); return HOADONDAO.instance; }
            private set { HOADONDAO.instance = value; }
        }
        private HOADONDAO() { }
        //Tạo một hóa đơn mới
        public bool datmon(HOADONDTO hoadon)
        {
            string sql = "INSERT INTO HOADON(MABAN,USERNAME, MAMON ,SOLUONG,THANHTIEN,GUIBEP,THANHTOAN,NGAYBAN,CHUTHICH) values( '" + hoadon.Maban + "', '" + hoadon.User + "',N'" + hoadon.Mamon + "', '" + hoadon.Soluong + "','" + hoadon.Thanhtien + "','False','False','"+hoadon.Ngayban+"',N'"+hoadon.Ghichu+"')";
            int result = Dataprovider.Instance.ExNonQuery(sql);
            return result > 0;
        }
        //Hiển thị danh sách phiếu tạm tính
        public DataTable phieutamtinh(int tenban)
        {
            string sql = "select MON.TENMON , SUM(HOADON.SOLUONG) AS SOLUONG, SUM(HOADON.THANHTIEN) AS THANHTIEN FROM MON, HOADON WHERE MON.MAMON = HOADON.MAMON AND MABAN = '" + tenban + "' GROUP BY HOADON.MAMON, MON.TENMON ";
            DataTable da = Dataprovider.Instance.Query(sql);
            return da;
        }
        //Cập nhật món gửi bếp
        public bool guibep(int maban)
        { 
        string sql = "update HOADON set GUIBEP = 1 WHERE MABAN = '"+ maban+"'   ";
        int result = Dataprovider.Instance.ExNonQuery(sql);
        return result>0;
        }
    }
}