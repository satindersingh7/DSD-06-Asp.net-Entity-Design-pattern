<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PresentationLayers._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <b>
                <asp:Literal ID="ltrMessage" runat="server"></asp:Literal></b>
        </p>
        <hr />
        <fieldset>
            <legend>Menu</legend>
            <a href="InsertBookDetails.aspx">Books Details</a> | <a href="StudentRegistration.aspx">Register Student</a> | <a href="UpdateStudentDetails.aspx">Update Student Details</a> | (<a href="logout.aspx">Logout</a>)
        </fieldset>
        <hr />
        <div>
            Students<br />
            <asp:GridView ID="gridStudent" runat="server"></asp:GridView>
            <br />
            Addresses<br />
            <asp:GridView ID="gridaddress" runat="server"></asp:GridView>
            <br />
            Books Checkout
            <asp:GridView ID="gridbookscheckout" runat="server"></asp:GridView>
            <br />
            Books
            <asp:GridView ID="gridbooks" runat="server"></asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnGetData" runat="server" OnClick="BtnGetData_Click" Text="Get Data" />
            <hr />

        </div>
    </form>
</body>
</html>
