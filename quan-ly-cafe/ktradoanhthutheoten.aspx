<%@ Page Title="" Language="C#" MasterPageFile="~/GDadmin.Master" AutoEventWireup="true" CodeBehind="ktradoanhthutheoten.aspx.cs" Inherits="quan_ly_cafe.ktradoanhthutheoten" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <form id ="form" runat ="server">
    <center> 
    <table style="width:100%;">
        <tr>
            <td style="height: 26px"></td>
            <td style="height: 26px">
                <asp:Label ID="Label1" runat="server" Text="kiểm tra doanh thu"></asp:Label>
&nbsp;theo nhân viên :
                <asp:Label ID="lbtb" runat="server" Text=""></asp:Label>
            </td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="height: 29px"></td>
            <td style="height: 29px">
                <asp:DropDownList ID="ddlnhanvien" runat="server"  AutoPostBack="True">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            &nbsp;ngày
                <asp:DropDownList ID="ddlngay" runat="server" AutoPostBack="True">
                </asp:DropDownList>
&nbsp;tháng
                <asp:DropDownList ID="ddlthang" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                năm<asp:DropDownList ID="ddlnam" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            &nbsp;<asp:Button ID="Chon" runat="server" OnClick="Chon_Click" Text="Button" />
            </td>
            <td style="height: 29px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="gvds" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="TENMON" HeaderText="TÊN MÓN" />
                        <asp:BoundField DataField="SOLUONG" HeaderText="SỐ LƯỢNG" />
                        <asp:BoundField DataField="THANHTIEN" HeaderText="THÀNH TIỀN" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </center>
   </form>
</asp:Content>
