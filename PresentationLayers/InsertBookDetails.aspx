<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertBookDetails.aspx.cs" Inherits="PresentationLayers.InsertBookDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <fieldset>
                <legend>Address:</legend>
                <table>
                    <tr>
                        <td>
                            <label>Title</label></td>
                        <td>
                            <asp:TextBox CssClass="form-control" ID="tbx_Title" runat="server" MaxLength="100"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="insert" ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbx_Title" ErrorMessage="Title" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Author</label></td>
                        <td>
                            <asp:TextBox CssClass="form-control" ID="tbx_Author" runat="server" MaxLength="100"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="insert" ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbx_Author" ErrorMessage="Author" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>ISBN</label></td>
                        <td>
                            <asp:TextBox CssClass="form-control" ID="tbx_ISBN" runat="server" MaxLength="12"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="insert" ID="RequiredFieldValidator6" runat="server" ControlToValidate="tbx_ISBN" ErrorMessage="ISBN" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <hr />
            <asp:Button ID="btn_insert" runat="server" OnClick="btn_insert_Click" Text="Insert" ValidationGroup="insert" />
            <asp:ValidationSummary ID="valsum" runat="server" ShowSummary="false" ShowMessageBox="true" HeaderText="Please make below fields entry valid" ValidationGroup="insert" />
            <hr />
            <a href="default.aspx">Home</a>
        </div>
    </form>
</body>
</html>
