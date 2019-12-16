using quan_ly_cafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quan_ly_cafe
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void btndn_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text.ToString();
            string matkhau = txtmk.Text.ToString();
            bool check = NGUOIDUNGDAO.Instance.kiemtra(username, matkhau);
            if(check)
            {
                Session["user"] = username;
                Response.Redirect("dsban.aspx");
            }
            else
            {
                lbloi.Text = "Đã sai tài khoản hoặc mật khẩu";
            }

        }
    }
}