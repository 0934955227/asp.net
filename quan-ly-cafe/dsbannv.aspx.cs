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
            if (Session["user"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
            string user = Session["user"].ToString();
            if (!IsPostBack)
            {

                hienthidsban();
                pnchuyenban.Visible = false;
                pntachban.Visible = false;
                pnghepban.Visible = false;
                pnhoadon.Visible = false;
            }

        }
        private void hienthidsban()
        {

            hienthiban1(); hienthiban2(); hienthiban3(); hienthiban4();
            hienthiban5(); hienthiban6(); hienthiban7(); hienthiban8();
            hienthiban9(); hienthiban10(); hienthiban11(); hienthiban12();
            hienthiban13(); hienthiban14(); hienthiban15(); hienthiban16();
            hienthiban17(); hienthiban18();

        }
        private void hienthiban1()
        {
            string tenban = btn1.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn1.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn1.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn1.BackColor = Color.Yellow;
            }
        }
        private void hienthiban2()
        {
            string tenban = btn2.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn2.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn2.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn2.BackColor = Color.Yellow;
            }

        }
        private void hienthiban3()
        {
            string tenban = btn3.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn3.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn3.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn3.BackColor = Color.Yellow;
            }
        }
        private void hienthiban4()
        {
            string tenban = btn4.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn4.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn4.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn4.BackColor = Color.Yellow;
            }
        }
        private void hienthiban5()
        {
            string tenban = btn5.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn5.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn5.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn5.BackColor = Color.Yellow;
            }
        }
        private void hienthiban6()
        {
            string tenban = btn6.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn6.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn6.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn6.BackColor = Color.Yellow;
            }
        }
        private void hienthiban7()
        {
            string tenban = btn7.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn7.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn7.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn7.BackColor = Color.Yellow;
            }
        }
        private void hienthiban8()
        {
            string tenban = btn8.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn8.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn8.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn8.BackColor = Color.Yellow;
            }
        }
        private void hienthiban9()
        {
            string tenban = btn9.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn9.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn9.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn9.BackColor = Color.Yellow;
            }
        }
        private void hienthiban10()
        {
            string tenban = btn10.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn10.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn10.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn10.BackColor = Color.Yellow;
            }
        }
        private void hienthiban11()
        {
            string tenban = btn11.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn11.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn11.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn11.BackColor = Color.Yellow;
            }
        }
        private void hienthiban12()
        {
            string tenban = btn12.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn12.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn12.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn12.BackColor = Color.Yellow;
            }
        }
        private void hienthiban13()
        {
            string tenban = btn13.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn13.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn13.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn13.BackColor = Color.Yellow;
            }
        }
        private void hienthiban14()
        {
            string tenban = btn14.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn14.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn14.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn14.BackColor = Color.Yellow;
            }
        }
        private void hienthiban15()
        {
            string tenban = btn15.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn15.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn15.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn15.BackColor = Color.Yellow;
            }
        }
        private void hienthiban16()
        {
            string tenban = btn16.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn16.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn16.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn16.BackColor = Color.Yellow;
            }
        }
        private void hienthiban17()
        {
            string tenban = btn17.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn17.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn17.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn17.BackColor = Color.Yellow;
            }
        }
        private void hienthiban18()
        {
            string tenban = btn18.Text.ToString();
            int tinhtrang = BANDAO.Instance.tinhtrangban(tenban);
            if (tinhtrang == 1)
            {
                btn18.BackColor = Color.LightGray;
            }
            else if (tinhtrang == 2)
            {
                btn18.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btn18.BackColor = Color.Yellow;
            }
        }

        private void chuyentrang()
        {
            Response.Redirect("datmonnv.aspx");
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

        protected void btn3_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn3.Text.ToString();
            chuyentrang();
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn4.Text.ToString();
            chuyentrang();
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn5.Text.ToString();
            chuyentrang();
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn6.Text.ToString();
            chuyentrang();
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn7.Text.ToString();
            chuyentrang();
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn8.Text.ToString();
            chuyentrang();
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn9.Text.ToString();
            chuyentrang();
        }

        protected void btn10_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn10.Text.ToString();
            chuyentrang();
        }

        protected void btn11_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn11.Text.ToString();
            chuyentrang();
        }

        protected void btn12_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn12.Text.ToString();
            chuyentrang();
        }

        protected void btn13_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn13.Text.ToString();
            chuyentrang();
        }

        protected void btn14_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn14.Text.ToString();
            chuyentrang();
        }

        protected void btn15_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn15.Text.ToString();
            chuyentrang();
        }

        protected void btn16_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn16.Text.ToString();
            chuyentrang();
        }

        protected void btn17_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn17.Text.ToString();
            chuyentrang();
        }

        protected void btn18_Click(object sender, EventArgs e)
        {
            Session["ban"] = btn18.Text.ToString();
            chuyentrang();
        }

        private void hienthihoadon(int mabancu)
        {
            gvdanhsachmon.DataSource = HOADONDAO.Instance.phieutamtinh(mabancu);
            gvdanhsachmon.DataBind();
        }
        public bool capnhatban(int mabancu, int mabanmoi)
        {
            bool kt = new bool();
            bool chuyen = HOADONDAO.Instance.capnhatchuyenban(mabancu, mabanmoi);
            if (chuyen)
            {
                bool capnhat1 = BANDAO.Instance.capnhattrangthaitrong(mabancu);
                bool capnhat2 = BANDAO.Instance.capnhattrangthaicokhach(mabanmoi);
                if (capnhat1 && capnhat2)
                {
                    kt = true;
                }
                else kt = false;
            }
            else
            {
                kt = false;
            }
            return kt;
        }
        private void chuyenban()
        {
            string bancu = txtbancu.Text.ToString();
            string banmoi = txtbanmoi.Text.ToString();
            int mabancu = BANDAO.Instance.maban(bancu);
            int mabanmoi = BANDAO.Instance.maban(banmoi);
            int trangthaibancu = BANDAO.Instance.tinhtrangban(bancu);
            int trangthaibanmoi = BANDAO.Instance.tinhtrangban(banmoi);
            if (trangthaibancu == 1)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bàn chọn trống');location.href='/dsbanadmin.aspx';", true);
            }
            else
            {
                if (trangthaibanmoi == 1)
                {
                    bool capnhat = capnhatban(mabancu, mabanmoi);
                    if (capnhat)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thành công');location.href='/dsbanadmin.aspx';", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại ');location.href='/dsbanadmin.aspx';", true);
                    }
                }
                else
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bàn chuyển có khách');location.href='/dsbanadmin.aspx';", true);
                }
            }
        }
        private void ghepban()
        {
            string bancu = txtbancughep.Text.ToString();
            string banmoi = txtbanmoighep.Text.ToString();
            int mabancu = BANDAO.Instance.maban(bancu);
            int mabanmoi = BANDAO.Instance.maban(banmoi);
            int trangthaibancu = BANDAO.Instance.tinhtrangban(bancu);
            int trangthaibanmoi = BANDAO.Instance.tinhtrangban(banmoi);
            if (trangthaibancu == 1)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bàn chọn trống');location.href='/dsbanadmin.aspx';", true);
            }
            else
            {
                if (trangthaibanmoi == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bàn ghép trống');location.href='/dsbanadmin.aspx';", true);
                }
                else
                {
                    bool capnhat = capnhatban(mabancu, mabanmoi);
                    if (capnhat)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thành công');location.href='/dsbanadmin.aspx';", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại ');location.href='/dsbanadmin.aspx';", true);
                    }
                }
            }
        }

        protected void btnchuyenban_Click(object sender, EventArgs e)
        {
            pnchuyenban.Visible = true;
        }

        protected void btnthchuyenban_Click(object sender, EventArgs e)
        {
            chuyenban();
        }

        protected void btntachban_Click(object sender, EventArgs e)
        {
            pntachban.Visible = true;
        }
        protected void btnthchonban_Click(object sender, EventArgs e)
        {
            string bancu = txtbantachcu.Text.ToString();
            string banmoi = txtbantachmoi.Text.ToString();
            int mabancu = BANDAO.Instance.maban(bancu);
            int mabanmoi = BANDAO.Instance.maban(banmoi);
            int trangthaibancu = BANDAO.Instance.tinhtrangban(bancu);
            int trangthaibanmoi = BANDAO.Instance.tinhtrangban(banmoi);
            if (trangthaibancu == 1)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bàn chọn trống');location.href='/dsbanadmin.aspx';", true);
            }
            else
            {
                hienthihoadon(mabancu);
                pnhoadon.Visible = true;

            }
        }
        protected void gvdanhsachmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvdanhsachmon.SelectedRow;
            string tenmon = row.Cells[1].Text.ToString();
            lbmonselected.Text = tenmon;
            Session["mamontach"] = row.Cells[0].Text.ToString();
        }

        private HOADONDTO laygiatrituform()
        {
            string banmoi = txtbantachmoi.Text.ToString();
            int maban = BANDAO.Instance.maban(banmoi);
            string user = Session["user"].ToString();
            int mamon = int.Parse(Session["mamontach"].ToString());
            int soluong = int.Parse(txtsl.Text.ToString());
            int dongia = MONDAO.Instance.dongia(mamon);
            int thanhtien = soluong * dongia;
            string ngayban = DateTime.Today.ToShortDateString();
            string chuthich = "";
            HOADONDTO hoadon = new HOADONDTO(maban, user, mamon, soluong, thanhtien, ngayban, chuthich);
            return hoadon;
        }


        protected void btnghepban_Click(object sender, EventArgs e)
        {
            pnghepban.Visible = true;
        }

        protected void btnthghepban_Click(object sender, EventArgs e)
        {
            ghepban();
        }

        protected void btnthtach_Click(object sender, EventArgs e)
        {
            HOADONDTO hoadon = laygiatrituform();
            string bancu = txtbantachcu.Text.ToString();
            int mabancu = BANDAO.Instance.maban(bancu);
            string tenmon = lbmonselected.Text.ToString(); //Lấy tên món
            string sl = txtsl.Text.ToString(); // Lấy số lượng món
            if (tenmon == "" || sl == "") //Nếu các ô dữ liệu trống, chưa có chọn món
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại');location.href='/dsbanadmin.aspx';", true);
            }
            else
            {
                try
                {
                    int soluongtach = int.Parse(sl);
                    int soluongmon = HOADONDAO.Instance.soluongdaguibep(mabancu, hoadon.Mamon);
                    int soluongconlai = soluongmon - soluongtach;
                    if (soluongtach <= 0) //Số lượng món nhập vào <= 0
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bạn phải nhập số lượng > 0');location.href='/dsbanadmin.aspx';", true);
                    }
                    else if (soluongconlai < 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Số lượng tách lớn hơn số lượng món trong bàn');location.href='/dsbanadmin.aspx';", true);
                    }
                    else
                    {
                        int dongia = MONDAO.Instance.dongia(hoadon.Mamon);
                        int thanhtienconlai = dongia * soluongconlai;
                        bool taohd = HOADONDAO.Instance.hoadontach(hoadon);
                        bool capnhattrangthai = BANDAO.Instance.capnhattrangthaicokhach(hoadon.Maban);
                        {
                            if (taohd && capnhattrangthai)
                            {
                                if (soluongconlai == 0)
                                {
                                    bool xoa = HOADONDAO.Instance.xoahoadontach(mabancu, hoadon.Mamon);
                                    if (xoa)
                                    {
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Đã tách');location.href='/dsbanadmin.aspx';", true);
                                    }
                                }
                                else
                                {
                                    bool xoa = HOADONDAO.Instance.xoahoadontach(mabancu, hoadon.Mamon);
                                    if (xoa)
                                    {
                                        HOADONDTO hdt = new HOADONDTO(mabancu, hoadon.User, hoadon.Mamon, soluongconlai, thanhtienconlai, hoadon.Ngayban, hoadon.Ghichu);
                                        bool tao = HOADONDAO.Instance.hoadontach(hdt);
                                        if (tao)
                                        {
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Đã tách');location.href='/dsbanadmin.aspx';", true);
                                        }
                                        else
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại');location.href='/dsbanadmin.aspx';", true);
                                    }
                                    else
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại');location.href='/dsbanadmin.aspx';", true);
                                }
                            }
                            else ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại');location.href='/dsbanadmin.aspx';", true);
                        }
                    }
                }
                catch
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Món chưa được chế biến');location.href='/dsbanadmin.aspx';", true);
                }
            }

        }
    }


}