<%@ Page Title="" Language="C#" MasterPageFile="~/GDadmin.Master" AutoEventWireup="true" CodeBehind="datmonadmin.aspx.cs" Inherits="quan_ly_cafe.datmonadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <center>
    <center>
    <form id="form1" runat="server">
        
        <table >
            <tr>
                <td colspan="3" style="text-align:right" >
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/img/icon-ad.png"></asp:Image>
                    <asp:Label ID="lbnv" runat="server" Text="Tên nhân viên" ForeColor="Blue"></asp:Label>
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
                <td style="width: 351px">
                    <asp:Label ID="Label1" runat="server" Text=" ĐẶT MÓN " ForeColor="#0066FF" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                </td>
                <td style="width: 14px"></td>
                <td style="width: 355px"></td>
            </tr>
            <tr>
                <td style="width: 351px">

                    <asp:Button ID="btncf" runat="server" Text="CÀ PHÊ" Width="80px" Height="40px" Font-Bold="True" ForeColor="Maroon" BackColor="White" OnClick="btncf_Click"  />
                    <asp:Button ID="btnnuocep" runat="server" Text="NƯỚC ÉP" Width="80px" Height="40px" Font-Bold="True" ForeColor="#003300" BackColor="White" OnClick="btnnuocep_Click"  />
                    <asp:Button ID="btntrasua" runat="server" Text="TRÀ SỮA" Width="80px" Height="40px" Font-Bold="True" ForeColor="Red" BackColor="White" OnClick="btntrasua_Click"  />
                    <asp:Button ID="btnsuachua" runat="server" Text="SỮA CHUA" Width="95px" Height="40px" Font-Bold="True" ForeColor="#660066" BackColor="White" OnClick="btnsuachua_Click"  />

                    </td>
                <td style="width: 14px"></td>
                <td>
                    <asp:Button ID="Button1" runat="server"  Text="PHIEU TAM TINH" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: 351px; height: 47px;"><asp:TextBox ID="txttenmon" runat="server" Height="30px"></asp:TextBox>
                <asp:Button ID="btntim" runat="server" Text="Tìm kiếm" OnClick="btntim_Click"  ></asp:Button>
                </td>
                <td style="height: 47px; width: 14px;"></td>
                <td style="height: 47px">
                    &nbsp;</td>   
            </tr>
            <tr>
                <td style="width: 351px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 351px">
                    <asp:Label ID="lbtb" runat="server" Text="" ForeColor="Red" Font-Bold="True"></asp:Label>
                    <asp:GridView ID="dsmon" runat="server" AutoGenerateColumns="False" Width="300px" AllowPaging="True" OnSelectedIndexChanged="dsmon_SelectedIndexChanged" Font-Bold="True" ForeColor="#3366FF" OnPageIndexChanging="dsmon_PageIndexChanging" >
                        <AlternatingRowStyle Font-Bold="True" ForeColor="#0066FF" />
                        <Columns>
                            <asp:BoundField DataField="MAMON" HeaderText="MÃ MÓN" >
                            <ControlStyle Width="40px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="TENMON" HeaderText="TÊN MÓN" />
                            <asp:BoundField DataField="DONGIA" HeaderText="ĐƠN GIÁ" />
                            <asp:CommandField ButtonType="Image" SelectImageUrl="~/img/icons8-hand-left-50.png" ShowSelectButton="True">
                            <ControlStyle Height="30px" Width="30px" />
                            </asp:CommandField>
                        </Columns>
                        <EditRowStyle Font-Bold="True" ForeColor="#3366FF" />
                        <FooterStyle ForeColor="#003300" />
                        <HeaderStyle BackColor="#FFCC00" ForeColor="Black" />
                        <RowStyle BackColor="White" />
                    </asp:GridView>                  
                </td>
                <td style="width: 14px"></td>
                <td>                 
                    <asp:Label ID="Label3" runat="server" Text="Chọn món:"></asp:Label>
                    <asp:Label ID="lbtenmon" runat="server" Font-Bold="True" ForeColor="Black"></asp:Label>
&nbsp;<asp:Label ID="Label7" runat="server" Text="Đơn giá "></asp:Label>
                    <asp:Label ID="lbgia" runat="server" Font-Bold="True" ForeColor="Black" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Số lượng"></asp:Label>
                    <asp:TextBox ID="txtsl" runat="server" Height="30" Width="30"  TextMode="Number"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Ghi chú"></asp:Label>
                    :
                    <asp:TextBox ID="txtghichu" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="btnxacnhan" runat="server" Height="33px"  Text="Xác nhận" OnClick="btnxacnhan_Click" />
                </td>
            </tr>
        </table>
        
    </form>
    </center>
                       
</asp:Content>
