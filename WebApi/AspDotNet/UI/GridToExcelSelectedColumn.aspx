<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridToExcelSelectedColumn.aspx.cs" Inherits="WebApi.AspDotNet.UI.GridToExcelSelectedColumn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron">
                <div class="text-center text-success">
                    <h3>Export Selected Grid View Data To Word or Excell</h3>
                </div>
                <div>
                    <asp:GridView runat="server" ID="gbDetails" AutoGenerateColumns="False" CssClass="table table-responsive table-hover">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkSelect" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="ID" DataField="Id" />
                            <asp:BoundField HeaderText="First Name" DataField="FirstName" />
                            <asp:BoundField HeaderText="Last Name" DataField="LastName" />
                            <asp:BoundField HeaderText="Age" DataField="Age" />
                            <asp:BoundField HeaderText="Address" DataField="Address" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="row">
                    <div class="col-md-4"></div>
                    <div class="col-md-2">
                        <asp:Button ID="btnExportWord" runat="server" CssClass="form-control btn-primary" Text="Export To Word" OnClick="btnExportWord_Click" />
                    </div>
                    <div class="col-md-2">

                        <asp:Button ID="btnExportExcel" runat="server" CssClass="form-control  btn-primary" Text="Export To Excel" OnClick="btnExportExcel_Click" />
                    </div>
                    <div class="col-md-4"></div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
