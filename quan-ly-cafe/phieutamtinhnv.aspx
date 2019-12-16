<%@ Page Title="" Language="C#" MasterPageFile="~/GDnhanvien.Master" AutoEventWireup="true" CodeBehind="phieutamtinhnv.aspx.cs" Inherits="quan_ly_cafe.phieutamtinhnv" %>
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
                    <asp:Button ID="btndsban" runat="server" Text="Sơ dồ bàn" OnClick="btndsban_Click"  />
                    <asp:Button ID="btndatmon" runat="server" Text="Đặt món mới" OnClick="btndatmon_Click" />
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
            <td style="height: 81px"> 
                <asp:Label ID="Label6" runat="server" Text="Chọn món: "></asp:Label>
                <asp:Label ID="lbmonselected" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Label7" runat="server" Text="Số lượng:"></asp:Label>
                <asp:TextBox ID="txtsl" runat="server" Width="168px"></asp:TextBox>
                <br />
                <asp:Label ID="Label8" runat="server" Text="Ghi chú"></asp:Label>
                :
                <asp:TextBox ID="txtghichu" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lbtb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvtamtinh" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvtamtinh_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="MAMON" HeaderText="MM" />
                        <asp:BoundField DataField="TENMON" HeaderText="TM" />
                        <asp:BoundField DataField="SOLUONG" HeaderText="SL" />
                        <asp:BoundField DataField="THANHTIEN" HeaderText="TT" />
                        <asp:CommandField ButtonType="Button" SelectText="Chọn" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLCafeConnectionString2 %>" SelectCommand="Select MON.TENMON, HOADON.SOLUONG, HOADON.THANHTIEN from MON, HOADON WHERE MON.MAMON = HOADON.MAMON  "></asp:SqlDataSource>
                <br />
                <asp:Button ID="btnthemmon" runat="server" Text="Thêm món"  Width="80px" OnClick="btnthemmon_Click" />
                <asp:Button ID="btnhuymon" runat="server" Text="Hủy món" OnClick="btnhuymon_Click"  />
                <asp:Button ID="btnchebien" runat="server" Text="Chế biến" OnClick="btnchebien_Click"  />
                <asp:Button ID="btntt" runat="server" Text="Yêu cầu thanh toán" OnClick="btntt_Click"  />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</form>
</asp:Content>
