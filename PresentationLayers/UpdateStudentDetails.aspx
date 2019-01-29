<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudentDetails.aspx.cs" Inherits="PresentationLayers.UpdateStudentDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>Update</legend>
                <asp:DropDownList ID="ddlstudents" runat="server" OnSelectedIndexChanged="Ddlstudents_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                &nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" /><br />
                <fieldset>
                    <legend>Student Registration:</legend>
                    <table>
                        <tr>
                            <td>
                                <label>First Name</label></td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_UFname" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="update" ID="RequiredFieldValidator7" runat="server" ControlToValidate="tbx_UFname" ErrorMessage="First Name" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>Last Name</label></td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_ULname" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="update" ID="RequiredFieldValidator8" runat="server" ControlToValidate="tbx_ULname" ErrorMessage="Last Name" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>Email</label></td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_UEmail" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="update" ID="RequiredFieldValidator9" runat="server" ControlToValidate="tbx_UEmail" ErrorMessage="Email" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ValidationGroup="update" ID="RegularExpressionValidator1" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tbx_UEmail" ErrorMessage="Invalid Email" Display="None" SetFocusOnError="true"></asp:RegularExpressionValidator>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>Password</label>
                            </td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_UPassword" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="update" ID="RequiredFieldValidator10" runat="server" ControlToValidate="tbx_UPassword" ErrorMessage="Password" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>

                            </td>
                        </tr>
                    </table>
                </fieldset>
            </fieldset>
            <hr />
            <asp:Button ID="btnupdate" runat="server" OnClick="Btnupdate_Click" Text="Update" ValidationGroup="update" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowSummary="false" ShowMessageBox="true" HeaderText="Please make below fields entry valid" ValidationGroup="update" />
            <hr />
            <a href="default.aspx">Home</a>
        </div>
    </form>
</body>
</html>
