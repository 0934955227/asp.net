using quan_ly_cafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quan_ly_cafe
{
    public partial class ktradoanhthutheomon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                hienthingay();
            }
            
        }
        //thêm các dữ liệu vào dropdownlist ngày,tháng,năm
        private void hienthingay()
        {
            int i;
            //Thêm ngày 
            for (i = 1; i <= 31; i++)
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
            for (i = 2015; i <= DateTime.Now.Year; i++)
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
        protected void btnchon_Click(object sender, EventArgs e)
        {
            string ngayban = layngay();
            string phanloai = ddldoanhmuc.SelectedValue.ToString();
            switch (phanloai)
            {
                case "Tất cả" :  gvdsmon.DataSource = DOANHTHUDAO.Instance.doanhthutheomon(ngayban);
                    gvdsmon.DataBind();
                    break;
                default: gvdsmon.DataSource = DOANHTHUDAO.Instance.doanhthutheoloai(phanloai,ngayban);
                    gvdsmon.DataBind();
                    break;
            }
            int tongthanhtien = 0;
            int sl = gvdsmon.Rows.Count;
            for(int i = 0; i<sl ; i++)
            {
                tongthanhtien += int.Parse(gvdsmon.Rows[i].Cells[2].Text.ToString());   
            }
            lbtong.Text = tongthanhtien.ToString() + " VNĐ";
            
        }

       
    }
} 