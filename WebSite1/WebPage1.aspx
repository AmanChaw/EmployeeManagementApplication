<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebPage1.aspx.cs" Inherits="WebPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Name:</td>
                    <td class="auto-style2">Phone:</td>
                    <td class="auto-style2">Adress</td>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonAddNew" runat="server" Text="Add New" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonEditOne" runat="server" Text="Edit" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonEditTwo" runat="server" Text="Edit" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonEditThree" runat="server" Text="Edit" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonEditFour" runat="server" Text="Edit" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonEditFive" runat="server" Text="Edit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
