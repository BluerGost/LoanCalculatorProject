<%@ Page Title="" Language="C#" MasterPageFile="~/LoanCalculator.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="LoanCalculatorProject.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="loanFormTitle" runat="server">
    Home
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="loanFormContent" runat="server">

    <asp:Button ID="bthLogin" class="btn btn-info btn-lg btn-block" runat="server" Text="Login Page" OnClick="bthLogin_Click" />
    <asp:Button ID="btnRegister" class="btn btn-info btn-lg btn-block" runat="server" Text="Register Page" OnClick="btnRegister_Click" />
    <br />
    <hr />
    <br />
   <asp:Button ID="bthDeposit" class="btn btn-danger btn-lg btn-block" runat="server" Text="Deposit Page" OnClick="bthDeposit_Click" />
   <asp:Button ID="bthTransfer" class="btn btn-danger btn-lg btn-block" runat="server" Text="Transfer Page" OnClick="bthTransfer_Click" />
   <asp:Button ID="btnInterest" class="btn btn-danger btn-lg btn-block" runat="server" Text="Interest Page" OnClick="btnInterest_Click" />
   <asp:Button ID="btnLoan" class="btn btn-danger btn-lg btn-block" runat="server" Text="Loan Page" OnClick="btnLoan_Click" />

</asp:Content>
