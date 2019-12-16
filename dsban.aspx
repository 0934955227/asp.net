<%@ Page Title="" Language="C#" MasterPageFile="~/Giao-dien1.Master" AutoEventWireup="true" CodeBehind="dsban.aspx.cs" Inherits="quan_ly_cafe.WebForm1" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <center>
    <form id="form1" runat="server">   
        <table >
            <tr>
                <td>                                  
                </td>
                <td></td>
                <td>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/img/icon-ad.png"></asp:Image>
                    <asp:Label ID="lbtennv" runat="server" Text="Lê Văn Quý " ForeColor="Blue"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:left">
                     <asp:Image ID="Image2" ImageUrl="~/img/icons8-coffee-table-100.png"  runat="server"></asp:Image>
                    <asp:Label ID="Label1"  runat="server" Text="SƠ ĐỒ BÀN" ForeColor="#0066FF" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:left">
                    <asp:Image ID="Image3" ImageUrl="~/img/icons8-location-96.png"  Width="50px" Height="50px" runat="server"></asp:Image>
                    <asp:Label ID="Label2" runat="server" Text="Khu vực : " Font-Size="Medium" ForeColor="Blue" Font-Bold="True"></asp:Label>
                     <asp:Button ID="btnall" runat="server" Text=" Tất cả " Width="90" Height="45" BackColor="#00ccff" ></asp:Button>
                    <asp:Button ID="btnkva" runat="server" style="margin-left: 18px" Text=" A" Width="90" Height="45" BackColor="#00ccff" OnClick="btnkva_Click" ></asp:Button>
                    <asp:Button ID="btnkvb" runat="server" style="margin-left: 18px" Text=" B" Width="90" Height="45" BackColor="#00ccff"></asp:Button>
                    <asp:Button ID="btnkvc" runat="server" style="margin-left: 18px" Text=" C" Width="90" Height="45" BackColor="#00ccff" ></asp:Button>
                    <br/>
                    <br/>
                </td>     
                <td ></td>
                <td></td>
            </tr>
            <tr>
                <td >
                    <asp:Panel ID="paneldsban" Width="700" runat="server">
                        <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" />
                        <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn2_Click" />
                        <asp:Button ID="btn3" runat="server" Text="3" />
                        <br />
                        <asp:Button ID="btn4" runat="server" Text="4" />
                        <asp:Button ID="btn5" runat="server" Text="5" />
                        <asp:Button ID="btn6" runat="server" Text="6" />
                    </asp:Panel>
                    <asp:Panel ID="panelkhua" Width="700" runat="server">
                        <asp:Button ID="btn7" runat="server" Text="7" />
                        <asp:Button ID="btn8" runat="server" Text="8" />
                        <asp:Button ID="btn9" runat="server" Text="9" />
                        <br />
                        <asp:Button ID="btn10" runat="server" Text="10" />
                        <asp:Button ID="btn11" runat="server" Text="11" />
                        <asp:Button ID="btn12" runat="server" Text="12" />
                    </asp:Panel>
                    <asp:Panel ID="panelkhub" Width="700" runat="server">
                        <asp:Button ID="btn13" runat="server" Text="13" />
                        <asp:Button ID="btn14" runat="server" Text="14" />
                        <asp:Button ID="btn15" runat="server" Text="15" />
                        <br />
                        <asp:Button ID="btn16" runat="server" Text="16" />
                        <asp:Button ID="btn17" runat="server" Text="17" />
                        <asp:Button ID="btn18" runat="server" Text="18" />
                        <br />
                    </asp:Panel>
                    <asp:Panel ID="panelkhuc" Width="700" runat="server">
                    </asp:Panel>
                   
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </form>
  </center>
</asp:Content>

