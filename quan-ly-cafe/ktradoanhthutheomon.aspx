<%@ Page Title="" Language="C#" MasterPageFile="~/GDadmin.Master" AutoEventWireup="true" CodeBehind="ktradoanhthutheomon.aspx.cs" Inherits="quan_ly_cafe.ktradoanhthutheomon" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="kiểm tra doanh thu theo món"></asp:Label>
                &nbsp;: ngày
                    <asp:DropDownList ID="ddlngay" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
&nbsp;tháng
                    <asp:DropDownList ID="ddlthang" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
&nbsp;năm
                    <asp:DropDownList ID="ddlnam" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
&nbsp;<asp:Button ID="btnchon" runat="server" OnClick="btnchon_Click" Text="Chọn" Width="54px" />
                    <br />
                    Doanh mục :
                    <asp:DropDownList ID="ddldoanhmuc" runat="server" AutoPostBack="True">
                        <asp:ListItem Selected="True">Tất cả</asp:ListItem>
                        <asp:ListItem Value="CÀ PHÊ">Cà phê</asp:ListItem>
                        <asp:ListItem Value="NƯỚC ÉP">Nước ép</asp:ListItem>
                        <asp:ListItem Value="SỮA CHUA">Sữa chua</asp:ListItem>
                        <asp:ListItem Value="TRÀ SỮA">Trà sữa</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvdsmon" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="TENMON" HeaderText="TÊN MÓN" />
                            <asp:BoundField DataField="SOLUONG" HeaderText="SỐ LƯỢNG" />
                            <asp:BoundField DataField="THANHTIEN" HeaderText="THÀNH TIỀN" />
                        </Columns>
                    </asp:GridView>
                    <asp:Label ID="Label2" runat="server" Text="Tổng : "></asp:Label>
                    <asp:Label ID="lbtong" runat="server"></asp:Label>
&nbsp;<br />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
