<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjAula2DotnetWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style4 {
            display: block;
            width: 100%;
            height: calc(1.5em + .75rem + 2px);
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #495057;
            background-clip: padding-box;
            border-radius: .25rem;
            transition: none;
            border: 1px solid #ced4da;
            margin-left: 92;
            background-color: #fff;
        }
    </style>
</head>
<body>
    <div style="padding-top:2%"></div>
    <div class="col-sm-8">
    <h2>Agenda de Amigos</h2>
    </div>
    <div style="padding-top:2%"></div>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMSG" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
            
            <div class="col-sm-2">
                <div class="form-group">
                    <label for="TxtCodigo">Código</label>
                    <asp:TextBox ID="TxtCodigo" CssClass="form-control" runat="server" Width="206px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TxtNome">Nome</label>
                    <asp:TextBox ID="TxtNome" CssClass="form-control" runat="server" Width="322px"></asp:TextBox>
                </div>
                <label for="TxtTelefone">Telefone</label>
                <asp:TextBox ID="TxtTelefone" CssClass="form-control" runat="server" Width="322px"></asp:TextBox>
                <div class="form-group">
                    <label for="TxtEndereco">Endereço</label>
                    <asp:TextBox ID="TxtEndereco" CssClass="form-control" runat="server" Width="322px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="DDLCidades">Cidades</label>
                    <asp:DropDownList ID="DDLCidades" CssClass="auto-style4" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="col-sm-2">
                <div class="form-group">
                    <asp:Button ID="BtnSalvar" runat="server" CssClass="btn btn-primary" OnClick="BtnSalvar_Click" Text="Salvar" />
                </div>
            </div>
             <div class="col-sm-8">
            <asp:GridView ID="GVPessoa" CssClass="table" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Código" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                    <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                    <asp:BoundField DataField="Cidade" HeaderText="Cidade" />
                </Columns>
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
                 </div>
        </div>
    </form>
</body>
</html>
