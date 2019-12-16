using quan_ly_cafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace quan_ly_cafe
{
    public partial class datmon : System.Web.UI.Page
    {
        private static datmon instance;

        public static datmon Instance
        {
            get { if (instance == null) instance = new datmon(); return datmon.instance; }
            set { datmon.instance = value; }
        }
        public datmon() { }
        string diachi = "datmonnv.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"]==null || Session["ban"] ==null )
            {
                Response.Redirect("login.aspx");
            }
            if(!IsPostBack)
            {
                hienthidanhsachmon();
                lbtenban.Text = Session["ban"].ToString();
                string user = Session["user"].ToString();
                lbnv.Text = NGUOIDUNGDAO.Instance.hienthinhanvien(user);
            }           
        }
        //hien thị danh sách món
        public void hienthidanhsachmon()
        {
            dsmon.DataSource = MONDAO.Instance.hienthimon();
            dsmon.DataBind();
        }

        protected void btncf_Click(object sender, EventArgs e)
        {
            dsmon.DataSource = MONDAO.Instance.hienthimoncf();
            dsmon.DataBind();
        }

        protected void btnnuocep_Click(object sender, EventArgs e)
        {
            dsmon.DataSource = MONDAO.Instance.hienthimonnuocep();
            dsmon.DataBind();
        }

        protected void btntrasua_Click(object sender, EventArgs e)
        {
            
                dsmon.DataSource = MONDAO.Instance.hienthimontrasua();
                dsmon.DataBind();
           
        }

        protected void btnsuachua_Click(object sender, EventArgs e)
        {
            dsmon.DataSource = MONDAO.Instance.hienthimonsuachua();
            dsmon.DataBind();
        }
        //Chọn món 
        protected void dsmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GridViewRow row = dsmon.SelectedRow;
            int mamon = int.Parse(row.Cells[0].Text.ToString());
            int dongia = int.Parse(row.Cells[2].Text.ToString());
            string session = mamon.ToString();
            Session["mamon"] = session;
            lbtenmon.Text = MONDAO.Instance.tenmon(mamon);
            lbgia.Text = dongia.ToString();
        }
        //Sự kiện khi nhấn nút tìm kiếm món
        protected void btntim_Click(object sender, EventArgs e)
        {
            string keyword = txttenmon.Text.ToString();
            int kw;
            Int32.TryParse(keyword, out kw);
            if(kw >0 )
            {
                int mamon = int.Parse(keyword.ToString());
                dsmon.DataSource = MONDAO.Instance.timkiemtheomamon(mamon);
                dsmon.DataBind();
 
            }
            else
                {
                dsmon.DataSource = MONDAO.Instance.timkiemtheoten(keyword);
                dsmon.DataBind();
                 }       
            if (dsmon.Rows.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Không tìm thấy dữ liệu về món');location.href='/datmonnv.aspx';", true);
            }         
        }
        protected void dsmon_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dsmon.PageIndex = e.NewPageIndex;
            this.hienthidanhsachmon();
        }
        //Lấy các giá trị trong giao diện để lưu vào CSDL
        private HOADONDTO laygiatrituform()
        {
            int maban = BANDAO.Instance.maban(lbtenban.Text);
            string user = Session["user"].ToString();
            int mamon = int.Parse(Session["mamon"].ToString());
            int soluong = int.Parse(txtsl.Text.ToString());
            int dongia = int.Parse(lbgia.Text.ToString());
            int thanhtien = dongia * soluong;
            string ngayban = DateTime.Today.ToShortDateString();
            string ghichu = txtghichu.Text.ToString();            
            HOADONDTO hoadon = new HOADONDTO(maban, user, mamon, soluong, thanhtien, ngayban, ghichu);
            return hoadon;
        }
        //Dùng kiểu public cho các phương thức được gọi lại trong các Class khác

        //Thêm một hóa đơn
        public bool taohoadonmoi(int maban, string user, int mamon, int soluong, int thanhtien, string ngayban, string ghichu)
        {
            bool kt = new bool();
            HOADONDTO hoadon = new HOADONDTO(maban, user, mamon, soluong, thanhtien, ngayban, ghichu);
            bool them = HOADONDAO.Instance.datmon(hoadon);
            if (them)
            {
                kt = true;             
            }
            else
            {
                kt = false;
            }
            return kt;
        }
        // Thêm hóa đơn hoàn chỉnh 
        public bool themmon(int maban, string user, int mamon, int soluong, int thanhtien, string ngayban, string ghichu)
        {
            bool check = new bool();
            HOADONDTO hoadon = new HOADONDTO(maban, user, mamon, soluong, thanhtien, ngayban, ghichu);
            bool kiemtra = HOADONDAO.Instance.kiemtracomonchuaguibep(maban, mamon); //Thực hiện kiểm tra có hóa đơn trùng món chưa gửi bếp không
            if (kiemtra) // Mếu có hóa đơn trùng món và chưa gửi bếp
            {
                bool themsoluong = HOADONDAO.Instance.tangsoluongmon(maban, mamon, soluong); // Cập nhật thêm số lượng vào hóa đơn đó
                if (themsoluong)
                {
                    int dongia = MONDAO.Instance.dongia(mamon);
                    bool capnhattien = HOADONDAO.Instance.capnhatthanhtien(maban, mamon, dongia); // Cập nhật lại thành tiền trong hóa đơn
                    if (capnhattien)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            else // Nếu không có hóa đơn trùng món và chưa gửi bếp
            {
                check = taohoadonmoi(maban, user, mamon, soluong, thanhtien, ngayban, ghichu);  //Gọi phương thức thêm hóa đơn mới.
            }
            return check;
        }

        
        //Thông báo lên trên màn hình sau khi thực hiện các lệnh
        public void thongbaothanhcong(Page a , string diachi )
        {
            ScriptManager.RegisterStartupScript( a , a.GetType(), "alert", "alert('thành công');location.href= '/" + diachi + "';", true);
        }
        public void thongbaothatbai(Page a, string diachi)
        {
            ScriptManager.RegisterStartupScript(a, a.GetType(), "alert", "alert('thất bại');location.href= '/" + diachi + "';", true);
        }
        
        //Sự kiện nhấn vào nút xác nhận
        protected void btnxacnhan_Click(object sender, EventArgs e)
        {
            string tenmon = lbtenmon.Text.ToString();
            string sl = txtsl.Text.ToString();           
            if(tenmon == "" || sl == "" ) // Kiểm tra các dữ liệu có bị trống không
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bạn phải chọn món và nhập số lượng món');location.href='/datmonnv.aspx';", true);
            }
            else // So sánh khi dữ liệu đầy đủ
            {
                int soluong = int.Parse(sl);
                if(soluong<=0) // Số lượng nhập vào < 0 
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bạn phải nhập số lượng món > 0');location.href='/datmonnv.aspx';", true);
                }
                else //Các thông tin đều hợp lệ
                {
                   HOADONDTO hoadon = laygiatrituform();
                    //Khai báo 1 biến check kiểu bool thực hiện gọi phương thức thêm hóa đơn hoàn chỉnh 
                   bool check =  themmon(hoadon.Maban,hoadon.User,hoadon.Mamon,hoadon.Soluong,hoadon.Thanhtien,hoadon.Ngayban,hoadon.Ghichu);                                 
                   if(check == true) 
                   {
                       thongbaothanhcong(this, diachi);
                   }
                    else
                   {
                       thongbaothatbai(this,diachi);
                   }
                }
            }           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("phieutamtinhnv.aspx");
            //Session["ban"] = lbtenban.Text.ToString();
        }

        



       
    }
}