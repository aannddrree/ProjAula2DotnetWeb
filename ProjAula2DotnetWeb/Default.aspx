<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjAula2DotnetWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 133px;
        }
        .auto-style2 {
            width: 133px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
            <asp:Label ID="lblMSG" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Código:</td>
                    <td>
                        <asp:TextBox ID="TxtCodigo" runat="server" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Nome:</td>
                    <td>
                        <asp:TextBox ID="TxtNome" runat="server" Width="322px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Telefone:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtTelefone" runat="server" Width="322px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Endereço:</td>
                    <td>
                        <asp:TextBox ID="TxtEndereco" runat="server" Width="322px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

            <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" />
            <br />
            <br />
            <asp:GridView ID="GVPessoa" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>

            <br />

        </div>
    </form>
</body>
</html>
