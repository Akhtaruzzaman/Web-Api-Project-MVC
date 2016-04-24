<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadDataFromExcelSheet.aspx.cs" Inherits="WebApi.AspDotNet.UI.ReadDataFromExcelSheet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>:: Import Excel File ::</title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-1.10.2.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script>
        $(document).on('change', '.btn-file :file', function () {
            var input = $(this),
                numFiles = input.get(0).files ? input.get(0).files.length : 1,
                label = input.val().replace(/\\/g, '/').replace(/.*\//, '');
            input.trigger('fileselect', [numFiles, label]);
        });

        $(document).ready(function () {
            $('.btn-file :file').on('fileselect', function (event, numFiles, label) {

                var input = $(this).parents('.input-group').find(':text'),
                    log = numFiles > 1 ? numFiles + ' files selected' : label;

                if (input.length) {
                    input.val(log);
                } else {
                    if (log) alert(log);
                }

            });
        });
        $(function() {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>
    <style>
        .btn-file {
            position: relative;
            overflow: hidden;
        }

            .btn-file input[type=file] {
                position: absolute;
                top: 0;
                right: 0;
                min-width: 100%;
                min-height: 100%;
                font-size: 100px;
                text-align: right;
                filter: alpha(opacity=0);
                opacity: 0;
                background: red;
                cursor: inherit;
                display: block;
            }

        input[readonly] {
            background-color: white !important;
            cursor: text !important;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron">
                <div class="text-center text-success">
                    <h3>Import Excel File</h3>
                </div>

                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-4">
                        <div class=" input-group ">
                            <span class="input-group-btn" data-toggle="tooltip" data-placement="top" title="Choos a Excel file">
                                <span class="btn btn-primary btn-file">Browse&hellip;
                                      <asp:FileUpload ID="fileUpload1" ClientIDMode="Static" CssClass="form-control" runat="server"
                                          accept="application/vnd.ms-excel,application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" />
                                </span>
                            </span>
                            <input type="text" class="form-control" readonly="readonly" />
                        </div>
                    </div>
                    <div class="col-md-2 input-group">
                        <asp:Button ID="btnUpload" ToolTip="Upload The File" runat="server" CssClass="form-control btn-primary" OnClick="btnUpload_Click" Text="Upload" />
                    </div>
                </div>



                <br />
                <asp:Label ID="Label1" runat="server" ClientIDMode="Static" CssClass="text-danger"></asp:Label>
                <br />
                <asp:GridView ID="gvExcelFile" runat="server" CssClass="table table-bordered" CellPadding="4" ForeColor="#000" GridLines="None">
                    <HeaderStyle CssClass="btn-danger"></HeaderStyle>
                    <RowStyle Font-Size="12px"></RowStyle>
                </asp:GridView>

            </div>
        </div>
    </form>
</body>
</html>
