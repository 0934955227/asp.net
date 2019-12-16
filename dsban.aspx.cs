using quan_ly_cafe.DAO;
using quan_ly_cafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


namespace quan_ly_cafe
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            string user = Session["user"].ToString();  
            
                hienthidsban();
            string tenban = btn1.Text.ToString();

            lbtennv.Text = BANDAO.Instance.tinhtrangban(tenban);
                     
        }
        private void hienthidsban()
        {

            hienthiban1(); hienthiban2(); hienthiban3(); hienthiban4();
            hienthiban5(); hienthiban6(); hienthiban7();
            
        }
        private void hienthiban1()
        {
            string tenban = btn1.Text.ToString();
            string tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            switch(tinhtrang)
            {
                case "Co khach ": btn1.BackColor = Color.CornflowerBlue;
                    break;
                case "Yeu cau thanh toan": btn1.BackColor = Color.Yellow;
                    break;
                default: btn1.BackColor = Color.LightGray;
                    break;
            }
        }
        private void hienthiban2()
        {
            string tenban = btn2.Text.ToString();
            string tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            switch (tinhtrang)
            {
                case "Co khach": btn2.BackColor = Color.CornflowerBlue;
                    break;
                case "Yeu cau thanh toan": btn2.BackColor = Color.Yellow;
                    break;
                default: btn2.BackColor = Color.LightGray;
                    break;
            }
        }
        private void hienthiban3()
        {
            string tenban = btn3.Text.ToString();
            string tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            switch (tinhtrang)
            {
                case "Co khach": btn3.BackColor = Color.CornflowerBlue;
                    break;
                case "Yeu cau thanh toan": btn3.BackColor = Color.Yellow;
                    break;
                default: btn3.BackColor = Color.LightGray;
                    break;
            }
        }
        private void hienthiban4()
        {
            string tenban = btn4.Text.ToString();
            string tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            switch (tinhtrang)
            {
                case "Co khach": btn4.BackColor = Color.CornflowerBlue;
                    break;
                case "Yeu cau thanh toan": btn4.BackColor = Color.Yellow;
                    break;
                default: btn4.BackColor = Color.LightGray;
                    break;
            }
        }
        private void hienthiban5()
        {
            string tenban = btn5.Text.ToString();
            string tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            switch (tinhtrang)
            {
                case "Co khach": btn5.BackColor = Color.CornflowerBlue;
                    break;
                case "Yeu cau thanh toan": btn5.BackColor = Color.Yellow;
                    break;
                default: btn5.BackColor = Color.LightGray;
                    break;
            }
        }
        private void hienthiban6()
        {
            string tenban = btn6.Text.ToString();
            string tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            switch (tinhtrang)
            {
                case "Co khach": btn6.BackColor = Color.CornflowerBlue;
                    break;
                case "Yeu cau thanh toan": btn6.BackColor = Color.Yellow;
                    break;
                default: btn6.BackColor = Color.LightGray;
                    break;
            }
        }
        private void hienthiban7()
        {
            string tenban = btn1.Text.ToString();
            string tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            switch (tinhtrang)
            {
                case "Co khach": btn7.BackColor = Color.CornflowerBlue;
                    break;
                case "Yeu cau thanh toan": btn7.BackColor = Color.Yellow;
                    break;
                default: btn7.BackColor = Color.LightGray;
                    break;
            }
        }
 
        private void chuyentrang()
        {
            Response.Redirect("datmon.aspx");
        }

        protected void btnkva_Click(object sender, EventArgs e)
        {
            panelkhua.Controls.Clear();
            panelkhub.Controls.Clear();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn1.Text.ToString();
            chuyentrang();
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn2.Text.ToString();
            chuyentrang();
        }

        
    }
}