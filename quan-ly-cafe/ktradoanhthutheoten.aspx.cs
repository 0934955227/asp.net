using quan_ly_cafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace quan_ly_cafe
{
    public partial class ktradoanhthutheoten : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                hienthidsnv();
                hienthingay();
            }
                     
        }
        private void hienthidsnv()
        {
            ddlnhanvien.DataSource = NGUOIDUNGDAO.Instance.danhsachnhanvien();
            ddlnhanvien.DataTextField= "TENNHANVIEN";
            ddlnhanvien.DataValueField = "USERNAME";
            ddlnhanvien.DataBind();
            
        }
        private void hienthihoadon(string user,string ngayban)
        {
            gvds.DataSource = HOADONDAO.Instance.doanhthutheonhanvien(user,ngayban);
            gvds.DataBind();
            if(gvds.Rows.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Không tìm thấy dữ liệu ');location.href='/ktradoanhthutheoten.aspx';", true);
            }
        }

        //thêm các dữ liệu vào dropdownlist ngày,tháng,năm
        private void hienthingay()
        {
            int i;
            //Thêm ngày 
            for (i = 1; i <= 31; i++ )
            {
                string ngay = i.ToString();
                ddlngay.Items.Add(ngay);
            }
            //Thêm tháng 
            for (i = 1; i <= 12; i++)
            {
                string thang = i.ToString();
                ddlthang.Items.Add(thang);
            }
            //Thêm năm 
            for (i = 2015 ; i <= DateTime.Now.Year ; i++)
            {
                string nam = i.ToString();
                ddlnam.Items.Add(nam);
            }
        }
        private string layngay()
        {
            string ngay = ddlngay.SelectedItem.Text.ToString();
            string thang = ddlthang.SelectedItem.Text.ToString();
            string nam = ddlnam.SelectedItem.Text.ToString();
            string ngayban = thang + "/" + ngay + "/" + nam;
            return ngayban;
        }
        protected void Chon_Click(object sender, EventArgs e)
        {
            string user = ddlnhanvien.SelectedValue.ToString();
            string ngayban = layngay();
            hienthihoadon(user, ngayban);
        }
    }
}