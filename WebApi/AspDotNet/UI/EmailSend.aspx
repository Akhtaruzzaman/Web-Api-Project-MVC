<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmailSend.aspx.cs" Inherits="WebApi.AspDotNet.UI.EmailSend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <link href="../../Content/TagInputs.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-1.10.2.js"></script>
    <script src="../../Scripts/TagInputs.js"></script>
    
    <script type="text/javascript">
		function onAddTag(tag) {
			alert("Added a mail id: " + tag);
		}
		function onRemoveTag(tag) {
		    alert("Removed a mail id: " + tag);
		}
		function onChangeTag(input,tag) {
		    alert("Changed a mail id: " + tag);
		}
		$(function() {
		    $('#tags').tagsInput({ width: 'auto' });
		});
	</script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron">
                <div class="row">
                     <div class="col-md-3">Email ID</div>
                     <div class="col-md-9">
                         <asp:TextBox ID="tags" ClientIDMode="Static" type="text" class="form-control"  runat="server"/>
                     </div>
                </div>
                <div class="row">
                     <div class="col-md-3">Message Body</div>
                     <div class="col-md-9">
                          <asp:TextBox cols="25" rows="7" placeholder="Message Body" TextMode="MultiLine" name="tags" runat="server" ID="txtMessageBody" class="form-control"></asp:TextBox> 
                     </div>
                </div>
                <div class="row">
                     <div class="col-md-3"></div>
                     <div class="col-md-2">
                         <asp:Button type="submit" ToolTip="Send Message" title="Send" Text="Send" class="form-control btn-primary" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click"/>
                     </div>
                    <div class="col-md-7"></div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
