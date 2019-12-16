using quan_ly_cafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quan_ly_cafe
{
    public partial class phieutamtinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbtenban.Text = Session["ban"].ToString();
            hienthiptt();
        }
        private void hienthiptt()
        {
           int maban = int.Parse(Session["ban"].ToString());
            gvtamtinh.DataSource = HOADONDAO.Instance.phieutamtinh(maban);
            gvtamtinh.DataBind(); 
        }

        protected void btnchebien_Click(object sender, EventArgs e)
        {
            int maban = BANDAO.Instance.maban(lbtenban.Text);
            bool guibep = HOADONDAO.Instance.guibep(maban);
            if(guibep)
            {
                Session["guibep"] = "Success";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Gửi bếp thành công');location.href='/phieutamtinh.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại');location.href='/phieutamtinh.aspx';", true);
            }
        }

        protected void gvtamtinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvtamtinh.SelectedRow;
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if(Session["guibep"]==null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Chưa gửi bếp');location.href='/datmon.aspx';", true);
            }
            else
            {
                Response.Redirect("datmon.aspx");
            }
            
        }
    }
}