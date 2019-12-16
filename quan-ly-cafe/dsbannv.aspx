<%@ Page Title="" Language="C#" MasterPageFile="~/GDnhanvien.Master" AutoEventWireup="true" CodeBehind="dsbannv.aspx.cs" Inherits="quan_ly_cafe.WebForm1" %>
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
                    <asp:Label ID="lbtennv" runat="server" ForeColor="Blue"></asp:Label>
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
                        <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn3_Click" />
                        <br />
                        <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn4_Click" />
                        <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn5_Click" />
                        <asp:Button ID="btn6" runat="server" Text="6" OnClick="btn6_Click" />
                    </asp:Panel>
                    <asp:Panel ID="panelkhua" Width="700" runat="server">
                        <asp:Button ID="btn7" runat="server" Text="7" OnClick="btn7_Click" />
                        <asp:Button ID="btn8" runat="server" Text="8" OnClick="btn8_Click" />
                        <asp:Button ID="btn9" runat="server" Text="9" OnClick="btn9_Click" />
                        <br />
                        <asp:Button ID="btn10" runat="server" Text="10" OnClick="btn10_Click" />
                        <asp:Button ID="btn11" runat="server" Text="11" OnClick="btn11_Click" />
                        <asp:Button ID="btn12" runat="server" Text="12" OnClick="btn12_Click" />
                    </asp:Panel>
                    <asp:Panel ID="panelkhub" Width="700" runat="server">
                        <asp:Button ID="btn13" runat="server" Text="13" OnClick="btn13_Click" />
                        <asp:Button ID="btn14" runat="server" Text="14" OnClick="btn14_Click" />
                        <asp:Button ID="btn15" runat="server" Text="15" OnClick="btn15_Click" />
                        <br />
                        <asp:Button ID="btn16" runat="server" Text="16" OnClick="btn16_Click" />
                        <asp:Button ID="btn17" runat="server" Text="17" OnClick="btn17_Click" />
                        <asp:Button ID="btn18" runat="server" Text="18" OnClick="btn18_Click" />
                        <br />
                      </asp:Panel>
                    <asp:Panel ID="pnchuyenban" Width="700" runat="server">
                        từ bàn có khách :
                        <asp:TextBox ID="txtbancu" runat="server" Width="29px"></asp:TextBox>
                        &nbsp; sang bàn trống
                        <asp:TextBox ID="txtbanmoi" runat="server" Width="46px"></asp:TextBox>
                        <asp:Button ID="btnthchuyenban" runat="server" Text="Button" OnClick="btnthchuyenban_Click" />
                        <asp:Label ID="lbtb" runat="server"></asp:Label>            
                    </asp:Panel>
                    <asp:Panel ID="pnghepban" Width="700" runat="server">
                        từ bàn có khách :
                        <asp:TextBox ID="txtbancughep" runat="server" Width="29px"></asp:TextBox>
                        &nbsp; sang bàn có khách: 
                        <asp:TextBox ID="txtbanmoighep" runat="server" Width="46px"></asp:TextBox>
                        <asp:Button ID="btnthghepban" runat="server" Text="chọn" OnClick="btnthghepban_Click" />
                        <asp:Label ID="Label3" runat="server"></asp:Label>            
                    </asp:Panel>
                     <asp:Panel ID="pntachban" runat="server">
                            Từ bàn :
                            <asp:TextBox ID="txtbantachcu" runat="server"></asp:TextBox>
                            &nbsp;<br /> sang bàn :
                            <asp:TextBox ID="txtbantachmoi" runat="server"></asp:TextBox>
                            <br />
                            <asp:Button ID="btnthchonban" runat="server" Text="Button" OnClick="btnthchonban_Click" />                           
                        </asp:Panel>
                        <asp:Panel ID="pnhoadon" Width="700" runat="server">
                            <asp:Label ID="Label6" runat="server" Text="Chọn món: "></asp:Label>
                            <asp:Label ID="lbmonselected" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="Label7" runat="server" Text="Số lượng:"></asp:Label>
                            <asp:TextBox ID="txtsl" runat="server" Width="168px"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="Error" runat="server" ControlToValidate="txtsl" ErrorMessage="Chưa điền thông tin" ForeColor="Red">*Chưa điền thông tin</asp:RequiredFieldValidator>
                            <br />
                            <asp:Button ID="btnthtach" runat="server" Text="Tách" OnClick="btnthtach_Click" />
                            <br />
                            <asp:GridView ID="gvdanhsachmon" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvdanhsachmon_SelectedIndexChanged">
                                    <Columns>
                                        <asp:BoundField DataField="MAMON" HeaderText="MÃ MÓN" />
                                        <asp:BoundField DataField="TENMON" HeaderText="TÊN MÓN" />
                                        <asp:BoundField DataField="SOLUONG" HeaderText="SỐ LƯỢNG" />
                                        <asp:BoundField DataField="THANHTIEN" HeaderText="THÀNH TIỀN" />
                                        <asp:CommandField ButtonType="Button" SelectText="Chọn" ShowSelectButton="True" />
                                    </Columns>
                                </asp:GridView>                             
                    </asp:Panel>
                   
                </td>
                <td>
                    <asp:Button ID="btnchuyenban" runat="server" Text="Chuyển bàn" OnClick="btnchuyenban_Click" />
                    <br />
                    <asp:Button ID="btntachban" runat="server" Text="Tách bàn" OnClick="btntachban_Click" />
                    <br />
                    <asp:Button ID="btnghepban" runat="server" Text="Ghép bàn" OnClick="btnghepban_Click" />
                </td>
                <td></td>
            </tr>
        </table>
    </form>
  </center>
</asp:Content>

