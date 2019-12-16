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
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Không tìm thấy dữ liệu về món');location.href='/datmon.aspx';", true);
            }         
        }


        protected void dsmon_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dsmon.PageIndex = e.NewPageIndex;
            this.hienthidanhsachmon();
        }
        //Lấy các giá trị trong giao diện để lưu vào CSDL
        public HOADONDTO laygiatrituform()
        {
            string ghichu;
            int maban = BANDAO.Instance.maban(lbtenban.Text);
            string user = Session["user"].ToString();
            int mamon = int.Parse(Session["mamon"].ToString());
            int soluong = int.Parse(txtsl.Text.ToString());
            int dongia = int.Parse(lbgia.Text.ToString());
            int thanhtien = dongia * soluong;
            string ngayban = DateTime.Today.ToShortDateString();
            ghichu = txtghichu.Text.ToString();            
            HOADONDTO hoadon = new HOADONDTO(maban, user, mamon, soluong, thanhtien, ngayban,ghichu);
            return hoadon;
        }
        //Sự kiện nhấn vào nút xác nhận
        protected void btnxacnhan_Click(object sender, EventArgs e)
        {
            string tenmon = lbtenmon.Text.ToString();
            string sl = txtsl.Text.ToString();           
            if(tenmon == "" || sl == "" )
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bạn phải chọn món và nhập số lượng món');location.href='/datmon.aspx';", true);
            }
            else
            {
                int soluong = int.Parse(sl);
                if(soluong<=0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bạn phải nhập số lượng món > 0');location.href='/datmon.aspx';", true);
                }
                else
                {
                    HOADONDTO hoadon = laygiatrituform();
                    bool them = HOADONDAO.Instance.datmon(hoadon);
                    if (them)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Đã thêm thành công');location.href='/datmon.aspx';", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Đã xảy ra lỗi');location.href='/datmon.aspx';", true);
                    }
                }
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("phieutamtinh.aspx");
            //Session["ban"] = lbtenban.Text.ToString();
        }

        



       
    }
}