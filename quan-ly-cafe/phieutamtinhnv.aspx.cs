using quan_ly_cafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quan_ly_cafe
{
    public partial class phieutamtinhnv : System.Web.UI.Page
    {
        string diachi = "phieutamtinhnv.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                lbtenban.Text = Session["ban"].ToString();
                string user = Session["user"].ToString();
                lbnv.Text = NGUOIDUNGDAO.Instance.hienthinhanvien(user);
                hienthiptt();
            }
        }
        private void hienthiptt()
        {
            int maban = BANDAO.Instance.maban(lbtenban.Text);
            gvtamtinh.DataSource = HOADONDAO.Instance.phieutamtinh(maban);
            gvtamtinh.DataBind();
        }
        protected void gvtamtinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvtamtinh.SelectedRow;
            string tenmon = row.Cells[1].Text.ToString();
            lbmonselected.Text = tenmon;
            Session["mon"] = row.Cells[0].Text.ToString();
        }
        private HOADONDTO laydulieutuform()
        {
            int maban = BANDAO.Instance.maban(lbtenban.Text);
            string user = Session["user"].ToString();
            int mamon = int.Parse(Session["mon"].ToString());
            int soluong = int.Parse(txtsl.Text.ToString());
            int dongia = MONDAO.Instance.dongia(mamon);
            int thanhtien = soluong * dongia;
            string ngayban = DateTime.Today.ToShortDateString();
            string chuthich = txtghichu.Text.ToString();
            HOADONDTO hoadon = new HOADONDTO(maban, user, mamon, soluong, thanhtien, ngayban, chuthich);
            return hoadon;
        }
        protected void btnthemmon_Click(object sender, EventArgs e)
        {
            string tenmon = lbmonselected.Text.ToString(); //Lấy tên món
            string sl = txtsl.Text.ToString(); // Lấy số lượng món
            if (tenmon == "" || sl == "") //Nếu các ô dữ liệu trống, chưa có chọn món
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại');location.href='/phieutamtinhnv.aspx';", true);
            }
            else
            {
                int soluong = int.Parse(sl);
                if (soluong <= 0) //Số lượng món nhập vào <= 0
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Bạn phải nhập số lượng > 0');location.href='/phieutamtinhnv.aspx';", true);
                }
                else
                {
                    HOADONDTO hoadon = laydulieutuform();
                    bool kt = datmon.Instance.themmon(hoadon.Maban, hoadon.User, hoadon.Mamon, hoadon.Soluong, hoadon.Thanhtien, hoadon.Ngayban, hoadon.Ghichu);
                    if (kt == true)
                    {
                        datmon.Instance.thongbaothanhcong(this, diachi);
                    }
                    else
                    {
                        datmon.Instance.thongbaothatbai(this, diachi);
                    }
                }
            }
        }

        protected void btnhuymon_Click(object sender, EventArgs e)
        {
            int maban = BANDAO.Instance.maban(lbtenban.Text);
            int mamon = int.Parse(Session["mon"].ToString());
            if (txtsl.Text == "")
            {
                bool huymon = HOADONDAO.Instance.huymon(maban, mamon);
                if (huymon)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hủy món thành công');location.href='/phieutamtinhnv.aspx';", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại');location.href='/phieutamtinhnv.aspx';", true);
                }
            }
            else
            {
                int soluonghuy = int.Parse(txtsl.Text.ToString());// Số lượng muốn hủy
                int soluongmon = HOADONDAO.Instance.soluongchuaguibep(maban, mamon); //Số lượng món có trong hóa đơn chưa gửi bếp
                if (soluongmon - soluonghuy > 0)
                {
                    bool giammon = HOADONDAO.Instance.giamsoluongmon(maban, mamon, soluonghuy);
                    if (giammon)
                    {
                        int dongia = MONDAO.Instance.dongia(mamon);
                        bool capnhattien = HOADONDAO.Instance.capnhatthanhtien(maban, mamon, dongia);
                        if (capnhattien)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hủy món thành công');location.href='/phieutamtinhnv.aspx';", true);
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại');location.href='/phieutamtinhnv.aspx';", true);
                    }
                }
                else if ((soluongmon - soluonghuy) == 0)
                {
                    bool giammon = HOADONDAO.Instance.giamsoluongmon(maban, mamon, soluonghuy);
                    bool xoamon = HOADONDAO.Instance.xoahoadoncomonbang0();
                    if (xoamon)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hủy món thành công');location.href='/phieutamtinhnv.aspx';", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại');location.href='/phieutamtinhnv.aspx';", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hủy hơn số lượng chưa gửi bếp');location.href='/phieutamtinhnv.aspx';", true);
                }
            }
        }

        protected void btnchebien_Click(object sender, EventArgs e)
        {
            int maban = BANDAO.Instance.maban(lbtenban.Text);
            bool guibep = HOADONDAO.Instance.guibep(maban);
            if (guibep)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Gửi bếp thành công');location.href='/phieutamtinhnv.aspx';", true);
                bool tt = BANDAO.Instance.capnhattrangthaicokhach(maban);
                if (!tt)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Cập nhật không thành công');location.href='/phieutamtinhnv.aspx';", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thất bại');location.href='/phieutamtinhnv.aspx';", true);
            }
        }

        protected void btntt_Click(object sender, EventArgs e)
        {
            int maban = BANDAO.Instance.maban(lbtenban.Text);
            int tinhtrangban = BANDAO.Instance.tinhtrangban(lbtenban.Text);
            if (tinhtrangban == 1)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Không có món');location.href='/phieutamtinhnv.aspx';", true);
            }
            else
            {
                bool capnhat = BANDAO.Instance.capnhattrangthaiyeucau(maban);
                if (capnhat)
                {
                    datmon.Instance.thongbaothanhcong(this, diachi);
                }
                else datmon.Instance.thongbaothatbai(this, diachi);
            } 
        }
        private void kiemtraban()
        {
            int maban = BANDAO.Instance.maban(lbtenban.Text);
            bool kiemtra = HOADONDAO.Instance.kiemtrabanchuaguibep(maban);
            if (kiemtra)
            {
                Session["guibep"] = "tontai"; // Nếu có tồn tại món chưa gửi bếp thì gán 1 Session 
            }
        }

        protected void btndsban_Click(object sender, EventArgs e)
        {
            kiemtraban();
            if (Session["guibep"] == null)
            {
                Response.Redirect("dsbannv.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Có món chưa gửi bếp');location.href='/phieutamtinhtn.aspx';", true);
                Session.Remove("guibep");
            }
        }

        protected void btndatmon_Click(object sender, EventArgs e)
        {
            Response.Redirect("datmonnv.aspx");
        }

       
    

    }
}