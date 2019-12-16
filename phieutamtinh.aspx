<%@ Page Title="" Language="C#" MasterPageFile="~/Giao-dien1.Master" AutoEventWireup="true" CodeBehind="phieutamtinh.aspx.cs" Inherits="quan_ly_cafe.phieutamtinh" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

    <table style="width:100%;">
         <tr>
                <td colspan="3" style="text-align:right" >
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/img/icon-ad.png"></asp:Image>
                    <asp:Label ID="lbnv" runat="server" Text="Tên nhân viên" ForeColor="Blue"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Sơ dồ bàn" OnClick="Button3_Click" />
                    <asp:Button ID="Button4" runat="server" Text="Đặt món" />
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align:center">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/img/icons8-restaurant-menu-96.png" Height="80px" Width="80px"></asp:Image>
                    <asp:Label ID="Label5" runat="server" Text=" BÀN " ForeColor="#0066FF" Font-Bold="True" Font-Size="XX-Large" ></asp:Label>
                    &nbsp;<asp:Label ID="lbtenban" runat="server" ForeColor="#0066FF" Font-Bold="True" Font-Size="XX-Large" ></asp:Label>
                </td>
            </tr>
        <tr>
            <td> 
                <asp:Label ID="Label6" runat="server" Text="Chọn món: "></asp:Label>
                <asp:Label ID="lbmonselected" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Label7" runat="server" Text="Số lượng:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lbtb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvtamtinh" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvtamtinh_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="TENMON" HeaderText="TM" />
                        <asp:BoundField DataField="SOLUONG" HeaderText="SL" />
                        <asp:BoundField DataField="THANHTIEN" HeaderText="TT" />
                        <asp:CommandField ButtonType="Button" SelectText="Chọn" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLCafeConnectionString2 %>" SelectCommand="Select MON.TENMON, HOADON.SOLUONG, HOADON.THANHTIEN from MON, HOADON WHERE MON.MAMON = HOADON.MAMON  "></asp:SqlDataSource>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Thêm món" />
                <asp:Button ID="Button2" runat="server" Text="Hủy món" />
                <asp:Button ID="btnchebien" runat="server" Text="Chế biến" OnClick="btnchebien_Click" />
                <asp:Button ID="btntt" runat="server" Text="Thanh toán" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</form>

</asp:Content>
