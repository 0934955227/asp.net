using quan_ly_cafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace quan_ly_cafe.DAO
{
    public class DOANHTHUDAO
    {
        private static DOANHTHUDAO instance;

        public static DOANHTHUDAO Instance
        {
            get { if (instance == null) instance = new DOANHTHUDAO(); return DOANHTHUDAO.instance; }
            private set { DOANHTHUDAO.instance = value; }
        }
        private DOANHTHUDAO() { }
        //Tạo 1 dữ liệu quản lý mới 
        public bool themdoanhthu(DOANHTHUDTO dt)
        {
           string sql = "insert into DOANHTHU values('"+dt.Username+"','"+dt.Mamon+"','"+dt.Soluong+"','"+dt.Thanhtien+"','"+dt.Ngayban+"')";
           int result = Dataprovider.Instance.ExNonQuery(sql);
            return result>0;
        }
         public List<DOANHTHUDTO> danhsachthem()
            {
             List<DOANHTHUDTO> ds = new List<DOANHTHUDTO>();
             string sql = "select USERNAME,MAMON,SOLUONG,THANHTIEN,NGAYBAN from HOADON WHERE THANHTOAN = 1";
             DataTable da = Dataprovider.Instance.Query(sql);
             foreach (DataRow item in da.Rows )
             { 
                 DOANHTHUDTO dt = new DOANHTHUDTO(item);
                 ds.Add(dt);
             }
             return ds;
        }
         public DataTable doanhthutheomon(string ngayban)
         {
             string sql =
             "select MON.TENMON,SUM( DOANHTHU.SOLUONG) as SOLUONG ,SUM( DOANHTHU.THANHTIEN) as THANHTIEN from MON, DOANHTHU where MON.MAMON = DOANHTHU.MAMON and NGAYBAN = '" + ngayban + "' GROUP BY MON.TENMON, DOANHTHU.MAMON ";
             DataTable result = Dataprovider.Instance.Query(sql);
             return result;
         }
         public DataTable doanhthutheoloai(string loai ,string ngayban)
         {
             string sql =
             "select MON.TENMON,SUM( DOANHTHU.SOLUONG) as SOLUONG ,SUM( DOANHTHU.THANHTIEN) as THANHTIEN from MON, DOANHTHU where MON.MAMON = DOANHTHU.MAMON and NGAYBAN = '" + ngayban + "' and MON.LOAI='"+loai+"' GROUP BY MON.TENMON, DOANHTHU.MAMON ";
             DataTable result = Dataprovider.Instance.Query(sql);
             return result;
         }
    }
}